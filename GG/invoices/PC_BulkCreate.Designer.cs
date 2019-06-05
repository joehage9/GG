namespace GG.Invoices
{
	partial class PC_BulkCreate
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC_BulkCreate));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new SlickControls.Controls.SlickGrid();
			this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CurrentCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TB_Search = new SlickControls.Controls.SlickTextBox();
			this.B_Print = new SlickControls.Controls.SlickButton();
			this.B_Save = new SlickControls.Controls.SlickButton();
			this.DT_To = new SlickControls.Controls.SlickDateTime();
			this.DD_Division = new SlickControls.Controls.SlickDropdown();
			this.DT_From = new SlickControls.Controls.SlickDateTime();
			this.DD_Month = new SlickControls.Controls.SlickDropdown();
			this.DD_Year = new SlickControls.Controls.SlickDropdown();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ampereNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.DD_Month, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.DD_Year, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TB_Search, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.B_Print, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.B_Save, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.DT_To, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.DD_Division, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.DT_From, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 408);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(218)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(218)))));
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 28;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Division,
            this.ampereNumberDataGridViewTextBoxColumn,
            this.CurrentCounter,
            this.dataGridViewTextBoxColumn1});
			this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
			this.dataGridView1.DataSource = this.customerBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 40);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(157)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Size = new System.Drawing.Size(783, 315);
			this.dataGridView1.TabIndex = 2;
			// 
			// Division
			// 
			this.Division.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Division.DataPropertyName = "Division";
			this.Division.FillWeight = 75F;
			this.Division.HeaderText = "Division";
			this.Division.Name = "Division";
			// 
			// CurrentCounter
			// 
			this.CurrentCounter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CurrentCounter.DataPropertyName = "CurrentCounter";
			this.CurrentCounter.HeaderText = "Current Counter";
			this.CurrentCounter.Name = "CurrentCounter";
			this.CurrentCounter.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "NewCounter";
			this.dataGridViewTextBoxColumn1.HeaderText = "New Counter";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GG.Properties.Resources.Big_Search;
			this.pictureBox1.Location = new System.Drawing.Point(7, 7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 22);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// TB_Search
			// 
			this.TB_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TB_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Search.Image = null;
			this.TB_Search.Location = new System.Drawing.Point(39, 9);
			this.TB_Search.MaximumSize = new System.Drawing.Size(9999, 21);
			this.TB_Search.MaxLength = 32767;
			this.TB_Search.MinimumSize = new System.Drawing.Size(50, 21);
			this.TB_Search.Name = "TB_Search";
			this.TB_Search.Password = false;
			this.TB_Search.Placeholder = "Search..";
			this.TB_Search.ReadOnly = false;
			this.TB_Search.Required = false;
			this.TB_Search.SelectAllOnFocus = false;
			this.TB_Search.SelectedText = "";
			this.TB_Search.SelectionLength = 0;
			this.TB_Search.SelectionStart = 0;
			this.TB_Search.ShowLabel = false;
			this.TB_Search.Size = new System.Drawing.Size(378, 21);
			this.TB_Search.TabIndex = 1;
			this.TB_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Search.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_Search.ValidationRegex = "";
			this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// B_Print
			// 
			this.B_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Print.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_Print.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Print.ColorShade = null;
			this.B_Print.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Print.IconSize = 16;
			this.B_Print.Image = ((System.Drawing.Image)(resources.GetObject("B_Print.Image")));
			this.B_Print.Location = new System.Drawing.Point(551, 372);
			this.B_Print.Margin = new System.Windows.Forms.Padding(7, 3, 7, 5);
			this.B_Print.Name = "B_Print";
			this.B_Print.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Print.Size = new System.Drawing.Size(100, 30);
			this.B_Print.TabIndex = 18;
			this.B_Print.Text = "PRINT";
			this.B_Print.Click += new System.EventHandler(this.B_Print_Click);
			// 
			// B_Save
			// 
			this.B_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_Save.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.B_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Save.ColorShade = null;
			this.B_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Save.IconSize = 16;
			this.B_Save.Image = ((System.Drawing.Image)(resources.GetObject("B_Save.Image")));
			this.B_Save.Location = new System.Drawing.Point(672, 372);
			this.B_Save.Margin = new System.Windows.Forms.Padding(7, 3, 7, 5);
			this.B_Save.Name = "B_Save";
			this.B_Save.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Save.Size = new System.Drawing.Size(100, 30);
			this.B_Save.TabIndex = 19;
			this.B_Save.Text = "CREATE";
			this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
			// 
			// DT_To
			// 
			this.DT_To.DateType = SlickControls.Enums.DateType.Date;
			this.DT_To.DefaultValue = null;
			this.DT_To.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DT_To.Image = ((System.Drawing.Image)(resources.GetObject("DT_To.Image")));
			this.DT_To.LabelText = "Last Invoice To";
			this.DT_To.Location = new System.Drawing.Point(544, 3);
			this.DT_To.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DT_To.MaximumValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
			this.DT_To.MaxLength = 32767;
			this.DT_To.MinimumSize = new System.Drawing.Size(50, 34);
			this.DT_To.MinimumValue = new System.DateTime(((long)(0)));
			this.DT_To.Name = "DT_To";
			this.DT_To.Password = false;
			this.DT_To.Placeholder = "";
			this.DT_To.ReadOnly = false;
			this.DT_To.Required = false;
			this.DT_To.SelectAllOnFocus = false;
			this.DT_To.SelectedText = "";
			this.DT_To.SelectionLength = 0;
			this.DT_To.SelectionStart = 0;
			this.DT_To.Size = new System.Drawing.Size(115, 34);
			this.DT_To.TabIndex = 20;
			this.DT_To.Text = "-- / -- / ----";
			this.DT_To.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DT_To.Validation = SlickControls.Enums.ValidationType.None;
			this.DT_To.ValidationRegex = "";
			this.DT_To.Value = null;
			this.DT_To.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// DD_Division
			// 
			this.DD_Division.Conversion = null;
			this.DD_Division.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Division.Image = ((System.Drawing.Image)(resources.GetObject("DD_Division.Image")));
			this.DD_Division.Items = new object[] {
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
			this.DD_Division.LabelText = "Customer Division";
			this.DD_Division.Location = new System.Drawing.Point(665, 3);
			this.DD_Division.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Division.MaxLength = 32767;
			this.DD_Division.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Division.Name = "DD_Division";
			this.DD_Division.Password = false;
			this.DD_Division.Placeholder = "Customer Division";
			this.DD_Division.ReadOnly = false;
			this.DD_Division.Required = false;
			this.DD_Division.SelectAllOnFocus = false;
			this.DD_Division.SelectedItem = null;
			this.DD_Division.SelectedText = "";
			this.DD_Division.SelectionLength = 0;
			this.DD_Division.SelectionStart = 0;
			this.DD_Division.Size = new System.Drawing.Size(115, 34);
			this.DD_Division.TabIndex = 20;
			this.DD_Division.Text = "All";
			this.DD_Division.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Division.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Division.ValidationRegex = "";
			this.DD_Division.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// DT_From
			// 
			this.DT_From.DateType = SlickControls.Enums.DateType.Date;
			this.DT_From.DefaultValue = null;
			this.DT_From.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DT_From.Image = ((System.Drawing.Image)(resources.GetObject("DT_From.Image")));
			this.DT_From.LabelText = "Last Invoice From";
			this.DT_From.Location = new System.Drawing.Point(423, 3);
			this.DT_From.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DT_From.MaximumValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
			this.DT_From.MaxLength = 32767;
			this.DT_From.MinimumSize = new System.Drawing.Size(50, 34);
			this.DT_From.MinimumValue = new System.DateTime(((long)(0)));
			this.DT_From.Name = "DT_From";
			this.DT_From.Password = false;
			this.DT_From.Placeholder = "";
			this.DT_From.ReadOnly = false;
			this.DT_From.Required = false;
			this.DT_From.SelectAllOnFocus = false;
			this.DT_From.SelectedText = "";
			this.DT_From.SelectionLength = 0;
			this.DT_From.SelectionStart = 0;
			this.DT_From.Size = new System.Drawing.Size(115, 34);
			this.DT_From.TabIndex = 20;
			this.DT_From.Text = "-- / -- / ----";
			this.DT_From.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DT_From.Validation = SlickControls.Enums.ValidationType.None;
			this.DT_From.ValidationRegex = "";
			this.DT_From.Value = null;
			this.DT_From.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// DD_Month
			// 
			this.DD_Month.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DD_Month.Conversion = null;
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
			this.DD_Month.Location = new System.Drawing.Point(302, 371);
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
			this.DD_Month.Size = new System.Drawing.Size(115, 34);
			this.DD_Month.TabIndex = 21;
			this.DD_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Month.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Month.ValidationRegex = "";
			// 
			// DD_Year
			// 
			this.DD_Year.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.DD_Year.Conversion = null;
			this.DD_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Year.Image = ((System.Drawing.Image)(resources.GetObject("DD_Year.Image")));
			this.DD_Year.Items = null;
			this.DD_Year.LabelText = "Year";
			this.DD_Year.Location = new System.Drawing.Point(423, 371);
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
			this.DD_Year.Size = new System.Drawing.Size(115, 34);
			this.DD_Year.TabIndex = 22;
			this.DD_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Year.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Year.ValidationRegex = "";
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// mobileDataGridViewTextBoxColumn
			// 
			this.mobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
			this.mobileDataGridViewTextBoxColumn.FillWeight = 75F;
			this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
			this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
			this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.FillWeight = 75F;
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ampereNumberDataGridViewTextBoxColumn
			// 
			this.ampereNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ampereNumberDataGridViewTextBoxColumn.DataPropertyName = "AmpereNumber";
			this.ampereNumberDataGridViewTextBoxColumn.FillWeight = 50F;
			this.ampereNumberDataGridViewTextBoxColumn.HeaderText = "Amperage";
			this.ampereNumberDataGridViewTextBoxColumn.Name = "ampereNumberDataGridViewTextBoxColumn";
			this.ampereNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.AllowNew = false;
			this.customerBindingSource.DataSource = typeof(GG.Classes.Customer);
			// 
			// panel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel1, 5);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(20, 361);
			this.panel1.Margin = new System.Windows.Forms.Padding(20, 6, 20, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(743, 1);
			this.panel1.TabIndex = 23;
			// 
			// PC_BulkCreate
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PC_BulkCreate";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Text = "Bulk Create Invoices";
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private SlickControls.Controls.SlickTextBox TB_Search;
		private SlickControls.Controls.SlickGrid dataGridView1;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private SlickControls.Controls.SlickButton B_Print;
		private SlickControls.Controls.SlickButton B_Save;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Division;
		private System.Windows.Forms.DataGridViewTextBoxColumn ampereNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCounter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private SlickControls.Controls.SlickDropdown DD_Division;
		private SlickControls.Controls.SlickDateTime DT_To;
		private SlickControls.Controls.SlickDateTime DT_From;
		private SlickControls.Controls.SlickDropdown DD_Month;
		private SlickControls.Controls.SlickDropdown DD_Year;
		private System.Windows.Forms.Panel panel1;
	}
}
