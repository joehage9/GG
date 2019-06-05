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

namespace GG.Invoices
{
	public partial class PC_ViewInvoices : PanelContent
	{
		public List<Invoice> Invoices { get; private set; }
		public Customer Customer { get; }

		public PC_ViewInvoices() : base(true)
		{
			InitializeComponent();

			DD_Month.Conversion = (i) => (int)i == 0 ? "All" : new DateTime(1, i.ToString().SmartParse(), 1).ToString("MMMM");
			DD_Year.Items = SqlHandler.GetInvoiceYears();
			DD_Year.Conversion = (i) => (int)i == -1 ? "All" : i.ToString();

			DD_Month.SelectedItem = DateTime.Now.Month;
			DD_Year.SelectedItem = DateTime.Now.Year;
		}

		public PC_ViewInvoices(Customer customer) : this()
		{
			Customer = customer;
			Text += $" for {Customer}";
		}

		protected override bool LoadData()
		{
			Invoices = SqlHandler.GetInvoices(Customer);

			DD_Division.Items = new[] { "All" }.Concat(SqlHandler.GetDivisions()).ToArray();

			return true;
		}

		protected override void OnDataLoad() => invoiceBindingSource.DataSource = GetInvoices();

		protected override void DesignChanged(FormDesign design)
		{
			base.DesignChanged(design);

			pictureBox1.Color(design.IconColor);
		}

		public void TB_Search_TextChanged(object sender, EventArgs e)
		{
			if (Invoices != null)
				invoiceBindingSource.DataSource = GetInvoices();
		}

		private IEnumerable<Invoice> GetInvoices()
		{
			var terms = TB_Search.Text.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			return Invoices.Where(x => (DD_Year.SelectedItem == null || (int)DD_Year.SelectedItem == -1 || x.Date.Year == (int)DD_Year.SelectedItem)
				&& (DD_Month.SelectedItem == null || (int)DD_Month.SelectedItem == 0 || x.Date.Month == (int)DD_Month.SelectedItem)
				&& (string.IsNullOrWhiteSpace(TB_Search.Text) || Search(x, terms))
				&& (DD_Division.Text == "All" || x.CustDivision == DD_Division.Text));
		}

		private bool Search(Invoice arg, string[] terms)
		{
			return terms.All(t =>
				arg.Customer.ToString().ToLower().Contains(t) ||
				arg.Date.ToString().Contains(t) ||
				arg.StartingCounter.ToString().Contains(t) ||
				arg.EndingCounter.ToString().Contains(t) ||
				arg.Price.ToString().Contains(t) ||
				arg.ID.ToString().Contains(t)
			);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
			{
				Form.PushPanel(null, new PC_NewInvoice(dataGridView1.Rows[e.RowIndex].DataBoundItem as Invoice));
			}
		}

        private void B_Print_Click(object sender, EventArgs e)
        {
            InvoicePrint.Print(Form, SqlHandler.GetInvoicesPrint(GetInvoices()));
        }
    }
}
