namespace xSageDataObjects;

public class InvoiceItem
{
	public string ProductCode;

	public string NominalCode;

	public int Department;

	public decimal Quantity;

	public decimal Price;

	public int TaxCode;

	public decimal TaxRate;

	public decimal TaxAmount;

	public decimal DiscountRate;

	public decimal DiscountAmount;

	public decimal NetAmountBeforeDiscount;

	public decimal NetAmountAfterDiscount;

	public string Description;

	public string CommentText_1;

	public string CommentText_2;
}
