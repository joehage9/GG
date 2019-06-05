using System;

namespace GG.Classes
{
	public class Customer
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Mobile { get; set; }
		public string Address { get; set; }
		public bool Active { get; set; }
		public double CurrentCounter { get; set; }
		public double NewCounter { get; set; }
		public double AmpereNumber { get; set; }
		public double AmpereValue { get; set; }
		public AmpereType AmpereType { get; set; }
		public string Division { get; set; }
		public DateTime LastInvoiceDate { get; set; }

		public override string ToString() => $"{FirstName} {LastName} #{ID}";
	}
}