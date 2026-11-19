using System.Data;
using System.Data.SqlServerCe;
using xSAD_VIES.Database;

namespace xSAD_VIES.DAL;

public static class Controller
{
	public static GroupsTable SelectAllGroups(string sageVersion)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		using SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", sageVersion);
		sqlCeCommand.CommandText = "SELECT * FROM Groups WHERE SageVersion = @val1 ORDER BY Name";
		sqlCeDataAdapter.SelectCommand = sqlCeCommand;
		GroupsTable groupsTable = new GroupsTable();
		sqlCeDataAdapter.Fill(groupsTable);
		return groupsTable;
	}

	public static bool IsGroupNameExists(string name, int id)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", name);
		sqlCeCommand.Parameters.AddWithValue("@val2", id);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM Groups WHERE Name = @val1 AND PKGroupID <> @val2";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static bool IsGroupVatRegExists(string vatReg, int id)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", vatReg);
		sqlCeCommand.Parameters.AddWithValue("@val2", id);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM Groups WHERE VATReg = @val1 AND PKGroupID <> @val2";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static bool IsGroupMultipleCompanyExists(int multipleCompanyId, int groupId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", multipleCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", groupId);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM ChildrenCompanies WHERE FKGroupID = @val2 AND FKMultipleCompanyID = @val1";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static int InsertGroup(string name, string vatReg, string sageVersion)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", name);
		sqlCeCommand.Parameters.AddWithValue("@val2", vatReg);
		sqlCeCommand.Parameters.AddWithValue("@val3", sageVersion);
		sqlCeCommand.CommandText = "INSERT INTO Groups (Name, VATReg, SageVersion) VALUES (@val1, @val2, @val3) ";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.CommandText = "SELECT MAX(PKGroupID) FROM Groups";
		int result = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		return result;
	}

	public static void SaveGroup(int pkGroupId, string name, string vatReg)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkGroupId);
		sqlCeCommand.Parameters.AddWithValue("@val2", name);
		sqlCeCommand.Parameters.AddWithValue("@val3", vatReg);
		sqlCeCommand.CommandText = "UPDATE Groups SET Name = @val2, VATReg = @val3 WHERE PKGroupID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void DeleteGroup(int pkGroupId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkGroupId);
		sqlCeCommand.CommandText = "DELETE Groups WHERE PKGroupID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void DeleteGroupCompanies(int pkGroupId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkGroupId);
		sqlCeCommand.CommandText = "DELETE Companies WHERE FKGroupID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static string GetGroupName(int groupId)
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "SELECT * FROM Groups WHERE PKGroupId=@GroupId";
		sqlCeCommand.Parameters.AddWithValue("@GroupId", groupId);
		sqlCeConnection.Open();
		using SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
		if (sqlCeDataReader.Read())
		{
			try
			{
				return (string)sqlCeDataReader["Name"];
			}
			catch
			{
				return "";
			}
		}
		return "";
	}

	public static GroupsTable SelectAllCompanies(int fkGroupId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		using SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", fkGroupId);
		sqlCeCommand.CommandText = "SELECT * FROM Companies WHERE FKGroupID = @val1 ORDER BY Name";
		sqlCeDataAdapter.SelectCommand = sqlCeCommand;
		GroupsTable groupsTable = new GroupsTable();
		sqlCeDataAdapter.Fill(groupsTable);
		return groupsTable;
	}

	public static GroupsTable SelectAllIncludedCompanies(int fkGroupId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		using SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", fkGroupId);
		sqlCeCommand.CommandText = "SELECT * FROM Companies WHERE FKGroupID = @val1 and Include=1 ORDER BY Name";
		sqlCeDataAdapter.SelectCommand = sqlCeCommand;
		GroupsTable groupsTable = new GroupsTable();
		sqlCeDataAdapter.Fill(groupsTable);
		return groupsTable;
	}

	public static int InsertCompany(int fkGroupId, string companyCode, string name, string vatReg, string period, bool include)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val0", fkGroupId);
		sqlCeCommand.Parameters.AddWithValue("@val1", companyCode);
		sqlCeCommand.Parameters.AddWithValue("@val2", name.Trim());
		sqlCeCommand.Parameters.AddWithValue("@val3", vatReg.Trim());
		sqlCeCommand.Parameters.AddWithValue("@val4", period);
		sqlCeCommand.Parameters.AddWithValue("@val5", include);
		sqlCeCommand.CommandText = "INSERT INTO Companies (FKGroupID, CompanyCode, Name, VATReg, Period, Include) VALUES (@val0, @val1, @val2, @val3, @val4, @val5)";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.CommandText = "SELECT MAX(PKCompanyID) FROM Companies";
		int result = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		return result;
	}

	public static bool IsCompanyExists(int fkGroupId, string companyCode)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val0", fkGroupId);
		sqlCeCommand.Parameters.AddWithValue("@val1", companyCode);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM Companies WHERE CompanyCode = @val1 AND FKGroupID = @val0";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static void SaveCompanyIsIncluded(int pkCompanyId, bool include)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", include);
		sqlCeCommand.CommandText = "UPDATE Companies SET Include = @val2 WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void SaveCompanyPeriod(int pkCompanyId, string period)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", period);
		sqlCeCommand.CommandText = "UPDATE Companies SET Period = @val2 WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void DeleteCompany(int pkCompanyId)
	{
		SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.CommandText = "DELETE Companies WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static MultipleCompaniesTable SelectAllMultipleCompanies(string sageVersion)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		using SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", sageVersion);
		sqlCeCommand.CommandText = "SELECT * FROM MultipleCompany WHERE SageVersion = @val1 ORDER BY Name";
		sqlCeDataAdapter.SelectCommand = sqlCeCommand;
		MultipleCompaniesTable multipleCompaniesTable = new MultipleCompaniesTable();
		sqlCeDataAdapter.Fill(multipleCompaniesTable);
		return multipleCompaniesTable;
	}

	public static bool IsMultipleCompanyNameExists(string name, int multipleCompanyId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", name);
		sqlCeCommand.Parameters.AddWithValue("@val2", multipleCompanyId);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM MultipleCompany WHERE Name = @val1 AND PKMultipleCompanyID <> @val2";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static int InsertMultipleCompany(string name, string sageVersion)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", name);
		sqlCeCommand.Parameters.AddWithValue("@val2", sageVersion);
		sqlCeCommand.CommandText = "INSERT INTO MultipleCompany (Name, SageVersion) VALUES (@val1, @val2) ";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.CommandText = "SELECT MAX(PKMultipleCompanyID) FROM MultipleCompany";
		int result = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		return result;
	}

	public static void SaveMultipleCompany(int pkMultipleCompanyId, string name)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkMultipleCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", name);
		sqlCeCommand.CommandText = "UPDATE MultipleCompany SET Name = @val2 WHERE PKMultipleCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void DeleteMultipleCompany(int pkMultipleCompanyId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkMultipleCompanyId);
		sqlCeCommand.CommandText = "DELETE MultipleCompany WHERE PKMultipleCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static GroupsTable SelectAllChildrenCompanies(int fkMultipleCompanyId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		using SqlCeDataAdapter sqlCeDataAdapter = new SqlCeDataAdapter();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", fkMultipleCompanyId);
		sqlCeCommand.CommandText = "SELECT * FROM ChildrenCompanies WHERE FKMultipleCompanyID = @val1 ORDER BY Name";
		sqlCeDataAdapter.SelectCommand = sqlCeCommand;
		GroupsTable groupsTable = new GroupsTable();
		sqlCeDataAdapter.Fill(groupsTable);
		return groupsTable;
	}

	public static int InsertChildCompany(int fkMultipleCompanyId, string companyCode, string name, string vatReg, string period, bool include, bool isGroup, int fkGroupdId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val0", fkMultipleCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val1", companyCode);
		sqlCeCommand.Parameters.AddWithValue("@val2", name.Trim());
		sqlCeCommand.Parameters.AddWithValue("@val3", vatReg.Trim());
		sqlCeCommand.Parameters.AddWithValue("@val4", period);
		sqlCeCommand.Parameters.AddWithValue("@val5", include);
		sqlCeCommand.Parameters.AddWithValue("@val6", isGroup);
		sqlCeCommand.Parameters.AddWithValue("@val7", fkGroupdId);
		sqlCeCommand.CommandText = "INSERT INTO ChildrenCompanies (FKMultipleCompanyID, CompanyCode, Name, VATReg, Period, Include, IsGroup, FKGroupID) VALUES (@val0, @val1, @val2, @val3, @val4, @val5, @val6, @val7)";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.CommandText = "SELECT MAX(PKCompanyID) FROM ChildrenCompanies";
		int result = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		return result;
	}

	public static bool IsChildCompanyExists(int fkMultipleCompanyId, string companyCode)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val0", fkMultipleCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val1", companyCode);
		sqlCeCommand.CommandText = "SELECT COUNT(*) FROM ChildrenCompanies WHERE CompanyCode = @val1 AND FKMultipleCompanyID = @val0";
		int num = (int)sqlCeCommand.ExecuteScalar();
		sqlCeCommand.Connection.Close();
		if (num == 0)
		{
			return false;
		}
		return true;
	}

	public static void SaveChildCompanyIsIncluded(int pkCompanyId, bool include)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", include);
		sqlCeCommand.CommandText = "UPDATE ChildrenCompanies SET Include = @val2 WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void SaveChildCompanyPeriod(int pkCompanyId, string period)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.Parameters.AddWithValue("@val2", period);
		sqlCeCommand.CommandText = "UPDATE ChildrenCompanies SET Period = @val2 WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}

	public static void DeleteChildCompany(int pkCompanyId)
	{
		using SqlCeConnection connection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = connection;
		sqlCeCommand.Connection.Open();
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.Parameters.AddWithValue("@val1", pkCompanyId);
		sqlCeCommand.CommandText = "DELETE ChildrenCompanies WHERE PKCompanyID = @val1";
		sqlCeCommand.ExecuteNonQuery();
		sqlCeCommand.Connection.Close();
	}
}
