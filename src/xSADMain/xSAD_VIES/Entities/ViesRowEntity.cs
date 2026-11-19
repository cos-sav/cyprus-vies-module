namespace xSAD_VIES.Entities;

public class ViesRowEntity
{
	public int RowNumber { get; set; }

	public string CountryName { get; set; }

	public string CountryCode { get; set; }

	public string VatRegistrationNumber { get; set; }

	public string CustomerName { get; set; }

	public decimal SuppliesAmount { get; set; }

	public decimal TriangleTransactionsAmount { get; set; }

	public decimal ServicesAmount { get; set; }

	public ViesRowEntity()
	{
		VatRegistrationNumber = "";
		CountryCode = "";
		CustomerName = "";
	}
}
