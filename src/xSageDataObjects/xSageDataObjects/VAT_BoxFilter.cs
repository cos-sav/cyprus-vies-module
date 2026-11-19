namespace xSageDataObjects;

public class VAT_BoxFilter
{
	public string AddFilter { get; set; }

	public string SubtractFilter { get; set; }

	public VAT_BoxFilter()
		: this(string.Empty, string.Empty)
	{
	}

	public VAT_BoxFilter(string addFilter, string subtractFilter)
	{
		AddFilter = addFilter;
		SubtractFilter = subtractFilter;
	}
}
