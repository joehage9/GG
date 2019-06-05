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
using SlickControls.Enums;
using SlickControls.Classes;
using Extensions;
using GG.Classes;

namespace GG.Tariffs
{
	public partial class PC_Tarrifs : PanelContent
	{
		public PC_Tarrifs()
		{
			InitializeComponent();

			var rounding = SqlHandler.GetRounding();
			var kwH = SqlHandler.GetKwhPrice();
			var ampereTypes = SqlHandler.GetAmperTypes();

			if (kwH > 0)
				TB_Price.Text = kwH.ToString();

			DD_Rounding.Text = DD_Rounding.Items.FirstThat(x => x.ToString().SmartParse(1) == rounding)?.ToString();

			ampereTypeBindingSource.DataSource = ampereTypes;
		}

		private void B_Delete_Click(object sender, EventArgs e)
		{
			if(slickGrid1.SelectedCells.Count > 0)
			{
				if (ShowPrompt("Are you sure you want to delete these rows?", PromptButtons.YesNo, PromptIcons.Hand) == DialogResult.Yes)
				{
					var ints = slickGrid1.SelectedCells.Cast<DataGridViewCell>().Select(x => x.RowIndex).Distinct().OrderByDescending(x => x).ToArray();

					slickGrid1.CommitEdit(DataGridViewDataErrorContexts.Commit);

					foreach (var item in ints)
					{
						try
						{ slickGrid1.Rows.RemoveAt(item); }
						catch { }
					}
				}
			}
		}

		private void B_Save_Click(object sender, EventArgs e)
		{
			if (this.CheckValidation())
			{
				SqlHandler.SaveTarrifs(TB_Price.Text.SmartParseD(), DD_Rounding.Text.SmartParse(1));

				SqlHandler.SaveAmperTypes(ampereTypeBindingSource.DataSource as List<AmpereType>);

				Global.Rounding = SqlHandler.GetRounding();
			}
		}
	}
}
