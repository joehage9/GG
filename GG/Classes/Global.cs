using System;
using System.IO;
using System.Windows.Forms;

namespace GG
{
	class Global
	{
		public static Main MainForm;

		public static int Rounding { get; set; } = SqlHandler.GetRounding();
	}
}