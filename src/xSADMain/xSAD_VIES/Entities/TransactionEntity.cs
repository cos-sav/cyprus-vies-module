using System;

namespace xSAD_VIES.Entities;

public class TransactionEntity
{
	public int TransactionNumber { get; set; }

	public string TransactionType { get; set; }

	public string AccountReference { get; set; }

	public string AccountName { get; set; }

	public decimal GrossAmount { get; set; }

	public decimal NetAmount { get; set; }

	public DateTime DateEntered { get; set; }

	public DateTime TransactionDate { get; set; }

	public string CountryCode { get; set; }

	public string CountryName { get; set; }

	public string VatRegistrationNumber { get; set; }

	public TransactionGroup TransactionGroupX { get; set; }

	public string GoodServiceText { get; set; }

	public bool IsTriangular { get; set; }

	public string InvoiceNumber { get; set; }

	public string AccountNameAndReference
	{
		get
		{
			if (AccountName.Trim() == "")
			{
				return AccountReference;
			}
			return AccountName + " (" + AccountReference + ")";
		}
	}
}
