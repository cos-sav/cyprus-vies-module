using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using xSageDataObjects.My;

namespace xSageDataObjects.NominalTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class NominalControlAccountsList : Component
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
	public NominalControlAccountsList()
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
		dataTableMapping.DataSetTable = "NominalControlAccountsList";
		dataTableMapping.ColumnMappings.Add("DEBTORS", "DEBTORS");
		dataTableMapping.ColumnMappings.Add("VAT_SALES", "VAT_SALES");
		dataTableMapping.ColumnMappings.Add("CREDITORS", "CREDITORS");
		dataTableMapping.ColumnMappings.Add("VAT_PURCHASE", "VAT_PURCHASE");
		dataTableMapping.ColumnMappings.Add("DISCOUNT_SALES", "DISCOUNT_SALES");
		dataTableMapping.ColumnMappings.Add("DISCOUNT_PURCHASE", "DISCOUNT_PURCHASE");
		dataTableMapping.ColumnMappings.Add("DEFAULT_BANK", "DEFAULT_BANK");
		dataTableMapping.ColumnMappings.Add("DEFAULT_SALES", "DEFAULT_SALES");
		dataTableMapping.ColumnMappings.Add("RETAINED_EARNINGS", "RETAINED_EARNINGS");
		dataTableMapping.ColumnMappings.Add("CREDIT_CHARGES", "CREDIT_CHARGES");
		dataTableMapping.ColumnMappings.Add("BAD_DEBTS", "BAD_DEBTS");
		dataTableMapping.ColumnMappings.Add("ACCRUALS", "ACCRUALS");
		dataTableMapping.ColumnMappings.Add("PREPAYMENTS", "PREPAYMENTS");
		dataTableMapping.ColumnMappings.Add("SUSPENSE", "SUSPENSE");
		dataTableMapping.ColumnMappings.Add("MISPOSTINGS", "MISPOSTINGS");
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
		_commandCollection = new OdbcCommand[1];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     NOM_DEBTORS AS DEBTORS, NOM_TAX_SALES AS VAT_SALES, NOM_CREDITORS AS CREDITORS, NOM_TAX_PURCHASE AS VAT_PURCHASE, \r\n                      NOM_DISCOUNT_SALES AS DISCOUNT_SALES, NOM_DISCOUNT_PURCHASE AS DISCOUNT_PURCHASE, NOM_DEFAULT_BANK AS DEFAULT_BANK, \r\n                      NOM_DEFAULT_SALES AS DEFAULT_SALES, NOM_RETAINED_EARNINGS AS RETAINED_EARNINGS, NOM_CREDIT_CHARGES AS CREDIT_CHARGES, \r\n                      NOM_BAD_DEBTS AS BAD_DEBTS, NOM_ACCRUALS AS ACCRUALS, NOM_PREPAYMENTS AS PREPAYMENTS, NOM_SUSPENSE AS SUSPENSE, \r\n                      NOM_MISPOSTINGS AS MISPOSTINGS\r\nFROM         COMPANY";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Nominal.NominalControlAccountsListDataTable dataTable)
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
	public virtual Nominal.NominalControlAccountsListDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Nominal.NominalControlAccountsListDataTable nominalControlAccountsListDataTable = new Nominal.NominalControlAccountsListDataTable();
		Adapter.Fill(nominalControlAccountsListDataTable);
		return nominalControlAccountsListDataTable;
	}
}
