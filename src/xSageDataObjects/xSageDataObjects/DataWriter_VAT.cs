using System;
using Microsoft.VisualBasic;

namespace xSageDataObjects;

public class DataWriter_VAT
{
	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool SetVATReconciledFlags(ref Engine Engine, DateTime DateFrom, DateTime DateTo, bool IncludePreviousUnreconciled = true)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool result = false;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable table = new VAT.TransactionSplitsDataTable();
		VAT.TransactionSplitsDataTable transactionSplitsDataTable2 = new VAT.TransactionSplitsDataTable();
		try
		{
			if (IncludePreviousUnreconciled)
			{
				table = DataReader_VAT.GetTransactions_All(Engine.OdbcConnection, new DateTime(1980, 1, 1), DateFrom.AddDays(-1.0));
			}
			transactionSplitsDataTable2 = DataReader_VAT.GetTransactions_All(Engine.OdbcConnection, DateFrom, DateTo);
			transactionSplitsDataTable.Merge(table);
			transactionSplitsDataTable.Merge(transactionSplitsDataTable2);
			foreach (VAT.TransactionSplitsRow item in transactionSplitsDataTable)
			{
				if (!Engine.SetTransactionFlag_VATReconciled(item.SPLIT_NUMBER, ReconciledFlag: true, DateAndTime.Today.Date))
				{
					result = true;
				}
			}
			return result;
		}
		finally
		{
			table = null;
			transactionSplitsDataTable2 = null;
			transactionSplitsDataTable = null;
		}
	}
}
