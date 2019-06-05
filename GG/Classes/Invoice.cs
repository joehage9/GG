using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace GG.Classes
{
	public class Invoice
	{
		public int ID { get; set; }
		public int CustomerID { get; set; }
		public int CounterID { get; set; }
		public Customer Customer { get; set; }
		public double StartingCounter { get; set; }
		public double EndingCounter { get; set; }
		public double CustAmpPrice { get; set; }
		public double CustAmp { get; set; }
		public double KWhPrice { get; set; }
		public DateTime Date { get; set; }
		public double ExtraCost { get; set; }
		public string ExtraCostString => string.IsNullOrWhiteSpace(ExtraInfo) ? "" : ExtraCost.ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "'" }) + " LBP";
		public string ExtraInfo { get; set; }
		public string CustDivision { get; set; }

		public double Price
		{
			get
			{
				var p = (string.IsNullOrWhiteSpace(ExtraInfo) ? 0 : ExtraCost)
					+ CustAmpPrice
					+ ((EndingCounter - StartingCounter) * KWhPrice);

				var round = p % Global.Rounding;

				return round.If(0, p, p + Global.Rounding - round);
			}
		}

		public override string ToString() => $"Invoice #{ID} {(Customer == null ? CustomerID.ToString() : " for " + Customer)}";
	}
}
