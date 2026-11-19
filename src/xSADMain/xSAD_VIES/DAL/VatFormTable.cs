using System;
using System.Data;

namespace xSAD_VIES.DAL;

public class VatFormTable : DataTable
{
	public const string Taxpayer = "TaxPayer";

	public const string Periodfrom = "PeriodFrom";

	public const string Periodto = "PeriodTo";

	public const string Dueoutflowvat = "DueOutflowVat";

	public const string Dueeuacquisitionvat = "DueEuAcquisitionVat";

	public const string Duevattotal = "DueVatTotal";

	public const string Deductedeuacquisitionvat = "DeductedEuAcquisitionVat";

	public const string Totalvat = "TotalVat";

	public const string Totaloutflows = "TotalOutflows";

	public const string Totalinflows = "TotalInflows";

	public const string Totaltoeuservices = "TotalToEuServices";

	public const string Totaltoeusuppliedservices = "TotalToEuSuppliedServices";

	public const string Totaltoeuzeroservices = "TotalToEuZeroServices";

	public const string Totalsales = "TotalSales";

	public const string Totalfromeuservices = "TotalFromEuServices";

	public const string Totalfromeusuppliedservices = "TotalFromEuSuppliedServices";

	public const string Payamountdescr = "PayAmountDescr";

	public const string Payamount = "PayAmount";

	public const string Paydate = "PayDate";

	public const string Paycode = "PayCode";

	public VatFormTable()
	{
		CreateTable();
	}

	private void CreateTable()
	{
		base.Columns.Add("TaxPayer", typeof(string));
		base.Columns.Add("PeriodFrom", typeof(DateTime));
		base.Columns.Add("PeriodTo", typeof(DateTime));
		base.Columns.Add("DueOutflowVat", typeof(decimal));
		base.Columns.Add("DueEuAcquisitionVat", typeof(decimal));
		base.Columns.Add("DueVatTotal", typeof(decimal));
		base.Columns.Add("DeductedEuAcquisitionVat", typeof(decimal));
		base.Columns.Add("TotalVat", typeof(decimal));
		base.Columns.Add("TotalOutflows", typeof(decimal));
		base.Columns.Add("TotalInflows", typeof(decimal));
		base.Columns.Add("TotalToEuServices", typeof(decimal));
		base.Columns.Add("TotalToEuSuppliedServices", typeof(decimal));
		base.Columns.Add("TotalToEuZeroServices", typeof(decimal));
		base.Columns.Add("TotalSales", typeof(decimal));
		base.Columns.Add("TotalFromEuServices", typeof(decimal));
		base.Columns.Add("TotalFromEuSuppliedServices", typeof(decimal));
		base.Columns.Add("PayAmountDescr", typeof(string));
		base.Columns.Add("PayAmount", typeof(decimal));
		base.Columns.Add("PayDate", typeof(DateTime));
		base.Columns.Add("PayCode", typeof(string));
	}
}
