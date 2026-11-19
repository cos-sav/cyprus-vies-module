using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Windows.Forms;
using xSAD_VIES.BL;
using xSAD_VIES.Common;
using xSAD_VIES.Entities;
using xSageDataObjects;

namespace xSAD_VIES.DAL;

public static class SageController
{
	public static string AutoDetectSagePath()
	{
		// Newest recognised Sage data folder that actually lists companies (has a COMPANY file);
		// an empty folder left behind by an uninstalled version is skipped.
		string accountsFolder = Path.Combine(CommonFuncs.AllUsersApplicationDataFolder, "Sage\\Accounts");
		if (!Directory.Exists(accountsFolder))
		{
			return "";
		}
		string bestPath = "";
		int bestVersion = 0;
		foreach (string folder in Directory.GetDirectories(accountsFolder))
		{
			int sdoVersion;
			if (TryParseSageFolder(Path.GetFileName(folder), out sdoVersion) && sdoVersion > bestVersion && File.Exists(Path.Combine(folder, "COMPANY")))
			{
				bestPath = folder;
				bestVersion = sdoVersion;
			}
		}
		return bestPath;
	}

	/// <summary>
	/// Maps a Sage data folder name to its Sage Data Objects version:
	/// "2009".."2026" are v15..v32 (year - 1994), "V33" style names are taken as is.
	/// </summary>
	public static bool TryParseSageFolder(string folderName, out int sdoVersion)
	{
		sdoVersion = 0;
		if (string.IsNullOrEmpty(folderName))
		{
			return false;
		}
		int number;
		if (folderName.Length == 4 && int.TryParse(folderName, out number))
		{
			sdoVersion = number - 1994;
		}
		else if ((folderName[0] == 'V' || folderName[0] == 'v') && int.TryParse(folderName.Substring(1), out number))
		{
			sdoVersion = number;
		}
		return Enum.IsDefined(typeof(SdoVersion), sdoVersion) && sdoVersion >= (int)SdoVersion.v15;
	}

	public static string GetSagePath(string sageVersion)
	{
		return Path.Combine(CommonFuncs.AllUsersApplicationDataFolder, "Sage\\Accounts\\" + sageVersion);
	}

	private static string ExtractSageCompanyName(string companySetupFile)
	{
		byte[] array = File.ReadAllBytes(companySetupFile);
		string text = "";
		for (int i = 3; i < array.Length; i++)
		{
			byte b = array[i];
			if (b == 0)
			{
				break;
			}
			text += Convert.ToChar(b);
		}
		return text;
	}

	private static int FindOffset(byte[] bytes, string vatRegistration)
	{
		for (int i = 0; i < bytes.Length - 10; i++)
		{
			string text = string.Empty;
			for (int j = i; j < bytes.Length; j++)
			{
				byte b = bytes[j];
				if (b == 0)
				{
					break;
				}
				text += Convert.ToChar(b);
			}
			if (text.Trim().Equals(vatRegistration, StringComparison.InvariantCultureIgnoreCase))
			{
				return i;
			}
		}
		return 0;
	}

	private static string ExtractSageVatRegistration(string companySetupFile, SdoVersion sageVersion)
	{
		byte[] array = File.ReadAllBytes(companySetupFile);
		int num = sageVersion switch
		{
			SdoVersion.v10 => 3898, 
			SdoVersion.v11 => 3898, 
			SdoVersion.v12 => 3898, 
			SdoVersion.v13 => 3898, 
			SdoVersion.v14 => 3898, 
			SdoVersion.v15 => 3898, 
			SdoVersion.v16 => 3898, 
			SdoVersion.v17 => 5326, 
			SdoVersion.v18 => 6627, 
			SdoVersion.v19 => 6732, 
			SdoVersion.v20 => 6738, 
			SdoVersion.v21 => 3960, 
			SdoVersion.v22 => 3967, 
			SdoVersion.v23 => 3967, 
			SdoVersion.v24 => 4004, 
			SdoVersion.v25 => 4004, 
			SdoVersion.v26 => 4004, 
			SdoVersion.v27 => 4002, 
			SdoVersion.v28 => 4002, 
			SdoVersion.v29 => 4277, 
			SdoVersion.v30 => 4277, 
			SdoVersion.v31 => 4277, 
			SdoVersion.v32 => 4277, 
			SdoVersion.v33 => 4277, 
			_ => throw new ArgumentOutOfRangeException("sageVersion", $"Sage version {sageVersion} not supported"), 
		};
		string text = "";
		for (int i = num; i < array.Length; i++)
		{
			byte b = array[i];
			if (b == 0)
			{
				break;
			}
			text += Convert.ToChar(b);
		}
		return text.Trim();
	}

