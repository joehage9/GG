namespace GG.Classes
{
	public class AmpereType
	{
		public decimal Amperes { get; set; }
		public decimal Value { get; set; }

		public override string ToString() => $"{Amperes.ToString("0.##")} A";
	}
}