using System;

namespace xSAD_VIES.Entities;

public class Company
{
	public int PkCompanyId { get; set; }

	public int FkGroupId { get; set; }

	public string Name { get; set; }

	public string Address1 { get; set; }

	public string Address2 { get; set; }

	public string CompanyCode { get; set; }

	public string VatReg { get; set; }

	public DateTime PeriodFrom { get; set; }

	public DateTime PeriodTo { get; set; }

	public bool Include { get; set; }
}
