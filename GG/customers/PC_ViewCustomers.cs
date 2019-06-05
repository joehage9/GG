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

namespace GG.Customers
{
	public partial class PC_ViewCustomers : PanelContent
	{
		public List<Customer> Customers { get; }

		public PC_ViewCustomers() : base(true)
		{
			InitializeComponent();

			customerBindingSource.DataSource = Customers = SqlHandler.GetCustomers();
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
		}

		public void TB_Search_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(TB_Search.Text))
				customerBindingSource.DataSource = Customers.Where(arg => DD_Division.Text == "All" || arg.Division == DD_Division.Text);
			else
			{
				var terms = TB_Search.Text.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				customerBindingSource.DataSource = Customers.Where(x => Search(x, terms));
			}
		}

		private bool Search(Customer arg, string[] terms)
		{
			return (DD_Division.Text == "All" || arg.Division == DD_Division.Text) && 
				terms.All(t =>
				arg.FirstName.ToLower().Contains(t) ||
				arg.LastName.ToLower().Contains(t) ||
				arg.Address.ToLower().Contains(t) ||
				arg.Division.ToLower().Contains(t) ||
				arg.Mobile.ToLower().Contains(t) ||
				arg.AmpereNumber.ToString().Contains(t) ||
				arg.ID.ToString().Contains(t)
			);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
			{
				Form.PushPanel(null, new PC_AddCustomer(dataGridView1.Rows[e.RowIndex].DataBoundItem as Customer));
			}
		}
	}
}
