using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using xSageDataObjects.My;

namespace xSageDataObjects.VATTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class TransactionSplits : Component
{
	private OdbcConnection _connection;

	private OdbcTransaction _transaction;

	private OdbcCommand[] _commandCollection;

	private bool _clearBeforeFill;

	private OdbcDataAdapter _adapter;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected internal OdbcDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OdbcConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal OdbcTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i = checked(i + 1))
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if (Adapter != null && Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected OdbcCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public TransactionSplits()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitAdapter()
	{
		_adapter = new OdbcDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "TransactionSplits";
		dataTableMapping.ColumnMappings.Add("TRAN_NUMBER", "TRAN_NUMBER");
		dataTableMapping.ColumnMappings.Add("TYPE", "TYPE");
		dataTableMapping.ColumnMappings.Add("ACCOUNT_REF", "ACCOUNT_REF");
		dataTableMapping.ColumnMappings.Add("NOMINAL_CODE", "NOMINAL_CODE");
		dataTableMapping.ColumnMappings.Add("INV_REF", "INV_REF");
		dataTableMapping.ColumnMappings.Add("DETAILS", "DETAILS");
		dataTableMapping.ColumnMappings.Add("NET_AMOUNT", "NET_AMOUNT");
		dataTableMapping.ColumnMappings.Add("TAX_AMOUNT", "TAX_AMOUNT");
		dataTableMapping.ColumnMappings.Add("GROSS_AMOUNT", "GROSS_AMOUNT");
		dataTableMapping.ColumnMappings.Add("TAX_CODE", "TAX_CODE");
		dataTableMapping.ColumnMappings.Add("TAX_RATE", "TAX_RATE");
		dataTableMapping.ColumnMappings.Add("SPLIT_NUMBER", "SPLIT_NUMBER");
		dataTableMapping.ColumnMappings.Add("DATE_ENTERED", "DATE_ENTERED");
		dataTableMapping.ColumnMappings.Add("DELETED_FLAG", "DELETED_FLAG");
		dataTableMapping.ColumnMappings.Add("VAT_FLAG", "VAT_FLAG");
		dataTableMapping.ColumnMappings.Add("VAT_RECONCILED_DATE", "VAT_RECONCILED_DATE");
		dataTableMapping.ColumnMappings.Add("VAT_INCLUDE", "VAT_INCLUDE");
		dataTableMapping.ColumnMappings.Add("EURO_SALES", "EURO_SALES");
		dataTableMapping.ColumnMappings.Add("EURO_PURCHASE", "EURO_PURCHASE");
		dataTableMapping.ColumnMappings.Add("IS_REVERSECHARGE", "IS_REVERSECHARGE");
		dataTableMapping.ColumnMappings.Add("RELATED_CODE", "RELATED_CODE");
		dataTableMapping.ColumnMappings.Add("RELATED_RATE", "RELATED_RATE");
		dataTableMapping.ColumnMappings.Add("TRAN_DATE", "TRAN_DATE");
		_adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitConnection()
	{
		_connection = new OdbcConnection();
		_connection.ConnectionString = MySettings.Default.Sage15_ConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new OdbcCommand[19];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG <> 1)";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OdbcCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC' OR\r\n                      AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD')";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[1].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2] = new OdbcCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (TAX_CODE.EURO_SALES = 0) AND (TAX_CODE.EURO_PURCHASE = 0)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[3] = new OdbcCommand();
		_commandCollection[3].Connection = Connection;
		_commandCollection[3].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 2) AND (TAX_CODE.RELATED_CODE = 1)";
		_commandCollection[3].CommandType = CommandType.Text;
		_commandCollection[3].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[3].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[4] = new OdbcCommand();
		_commandCollection[4].Connection = Connection;
		_commandCollection[4].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (AUDIT_SPLIT.TAX_CODE = ?)";
		_commandCollection[4].CommandType = CommandType.Text;
		_commandCollection[4].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[4].Parameters.Add(new OdbcParameter("Param5", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[4].Parameters.Add(new OdbcParameter("TAX_CODE", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "TAX_CODE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[5] = new OdbcCommand();
		_commandCollection[5].Connection = Connection;
		_commandCollection[5].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 1)";
		_commandCollection[5].CommandType = CommandType.Text;
		_commandCollection[5].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[5].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[6] = new OdbcCommand();
		_commandCollection[6].Connection = Connection;
		_commandCollection[6].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 2)";
		_commandCollection[6].CommandType = CommandType.Text;
		_commandCollection[6].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[6].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[7] = new OdbcCommand();
		_commandCollection[7].Connection = Connection;
		_commandCollection[7].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 1) AND (TAX_CODE.RELATED_CODE = 1)";
		_commandCollection[7].CommandType = CommandType.Text;
		_commandCollection[7].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[7].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[8] = new OdbcCommand();
		_commandCollection[8].Connection = Connection;
		_commandCollection[8].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_SALES = 0) AND (TAX_CODE.EURO_PURCHASE = 0)";
		_commandCollection[8].CommandType = CommandType.Text;
		_commandCollection[8].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[8].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[9] = new OdbcCommand();
		_commandCollection[9].Connection = Connection;
		_commandCollection[9].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE > 0) AND (TAX_CODE.RELATED_CODE = 1)";
		_commandCollection[9].CommandType = CommandType.Text;
		_commandCollection[9].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[9].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[10] = new OdbcCommand();
		_commandCollection[10].Connection = Connection;
		_commandCollection[10].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (TAX_CODE.EURO_SALES = 0) AND (TAX_CODE.EURO_PURCHASE = 0)";
		_commandCollection[10].CommandType = CommandType.Text;
		_commandCollection[10].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[10].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[11] = new OdbcCommand();
		_commandCollection[11].Connection = Connection;
		_commandCollection[11].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (TAX_CODE.EURO_SALES > 0)";
		_commandCollection[11].CommandType = CommandType.Text;
		_commandCollection[11].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[11].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[12] = new OdbcCommand();
		_commandCollection[12].Connection = Connection;
		_commandCollection[12].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 2)";
		_commandCollection[12].CommandType = CommandType.Text;
		_commandCollection[12].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[12].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[13] = new OdbcCommand();
		_commandCollection[13].Connection = Connection;
		_commandCollection[13].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE = 0) AND (TAX_CODE.EURO_SALES = 0)";
		_commandCollection[13].CommandType = CommandType.Text;
		_commandCollection[13].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[13].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[14] = new OdbcCommand();
		_commandCollection[14].Connection = Connection;
		_commandCollection[14].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.EURO_PURCHASE > 0)";
		_commandCollection[14].CommandType = CommandType.Text;
		_commandCollection[14].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[14].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[15] = new OdbcCommand();
		_commandCollection[15].Connection = Connection;
		_commandCollection[15].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (TAX_CODE.EURO_SALES = 1)";
		_commandCollection[15].CommandType = CommandType.Text;
		_commandCollection[15].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[15].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[16] = new OdbcCommand();
		_commandCollection[16].Connection = Connection;
		_commandCollection[16].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (TAX_CODE.EURO_SALES = 2)";
		_commandCollection[16].CommandType = CommandType.Text;
		_commandCollection[16].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[16].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[17] = new OdbcCommand();
		_commandCollection[17].Connection = Connection;
		_commandCollection[17].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND \r\n                      (DATE <= ?) AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC') AND (AUDIT_SPLIT.TAX_CODE = 'T0')";
		_commandCollection[17].CommandType = CommandType.Text;
		_commandCollection[17].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[17].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[18] = new OdbcCommand();
		_commandCollection[18].Connection = Connection;
		_commandCollection[18].CommandText = "SELECT     COUNT(*) AS TransactionCount\r\nFROM         AUDIT_SPLIT, TAX_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND (AUDIT_SPLIT.DELETED_FLAG <> 1) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BR' OR\r\n                      AUDIT_SPLIT.TYPE = 'CR' OR\r\n                      AUDIT_SPLIT.TYPE = 'VR' OR\r\n                      AUDIT_SPLIT.TYPE = 'JC' OR\r\n                      AUDIT_SPLIT.TYPE = 'PI' OR\r\n                      AUDIT_SPLIT.TYPE = 'PC' OR\r\n                      AUDIT_SPLIT.TYPE = 'BP' OR\r\n                      AUDIT_SPLIT.TYPE = 'CP' OR\r\n                      AUDIT_SPLIT.TYPE = 'VP' OR\r\n                      AUDIT_SPLIT.TYPE = 'JD') AND (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.VAT_FLAG = 'N') AND (DATE >= ?) AND (DATE <= ?)";
		_commandCollection[18].CommandType = CommandType.Text;
		_commandCollection[18].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[18].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(VAT.TransactionSplitsDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual VAT.TransactionSplitsDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_AllBoxes(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_AllBoxes(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box1_GroupA(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box1_GroupA(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box1_GroupB(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[3];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box1_GroupB(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[3];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box10_GroupA(VAT.TransactionSplitsDataTable dataTable, string Param4, string Param5, string TAX_CODE)
	{
		Adapter.SelectCommand = CommandCollection[4];
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param4;
		if (Param5 == null)
		{
			throw new ArgumentNullException("Param5");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param5;
		if (TAX_CODE == null)
		{
			throw new ArgumentNullException("TAX_CODE");
		}
		Adapter.SelectCommand.Parameters[2].Value = TAX_CODE;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box10_GroupA(string Param4, string Param5, string TAX_CODE)
	{
		Adapter.SelectCommand = CommandCollection[4];
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param4;
		if (Param5 == null)
		{
			throw new ArgumentNullException("Param5");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param5;
		if (TAX_CODE == null)
		{
			throw new ArgumentNullException("TAX_CODE");
		}
		Adapter.SelectCommand.Parameters[2].Value = TAX_CODE;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box11a_GroupB(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[5];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box11a_GroupB(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[5];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box11b_GroupB(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[6];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box11b_GroupB(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[6];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box2_GroupB(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[7];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box2_GroupB(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[7];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box4_GroupB_1(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[8];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box4_GroupB_1(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[8];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box4_GroupB_2(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[9];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box4_GroupB_2(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[9];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box6_GroupA_1(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[10];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box6_GroupA_1(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[10];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box6_GroupA_2(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[11];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box6_GroupA_2(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[11];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box6_GroupB(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[12];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box6_GroupB(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[12];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box7_GroupB_1(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[13];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box7_GroupB_1(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[13];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box7_GroupB_2(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[14];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box7_GroupB_2(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[14];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box8a_GroupA(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[15];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box8a_GroupA(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[15];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box8b_GroupA(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[16];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box8b_GroupA(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[16];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_Box9_GroupA(VAT.TransactionSplitsDataTable dataTable, string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[17];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VAT.TransactionSplitsDataTable GetData_Box9_GroupA(string Param3, string Param4)
	{
		Adapter.SelectCommand = CommandCollection[17];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		Adapter.SelectCommand.Parameters[1].Value = Param4;
		VAT.TransactionSplitsDataTable transactionSplitsDataTable = new VAT.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual object TransactionCount_AllBoxes(string Param3, string Param4)
	{
		OdbcCommand odbcCommand = CommandCollection[18];
		if (Param3 == null)
		{
			throw new ArgumentNullException("Param3");
		}
		odbcCommand.Parameters[0].Value = Param3;
		if (Param4 == null)
		{
			throw new ArgumentNullException("Param4");
		}
		odbcCommand.Parameters[1].Value = Param4;
		ConnectionState state = odbcCommand.Connection.State;
		if ((odbcCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			odbcCommand.Connection.Open();
		}
		object objectValue;
		try
		{
			objectValue = RuntimeHelpers.GetObjectValue(odbcCommand.ExecuteScalar());
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				odbcCommand.Connection.Close();
			}
		}
		if (objectValue == null || (object)objectValue.GetType() == typeof(DBNull))
		{
			return null;
		}
		return objectValue;
	}
}
