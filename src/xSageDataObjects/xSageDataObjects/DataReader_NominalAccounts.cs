using System;
using System.Data.Odbc;
using xSageDataObjects.NominalTableAdapters;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class DataReader_NominalAccounts
{
	/// <summary>
	/// Gets all Nominal Account records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Nominal.NominalAccountsListDataTable GetNominalAccounts_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Nominal.NominalAccountsListDataTable nominalAccountsListDataTable = new Nominal.NominalAccountsListDataTable();
		NominalAccountsList nominalAccountsList = new NominalAccountsList();
		nominalAccountsList.Connection = Connection;
		nominalAccountsList.ClearBeforeFill = true;
		try
		{
			nominalAccountsList.Fill(nominalAccountsListDataTable);
			return nominalAccountsListDataTable;
		}
		finally
		{
			if (nominalAccountsList != null)
			{
				nominalAccountsList.Dispose();
				nominalAccountsList = null;
			}
		}
	}

	/// <summary>
	/// Gets all Nominal Control Account records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Nominal.NominalControlAccountsListDataTable GetNominalControlAccounts_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Nominal.NominalControlAccountsListDataTable nominalControlAccountsListDataTable = new Nominal.NominalControlAccountsListDataTable();
		NominalControlAccountsList nominalControlAccountsList = new NominalControlAccountsList();
		nominalControlAccountsList.Connection = Connection;
		nominalControlAccountsList.ClearBeforeFill = true;
		try
		{
			nominalControlAccountsList.Fill(nominalControlAccountsListDataTable);
			return nominalControlAccountsListDataTable;
		}
		finally
		{
			if (nominalControlAccountsList != null)
			{
				nominalControlAccountsList.Dispose();
				nominalControlAccountsList = null;
			}
		}
	}
}
