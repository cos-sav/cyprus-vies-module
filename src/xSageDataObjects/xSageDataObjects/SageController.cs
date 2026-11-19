using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

public class SageController
{
	private string _FilePath;

	private string _Username;

	private string _Password;

	private SdoVersion _SageVersion;

	private Engine _Engine;

	private string _LastError;

	public Engine Engine
	{
		get
		{
			return _Engine;
		}
		set
		{
			_Engine = value;
		}
	}

	public string FilePath => _FilePath;

	public string Username => _Username;

	public string Password => _Password;

	public SdoVersion SageVersion => _SageVersion;

	public string LastError => _LastError;

	public SageController(string FilePath, string Username, string Password, SdoVersion SageVersion)
	{
		if (string.IsNullOrEmpty(FilePath))
		{
			throw new ArgumentNullException("FilePath");
		}
		if (string.IsNullOrEmpty(Username))
		{
			throw new ArgumentNullException("Username");
		}
		if (SageVersion < SdoVersion.v10 || SageVersion > SdoVersion.v17)
		{
			throw new ArgumentOutOfRangeException("SageVersion");
		}
		if (Password == null)
		{
			Password = string.Empty;
		}
		_FilePath = FilePath;
		_Username = Username;
		_Password = Password;
		_SageVersion = SageVersion;
		_Engine = new Engine(_SageVersion);
	}

	public AllSageData GetAllSageData()
	{
		AllSageData allSageData = new AllSageData();
		try
		{
			Connect();
			allSageData.Customers = DataReader_Customers.GetCustomers_All(Engine.OdbcConnection);
			allSageData.TaxCodes = DataReader_TaxCodes.GetTaxCodes_Active(Engine.OdbcConnection);
			allSageData.NominalCodes = DataReader_NominalAccounts.GetNominalAccounts_All(Engine.OdbcConnection);
			return allSageData;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public Customers.CustomersListDataTable GetCustomersTable()
	{
		try
		{
			Connect();
			return DataReader_Customers.GetCustomers_All(Engine.OdbcConnection);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public TaxCodes.TaxCodesListDataTable GetTaxCodesTable()
	{
		try
		{
			Connect();
			return DataReader_TaxCodes.GetTaxCodes_All(Engine.OdbcConnection);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public Nominal.NominalAccountsListDataTable GetNominalCodes()
	{
		try
		{
			Connect();
			return DataReader_NominalAccounts.GetNominalAccounts_All(Engine.OdbcConnection);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public Departments.DEPARTMENTDataTable GetDepartments()
	{
		try
		{
			Connect();
			return DataReader_Departments.GetDepartments_All(Engine.OdbcConnection);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public DataReader_Departments.Department GetDepartment(int DepartmentNumber)
	{
		try
		{
			Connect();
			return DataReader_Departments.GetDepartments_ByNumber(Engine.OdbcConnection, DepartmentNumber);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public bool InvoiceExists(int InvoiceNumber)
	{
		string Out_LastError = string.Empty;
		Exception ex = null;
		try
		{
			Connect();
			Engine Engine = this.Engine;
			bool invoiceStatus_Exists = DataWriter_SalesInvoices.GetInvoiceStatus_Exists(ref Engine, InvoiceNumber, ref Out_LastError);
			this.Engine = Engine;
			return invoiceStatus_Exists;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			ex = ex2;
			throw;
		}
		finally
		{
			Disconnect();
			if (!string.IsNullOrEmpty(Out_LastError))
			{
				_LastError = Out_LastError;
				if (ex == null)
				{
					throw new Exception("Could not write to Sage, last error: " + Out_LastError);
				}
			}
		}
	}

	public bool InvoicePosted(int InvoiceNumber)
	{
		string Out_LastError = string.Empty;
		Exception ex = null;
		try
		{
			Connect();
			Engine Engine = this.Engine;
			bool invoiceStatus_Posted = DataWriter_SalesInvoices.GetInvoiceStatus_Posted(ref Engine, InvoiceNumber, ref Out_LastError);
			this.Engine = Engine;
			return invoiceStatus_Posted;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			ex = ex2;
			throw;
		}
		finally
		{
			Disconnect();
			if (!string.IsNullOrEmpty(Out_LastError))
			{
				_LastError = Out_LastError;
				if (ex == null)
				{
					throw new Exception("Could not write to Sage, last error: " + Out_LastError);
				}
			}
		}
	}

	public Transactions.AUDIT_SPLITDataTable GetInvoiceTransactions(string InvoiceNumber, string CustomerReference, string NominalCode, string TransactionDate, string TransactionType)
	{
		try
		{
			Connect();
			return DataReader_Transactions.GetTransactions_Filtered(Engine.OdbcConnection, TransactionDate, TransactionType, NominalCode, CustomerReference, InvoiceNumber);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public bool WriteAndPostInvoice(int InvoiceNumber, InvoiceHeader Header, List<InvoiceItem> Items, bool IsCredit = false)
	{
		string Out_LastError = string.Empty;
		Exception ex = null;
		try
		{
			Connect();
			Engine Engine = this.Engine;
			bool num = DataWriter_SalesInvoices.CreateInvoice(ref Engine, ref InvoiceNumber, Header, Items, ref Out_LastError, IsCredit);
			this.Engine = Engine;
			bool flag = num;
			if (!flag)
			{
				return flag;
			}
			Engine = this.Engine;
			bool result = DataWriter_SalesInvoices.PostInvoice(ref Engine, InvoiceNumber, ref Out_LastError, IsCredit);
			this.Engine = Engine;
			return result;
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			ex = ex2;
			throw;
		}
		finally
		{
			Disconnect();
			if (!string.IsNullOrEmpty(Out_LastError))
			{
				_LastError = Out_LastError;
				if (ex == null)
				{
					throw new Exception("Could not write to Sage, last error: " + Out_LastError);
				}
			}
		}
	}

	public bool UpdateTransaction(InvoiceTransaction Transaction)
	{
		try
		{
			Connect();
			Engine Engine = this.Engine;
			bool result = DataWriter_SalesInvoices.EditInvoiceTransaction(ref Engine, Transaction);
			this.Engine = Engine;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	public bool UpdateInvoiceItems(int InvoiceNumber, int DepartmentNumber)
	{
		try
		{
			Connect();
			Engine Engine = this.Engine;
			bool result = DataWriter_SalesInvoices.UpdateInvoiceItems(ref Engine, InvoiceNumber, DepartmentNumber);
			this.Engine = Engine;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
		finally
		{
			Disconnect();
		}
	}

	protected bool Connect()
	{
		if (!Engine.IsInitialized)
		{
			throw new Exception("Engine not initialized, can not connect");
		}
		if (!Engine.IsConnected)
		{
			string Out_LastError = string.Empty;
			if (!Engine.Connect(_FilePath, _Username, _Password, ref Out_LastError))
			{
				_LastError = Out_LastError;
				throw new Exception("Could not connect to Sage, last error: " + Out_LastError);
			}
		}
		bool result = default(bool);
		return result;
	}

	protected void Disconnect()
	{
		if (Engine.IsConnected)
		{
			Engine.Disconnect();
		}
	}
}
