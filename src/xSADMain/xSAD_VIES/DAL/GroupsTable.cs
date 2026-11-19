using System.Data;

namespace xSAD_VIES.DAL;

public class GroupsTable : DataTable
{
	public const string Pkgroupid = "PKGroupID";

	public const string Name = "Name";

	public const string Vatreg = "VATReg";

	public GroupsTable()
	{
		CreateTable();
	}

	private void CreateTable()
	{
		base.Columns.Add("PKGroupID", typeof(int));
		base.Columns.Add("Name", typeof(string));
		base.Columns.Add("VATReg", typeof(string));
	}
}
