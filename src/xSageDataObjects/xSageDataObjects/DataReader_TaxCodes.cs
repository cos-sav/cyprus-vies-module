using System;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic.CompilerServices;
using xSageDataObjects.TaxCodesTableAdapters;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class DataReader_TaxCodes
{
	/// <summary>
	/// Gets all Tax Codes (TAXCODE) records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static TaxCodes.TaxCodesListDataTable GetTaxCodes_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		TaxCodes.TaxCodesListDataTable taxCodesListDataTable = new TaxCodes.TaxCodesListDataTable();
		TaxCodesList taxCodesList = new TaxCodesList();
		taxCodesList.Connection = Connection;
		taxCodesList.ClearBeforeFill = true;
		try
		{
			taxCodesList.Fill(taxCodesListDataTable);
			return taxCodesListDataTable;
		}
		finally
		{
			if (taxCodesList != null)
			{
				taxCodesList.Dispose();
				taxCodesList = null;
			}
		}
	}

	public static TaxCodes.TaxCodesListDataTable GetTaxCodes_Active(OdbcConnection Connection)
	{
		TaxCodes.TaxCodesListDataTable taxCodes_All = GetTaxCodes_All(Connection);
		checked
		{
			for (int i = taxCodes_All.Rows.Count - 1; i >= 0; i += -1)
			{
				DataRow dataRow = taxCodes_All.Rows[i];
				if (Conversions.ToInteger(dataRow[taxCodes_All.VAT_INCLUDEColumn]) == 0)
				{
					taxCodes_All.Rows.Remove(dataRow);
				}
			}
			return taxCodes_All;
		}
	}
}
