namespace GG
{
    partial class PC_NewInvoice
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC_NewInvoice));
			this.slickSectionPanel1 = new SlickControls.Controls.SlickSectionPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.DD_Customer = new SlickControls.Controls.SlickDropdown();
			this.TB_Mobile = new SlickControls.Controls.SlickTextBox();
			this.TB_Address = new SlickControls.Controls.SlickTextBox();
			this.slickSectionPanel2 = new SlickControls.Controls.SlickSectionPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_ExtraFee = new SlickControls.Controls.SlickTextBox();
			this.TB_ExtraFeeAmount = new SlickControls.Controls.SlickTextBox();
			this.DD_Month = new SlickControls.Controls.SlickDropdown();
			this.DD_Year = new SlickControls.Controls.SlickDropdown();
			this.TB_Price = new SlickControls.Controls.SlickTextBox();
			this.TB_NewCounter = new SlickControls.Controls.SlickTextBox();
			this.TB_LastCounter = new SlickControls.Controls.SlickTextBox();
			this.DD_Ampere = new SlickControls.Controls.SlickDropdown();
			this.B_Save = new SlickControls.Controls.SlickButton();
			this.B_Delete = new SlickControls.Controls.SlickButton();
			this.B_Print = new SlickControls.Controls.SlickButton();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).BeginInit();
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
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.DD_Customer, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.TB_Mobile, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.TB_Address, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 84);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(880, 96);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// DD_Customer
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.DD_Customer, 2);
			this.DD_Customer.Conversion = null;
			this.DD_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Customer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Customer.Image = ((System.Drawing.Image)(resources.GetObject("DD_Customer.Image")));
			this.DD_Customer.Items = null;
			this.DD_Customer.LabelText = "Customer";
			this.DD_Customer.Location = new System.Drawing.Point(40, 7);
			this.DD_Customer.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Customer.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Customer.MaxLength = 32767;
			this.DD_Customer.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Customer.Name = "DD_Customer";
			this.DD_Customer.Password = false;
			this.DD_Customer.Placeholder = "Customer";
			this.DD_Customer.ReadOnly = false;
			this.DD_Customer.Required = true;
			this.DD_Customer.SelectAllOnFocus = false;
			this.DD_Customer.SelectedItem = null;
			this.DD_Customer.SelectedText = "";
			this.DD_Customer.SelectionLength = 0;
			this.DD_Customer.SelectionStart = 0;
			this.DD_Customer.Size = new System.Drawing.Size(690, 34);
			this.DD_Customer.TabIndex = 1;
			this.DD_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Customer.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Customer.ValidationRegex = "";
			this.DD_Customer.TextChanged += new System.EventHandler(this.DD_Customer_TextChanged);
			// 
			// TB_Mobile
			// 
			this.TB_Mobile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Mobile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Mobile.Image = null;
			this.TB_Mobile.LabelText = "Phone Number";
			this.TB_Mobile.Location = new System.Drawing.Point(40, 55);
			this.TB_Mobile.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Mobile.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Mobile.MaxLength = 32767;
			this.TB_Mobile.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Mobile.Name = "TB_Mobile";
			this.TB_Mobile.Password = false;
			this.TB_Mobile.Placeholder = "Phone Number";
			this.TB_Mobile.ReadOnly = true;
			this.TB_Mobile.Required = false;
			this.TB_Mobile.SelectAllOnFocus = false;
			this.TB_Mobile.SelectedText = "";
			this.TB_Mobile.SelectionLength = 0;
			this.TB_Mobile.SelectionStart = 0;
			this.TB_Mobile.Size = new System.Drawing.Size(250, 34);
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
			this.TB_Address.Location = new System.Drawing.Point(480, 55);
			this.TB_Address.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Address.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Address.MaxLength = 32767;
			this.TB_Address.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Address.Name = "TB_Address";
			this.TB_Address.Password = false;
			this.TB_Address.Placeholder = "Address";
			this.TB_Address.ReadOnly = true;
			this.TB_Address.Required = false;
			this.TB_Address.SelectAllOnFocus = false;
			this.TB_Address.SelectedText = "";
			this.TB_Address.SelectionLength = 0;
			this.TB_Address.SelectionStart = 0;
			this.TB_Address.Size = new System.Drawing.Size(250, 34);
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
			this.slickSectionPanel2.Location = new System.Drawing.Point(5, 180);
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
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.TB_ExtraFee, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.TB_ExtraFeeAmount, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.DD_Month, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.DD_Year, 1, 2);
			this.tableLayoutPanel4.Controls.Add(this.TB_Price, 0, 4);
			this.tableLayoutPanel4.Controls.Add(this.TB_NewCounter, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.TB_LastCounter, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.DD_Ampere, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 234);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 5;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(880, 240);
			this.tableLayoutPanel4.TabIndex = 16;
			// 
			// TB_ExtraFee
			// 
			this.TB_ExtraFee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_ExtraFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_ExtraFee.Image = null;
			this.TB_ExtraFee.LabelText = "Extra Fee Info";
			this.TB_ExtraFee.Location = new System.Drawing.Point(40, 151);
			this.TB_ExtraFee.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_ExtraFee.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_ExtraFee.MaxLength = 32767;
			this.TB_ExtraFee.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_ExtraFee.Name = "TB_ExtraFee";
			this.TB_ExtraFee.Password = false;
			this.TB_ExtraFee.Placeholder = "Extra Fee Text";
			this.TB_ExtraFee.ReadOnly = false;
			this.TB_ExtraFee.Required = false;
			this.TB_ExtraFee.SelectAllOnFocus = false;
			this.TB_ExtraFee.SelectedText = "";
			this.TB_ExtraFee.SelectionLength = 0;
			this.TB_ExtraFee.SelectionStart = 0;
			this.TB_ExtraFee.Size = new System.Drawing.Size(250, 34);
			this.TB_ExtraFee.TabIndex = 7;
			this.TB_ExtraFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_ExtraFee.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_ExtraFee.ValidationRegex = "";
			this.TB_ExtraFee.TextChanged += new System.EventHandler(this.TB_NewCounter_TextChanged);
			// 
			// TB_ExtraFeeAmount
			// 
			this.TB_ExtraFeeAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_ExtraFeeAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_ExtraFeeAmount.Image = null;
			this.TB_ExtraFeeAmount.LabelText = "Extra Fee Amount";
			this.TB_ExtraFeeAmount.Location = new System.Drawing.Point(480, 151);
			this.TB_ExtraFeeAmount.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_ExtraFeeAmount.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_ExtraFeeAmount.MaxLength = 32767;
			this.TB_ExtraFeeAmount.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_ExtraFeeAmount.Name = "TB_ExtraFeeAmount";
			this.TB_ExtraFeeAmount.Password = false;
			this.TB_ExtraFeeAmount.Placeholder = "Extra Fee Amount";
			this.TB_ExtraFeeAmount.ReadOnly = false;
			this.TB_ExtraFeeAmount.Required = true;
			this.TB_ExtraFeeAmount.SelectAllOnFocus = false;
			this.TB_ExtraFeeAmount.SelectedText = "";
			this.TB_ExtraFeeAmount.SelectionLength = 0;
			this.TB_ExtraFeeAmount.SelectionStart = 0;
			this.TB_ExtraFeeAmount.Size = new System.Drawing.Size(250, 34);
			this.TB_ExtraFeeAmount.TabIndex = 6;
			this.TB_ExtraFeeAmount.Text = "0";
			this.TB_ExtraFeeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_ExtraFeeAmount.Validation = SlickControls.Enums.ValidationType.Decimal;
			this.TB_ExtraFeeAmount.ValidationRegex = "";
			this.TB_ExtraFeeAmount.TextChanged += new System.EventHandler(this.TB_NewCounter_TextChanged);
			// 
			// DD_Month
			// 
			this.DD_Month.Conversion = null;
			this.DD_Month.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Month.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Month.Image = ((System.Drawing.Image)(resources.GetObject("DD_Month.Image")));
			this.DD_Month.Items = new object[] {
        ((object)(0)),
        ((object)(1)),
        ((object)(2)),
        ((object)(3)),
        ((object)(4)),
        ((object)(5)),
        ((object)(6)),
        ((object)(7)),
        ((object)(8)),
        ((object)(9)),
        ((object)(10)),
        ((object)(11)),
        ((object)(12))};
			this.DD_Month.LabelText = "Month";
			this.DD_Month.Location = new System.Drawing.Point(40, 103);
			this.DD_Month.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Month.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Month.MaxLength = 32767;
			this.DD_Month.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Month.Name = "DD_Month";
			this.DD_Month.Password = false;
			this.DD_Month.Placeholder = " ";
			this.DD_Month.ReadOnly = false;
			this.DD_Month.Required = false;
			this.DD_Month.SelectAllOnFocus = false;
			this.DD_Month.SelectedItem = null;
			this.DD_Month.SelectedText = "";
			this.DD_Month.SelectionLength = 0;
			this.DD_Month.SelectionStart = 0;
			this.DD_Month.Size = new System.Drawing.Size(250, 34);
			this.DD_Month.TabIndex = 4;
			this.DD_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Month.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Month.ValidationRegex = "";
			this.DD_Month.TextChanged += new System.EventHandler(this.TB_NewCounter_TextChanged);
			// 
			// DD_Year
			// 
			this.DD_Year.Conversion = null;
			this.DD_Year.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Year.Image = ((System.Drawing.Image)(resources.GetObject("DD_Year.Image")));
			this.DD_Year.Items = null;
			this.DD_Year.LabelText = "Year";
			this.DD_Year.Location = new System.Drawing.Point(480, 103);
			this.DD_Year.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Year.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Year.MaxLength = 32767;
			this.DD_Year.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Year.Name = "DD_Year";
			this.DD_Year.Password = false;
			this.DD_Year.Placeholder = " ";
			this.DD_Year.ReadOnly = false;
			this.DD_Year.Required = false;
			this.DD_Year.SelectAllOnFocus = false;
			this.DD_Year.SelectedItem = null;
			this.DD_Year.SelectedText = "";
			this.DD_Year.SelectionLength = 0;
			this.DD_Year.SelectionStart = 0;
			this.DD_Year.Size = new System.Drawing.Size(250, 34);
			this.DD_Year.TabIndex = 5;
			this.DD_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Year.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Year.ValidationRegex = "";
			this.DD_Year.TextChanged += new System.EventHandler(this.TB_NewCounter_TextChanged);
			// 
			// TB_Price
			// 
			this.TB_Price.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Price.Image = null;
			this.TB_Price.LabelText = "Invoice Price";
			this.TB_Price.Location = new System.Drawing.Point(40, 199);
			this.TB_Price.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Price.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Price.MaxLength = 32767;
			this.TB_Price.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Price.Name = "TB_Price";
			this.TB_Price.Password = false;
			this.TB_Price.Placeholder = "Invoice Price";
			this.TB_Price.ReadOnly = true;
			this.TB_Price.Required = false;
			this.TB_Price.SelectAllOnFocus = false;
			this.TB_Price.SelectedText = "";
			this.TB_Price.SelectionLength = 0;
			this.TB_Price.SelectionStart = 0;
			this.TB_Price.Size = new System.Drawing.Size(250, 34);
			this.TB_Price.TabIndex = 3;
			this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Price.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_Price.ValidationRegex = "";
			// 
			// TB_NewCounter
			// 
			this.TB_NewCounter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_NewCounter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_NewCounter.Image = null;
			this.TB_NewCounter.LabelText = "New Counter";
			this.TB_NewCounter.Location = new System.Drawing.Point(480, 55);
			this.TB_NewCounter.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_NewCounter.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_NewCounter.MaxLength = 32767;
			this.TB_NewCounter.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_NewCounter.Name = "TB_NewCounter";
			this.TB_NewCounter.Password = false;
			this.TB_NewCounter.Placeholder = "New Counter";
			this.TB_NewCounter.ReadOnly = false;
			this.TB_NewCounter.Required = true;
			this.TB_NewCounter.SelectAllOnFocus = false;
			this.TB_NewCounter.SelectedText = "";
			this.TB_NewCounter.SelectionLength = 0;
			this.TB_NewCounter.SelectionStart = 0;
			this.TB_NewCounter.Size = new System.Drawing.Size(250, 34);
			this.TB_NewCounter.TabIndex = 2;
			this.TB_NewCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_NewCounter.Validation = SlickControls.Enums.ValidationType.Decimal;
			this.TB_NewCounter.ValidationRegex = "";
			this.TB_NewCounter.TextChanged += new System.EventHandler(this.TB_NewCounter_TextChanged);
			// 
			// TB_LastCounter
			// 
			this.TB_LastCounter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_LastCounter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_LastCounter.Image = null;
			this.TB_LastCounter.LabelText = "Last Counter";
			this.TB_LastCounter.Location = new System.Drawing.Point(40, 55);
			this.TB_LastCounter.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_LastCounter.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_LastCounter.MaxLength = 32767;
			this.TB_LastCounter.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_LastCounter.Name = "TB_LastCounter";
			this.TB_LastCounter.Password = false;
			this.TB_LastCounter.Placeholder = "Last Counter";
			this.TB_LastCounter.ReadOnly = true;
			this.TB_LastCounter.Required = false;
			this.TB_LastCounter.SelectAllOnFocus = false;
			this.TB_LastCounter.SelectedText = "";
			this.TB_LastCounter.SelectionLength = 0;
			this.TB_LastCounter.SelectionStart = 0;
			this.TB_LastCounter.Size = new System.Drawing.Size(250, 34);
			this.TB_LastCounter.TabIndex = 1;
			this.TB_LastCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_LastCounter.Validation = SlickControls.Enums.ValidationType.Decimal;
			this.TB_LastCounter.ValidationRegex = "";
			// 
			// DD_Ampere
			// 
			this.DD_Ampere.Conversion = null;
			this.DD_Ampere.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Ampere.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Ampere.Image = ((System.Drawing.Image)(resources.GetObject("DD_Ampere.Image")));
			this.DD_Ampere.Items = null;
			this.DD_Ampere.LabelText = "Amper Type";
			this.DD_Ampere.Location = new System.Drawing.Point(40, 7);
			this.DD_Ampere.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Ampere.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Ampere.MaxLength = 32767;
			this.DD_Ampere.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Ampere.Name = "DD_Ampere";
			this.DD_Ampere.Password = false;
			this.DD_Ampere.Placeholder = "Amper Type";
			this.DD_Ampere.ReadOnly = true;
			this.DD_Ampere.Required = false;
			this.DD_Ampere.SelectAllOnFocus = false;
			this.DD_Ampere.SelectedItem = null;
			this.DD_Ampere.SelectedText = "";
			this.DD_Ampere.SelectionLength = 0;
			this.DD_Ampere.SelectionStart = 0;
			this.DD_Ampere.Size = new System.Drawing.Size(250, 34);
			this.DD_Ampere.TabIndex = 0;
			this.DD_Ampere.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Ampere.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Ampere.ValidationRegex = "";
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
			this.B_Save.Location = new System.Drawing.Point(770, 550);
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
			this.B_Delete.Location = new System.Drawing.Point(15, 550);
			this.B_Delete.Margin = new System.Windows.Forms.Padding(0);
			this.B_Delete.Name = "B_Delete";
			this.B_Delete.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Delete.Size = new System.Drawing.Size(100, 30);
			this.B_Delete.TabIndex = 17;
			this.B_Delete.Text = "DELETE";
			this.B_Delete.Visible = false;
			this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
			// 
			// B_Print
			// 
			this.B_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_Print.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Print.ColorShade = null;
			this.B_Print.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Print.IconSize = 16;
			this.B_Print.Image = ((System.Drawing.Image)(resources.GetObject("B_Print.Image")));
			this.B_Print.Location = new System.Drawing.Point(655, 550);
			this.B_Print.Margin = new System.Windows.Forms.Padding(0);
			this.B_Print.Name = "B_Print";
			this.B_Print.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Print.Size = new System.Drawing.Size(100, 30);
			this.B_Print.TabIndex = 17;
			this.B_Print.Text = "PRINT";
			this.B_Print.Visible = false;
			this.B_Print.Click += new System.EventHandler(this.B_Print_Click);
			// 
			// PC_NewInvoice
			// 
			this.AcceptButton = this.B_Save;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.B_Delete);
			this.Controls.Add(this.B_Print);
			this.Controls.Add(this.B_Save);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.slickSectionPanel2);
			this.Controls.Add(this.tableLayoutPanel3);
			this.Controls.Add(this.slickSectionPanel1);
			this.Name = "PC_NewInvoice";
			this.Size = new System.Drawing.Size(890, 600);
			this.Text = "New Invoice";
			this.Controls.SetChildIndex(this.slickSectionPanel1, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
			this.Controls.SetChildIndex(this.slickSectionPanel2, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
			this.Controls.SetChildIndex(this.B_Save, 0);
			this.Controls.SetChildIndex(this.B_Print, 0);
			this.Controls.SetChildIndex(this.B_Delete, 0);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SlickControls.Controls.SlickSectionPanel slickSectionPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private SlickControls.Controls.SlickTextBox TB_Mobile;
		private SlickControls.Controls.SlickTextBox TB_Address;
		private SlickControls.Controls.SlickSectionPanel slickSectionPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private SlickControls.Controls.SlickDropdown DD_Ampere;
		private SlickControls.Controls.SlickButton B_Save;
		private SlickControls.Controls.SlickButton B_Delete;
		private SlickControls.Controls.SlickButton B_Print;
		private SlickControls.Controls.SlickDropdown DD_Customer;
		private SlickControls.Controls.SlickTextBox TB_NewCounter;
		private SlickControls.Controls.SlickTextBox TB_LastCounter;
		private SlickControls.Controls.SlickTextBox TB_Price;
		private SlickControls.Controls.SlickDropdown DD_Month;
		private SlickControls.Controls.SlickDropdown DD_Year;
		private SlickControls.Controls.SlickTextBox TB_ExtraFee;
		private SlickControls.Controls.SlickTextBox TB_ExtraFeeAmount;
	}
}