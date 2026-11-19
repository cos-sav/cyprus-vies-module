namespace xSAD_VIES.DAL;

public class Objects
{
	public class GroupObject
	{
		public int PkGroupId { get; set; }

		public string Name { get; set; }

		public string VatReg { get; set; }
	}

	public class MultipleCompanyObject
	{
		public int PkMultipleCompanyId { get; set; }

		public string Name { get; set; }
	}
}
