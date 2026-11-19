using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using xSADReports;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;
using xSageDataObjects;

namespace xSAD_VIES.BL;

public static class Service
{
	private const int ColGoods = 5;

	private const int ColTriangle = 7;

	private const int ColServices = 8;

	public const string MessageMissingVatRegNumber = "Please provide a VAT Registration Number for this {0}. \r\n\r\nWithout the VAT Registration Number you will not be able to generate XML files for automatic submission\r\nto the Ministry of Finance TAXISNET service.";

	public const string MessageMissingVatRegNumber2 = "This {0} does not have a VAT Registration Number.\r\n \r\nIt is not possible to generate an XML file for automatic submission to the Ministry of Finance TAXISNET service\r\nunless you provide the VAT Registration Number.";

	private static Dictionary<string, string> _sageCountriesCache;

	private static Dictionary<string, string> _predefinedCountries = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
	{
		{ "Austria", "AT" },
		{ "Belgium", "BE" },
		{ "Bulgaria", "BG" },
		{ "Croatia", "HR" },
		{ "Cyprus", "CY" },
		{ "Czech Republic", "CZ" },
		{ "Denmark", "DK" },
		{ "Estonia", "EE" },
		{ "Finland", "FI" },
		{ "France", "FR" },
		{ "Germany", "DE" },
		{ "Greece", "EL" },
		{ "Greece GR", "GR" },
		{ "Hungary", "HU" },
		{ "Ireland", "IE" },
		{ "Italy", "IT" },
		{ "Latvia", "LV" },
		{ "Lithuania", "LT" },
		{ "Luxembourg", "LU" },
		{ "Malta", "MT" },
		{ "The Netherlands", "NL" },
		{ "Poland", "PL" },
		{ "Portugal", "PT" },
		{ "Romania", "RO" },
		{ "Slovakia", "SK" },
		{ "Slovenia", "SI" },
		{ "Spain", "ES" },
		{ "Sweden", "SE" },
		{ "United Kingdom", "GB" }
	};

	private static bool _loadCountriesFromSage = false;

	public static string UserXmlFolder
	{
		get
		{
			string text = Controller2.GetUserXmlFolder();
			if (text == "")
			{
				text = CommonFuncs.ActsApplicationDataFolder;
			}
			return text;
		}
	}

	public static bool GetFormNotificationSetting => Controller2.GetFormNotificationSetting();

	public static string GetUserXmlFolder
	{
		get
		{
			string text = Controller2.GetUserXmlFolder();
			if (text == "")
			{
				text = CommonFuncs.ActsApplicationDataFolder;
			}
			return text;
		}
	}

