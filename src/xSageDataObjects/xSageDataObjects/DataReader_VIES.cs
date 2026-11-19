using System;
using System.Data.Odbc;
using xSageDataObjects.VIESTableAdapters;

namespace xSageDataObjects;

/// <summary>
/// This class provides a number of shared methods that can be used to retrieve various sets of transactions.  
/// </summary>
/// <remarks>
/// </remarks>
public class DataReader_VIES
{
	/// <summary>
	/// Gets all transactions for the specified period which are relevant for VIES calculations.
	/// </summary>
	/// <param name="DateFrom"></param>
	/// <param name="DateTo"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static VIES.TransactionSplitsDataTable GetTransactions(OdbcConnection Connection, DateTime DateFrom, DateTime DateTo)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		VIES.TransactionSplitsDataTable Table = new VIES.TransactionSplitsDataTable();
		TransactionSplits transactionSplits = new TransactionSplits();
		transactionSplits.Connection = Connection;
		transactionSplits.ClearBeforeFill = true;
		try
		{
			transactionSplits.Fill_All(Table, DateFrom.ToString("yyyy-MM-dd"), DateTo.ToString("yyyy-MM-dd"));
			FixTransactionSigns(ref Table);
			SetGoodsServicesText(ref Table);
			return Table;
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
	/// Returns a table that only contains records where ACCOUNT_REF column is equal to the supplied AccountRef value.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static VIES.TransactionSplitsDataTable GetTransactions_ByAccountRef(VIES.TransactionSplitsDataTable Table, string AccountRef)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		VIES.TransactionSplitsDataTable transactionSplitsDataTable = new VIES.TransactionSplitsDataTable();
		Table.DefaultView.RowFilter = "ACCOUNT_REF = " + AccountRef;
		transactionSplitsDataTable.Merge(Table.DefaultView.ToTable());
		return transactionSplitsDataTable;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Table"></param>
	/// <remarks></remarks>
	private static void SetGoodsServicesText(ref VIES.TransactionSplitsDataTable Table)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		foreach (VIES.TransactionSplitsRow item in Table)
		{
			if (item.EURO_SALES == 1)
			{
				item.GOODS_SERVICES_TEXT = "Goods";
			}
			else
			{
				item.GOODS_SERVICES_TEXT = "Service";
			}
		}
	}

	/// <summary>
	/// Changes signs of values found in TAX_AMOUNT, NET_AMOUNT and GROSS_AMOUNT columns of the supplied table based on the type of each transaction.
	/// </summary>
	/// <remarks>
	/// The following transaction types recieve a Positive sign: SI, BR, BP, CR, CP, JC, JD, PI, VR, VP
	/// The following transaction types recieve a Negative sign: SC, PC
	/// </remarks>
	private static void FixTransactionSigns(ref VIES.TransactionSplitsDataTable Table)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		bool flag = default(bool);
		foreach (VIES.TransactionSplitsRow item in Table)
		{
			switch (item.TYPE)
			{
			case "SI":
			case "BR":
			case "BP":
			case "CR":
			case "CP":
			case "JC":
			case "JD":
			case "PI":
			case "VR":
			case "VP":
				flag = true;
				break;
			case "SC":
			case "PC":
				flag = false;
				break;
			}
			if (flag)
			{
				item.NET_AMOUNT = Math.Abs(item.NET_AMOUNT);
				item.TAX_AMOUNT = Math.Abs(item.TAX_AMOUNT);
				item.GROSS_AMOUNT = Math.Abs(item.GROSS_AMOUNT);
			}
			else
			{
				item.NET_AMOUNT = 0.0 - Math.Abs(item.NET_AMOUNT);
				item.TAX_AMOUNT = 0.0 - Math.Abs(item.TAX_AMOUNT);
				item.GROSS_AMOUNT = 0.0 - Math.Abs(item.GROSS_AMOUNT);
			}
		}
	}
}
