namespace xSageDataObjects;

/// <summary>
/// A dataset style structure containing all tables from Sage
/// </summary>
public class AllSageData
{
	public Customers.CustomersListDataTable Customers;

	public TaxCodes.TaxCodesListDataTable TaxCodes;

	public Nominal.NominalAccountsListDataTable NominalCodes;
}
