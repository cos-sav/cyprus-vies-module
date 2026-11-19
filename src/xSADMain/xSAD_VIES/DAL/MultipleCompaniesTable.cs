using System.Data;

namespace xSAD_VIES.DAL;

public class MultipleCompaniesTable : DataTable
{
	public const string PkMultipleCompanyid = "PKMultipleCompanyID";

	public const string Name = "Name";

	public const string Vatreg = "VATReg";

	public MultipleCompaniesTable()
	{
		CreateTable();
	}

	private void CreateTable()
	{
		base.Columns.Add("PKMultipleCompanyID", typeof(int));
		base.Columns.Add("Name", typeof(string));
		base.Columns.Add("VATReg", typeof(string));
	}
}
