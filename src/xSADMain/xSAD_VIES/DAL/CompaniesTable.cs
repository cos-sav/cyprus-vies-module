using System.Data;

namespace xSAD_VIES.DAL;

public class CompaniesTable : DataTable
{
	public const string Pkcompanyid = "PKCompanyID";

	public const string Fkgroupid = "FKGroupID";

	public const string Name = "Name";

	public const string Vatreg = "VATReg";

	public const string Period = "Period";

	public const string Include = "Include";

	public CompaniesTable()
	{
		CreateTable();
	}

	private void CreateTable()
	{
		base.Columns.Add("PKCompanyID", typeof(int));
		base.Columns.Add("FKGroupID", typeof(int));
		base.Columns.Add("Name", typeof(string));
		base.Columns.Add("VATReg", typeof(string));
		base.Columns.Add("Include", typeof(string));
	}
}
