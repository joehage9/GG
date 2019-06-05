namespace GG
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.PI_AddCustomer = new SlickControls.Panels.PanelItem();
			this.PI_ViewCustomer = new SlickControls.Panels.PanelItem();
			this.PI_Invoices = new SlickControls.Panels.PanelItem();
			this.PI_Tarrifs = new SlickControls.Panels.PanelItem();
			this.PI_NewInvoice = new SlickControls.Panels.PanelItem();
			this.PI_BulkInvoice = new SlickControls.Panels.PanelItem();
			this.base_P_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.base_PB_Icon)).BeginInit();
			this.SuspendLayout();
			// 
			// base_P_Content
			// 
			this.base_P_Content.Size = new System.Drawing.Size(981, 561);
			// 
			// base_P_SideControls
			// 
			this.base_P_SideControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(129)))), ((int)(((byte)(150)))));
			this.base_P_SideControls.Location = new System.Drawing.Point(0, 441);
			// 
			// base_P_Container
			// 
			this.base_P_Container.Size = new System.Drawing.Size(983, 563);
			// 
			// base_PB_Icon
			// 
			this.base_PB_Icon.Image = ((System.Drawing.Image)(resources.GetObject("base_PB_Icon.Image")));
			// 
			// PI_AddCustomer
			// 
			this.PI_AddCustomer.ForceReopen = false;
			this.PI_AddCustomer.Group = "Customers";
			this.PI_AddCustomer.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_AddCustomer.Icon")));
			this.PI_AddCustomer.Selected = false;
			this.PI_AddCustomer.Text = "Add Customer";
			this.PI_AddCustomer.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_AddCustomer_OnClick);
			// 
			// PI_ViewCustomer
			// 
			this.PI_ViewCustomer.ForceReopen = false;
			this.PI_ViewCustomer.Group = "Customers";
			this.PI_ViewCustomer.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_ViewCustomer.Icon")));
			this.PI_ViewCustomer.Selected = false;
			this.PI_ViewCustomer.Text = "View Customers";
			this.PI_ViewCustomer.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_ViewCustomer_OnClick);
			// 
			// PI_Invoices
			// 
			this.PI_Invoices.ForceReopen = false;
			this.PI_Invoices.Group = "Invoices";
			this.PI_Invoices.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_Invoices.Icon")));
			this.PI_Invoices.Selected = false;
			this.PI_Invoices.Text = "View Invoices";
			this.PI_Invoices.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_Invoices_OnClick);
			// 
			// PI_Tarrifs
			// 
			this.PI_Tarrifs.ForceReopen = false;
			this.PI_Tarrifs.Group = "Options";
			this.PI_Tarrifs.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_Tarrifs.Icon")));
			this.PI_Tarrifs.Selected = false;
			this.PI_Tarrifs.Text = "Tariffs";
			this.PI_Tarrifs.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_Tarrifs_OnClick);
			// 
			// PI_NewInvoice
			// 
			this.PI_NewInvoice.ForceReopen = false;
			this.PI_NewInvoice.Group = "Invoices";
			this.PI_NewInvoice.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_NewInvoice.Icon")));
			this.PI_NewInvoice.Selected = false;
			this.PI_NewInvoice.Text = "New Invoice";
			this.PI_NewInvoice.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_NewInvoice_OnClick);
			// 
			// PI_BulkInvoice
			// 
			this.PI_BulkInvoice.ForceReopen = false;
			this.PI_BulkInvoice.Group = "Invoices";
			this.PI_BulkInvoice.Icon = ((System.Drawing.Bitmap)(resources.GetObject("PI_BulkInvoice.Icon")));
			this.PI_BulkInvoice.Selected = false;
			this.PI_BulkInvoice.Text = "Bulk Create";
			this.PI_BulkInvoice.OnClick += new System.Windows.Forms.MouseEventHandler(this.PI_BulkInvoice_OnClick);
			// 
			// Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1000, 580);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
			this.FormIcon = ((System.Drawing.Image)(resources.GetObject("$this.FormIcon")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3);
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "Main";
			this.SidebarItems = new SlickControls.Panels.PanelItem[] {
        this.PI_AddCustomer,
        this.PI_ViewCustomer,
        this.PI_NewInvoice,
        this.PI_BulkInvoice,
        this.PI_Invoices,
        this.PI_Tarrifs};
			this.Text = "GG";
			this.base_P_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.base_PB_Icon)).EndInit();
			this.ResumeLayout(false);

        }
        #endregion
		public SlickControls.Panels.PanelItem PI_AddCustomer;
		public SlickControls.Panels.PanelItem PI_ViewCustomer;
		private SlickControls.Panels.PanelItem PI_Invoices;
		public SlickControls.Panels.PanelItem PI_Tarrifs;
		public SlickControls.Panels.PanelItem PI_NewInvoice;
		private SlickControls.Panels.PanelItem PI_BulkInvoice;
	}
}



