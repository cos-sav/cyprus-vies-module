using System;
using System.Data.Odbc;
using Microsoft.VisualBasic.CompilerServices;
using xSageDataObjects.DepartmentsTableAdapters;

namespace xSageDataObjects;

public class DataReader_Departments
{
	public struct Department
	{
		public int Number;

		public string Name;

		public string Reference;
	}

	/// <summary>
	/// Gets all Department records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Departments.DEPARTMENTDataTable GetDepartments_All(OdbcConnection Connection)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Departments.DEPARTMENTDataTable dEPARTMENTDataTable = new Departments.DEPARTMENTDataTable();
		DEPARTMENTTableAdapter dEPARTMENTTableAdapter = new DEPARTMENTTableAdapter();
		dEPARTMENTTableAdapter.Connection = Connection;
		dEPARTMENTTableAdapter.ClearBeforeFill = true;
		try
		{
			dEPARTMENTTableAdapter.Fill(dEPARTMENTDataTable);
		}
		finally
		{
			if (dEPARTMENTTableAdapter != null)
			{
				dEPARTMENTTableAdapter.Dispose();
				dEPARTMENTTableAdapter = null;
			}
		}
		return dEPARTMENTDataTable;
	}

	/// <summary>
	/// Gets all Department records.
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static Department GetDepartments_ByNumber(OdbcConnection Connection, int DepartmentNumber)
	{
		if (Connection == null)
		{
			throw new ArgumentNullException("Connection");
		}
		Departments.DEPARTMENTDataTable dEPARTMENTDataTable = new Departments.DEPARTMENTDataTable();
		DEPARTMENTTableAdapter dEPARTMENTTableAdapter = new DEPARTMENTTableAdapter();
		dEPARTMENTTableAdapter.Connection = Connection;
		dEPARTMENTTableAdapter.ClearBeforeFill = true;
		Department result = default(Department);
		try
		{
			dEPARTMENTTableAdapter.FillByNumber(dEPARTMENTDataTable, checked((short)DepartmentNumber));
			if (dEPARTMENTDataTable != null && dEPARTMENTDataTable.Rows.Count > 0)
			{
				result.Name = Conversions.ToString(dEPARTMENTDataTable.Rows[0]["NAME"]);
				result.Number = Conversions.ToInteger(dEPARTMENTDataTable.Rows[0]["NUMBER"]);
				result.Reference = Conversions.ToString(dEPARTMENTDataTable.Rows[0]["REFERENCE"]);
			}
		}
		finally
		{
			if (dEPARTMENTTableAdapter != null)
			{
				dEPARTMENTTableAdapter.Dispose();
				dEPARTMENTTableAdapter = null;
			}
		}
		return result;
	}
}
