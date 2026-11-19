using System;
using System.Data.SqlServerCe;
using System.IO;
using xSAD_VIES.Common;

namespace xSAD_VIES.Database;

public static class DatabaseConnection
{
	private static SqlCeConnection _Connection;

	public static SqlCeConnection Connection
	{
		get
		{
			InitializeConnection();
			return _Connection;
		}
		set
		{
			_Connection = value;
		}
	}

	private static void InitializeConnection()
	{
		string actsDatabaseFolder = CommonFuncs.ActsDatabaseFolder;
		string fullPath = Path.GetFullPath(Path.Combine(actsDatabaseFolder, "xSAD-VIESv1.sdf"));
		string text;
		if (File.Exists(fullPath))
		{
			text = fullPath;
		}
		else
		{
			text = Path.GetFullPath(Path.Combine(Path.Combine(Environment.CurrentDirectory, "Database"), "xSAD-VIESv1.sdf"));
			if (!File.Exists(text))
			{
				throw new FileNotFoundException("Database file is not found in either of the 2 expected locations: " + fullPath + ", " + text);
			}
		}
		_Connection = new SqlCeConnection(string.Format("Data Source=" + text, actsDatabaseFolder));
	}
}
