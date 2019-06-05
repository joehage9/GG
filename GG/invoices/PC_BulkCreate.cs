using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlickControls.Panels;
using GG.Classes;
using Extensions;
using SlickControls.Classes;

namespace GG.Invoices
{
	public partial class PC_BulkCreate : PanelContent
	{
		public List<Customer> Customers { get; }

		public PC_BulkCreate() : base(true)
		{
			InitializeComponent();

			customerBindingSource.DataSource = Customers = SqlHandler.GetCustomers().Where(x => x.Active).ToList();

			DT_From.Value = Customers.Min(x => x.LastInvoiceDate);
			DT_From.DefaultValue = DT_To.MinimumValue = DT_From.MinimumValue =  DateTime.MinValue;
			DT_To.Value = DT_To.DefaultValue = DateTime.Today;

			DD_Month.Conversion = (i) => (int)i == 0 ? "All" : new DateTime(1, i.ToString().SmartParse(), 1).ToString("MMMM");
			DD_Year.Items = SqlHandler.GetInvoiceYears();
			DD_Year.Conversion = (i) => (int)i == -1 ? "All" : i.ToString();

			DD_Month.SelectedItem = DateTime.Now.Month;
			DD_Year.SelectedItem = DateTime.Now.Year;
		}

		protected override bool LoadData()
		{
			DD_Division.Items = new[] { "All" }.Concat(SqlHandler.GetDivisions()).ToArray();

			return true;
		}

		protected override void DesignChanged(FormDesign design)
		{
			base.DesignChanged(design);

			pictureBox1.Color(design.IconColor);
			panel1.BackColor = design.AccentColor;
		}

		private void TB_Search_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TB_Search.Text))
				customerBindingSource.DataSource = Customers.Where(arg => (arg.LastInvoiceDate >= DT_From.Value && arg.LastInvoiceDate <= DT_To.Value) && (DD_Division.Text == "All" || arg.Division == DD_Division.Text));
			else
			{
				var terms = TB_Search.Text.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				customerBindingSource.DataSource = Customers.Where(x => Search(x, terms));
			}
		}

		private bool Search(Customer arg, string[] terms)
		{
			return (arg.LastInvoiceDate >= DT_From.Value && arg.LastInvoiceDate <= DT_To.Value) &&
				(DD_Division.Text == "All" || arg.Division == DD_Division.Text) &&
				terms.All(t =>
				arg.FirstName.ToLower().Contains(t) ||
				arg.LastName.ToLower().Contains(t) ||
				arg.Address.ToLower().Contains(t) ||
				arg.Mobile.ToLower().Contains(t) ||
				arg.Division.ToLower().Contains(t) ||
				arg.AmpereNumber.ToString().Contains(t) ||
				arg.ID.ToString().Contains(t)
			);
		}

		private void B_Save_Click(object sender, EventArgs e)
		{
			Save(false);
		}

		private void B_Print_Click(object sender, EventArgs e)
		{
			Save(true);
		}

		private void Save(bool print)
		{
			B_Print.Enabled = B_Save.Enabled = false;
			var notif = Notification.Create("Creating Invoices", "Gathering required information..", SlickControls.Enums.PromptIcons.Info, null).Show(Form);

			new Action(() =>
			{
				var invs = new List<int>();
				System.Threading.Thread.Sleep(1000);

				foreach (var cust in Customers.Where(x => x.NewCounter > x.CurrentCounter))
				{
					notif.SetText(cust.ToString());
					invs.Add(SqlHandler.SaveInvoice(new Invoice()
					{
						CustomerID = cust.ID,
						StartingCounter = cust.CurrentCounter,
						EndingCounter = cust.NewCounter,
						Date = new DateTime((int)DD_Year.SelectedItem, (int)DD_Month.SelectedItem, DateTime.Today.Day)
					}));

					System.Threading.Thread.Sleep(75);
				}

				notif.Close();
				this.TryInvoke(() =>
				{
					B_Print.Enabled = B_Save.Enabled = true;

					if (print)
					{
						InvoicePrint.Print(Form, SqlHandler.GetInvoicesPrint(invs.Select(x => new Invoice() { ID = x })));
					}
				});
			}).RunInBackground();
		}
	}
}
