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
public class AUDIT_HEADERTableAdapter : Component
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
	public AUDIT_HEADERTableAdapter()
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
		dataTableMapping.DataSetTable = "AUDIT_HEADER";
		dataTableMapping.ColumnMappings.Add("TRAN_NUMBER", "TRAN_NUMBER");
		dataTableMapping.ColumnMappings.Add("ITEM_COUNT", "ITEM_COUNT");
		dataTableMapping.ColumnMappings.Add("TYPE", "TYPE");
		dataTableMapping.ColumnMappings.Add("DATE", "DATE");
		dataTableMapping.ColumnMappings.Add("ACCOUNT_REF", "ACCOUNT_REF");
		dataTableMapping.ColumnMappings.Add("SALES_PURCHASE_REF", "SALES_PURCHASE_REF");
		dataTableMapping.ColumnMappings.Add("BANK_CODE", "BANK_CODE");
		dataTableMapping.ColumnMappings.Add("BANK_NAME", "BANK_NAME");
		dataTableMapping.ColumnMappings.Add("INV_REF", "INV_REF");
		dataTableMapping.ColumnMappings.Add("INV_REF_NUMERIC", "INV_REF_NUMERIC");
		dataTableMapping.ColumnMappings.Add("USER_NAME", "USER_NAME");
		dataTableMapping.ColumnMappings.Add("DETAILS", "DETAILS");
		dataTableMapping.ColumnMappings.Add("DUE_DATE", "DUE_DATE");
		dataTableMapping.ColumnMappings.Add("LAST_CHARGE_DATE", "LAST_CHARGE_DATE");
		dataTableMapping.ColumnMappings.Add("FINANCE_CHARGE", "FINANCE_CHARGE");
		dataTableMapping.ColumnMappings.Add("INTEREST_RATE", "INTEREST_RATE");
		dataTableMapping.ColumnMappings.Add("ELECTRONIC_TRANS", "ELECTRONIC_TRANS");
		dataTableMapping.ColumnMappings.Add("DISPUTED", "DISPUTED");
		dataTableMapping.ColumnMappings.Add("PAID_FLAG", "PAID_FLAG");
		dataTableMapping.ColumnMappings.Add("PAID_STATUS", "PAID_STATUS");
		dataTableMapping.ColumnMappings.Add("DELETED_FLAG", "DELETED_FLAG");
		dataTableMapping.ColumnMappings.Add("DATE_FLAG", "DATE_FLAG");
		dataTableMapping.ColumnMappings.Add("DATE_BF", "DATE_BF");
		dataTableMapping.ColumnMappings.Add("DATE_FROM", "DATE_FROM");
		dataTableMapping.ColumnMappings.Add("DATE_TO", "DATE_TO");
		dataTableMapping.ColumnMappings.Add("NET_AMOUNT", "NET_AMOUNT");
		dataTableMapping.ColumnMappings.Add("TAX_AMOUNT", "TAX_AMOUNT");
		dataTableMapping.ColumnMappings.Add("GROSS_AMOUNT", "GROSS_AMOUNT");
		dataTableMapping.ColumnMappings.Add("BANK_AMOUNT", "BANK_AMOUNT");
		dataTableMapping.ColumnMappings.Add("AMOUNT_PAID", "AMOUNT_PAID");
		dataTableMapping.ColumnMappings.Add("PAYMENT", "PAYMENT");
		dataTableMapping.ColumnMappings.Add("OUTSTANDING", "OUTSTANDING");
		dataTableMapping.ColumnMappings.Add("FOREIGN_NET_AMOUNT", "FOREIGN_NET_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_TAX_AMOUNT", "FOREIGN_TAX_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_GROSS_AMOUNT", "FOREIGN_GROSS_AMOUNT");
		dataTableMapping.ColumnMappings.Add("FOREIGN_AMOUNT_PAID", "FOREIGN_AMOUNT_PAID");
		dataTableMapping.ColumnMappings.Add("FOREIGN_BANK_AMOUNT", "FOREIGN_BANK_AMOUNT");
		dataTableMapping.ColumnMappings.Add("CURRENCY", "CURRENCY");
		dataTableMapping.ColumnMappings.Add("CURRENCY_TYPE", "CURRENCY_TYPE");
		dataTableMapping.ColumnMappings.Add("EURO_GROSS", "EURO_GROSS");
		dataTableMapping.ColumnMappings.Add("EURO_RATE", "EURO_RATE");
		dataTableMapping.ColumnMappings.Add("FOREIGN_RATE", "FOREIGN_RATE");
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
		dataTableMapping.ColumnMappings.Add("BANK_FLAG", "BANK_FLAG");
		dataTableMapping.ColumnMappings.Add("HEADER_NUMBER", "HEADER_NUMBER");
		dataTableMapping.ColumnMappings.Add("DATE_ENTERED", "DATE_ENTERED");
		dataTableMapping.ColumnMappings.Add("DATE_BANK_RECONCILED", "DATE_BANK_RECONCILED");
		dataTableMapping.ColumnMappings.Add("CIS_RECONCILED", "CIS_RECONCILED");
		dataTableMapping.ColumnMappings.Add("SPS_REF", "SPS_REF");
		dataTableMapping.ColumnMappings.Add("DEPOSIT_DATE", "DEPOSIT_DATE");
		dataTableMapping.ColumnMappings.Add("DEPOSIT_FLAG", "DEPOSIT_FLAG");
		dataTableMapping.ColumnMappings.Add("RECURRING_ENTRY_ID", "RECURRING_ENTRY_ID");
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
		_commandCollection = new OdbcCommand[2];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     AUDIT_HEADER.*\r\nFROM         AUDIT_HEADER";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new OdbcCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT     AUDIT_HEADER.*\r\nFROM         AUDIT_HEADER";
		_commandCollection[1].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Transactions.AUDIT_HEADERDataTable dataTable)
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
	public virtual Transactions.AUDIT_HEADERDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Transactions.AUDIT_HEADERDataTable aUDIT_HEADERDataTable = new Transactions.AUDIT_HEADERDataTable();
		Adapter.Fill(aUDIT_HEADERDataTable);
		return aUDIT_HEADERDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy(Transactions.AUDIT_HEADERDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[1];
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
	public virtual Transactions.AUDIT_HEADERDataTable GetDataBy()
	{
		Adapter.SelectCommand = CommandCollection[1];
		Transactions.AUDIT_HEADERDataTable aUDIT_HEADERDataTable = new Transactions.AUDIT_HEADERDataTable();
		Adapter.Fill(aUDIT_HEADERDataTable);
		return aUDIT_HEADERDataTable;
	}
}
