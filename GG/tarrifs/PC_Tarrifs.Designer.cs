namespace GG.Tariffs
{
	partial class PC_Tarrifs
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PC_Tarrifs));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.slickSectionPanel1 = new SlickControls.Controls.SlickSectionPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_Price = new SlickControls.Controls.SlickTextBox();
			this.DD_Rounding = new SlickControls.Controls.SlickDropdown();
			this.slickSectionPanel2 = new SlickControls.Controls.SlickSectionPanel();
			this.slickGrid1 = new SlickControls.Controls.SlickGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.B_Delete = new SlickControls.Controls.SlickButton();
			this.B_Save = new SlickControls.Controls.SlickButton();
			this.amperesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ampereTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.slickGrid1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ampereTypeBindingSource)).BeginInit();
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
			this.slickSectionPanel1.Location = new System.Drawing.Point(0, 30);
			this.slickSectionPanel1.MaximumSize = new System.Drawing.Size(9999, 54);
			this.slickSectionPanel1.Name = "slickSectionPanel1";
			this.slickSectionPanel1.Size = new System.Drawing.Size(783, 54);
			this.slickSectionPanel1.TabIndex = 14;
			this.slickSectionPanel1.Text = "KWh Pricing";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.TB_Price, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.DD_Rounding, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 84);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(783, 96);
			this.tableLayoutPanel4.TabIndex = 17;
			// 
			// TB_Price
			// 
			this.TB_Price.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TB_Price.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TB_Price.Image = null;
			this.TB_Price.LabelText = "KWh Value";
			this.TB_Price.Location = new System.Drawing.Point(40, 7);
			this.TB_Price.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.TB_Price.MaximumSize = new System.Drawing.Size(9999, 34);
			this.TB_Price.MaxLength = 32767;
			this.TB_Price.MinimumSize = new System.Drawing.Size(50, 34);
			this.TB_Price.Name = "TB_Price";
			this.TB_Price.Password = false;
			this.TB_Price.Placeholder = "KWh Value (LBP)";
			this.TB_Price.ReadOnly = false;
			this.TB_Price.Required = true;
			this.TB_Price.SelectAllOnFocus = false;
			this.TB_Price.SelectedText = "";
			this.TB_Price.SelectionLength = 0;
			this.TB_Price.SelectionStart = 0;
			this.TB_Price.Size = new System.Drawing.Size(593, 34);
			this.TB_Price.TabIndex = 1;
			this.TB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TB_Price.Validation = SlickControls.Enums.ValidationType.Decimal;
			this.TB_Price.ValidationRegex = "";
			// 
			// DD_Rounding
			// 
			this.DD_Rounding.Conversion = null;
			this.DD_Rounding.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DD_Rounding.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DD_Rounding.Image = ((System.Drawing.Image)(resources.GetObject("DD_Rounding.Image")));
			this.DD_Rounding.Items = new string[] {
        "1\'000 LBP",
        "500 LBP",
        "250 LBP",
        "None"};
			this.DD_Rounding.LabelText = "Rounding Type";
			this.DD_Rounding.Location = new System.Drawing.Point(40, 55);
			this.DD_Rounding.Margin = new System.Windows.Forms.Padding(40, 7, 150, 7);
			this.DD_Rounding.MaximumSize = new System.Drawing.Size(9999, 34);
			this.DD_Rounding.MaxLength = 32767;
			this.DD_Rounding.MinimumSize = new System.Drawing.Size(50, 34);
			this.DD_Rounding.Name = "DD_Rounding";
			this.DD_Rounding.Password = false;
			this.DD_Rounding.Placeholder = "Rounding Type";
			this.DD_Rounding.ReadOnly = false;
			this.DD_Rounding.Required = true;
			this.DD_Rounding.SelectAllOnFocus = false;
			this.DD_Rounding.SelectedItem = "250 LBP";
			this.DD_Rounding.SelectedText = "";
			this.DD_Rounding.SelectionLength = 0;
			this.DD_Rounding.SelectionStart = 0;
			this.DD_Rounding.Size = new System.Drawing.Size(593, 34);
			this.DD_Rounding.TabIndex = 0;
			this.DD_Rounding.Text = "250 LBP";
			this.DD_Rounding.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DD_Rounding.Validation = SlickControls.Enums.ValidationType.None;
			this.DD_Rounding.ValidationRegex = "";
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
			this.slickSectionPanel2.Location = new System.Drawing.Point(0, 180);
			this.slickSectionPanel2.MaximumSize = new System.Drawing.Size(9999, 54);
			this.slickSectionPanel2.Name = "slickSectionPanel2";
			this.slickSectionPanel2.Size = new System.Drawing.Size(783, 54);
			this.slickSectionPanel2.TabIndex = 18;
			this.slickSectionPanel2.Text = "Ampere Pricing";
			// 
			// slickGrid1
			// 
			this.slickGrid1.AutoGenerateColumns = false;
			this.slickGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
			this.slickGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.slickGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.slickGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(218)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(202)))), ((int)(((byte)(218)))));
			this.slickGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.slickGrid1.ColumnHeadersHeight = 28;
			this.slickGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.slickGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amperesDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
			this.slickGrid1.DataSource = this.ampereTypeBindingSource;
			this.slickGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.slickGrid1.EnableHeadersVisualStyles = false;
			this.slickGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
			this.slickGrid1.Location = new System.Drawing.Point(0, 234);
			this.slickGrid1.Name = "slickGrid1";
			this.slickGrid1.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(157)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.slickGrid1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.slickGrid1.Size = new System.Drawing.Size(783, 156);
			this.slickGrid1.TabIndex = 20;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.B_Delete);
			this.panel1.Controls.Add(this.B_Save);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 390);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(783, 48);
			this.panel1.TabIndex = 21;
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
			this.B_Delete.Location = new System.Drawing.Point(15, 9);
			this.B_Delete.Margin = new System.Windows.Forms.Padding(0);
			this.B_Delete.Name = "B_Delete";
			this.B_Delete.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Delete.Size = new System.Drawing.Size(116, 30);
			this.B_Delete.TabIndex = 18;
			this.B_Delete.Text = "DELETE ROW";
			this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
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
			this.B_Save.Location = new System.Drawing.Point(668, 9);
			this.B_Save.Margin = new System.Windows.Forms.Padding(0);
			this.B_Save.Name = "B_Save";
			this.B_Save.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.B_Save.Size = new System.Drawing.Size(100, 30);
			this.B_Save.TabIndex = 19;
			this.B_Save.Text = "SAVE";
			this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
			// 
			// amperesDataGridViewTextBoxColumn
			// 
			this.amperesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.amperesDataGridViewTextBoxColumn.DataPropertyName = "Amperes";
			this.amperesDataGridViewTextBoxColumn.FillWeight = 97.16496F;
			this.amperesDataGridViewTextBoxColumn.HeaderText = "Amperes";
			this.amperesDataGridViewTextBoxColumn.Name = "amperesDataGridViewTextBoxColumn";
			// 
			// valueDataGridViewTextBoxColumn
			// 
			this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.FillWeight = 100.1701F;
			this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			// 
			// ampereTypeBindingSource
			// 
			this.ampereTypeBindingSource.DataSource = typeof(GG.Classes.AmpereType);
			// 
			// PC_Tarrifs
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.slickGrid1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.slickSectionPanel2);
			this.Controls.Add(this.tableLayoutPanel4);
			this.Controls.Add(this.slickSectionPanel1);
			this.Name = "PC_Tarrifs";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Text = "Tariffs";
			this.Controls.SetChildIndex(this.slickSectionPanel1, 0);
			this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
			this.Controls.SetChildIndex(this.slickSectionPanel2, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.slickGrid1, 0);
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.slickGrid1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.B_Delete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.B_Save)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ampereTypeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private SlickControls.Controls.SlickSectionPanel slickSectionPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private SlickControls.Controls.SlickDropdown DD_Rounding;
		private SlickControls.Controls.SlickSectionPanel slickSectionPanel2;
		private SlickControls.Controls.SlickTextBox TB_Price;
		private SlickControls.Controls.SlickGrid slickGrid1;
		private System.Windows.Forms.BindingSource ampereTypeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn amperesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel panel1;
		private SlickControls.Controls.SlickButton B_Delete;
		private SlickControls.Controls.SlickButton B_Save;
	}
}
