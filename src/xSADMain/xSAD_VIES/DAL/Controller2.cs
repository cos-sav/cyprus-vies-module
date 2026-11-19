using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Security.Principal;
using xSAD_VIES.Database;

namespace xSAD_VIES.DAL;

public static class Controller2
{
	public static void SetSageVersion(string sageVersion)
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "update Settings set SageVersion=@SageVersion";
		sqlCeCommand.Parameters.AddWithValue("@SageVersion", sageVersion);
		sqlCeConnection.Open();
		sqlCeCommand.ExecuteNonQuery();
	}

	public static string GetSageVersion()
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "select SageVersion from Settings";
		sqlCeConnection.Open();
		using SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
		if (sqlCeDataReader.Read())
		{
			try
			{
				return (string)sqlCeDataReader["SageVersion"];
			}
			catch
			{
				return "";
			}
		}
		return "";
	}

	public static string GetCompanyPeriod(int groupId, string companyCode)
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "select Period from Companies where FKGroupId=@FKGroupId and CompanyCode=@CompanyCode";
		sqlCeCommand.Parameters.AddWithValue("@FKGroupId", groupId);
		sqlCeCommand.Parameters.AddWithValue("@CompanyCode", companyCode);
		sqlCeConnection.Open();
		using SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
		if (sqlCeDataReader.Read())
		{
			try
			{
				return (string)sqlCeDataReader["Period"];
			}
			catch
			{
				return "";
			}
		}
		return "";
	}

	public static void ApplyDatabaseUpdates()
	{
		try
		{
			using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
			sqlCeConnection.Open();
			using (SqlCeCommand sqlCeCommand = new SqlCeCommand())
			{
				sqlCeCommand.Connection = sqlCeConnection;
				sqlCeCommand.CommandType = CommandType.Text;
				sqlCeCommand.CommandText = "alter table Settings add FormNotification int";
				try
				{
					sqlCeCommand.ExecuteNonQuery();
				}
				catch
				{
				}
			}
			using (SqlCeCommand sqlCeCommand2 = new SqlCeCommand())
			{
				sqlCeCommand2.Connection = sqlCeConnection;
				sqlCeCommand2.CommandType = CommandType.Text;
				sqlCeCommand2.CommandText = "update Settings set FormNotification=1 where FormNotification is null";
				try
				{
					sqlCeCommand2.ExecuteNonQuery();
				}
				catch
				{
				}
			}
			using (SqlCeCommand sqlCeCommand3 = new SqlCeCommand())
			{
				sqlCeCommand3.Connection = sqlCeConnection;
				sqlCeCommand3.CommandType = CommandType.Text;
				sqlCeCommand3.CommandText = "update Companies set Name=LTRIM(RTRIM(NAME)), VATREG=LTRIM(RTRIM(VATREG)) ";
				try
				{
					sqlCeCommand3.ExecuteNonQuery();
				}
				catch
				{
				}
			}
			using (SqlCeCommand sqlCeCommand4 = new SqlCeCommand())
			{
				sqlCeCommand4.Connection = sqlCeConnection;
				sqlCeCommand4.CommandType = CommandType.Text;
				sqlCeCommand4.CommandText = "update ChildrenCompanies set Name=LTRIM(RTRIM(NAME)), VATREG=LTRIM(RTRIM(VATREG)) ";
				try
				{
					sqlCeCommand4.ExecuteNonQuery();
				}
				catch
				{
				}
			}
			using SqlCeCommand sqlCeCommand5 = new SqlCeCommand();
			sqlCeCommand5.Connection = sqlCeConnection;
			sqlCeCommand5.CommandType = CommandType.Text;
			sqlCeCommand5.CommandText = "create table UserXmlFolders (Username nvarchar(100), FolderPath nvarchar(500))";
			try
			{
				sqlCeCommand5.ExecuteNonQuery();
			}
			catch
			{
			}
		}
		catch (SqlCeException ex)
		{
			if (ex.Message == "Unspecified error")
			{
				throw new Exception("After installing Microsoft SQL Server Compact 3.5 Service Pack 2 runtime restart the computer");
			}
			throw;
		}
	}

	public static bool GetFormNotificationSetting()
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		sqlCeConnection.Open();
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "select FormNotification from Settings";
		using SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
		if (sqlCeDataReader.Read())
		{
			try
			{
				return (int)sqlCeDataReader["FormNotification"] == 1;
			}
			catch
			{
				return true;
			}
		}
		return true;
	}

	public static void DisableFormNotification()
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		sqlCeConnection.Open();
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "update Settings set FormNotification=0";
		sqlCeCommand.ExecuteNonQuery();
	}

	public static void EnableFormNotification()
	{
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		sqlCeConnection.Open();
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "update Settings set FormNotification=1";
		sqlCeCommand.ExecuteNonQuery();
	}

	public static void SetUserXmlFolder(string userXmlPath)
	{
		string name = WindowsIdentity.GetCurrent().Name;
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		sqlCeConnection.Open();
		using (SqlCeCommand sqlCeCommand = new SqlCeCommand())
		{
			sqlCeCommand.Connection = sqlCeConnection;
			sqlCeCommand.CommandType = CommandType.Text;
			sqlCeCommand.CommandText = "insert into UserXmlFolders (Username, FolderPath) \r\n                                        select '{Username}', ''\r\n                                        where not exists (select * from UserXmlFolders where Username='{Username}') ".Replace("{Username}", name);
			sqlCeCommand.ExecuteNonQuery();
		}
		using SqlCeCommand sqlCeCommand2 = new SqlCeCommand();
		sqlCeCommand2.Connection = sqlCeConnection;
		sqlCeCommand2.CommandType = CommandType.Text;
		sqlCeCommand2.CommandText = "update UserXmlFolders set FolderPath=@FolderPath where Username=@Username";
		sqlCeCommand2.Parameters.AddWithValue("FolderPath", userXmlPath);
		sqlCeCommand2.Parameters.AddWithValue("Username", name);
		sqlCeCommand2.ExecuteNonQuery();
	}

	public static string GetUserXmlFolder()
	{
		string name = WindowsIdentity.GetCurrent().Name;
		using SqlCeConnection sqlCeConnection = DatabaseConnection.Connection;
		sqlCeConnection.Open();
		using SqlCeCommand sqlCeCommand = new SqlCeCommand();
		sqlCeCommand.Connection = sqlCeConnection;
		sqlCeCommand.CommandType = CommandType.Text;
		sqlCeCommand.CommandText = "select FolderPath from UserXmlFolders where Username=@Username";
		sqlCeCommand.Parameters.AddWithValue("Username", name);
		using SqlCeDataReader sqlCeDataReader = sqlCeCommand.ExecuteReader();
		if (sqlCeDataReader.Read())
		{
			try
			{
				return (string)sqlCeDataReader["FolderPath"];
			}
			catch
			{
				return "";
			}
		}
		return "";
	}
}
