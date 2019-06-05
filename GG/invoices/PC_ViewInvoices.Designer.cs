namespace GG.Invoices
{
	partial class PC_ViewInvoices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC_ViewInvoices));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.B_Print = new SlickControls.Controls.SlickButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TB_Search = new SlickControls.Controls.SlickTextBox();
			this.dataGridView1 = new SlickControls.Controls.SlickGrid();
			this.DD_Month = new SlickControls.Controls.SlickDropdown();
			this.DD_Year = new SlickControls.Controls.SlickDropdown();
			this.DD_Division = new SlickControls.Controls.SlickDropdown();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustDivision = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startingCounterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endingCounterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.B_Print, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TB_Search, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.DD_Month, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.DD_Year, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.DD_Division, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 408);
			this.tableLayoutPanel1.TabIndex = 13;
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
			this.B_Print.Location = new System.Drawing.Point(676, 5);
			this.B_Print.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.B_Print.Name = "B_Print";
			this.B_Print.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Print.Size = new System.Drawing.Size(100, 30);
			this.B_Print.TabIndex = 18;
			this.B_Print.Text = "PRINT";
			this.B_Print.Click += new System.EventHandler(this.B_Print_Click);
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
			this.TB_Search.Size = new System.Drawing.Size(310, 21);
			this.TB_Search.TabIndex = 1;
			this.TB_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Search.Validation = SlickControls.Enums.ValidationType.None;
			this.TB_Search.ValidationRegex = "";
			this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
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
            this.customerDataGridViewTextBoxColumn,
            this.CustDivision,
            this.dateDataGridViewTextBoxColumn,
            this.startingCounterDataGridViewTextBoxColumn,
            this.endingCounterDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
			this.dataGridView1.DataSource = this.invoiceBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
			this.dataGridView1.Location = new System.Drawing.Point(0, 40);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(157)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(783, 368);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// DD_Month
			// 
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
			this.DD_Month.Location = new System.Drawing.Point(476, 3);
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
			this.DD_Month.Size = new System.Drawing.Size(85, 34);
			this.DD_Month.TabIndex = 3;
			this.DD_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Month.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Month.ValidationRegex = "";
			this.DD_Month.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// DD_Year
			// 
			this.DD_Year.Conversion = null;
			this.DD_Year.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Year.Image = ((System.Drawing.Image)(resources.GetObject("DD_Year.Image")));
			this.DD_Year.Items = null;
			this.DD_Year.LabelText = "Year";
			this.DD_Year.Location = new System.Drawing.Point(574, 3);
			this.DD_Year.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
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
			this.DD_Year.Size = new System.Drawing.Size(85, 34);
			this.DD_Year.TabIndex = 3;
			this.DD_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Year.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Year.ValidationRegex = "";
			this.DD_Year.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
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
			this.DD_Division.Location = new System.Drawing.Point(355, 3);
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
			this.DD_Division.TabIndex = 3;
			this.DD_Division.Text = "All";
			this.DD_Division.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Division.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Division.ValidationRegex = "";
			this.DD_Division.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(GG.Classes.Invoice);
			// 
			// customerDataGridViewTextBoxColumn
			// 
			this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
			this.customerDataGridViewTextBoxColumn.FillWeight = 250F;
			this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
			this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
			this.customerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// CustDivision
			// 
			this.CustDivision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CustDivision.DataPropertyName = "CustDivision";
			this.CustDivision.HeaderText = "Division";
			this.CustDivision.Name = "CustDivision";
			this.CustDivision.ReadOnly = true;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// startingCounterDataGridViewTextBoxColumn
			// 
			this.startingCounterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.startingCounterDataGridViewTextBoxColumn.DataPropertyName = "StartingCounter";
			this.startingCounterDataGridViewTextBoxColumn.HeaderText = "Starting Counter";
			this.startingCounterDataGridViewTextBoxColumn.Name = "startingCounterDataGridViewTextBoxColumn";
			this.startingCounterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endingCounterDataGridViewTextBoxColumn
			// 
			this.endingCounterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.endingCounterDataGridViewTextBoxColumn.DataPropertyName = "EndingCounter";
			this.endingCounterDataGridViewTextBoxColumn.HeaderText = "Ending Counter";
			this.endingCounterDataGridViewTextBoxColumn.Name = "endingCounterDataGridViewTextBoxColumn";
			this.endingCounterDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.FillWeight = 125F;
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// PC_ViewInvoices
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PC_ViewInvoices";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Text = "Invoices";
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.B_Print)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private SlickControls.Controls.SlickTextBox TB_Search;
		private SlickControls.Controls.SlickGrid dataGridView1;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private SlickControls.Controls.SlickDropdown DD_Month;
		private SlickControls.Controls.SlickDropdown DD_Year;
		private SlickControls.Controls.SlickButton B_Print;
		private SlickControls.Controls.SlickDropdown DD_Division;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustDivision;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startingCounterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endingCounterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
	}
}
