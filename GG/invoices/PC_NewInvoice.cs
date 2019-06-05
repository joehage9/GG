using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SlickControls.Panels;
using SlickControls.Classes;
using SlickControls.Enums;
using GG.Classes;
using Extensions;
using System.Text.RegularExpressions;
using GG.Invoices;
using System.Collections.Generic;

namespace GG
{
	public partial class PC_NewInvoice : PanelContent
	{
		public Customer Customer { get; private set; }
		public Invoice Invoice { get; private set; } = new Invoice() { ID = -1 };

		public PC_NewInvoice() : base(true)
		{
			InitializeComponent();

			DD_Month.Conversion = (i) => (int)i == 0 ? "All" : new DateTime(1, i.ToString().SmartParse(), 1).ToString("MMMM");
			DD_Year.Items = SqlHandler.GetInvoiceYears();
			DD_Year.Conversion = (i) => (int)i == -1 ? "All" : i.ToString();

			DD_Month.SelectedItem = DateTime.Now.Month;
			DD_Year.SelectedItem = DateTime.Now.Year;
		}

		protected override bool LoadData()
		{
			var custs = SqlHandler.GetCustomers(false).ToArray();
			this.TryInvoke(() => DD_Customer.Items = custs);
			var amps = SqlHandler.GetAmperTypes().ToArray();
			this.TryInvoke(() => DD_Ampere.Items = amps);

			return true;
		}

		public PC_NewInvoice(Customer customer) : this()
		{
			DD_Customer.Text = customer.ToString();
		}

		public PC_NewInvoice(Invoice invoice) : this()
		{
			Invoice = invoice;
			DD_Customer.Text = invoice.Customer.ToString();
			DD_Customer.ReadOnly = true;
			TB_LastCounter.Text = Invoice.StartingCounter.ToString("0.##");
			TB_NewCounter.Text = Invoice.EndingCounter.ToString("0.##");
			DD_Year.SelectedItem = Invoice.Date.Year;
			DD_Month.SelectedItem = Invoice.Date.Month;
			TB_ExtraFee.Text = Invoice.ExtraInfo;
			TB_ExtraFeeAmount.Text = Invoice.ExtraCost.ToString();
			B_Print.Visible = B_Delete.Visible = true;
			B_Save.Text = "SAVE";
		}

		private void B_Save_Click(object sender, EventArgs e)
		{
			if (this.CheckValidation())
			{
				Invoice.CustomerID = (DD_Customer.SelectedItem as Customer).ID;
				Invoice.EndingCounter = TB_NewCounter.Text.SmartParseD();
				Invoice.StartingCounter = TB_LastCounter.Text.SmartParseD();
				Invoice.ExtraInfo = TB_ExtraFee.Text;
				Invoice.ExtraCost = TB_ExtraFeeAmount.Text.SmartParseD();

				Invoice.Date = new DateTime((int)DD_Year.SelectedItem, (int)DD_Month.SelectedItem, DateTime.Now.Day);

				SqlHandler.SaveInvoice(Invoice);

				if (Invoice.ID == -1)
				{
					Notification.Create("Invoice Created", $"Invoice for {DD_Customer.Text} was successfully created.", PromptIcons.Info, null).Show(Form, 10);

					this.ClearForm();
					Invoice = new Invoice() { ID = -1 };
				}
			}
		}

		private void B_Delete_Click(object sender, EventArgs e)
		{
			if (ShowPrompt("Are you sure you want to delete this invoice?", PromptButtons.YesNo, PromptIcons.Hand) == DialogResult.Yes)
			{
				try
				{
					SqlHandler.DeleteInvoice(Invoice);

					Form.PushBack();
					if (Form.CurrentPanel is PC_ViewInvoices vi)
					{
						vi.Invoices.Remove(Invoice);
						vi.TB_Search_TextChanged(null, null);
					}
				}
				catch (Exception ex)
				{ ShowPrompt("An error occurred while deleting the invoice\n\n" + ex.Message, PromptButtons.OK, PromptIcons.Error); }
			}
		}

		private void DD_Customer_TextChanged(object sender, EventArgs e)
		{
			var id = Regex.Match(DD_Customer.Text, "#(\\d+)$").Groups[1].Value.SmartParse(-1);

			if(id >= 0)
			{
				var customer = SqlHandler.GetCustomerById(id);
				TB_Mobile.Text = customer.Mobile;
				TB_Address.Text = customer.Address;
				DD_Ampere.Text = customer.AmpereNumber.ToString("0.##") + " A";
				TB_LastCounter.Text = customer.CurrentCounter.ToString("0.##");
			}
		}

		private void TB_NewCounter_TextChanged(object sender, EventArgs e)
		{
			var id = Regex.Match(DD_Customer.Text, "#(\\d+)$").Groups[1].Value.SmartParse(-1);

			if (id >= 0 && DD_Year.SelectedItem != null && DD_Month.SelectedItem != null)
			{
				TB_Price.Text = new InvoicePrint()
				{
					ExtraInfo = TB_ExtraFee.Text,
					ExtraCost = TB_ExtraFeeAmount.Text.SmartParseD(),
					CustAmpPrice = SqlHandler.GetInvoicePrice(id, TB_LastCounter.Text.SmartParseD(), TB_NewCounter.Text.SmartParseD(), new DateTime((int)DD_Year.SelectedItem, (int)DD_Month.SelectedItem, DateTime.Now.Day))
				}.TotPrice;
			}
		}

		private void B_Print_Click(object sender, EventArgs e)
		{
			InvoicePrint.Print(Form, SqlHandler.GetInvoicesPrint(new[] { Invoice }));
		}
	}
}
