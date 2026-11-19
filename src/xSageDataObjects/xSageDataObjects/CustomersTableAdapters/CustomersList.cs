using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using xSageDataObjects.My;

namespace xSageDataObjects.CustomersTableAdapters;

/// <summary>
/// Represents the connection and commands used to retrieve and save data.
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class CustomersList : Component
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
	public CustomersList()
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
		dataTableMapping.DataSetTable = "CustomersList";
		dataTableMapping.ColumnMappings.Add("ACCOUNT_REF", "ACCOUNT_REF");
		dataTableMapping.ColumnMappings.Add("NAME", "NAME");
		dataTableMapping.ColumnMappings.Add("ADDRESS_1", "ADDRESS_1");
		dataTableMapping.ColumnMappings.Add("ADDRESS_2", "ADDRESS_2");
		dataTableMapping.ColumnMappings.Add("ADDRESS_3", "ADDRESS_3");
		dataTableMapping.ColumnMappings.Add("ADDRESS_4", "ADDRESS_4");
		dataTableMapping.ColumnMappings.Add("ADDRESS_5", "ADDRESS_5");
		dataTableMapping.ColumnMappings.Add("C_ADDRESS_1", "C_ADDRESS_1");
		dataTableMapping.ColumnMappings.Add("C_ADDRESS_2", "C_ADDRESS_2");
		dataTableMapping.ColumnMappings.Add("C_ADDRESS_3", "C_ADDRESS_3");
		dataTableMapping.ColumnMappings.Add("C_ADDRESS_4", "C_ADDRESS_4");
		dataTableMapping.ColumnMappings.Add("C_ADDRESS_5", "C_ADDRESS_5");
		dataTableMapping.ColumnMappings.Add("CONTACT_NAME", "CONTACT_NAME");
		dataTableMapping.ColumnMappings.Add("TELEPHONE", "TELEPHONE");
		dataTableMapping.ColumnMappings.Add("TELEPHONE_2", "TELEPHONE_2");
		dataTableMapping.ColumnMappings.Add("FAX", "FAX");
		dataTableMapping.ColumnMappings.Add("E_MAIL", "E_MAIL");
		dataTableMapping.ColumnMappings.Add("WEB_ADDRESS", "WEB_ADDRESS");
		dataTableMapping.ColumnMappings.Add("TRADE_CONTACT", "TRADE_CONTACT");
		dataTableMapping.ColumnMappings.Add("DEL_NAME", "DEL_NAME");
		dataTableMapping.ColumnMappings.Add("DEL_ADDRESS_1", "DEL_ADDRESS_1");
		dataTableMapping.ColumnMappings.Add("DEL_ADDRESS_2", "DEL_ADDRESS_2");
		dataTableMapping.ColumnMappings.Add("DEL_ADDRESS_3", "DEL_ADDRESS_3");
		dataTableMapping.ColumnMappings.Add("DEL_ADDRESS_4", "DEL_ADDRESS_4");
		dataTableMapping.ColumnMappings.Add("DEL_ADDRESS_5", "DEL_ADDRESS_5");
		dataTableMapping.ColumnMappings.Add("DEL_CONTACT_NAME", "DEL_CONTACT_NAME");
		dataTableMapping.ColumnMappings.Add("DEL_TELEPHONE", "DEL_TELEPHONE");
		dataTableMapping.ColumnMappings.Add("DEL_FAX", "DEL_FAX");
		dataTableMapping.ColumnMappings.Add("ANALYSIS_1", "ANALYSIS_1");
		dataTableMapping.ColumnMappings.Add("ANALYSIS_2", "ANALYSIS_2");
		dataTableMapping.ColumnMappings.Add("ANALYSIS_3", "ANALYSIS_3");
		dataTableMapping.ColumnMappings.Add("DEPT_NUMBER", "DEPT_NUMBER");
		dataTableMapping.ColumnMappings.Add("DEPT_NAME", "DEPT_NAME");
		dataTableMapping.ColumnMappings.Add("STATUS_NUMBER", "STATUS_NUMBER");
		dataTableMapping.ColumnMappings.Add("STATUS_TEXT", "STATUS_TEXT");
		dataTableMapping.ColumnMappings.Add("DEF_TAX_CODE", "DEF_TAX_CODE");
		dataTableMapping.ColumnMappings.Add("DEF_NOM_CODE", "DEF_NOM_CODE");
		dataTableMapping.ColumnMappings.Add("VAT_REG_NUMBER", "VAT_REG_NUMBER");
		dataTableMapping.ColumnMappings.Add("CURRENCY", "CURRENCY");
		dataTableMapping.ColumnMappings.Add("COUNTRY_CODE", "COUNTRY_CODE");
		dataTableMapping.ColumnMappings.Add("DISCOUNT_TYPE", "DISCOUNT_TYPE");
		dataTableMapping.ColumnMappings.Add("DISCOUNT_RATE", "DISCOUNT_RATE");
		dataTableMapping.ColumnMappings.Add("PRICING_REF", "PRICING_REF");
		dataTableMapping.ColumnMappings.Add("SETTLEMENT_DISC_RATE", "SETTLEMENT_DISC_RATE");
		dataTableMapping.ColumnMappings.Add("SETTLEMENT_DUE_DAYS", "SETTLEMENT_DUE_DAYS");
		dataTableMapping.ColumnMappings.Add("PAYMENT_DUE_DAYS", "PAYMENT_DUE_DAYS");
		dataTableMapping.ColumnMappings.Add("CREDIT_LIMIT", "CREDIT_LIMIT");
		dataTableMapping.ColumnMappings.Add("ACCOUNT_ON_HOLD", "ACCOUNT_ON_HOLD");
		dataTableMapping.ColumnMappings.Add("TERMS", "TERMS");
		dataTableMapping.ColumnMappings.Add("RESTRICT_MAIL", "RESTRICT_MAIL");
		dataTableMapping.ColumnMappings.Add("TERMS_AGREED", "TERMS_AGREED");
		dataTableMapping.ColumnMappings.Add("DATE_ACCOUNT_OPENED", "DATE_ACCOUNT_OPENED");
		dataTableMapping.ColumnMappings.Add("DATE_NEXT_CREDIT", "DATE_NEXT_CREDIT");
		dataTableMapping.ColumnMappings.Add("DATE_LAST_CREDIT", "DATE_LAST_CREDIT");
		dataTableMapping.ColumnMappings.Add("CREDIT_POSITION", "CREDIT_POSITION");
		dataTableMapping.ColumnMappings.Add("CREDIT_POS_CODE", "CREDIT_POS_CODE");
		dataTableMapping.ColumnMappings.Add("CAN_CHARGE", "CAN_CHARGE");
		dataTableMapping.ColumnMappings.Add("USE_BACS", "USE_BACS");
		dataTableMapping.ColumnMappings.Add("BACS_REF", "BACS_REF");
		dataTableMapping.ColumnMappings.Add("BUREAU_CODE", "BUREAU_CODE");
		dataTableMapping.ColumnMappings.Add("CREDIT_REF", "CREDIT_REF");
		dataTableMapping.ColumnMappings.Add("DATE_CREDIT_APPLIED", "DATE_CREDIT_APPLIED");
		dataTableMapping.ColumnMappings.Add("DATE_CREDIT_RECEIVED", "DATE_CREDIT_RECEIVED");
		dataTableMapping.ColumnMappings.Add("OVERRIDE_TAX_CODE", "OVERRIDE_TAX_CODE");
		dataTableMapping.ColumnMappings.Add("LAST_PAYMENT_DATE", "LAST_PAYMENT_DATE");
		dataTableMapping.ColumnMappings.Add("FIRST_INV_DATE", "FIRST_INV_DATE");
		dataTableMapping.ColumnMappings.Add("AVERAGE_PAY_DAYS", "AVERAGE_PAY_DAYS");
		dataTableMapping.ColumnMappings.Add("LAST_INV_DATE", "LAST_INV_DATE");
		dataTableMapping.ColumnMappings.Add("BALANCE", "BALANCE");
		dataTableMapping.ColumnMappings.Add("TURNOVER_MTD", "TURNOVER_MTD");
		dataTableMapping.ColumnMappings.Add("TURNOVER_YTD", "TURNOVER_YTD");
		dataTableMapping.ColumnMappings.Add("PRIOR_YEAR", "PRIOR_YEAR");
		dataTableMapping.ColumnMappings.Add("BANK_NAME", "BANK_NAME");
		dataTableMapping.ColumnMappings.Add("BANK_ADDRESS_1", "BANK_ADDRESS_1");
		dataTableMapping.ColumnMappings.Add("BANK_ADDRESS_2", "BANK_ADDRESS_2");
		dataTableMapping.ColumnMappings.Add("BANK_ADDRESS_3", "BANK_ADDRESS_3");
		dataTableMapping.ColumnMappings.Add("BANK_ADDRESS_4", "BANK_ADDRESS_4");
		dataTableMapping.ColumnMappings.Add("BANK_ADDRESS_5", "BANK_ADDRESS_5");
		dataTableMapping.ColumnMappings.Add("BANK_SORT_CODE", "BANK_SORT_CODE");
		dataTableMapping.ColumnMappings.Add("BANK_ACCOUNT_NAME", "BANK_ACCOUNT_NAME");
		dataTableMapping.ColumnMappings.Add("BANK_ACCOUNT_NUMBER", "BANK_ACCOUNT_NUMBER");
		dataTableMapping.ColumnMappings.Add("BANK_IBAN", "BANK_IBAN");
		dataTableMapping.ColumnMappings.Add("BANK_BIC", "BANK_BIC");
		dataTableMapping.ColumnMappings.Add("BANK_ROLLNUMBER", "BANK_ROLLNUMBER");
		dataTableMapping.ColumnMappings.Add("BANK_ADDITIONALREF1", "BANK_ADDITIONALREF1");
		dataTableMapping.ColumnMappings.Add("BANK_ADDITIONALREF2", "BANK_ADDITIONALREF2");
		dataTableMapping.ColumnMappings.Add("BANK_ADDITIONALREF3", "BANK_ADDITIONALREF3");
		dataTableMapping.ColumnMappings.Add("DEFAULT_FUND_ID", "DEFAULT_FUND_ID");
		dataTableMapping.ColumnMappings.Add("GIFT_AID", "GIFT_AID");
		dataTableMapping.ColumnMappings.Add("INVOICE_BF", "INVOICE_BF");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH1", "INVOICE_MTH1");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH2", "INVOICE_MTH2");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH3", "INVOICE_MTH3");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH4", "INVOICE_MTH4");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH5", "INVOICE_MTH5");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH6", "INVOICE_MTH6");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH7", "INVOICE_MTH7");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH8", "INVOICE_MTH8");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH9", "INVOICE_MTH9");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH10", "INVOICE_MTH10");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH11", "INVOICE_MTH11");
		dataTableMapping.ColumnMappings.Add("INVOICE_MTH12", "INVOICE_MTH12");
		dataTableMapping.ColumnMappings.Add("INVOICE_CF", "INVOICE_CF");
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
		dataTableMapping.ColumnMappings.Add("CREDIT_CF", "CREDIT_CF");
		dataTableMapping.ColumnMappings.Add("PAYMENT_BF", "PAYMENT_BF");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH1", "PAYMENT_MTH1");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH2", "PAYMENT_MTH2");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH3", "PAYMENT_MTH3");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH4", "PAYMENT_MTH4");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH5", "PAYMENT_MTH5");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH6", "PAYMENT_MTH6");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH7", "PAYMENT_MTH7");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH8", "PAYMENT_MTH8");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH9", "PAYMENT_MTH9");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH10", "PAYMENT_MTH10");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH11", "PAYMENT_MTH11");
		dataTableMapping.ColumnMappings.Add("PAYMENT_MTH12", "PAYMENT_MTH12");
		dataTableMapping.ColumnMappings.Add("PAYMENT_CF", "PAYMENT_CF");
		dataTableMapping.ColumnMappings.Add("DUNS_NUMBER", "DUNS_NUMBER");
		dataTableMapping.ColumnMappings.Add("PRIORITY", "PRIORITY");
		dataTableMapping.ColumnMappings.Add("PROMISED_PAYMENT", "PROMISED_PAYMENT");
		dataTableMapping.ColumnMappings.Add("PROMISED_PAYMENT_DATE", "PROMISED_PAYMENT_DATE");
		dataTableMapping.ColumnMappings.Add("REPORT_PASSWORD", "REPORT_PASSWORD");
		dataTableMapping.ColumnMappings.Add("LETTERS_VIA_EMAIL", "LETTERS_VIA_EMAIL");
		dataTableMapping.ColumnMappings.Add("PAYMENT_METHOD_ID", "PAYMENT_METHOD_ID");
		dataTableMapping.ColumnMappings.Add("RECORD_CREATE_DATE", "RECORD_CREATE_DATE");
		dataTableMapping.ColumnMappings.Add("RECORD_MODIFY_DATE", "RECORD_MODIFY_DATE");
		dataTableMapping.ColumnMappings.Add("RECORD_DELETED", "RECORD_DELETED");
		dataTableMapping.ColumnMappings.Add("EU_MEMBER", "EU_MEMBER");
		dataTableMapping.ColumnMappings.Add("COUNTRY_NAME", "COUNTRY_NAME");
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
		_commandCollection[0].CommandText = "SELECT     SALES_LEDGER.ACCOUNT_REF, SALES_LEDGER.NAME, SALES_LEDGER.ADDRESS_1, SALES_LEDGER.ADDRESS_2, SALES_LEDGER.ADDRESS_3, \r\n                      SALES_LEDGER.ADDRESS_4, SALES_LEDGER.ADDRESS_5, SALES_LEDGER.C_ADDRESS_1, SALES_LEDGER.C_ADDRESS_2, \r\n                      SALES_LEDGER.C_ADDRESS_3, SALES_LEDGER.C_ADDRESS_4, SALES_LEDGER.C_ADDRESS_5, SALES_LEDGER.CONTACT_NAME, \r\n                      SALES_LEDGER.TELEPHONE, SALES_LEDGER.TELEPHONE_2, SALES_LEDGER.FAX, SALES_LEDGER.E_MAIL, SALES_LEDGER.WEB_ADDRESS, \r\n                      SALES_LEDGER.TRADE_CONTACT, SALES_LEDGER.DEL_NAME, SALES_LEDGER.DEL_ADDRESS_1, SALES_LEDGER.DEL_ADDRESS_2, \r\n                      SALES_LEDGER.DEL_ADDRESS_3, SALES_LEDGER.DEL_ADDRESS_4, SALES_LEDGER.DEL_ADDRESS_5, SALES_LEDGER.DEL_CONTACT_NAME, \r\n                      SALES_LEDGER.DEL_TELEPHONE, SALES_LEDGER.DEL_FAX, SALES_LEDGER.ANALYSIS_1, SALES_LEDGER.ANALYSIS_2, \r\n                      SALES_LEDGER.ANALYSIS_3, SALES_LEDGER.DEPT_NUMBER, SALES_LEDGER.DEPT_NAME, SALES_LEDGER.STATUS_NUMBER, \r\n                      SALES_LEDGER.STATUS_TEXT, SALES_LEDGER.DEF_TAX_CODE, SALES_LEDGER.DEF_NOM_CODE, SALES_LEDGER.VAT_REG_NUMBER, \r\n                      SALES_LEDGER.CURRENCY, SALES_LEDGER.COUNTRY_CODE, SALES_LEDGER.DISCOUNT_TYPE, SALES_LEDGER.DISCOUNT_RATE, \r\n                      SALES_LEDGER.PRICING_REF, SALES_LEDGER.SETTLEMENT_DISC_RATE, SALES_LEDGER.SETTLEMENT_DUE_DAYS, \r\n                      SALES_LEDGER.PAYMENT_DUE_DAYS, SALES_LEDGER.CREDIT_LIMIT, SALES_LEDGER.ACCOUNT_ON_HOLD, SALES_LEDGER.TERMS, \r\n                      SALES_LEDGER.RESTRICT_MAIL, SALES_LEDGER.TERMS_AGREED, SALES_LEDGER.DATE_ACCOUNT_OPENED, \r\n                      SALES_LEDGER.DATE_NEXT_CREDIT, SALES_LEDGER.DATE_LAST_CREDIT, SALES_LEDGER.CREDIT_POSITION, \r\n                      SALES_LEDGER.CREDIT_POS_CODE, SALES_LEDGER.CAN_CHARGE, SALES_LEDGER.USE_BACS, SALES_LEDGER.BACS_REF, \r\n                      SALES_LEDGER.BUREAU_CODE, SALES_LEDGER.CREDIT_REF, SALES_LEDGER.DATE_CREDIT_APPLIED, \r\n                      SALES_LEDGER.DATE_CREDIT_RECEIVED, SALES_LEDGER.OVERRIDE_TAX_CODE, SALES_LEDGER.LAST_PAYMENT_DATE, \r\n                      SALES_LEDGER.FIRST_INV_DATE, SALES_LEDGER.AVERAGE_PAY_DAYS, SALES_LEDGER.LAST_INV_DATE, SALES_LEDGER.BALANCE, \r\n                      SALES_LEDGER.TURNOVER_MTD, SALES_LEDGER.TURNOVER_YTD, SALES_LEDGER.PRIOR_YEAR, SALES_LEDGER.BANK_NAME, \r\n                      SALES_LEDGER.BANK_ADDRESS_1, SALES_LEDGER.BANK_ADDRESS_2, SALES_LEDGER.BANK_ADDRESS_3, SALES_LEDGER.BANK_ADDRESS_4, \r\n                      SALES_LEDGER.BANK_ADDRESS_5, SALES_LEDGER.BANK_SORT_CODE, SALES_LEDGER.BANK_ACCOUNT_NAME, \r\n                      SALES_LEDGER.BANK_ACCOUNT_NUMBER, SALES_LEDGER.BANK_IBAN, SALES_LEDGER.BANK_BIC, SALES_LEDGER.BANK_ROLLNUMBER, \r\n                      SALES_LEDGER.BANK_ADDITIONALREF1, SALES_LEDGER.BANK_ADDITIONALREF2, SALES_LEDGER.BANK_ADDITIONALREF3, \r\n                      SALES_LEDGER.DEFAULT_FUND_ID, SALES_LEDGER.GIFT_AID, SALES_LEDGER.INVOICE_BF, SALES_LEDGER.INVOICE_MTH1, \r\n                      SALES_LEDGER.INVOICE_MTH2, SALES_LEDGER.INVOICE_MTH3, SALES_LEDGER.INVOICE_MTH4, SALES_LEDGER.INVOICE_MTH5, \r\n                      SALES_LEDGER.INVOICE_MTH6, SALES_LEDGER.INVOICE_MTH7, SALES_LEDGER.INVOICE_MTH8, SALES_LEDGER.INVOICE_MTH9, \r\n                      SALES_LEDGER.INVOICE_MTH10, SALES_LEDGER.INVOICE_MTH11, SALES_LEDGER.INVOICE_MTH12, SALES_LEDGER.INVOICE_CF, \r\n                      SALES_LEDGER.CREDIT_BF, SALES_LEDGER.CREDIT_MTH1, SALES_LEDGER.CREDIT_MTH2, SALES_LEDGER.CREDIT_MTH3, \r\n                      SALES_LEDGER.CREDIT_MTH4, SALES_LEDGER.CREDIT_MTH5, SALES_LEDGER.CREDIT_MTH6, SALES_LEDGER.CREDIT_MTH7, \r\n                      SALES_LEDGER.CREDIT_MTH8, SALES_LEDGER.CREDIT_MTH9, SALES_LEDGER.CREDIT_MTH10, SALES_LEDGER.CREDIT_MTH11, \r\n                      SALES_LEDGER.CREDIT_MTH12, SALES_LEDGER.CREDIT_CF, SALES_LEDGER.PAYMENT_BF, SALES_LEDGER.PAYMENT_MTH1, \r\n                      SALES_LEDGER.PAYMENT_MTH2, SALES_LEDGER.PAYMENT_MTH3, SALES_LEDGER.PAYMENT_MTH4, SALES_LEDGER.PAYMENT_MTH5, \r\n                      SALES_LEDGER.PAYMENT_MTH6, SALES_LEDGER.PAYMENT_MTH7, SALES_LEDGER.PAYMENT_MTH8, SALES_LEDGER.PAYMENT_MTH9, \r\n                      SALES_LEDGER.PAYMENT_MTH10, SALES_LEDGER.PAYMENT_MTH11, SALES_LEDGER.PAYMENT_MTH12, SALES_LEDGER.PAYMENT_CF, \r\n                      SALES_LEDGER.DUNS_NUMBER, SALES_LEDGER.PRIORITY, SALES_LEDGER.PROMISED_PAYMENT, \r\n                      SALES_LEDGER.PROMISED_PAYMENT_DATE, SALES_LEDGER.REPORT_PASSWORD, SALES_LEDGER.LETTERS_VIA_EMAIL, \r\n                      SALES_LEDGER.PAYMENT_METHOD_ID, SALES_LEDGER.RECORD_CREATE_DATE, SALES_LEDGER.RECORD_MODIFY_DATE, \r\n                      SALES_LEDGER.RECORD_DELETED, COUNTRY_CODE.EU_MEMBER, COUNTRY_CODE.NAME AS COUNTRY_NAME\r\nFROM         SALES_LEDGER, COUNTRY_CODE\r\nWHERE     SALES_LEDGER.COUNTRY_CODE = COUNTRY_CODE.CODE";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(Customers.CustomersListDataTable dataTable)
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
	public virtual Customers.CustomersListDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		Customers.CustomersListDataTable customersListDataTable = new Customers.CustomersListDataTable();
		Adapter.Fill(customersListDataTable);
		return customersListDataTable;
	}
}
