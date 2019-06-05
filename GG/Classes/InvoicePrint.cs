using GG.Invoices;
using SlickControls.Panels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG.Classes
{
    public class InvoicePrint : Invoice
    {
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustAmpString => CustAmpPrice.ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "'" }) + " LBP";
        public string TotKWhPrice => ((EndingCounter - StartingCounter) * KWhPrice).ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "'" }) + " LBP";
        public string TotPrice => Price.ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "'" }) + " LBP";
        public string StringValue => $"ONLY {NumberToWords((int)Price)}LBP";
        
        public static void Print(BasePanelForm Form, IEnumerable<InvoicePrint> invocies)
        {
            Form.PushPanel(null , new PC_ReportViewer(
                "GG.Invoices.InvoiceReport.rdlc"
                , new Microsoft.Reporting.WinForms.ReportParameter[0]
                , new Microsoft.Reporting.WinForms.ReportDataSource[]
						{
							new Microsoft.Reporting.WinForms.ReportDataSource("InvoiceDataSet", invocies.Take((int)Math.Ceiling(invocies.Count() / 2D))),
							new Microsoft.Reporting.WinForms.ReportDataSource("InvoiceDataSet2", invocies.Skip((int)Math.Ceiling(invocies.Count() / 2D)))
						}
                , true
                )
            );
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words.ToUpper();
        }
    }
}
