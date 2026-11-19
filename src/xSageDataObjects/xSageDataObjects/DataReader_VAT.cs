using System;
using System.Data.Odbc;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using xSageDataObjects.NominalTableAdapters;
using xSageDataObjects.VATTableAdapters;

namespace xSageDataObjects;

/// <summary>
/// This class provides a number of shared methods that can be used to retrieve various sets of transactions.  
/// </summary>
/// <remarks>
/// </remarks>
public class DataReader_VAT
{
	/// <summary>
	/// Stores full transactions list for the last specified calculation period.
	/// This table is automatically updated if the last call to a GetTotal_BoxX method had parameters 
	/// that were different from the previous ones.
	/// </summary>
	/// <remarks></remarks>
	private static VAT.TransactionSplitsDataTable _lastLastTransactionsTable;

	/// <summary>
	/// Stores last specified From date. This variable is updated each time a GetTotal_BoxX method is called.
	/// </summary>
	/// <remarks></remarks>
	private static DateTime _lastDateFrom;

	/// <summary>
	/// Stores last specified To date. This variable is updated each time a GetTotal_BoxX method is called.
	/// </summary>
	/// <remarks></remarks>
	private static DateTime _lastDateTo;

	/// <summary>
	/// Stores last specified includePreviousUnreconciled flag. This variable is updated each time a GetTotal_BoxX method is called.
	/// </summary>
	/// <remarks></remarks>
	private static bool _lastincludePreviousUnreconciledFlag;

	public static bool LoadQueriesFromFile { get; set; }

	static DataReader_VAT()
	{
		LoadQueriesFromFile = true;
	}

	/// <summary>
	/// Gets all unreconciled transactions for the specified period which are relevant for VAT calculations.
	/// </summary>
	/// <param name="dateFrom"></param>
	/// <param name="dateTo"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static VAT.TransactionSplitsDataTable GetTransactions_All(OdbcConnection connection, DateTime dateFrom, DateTime dateTo)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		TransactionSplits transactionSplits = new TransactionSplits();
		transactionSplits.Connection = connection;
		transactionSplits.ClearBeforeFill = true;
		try
		{
			transactionSplits.Fill_AllBoxes(transactionSplitsDataTable, dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"));
			return transactionSplitsDataTable;
		}
		finally
		{
			if (transactionSplits != null)
			{
				transactionSplits.Dispose();
				transactionSplits = null;
			}
		}
	}

