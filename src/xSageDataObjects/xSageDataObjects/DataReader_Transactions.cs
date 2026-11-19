using System;
using System.Data.Odbc;
using xSageDataObjects.TransactionsTableAdapters;

namespace xSageDataObjects;

public class DataReader_Transactions
{
	/// <summary>
	/// Gets all Customer (AUDIT SPLIT) records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Transactions.AUDIT_SPLITDataTable GetTransactions_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		AUDIT_SPLITTableAdapter aUDIT_SPLITTableAdapter = new AUDIT_SPLITTableAdapter();
		aUDIT_SPLITTableAdapter.Connection = Connection;
		aUDIT_SPLITTableAdapter.ClearBeforeFill = true;
		try
		{
			aUDIT_SPLITTableAdapter.Fill(aUDIT_SPLITDataTable);
		}
		finally
		{
			if (aUDIT_SPLITTableAdapter != null)
			{
				aUDIT_SPLITTableAdapter.Dispose();
				aUDIT_SPLITTableAdapter = null;
			}
		}
		return aUDIT_SPLITDataTable;
	}

	/// <summary>
	/// Gets Customer (AUDIT SPLIT) records filtered by Date, Transaction Type, Nominal Code and Invoice Number
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Transactions.AUDIT_SPLITDataTable GetTransactions_Filtered(OdbcConnection Connection, string TransDate, string TransType, string NominalCode, string AccountRef, string InvoiceRef)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		AUDIT_SPLITTableAdapter aUDIT_SPLITTableAdapter = new AUDIT_SPLITTableAdapter();
		aUDIT_SPLITTableAdapter.Connection = Connection;
		aUDIT_SPLITTableAdapter.ClearBeforeFill = true;
		try
		{
			aUDIT_SPLITTableAdapter.FillBy_Transaction(aUDIT_SPLITDataTable, TransDate, TransType, NominalCode, AccountRef, InvoiceRef);
		}
		finally
		{
			if (aUDIT_SPLITTableAdapter != null)
			{
				aUDIT_SPLITTableAdapter.Dispose();
				aUDIT_SPLITTableAdapter = null;
			}
		}
		return aUDIT_SPLITDataTable;
	}

	/// <summary>
	/// Gets Customer (AUDIT SPLIT) records filtered by Date, Transaction Type and Invoice Number
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Transactions.AUDIT_SPLITDataTable GetTransactions_Filtered(OdbcConnection Connection, string TransDate, string TransType, string AccountRef, string InvoiceRef)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		AUDIT_SPLITTableAdapter aUDIT_SPLITTableAdapter = new AUDIT_SPLITTableAdapter();
		aUDIT_SPLITTableAdapter.Connection = Connection;
		aUDIT_SPLITTableAdapter.ClearBeforeFill = true;
		try
		{
			aUDIT_SPLITTableAdapter.FillBy_Date_Type_AccRef_TransRef(aUDIT_SPLITDataTable, TransDate, TransType, AccountRef, InvoiceRef);
		}
		finally
		{
			if (aUDIT_SPLITTableAdapter != null)
			{
				aUDIT_SPLITTableAdapter.Dispose();
				aUDIT_SPLITTableAdapter = null;
			}
		}
		return aUDIT_SPLITDataTable;
	}
}