	public static List<SageCompany> SelectAllSageCompanies()
	{
		List<SageCompany> list = new List<SageCompany>();
		string activeSagePath = Service.GetActiveSagePath();
		// The Sage data folder is ...\Sage\Accounts\<2009..2026 or V33>. When it can't be found or
		// recognised, return no companies so the main window still opens and the user can fix it
		// in Settings > Path Configuration (throwing here used to stop the app from starting).
		string text = string.IsNullOrEmpty(activeSagePath) ? "" : Path.GetFileName(activeSagePath.TrimEnd('\\'));
		int sdoVersion;
		if (!TryParseSageFolder(text, out sdoVersion))
		{
			return list;
		}
		if (text[0] == 'v')
		{
			text = text.ToUpperInvariant();
		}
		SdoVersion sageVersion = (SdoVersion)sdoVersion;
		string newValue = "{Sage Line 50 v" + sdoVersion + "}";
		string path = Path.Combine(activeSagePath, "COMPANY");
		if (!File.Exists(path))
		{
			return list;
		}
		List<string> list2 = new List<string>();
		string[] array = File.ReadAllLines(path);
		for (int j = 0; j < array.Length; j++)
		{
			string text2 = array[j].Trim();
			if (!(text2 == "") && Directory.Exists(text2))
			{
				list2.Add(text2);
			}
		}
		foreach (string item2 in list2)
		{
			string text3 = Path.Combine(item2, "ACCDATA\\SETUP.DTA");
			text3 = text3.ToUpper().Replace("ACCDATA\\ACCDATA\\", "ACCDATA\\");
			if (File.Exists(text3))
			{
				string name = ExtractSageCompanyName(text3).Trim();
				string sageVatRegistrationNumber = ExtractSageVatRegistration(text3, sageVersion).Trim();
				string sageAddress = "";
				string sageAddress2 = "";
				string sageAddress3 = "";
				string sageAddress4 = "";
				string sageAddress5 = "";
				string sageConnectionString = "Driver={SageVersion};uid={username};pwd={password};dir={CompanyPath}\\Accdata".Replace("{SageVersion}", newValue).Replace("{CompanyPath}", item2);
				string text4 = "";
				if (item2.Contains("\\"))
				{
					text4 = item2.Substring(item2.LastIndexOf("\\") + 1);
				}
				string getUserXmlFolder = Service.GetUserXmlFolder;
				getUserXmlFolder = Path.Combine(getUserXmlFolder, text + "-" + text4);
				SageCompany item = new SageCompany
				{
					CompanyCode = text + "-" + text4,
					Name = name,
					SagePath = item2,
					SageSetupFile = text3,
					SageAddress1 = sageAddress,
					SageAddress2 = sageAddress2,
					SageAddress3 = sageAddress3,
					SageAddress4 = sageAddress4,
					SageAddress5 = sageAddress5,
					SageVatRegistrationNumber = sageVatRegistrationNumber,
					SageVersion = sageVersion,
					SageConnectionString = sageConnectionString,
					CompanyXmlPath = getUserXmlFolder
				};
				list.Add(item);
			}
		}
		return list;
	}

	public static SageCompany GetSageCompanyFromCompanyCode(string companyCode)
	{
		foreach (SageCompany item in SelectAllSageCompanies())
		{
			if (item.CompanyCode == companyCode)
			{
				return item;
			}
		}
		return null;
	}

	private static List<SageCompany> GetSageCompaniesList(GroupsTable companies)
	{
		List<SageCompany> list = new List<SageCompany>();
		for (int i = 0; i < companies.Rows.Count; i++)
		{
			SageCompany sageCompanyFromCompanyCode = GetSageCompanyFromCompanyCode((string)companies.Rows[i]["CompanyCode"]);
			if (sageCompanyFromCompanyCode != null)
			{
				list.Add(sageCompanyFromCompanyCode);
			}
		}
		return list;
	}

	public static List<SageCompany> GetSageCompaniesListForGroupIdIncludeOnly(int groupId)
	{
		return GetSageCompaniesList(Controller.SelectAllIncludedCompanies(groupId));
	}

