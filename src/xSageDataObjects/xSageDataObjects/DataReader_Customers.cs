using System;
using System.Data.Odbc;
using xSageDataObjects.CustomersTableAdapters;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class DataReader_Customers
{
	/// <summary>
	/// Gets all Customer (SALES_LEDGER) records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Customers.CustomersListDataTable GetCustomers_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Customers.CustomersListDataTable customersListDataTable = new Customers.CustomersListDataTable();
		CustomersList customersList = new CustomersList();
		customersList.Connection = Connection;
		customersList.ClearBeforeFill = true;
		try
		{
			customersList.Fill(customersListDataTable);
		}
		finally
		{
			if (customersList != null)
			{
				customersList.Dispose();
				customersList = null;
			}
		}
		return customersListDataTable;
	}
}
