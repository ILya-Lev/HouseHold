namespace DomainModel
{
	public class Wallet
	{
		/// <summary> money available for spending this time period, i.e. month </summary>
		public decimal Balance { get; set; }

		/// <summary> savings in UAH </summary>
		public decimal SavingsGrivna { get; set; }

		/// <summary> savings in USD </summary>
		public decimal SavingsDollar { get; set; }
	}
}
