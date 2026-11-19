using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using xSageDataObjects.My;

namespace xSageDataObjects.ProductsTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class ProductsList : Component
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
	public ProductsList()
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
		dataTableMapping.DataSetTable = "ProductsList";
		dataTableMapping.ColumnMappings.Add("STOCK_CODE", "STOCK_CODE");
		dataTableMapping.ColumnMappings.Add("DESCRIPTION", "DESCRIPTION");
		dataTableMapping.ColumnMappings.Add("UNIT_OF_SALE", "UNIT_OF_SALE");
		dataTableMapping.ColumnMappings.Add("NOMINAL_CODE", "NOMINAL_CODE");
		dataTableMapping.ColumnMappings.Add("PURCHASE_REF", "PURCHASE_REF");
		dataTableMapping.ColumnMappings.Add("SUPPLIER_PART_NUMBER", "SUPPLIER_PART_NUMBER");
		dataTableMapping.ColumnMappings.Add("LOCATION", "LOCATION");
		dataTableMapping.ColumnMappings.Add("COMMODITY_CODE", "COMMODITY_CODE");
		dataTableMapping.ColumnMappings.Add("SALES_PRICE", "SALES_PRICE");
		dataTableMapping.ColumnMappings.Add("WEB_DESCRIPTION", "WEB_DESCRIPTION");
		dataTableMapping.ColumnMappings.Add("WEB_DETAILS", "WEB_DETAILS");
		dataTableMapping.ColumnMappings.Add("WEB_CATEGORY_1", "WEB_CATEGORY_1");
		dataTableMapping.ColumnMappings.Add("WEB_CATEGORY_2", "WEB_CATEGORY_2");
		dataTableMapping.ColumnMappings.Add("WEB_CATEGORY_3", "WEB_CATEGORY_3");
		dataTableMapping.ColumnMappings.Add("WEB_IMAGE_FILE", "WEB_IMAGE_FILE");
		dataTableMapping.ColumnMappings.Add("WEB_PUBLISH", "WEB_PUBLISH");
		dataTableMapping.ColumnMappings.Add("WEB_SPECIAL", "WEB_SPECIAL");
		dataTableMapping.ColumnMappings.Add("INTRASTAT_COMM_CODE", "INTRASTAT_COMM_CODE");
		dataTableMapping.ColumnMappings.Add("IGNORE_STK_LVL_FLAG", "IGNORE_STK_LVL_FLAG");
		dataTableMapping.ColumnMappings.Add("DEPT_NUMBER", "DEPT_NUMBER");
		dataTableMapping.ColumnMappings.Add("DEPT_NAME", "DEPT_NAME");
		dataTableMapping.ColumnMappings.Add("TAX_CODE", "TAX_CODE");
		dataTableMapping.ColumnMappings.Add("ASSEMBLY_LEVEL", "ASSEMBLY_LEVEL");
		dataTableMapping.ColumnMappings.Add("LINK_LEVEL", "LINK_LEVEL");
		dataTableMapping.ColumnMappings.Add("STOCK_CAT", "STOCK_CAT");
		dataTableMapping.ColumnMappings.Add("STOCK_CAT_NAME", "STOCK_CAT_NAME");
		dataTableMapping.ColumnMappings.Add("STOCK_TAKE_DATE", "STOCK_TAKE_DATE");
		dataTableMapping.ColumnMappings.Add("LAST_PURCHASE_PRICE", "LAST_PURCHASE_PRICE");
		dataTableMapping.ColumnMappings.Add("LAST_DISC_PURCHASE_PRICE", "LAST_DISC_PURCHASE_PRICE");
		dataTableMapping.ColumnMappings.Add("AVERAGE_COST_PRICE", "AVERAGE_COST_PRICE");
		dataTableMapping.ColumnMappings.Add("QTY_IN_STOCK", "QTY_IN_STOCK");
		dataTableMapping.ColumnMappings.Add("QTY_ON_ORDER", "QTY_ON_ORDER");
		dataTableMapping.ColumnMappings.Add("QTY_ALLOCATED", "QTY_ALLOCATED");
		dataTableMapping.ColumnMappings.Add("QTY_LAST_ORDER", "QTY_LAST_ORDER");
		dataTableMapping.ColumnMappings.Add("QTY_REORDER", "QTY_REORDER");
		dataTableMapping.ColumnMappings.Add("QTY_REORDER_LEVEL", "QTY_REORDER_LEVEL");
		dataTableMapping.ColumnMappings.Add("QTY_LAST_STOCK_TAKE", "QTY_LAST_STOCK_TAKE");
		dataTableMapping.ColumnMappings.Add("QTY_MAKEUP", "QTY_MAKEUP");
		dataTableMapping.ColumnMappings.Add("LAST_SALE_DATE", "LAST_SALE_DATE");
		dataTableMapping.ColumnMappings.Add("LAST_PURCHASE_DATE", "LAST_PURCHASE_DATE");
		dataTableMapping.ColumnMappings.Add("UNIT_WEIGHT", "UNIT_WEIGHT");
		dataTableMapping.ColumnMappings.Add("HAS_NO_COMPONENT", "HAS_NO_COMPONENT");
		dataTableMapping.ColumnMappings.Add("HAS_BOM", "HAS_BOM");
		dataTableMapping.ColumnMappings.Add("BARCODE", "BARCODE");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_1", "COMPONENT_CODE_1");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_2", "COMPONENT_CODE_2");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_3", "COMPONENT_CODE_3");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_4", "COMPONENT_CODE_4");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_5", "COMPONENT_CODE_5");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_6", "COMPONENT_CODE_6");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_7", "COMPONENT_CODE_7");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_8", "COMPONENT_CODE_8");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_9", "COMPONENT_CODE_9");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_10", "COMPONENT_CODE_10");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_11", "COMPONENT_CODE_11");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_12", "COMPONENT_CODE_12");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_13", "COMPONENT_CODE_13");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_14", "COMPONENT_CODE_14");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_15", "COMPONENT_CODE_15");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_16", "COMPONENT_CODE_16");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_17", "COMPONENT_CODE_17");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_18", "COMPONENT_CODE_18");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_19", "COMPONENT_CODE_19");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_20", "COMPONENT_CODE_20");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_21", "COMPONENT_CODE_21");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_22", "COMPONENT_CODE_22");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_23", "COMPONENT_CODE_23");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_24", "COMPONENT_CODE_24");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_25", "COMPONENT_CODE_25");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_26", "COMPONENT_CODE_26");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_27", "COMPONENT_CODE_27");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_28", "COMPONENT_CODE_28");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_29", "COMPONENT_CODE_29");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_30", "COMPONENT_CODE_30");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_31", "COMPONENT_CODE_31");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_32", "COMPONENT_CODE_32");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_33", "COMPONENT_CODE_33");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_34", "COMPONENT_CODE_34");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_35", "COMPONENT_CODE_35");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_36", "COMPONENT_CODE_36");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_37", "COMPONENT_CODE_37");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_38", "COMPONENT_CODE_38");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_39", "COMPONENT_CODE_39");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_40", "COMPONENT_CODE_40");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_41", "COMPONENT_CODE_41");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_42", "COMPONENT_CODE_42");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_43", "COMPONENT_CODE_43");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_44", "COMPONENT_CODE_44");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_45", "COMPONENT_CODE_45");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_46", "COMPONENT_CODE_46");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_47", "COMPONENT_CODE_47");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_48", "COMPONENT_CODE_48");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_49", "COMPONENT_CODE_49");
		dataTableMapping.ColumnMappings.Add("COMPONENT_CODE_50", "COMPONENT_CODE_50");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_1", "COMPONENT_QTY_1");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_2", "COMPONENT_QTY_2");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_3", "COMPONENT_QTY_3");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_4", "COMPONENT_QTY_4");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_5", "COMPONENT_QTY_5");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_6", "COMPONENT_QTY_6");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_7", "COMPONENT_QTY_7");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_8", "COMPONENT_QTY_8");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_9", "COMPONENT_QTY_9");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_10", "COMPONENT_QTY_10");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_11", "COMPONENT_QTY_11");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_12", "COMPONENT_QTY_12");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_13", "COMPONENT_QTY_13");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_14", "COMPONENT_QTY_14");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_15", "COMPONENT_QTY_15");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_16", "COMPONENT_QTY_16");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_17", "COMPONENT_QTY_17");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_18", "COMPONENT_QTY_18");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_19", "COMPONENT_QTY_19");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_20", "COMPONENT_QTY_20");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_21", "COMPONENT_QTY_21");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_22", "COMPONENT_QTY_22");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_23", "COMPONENT_QTY_23");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_24", "COMPONENT_QTY_24");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_25", "COMPONENT_QTY_25");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_26", "COMPONENT_QTY_26");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_27", "COMPONENT_QTY_27");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_28", "COMPONENT_QTY_28");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_29", "COMPONENT_QTY_29");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_30", "COMPONENT_QTY_30");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_31", "COMPONENT_QTY_31");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_32", "COMPONENT_QTY_32");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_33", "COMPONENT_QTY_33");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_34", "COMPONENT_QTY_34");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_35", "COMPONENT_QTY_35");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_36", "COMPONENT_QTY_36");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_37", "COMPONENT_QTY_37");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_38", "COMPONENT_QTY_38");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_39", "COMPONENT_QTY_39");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_40", "COMPONENT_QTY_40");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_41", "COMPONENT_QTY_41");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_42", "COMPONENT_QTY_42");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_43", "COMPONENT_QTY_43");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_44", "COMPONENT_QTY_44");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_45", "COMPONENT_QTY_45");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_46", "COMPONENT_QTY_46");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_47", "COMPONENT_QTY_47");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_48", "COMPONENT_QTY_48");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_49", "COMPONENT_QTY_49");
		dataTableMapping.ColumnMappings.Add("COMPONENT_QTY_50", "COMPONENT_QTY_50");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_BF", "QTY_SOLD_BF");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH1", "QTY_SOLD_MTH1");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH2", "QTY_SOLD_MTH2");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH3", "QTY_SOLD_MTH3");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH4", "QTY_SOLD_MTH4");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH5", "QTY_SOLD_MTH5");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH6", "QTY_SOLD_MTH6");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH7", "QTY_SOLD_MTH7");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH8", "QTY_SOLD_MTH8");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH9", "QTY_SOLD_MTH9");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH10", "QTY_SOLD_MTH10");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH11", "QTY_SOLD_MTH11");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_MTH12", "QTY_SOLD_MTH12");
		dataTableMapping.ColumnMappings.Add("QTY_SOLD_FUTURE", "QTY_SOLD_FUTURE");
		dataTableMapping.ColumnMappings.Add("SALES_BF", "SALES_BF");
		dataTableMapping.ColumnMappings.Add("SALES_MTH1", "SALES_MTH1");
		dataTableMapping.ColumnMappings.Add("SALES_MTH2", "SALES_MTH2");
		dataTableMapping.ColumnMappings.Add("SALES_MTH3", "SALES_MTH3");
		dataTableMapping.ColumnMappings.Add("SALES_MTH4", "SALES_MTH4");
		dataTableMapping.ColumnMappings.Add("SALES_MTH5", "SALES_MTH5");
		dataTableMapping.ColumnMappings.Add("SALES_MTH6", "SALES_MTH6");
		dataTableMapping.ColumnMappings.Add("SALES_MTH7", "SALES_MTH7");
		dataTableMapping.ColumnMappings.Add("SALES_MTH8", "SALES_MTH8");
		dataTableMapping.ColumnMappings.Add("SALES_MTH9", "SALES_MTH9");
		dataTableMapping.ColumnMappings.Add("SALES_MTH10", "SALES_MTH10");
		dataTableMapping.ColumnMappings.Add("SALES_MTH11", "SALES_MTH11");
		dataTableMapping.ColumnMappings.Add("SALES_MTH12", "SALES_MTH12");
		dataTableMapping.ColumnMappings.Add("SALES_FUTURE", "SALES_FUTURE");
		dataTableMapping.ColumnMappings.Add("COST_BF", "COST_BF");
		dataTableMapping.ColumnMappings.Add("COST_MTH1", "COST_MTH1");
		dataTableMapping.ColumnMappings.Add("COST_MTH2", "COST_MTH2");
		dataTableMapping.ColumnMappings.Add("COST_MTH3", "COST_MTH3");
		dataTableMapping.ColumnMappings.Add("COST_MTH4", "COST_MTH4");
		dataTableMapping.ColumnMappings.Add("COST_MTH5", "COST_MTH5");
		dataTableMapping.ColumnMappings.Add("COST_MTH6", "COST_MTH6");
		dataTableMapping.ColumnMappings.Add("COST_MTH7", "COST_MTH7");
		dataTableMapping.ColumnMappings.Add("COST_MTH8", "COST_MTH8");
		dataTableMapping.ColumnMappings.Add("COST_MTH9", "COST_MTH9");
		dataTableMapping.ColumnMappings.Add("COST_MTH10", "COST_MTH10");
		dataTableMapping.ColumnMappings.Add("COST_MTH11", "COST_MTH11");
		dataTableMapping.ColumnMappings.Add("COST_MTH12", "COST_MTH12");
		dataTableMapping.ColumnMappings.Add("COST_FUTURE", "COST_FUTURE");
		dataTableMapping.ColumnMappings.Add("THIS_RECORD", "THIS_RECORD");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_BF", "BUDGET_QTY_SOLD_BF");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH1", "BUDGET_QTY_SOLD_MTH1");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH2", "BUDGET_QTY_SOLD_MTH2");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH3", "BUDGET_QTY_SOLD_MTH3");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH4", "BUDGET_QTY_SOLD_MTH4");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH5", "BUDGET_QTY_SOLD_MTH5");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH6", "BUDGET_QTY_SOLD_MTH6");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH7", "BUDGET_QTY_SOLD_MTH7");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH8", "BUDGET_QTY_SOLD_MTH8");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH9", "BUDGET_QTY_SOLD_MTH9");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH10", "BUDGET_QTY_SOLD_MTH10");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH11", "BUDGET_QTY_SOLD_MTH11");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_MTH12", "BUDGET_QTY_SOLD_MTH12");
		dataTableMapping.ColumnMappings.Add("BUDGET_QTY_SOLD_FUTURE", "BUDGET_QTY_SOLD_FUTURE");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_BF", "BUDGET_SALES_BF");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH1", "BUDGET_SALES_MTH1");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH2", "BUDGET_SALES_MTH2");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH3", "BUDGET_SALES_MTH3");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH4", "BUDGET_SALES_MTH4");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH5", "BUDGET_SALES_MTH5");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH6", "BUDGET_SALES_MTH6");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH7", "BUDGET_SALES_MTH7");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH8", "BUDGET_SALES_MTH8");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH9", "BUDGET_SALES_MTH9");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH10", "BUDGET_SALES_MTH10");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH11", "BUDGET_SALES_MTH11");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_MTH12", "BUDGET_SALES_MTH12");
		dataTableMapping.ColumnMappings.Add("BUDGET_SALES_FUTURE", "BUDGET_SALES_FUTURE");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_BF", "PRIOR_YR_QTY_SOLD_BF");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH1", "PRIOR_YR_QTY_SOLD_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH2", "PRIOR_YR_QTY_SOLD_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH3", "PRIOR_YR_QTY_SOLD_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH4", "PRIOR_YR_QTY_SOLD_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH5", "PRIOR_YR_QTY_SOLD_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH6", "PRIOR_YR_QTY_SOLD_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH7", "PRIOR_YR_QTY_SOLD_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH8", "PRIOR_YR_QTY_SOLD_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH9", "PRIOR_YR_QTY_SOLD_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH10", "PRIOR_YR_QTY_SOLD_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH11", "PRIOR_YR_QTY_SOLD_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_MTH12", "PRIOR_YR_QTY_SOLD_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_QTY_SOLD_FUTURE", "PRIOR_YR_QTY_SOLD_FUTURE");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_BF", "PRIOR_YR_SALES_BF");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH1", "PRIOR_YR_SALES_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH2", "PRIOR_YR_SALES_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH3", "PRIOR_YR_SALES_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH4", "PRIOR_YR_SALES_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH5", "PRIOR_YR_SALES_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH6", "PRIOR_YR_SALES_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH7", "PRIOR_YR_SALES_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH8", "PRIOR_YR_SALES_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH9", "PRIOR_YR_SALES_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH10", "PRIOR_YR_SALES_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH11", "PRIOR_YR_SALES_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_MTH12", "PRIOR_YR_SALES_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_SALES_FUTURE", "PRIOR_YR_SALES_FUTURE");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_BF", "PRIOR_YR_COST_BF");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH1", "PRIOR_YR_COST_MTH1");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH2", "PRIOR_YR_COST_MTH2");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH3", "PRIOR_YR_COST_MTH3");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH4", "PRIOR_YR_COST_MTH4");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH5", "PRIOR_YR_COST_MTH5");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH6", "PRIOR_YR_COST_MTH6");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH7", "PRIOR_YR_COST_MTH7");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH8", "PRIOR_YR_COST_MTH8");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH9", "PRIOR_YR_COST_MTH9");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH10", "PRIOR_YR_COST_MTH10");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH11", "PRIOR_YR_COST_MTH11");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_MTH12", "PRIOR_YR_COST_MTH12");
		dataTableMapping.ColumnMappings.Add("PRIOR_YR_COST_FUTURE", "PRIOR_YR_COST_FUTURE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_1_QTY", "DISC_A_LEVEL_1_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_2_QTY", "DISC_A_LEVEL_2_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_3_QTY", "DISC_A_LEVEL_3_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_4_QTY", "DISC_A_LEVEL_4_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_5_QTY", "DISC_A_LEVEL_5_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_6_QTY", "DISC_A_LEVEL_6_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_7_QTY", "DISC_A_LEVEL_7_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_8_QTY", "DISC_A_LEVEL_8_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_9_QTY", "DISC_A_LEVEL_9_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_10_QTY", "DISC_A_LEVEL_10_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_1_RATE", "DISC_A_LEVEL_1_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_2_RATE", "DISC_A_LEVEL_2_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_3_RATE", "DISC_A_LEVEL_3_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_4_RATE", "DISC_A_LEVEL_4_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_5_RATE", "DISC_A_LEVEL_5_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_6_RATE", "DISC_A_LEVEL_6_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_7_RATE", "DISC_A_LEVEL_7_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_8_RATE", "DISC_A_LEVEL_8_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_9_RATE", "DISC_A_LEVEL_9_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_A_LEVEL_10_RATE", "DISC_A_LEVEL_10_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_1_QTY", "DISC_B_LEVEL_1_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_2_QTY", "DISC_B_LEVEL_2_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_3_QTY", "DISC_B_LEVEL_3_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_4_QTY", "DISC_B_LEVEL_4_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_5_QTY", "DISC_B_LEVEL_5_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_6_QTY", "DISC_B_LEVEL_6_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_7_QTY", "DISC_B_LEVEL_7_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_8_QTY", "DISC_B_LEVEL_8_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_9_QTY", "DISC_B_LEVEL_9_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_10_QTY", "DISC_B_LEVEL_10_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_1_RATE", "DISC_B_LEVEL_1_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_2_RATE", "DISC_B_LEVEL_2_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_3_RATE", "DISC_B_LEVEL_3_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_4_RATE", "DISC_B_LEVEL_4_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_5_RATE", "DISC_B_LEVEL_5_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_6_RATE", "DISC_B_LEVEL_6_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_7_RATE", "DISC_B_LEVEL_7_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_8_RATE", "DISC_B_LEVEL_8_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_9_RATE", "DISC_B_LEVEL_9_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_B_LEVEL_10_RATE", "DISC_B_LEVEL_10_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_1_QTY", "DISC_C_LEVEL_1_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_2_QTY", "DISC_C_LEVEL_2_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_3_QTY", "DISC_C_LEVEL_3_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_4_QTY", "DISC_C_LEVEL_4_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_5_QTY", "DISC_C_LEVEL_5_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_6_QTY", "DISC_C_LEVEL_6_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_7_QTY", "DISC_C_LEVEL_7_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_8_QTY", "DISC_C_LEVEL_8_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_9_QTY", "DISC_C_LEVEL_9_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_10_QTY", "DISC_C_LEVEL_10_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_1_RATE", "DISC_C_LEVEL_1_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_2_RATE", "DISC_C_LEVEL_2_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_3_RATE", "DISC_C_LEVEL_3_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_4_RATE", "DISC_C_LEVEL_4_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_5_RATE", "DISC_C_LEVEL_5_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_6_RATE", "DISC_C_LEVEL_6_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_7_RATE", "DISC_C_LEVEL_7_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_8_RATE", "DISC_C_LEVEL_8_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_9_RATE", "DISC_C_LEVEL_9_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_C_LEVEL_10_RATE", "DISC_C_LEVEL_10_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_1_QTY", "DISC_D_LEVEL_1_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_2_QTY", "DISC_D_LEVEL_2_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_3_QTY", "DISC_D_LEVEL_3_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_4_QTY", "DISC_D_LEVEL_4_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_5_QTY", "DISC_D_LEVEL_5_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_6_QTY", "DISC_D_LEVEL_6_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_7_QTY", "DISC_D_LEVEL_7_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_8_QTY", "DISC_D_LEVEL_8_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_9_QTY", "DISC_D_LEVEL_9_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_10_QTY", "DISC_D_LEVEL_10_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_1_RATE", "DISC_D_LEVEL_1_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_2_RATE", "DISC_D_LEVEL_2_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_3_RATE", "DISC_D_LEVEL_3_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_4_RATE", "DISC_D_LEVEL_4_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_5_RATE", "DISC_D_LEVEL_5_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_6_RATE", "DISC_D_LEVEL_6_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_7_RATE", "DISC_D_LEVEL_7_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_8_RATE", "DISC_D_LEVEL_8_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_9_RATE", "DISC_D_LEVEL_9_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_D_LEVEL_10_RATE", "DISC_D_LEVEL_10_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_1_QTY", "DISC_E_LEVEL_1_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_2_QTY", "DISC_E_LEVEL_2_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_3_QTY", "DISC_E_LEVEL_3_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_4_QTY", "DISC_E_LEVEL_4_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_5_QTY", "DISC_E_LEVEL_5_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_6_QTY", "DISC_E_LEVEL_6_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_7_QTY", "DISC_E_LEVEL_7_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_8_QTY", "DISC_E_LEVEL_8_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_9_QTY", "DISC_E_LEVEL_9_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_10_QTY", "DISC_E_LEVEL_10_QTY");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_1_RATE", "DISC_E_LEVEL_1_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_2_RATE", "DISC_E_LEVEL_2_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_3_RATE", "DISC_E_LEVEL_3_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_4_RATE", "DISC_E_LEVEL_4_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_5_RATE", "DISC_E_LEVEL_5_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_6_RATE", "DISC_E_LEVEL_6_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_7_RATE", "DISC_E_LEVEL_7_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_8_RATE", "DISC_E_LEVEL_8_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_9_RATE", "DISC_E_LEVEL_9_RATE");
		dataTableMapping.ColumnMappings.Add("DISC_E_LEVEL_10_RATE", "DISC_E_LEVEL_10_RATE");
		dataTableMapping.ColumnMappings.Add("PURCHASE_NOMINAL_CODE", "PURCHASE_NOMINAL_CODE");
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
		_commandCollection[0].CommandText = "SELECT     STOCK.*\r\nFROM         STOCK";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Products.ProductsListDataTable dataTable)
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
	public virtual Products.ProductsListDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Products.ProductsListDataTable productsListDataTable = new Products.ProductsListDataTable();
		Adapter.Fill(productsListDataTable);
		return productsListDataTable;
	}
}
