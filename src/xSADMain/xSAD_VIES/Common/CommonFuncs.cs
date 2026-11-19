using System;
using System.IO;

namespace xSAD_VIES.Common;

public static class CommonFuncs
{
	public static string AllUsersApplicationDataFolder => Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	public static string ActsApplicationDataFolder => Path.Combine(AllUsersApplicationDataFolder, "AccountsTech\\Cyprus VIES Declaration");

	public static string ActsDatabaseFolder => Path.Combine(ActsApplicationDataFolder, "Database");

	public static string SanitizePathX(string path)
	{
		string text = Path.GetDirectoryName(path);
		char[] invalidPathChars = Path.GetInvalidPathChars();
		foreach (char oldChar in invalidPathChars)
		{
			text = text.Replace(oldChar, '_');
		}
		string text2 = Path.GetFileName(path);
		invalidPathChars = Path.GetInvalidFileNameChars();
		foreach (char oldChar2 in invalidPathChars)
		{
			text2 = text2.Replace(oldChar2, '_');
		}
		return text + text2;
	}

	public static string SanitizeName(string name)
	{
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char oldChar in invalidFileNameChars)
		{
			name = name.Replace(oldChar, '_');
		}
		return name;
	}
}
