namespace GG
{
    partial class PC_AddCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC_AddCustomer));
			this.slickSectionPanel1 = new SlickControls.Controls.SlickSectionPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_FirstName = new SlickControls.Controls.SlickTextBox();
			this.TB_LastName = new SlickControls.Controls.SlickTextBox();
			this.TB_Mobile = new SlickControls.Controls.SlickTextBox();
			this.TB_Address = new SlickControls.Controls.SlickTextBox();
			this.slickSectionPanel2 = new SlickControls.Controls.SlickSectionPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_Counter = new SlickControls.Controls.SlickTextBox();
			this.DD_Ampere = new SlickControls.Controls.SlickDropdown();
			this.CB_Active = new SlickControls.Controls.SlickCheckbox();
			this.B_Save = new SlickControls.Controls.SlickButton();
			this.B_Delete = new SlickControls.Controls.SlickButton();
			this.B_NewInvoice = new SlickControls.Controls.SlickButton();
			this.B_ViewHistory = new SlickControls.Controls.SlickButton();
			this.DD_Division = new SlickControls.Controls.SlickDropdown();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CB_Active)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_NewInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_ViewHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// slickSectionPanel1
			// 
			this.slickSectionPanel1.Active = false;
			this.slickSectionPanel1.AutoHide = false;
			this.slickSectionPanel1.AutoSize = true;
			this.slickSectionPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.slickSectionPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.slickSectionPanel1.Flavor = null;
			this.slickSectionPanel1.Icon = null;
			this.slickSectionPanel1.Info = "";
			this.slickSectionPanel1.Location = new System.Drawing.Point(5, 30);
			this.slickSectionPanel1.MaximumSize = new System.Drawing.Size(9999, 54);
			this.slickSectionPanel1.Name = "slickSectionPanel1";
			this.slickSectionPanel1.Size = new System.Drawing.Size(880, 54);
			this.slickSectionPanel1.TabIndex = 13;
			this.slickSectionPanel1.Text = "Client Info";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.DD_Division, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.TB_FirstName, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.TB_LastName, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.TB_Mobile, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.TB_Address, 0, 3);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 84);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(880, 240);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// TB_FirstName
			// 
			this.TB_FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_FirstName.Image = null;
			this.TB_FirstName.LabelText = "First Name";
			this.TB_FirstName.Location = new System.Drawing.Point(40, 7);
			this.TB_FirstName.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_FirstName.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_FirstName.MaxLength = 32767;
			this.TB_FirstName.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_FirstName.Name = "TB_FirstName";
			this.TB_FirstName.Password = false;
			this.TB_FirstName.Placeholder = "First Name";
			this.TB_FirstName.ReadOnly = false;
			this.TB_FirstName.Required = true;
			this.TB_FirstName.SelectAllOnFocus = false;
			this.TB_FirstName.SelectedText = "";
			this.TB_FirstName.SelectionLength = 0;
			this.TB_FirstName.SelectionStart = 0;
			this.TB_FirstName.Size = new System.Drawing.Size(690, 34);
			this.TB_FirstName.TabIndex = 0;
			this.TB_FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_FirstName.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_FirstName.ValidationRegex = "";
			// 
			// TB_LastName
			// 
			this.TB_LastName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_LastName.Image = null;
			this.TB_LastName.LabelText = "Last Name";
			this.TB_LastName.Location = new System.Drawing.Point(40, 55);
			this.TB_LastName.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_LastName.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_LastName.MaxLength = 32767;
			this.TB_LastName.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_LastName.Name = "TB_LastName";
			this.TB_LastName.Password = false;
			this.TB_LastName.Placeholder = "Last Name";
			this.TB_LastName.ReadOnly = false;
			this.TB_LastName.Required = true;
			this.TB_LastName.SelectAllOnFocus = false;
			this.TB_LastName.SelectedText = "";
			this.TB_LastName.SelectionLength = 0;
			this.TB_LastName.SelectionStart = 0;
			this.TB_LastName.Size = new System.Drawing.Size(690, 34);
			this.TB_LastName.TabIndex = 0;
			this.TB_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_LastName.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_LastName.ValidationRegex = "";
			// 
			// TB_Mobile
			// 
			this.TB_Mobile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Mobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Mobile.Image = null;
			this.TB_Mobile.LabelText = "Phone Number";
			this.TB_Mobile.Location = new System.Drawing.Point(40, 103);
			this.TB_Mobile.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Mobile.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Mobile.MaxLength = 32767;
			this.TB_Mobile.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Mobile.Name = "TB_Mobile";
			this.TB_Mobile.Password = false;
			this.TB_Mobile.Placeholder = "Phone Number";
			this.TB_Mobile.ReadOnly = false;
			this.TB_Mobile.Required = true;
			this.TB_Mobile.SelectAllOnFocus = false;
			this.TB_Mobile.SelectedText = "";
			this.TB_Mobile.SelectionLength = 0;
			this.TB_Mobile.SelectionStart = 0;
			this.TB_Mobile.Size = new System.Drawing.Size(690, 34);
			this.TB_Mobile.TabIndex = 0;
			this.TB_Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Mobile.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_Mobile.ValidationRegex = "";
			// 
			// TB_Address
			// 
			this.TB_Address.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Address.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Address.Image = null;
			this.TB_Address.LabelText = "Address";
			this.TB_Address.Location = new System.Drawing.Point(40, 151);
			this.TB_Address.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Address.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Address.MaxLength = 32767;
			this.TB_Address.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Address.Name = "TB_Address";
			this.TB_Address.Password = false;
			this.TB_Address.Placeholder = "Address";
			this.TB_Address.ReadOnly = false;
			this.TB_Address.Required = true;
			this.TB_Address.SelectAllOnFocus = false;
			this.TB_Address.SelectedText = "";
			this.TB_Address.SelectionLength = 0;
			this.TB_Address.SelectionStart = 0;
			this.TB_Address.Size = new System.Drawing.Size(690, 34);
			this.TB_Address.TabIndex = 0;
			this.TB_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Address.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_Address.ValidationRegex = "";
			// 
			// slickSectionPanel2
			// 
			this.slickSectionPanel2.Active = false;
			this.slickSectionPanel2.AutoHide = false;
			this.slickSectionPanel2.AutoSize = true;
			this.slickSectionPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.slickSectionPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.slickSectionPanel2.Flavor = null;
			this.slickSectionPanel2.Icon = null;
			this.slickSectionPanel2.Info = "";
			this.slickSectionPanel2.Location = new System.Drawing.Point(5, 324);
			this.slickSectionPanel2.MaximumSize = new System.Drawing.Size(9999, 54);
			this.slickSectionPanel2.Name = "slickSectionPanel2";
			this.slickSectionPanel2.Size = new System.Drawing.Size(880, 54);
			this.slickSectionPanel2.TabIndex = 15;
			this.slickSectionPanel2.Text = "Client Subscription";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.TB_Counter, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.DD_Ampere, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.CB_Active, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 378);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(880, 136);
			this.tableLayoutPanel4.TabIndex = 16;
			// 
			// TB_Counter
			// 
			this.TB_Counter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Counter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Counter.Image = null;
			this.TB_Counter.LabelText = "Current Counter";
			this.TB_Counter.Location = new System.Drawing.Point(40, 95);
			this.TB_Counter.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Counter.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Counter.MaxLength = 32767;
			this.TB_Counter.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Counter.Name = "TB_Counter";
			this.TB_Counter.Password = false;
			this.TB_Counter.Placeholder = "Current Counter";
			this.TB_Counter.ReadOnly = false;
			this.TB_Counter.Required = true;
			this.TB_Counter.SelectAllOnFocus = false;
			this.TB_Counter.SelectedText = "";
			this.TB_Counter.SelectionLength = 0;
			this.TB_Counter.SelectionStart = 0;
			this.TB_Counter.Size = new System.Drawing.Size(690, 34);
			this.TB_Counter.TabIndex = 2;
			this.TB_Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Counter.Validation = SlickControls.Enums.ValidationType.Decimal;
			this.TB_Counter.ValidationRegex = "";
			// 
			// DD_Ampere
			// 
			this.DD_Ampere.Conversion = null;
			this.DD_Ampere.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Ampere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Ampere.Image = ((System.Drawing.Image)(resources.GetObject("DD_Ampere.Image")));
			this.DD_Ampere.Items = null;
			this.DD_Ampere.LabelText = "Amper Type";
			this.DD_Ampere.Location = new System.Drawing.Point(40, 47);
			this.DD_Ampere.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Ampere.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Ampere.MaxLength = 32767;
			this.DD_Ampere.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Ampere.Name = "DD_Ampere";
			this.DD_Ampere.Password = false;
			this.DD_Ampere.Placeholder = "Amper Type";
			this.DD_Ampere.ReadOnly = false;
			this.DD_Ampere.Required = true;
			this.DD_Ampere.SelectAllOnFocus = false;
			this.DD_Ampere.SelectedItem = null;
			this.DD_Ampere.SelectedText = "";
			this.DD_Ampere.SelectionLength = 0;
			this.DD_Ampere.SelectionStart = 0;
			this.DD_Ampere.Size = new System.Drawing.Size(690, 34);
			this.DD_Ampere.TabIndex = 0;
			this.DD_Ampere.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Ampere.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Ampere.ValidationRegex = "";
			// 
			// CB_Active
			// 
			this.CB_Active.ActiveColor = null;
			this.CB_Active.Center = false;
			this.CB_Active.Checked = true;
			this.CB_Active.CheckedText = null;
			this.CB_Active.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CB_Active.DefaultValue = true;
			this.CB_Active.HideText = false;
			this.CB_Active.HoverState = SlickControls.Enums.HoverState.Normal;
			this.CB_Active.IconSize = 16;
			this.CB_Active.Image = ((System.Drawing.Image)(resources.GetObject("CB_Active.Image")));
			this.CB_Active.Location = new System.Drawing.Point(40, 7);
			this.CB_Active.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.CB_Active.Name = "CB_Active";
			this.CB_Active.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
			this.CB_Active.Size = new System.Drawing.Size(125, 26);
			this.CB_Active.TabIndex = 1;
			this.CB_Active.TabStop = false;
			this.CB_Active.Text = "Active Customer";
			this.CB_Active.UncheckedText = null;
			this.CB_Active.UseToggleIcon = false;
			// 
			// B_Save
			// 
			this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Save.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Save.ColorShade = null;
			this.B_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Save.IconSize = 16;
			this.B_Save.Image = ((System.Drawing.Image)(resources.GetObject("B_Save.Image")));
			this.B_Save.Location = new System.Drawing.Point(770, 523);
			this.B_Save.Margin = new System.Windows.Forms.Padding(0);
			this.B_Save.Name = "B_Save";
			this.B_Save.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Save.Size = new System.Drawing.Size(100, 30);
			this.B_Save.TabIndex = 17;
			this.B_Save.Text = "CREATE";
			this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
			// 
			// B_Delete
			// 
			this.B_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.B_Delete.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Delete.ColorShade = null;
			this.B_Delete.ColorStyle = Extensions.ColorStyle.Red;
			this.B_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Delete.IconSize = 16;
			this.B_Delete.Image = ((System.Drawing.Image)(resources.GetObject("B_Delete.Image")));
			this.B_Delete.Location = new System.Drawing.Point(15, 523);
			this.B_Delete.Margin = new System.Windows.Forms.Padding(0);
			this.B_Delete.Name = "B_Delete";
			this.B_Delete.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Delete.Size = new System.Drawing.Size(100, 30);
			this.B_Delete.TabIndex = 17;
			this.B_Delete.Text = "DELETE";
			this.B_Delete.Visible = false;
			this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
			// 
			// B_NewInvoice
			// 
			this.B_NewInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_NewInvoice.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_NewInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_NewInvoice.ColorShade = null;
			this.B_NewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_NewInvoice.IconSize = 16;
			this.B_NewInvoice.Image = ((System.Drawing.Image)(resources.GetObject("B_NewInvoice.Image")));
			this.B_NewInvoice.Location = new System.Drawing.Point(625, 523);
			this.B_NewInvoice.Margin = new System.Windows.Forms.Padding(0);
			this.B_NewInvoice.Name = "B_NewInvoice";
			this.B_NewInvoice.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_NewInvoice.Size = new System.Drawing.Size(130, 30);
			this.B_NewInvoice.TabIndex = 17;
			this.B_NewInvoice.Text = "NEW INVOICE";
			this.B_NewInvoice.Visible = false;
			this.B_NewInvoice.Click += new System.EventHandler(this.B_NewInvoice_Click);
			// 
			// B_ViewHistory
			// 
			this.B_ViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_ViewHistory.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_ViewHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_ViewHistory.ColorShade = null;
			this.B_ViewHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_ViewHistory.IconSize = 16;
			this.B_ViewHistory.Image = ((System.Drawing.Image)(resources.GetObject("B_ViewHistory.Image")));
			this.B_ViewHistory.Location = new System.Drawing.Point(480, 523);
			this.B_ViewHistory.Margin = new System.Windows.Forms.Padding(0);
			this.B_ViewHistory.Name = "B_ViewHistory";
			this.B_ViewHistory.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_ViewHistory.Size = new System.Drawing.Size(130, 30);
			this.B_ViewHistory.TabIndex = 17;
			this.B_ViewHistory.Text = "VIEW HISTORY";
			this.B_ViewHistory.Visible = false;
			this.B_ViewHistory.Click += new System.EventHandler(this.B_ViewHistory_Click);
			// 
			// DD_Division
			// 
			this.DD_Division.Conversion = null;
			this.DD_Division.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Division.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Division.Image = ((System.Drawing.Image)(resources.GetObject("DD_Division.Image")));
			this.DD_Division.Items = null;
			this.DD_Division.LabelText = "Customer Division";
			this.DD_Division.Location = new System.Drawing.Point(40, 199);
			this.DD_Division.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Division.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Division.MaxLength = 32767;
			this.DD_Division.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Division.Name = "DD_Division";
			this.DD_Division.Password = false;
			this.DD_Division.Placeholder = "Division";
			this.DD_Division.ReadOnly = false;
			this.DD_Division.Required = true;
			this.DD_Division.SelectAllOnFocus = false;
			this.DD_Division.SelectedItem = null;
			this.DD_Division.SelectedText = "";
			this.DD_Division.SelectionLength = 0;
			this.DD_Division.SelectionStart = 0;
			this.DD_Division.Size = new System.Drawing.Size(690, 34);
			this.DD_Division.TabIndex = 1;
			this.DD_Division.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Division.Validation = SlickControls.Enums.ValidationType.Custom;
			this.DD_Division.ValidationRegex = "";
			// 
			// PC_AddCustomer
			// 
			this.AcceptButton = this.B_Save;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.B_Delete);
			this.Controls.Add(this.B_ViewHistory);
			this.Controls.Add(this.B_NewInvoice);
			this.Controls.Add(this.B_Save);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.slickSectionPanel2);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.slickSectionPanel1);
			this.Name = "PC_AddCustomer";
			this.Size = new System.Drawing.Size(890, 568);
			this.Text = "New Customer";
			this.Controls.SetChildIndex(this.slickSectionPanel1, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
			this.Controls.SetChildIndex(this.slickSectionPanel2, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
			this.Controls.SetChildIndex(this.B_Save, 0);
			this.Controls.SetChildIndex(this.B_NewInvoice, 0);
			this.Controls.SetChildIndex(this.B_ViewHistory, 0);
			this.Controls.SetChildIndex(this.B_Delete, 0);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CB_Active)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_NewInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_ViewHistory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private SlickControls.Controls.SlickSectionPanel slickSectionPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private SlickControls.Controls.SlickTextBox TB_FirstName;
		private SlickControls.Controls.SlickTextBox TB_LastName;
		private SlickControls.Controls.SlickTextBox TB_Mobile;
		private SlickControls.Controls.SlickTextBox TB_Address;
		private SlickControls.Controls.SlickSectionPanel slickSectionPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private SlickControls.Controls.SlickDropdown DD_Ampere;
		private SlickControls.Controls.SlickButton B_Save;
		private SlickControls.Controls.SlickButton B_Delete;
		private SlickControls.Controls.SlickButton B_NewInvoice;
		private SlickControls.Controls.SlickButton B_ViewHistory;
		private SlickControls.Controls.SlickCheckbox CB_Active;
		private SlickControls.Controls.SlickTextBox TB_Counter;
		private SlickControls.Controls.SlickDropdown DD_Division;
	}
}