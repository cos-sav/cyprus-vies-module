using System;
using System.Data.Odbc;
using xSageDataObjects.ProductsTableAdapters;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class DataReader_Products
{
	/// <summary>
	/// Gets all Product (STOCK) records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Products.ProductsListDataTable GetProducts_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Products.ProductsListDataTable productsListDataTable = new Products.ProductsListDataTable();
		ProductsList productsList = new ProductsList();
		productsList.Connection = Connection;
		productsList.ClearBeforeFill = true;
		try
		{
			productsList.Fill(productsListDataTable);
			return productsListDataTable;
		}
		finally
		{
			if (productsList != null)
			{
				productsList.Dispose();
				productsList = null;
			}
		}
	}
}
