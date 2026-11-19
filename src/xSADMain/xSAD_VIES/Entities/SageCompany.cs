using xSageDataObjects;

namespace xSAD_VIES.Entities;

public class SageCompany
{
	public string CompanyCode { get; set; }

	public string Name { get; set; }

	public string SagePath { get; set; }

	public string SageSetupFile { get; set; }

	public string SageVatRegistrationNumber { get; set; }

	public string SageAddress1 { get; set; }

	public string SageAddress2 { get; set; }

	public string SageAddress3 { get; set; }

	public string SageAddress4 { get; set; }

	public string SageAddress5 { get; set; }

	public string SageConnectionString { get; set; }

	public SdoVersion SageVersion { get; set; }

	public string SageVersionYear { get; set; }

	public string UserName { get; set; }

	public string Password { get; set; }

	public string CompanyXmlPath { get; set; }
}
