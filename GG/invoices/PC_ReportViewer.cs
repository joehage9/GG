using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SlickControls.Enums;
using SlickControls.Panels;

namespace GG.Invoices
{
	public partial class PC_ReportViewer : PanelContent
	{
		public PC_ReportViewer(string reportEmbeddedResource, ReportParameter[] paramList,  ReportDataSource[] rptSources, bool embedded = false)
		{
			try
			{
				InitializeComponent();

				rptViewer.LocalReport.SetBasePermissionsForSandboxAppDomain(new PermissionSet(PermissionState.Unrestricted));

				if (embedded)
				{
					rptViewer.LocalReport.ReportEmbeddedResource = reportEmbeddedResource;
					Stream resourceReportStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(rptViewer.LocalReport.ReportEmbeddedResource);
					rptViewer.LocalReport.LoadReportDefinition(resourceReportStream);
				}
				else
					rptViewer.LocalReport.ReportPath = reportEmbeddedResource;

				foreach (ReportDataSource rptSource in rptSources)
					rptViewer.LocalReport.DataSources.Add(rptSource);

				//rptViewer.LocalReport.SetParameters(paramList);
				rptViewer.LocalReport.EnableHyperlinks = true;
				rptViewer.ShowCredentialPrompts = false;
				rptViewer.ShowParameterPrompts = false;
				rptViewer.ShowDocumentMapButton = true;
				rptViewer.DocumentMapCollapsed = true;
			}
			catch (Exception ex)
			{ ShowPrompt("An error occurred while processing the report.\n\n" + ex.Message, PromptButtons.OK, PromptIcons.Error); }
		}

		private void PC_ReportViewer_Load(object sender, EventArgs e)
		{
			rptViewer.RefreshReport();
		}

		public override bool KeyPressed(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.Control | Keys.P))
			{
				rptViewer.PrintDialog();
				return true;
			}

			return base.KeyPressed(ref msg, keyData);
		}
	}
}