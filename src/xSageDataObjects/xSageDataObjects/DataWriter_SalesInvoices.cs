using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

/// <summary>
///
/// </summary>
/// <remarks></remarks>
public class DataWriter_SalesInvoices
{
	/// <summary>
	///
	/// </summary>
	/// <param name="Out_SageInvoiceNumber">You should only use this value if the function returns True.</param>
	/// <param name="IsCredit">Set to true to post an SC transaction instead of an SI</param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool CreateInvoice(ref Engine Engine, InvoiceHeader InvoiceHeader, List<InvoiceItem> InvoiceItems, ref int Out_SageInvoiceNumber, ref string Out_LastError, bool IsCredit = false)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool flag;
		try
		{
			flag = false;
			Out_SageInvoiceNumber = 0;
			Out_LastError = "";
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoicePost" }, null, null, null));
			if (!IsCredit)
			{
				NewLateBinding.LateSet(objectValue, null, "Type", new object[1] { 261 }, null, null);
			}
			else
			{
				NewLateBinding.LateSet(objectValue, null, "Type", new object[1] { 265 }, null, null);
			}
			int InvoiceNumber = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "GetNextNumber", new object[0], null, null, null));
			flag = CreateInvoice(ref Engine, ref InvoiceNumber, InvoiceHeader, InvoiceItems, ref Out_LastError, IsCredit);
			if (flag)
			{
				Out_SageInvoiceNumber = InvoiceNumber;
			}
			else
			{
				Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
		}
		return flag;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <param name="IsCredit">Set to true to post an SC transaction instead of an SI</param>
	/// <remarks></remarks>
	public static bool CreateInvoice(ref Engine Engine, ref int InvoiceNumber, InvoiceHeader InvoiceHeader, List<InvoiceItem> InvoiceItems, ref string Out_LastError, bool IsCredit = false)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		if (GetInvoiceStatus_Exists(ref Engine, InvoiceNumber, ref Out_LastError))
		{
			throw new ArgumentException("Invoice with the specified number already exists in Sage.", "InvoiceNumber");
		}
		bool flag;
		try
		{
			flag = false;
			Out_LastError = "";
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoicePost" }, null, null, null));
			if (!IsCredit)
			{
				NewLateBinding.LateSet(objectValue, null, "Type", new object[1] { 261 }, null, null);
			}
			else
			{
				NewLateBinding.LateSet(objectValue, null, "Type", new object[1] { 265 }, null, null);
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[1] { InvoiceNumber }, null, null, OptimisticSet: false, RValueBase: true);
			InvoiceHeader invoiceHeader = InvoiceHeader;
			if (!IsCredit)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "INVOICE_TYPE_CODE" }, null, null, null), null, "Value", new object[1] { 0 }, null, null, OptimisticSet: false, RValueBase: true);
			}
			else
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "INVOICE_TYPE_CODE" }, null, null, null), null, "Value", new object[1] { 3 }, null, null, OptimisticSet: false, RValueBase: true);
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AccountRef.Substring(0, Math.Min(8, invoiceHeader.AccountRef.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "NAME" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AccountName.Substring(0, Math.Min(60, invoiceHeader.AccountName.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "INVOICE_DATE" }, null, null, null), null, "Value", new object[1] { invoiceHeader.InvoiceDate }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "NOTES_1" }, null, null, null), null, "Value", new object[1] { invoiceHeader.NotesText_1.Substring(0, Math.Min(60, invoiceHeader.NotesText_1.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "NOTES_2" }, null, null, null), null, "Value", new object[1] { invoiceHeader.NotesText_2.Substring(0, Math.Min(60, invoiceHeader.NotesText_2.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "NOTES_3" }, null, null, null), null, "Value", new object[1] { invoiceHeader.NotesText_3.Substring(0, Math.Min(60, invoiceHeader.NotesText_3.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ADDRESS_1" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AddressText_1.Substring(0, Math.Min(60, invoiceHeader.AddressText_1.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ADDRESS_2" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AddressText_2.Substring(0, Math.Min(60, invoiceHeader.AddressText_2.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ADDRESS_3" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AddressText_3.Substring(0, Math.Min(60, invoiceHeader.AddressText_3.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ADDRESS_4" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AddressText_4.Substring(0, Math.Min(60, invoiceHeader.AddressText_4.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "ADDRESS_5" }, null, null, null), null, "Value", new object[1] { invoiceHeader.AddressText_5.Substring(0, Math.Min(60, invoiceHeader.AddressText_5.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Header", new object[1] { "TAKEN_BY" }, null, null, null), null, "Value", new object[1] { invoiceHeader.TakenBy.Substring(0, Math.Min(60, invoiceHeader.TakenBy.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
			invoiceHeader = null;
			foreach (InvoiceItem InvoiceItem in InvoiceItems)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "StockRecord" }, null, null, null));
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[1] { InvoiceItem.ProductCode }, null, null, OptimisticSet: false, RValueBase: true);
				bool num = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, null, "Find", new object[1] { false }, null, null, null));
				if (num | (!num & ((Operators.CompareString(InvoiceItem.ProductCode, "S1", TextCompare: false) == 0) | (Operators.CompareString(InvoiceItem.ProductCode, "S2", TextCompare: false) == 0) | (Operators.CompareString(InvoiceItem.ProductCode, "S3", TextCompare: false) == 0) | (Operators.CompareString(InvoiceItem.ProductCode, "M", TextCompare: false) == 0))))
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Items", new object[0], null, null, null), null, "Add", new object[0], null, null, null));
					InvoiceItem invoiceItem = InvoiceItem;
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[1] { invoiceItem.ProductCode }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DESCRIPTION" }, null, null, null), null, "Value", new object[1] { invoiceItem.Description.Substring(0, Math.Min(60, invoiceItem.Description.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "COMMENT_1" }, null, null, null), null, "Value", new object[1] { invoiceItem.CommentText_1.Substring(0, Math.Min(60, invoiceItem.CommentText_1.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "COMMENT_2" }, null, null, null), null, "Value", new object[1] { invoiceItem.CommentText_2.Substring(0, Math.Min(60, invoiceItem.CommentText_2.Length)) }, null, null, OptimisticSet: false, RValueBase: true);
					if (Operators.CompareString(InvoiceItem.ProductCode, "M", TextCompare: false) != 0)
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "SERVICE_FLAG" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ITEM_TYPE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
					}
					else
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "SERVICE_FLAG" }, null, null, null), null, "Value", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
					}
					if (Operators.CompareString(InvoiceItem.ProductCode, "M", TextCompare: false) != 0)
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NOMINAL_CODE" }, null, null, null), null, "Value", new object[1] { invoiceItem.NominalCode }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DEPT_NUMBER" }, null, null, null), null, "Value", new object[1] { invoiceItem.Department }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "QTY_ORDER" }, null, null, null), null, "Value", new object[1] { invoiceItem.Quantity }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "UNIT_PRICE" }, null, null, null), null, "Value", new object[1] { invoiceItem.Price }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_CODE" }, null, null, null), null, "Value", new object[1] { invoiceItem.TaxCode }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_RATE" }, null, null, null), null, "Value", new object[1] { invoiceItem.TaxRate }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_AMOUNT" }, null, null, null), null, "Value", new object[1] { invoiceItem.TaxAmount }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DISCOUNT_AMOUNT" }, null, null, null), null, "Value", new object[1] { invoiceItem.DiscountAmount }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DISCOUNT_RATE" }, null, null, null), null, "Value", new object[1] { invoiceItem.DiscountRate }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NET_AMOUNT" }, null, null, null), null, "Value", new object[1] { invoiceItem.NetAmountAfterDiscount }, null, null, OptimisticSet: false, RValueBase: true);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "FULL_NET_AMOUNT" }, null, null, null), null, "Value", new object[1] { invoiceItem.NetAmountBeforeDiscount }, null, null, OptimisticSet: false, RValueBase: true);
					}
					invoiceItem = null;
					continue;
				}
				throw new ArgumentOutOfRangeException("InvoiceItem.ProductCode", "Specified product code does not exist in Sage.");
			}
			flag = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Update", new object[0], null, null, null));
			if (!flag)
			{
				Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
			object objectValue3 = null;
			object objectValue2 = null;
		}
		return flag;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool PostInvoice(ref Engine Engine, int InvoiceNumber, ref string Out_LastError, bool IsCredit = false)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool flag;
		try
		{
			flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			Out_LastError = "";
			if (GetInvoiceStatus_Exists(ref Engine, InvoiceNumber, ref Out_LastError))
			{
				flag = GetInvoiceStatus_Posted(ref Engine, InvoiceNumber, ref Out_LastError);
				if (!flag)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceRecord" }, null, null, null));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "SalesRecord" }, null, null, null));
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[1] { InvoiceNumber }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateCall(objectValue, null, "Find", new object[1] { false }, null, null, null, IgnoreReturn: true);
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
					if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, null, "Find", new object[1] { false }, null, null, null)))
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceItem" }, null, null, null));
						objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Link", new object[0], null, null, null));
						int num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue3, null, "Count", new object[0], null, null, null));
						if (num > 0)
						{
							NewLateBinding.LateCall(objectValue3, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "value", new object[0], null, null, null), "M", TextCompare: false))))
							{
								object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "TransactionPost" }, null, null, null));
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "DATE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_DATE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "POSTED_DATE" }, null, null, null), null, "Value", new object[1] { DateAndTime.Today }, null, null, OptimisticSet: false, RValueBase: true);
								if (!IsCredit)
								{
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "TYPE" }, null, null, null), null, "Value", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
								}
								else
								{
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "TYPE" }, null, null, null), null, "Value", new object[1] { 2 }, null, null, OptimisticSet: false, RValueBase: true);
								}
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "DETAILS" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DESCRIPTION" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "INV_REF" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
								checked
								{
									int num2 = num - 1;
									for (int i = 0; i <= num2; i++)
									{
										object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Items", new object[0], null, null, null), null, "Add", new object[0], null, null, null));
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TYPE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "TYPE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NOMINAL_CODE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NOMINAL_CODE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_CODE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_CODE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NET_AMOUNT" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "NET_AMOUNT" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_AMOUNT" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TAX_AMOUNT" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DATE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "DATE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										NewLateBinding.LateCall(objectValue3, null, "MoveNext", new object[0], null, null, null, IgnoreReturn: true);
									}
									object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "StockPost" }, null, null, null));
									object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "StockRecord" }, null, null, null));
									NewLateBinding.LateCall(objectValue3, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
									int num3 = num - 1;
									for (int j = 0; j <= num3; j++)
									{
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
										bool flag5 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue7, null, "Find", new object[1] { false }, null, null, null));
										if (Conversions.ToBoolean(Operators.OrObject(flag5, Operators.AndObject(!flag5, Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null), "S1", TextCompare: false)))))
										{
											if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ITEM_TYPE" }, null, null, null), null, "Value", new object[0], null, null, null), 0, TextCompare: false))
											{
												flag4 = true;
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue6, null, "Header", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
												object objectValue8 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue6, null, "Items", new object[0], null, null, null), null, "Add", new object[0], null, null, null));
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue6, null, "Header", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DATE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Header", new object[1] { "POSTED_DATE" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "TYPE" }, null, null, null), null, "Value", new object[1] { 4 }, null, null, OptimisticSet: false, RValueBase: true);
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "QUANTITY" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "QTY_ORDER" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "REFERENCE" }, null, null, null), null, "Value", new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
												NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DETAILS" }, null, null, null), null, "Value", new object[1] { "" }, null, null, OptimisticSet: false, RValueBase: true);
											}
										}
										else if (Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null), "S2", TextCompare: false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null), "S3", TextCompare: false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null), "M", TextCompare: false)))))
										{
											Out_LastError = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Product ", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "STOCK_CODE" }, null, null, null), null, "Value", new object[0], null, null, null)), " not found."));
											return false;
										}
										NewLateBinding.LateCall(objectValue3, null, "MoveNext", new object[0], null, null, null, IgnoreReturn: true);
									}
									flag2 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue4, null, "Update", new object[0], null, null, null));
									if (flag4)
									{
										flag3 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue6, null, "Update", new object[0], null, null, null));
									}
								}
								if (flag2 && flag3 == flag4)
								{
									NewLateBinding.LateCall(objectValue, null, "Edit", new object[0], null, null, null, IgnoreReturn: true);
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "POSTED_CODE" }, null, null, null), null, "Value", new object[1] { 1 }, null, null, OptimisticSet: false, RValueBase: true);
									flag = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Update", new object[0], null, null, null));
									if (!flag)
									{
										Out_LastError = "Failed to post Invoice Record " + Engine.LastErrorCode + " : " + Engine.LastErrorText;
									}
								}
								else
								{
									Out_LastError = "Failed to post Invoice/Stock : " + Conversions.ToString(flag2) + "/" + Conversions.ToString(flag3) + Engine.LastErrorCode + " : " + Engine.LastErrorText;
								}
							}
						}
					}
					else
					{
						Out_LastError = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Customer ", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "ACCOUNT_REF" }, null, null, null), null, "Value", new object[0], null, null, null)), " not found."));
					}
				}
			}
			else
			{
				Out_LastError = "Invoice " + Conversions.ToString(InvoiceNumber) + " not found.";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue2 = null;
			object objectValue = null;
			object objectValue3 = null;
			object objectValue4 = null;
			object objectValue5 = null;
			object objectValue8 = null;
			object objectValue6 = null;
		}
		return flag;
	}

	/// <summary>
	///
	/// </summary>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool DeleteInvoice(ref Engine Engine, int InvoiceNumber, ref string Out_LastError)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool flag;
		try
		{
			flag = false;
			Out_LastError = "";
			if (GetInvoiceStatus_Exists(ref Engine, InvoiceNumber, ref Out_LastError))
			{
				if (!GetInvoiceStatus_Posted(ref Engine, InvoiceNumber, ref Out_LastError))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceRecord" }, null, null, null));
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[1] { InvoiceNumber }, null, null, OptimisticSet: false, RValueBase: true);
					NewLateBinding.LateCall(objectValue, null, "Find", new object[1] { false }, null, null, null, IgnoreReturn: true);
					flag = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Remove", new object[0], null, null, null));
					if (!flag)
					{
						Out_LastError = "Failed to delete invoice. " + Engine.LastErrorCode + " : " + Engine.LastErrorText;
					}
				}
				else
				{
					Out_LastError = "Invoice " + Conversions.ToString(InvoiceNumber) + " is posted and cannot be deleted.";
				}
			}
			else
			{
				Out_LastError = "Invoice " + Conversions.ToString(InvoiceNumber) + " doesn't exist.";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
		}
		return flag;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Engine"></param>
	/// <param name="InvoiceNumber"></param>
	/// <param name="Out_LastError"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool GetInvoiceStatus_Exists(ref Engine Engine, int InvoiceNumber, ref string Out_LastError)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool result;
		try
		{
			result = false;
			Out_LastError = "";
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceRecord" }, null, null, null));
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[1] { InvoiceNumber }, null, null, OptimisticSet: false, RValueBase: true);
			result = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Find", new object[1] { false }, null, null, null));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
		}
		return result;
	}

	/// <summary>
	///
	/// </summary>
	/// <param name="Engine"></param>
	/// <param name="InvoiceNumber"></param>
	/// <param name="Out_LastError"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static bool GetInvoiceStatus_Posted(ref Engine Engine, int InvoiceNumber, ref string Out_LastError)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		bool result;
		try
		{
			result = false;
			Out_LastError = "";
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceRecord" }, null, null, null));
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INVOICE_NUMBER" }, null, null, null), null, "Value", new object[1] { InvoiceNumber }, null, null, OptimisticSet: false, RValueBase: true);
			if (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Find", new object[1] { false }, null, null, null)))
			{
				result = Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "POSTED_CODE" }, null, null, null), null, "Value", new object[0], null, null, null));
			}
			else
			{
				Out_LastError = "Invoice # " + Conversions.ToString(InvoiceNumber) + " not found.";
				result = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Out_LastError = Engine.LastErrorCode + " : " + Engine.LastErrorText;
			throw ex2;
		}
		finally
		{
			object objectValue = null;
		}
		return result;
	}

	public static bool EditInvoiceTransaction(ref Engine Engine, InvoiceTransaction TransactionToSave)
	{
		if (TransactionToSave == null)
		{
			return false;
		}
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		object obj = null;
		try
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "SplitData" }, null, null, null));
			NewLateBinding.LateCall(obj, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "Open", new object[1] { 1 }, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "FindFirst", new object[2] { "TRAN_NUMBER", TransactionToSave.TRAN_NUMBER }, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "Read", new object[1] { TransactionToSave.TRAN_NUMBER }, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DEPT_NUMBER" }, null, null, null), null, "Value", new object[1] { TransactionToSave.DEPT_NUMBER }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DETAILS" }, null, null, null), null, "Value", new object[1] { TransactionToSave.DETAILS }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "INTERNAL_REF" }, null, null, null), null, "Value", new object[1] { TransactionToSave.EXTRA_REF }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "USER_NAME" }, null, null, null), null, "Value", new object[1] { TransactionToSave.USER_NAME }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "VAT_FLAG" }, null, null, null), null, "Value", new object[1] { TransactionToSave.VAT_FLAG }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "VAT_RECONCILED_DATE" }, null, null, null), null, "Value", new object[1] { TransactionToSave.VAT_RECONCILED_DATE }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(obj, null, "Write", new object[1] { TransactionToSave.TRAN_NUMBER }, null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
			return true;
		}
		finally
		{
			if (obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
				obj = null;
			}
		}
	}

	public static bool EditInvoiceTransaction_SetDepartmentTo(ref Engine Engine, int transactionNumber, int department)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		object obj = null;
		try
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "SplitData" }, null, null, null));
			NewLateBinding.LateCall(obj, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "Open", new object[1] { 1 }, null, null, null, IgnoreReturn: true);
			object instance = obj;
			object[] obj2 = new object[2] { "TRAN_NUMBER", transactionNumber };
			object[] array = obj2;
			bool[] obj3 = new bool[2] { false, true };
			bool[] array2 = obj3;
			NewLateBinding.LateCall(instance, null, "FindFirst", obj2, null, null, obj3, IgnoreReturn: true);
			if (array2[1])
			{
				transactionNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			NewLateBinding.LateCall(obj, null, "Read", array = new object[1] { transactionNumber }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				transactionNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DEPT_NUMBER" }, null, null, null), null, "Value", new object[1] { department }, null, null, OptimisticSet: false, RValueBase: true);
			NewLateBinding.LateCall(obj, null, "Write", array = new object[1] { transactionNumber }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				transactionNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
			return true;
		}
		finally
		{
			if (obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
				obj = null;
			}
		}
	}

	public static bool UpdateInvoiceItems(ref Engine Engine, int InvoiceNumber, int DeptNumber)
	{
		if (Engine == null || !Engine.IsInitialized)
		{
			throw new ArgumentException("Engine is null or not initialized.");
		}
		if (!Engine.IsConnected)
		{
			throw new ArgumentException("Engine is not connected to a Sage company dataset.");
		}
		object obj = null;
		string empty = string.Empty;
		try
		{
			obj = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Engine.ActiveWorkSpace, null, "CreateObject", new object[1] { "InvoiceItem" }, null, null, null));
			NewLateBinding.LateCall(obj, null, "MoveFirst", new object[0], null, null, null, IgnoreReturn: true);
			NewLateBinding.LateCall(obj, null, "Open", new object[1] { 1 }, null, null, null, IgnoreReturn: true);
			bool flag = false;
			object instance = obj;
			object[] obj2 = new object[2] { "INVOICE_NUMBER", InvoiceNumber };
			object[] array = obj2;
			bool[] obj3 = new bool[2] { false, true };
			bool[] array2 = obj3;
			object value = NewLateBinding.LateGet(instance, null, "FindFirst", obj2, null, null, obj3);
			if (array2[1])
			{
				InvoiceNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			flag = Conversions.ToBoolean(value);
			while (flag)
			{
				empty = Conversions.ToString(NewLateBinding.LateGet(obj, null, "RecordNumber", new object[0], null, null, null));
				NewLateBinding.LateCall(obj, null, "Read", array = new object[1] { empty }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
				if (array2[0])
				{
					empty = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, null, "Fields", new object[0], null, null, null), null, "Item", new object[1] { "DEPT_NUMBER" }, null, null, null), null, "Value", new object[1] { DeptNumber.ToString() }, null, null, OptimisticSet: false, RValueBase: true);
				NewLateBinding.LateCall(obj, null, "Write", array = new object[1] { empty }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
				if (array2[0])
				{
					empty = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				object value2 = NewLateBinding.LateGet(obj, null, "FindNext", array = new object[2] { "INVOICE_NUMBER", InvoiceNumber }, null, null, array2 = new bool[2] { false, true });
				if (array2[1])
				{
					InvoiceNumber = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				flag = Conversions.ToBoolean(value2);
			}
			NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
			return true;
		}
		finally
		{
			if (obj != null)
			{
				NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, IgnoreReturn: true);
				obj = null;
			}
		}
	}
}