	/// <summary>
	/// Gets all unreconciled transactions dated prior to and within the specified period which are relevant for VAT calculations and groups them together by Box number. 
	/// </summary>
	/// <param name="dateFrom"></param>
	/// <param name="dateTo"></param>
	/// <returns></returns>
	/// <remarks>
	/// Returned table will contain certain transactions multiple times. Boxes 3 and 5 will not appear in the table since they report totals and 
	/// do not contain any transactions.
	/// </remarks>
	public static VAT.TransactionSplitsDataTable GetTransactions_PerBox(OdbcConnection connection, DateTime dateFrom, DateTime dateTo, VAT_AllBoxFilters filters, bool includePreviousUnreconciled = true)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		VAT.TransactionSplitsDataTable table = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable table2 = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable Table = new VAT.TransactionSplitsDataTable();
		if (!IsSameAsLastPeriod(dateFrom, dateTo, includePreviousUnreconciled))
		{
			GetTotal_TransactionsAll(connection, dateFrom, dateTo, includePreviousUnreconciled);
		}
		if (includePreviousUnreconciled)
		{
			FilterAndMergeBoxTransactions(filters.Box1, DateTime.MinValue, dateFrom.AddDays(-1.0), "01", table);
			FilterAndMergeBoxTransactions(filters.Box2, DateTime.MinValue, dateFrom.AddDays(-1.0), "02", table);
			FilterAndMergeBoxTransactions(filters.Box4, DateTime.MinValue, dateFrom.AddDays(-1.0), "04", table);
			FilterAndMergeBoxTransactions(filters.Box6, DateTime.MinValue, dateFrom.AddDays(-1.0), "06", table);
			FilterAndMergeBoxTransactions(filters.Box7, DateTime.MinValue, dateFrom.AddDays(-1.0), "07", table);
			FilterAndMergeBoxTransactions(filters.Box8a, DateTime.MinValue, dateFrom.AddDays(-1.0), "08A", table);
			FilterAndMergeBoxTransactions(filters.Box8b, DateTime.MinValue, dateFrom.AddDays(-1.0), "08B", table);
			FilterAndMergeBoxTransactions(filters.Box9, DateTime.MinValue, dateFrom.AddDays(-1.0), "09", table);
			FilterAndMergeBoxTransactions(filters.Box10, DateTime.MinValue, dateFrom.AddDays(-1.0), "10", table);
			FilterAndMergeBoxTransactions(filters.Box11a, DateTime.MinValue, dateFrom.AddDays(-1.0), "11A", table);
			FilterAndMergeBoxTransactions(filters.Box11b, DateTime.MinValue, dateFrom.AddDays(-1.0), "11B", table);
		}
		FilterAndMergeBoxTransactions(filters.Box1, dateFrom, dateTo, "01", table2);
		FilterAndMergeBoxTransactions(filters.Box2, dateFrom, dateTo, "02", table2);
		FilterAndMergeBoxTransactions(filters.Box4, dateFrom, dateTo, "04", table2);
		FilterAndMergeBoxTransactions(filters.Box6, dateFrom, dateTo, "06", table2);
		FilterAndMergeBoxTransactions(filters.Box7, dateFrom, dateTo, "07", table2);
		FilterAndMergeBoxTransactions(filters.Box8a, dateFrom, dateTo, "08A", table2);
		FilterAndMergeBoxTransactions(filters.Box8b, dateFrom, dateTo, "08B", table2);
		FilterAndMergeBoxTransactions(filters.Box9, dateFrom, dateTo, "09", table2);
		FilterAndMergeBoxTransactions(filters.Box10, dateFrom, dateTo, "10", table2);
		FilterAndMergeBoxTransactions(filters.Box11a, dateFrom, dateTo, "11A", table2);
		FilterAndMergeBoxTransactions(filters.Box11b, dateFrom, dateTo, "11B", table2);
		_lastLastTransactionsTable.DefaultView.RowFilter = "";
		Table.Merge(table);
		Table.Merge(table2);
		CommonMethods.FixTransactionSigns(ref Table);
		CommonMethods.CalculateTaxValues(ref Table, connection);
		return Table;
	}

	private static void FilterAndMergeBoxTransactions(VAT_BoxFilter filter, DateTime dateFrom, DateTime dateTo, string boxCode, VAT.TransactionSplitsDataTable table)
	{
		if (!string.IsNullOrWhiteSpace(filter.AddFilter))
		{
			FilterAndMergeBoxTransactions(filter.AddFilter, isAdd: true, dateFrom, dateTo, boxCode, table);
		}
		if (!string.IsNullOrWhiteSpace(filter.SubtractFilter))
		{
			FilterAndMergeBoxTransactions(filter.SubtractFilter, isAdd: false, dateFrom, dateTo, boxCode, table);
		}
	}

	private static void FilterAndMergeBoxTransactions(string filter, bool isAdd, DateTime dateFrom, DateTime dateTo, string boxCode, VAT.TransactionSplitsDataTable table)
	{
		PerformFilter(filter, dateFrom, dateTo);
		ApplyCodeAndMergeTransactionInto(boxCode, isAdd, table);
	}

	/// <summary>
	/// Gets a list of all tax codes.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static VAT.TaxCodesDataTable GetTaxCodes(OdbcConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		VAT.TaxCodesDataTable taxCodesDataTable = new VAT.TaxCodesDataTable();
		xSageDataObjects.VATTableAdapters.TaxCodes taxCodes = new xSageDataObjects.VATTableAdapters.TaxCodes();
		taxCodes.Connection = connection;
		taxCodes.ClearBeforeFill = true;
		try
		{
			taxCodes.Fill(taxCodesDataTable);
			return taxCodesDataTable;
		}
		finally
		{
			if (taxCodes != null)
			{
				taxCodes.Dispose();
				taxCodes = null;
			}
		}
	}

	public static double CalculateBoxTotal(OdbcConnection connection, DateTime dateFrom, DateTime dateTo, bool isTax, string filter, bool roundToNearestInteger, bool includePreviousUnreconciled = true)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable table = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable table2 = new VAT.TransactionSplitsDataTable();
		if (!IsSameAsLastPeriod(dateFrom, dateTo, includePreviousUnreconciled))
		{
			GetTotal_TransactionsAll(connection, dateFrom, dateTo, includePreviousUnreconciled);
		}
		new StringBuilder(filter);
		if (includePreviousUnreconciled)
		{
			PerformFilter(filter, DateTime.MinValue, dateFrom.AddDays(-1.0));
			MergeTransactionInto(table);
		}
		PerformFilter(filter, dateFrom, dateTo);
		MergeTransactionInto(table2);
		transactionSplitsDataTable.Merge(table);
		transactionSplitsDataTable.Merge(table2);
		_lastLastTransactionsTable.DefaultView.RowFilter = "";
		return Convert.ToDouble(new decimal(CalculateTotalAmount(transactionSplitsDataTable, isTax, roundToNearestInteger)));
	}

	/// <summary>
	/// Gets all unreconciled transactions for the specified period which are relevant for box calculations.
	/// </summary>
	/// <param name="includePreviousUnreconciled">If set to TRUE unreconciled transactions dated prior to the specified dateFrom
	/// parameter will be included in the calculations.</param>
	/// <param name="dateFrom"></param>
	/// <param name="dateTo"></param>
	public static VAT.TransactionSplitsDataTable GetTotal_TransactionsAll(OdbcConnection connection, DateTime dateFrom, DateTime dateTo, bool includePreviousUnreconciled = true)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		if (!IsSameAsLastPeriod(dateFrom, dateTo, includePreviousUnreconciled))
		{
			VAT.TransactionSplitsDataTable Table = new VAT.TransactionSplitsDataTable();
			VAT.TransactionSplitsDataTable table = new VAT.TransactionSplitsDataTable();
			VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
			if (includePreviousUnreconciled)
			{
				table = GetTransactions_All(connection, new DateTime(1980, 1, 1), dateFrom.AddDays(-1.0));
			}
			transactionSplitsDataTable = GetTransactions_All(connection, dateFrom, dateTo);
			Table.Merge(table);
			Table.Merge(transactionSplitsDataTable);
			CommonMethods.FixTransactionSigns(ref Table);
			CommonMethods.CalculateTaxValues(ref Table, connection);
			_lastLastTransactionsTable = Table;
			_lastDateFrom = dateFrom;
			_lastDateTo = dateTo;
			_lastincludePreviousUnreconciledFlag = includePreviousUnreconciled;
		}
		return _lastLastTransactionsTable;
	}

	/// <summary>
	/// Counts unreconciled transactions dated prior to and within the specified period.
	/// </summary>
	/// <param name="CurrentUnreconciled">Callback parameter. Returns total number of unreconciled transactions for the specified period.</param>
	/// <param name="PreviousUnreconciled">Callback parameter. Returns total number of unreconciled transactions dated prior to the specified period.</param>
	/// <remarks></remarks>
	public static void GetTotal_TransactionCount(OdbcConnection connection, DateTime dateFrom, DateTime dateTo, ref int PreviousUnreconciled, ref int CurrentUnreconciled)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		if (!IsSameAsLastPeriod(dateFrom, dateTo, includePreviousUnreconciled: true))
		{
			GetTotal_TransactionsAll(connection, dateFrom, dateTo);
		}
		_lastLastTransactionsTable.DefaultView.RowFilter = "TRAN_DATE >= '01/01/1980' AND TRAN_DATE <= '" + dateFrom.AddDays(-1.0).ToShortDateString() + "'";
		PreviousUnreconciled = _lastLastTransactionsTable.DefaultView.Count;
		_lastLastTransactionsTable.DefaultView.RowFilter = "TRAN_DATE >= '" + dateFrom.ToShortDateString() + "' AND TRAN_DATE <= '" + dateTo.ToShortDateString() + "'";
		CurrentUnreconciled = _lastLastTransactionsTable.DefaultView.Count;
		_lastLastTransactionsTable.DefaultView.RowFilter = "";
	}

	public static double CalculateTotalAmount(VAT.TransactionSplitsDataTable table, bool isTax, bool roundToNearestInteger = false)
	{
		if (isTax)
		{
			return CalculateTotalTaxAmount(table, roundToNearestInteger);
		}
		return CalculateTotalNetAmount(table, roundToNearestInteger);
	}

	/// <summary>
	/// Calculates and returns total value of the TAX_AMOUNT column for the supplied table.
	/// </summary>
	/// <param name="Table">Table of transactions to be summed.</param>
	/// <param name="RoundToNearestInteger">If set to TRUE the returned value will is rounded to 0 d.p (i.e nearest integer), 
	/// otherwise rounds the returned value to 2 d.p.</param>
	/// <returns></returns>
	/// <remarks></remarks>
	/// <exception cref="T:System.ArgumentNullException">Thrown if supplied table is null.</exception>
	public static double CalculateTotalTaxAmount(VAT.TransactionSplitsDataTable Table, bool RoundToNearestInteger = false)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		double num = 0.0;
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			num += item.TAX_AMOUNT;
		}
		if (RoundToNearestInteger)
		{
			num = Math.Round(num, 0);
		}
		return num;
	}

	/// <summary>
	/// Calculates and returns total value of the NET_AMOUNT column for the supplied table.
	/// </summary>
	/// <param name="Table">Table of transactions to be summed.</param>
	/// <param name="RoundToNearestInteger">If set to TRUE the returned value will is rounded to 0 d.p (i.e nearest integer), 
	/// otherwise rounds the returned value to 2 d.p.</param>
	/// <returns></returns>
	/// <remarks></remarks>
	/// <exception cref="T:System.ArgumentNullException">Thrown if supplied table is null.</exception>
	public static double CalculateTotalNetAmount(VAT.TransactionSplitsDataTable Table, bool RoundToNearestInteger = false)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		double num = 0.0;
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			num += item.NET_AMOUNT;
		}
		if (RoundToNearestInteger)
		{
			num = Math.Round(num, 0);
		}
		return num;
	}

	public static void ClearCache()
	{
		_lastLastTransactionsTable = null;
		_lastDateFrom = DateTime.MinValue;
		_lastDateTo = DateTime.MinValue;
		_lastincludePreviousUnreconciledFlag = false;
	}

	/// <summary>
	/// Returns the Vat Sales control account from the NominalControlAccountsList table
	/// </summary>
	/// <param name="Connection"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static string GetSalesTaxControlAccount(OdbcConnection connection)
	{
		Nominal.NominalControlAccountsListDataTable nominalControlAccountsListDataTable = new Nominal.NominalControlAccountsListDataTable();
		NominalControlAccountsList nominalControlAccountsList = new NominalControlAccountsList();
		nominalControlAccountsList.Connection = connection;
		nominalControlAccountsList.ClearBeforeFill = true;
		nominalControlAccountsList.Fill(nominalControlAccountsListDataTable);
		return Conversions.ToInteger(nominalControlAccountsListDataTable.Rows[0]["VAT_SALES"]).ToString();
	}

	/// <summary>
	/// Returns the Vat Purchase control account from the NominalControlAccountsList table
	/// </summary>
	/// <param name="Connection"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static string GetPurchaseTaxControlAccount(OdbcConnection connection)
	{
		Nominal.NominalControlAccountsListDataTable nominalControlAccountsListDataTable = new Nominal.NominalControlAccountsListDataTable();
		NominalControlAccountsList nominalControlAccountsList = new NominalControlAccountsList();
		nominalControlAccountsList.Connection = connection;
		nominalControlAccountsList.ClearBeforeFill = true;
		nominalControlAccountsList.Fill(nominalControlAccountsListDataTable);
		return Conversions.ToInteger(nominalControlAccountsListDataTable.Rows[0]["VAT_PURCHASE"]).ToString();
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	private static bool IsSameAsLastPeriod(DateTime dateFrom, DateTime dateTo, bool includePreviousUnreconciled)
	{
		return (Operators.CompareString(dateFrom.ToShortDateString(), _lastDateFrom.ToShortDateString(), TextCompare: false) == 0) & (Operators.CompareString(dateTo.ToShortDateString(), _lastDateTo.ToShortDateString(), TextCompare: false) == 0) & (includePreviousUnreconciled == _lastincludePreviousUnreconciledFlag);
	}

	private static void PerformFilter(string sb, DateTime dateFrom, DateTime dateTo)
	{
		if (DateTime.Compare(dateFrom, DateTime.MinValue) == 0)
		{
			dateFrom = new DateTime(1980, 1, 1);
		}
		string arg = dateFrom.ToString("yyyy-MM-dd");
		string arg2 = dateTo.ToString("yyyy-MM-dd");
		string format = "(TRAN_DATE >= '{0}' AND TRAN_DATE <= '{1}') AND ({2}) ";
		format = string.Format(format, arg, arg2, sb.ToString());
		_lastLastTransactionsTable.DefaultView.RowFilter = format;
	}

	private static void MergeTransactionInto(VAT.TransactionSplitsDataTable table)
	{
		table.Merge(_lastLastTransactionsTable.DefaultView.ToTable());
	}

	private static void ApplyCodeAndMergeTransactionInto(string boxCode, bool isAdd, VAT.TransactionSplitsDataTable table)
	{
		VAT.TransactionSplitsDataTable Table = new VAT.TransactionSplitsDataTable();
		Table.Merge(_lastLastTransactionsTable.DefaultView.ToTable());
		CommonMethods.SetBoxCode(ref Table, boxCode);
		CommonMethods.SetIsAdd(ref Table, isAdd);
		table.Merge(Table);
	}
}
