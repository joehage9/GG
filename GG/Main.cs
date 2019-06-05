using System;
using System.Drawing;
using System.Windows.Forms;
using GG.Customers;
using GG.Invoices;
using GG.Tariffs;
using SlickControls.Forms;
using SlickControls.Panels;

namespace GG
{
	public partial class Main : BasePanelForm
	{
		public Main()
		{
			InitializeComponent();
			Global.MainForm = this;
			SetPanel<PC_ViewInvoices>(PI_Invoices);
		}

		private void PI_AddCustomer_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_AddCustomer>(PI_AddCustomer);
		}

		private void PI_ViewCustomer_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_ViewCustomers>(PI_ViewCustomer);
		}

		private void PI_Tarrifs_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_Tarrifs>(PI_Tarrifs);
		}

		private void PI_Invoices_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_ViewInvoices>(PI_Invoices);
		}

		private void PI_NewInvoice_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_NewInvoice>(PI_NewInvoice);
		}

		private void PI_BulkInvoice_OnClick(object sender, MouseEventArgs e)
		{
			SetPanel<PC_BulkCreate>(PI_BulkInvoice);
		}
	}
}
