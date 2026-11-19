using System;
using System.Collections.Generic;
using xSageDataObjects;

namespace xSAD_VIES.Entities;

public class ViesEntity
{
	public List<ViesRowEntity> ViesRows;

	public List<TransactionEntity> ViesTransactions;

	public VIES.TransactionSplitsDataTable DataTable;

	public string TaxPayer { get; set; }

	public DateTime PeriodFrom { get; set; }

	public DateTime PeriodTo { get; set; }

	public int DeclarationMonth { get; set; }

	public int DeclarationYear { get; set; }

	public int TotalRows => ViesRows.Count;

	public decimal SumSuppliesAmount { get; set; }

	public decimal SumTriangleTransactionsAmount { get; set; }

	public decimal SumServicesAmount { get; set; }

	public ViesEntity()
	{
		TaxPayer = "";
		PeriodFrom = DateTime.Now;
		PeriodTo = DateTime.Now;
		DeclarationMonth = 0;
		DeclarationYear = 0;
		SumSuppliesAmount = 0m;
		SumTriangleTransactionsAmount = 0m;
		SumServicesAmount = 0m;
		ViesRows = new List<ViesRowEntity>();
		ViesTransactions = new List<TransactionEntity>();
	}
}
