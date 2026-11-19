using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

public class CommonMethods
{
	/// <summary>
	/// Changes signs of values found in TAX_AMOUNT, NET_AMOUNT and GROSS_AMOUNT columns of the supplied table based on the type of each transaction.
	/// </summary>
	/// <remarks>
	/// The following transaction types recieve a Positive sign: SI, BR, BP, CR, CP, JC, JD, PI, VR, VP
	/// The following transaction types recieve a Negative sign: SC, PC
	/// </remarks>
	public static void FixTransactionSigns(ref VAT.TransactionSplitsDataTable Table)
	{
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataRow> list3 = new List<DataRow>();
		List<DataRow> list4 = new List<DataRow>();
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		bool flag = default(bool);
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			double tAX_AMOUNT = item.TAX_AMOUNT;
			double nET_AMOUNT = item.NET_AMOUNT;
			double gROSS_AMOUNT = item.GROSS_AMOUNT;
			switch (item.TYPE)
			{
			case "SI":
			case "BR":
			case "BP":
			case "CR":
			case "CP":
			case "JC":
			case "JD":
			case "PI":
			case "VR":
			case "VP":
				flag = true;
				break;
			case "SC":
			case "PC":
				flag = false;
				break;
			}
			if (flag)
			{
				item.NET_AMOUNT = Math.Abs(item.NET_AMOUNT);
				item.TAX_AMOUNT = Math.Abs(item.TAX_AMOUNT);
				item.GROSS_AMOUNT = Math.Abs(item.GROSS_AMOUNT);
			}
			else
			{
				item.NET_AMOUNT = 0.0 - Math.Abs(item.NET_AMOUNT);
				item.TAX_AMOUNT = 0.0 - Math.Abs(item.TAX_AMOUNT);
				item.GROSS_AMOUNT = 0.0 - Math.Abs(item.GROSS_AMOUNT);
			}
			double tAX_AMOUNT2 = item.TAX_AMOUNT;
			double nET_AMOUNT2 = item.NET_AMOUNT;
			double gROSS_AMOUNT2 = item.GROSS_AMOUNT;
			if (tAX_AMOUNT != tAX_AMOUNT2)
			{
				list.Add(item);
			}
			if (nET_AMOUNT != nET_AMOUNT2)
			{
				list2.Add(item);
			}
			if (gROSS_AMOUNT != gROSS_AMOUNT2)
			{
				list3.Add(item);
			}
			if (nET_AMOUNT != nET_AMOUNT2 && tAX_AMOUNT == tAX_AMOUNT2)
			{
				list4.Add(item);
			}
		}
		Dictionary<string, DataRow> dictionary = new Dictionary<string, DataRow>();
		Dictionary<string, DataRow> dictionary2 = new Dictionary<string, DataRow>();
		Dictionary<string, DataRow> dictionary3 = new Dictionary<string, DataRow>();
		foreach (VAT.TransactionSplitsRow item2 in list2)
		{
			if (!dictionary.ContainsKey(item2.TYPE))
			{
				dictionary.Add(item2.TYPE, item2);
			}
		}
		foreach (VAT.TransactionSplitsRow item3 in list)
		{
			if (!dictionary2.ContainsKey(item3.TYPE))
			{
				dictionary2.Add(item3.TYPE, item3);
			}
		}
		foreach (VAT.TransactionSplitsRow item4 in list3)
		{
			if (!dictionary3.ContainsKey(item4.TYPE))
			{
				dictionary3.Add(item4.TYPE, item4);
			}
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Table"></param>
	/// <remarks></remarks>
	public static void CalculateTaxValues(ref VAT.TransactionSplitsDataTable Table, OdbcConnection Connection)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		string salesTaxControlAccount = DataReader_VAT.GetSalesTaxControlAccount(Connection);
		string purchaseTaxControlAccount = DataReader_VAT.GetPurchaseTaxControlAccount(Connection);
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			if ((Operators.CompareString(item.TYPE, "JC", TextCompare: false) == 0) & (Operators.CompareString(item.NOMINAL_CODE, salesTaxControlAccount, TextCompare: false) == 0))
			{
				item.TAX_AMOUNT = item.NET_AMOUNT;
			}
			else if ((Operators.CompareString(item.TYPE, "JD", TextCompare: false) == 0) & (Operators.CompareString(item.NOMINAL_CODE, purchaseTaxControlAccount, TextCompare: false) == 0))
			{
				item.TAX_AMOUNT = item.NET_AMOUNT;
			}
			else if (item.RELATED_RATE != 0.0)
			{
				if (item.TAX_AMOUNT == 0.0)
				{
					item.TAX_AMOUNT = item.NET_AMOUNT * item.RELATED_RATE / 100.0;
				}
			}
			else if (item.TAX_AMOUNT == 0.0)
			{
				item.TAX_AMOUNT = item.NET_AMOUNT * item.TAX_RATE / 100.0;
			}
			item.TAX_AMOUNT = Math.Round(item.TAX_AMOUNT, 2, MidpointRounding.AwayFromZero);
		}
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Table"></param>
	/// <remarks></remarks>
	public static void SetBoxCode(ref VAT.TransactionSplitsDataTable Table, string BoxCode)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			item.BOX = BoxCode;
		}
	}

	public static void SetIsAdd(ref VAT.TransactionSplitsDataTable Table, bool IsAdd)
	{
		if (Table == null)
		{
			throw new ArgumentNullException("Table");
		}
		foreach (VAT.TransactionSplitsRow item in Table)
		{
			item.IsAdd = IsAdd;
		}
	}
}
