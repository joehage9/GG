using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SlickControls.Panels;
using SlickControls.Classes;
using SlickControls.Enums;
using GG.Classes;
using Extensions;
using GG.Customers;
using GG.Invoices;

namespace GG
{
	public partial class PC_AddCustomer : PanelContent
	{
		public Customer Customer { get; private set; } = new Customer() { ID = -1 };

		public PC_AddCustomer() : base(true)
		{
			InitializeComponent();
		}

		protected override bool LoadData()
		{
			var amps = SqlHandler.GetAmperTypes().ToArray();
			this.TryInvoke(() => DD_Ampere.Items = amps);

			var divs = SqlHandler.GetDivisions();
			this.TryInvoke(() => DD_Division.Items = divs);

			return true;
		}

		public PC_AddCustomer(Customer customer) : this()
		{
			Customer = customer;
			TB_FirstName.Text = customer.FirstName;
			TB_LastName.Text = customer.LastName;
			TB_Mobile.Text = customer.Mobile;
			TB_Address.Text = customer.Address;
			DD_Ampere.Text = customer.AmpereNumber.ToString("0.##") + " A";
			TB_Counter.Text = customer.CurrentCounter.ToString("0.##");
			DD_Division.Text = customer.Division;

			B_NewInvoice.Visible = B_ViewHistory.Visible = B_Delete.Visible = true;
			B_Save.Text = "SAVE";
			Text = "Edit Customer";
		}

		private void B_Save_Click(object sender, EventArgs e)
		{
			if (this.CheckValidation())
			{
				Customer.Active = CB_Active.Checked;
				Customer.Address = TB_Address.Text;
				Customer.AmpereNumber = DD_Ampere.Text.SmartParseD();
				Customer.CurrentCounter = TB_Counter.Text.SmartParseD();
				Customer.FirstName = TB_FirstName.Text;
				Customer.LastName = TB_LastName.Text;
				Customer.Mobile = TB_Mobile.Text;
				Customer.Division = DD_Division.Text;

				SqlHandler.SaveCustomer(Customer);

				if (Customer.ID == -1)
				{
					Notification.Create("Customer Created", $"{Customer.FirstName} {Customer.LastName} was successfully created.", PromptIcons.Info, null).Show(Form, 5);

					this.ClearForm();
					Customer = new Customer() { ID = -1 };
				}
			}
		}

		private void B_Delete_Click(object sender, EventArgs e)
		{
			if (ShowPrompt("Are you sure you want to delete this customer?", PromptButtons.YesNo, PromptIcons.Hand) == DialogResult.Yes)
			{
				try
				{
					SqlHandler.DeleteCustomer(Customer);

					Form.PushBack();
					if (Form.CurrentPanel is PC_ViewCustomers vi)
					{
						vi.Customers.Remove(Customer);
						vi.TB_Search_TextChanged(null, null);
					}
				}
				catch (Exception ex)
				{ ShowPrompt("An error occurred while deleting the customer.\n\n" + ex.Message, PromptButtons.OK, PromptIcons.Error); }
			}
		}

		private void B_NewInvoice_Click(object sender, EventArgs e)
		{
			B_Save_Click(null, null);
			Form.PushPanel(Global.MainForm.PI_NewInvoice, new PC_NewInvoice(Customer));
		}

		private void B_ViewHistory_Click(object sender, EventArgs e)
		{
			Form.PushPanel(null, new PC_ViewInvoices(Customer));
		}
	}
}
