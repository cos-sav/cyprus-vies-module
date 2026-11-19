using System;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

public class InvoiceTransaction
{
	private string _TRAN_NUMBER;

	private string _TYPE;

	private string _TRAN_DATE;

	private string _ACCOUNT_REF;

	private string _NOMINAL_CODE;

	private string _BANK_CODE;

	private string _DELETED_FLAG;

	private string _SPLIT_NUMBER;

	private string _HEADER_NUMBER;

	private string _DATE_ENTERED;

	private string _RECORD_CREATE_DATE;

	private string _RECORD_MODIFY_DATE;

	private string _RECORD_DELETED;

	private string _DETAILS;

	private string _EXTRA_REF;

	private string _VAT_FLAG;

	private string _VAT_RECONCILED_DATE;

	private string _DEPT_NUMBER;

	private string _DEPT_NAME;

	private string _INV_REF;

	private string _USER_NAME;

	public string TRAN_NUMBER => _TRAN_NUMBER;

	public string TYPE => _TYPE;

	public string TRAN_DATE => _TRAN_DATE;

	public string ACCOUNT_REF => _ACCOUNT_REF;

	public string NOMINAL_CODE => _NOMINAL_CODE;

	public string BANK_CODE => _BANK_CODE;

	public string DELETED_FLAG => _DELETED_FLAG;

	public string SPLIT_NUMBER => _SPLIT_NUMBER;

	public string HEADER_NUMBER => _HEADER_NUMBER;

	public string DATE_ENTERED => _DATE_ENTERED;

	public string RECORD_CREATE_DATE => _RECORD_CREATE_DATE;

	public string RECORD_MODIFY_DATE => _RECORD_MODIFY_DATE;

	public string RECORD_DELETED => _RECORD_DELETED;

	public string DETAILS
	{
		get
		{
			return _DETAILS;
		}
		set
		{
			_DETAILS = value;
		}
	}

	public string EXTRA_REF
	{
		get
		{
			return _EXTRA_REF;
		}
		set
		{
			_EXTRA_REF = value;
		}
	}

	public string VAT_FLAG
	{
		get
		{
			return _VAT_FLAG;
		}
		set
		{
			_VAT_FLAG = value;
		}
	}

	public string VAT_RECONCILED_DATE
	{
		get
		{
			return _VAT_RECONCILED_DATE;
		}
		set
		{
			_VAT_RECONCILED_DATE = value;
		}
	}

	public string DEPT_NUMBER
	{
		get
		{
			return _DEPT_NUMBER;
		}
		set
		{
			_DEPT_NUMBER = value;
		}
	}

	public string DEPT_NAME
	{
		get
		{
			return _DEPT_NAME;
		}
		set
		{
			_DEPT_NAME = value;
		}
	}

	public string INV_REF
	{
		get
		{
			return _INV_REF;
		}
		set
		{
			_INV_REF = value;
		}
	}

	public string USER_NAME
	{
		get
		{
			return _USER_NAME;
		}
		set
		{
			_USER_NAME = value;
		}
	}

	public InvoiceTransaction()
	{
	}

	public InvoiceTransaction(Transactions.AUDIT_SPLITRow Row)
		: this()
	{
		_TRAN_NUMBER = Conversions.ToString(Row.TRAN_NUMBER);
		_ACCOUNT_REF = Row.ACCOUNT_REF;
		_BANK_CODE = Row.BANK_CODE;
		_DATE_ENTERED = Conversions.ToString(Row.DATE_ENTERED);
		_DELETED_FLAG = Conversions.ToString((int)Row.DELETED_FLAG);
		_DEPT_NAME = Row.DEPT_NAME;
		_DEPT_NUMBER = Conversions.ToString((int)Row.DEPT_NUMBER);
		_DETAILS = Row.DETAILS;
		_EXTRA_REF = Row.EXTRA_REF;
		_HEADER_NUMBER = Conversions.ToString(Row.HEADER_NUMBER);
		_INV_REF = Row.INV_REF;
		_NOMINAL_CODE = Row.NOMINAL_CODE;
		_RECORD_CREATE_DATE = Conversions.ToString(Row.RECORD_CREATE_DATE);
		_RECORD_DELETED = Conversions.ToString((int)Row.RECORD_DELETED);
		_RECORD_MODIFY_DATE = Conversions.ToString(Row.RECORD_MODIFY_DATE);
		_SPLIT_NUMBER = Conversions.ToString(Row.SPLIT_NUMBER);
		_TRAN_DATE = Conversions.ToString(Row._DATE);
		_TYPE = Row.TYPE;
		_USER_NAME = Row.USER_NAME;
		_VAT_FLAG = Row.VAT_FLAG;
		try
		{
			_VAT_RECONCILED_DATE = Conversions.ToString(Row.VAT_RECONCILED_DATE);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
