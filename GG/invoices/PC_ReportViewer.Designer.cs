namespace GG.Invoices
{
    partial class PC_ReportViewer
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
			this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rptViewer
			// 
			this.rptViewer.AutoScroll = true;
			this.rptViewer.AutoSize = true;
			this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rptViewer.Location = new System.Drawing.Point(0, 30);
			this.rptViewer.Name = "rptViewer";
			this.rptViewer.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
			this.rptViewer.ShowBackButton = false;
			this.rptViewer.ShowRefreshButton = false;
			this.rptViewer.ShowStopButton = false;
			this.rptViewer.Size = new System.Drawing.Size(796, 366);
			this.rptViewer.TabIndex = 1;
			// 
			// PC_ReportViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.rptViewer);
			this.Name = "PC_ReportViewer";
			this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
			this.Size = new System.Drawing.Size(796, 396);
			this.Text = "Print Preview";
			this.Load += new System.EventHandler(this.PC_ReportViewer_Load);
			this.Controls.SetChildIndex(this.rptViewer, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
	}
}