	public static ViesEntity MergeVatEntityForGroupId(int groupId)
	{
		List<SageCompany> sageCompaniesListForGroupIdIncludeOnly = GetSageCompaniesListForGroupIdIncludeOnly(groupId);
		string text = "";
		ViesEntity viesEntity = new ViesEntity();
		bool flag = false;
		foreach (SageCompany item in sageCompaniesListForGroupIdIncludeOnly)
		{
			string companyPeriod = Controller2.GetCompanyPeriod(groupId, item.CompanyCode);
			DateTime dateTime = Service.ExtractDateFrom(companyPeriod);
			DateTime periodTo = Service.ExtractDateTo(companyPeriod);
			if (dateTime == DateTime.MinValue)
			{
				MessageBox.Show("Some of the entries do not have a selected period");
				return null;
			}
			if (text == "")
			{
				text = companyPeriod;
			}
			if (companyPeriod != text && !flag)
			{
				flag = true;
				if (MessageBox.Show("The entries of this group have different date periods.\r\n\r\nContinue?", "", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
				{
					return null;
				}
			}
			string path = XmlFuncs.GenerateXmlFilename(item.CompanyCode, dateTime, periodTo);
			string text2 = Path.Combine(item.CompanyXmlPath, path);
			if (File.Exists(text2))
			{
				ViesEntity newEntity = XmlFuncs.ReadEntityFromXml(text2);
				viesEntity = Service.MergeValues(viesEntity, newEntity);
			}
		}
		return viesEntity;
	}

	public static List<ViesEntity> GetVatEntitiesForMultiId(int multiGroupId)
	{
		List<ViesEntity> list = new List<ViesEntity>();
		string text = "";
		bool flag = false;
		GroupsTable groupsTable = Controller.SelectAllChildrenCompanies(multiGroupId);
		for (int i = 0; i < groupsTable.Rows.Count; i++)
		{
			bool flag2 = (bool)groupsTable.Rows[i]["IsGroup"];
			string companyCode = (string)groupsTable.Rows[i]["CompanyCode"];
			int groupId = (int)groupsTable.Rows[i]["FKGroupId"];
			string text2 = (string)groupsTable.Rows[i]["Period"];
			DateTime dateTime = Service.ExtractDateFrom(text2);
			DateTime periodTo = Service.ExtractDateTo(text2);
			bool num = (bool)groupsTable.Rows[i]["Include"];
			string companyName = (string)groupsTable.Rows[i]["Name"];
			if (!num)
			{
				continue;
			}
			if (dateTime == DateTime.MinValue)
			{
				MessageBox.Show("Some of the entries do not have a selected period");
				return null;
			}
			if (text == "")
			{
				text = text2;
			}
			if (text2 != text && !flag)
			{
				flag = true;
				if (MessageBox.Show("The entries of this group have different date periods.\r\n\r\nContinue?", "", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
				{
					return null;
				}
			}
			ViesEntity item = ((!flag2) ? GetCompanyVatEntity(companyCode, companyName, dateTime, periodTo) : GetGroupVatEntity(groupId, dateTime, periodTo));
			list.Add(item);
		}
		return list;
	}

	public static ViesEntity GetCompanyVatEntity(string companyCode, string companyName, DateTime periodFrom, DateTime periodTo)
	{
		foreach (ViesEntity companyViesEntity in XmlFuncs.GetCompanyViesEntities(GetSageCompanyFromCompanyCode(companyCode)))
		{
			if (companyViesEntity.PeriodFrom == periodFrom && companyViesEntity.PeriodTo == periodTo)
			{
				return companyViesEntity;
			}
		}
		if (companyName == "")
		{
			companyName = companyCode;
		}
		MessageBox.Show("Could not find XML file for selected period for company " + companyName);
		return new ViesEntity();
	}

	public static ViesEntity GetGroupVatEntity(int groupId, DateTime periodFrom, DateTime periodTo)
	{
		string groupName = Controller.GetGroupName(groupId);
		foreach (ViesEntity groupViesEntity in XmlFuncs.GetGroupViesEntities(groupId))
		{
			if (groupViesEntity.PeriodFrom == periodFrom && groupViesEntity.PeriodTo == periodTo)
			{
				return groupViesEntity;
			}
		}
		MessageBox.Show("Could not find XML file for selected period for group " + groupName);
		return new ViesEntity();
	}

	public static Dictionary<string, string> GetCountries(string connectionString)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		using OdbcConnection odbcConnection = new OdbcConnection(connectionString);
		odbcConnection.Open();
		using OdbcCommand odbcCommand = new OdbcCommand("SELECT CODE, NAME FROM COUNTRY_CODE", odbcConnection);
		DataTable dataTable = new DataTable();
		using OdbcDataReader reader = odbcCommand.ExecuteReader();
		dataTable.Load(reader);
		foreach (object row in dataTable.Rows)
		{
			string value = (string)((DataRow)row)["CODE"];
			string key = (string)((DataRow)row)["NAME"];
			dictionary[key] = value;
		}
		return dictionary;
	}
}
