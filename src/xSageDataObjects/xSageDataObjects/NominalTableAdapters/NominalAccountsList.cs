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
public class NominalAccountsList : Component
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
	public NominalAccountsList()
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
		dataTableMapping.DataSetTable = "NominalAccountsList";
		dataTableMapping.ColumnMappings.Add("ACCOUNT_REF", "ACCOUNT_REF");
		dataTableMapping.ColumnMappings.Add("NAME", "NAME");
		dataTableMapping.ColumnMappings.Add("ACCOUNT_TYPE", "ACCOUNT_TYPE");
		dataTableMapping.ColumnMappings.Add("BALANCE", "BALANCE");
		dataTableMapping.ColumnMappings.Add("QUICK_RATIO", "QUICK_RATIO");
		dataTableMapping.ColumnMappings.Add("SOFA_ID", "SOFA_ID");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH1", "PRIOR_YR_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH2", "PRIOR_YR_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH3", "PRIOR_YR_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH4", "PRIOR_YR_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH5", "PRIOR_YR_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH6", "PRIOR_YR_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH7", "PRIOR_YR_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH8", "PRIOR_YR_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH9", "PRIOR_YR_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH10", "PRIOR_YR_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH11", "PRIOR_YR_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_MTH12", "PRIOR_YR_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH1", "PRIOR_YR2_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH2", "PRIOR_YR2_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH3", "PRIOR_YR2_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH4", "PRIOR_YR2_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH5", "PRIOR_YR2_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH6", "PRIOR_YR2_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH7", "PRIOR_YR2_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH8", "PRIOR_YR2_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH9", "PRIOR_YR2_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH10", "PRIOR_YR2_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH11", "PRIOR_YR2_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR2_MTH12", "PRIOR_YR2_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH1", "PRIOR_YR3_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH2", "PRIOR_YR3_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH3", "PRIOR_YR3_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH4", "PRIOR_YR3_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH5", "PRIOR_YR3_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH6", "PRIOR_YR3_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH7", "PRIOR_YR3_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH8", "PRIOR_YR3_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH9", "PRIOR_YR3_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH10", "PRIOR_YR3_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH11", "PRIOR_YR3_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR3_MTH12", "PRIOR_YR3_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH1", "PRIOR_YR4_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH2", "PRIOR_YR4_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH3", "PRIOR_YR4_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH4", "PRIOR_YR4_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH5", "PRIOR_YR4_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH6", "PRIOR_YR4_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH7", "PRIOR_YR4_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH8", "PRIOR_YR4_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH9", "PRIOR_YR4_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH10", "PRIOR_YR4_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH11", "PRIOR_YR4_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR4_MTH12", "PRIOR_YR4_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH1", "PRIOR_YR5_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH2", "PRIOR_YR5_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH3", "PRIOR_YR5_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH4", "PRIOR_YR5_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH5", "PRIOR_YR5_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH6", "PRIOR_YR5_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH7", "PRIOR_YR5_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH8", "PRIOR_YR5_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH9", "PRIOR_YR5_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH10", "PRIOR_YR5_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH11", "PRIOR_YR5_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR5_MTH12", "PRIOR_YR5_MTH12");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH1", "BUDGET_MTH1");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH2", "BUDGET_MTH2");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH3", "BUDGET_MTH3");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH4", "BUDGET_MTH4");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH5", "BUDGET_MTH5");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH6", "BUDGET_MTH6");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH7", "BUDGET_MTH7");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH8", "BUDGET_MTH8");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH9", "BUDGET_MTH9");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH10", "BUDGET_MTH10");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH11", "BUDGET_MTH11");
		dataTableMapping.ColumnMappings.Add("BUDGET_MTH12", "BUDGET_MTH12");
		dataTableMapping.ColumnMappings.Add("BALANCE_BF", "BALANCE_BF");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH1", "BALANCE_MTH1");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH2", "BALANCE_MTH2");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH3", "BALANCE_MTH3");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH4", "BALANCE_MTH4");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH5", "BALANCE_MTH5");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH6", "BALANCE_MTH6");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH7", "BALANCE_MTH7");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH8", "BALANCE_MTH8");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH9", "BALANCE_MTH9");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH10", "BALANCE_MTH10");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH11", "BALANCE_MTH11");
		dataTableMapping.ColumnMappings.Add("BALANCE_MTH12", "BALANCE_MTH12");
		dataTableMapping.ColumnMappings.Add("BALANCE_FUTURE", "BALANCE_FUTURE");
		dataTableMapping.ColumnMappings.Add("DEBIT_BF", "DEBIT_BF");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH1", "DEBIT_MTH1");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH2", "DEBIT_MTH2");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH3", "DEBIT_MTH3");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH4", "DEBIT_MTH4");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH5", "DEBIT_MTH5");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH6", "DEBIT_MTH6");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH7", "DEBIT_MTH7");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH8", "DEBIT_MTH8");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH9", "DEBIT_MTH9");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH10", "DEBIT_MTH10");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH11", "DEBIT_MTH11");
		dataTableMapping.ColumnMappings.Add("DEBIT_MTH12", "DEBIT_MTH12");
		dataTableMapping.ColumnMappings.Add("DEBIT_FUTURE", "DEBIT_FUTURE");
		dataTableMapping.ColumnMappings.Add("CREDIT_BF", "CREDIT_BF");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH1", "CREDIT_MTH1");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH2", "CREDIT_MTH2");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH3", "CREDIT_MTH3");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH4", "CREDIT_MTH4");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH5", "CREDIT_MTH5");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH6", "CREDIT_MTH6");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH7", "CREDIT_MTH7");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH8", "CREDIT_MTH8");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH9", "CREDIT_MTH9");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH10", "CREDIT_MTH10");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH11", "CREDIT_MTH11");
		dataTableMapping.ColumnMappings.Add("CREDIT_MTH12", "CREDIT_MTH12");
		dataTableMapping.ColumnMappings.Add("CREDIT_FUTURE", "CREDIT_FUTURE");
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
		_commandCollection = new OdbcCommand[1];
		_commandCollection[0] = new OdbcCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT     NOMINAL_LEDGER.*\r\nFROM         NOMINAL_LEDGER";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Nominal.NominalAccountsListDataTable dataTable)
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
	public virtual Nominal.NominalAccountsListDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Nominal.NominalAccountsListDataTable nominalAccountsListDataTable = new Nominal.NominalAccountsListDataTable();
		Adapter.Fill(nominalAccountsListDataTable);
		return nominalAccountsListDataTable;
	}
}
