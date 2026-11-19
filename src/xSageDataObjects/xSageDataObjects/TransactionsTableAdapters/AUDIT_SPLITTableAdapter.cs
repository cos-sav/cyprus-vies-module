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

namespace xSageDataObjects.TransactionsTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class AUDIT_SPLITTableAdapter : Component
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
	public AUDIT_SPLITTableAdapter()
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
		dataTableMapping.DataSetTable = "AUDIT_SPLIT";
		dataTableMapping.ColumnMappings.Add("TRAN_NUMBER", "TRAN_NUMBER");
		dataTableMapping.ColumnMappings.Add("TYPE", "TYPE");
		dataTableMapping.ColumnMappings.Add("DATE", "DATE");
		dataTableMapping.ColumnMappings.Add("ACCOUNT_REF", "ACCOUNT_REF");
		dataTableMapping.ColumnMappings.Add("NOMINAL_CODE", "NOMINAL_CODE");
		dataTableMapping.ColumnMappings.Add("BANK_CODE", "BANK_CODE");
		dataTableMapping.ColumnMappings.Add("INV_REF", "INV_REF");
		dataTableMapping.ColumnMappings.Add("USER_NAME", "USER_NAME");
		dataTableMapping.ColumnMappings.Add("DETAILS", "DETAILS");
		dataTableMapping.ColumnMappings.Add("EXTRA_REF", "EXTRA_REF");
		dataTableMapping.ColumnMappings.Add("DISPUTED", "DISPUTED");
		dataTableMapping.ColumnMappings.Add("STMT_TEXT", "STMT_TEXT");
		dataTableMapping.ColumnMappings.Add("BANK_FLAG", "BANK_FLAG");
		dataTableMapping.ColumnMappings.Add("VAT_FLAG", "VAT_FLAG");
		dataTableMapping.ColumnMappings.Add("PAID_FLAG", "PAID_FLAG");
		dataTableMapping.ColumnMappings.Add("PAID_STATUS", "PAID_STATUS");
		dataTableMapping.ColumnMappings.Add("DEPT_NUMBER", "DEPT_NUMBER");
		dataTableMapping.ColumnMappings.Add("DEPT_NAME", "DEPT_NAME");
		dataTableMapping.ColumnMappings.Add("TAX_CODE", "TAX_CODE");
		dataTableMapping.ColumnMappings.Add("DELETED_FLAG", "DELETED_FLAG");
		dataTableMapping.ColumnMappings.Add("NET_AMOUNT", "NET_AMOUNT");
		dataTableMapping.ColumnMappings.Add("TAX_AMOUNT", "TAX_AMOUNT");
		dataTableMapping.ColumnMappings.Add("GROSS_AMOUNT", "GROSS_AMOUNT");
		dataTableMapping.ColumnMappings.Add("AMOUNT_PAID", "AMOUNT_PAID");
		dataTableMapping.ColumnMappings.Add("PAYMENT", "PAYMENT");
		dataTableMapping.ColumnMappings.Add("OUTSTANDING", "OUTSTANDING");
		dataTableMapping.ColumnMappings.Add("FOREIGN_NET_AMOUNT", "FOREIGN_NET_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_TAX_AMOUNT", "FOREIGN_TAX_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_GROSS_AMOUNT", "FOREIGN_GROSS_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AMOUNT_PAID", "FOREIGN_AMOUNT_PAID");
		dataTableMapping.ColumnMappings.Add("AGED_BALANCE", "AGED_BALANCE");
		dataTableMapping.ColumnMappings.Add("AGED_FUTURE", "AGED_FUTURE");
		dataTableMapping.ColumnMappings.Add("AGED_CURRENT", "AGED_CURRENT");
		dataTableMapping.ColumnMappings.Add("AGED_30", "AGED_30");
		dataTableMapping.ColumnMappings.Add("AGED_60", "AGED_60");
		dataTableMapping.ColumnMappings.Add("AGED_90", "AGED_90");
		dataTableMapping.ColumnMappings.Add("AGED_OLDER", "AGED_OLDER");
		dataTableMapping.ColumnMappings.Add("AGED_CUM_CURRENT", "AGED_CUM_CURRENT");
		dataTableMapping.ColumnMappings.Add("AGED_CUM_30", "AGED_CUM_30");
		dataTableMapping.ColumnMappings.Add("AGED_CUM_60", "AGED_CUM_60");
		dataTableMapping.ColumnMappings.Add("AGED_CUM_90", "AGED_CUM_90");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_BALANCE", "FOREIGN_AGED_BALANCE");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_FUTURE", "FOREIGN_AGED_FUTURE");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_CURRENT", "FOREIGN_AGED_CURRENT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_30", "FOREIGN_AGED_30");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_60", "FOREIGN_AGED_60");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_90", "FOREIGN_AGED_90");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_OLDER", "FOREIGN_AGED_OLDER");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_CUM_CURRENT", "FOREIGN_AGED_CUM_CURRENT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_CUM_30", "FOREIGN_AGED_CUM_30");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_CUM_60", "FOREIGN_AGED_CUM_60");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AGED_CUM_90", "FOREIGN_AGED_CUM_90");
		dataTableMapping.ColumnMappings.Add("SPLIT_NUMBER", "SPLIT_NUMBER");
		dataTableMapping.ColumnMappings.Add("HEADER_NUMBER", "HEADER_NUMBER");
		dataTableMapping.ColumnMappings.Add("VAT_FLAG_CODE", "VAT_FLAG_CODE");
		dataTableMapping.ColumnMappings.Add("DATE_FLAG", "DATE_FLAG");
		dataTableMapping.ColumnMappings.Add("DATE_ENTERED", "DATE_ENTERED");
		dataTableMapping.ColumnMappings.Add("VAT_RECONCILED_DATE", "VAT_RECONCILED_DATE");
		dataTableMapping.ColumnMappings.Add("DISPUTE_CODE", "DISPUTE_CODE");
		dataTableMapping.ColumnMappings.Add("FUND_ID", "FUND_ID");
		dataTableMapping.ColumnMappings.Add("VAT_LEDGER_RETURN_ID", "VAT_LEDGER_RETURN_ID");
		dataTableMapping.ColumnMappings.Add("RECORD_CREATE_DATE", "RECORD_CREATE_DATE");
		dataTableMapping.ColumnMappings.Add("RECORD_MODIFY_DATE", "RECORD_MODIFY_DATE");
		dataTableMapping.ColumnMappings.Add("RECORD_DELETED", "RECORD_DELETED");
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
		_commandCollection = new OdbcCommand[3];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     AUDIT_SPLIT.*\r\nFROM         AUDIT_SPLIT";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OdbcCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     TRAN_NUMBER, TYPE, 'DATE', ACCOUNT_REF, NOMINAL_CODE, BANK_CODE, INV_REF, USER_NAME, DETAILS, EXTRA_REF, DISPUTED, \r\n                      STMT_TEXT, BANK_FLAG, VAT_FLAG, PAID_FLAG, PAID_STATUS, DEPT_NUMBER, DEPT_NAME, TAX_CODE, DELETED_FLAG, NET_AMOUNT, \r\n                      TAX_AMOUNT, GROSS_AMOUNT, AMOUNT_PAID, PAYMENT, OUTSTANDING, FOREIGN_NET_AMOUNT, FOREIGN_TAX_AMOUNT, \r\n                      FOREIGN_GROSS_AMOUNT, FOREIGN_AMOUNT_PAID, AGED_BALANCE, AGED_FUTURE, AGED_CURRENT, AGED_30, AGED_60, AGED_90, \r\n                      AGED_OLDER, AGED_CUM_CURRENT, AGED_CUM_30, AGED_CUM_60, AGED_CUM_90, FOREIGN_AGED_BALANCE, FOREIGN_AGED_FUTURE, \r\n                      FOREIGN_AGED_CURRENT, FOREIGN_AGED_30, FOREIGN_AGED_60, FOREIGN_AGED_90, FOREIGN_AGED_OLDER, \r\n                      FOREIGN_AGED_CUM_CURRENT, FOREIGN_AGED_CUM_30, FOREIGN_AGED_CUM_60, FOREIGN_AGED_CUM_90, SPLIT_NUMBER, \r\n                      HEADER_NUMBER, VAT_FLAG_CODE, DATE_FLAG, DATE_ENTERED, VAT_RECONCILED_DATE, DISPUTE_CODE, FUND_ID, \r\n                      VAT_LEDGER_RETURN_ID, RECORD_CREATE_DATE, RECORD_MODIFY_DATE, RECORD_DELETED\r\nFROM         AUDIT_SPLIT\r\nWHERE     ('DATE' = ?) AND (TYPE = ?) AND (ACCOUNT_REF = ?) AND (INV_REF = ?) AND (DELETED_FLAG <> 1)";
		_commandCollection[1].CommandType = CommandType.Text;
		_commandCollection[1].Parameters.Add(new OdbcParameter("Param1", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[1].Parameters.Add(new OdbcParameter("TYPE", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "TYPE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[1].Parameters.Add(new OdbcParameter("ACCOUNT_REF", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "ACCOUNT_REF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[1].Parameters.Add(new OdbcParameter("INV_REF", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "INV_REF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2] = new OdbcCommand();
		_commandCollection[2].Connection = Connection;
		_commandCollection[2].CommandText = "SELECT     TRAN_NUMBER, TYPE, 'DATE', ACCOUNT_REF, NOMINAL_CODE, BANK_CODE, INV_REF, USER_NAME, DETAILS, EXTRA_REF, DISPUTED, \r\n                      STMT_TEXT, BANK_FLAG, VAT_FLAG, PAID_FLAG, PAID_STATUS, DEPT_NUMBER, DEPT_NAME, TAX_CODE, DELETED_FLAG, NET_AMOUNT, \r\n                      TAX_AMOUNT, GROSS_AMOUNT, AMOUNT_PAID, PAYMENT, OUTSTANDING, FOREIGN_NET_AMOUNT, FOREIGN_TAX_AMOUNT, \r\n                      FOREIGN_GROSS_AMOUNT, FOREIGN_AMOUNT_PAID, AGED_BALANCE, AGED_FUTURE, AGED_CURRENT, AGED_30, AGED_60, AGED_90, \r\n                      AGED_OLDER, AGED_CUM_CURRENT, AGED_CUM_30, AGED_CUM_60, AGED_CUM_90, FOREIGN_AGED_BALANCE, FOREIGN_AGED_FUTURE, \r\n                      FOREIGN_AGED_CURRENT, FOREIGN_AGED_30, FOREIGN_AGED_60, FOREIGN_AGED_90, FOREIGN_AGED_OLDER, \r\n                      FOREIGN_AGED_CUM_CURRENT, FOREIGN_AGED_CUM_30, FOREIGN_AGED_CUM_60, FOREIGN_AGED_CUM_90, SPLIT_NUMBER, \r\n                      HEADER_NUMBER, VAT_FLAG_CODE, DATE_FLAG, DATE_ENTERED, VAT_RECONCILED_DATE, DISPUTE_CODE, FUND_ID, \r\n                      VAT_LEDGER_RETURN_ID, RECORD_CREATE_DATE, RECORD_MODIFY_DATE, RECORD_DELETED\r\nFROM         AUDIT_SPLIT\r\nWHERE     ('DATE' = ?) AND (TYPE = ?) AND (NOMINAL_CODE = ?) AND (ACCOUNT_REF = ?) AND (INV_REF = ?) AND (DELETED_FLAG <> 1)";
		_commandCollection[2].CommandType = CommandType.Text;
		_commandCollection[2].Parameters.Add(new OdbcParameter("DATE", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2].Parameters.Add(new OdbcParameter("TYPE", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "TYPE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2].Parameters.Add(new OdbcParameter("NOMINAL_CODE", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "NOMINAL_CODE", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2].Parameters.Add(new OdbcParameter("ACCOUNT_REF", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "ACCOUNT_REF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
		_commandCollection[2].Parameters.Add(new OdbcParameter("INV_REF", OdbcType.VarChar, 1024, ParameterDirection.Input, 0, 0, "INV_REF", DataRowVersion.Current, sourceColumnNullMapping: false, null));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Transactions.AUDIT_SPLITDataTable dataTable)
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
	public virtual Transactions.AUDIT_SPLITDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		Adapter.Fill(aUDIT_SPLITDataTable);
		return aUDIT_SPLITDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy_Date_Type_AccRef_TransRef(Transactions.AUDIT_SPLITDataTable dataTable, string Param1, string TYPE, string ACCOUNT_REF, string INV_REF)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (Param1 == null)
		{
			throw new ArgumentNullException("Param1");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param1;
		if (TYPE == null)
		{
			throw new ArgumentNullException("TYPE");
		}
		Adapter.SelectCommand.Parameters[1].Value = TYPE;
		if (ACCOUNT_REF == null)
		{
			throw new ArgumentNullException("ACCOUNT_REF");
		}
		Adapter.SelectCommand.Parameters[2].Value = ACCOUNT_REF;
		if (INV_REF == null)
		{
			throw new ArgumentNullException("INV_REF");
		}
		Adapter.SelectCommand.Parameters[3].Value = INV_REF;
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
	public virtual Transactions.AUDIT_SPLITDataTable GetDataBy_Date_Type_AccRef_TransRef(string Param1, string TYPE, string ACCOUNT_REF, string INV_REF)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (Param1 == null)
		{
			throw new ArgumentNullException("Param1");
		}
		Adapter.SelectCommand.Parameters[0].Value = Param1;
		if (TYPE == null)
		{
			throw new ArgumentNullException("TYPE");
		}
		Adapter.SelectCommand.Parameters[1].Value = TYPE;
		if (ACCOUNT_REF == null)
		{
			throw new ArgumentNullException("ACCOUNT_REF");
		}
		Adapter.SelectCommand.Parameters[2].Value = ACCOUNT_REF;
		if (INV_REF == null)
		{
			throw new ArgumentNullException("INV_REF");
		}
		Adapter.SelectCommand.Parameters[3].Value = INV_REF;
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		Adapter.Fill(aUDIT_SPLITDataTable);
		return aUDIT_SPLITDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy_Transaction(Transactions.AUDIT_SPLITDataTable dataTable, string _DATE, string TYPE, string NOMINAL_CODE, string ACCOUNT_REF, string INV_REF)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (_DATE == null)
		{
			throw new ArgumentNullException("_DATE");
		}
		Adapter.SelectCommand.Parameters[0].Value = _DATE;
		if (TYPE == null)
		{
			throw new ArgumentNullException("TYPE");
		}
		Adapter.SelectCommand.Parameters[1].Value = TYPE;
		if (NOMINAL_CODE == null)
		{
			throw new ArgumentNullException("NOMINAL_CODE");
		}
		Adapter.SelectCommand.Parameters[2].Value = NOMINAL_CODE;
		if (ACCOUNT_REF == null)
		{
			throw new ArgumentNullException("ACCOUNT_REF");
		}
		Adapter.SelectCommand.Parameters[3].Value = ACCOUNT_REF;
		if (INV_REF == null)
		{
			throw new ArgumentNullException("INV_REF");
		}
		Adapter.SelectCommand.Parameters[4].Value = INV_REF;
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
	public virtual Transactions.AUDIT_SPLITDataTable GetDataBy_Transaction(string _DATE, string TYPE, string NOMINAL_CODE, string ACCOUNT_REF, string INV_REF)
	{
		Adapter.SelectCommand = CommandCollection[2];
		if (_DATE == null)
		{
			throw new ArgumentNullException("_DATE");
		}
		Adapter.SelectCommand.Parameters[0].Value = _DATE;
		if (TYPE == null)
		{
			throw new ArgumentNullException("TYPE");
		}
		Adapter.SelectCommand.Parameters[1].Value = TYPE;
		if (NOMINAL_CODE == null)
		{
			throw new ArgumentNullException("NOMINAL_CODE");
		}
		Adapter.SelectCommand.Parameters[2].Value = NOMINAL_CODE;
		if (ACCOUNT_REF == null)
		{
			throw new ArgumentNullException("ACCOUNT_REF");
		}
		Adapter.SelectCommand.Parameters[3].Value = ACCOUNT_REF;
		if (INV_REF == null)
		{
			throw new ArgumentNullException("INV_REF");
		}
		Adapter.SelectCommand.Parameters[4].Value = INV_REF;
		Transactions.AUDIT_SPLITDataTable aUDIT_SPLITDataTable = new Transactions.AUDIT_SPLITDataTable();
		Adapter.Fill(aUDIT_SPLITDataTable);
		return aUDIT_SPLITDataTable;
	}
}
