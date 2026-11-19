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

namespace xSageDataObjects.VIESTableAdapters;

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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public TransactionSplits()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
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
		dataTableMapping.ColumnMappings.Add("COUNTRY_CODE", "COUNTRY_CODE");
		dataTableMapping.ColumnMappings.Add("COUNTRY_NAME", "COUNTRY_NAME");
		dataTableMapping.ColumnMappings.Add("EU_MEMBER", "EU_MEMBER");
		dataTableMapping.ColumnMappings.Add("VAT_REG_NUMBER", "VAT_REG_NUMBER");
		dataTableMapping.ColumnMappings.Add("NAME", "NAME");
		_adapter.TableMappings.Add(dataTableMapping);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitConnection()
	{
		_connection = new OdbcConnection();
		_connection.ConnectionString = MySettings.Default.Sage15_ConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new OdbcCommand[2];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE, \r\n                      SALES_LEDGER.COUNTRY_CODE, COUNTRY_CODE.NAME AS COUNTRY_NAME, COUNTRY_CODE.EU_MEMBER, \r\n                      SALES_LEDGER.VAT_REG_NUMBER, SALES_LEDGER.NAME\r\nFROM         AUDIT_SPLIT, TAX_CODE, SALES_LEDGER, COUNTRY_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND AUDIT_SPLIT.ACCOUNT_REF = SALES_LEDGER.ACCOUNT_REF AND \r\n                      SALES_LEDGER.COUNTRY_CODE = COUNTRY_CODE.CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (TAX_CODE.VAT_INCLUDE <> 0) AND \r\n                      (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC')";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OdbcCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     AUDIT_SPLIT.TRAN_NUMBER, AUDIT_SPLIT.TYPE, AUDIT_SPLIT.ACCOUNT_REF, AUDIT_SPLIT.NOMINAL_CODE, AUDIT_SPLIT.INV_REF, \r\n                      AUDIT_SPLIT.DETAILS, AUDIT_SPLIT.NET_AMOUNT, AUDIT_SPLIT.TAX_AMOUNT, AUDIT_SPLIT.GROSS_AMOUNT, AUDIT_SPLIT.TAX_CODE, \r\n                      TAX_CODE.TAX_RATE, AUDIT_SPLIT.SPLIT_NUMBER, AUDIT_SPLIT.DATE_ENTERED, AUDIT_SPLIT.DELETED_FLAG, AUDIT_SPLIT.VAT_FLAG, \r\n                      AUDIT_SPLIT.VAT_RECONCILED_DATE, TAX_CODE.VAT_INCLUDE, TAX_CODE.EURO_SALES, TAX_CODE.EURO_PURCHASE, \r\n                      TAX_CODE.IS_REVERSECHARGE, TAX_CODE.RELATED_CODE, TAX_CODE.RELATED_RATE, DATE AS TRAN_DATE, \r\n                      SALES_LEDGER.COUNTRY_CODE, COUNTRY_CODE.NAME AS COUNTRY_NAME, COUNTRY_CODE.EU_MEMBER, \r\n                      SALES_LEDGER.VAT_REG_NUMBER, SALES_LEDGER.NAME\r\nFROM         AUDIT_SPLIT, TAX_CODE, SALES_LEDGER, COUNTRY_CODE\r\nWHERE     AUDIT_SPLIT.TAX_CODE = TAX_CODE.TAX_CODE AND AUDIT_SPLIT.ACCOUNT_REF = SALES_LEDGER.ACCOUNT_REF AND \r\n                      SALES_LEDGER.COUNTRY_CODE = COUNTRY_CODE.CODE AND (AUDIT_SPLIT.DELETED_FLAG = 0) AND (DATE >= ?) AND (DATE <= ?) AND \r\n                      (TAX_CODE.VAT_INCLUDE <> 0) AND (AUDIT_SPLIT.TYPE = 'SI' OR\r\n                      AUDIT_SPLIT.TYPE = 'SC') AND (TAX_CODE.EURO_SALES > 0) AND (COUNTRY_CODE.EU_MEMBER = 1) AND \r\n                      (SALES_LEDGER.COUNTRY_CODE <> 'CY')";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new OdbcParameter("Param3", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[1].Parameters.Add(new OdbcParameter("Param4", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(VIES.TransactionSplitsDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual VIES.TransactionSplitsDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		VIES.TransactionSplitsDataTable transactionSplitsDataTable = new VIES.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int Fill_All(VIES.TransactionSplitsDataTable dataTable, string Param3, string Param4)
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
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual VIES.TransactionSplitsDataTable GetData_All(string Param3, string Param4)
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
		VIES.TransactionSplitsDataTable transactionSplitsDataTable = new VIES.TransactionSplitsDataTable();
		Adapter.Fill(transactionSplitsDataTable);
		return transactionSplitsDataTable;
	}
}