	public static ViesEntity ReadEntityFromGrid(ViesEntity entity, DataGridView dataGridView1, DateTimePicker dtPeriodFrom, DateTimePicker dtPeriodTo, ComboBox cbDeclarationMonth, ComboBox cbDeclarationYear, Label lblVatRegistration)
	{
		entity.ViesRows.Clear();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1.Rows)
		{
			if (!item.IsNewRow)
			{
				ViesRowEntity viesRowEntity = new ViesRowEntity();
				viesRowEntity.RowNumber = Convert.ToInt32(item.Cells[0].Value);
				viesRowEntity.CountryName = (item.Cells[1].Value ?? "").ToString();
				viesRowEntity.CountryCode = (item.Cells[2].Value ?? "").ToString();
				viesRowEntity.VatRegistrationNumber = (item.Cells[3].Value ?? "").ToString();
				viesRowEntity.CustomerName = (item.Cells[4].Value ?? "").ToString();
				viesRowEntity.SuppliesAmount = Convert.ToDecimal(item.Cells[5].Value ?? "0");
				viesRowEntity.TriangleTransactionsAmount = Convert.ToDecimal(item.Cells[7].Value ?? "0");
				viesRowEntity.ServicesAmount = Convert.ToDecimal(item.Cells[8].Value ?? "0");
				entity.ViesRows.Add(viesRowEntity);
			}
		}
		entity.PeriodFrom = dtPeriodFrom.Value;
		entity.PeriodTo = dtPeriodTo.Value;
		entity.TaxPayer = lblVatRegistration.Text;
		entity.DeclarationMonth = cbDeclarationMonth.SelectedIndex + 1;
		entity.DeclarationYear = Convert.ToInt32(cbDeclarationYear.Text);
		return entity;
	}

	public static void SetEntityOnGrid(ViesEntity entity, DataGridView dataGridView1, DateTimePicker dtPeriodFrom, DateTimePicker dtPeriodTo, ComboBox cbDeclarationMonth, ComboBox cbDeclarationYear)
	{
		try
		{
			dtPeriodFrom.Value = entity.PeriodFrom;
		}
		catch
		{
		}
		try
		{
			dtPeriodTo.Value = entity.PeriodTo;
		}
		catch
		{
		}
		cbDeclarationMonth.SelectedIndex = entity.DeclarationMonth - 1;
		cbDeclarationYear.SelectedValue = entity.DeclarationYear;
		cbDeclarationYear.SelectedIndex = -1;
		for (int i = 0; i < cbDeclarationYear.Items.Count; i++)
		{
			if ((int)cbDeclarationYear.Items[i] == entity.DeclarationYear)
			{
				cbDeclarationYear.SelectedIndex = i;
			}
		}
	}

	public static List<string> CompareEntities(List<ViesRowEntity> viesRows, List<ViesRowEntity> calculatedRows)
	{
		List<string> list = new List<string>();
		foreach (ViesRowEntity calculatedRow in calculatedRows)
		{
			ViesRowEntity row = calculatedRow;
			ViesRowEntity viesRowEntity = viesRows.Find((ViesRowEntity c) => c.CountryCode == row.CountryCode && c.VatRegistrationNumber == row.VatRegistrationNumber);
			if (viesRowEntity != null)
			{
				string arg = viesRowEntity.CountryCode + "/" + viesRowEntity.VatRegistrationNumber;
				if (calculatedRow.CountryName != viesRowEntity.CountryName)
				{
					list.Add($"VAT {arg}: Country: from {viesRowEntity.CountryName} to {calculatedRow.CountryName}");
				}
				if (calculatedRow.CustomerName != viesRowEntity.CustomerName)
				{
					list.Add($"VAT {arg}: Customer name: from {viesRowEntity.CustomerName} to {calculatedRow.CustomerName}");
				}
				if (calculatedRow.SuppliesAmount != viesRowEntity.SuppliesAmount)
				{
					list.Add($"VAT {arg}: Supplies amount: from {viesRowEntity.SuppliesAmount} to {calculatedRow.SuppliesAmount}");
				}
				if (calculatedRow.TriangleTransactionsAmount != viesRowEntity.TriangleTransactionsAmount)
				{
					list.Add($"VAT {arg}: Triangle transactions amount: from {viesRowEntity.TriangleTransactionsAmount} to {calculatedRow.TriangleTransactionsAmount}");
				}
				if (calculatedRow.ServicesAmount != viesRowEntity.ServicesAmount)
				{
					list.Add($"VAT {arg}: Services amount: from {viesRowEntity.ServicesAmount} to {calculatedRow.ServicesAmount}");
				}
			}
		}
		return list;
	}

	public static void AssignNewValues(ViesEntity vatEntity, List<ViesRowEntity> calculatedEntity)
	{
		foreach (ViesRowEntity item in calculatedEntity)
		{
			ViesRowEntity row = item;
			ViesRowEntity viesRowEntity = vatEntity.ViesRows.Find((ViesRowEntity c) => c != null && c.CountryCode == row.CountryCode && c.VatRegistrationNumber == row.VatRegistrationNumber);
			if (viesRowEntity == null)
			{
				vatEntity.ViesRows.Add(item);
				continue;
			}
			viesRowEntity.ServicesAmount = item.ServicesAmount;
			viesRowEntity.SuppliesAmount = item.SuppliesAmount;
			viesRowEntity.TriangleTransactionsAmount = item.TriangleTransactionsAmount;
			viesRowEntity.CustomerName = item.CustomerName;
			viesRowEntity.CountryName = item.CountryName;
		}
	}

	public static ViesEntity MergeValues(ViesEntity viesEntity, ViesEntity newEntity)
	{
		foreach (ViesRowEntity viesRow in newEntity.ViesRows)
		{
			ViesRowEntity row = viesRow;
			ViesRowEntity viesRowEntity = viesEntity.ViesRows.Find((ViesRowEntity c) => c != null && c.CountryCode == row.CountryCode && c.VatRegistrationNumber == row.VatRegistrationNumber);
			if (viesRowEntity == null)
			{
				viesEntity.ViesRows.Add(viesRow);
				continue;
			}
			viesRowEntity.SuppliesAmount += viesRow.SuppliesAmount;
			viesRowEntity.TriangleTransactionsAmount += viesRow.TriangleTransactionsAmount;
			viesRowEntity.ServicesAmount += viesRow.ServicesAmount;
		}
		return viesEntity;
	}

	public static VIES.TransactionSplitsDataTable Calculate(DateTime periodFrom, DateTime periodTo, SageCompany sageCompanyEntity)
	{
		string sageConnectionString = sageCompanyEntity.SageConnectionString;
		using OdbcConnection odbcConnection = new OdbcConnection();
		odbcConnection.ConnectionString = sageConnectionString;
		return DataReader_VIES.GetTransactions(odbcConnection, periodFrom, periodTo);
	}

	internal static void CheckDatabase()
	{
		string actsDatabaseFolder = CommonFuncs.ActsDatabaseFolder;
		Directory.CreateDirectory(actsDatabaseFolder);
		string text = Path.Combine(actsDatabaseFolder, "xSAD-VIESv1.sdf");
		if (!File.Exists(text))
		{
			string text2 = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "xSAD-VIESv1.sdf");
			Directory.CreateDirectory(CommonFuncs.ActsDatabaseFolder);
			if (File.Exists(text2))
			{
				File.Copy(text2, text);
			}
		}
		Controller2.ApplyDatabaseUpdates();
	}

	public static string GetActiveSagePath()
	{
		string text = "";
		string sageVersion = Controller2.GetSageVersion();
		if (sageVersion != "")
		{
			text = xSAD_VIES.DAL.SageController.GetSagePath(sageVersion);
		}
		if (text == "" || !Directory.Exists(text))
		{
			text = xSAD_VIES.DAL.SageController.AutoDetectSagePath();
		}
		return text;
	}

	public static DateTime ExtractDateFrom(string period)
	{
		try
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return DateTime.ParseExact(period.Remove(8, 9), "yyyyMMdd", invariantCulture);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static DateTime ExtractDateTo(string period)
	{
		try
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return DateTime.ParseExact(period.Remove(0, 9), "yyyyMMdd", invariantCulture);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static void RenameGroupFolder(string codeFrom, string codeTo)
	{
		try
		{
			string sourceDirName = XmlFuncs.GenerateXmlFilenameForGroupEntity(codeFrom);
			string destDirName = XmlFuncs.GenerateXmlFilenameForGroupEntity(codeTo);
			Directory.Move(sourceDirName, destDirName);
		}
		catch
		{
		}
	}

	public static void RenameMultipleEntityFolder(string codeFrom, string codeTo)
	{
		try
		{
			string sourceDirName = XmlFuncs.GenerateXmlFilenameForMultipleEntity(codeFrom);
			string destDirName = XmlFuncs.GenerateXmlFilenameForMultipleEntity(codeTo);
			Directory.Move(sourceDirName, destDirName);
		}
		catch
		{
		}
	}

	public static void DisableFormNotification()
	{
		Controller2.DisableFormNotification();
	}

	public static void CheckLicensing()
	{
		if (!Debugger.IsAttached && !ReadLicensingKey())
		{
			MessageBox.Show("ACTS: Could not validate licensing. You will need to reinstall the application\r\n\r\nPlease contact AccountsTech Software");
			Environment.Exit(0);
		}
	}

	private static bool ReadLicensingKey()
	{
		return true;
	}

	public static List<TransactionEntity> ConvertDataTable(VIES.TransactionSplitsDataTable dataTable)
	{
		List<TransactionEntity> list = new List<TransactionEntity>();
		foreach (VIES.TransactionSplitsRow item in dataTable)
		{
			if ((short)item["EU_MEMBER"] != 0)
			{
				TransactionEntity transactionEntity = new TransactionEntity();
				transactionEntity.TransactionNumber = (int)item["TRAN_NUMBER"];
				transactionEntity.TransactionType = (string)item["TYPE"];
				transactionEntity.AccountReference = (string)item["ACCOUNT_REF"];
				transactionEntity.AccountName = (string)item["NAME"];
				transactionEntity.GrossAmount = Convert.ToDecimal((double)item["GROSS_AMOUNT"]);
				transactionEntity.NetAmount = Convert.ToDecimal((double)item["NET_AMOUNT"]);
				transactionEntity.DateEntered = (DateTime)item["DATE_ENTERED"];
				transactionEntity.TransactionDate = (DateTime)item["TRAN_DATE"];
				transactionEntity.CountryCode = (string)item["COUNTRY_CODE"];
				transactionEntity.CountryName = (string)item["COUNTRY_NAME"];
				transactionEntity.VatRegistrationNumber = (string)item["VAT_REG_NUMBER"];
				transactionEntity.GoodServiceText = ((string)item["GOODS_SERVICES_TEXT"]) ?? "";
				transactionEntity.InvoiceNumber = ((string)item["INV_REF"]) ?? "";
				string text = ((string)item["GOODS_SERVICES_TEXT"]) ?? "";
				transactionEntity.TransactionGroupX = ((!(text == "Goods")) ? TransactionGroup.Services : TransactionGroup.Goods);
				transactionEntity.IsTriangular = false;
				list.Add(transactionEntity);
			}
		}
		return list;
	}

	public static List<ViesRowEntity> GroupTransactions(List<TransactionEntity> transactionsList)
	{
		List<ViesRowEntity> list = new List<ViesRowEntity>();
		foreach (TransactionEntity transactions in transactionsList)
		{
			TransactionEntity transaction1 = transactions;
			ViesRowEntity viesRowEntity = list.Find((ViesRowEntity c) => c.CountryCode == transaction1.CountryCode && c.VatRegistrationNumber == transaction1.VatRegistrationNumber);
			ViesRowEntity viesRowEntity2;
			if (viesRowEntity == null)
			{
				viesRowEntity2 = new ViesRowEntity
				{
					CountryCode = transactions.CountryCode,
					CountryName = transactions.CountryName,
					VatRegistrationNumber = transactions.VatRegistrationNumber,
					CustomerName = transactions.AccountName,
					ServicesAmount = 0m,
					SuppliesAmount = 0m,
					TriangleTransactionsAmount = 0m
				};
				list.Add(viesRowEntity2);
			}
			else
			{
				viesRowEntity2 = viesRowEntity;
			}
			if (transactions.IsTriangular)
			{
				viesRowEntity2.TriangleTransactionsAmount += transactions.NetAmount;
			}
			else if (transactions.TransactionGroupX == TransactionGroup.Goods)
			{
				viesRowEntity2.SuppliesAmount += transactions.NetAmount;
			}
			else
			{
				viesRowEntity2.ServicesAmount += transactions.NetAmount;
			}
		}
		foreach (ViesRowEntity item in list)
		{
			item.ServicesAmount = Math.Round(item.ServicesAmount);
			item.SuppliesAmount = Math.Round(item.SuppliesAmount);
			item.TriangleTransactionsAmount = Math.Round(item.TriangleTransactionsAmount);
		}
		return list.Where((ViesRowEntity r) => r.ServicesAmount != 0m || r.SuppliesAmount != 0m || r.TriangleTransactionsAmount != 0m).ToList();
	}

	public static void ShowViesSubmissionForm(ViesEntity viesEntity, Form form1)
	{
		form1.Cursor = Cursors.WaitCursor;
		try
		{
			foreach (ViesRowEntity viesRow in viesEntity.ViesRows)
			{
				viesRow.CountryName = GetCountryName(viesRow.CountryCode);
			}
			rptVIESSubmissionForm rptVIESSubmissionForm = new rptVIESSubmissionForm();
			rptVIESSubmissionForm.TaxPayerValue = viesEntity.TaxPayer;
			rptVIESSubmissionForm.DataSource = viesEntity.ViesRows;
			rptVIESSubmissionForm.SetTotals(viesEntity.TotalRows, viesEntity.SumSuppliesAmount, viesEntity.SumTriangleTransactionsAmount, viesEntity.SumServicesAmount);
			rptVIESSubmissionForm.SetDates(viesEntity.PeriodFrom, viesEntity.PeriodTo, viesEntity.DeclarationMonth.ToString(), viesEntity.DeclarationYear.ToString(), "Ημερομηνία εκτύπωσης");
			frmPreview frmPreview = new frmPreview(rptVIESSubmissionForm, GetFormNotificationSetting);
			frmPreview.Text = "VIES Declaration Form";
			frmPreview.ShowDialog();
			if (frmPreview.DisableNotification)
			{
				DisableFormNotification();
			}
		}
		finally
		{
			form1.Cursor = Cursors.Default;
		}
	}

	public static Dictionary<string, string> GetCountries(bool loadFromSage, string connectionString)
	{
		if (!loadFromSage)
		{
			_loadCountriesFromSage = loadFromSage;
			return _predefinedCountries;
		}
		_sageCountriesCache = xSAD_VIES.DAL.SageController.GetCountries(connectionString);
		_loadCountriesFromSage = loadFromSage;
		return _sageCountriesCache;
	}

	private static Dictionary<string, string> GetActiveCountriesCache()
	{
		if (_loadCountriesFromSage)
		{
			return _sageCountriesCache;
		}
		return _predefinedCountries;
	}

	public static string GetCountryName(string countryCode)
	{
		foreach (KeyValuePair<string, string> item in GetActiveCountriesCache())
		{
			if (item.Value == countryCode.ToUpper())
			{
				return item.Key;
			}
		}
		return "";
	}

	public static string GetCountryCode(string countryName)
	{
		if (GetActiveCountriesCache().TryGetValue(countryName, out var value))
		{
			return value;
		}
		return "";
	}
}
