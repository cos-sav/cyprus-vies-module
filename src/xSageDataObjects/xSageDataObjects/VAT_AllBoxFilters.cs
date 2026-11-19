namespace xSageDataObjects;

public class VAT_AllBoxFilters
{
	public VAT_BoxFilter Box1 { get; set; }

	public VAT_BoxFilter Box2 { get; set; }

	public VAT_BoxFilter Box4 { get; set; }

	public VAT_BoxFilter Box6 { get; set; }

	public VAT_BoxFilter Box7 { get; set; }

	public VAT_BoxFilter Box8a { get; set; }

	public VAT_BoxFilter Box8b { get; set; }

	public VAT_BoxFilter Box9 { get; set; }

	public VAT_BoxFilter Box10 { get; set; }

	public VAT_BoxFilter Box11a { get; set; }

	public VAT_BoxFilter Box11b { get; set; }

	public VAT_AllBoxFilters()
	{
	}

	public VAT_AllBoxFilters(VAT_BoxFilter box1, VAT_BoxFilter box2, VAT_BoxFilter box4, VAT_BoxFilter box6, VAT_BoxFilter box7, VAT_BoxFilter box8a, VAT_BoxFilter box8b, VAT_BoxFilter box9, VAT_BoxFilter box10, VAT_BoxFilter box11a, VAT_BoxFilter box11b)
		: this()
	{
		Box1 = box1;
		Box2 = box2;
		Box4 = box4;
		Box6 = box6;
		Box7 = box7;
		Box8a = box8a;
		Box8b = box8b;
		Box9 = box9;
		Box10 = box10;
		Box11a = box11a;
		Box11b = box11b;
	}
}
