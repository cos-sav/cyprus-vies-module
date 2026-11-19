using System;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

public class SageServicesBase
{
	public enum InvoiceNumberValidationResult
	{
		InvoiceNumberOK,
		InvoiceNumberInvalid,
		InvoiceNumberExists
	}

	public enum InvoiceAccRefValidationResult
	{
		InvoiceAccRefOK,
		InvoiceAccRefInvalid,
		InvoiceAccRefNotFound
	}

	public enum InvoiceItemNominalCodeValidationResult
	{
		NominalCodeOk,
		NominalCodeInvalid,
		NominalCodeNotFound
	}

	public enum InvoiceItemTaxCodeValidationResult
	{
		TaxCodeOk,
		TaxCodeInvalid,
		TaxCodeNotFound
	}

	public static InvoiceNumberValidationResult InvoiceNumberValid(string invoiceNumber, SageController controller)
	{
		if (string.IsNullOrEmpty(invoiceNumber) || !Versioned.IsNumeric(invoiceNumber) || invoiceNumber.Length > 7)
		{
			return InvoiceNumberValidationResult.InvoiceNumberInvalid;
		}
		if (!int.TryParse(invoiceNumber, out var result) || result < 1 || result > 9999999)
		{
			return InvoiceNumberValidationResult.InvoiceNumberInvalid;
		}
		return InvoiceNumberValid(result, controller);
	}

	public static InvoiceNumberValidationResult InvoiceNumberValid(int invoiceNumber, SageController controller)
	{
		if (controller.InvoiceExists(invoiceNumber))
		{
			return InvoiceNumberValidationResult.InvoiceNumberExists;
		}
		return InvoiceNumberValidationResult.InvoiceNumberOK;
	}

	public static InvoiceAccRefValidationResult InvoiceAccRefValid(string accRef, Customers.CustomersListDataTable customers)
	{
		if (string.IsNullOrEmpty(accRef) || accRef.Length > 8)
		{
			return InvoiceAccRefValidationResult.InvoiceAccRefInvalid;
		}
		if (!CustomerExists(accRef, customers))
		{
			return InvoiceAccRefValidationResult.InvoiceAccRefNotFound;
		}
		return InvoiceAccRefValidationResult.InvoiceAccRefOK;
	}

	public static bool InvoiceTitleValid(string invoiceTitle)
	{
		if (!string.IsNullOrEmpty(invoiceTitle))
		{
			return invoiceTitle.Length <= 60;
		}
		return true;
	}

	public static InvoiceItemNominalCodeValidationResult InvoiceItemNominalCodeValid(string nominalCode, Nominal.NominalAccountsListDataTable nominalCodes)
	{
		if (string.IsNullOrEmpty(nominalCode) || !Versioned.IsNumeric(nominalCode))
		{
			return InvoiceItemNominalCodeValidationResult.NominalCodeInvalid;
		}
		if (!NominalCodeExists(nominalCode, nominalCodes))
		{
			return InvoiceItemNominalCodeValidationResult.NominalCodeNotFound;
		}
		return InvoiceItemNominalCodeValidationResult.NominalCodeOk;
	}

	public static InvoiceItemTaxCodeValidationResult InvoiceItemTaxCodeValid(string taxCode, TaxCodes.TaxCodesListDataTable taxCodes)
	{
		if (string.IsNullOrEmpty(taxCode) || !Versioned.IsNumeric(taxCode.TrimStart('T')))
		{
			return InvoiceItemTaxCodeValidationResult.TaxCodeInvalid;
		}
		if (!TaxCodeExists(taxCode, taxCodes))
		{
			return InvoiceItemTaxCodeValidationResult.TaxCodeNotFound;
		}
		return InvoiceItemTaxCodeValidationResult.TaxCodeOk;
	}

	public static bool InvoiceItemAmountValid(decimal amount)
	{
		if (decimal.Compare(amount, Math.Round(amount, 2, MidpointRounding.AwayFromZero)) == 0)
		{
			return decimal.Compare(amount, 0m) > 0;
		}
		return false;
	}

	public static bool CustomerExists(string AccRef, Customers.CustomersListDataTable Customers)
	{
		foreach (Customers.CustomersListRow Customer in Customers)
		{
			if (Operators.CompareString(Customer.ACCOUNT_REF, AccRef, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool TaxCodeExists(string TaxCode, TaxCodes.TaxCodesListDataTable TaxCodes)
	{
		foreach (TaxCodes.TaxCodesListRow TaxCode2 in TaxCodes)
		{
			if (Operators.CompareString(TaxCode2.TAX_CODE, TaxCode, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool NominalCodeExists(string NominalCode, Nominal.NominalAccountsListDataTable NominalCodes)
	{
		foreach (Nominal.NominalAccountsListRow NominalCode2 in NominalCodes)
		{
			if (Operators.CompareString(NominalCode2.ACCOUNT_REF, NominalCode, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}
}
