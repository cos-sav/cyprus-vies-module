using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace xSADReports;

[DesignerGenerated]
public class rptVIESSubmissionForm : XtraReport
{
	private IContainer components;

	[field: AccessedThroughProperty("Detail")]
	internal virtual DetailBand Detail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrPictureBox1")]
	internal virtual XRPictureBox XrPictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPeriodFrom")]
	internal virtual XRLabel lblPeriodFrom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPeriodTo")]
	internal virtual XRLabel lblPeriodTo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintDate")]
	internal virtual XRLabel PrintDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TaxPayer")]
	internal virtual XRLabel TaxPayer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalEntries")]
	internal virtual XRLabel lblTotalEntries
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalGoods")]
	internal virtual XRLabel lblTotalGoods
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalTriangle")]
	internal virtual XRLabel lblTotalTriangle
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTotalServices")]
	internal virtual XRLabel lblTotalServices
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrPictureBox2")]
	internal virtual XRPictureBox XrPictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel1")]
	internal virtual XRLabel XrLabel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel2")]
	internal virtual XRLabel XrLabel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReportHeader")]
	internal virtual ReportHeaderBand ReportHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel3")]
	internal virtual XRLabel XrLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ReportFooter")]
	internal virtual ReportFooterBand ReportFooter
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel4")]
	internal virtual XRLabel XrLabel4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel5")]
	internal virtual XRLabel XrLabel5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel6")]
	internal virtual XRLabel XrLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel7")]
	internal virtual XRLabel XrLabel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDeclarationMonthYear")]
	internal virtual XRLabel lblDeclarationMonthYear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel8")]
	internal virtual XRLabel XrLabel8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateHeader")]
	internal virtual XRLabel lblDateHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TopMarginBand1")]
	internal virtual TopMarginBand TopMarginBand1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BottomMarginBand1")]
	internal virtual BottomMarginBand BottomMarginBand1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public string TaxPayerValue
	{
		get
		{
			return TaxPayer.Text;
		}
		set
		{
			TaxPayer.Text = value;
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(rptVIESSubmissionForm));
		Detail = new DetailBand();
		XrLabel1 = new XRLabel();
		XrLabel2 = new XRLabel();
		XrLabel3 = new XRLabel();
		XrLabel4 = new XRLabel();
		XrLabel5 = new XRLabel();
		XrLabel6 = new XRLabel();
		XrLabel7 = new XRLabel();
		PrintDate = new XRLabel();
		TaxPayer = new XRLabel();
		lblPeriodTo = new XRLabel();
		lblPeriodFrom = new XRLabel();
		lblTotalEntries = new XRLabel();
		lblTotalGoods = new XRLabel();
		lblTotalTriangle = new XRLabel();
		lblTotalServices = new XRLabel();
		XrPictureBox1 = new XRPictureBox();
		XrPictureBox2 = new XRPictureBox();
		ReportHeader = new ReportHeaderBand();
		XrLabel8 = new XRLabel();
		lblDeclarationMonthYear = new XRLabel();
		lblDateHeader = new XRLabel();
		ReportFooter = new ReportFooterBand();
		TopMarginBand1 = new TopMarginBand();
		BottomMarginBand1 = new BottomMarginBand();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[7] { XrLabel1, XrLabel2, XrLabel3, XrLabel4, XrLabel5, XrLabel6, XrLabel7 });
		Detail.HeightF = 25f;
		Detail.Name = "Detail";
		Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		Detail.TextAlignment = TextAlignment.TopLeft;
		XrLabel1.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel1.CanGrow = false;
		XrLabel1.Font = new Font("Arial", 9.75f);
		XrLabel1.LocationFloat = new PointFloat(38f, 0f);
		XrLabel1.Name = "XrLabel1";
		XrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel1.SizeF = new SizeF(106f, 25f);
		XrLabel1.StylePriority.UseBorders = false;
		XrLabel1.StylePriority.UseFont = false;
		XrLabel1.StylePriority.UseTextAlignment = false;
		XrLabel1.Text = "[CountryName]";
		XrLabel1.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel1.WordWrap = false;
		XrLabel2.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel2.CanGrow = false;
		XrLabel2.LocationFloat = new PointFloat(144f, 0f);
		XrLabel2.Name = "XrLabel2";
		XrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel2.SizeF = new SizeF(48f, 25f);
		XrLabel2.StylePriority.UseBorders = false;
		XrLabel2.StylePriority.UseTextAlignment = false;
		XrLabel2.Text = "[CountryCode]";
		XrLabel2.TextAlignment = TextAlignment.MiddleCenter;
		XrLabel2.WordWrap = false;
		XrLabel3.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel3.CanGrow = false;
		XrLabel3.Font = new Font("Arial", 9.75f);
		XrLabel3.LocationFloat = new PointFloat(9f, 0f);
		XrLabel3.Name = "XrLabel3";
		XrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel3.SizeF = new SizeF(31f, 25f);
		XrLabel3.StylePriority.UseBorders = false;
		XrLabel3.StylePriority.UseFont = false;
		XrLabel3.StylePriority.UseTextAlignment = false;
		XrLabel3.Text = "[RowNumber]";
		XrLabel3.TextAlignment = TextAlignment.MiddleRight;
		XrLabel3.WordWrap = false;
		XrLabel4.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel4.CanGrow = false;
		XrLabel4.LocationFloat = new PointFloat(192f, 0f);
		XrLabel4.Name = "XrLabel4";
		XrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel4.SizeF = new SizeF(292f, 25f);
		XrLabel4.StylePriority.UseBorders = false;
		XrLabel4.StylePriority.UseTextAlignment = false;
		XrLabel4.Text = "[VatRegistrationNumber]";
		XrLabel4.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel4.WordWrap = false;
		XrLabel5.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel5.CanGrow = false;
		XrLabel5.LocationFloat = new PointFloat(484f, 0f);
		XrLabel5.Name = "XrLabel5";
		XrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel5.SizeF = new SizeF(115f, 25f);
		XrLabel5.StylePriority.UseBorders = false;
		XrLabel5.StylePriority.UseTextAlignment = false;
		XrLabel5.Text = "[SuppliesAmount]";
		XrLabel5.TextAlignment = TextAlignment.MiddleRight;
		XrLabel5.WordWrap = false;
		XrLabel6.Borders = BorderSide.Left | BorderSide.Bottom;
		XrLabel6.CanGrow = false;
		XrLabel6.LocationFloat = new PointFloat(599f, 0f);
		XrLabel6.Name = "XrLabel6";
		XrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel6.SizeF = new SizeF(117f, 25f);
		XrLabel6.StylePriority.UseBorders = false;
		XrLabel6.StylePriority.UseTextAlignment = false;
		XrLabel6.Text = "[TriangleTransactionsAmount]";
		XrLabel6.TextAlignment = TextAlignment.MiddleRight;
		XrLabel6.WordWrap = false;
		XrLabel7.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
		XrLabel7.CanGrow = false;
		XrLabel7.Font = new Font("Arial", 9.75f);
		XrLabel7.LocationFloat = new PointFloat(714f, 0f);
		XrLabel7.Name = "XrLabel7";
		XrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel7.SizeF = new SizeF(117f, 25f);
		XrLabel7.StylePriority.UseBorders = false;
		XrLabel7.StylePriority.UseFont = false;
		XrLabel7.StylePriority.UseTextAlignment = false;
		XrLabel7.Text = "[ServicesAmount]";
		XrLabel7.TextAlignment = TextAlignment.MiddleRight;
		XrLabel7.WordWrap = false;
		PrintDate.LocationFloat = new PointFloat(692f, 25f);
		PrintDate.Name = "PrintDate";
		PrintDate.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		PrintDate.SizeF = new SizeF(142f, 25f);
		PrintDate.StylePriority.UseTextAlignment = false;
		PrintDate.Text = "[PrintDate]";
		PrintDate.TextAlignment = TextAlignment.MiddleLeft;
		PrintDate.WordWrap = false;
		TaxPayer.LocationFloat = new PointFloat(642f, 98f);
		TaxPayer.Name = "TaxPayer";
		TaxPayer.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		TaxPayer.SizeF = new SizeF(142f, 25f);
		TaxPayer.StylePriority.UseTextAlignment = false;
		TaxPayer.Text = "[TaxPayer]";
		TaxPayer.TextAlignment = TextAlignment.MiddleLeft;
		TaxPayer.WordWrap = false;
		lblPeriodTo.LocationFloat = new PointFloat(318f, 99f);
		lblPeriodTo.Name = "lblPeriodTo";
		lblPeriodTo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblPeriodTo.SizeF = new SizeF(115f, 25f);
		lblPeriodTo.StylePriority.UseTextAlignment = false;
		lblPeriodTo.Text = "[PeriodTo]";
		lblPeriodTo.TextAlignment = TextAlignment.MiddleLeft;
		lblPeriodTo.WordWrap = false;
		lblPeriodFrom.LocationFloat = new PointFloat(149f, 99f);
		lblPeriodFrom.Name = "lblPeriodFrom";
		lblPeriodFrom.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblPeriodFrom.SizeF = new SizeF(108f, 25f);
		lblPeriodFrom.StylePriority.UseTextAlignment = false;
		lblPeriodFrom.Text = "[PeriodFrom]";
		lblPeriodFrom.TextAlignment = TextAlignment.MiddleLeft;
		lblPeriodFrom.WordWrap = false;
		lblTotalEntries.LocationFloat = new PointFloat(392f, 196f);
		lblTotalEntries.Name = "lblTotalEntries";
		lblTotalEntries.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalEntries.SizeF = new SizeF(83f, 25f);
		lblTotalEntries.StylePriority.UseTextAlignment = false;
		lblTotalEntries.Text = "[TotalEnties]";
		lblTotalEntries.TextAlignment = TextAlignment.MiddleRight;
		lblTotalEntries.WordWrap = false;
		lblTotalGoods.LocationFloat = new PointFloat(492f, 196f);
		lblTotalGoods.Name = "lblTotalGoods";
		lblTotalGoods.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalGoods.SizeF = new SizeF(100f, 25f);
		lblTotalGoods.StylePriority.UseTextAlignment = false;
		lblTotalGoods.Text = "[TotalGoods]";
		lblTotalGoods.TextAlignment = TextAlignment.MiddleRight;
		lblTotalGoods.WordWrap = false;
		lblTotalTriangle.LocationFloat = new PointFloat(608f, 196f);
		lblTotalTriangle.Name = "lblTotalTriangle";
		lblTotalTriangle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalTriangle.SizeF = new SizeF(100f, 25f);
		lblTotalTriangle.StylePriority.UseTextAlignment = false;
		lblTotalTriangle.Text = "[TotalTriangle]";
		lblTotalTriangle.TextAlignment = TextAlignment.MiddleRight;
		lblTotalTriangle.WordWrap = false;
		lblTotalServices.LocationFloat = new PointFloat(725f, 196f);
		lblTotalServices.Name = "lblTotalServices";
		lblTotalServices.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalServices.SizeF = new SizeF(100f, 25f);
		lblTotalServices.StylePriority.UseTextAlignment = false;
		lblTotalServices.Text = "[TotalServices]";
		lblTotalServices.TextAlignment = TextAlignment.MiddleRight;
		lblTotalServices.WordWrap = false;
		XrPictureBox1.Image = (Image)componentResourceManager.GetObject("XrPictureBox1.Image");
		XrPictureBox1.LocationFloat = new PointFloat(8f, 92f);
		XrPictureBox1.Name = "XrPictureBox1";
		XrPictureBox1.SizeF = new SizeF(833f, 225f);
		XrPictureBox1.Sizing = ImageSizeMode.ZoomImage;
		XrPictureBox2.Image = (Image)componentResourceManager.GetObject("XrPictureBox2.Image");
		XrPictureBox2.LocationFloat = new PointFloat(208f, 17f);
		XrPictureBox2.Name = "XrPictureBox2";
		XrPictureBox2.SizeF = new SizeF(383f, 33f);
		XrPictureBox2.Sizing = ImageSizeMode.ZoomImage;
		ReportHeader.Controls.AddRange(new XRControl[13]
		{
			XrLabel8, XrPictureBox2, lblTotalServices, lblTotalTriangle, lblTotalGoods, lblTotalEntries, lblPeriodFrom, lblPeriodTo, TaxPayer, PrintDate,
			lblDeclarationMonthYear, XrPictureBox1, lblDateHeader
		});
		ReportHeader.HeightF = 317f;
		ReportHeader.Name = "ReportHeader";
		XrLabel8.BackColor = Color.White;
		XrLabel8.CanGrow = false;
		XrLabel8.LocationFloat = new PointFloat(11f, 164f);
		XrLabel8.Name = "XrLabel8";
		XrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel8.SizeF = new SizeF(367f, 72f);
		XrLabel8.StylePriority.UseBackColor = false;
		XrLabel8.StylePriority.UseTextAlignment = false;
		XrLabel8.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel8.WordWrap = false;
		lblDeclarationMonthYear.BackColor = Color.White;
		lblDeclarationMonthYear.CanGrow = false;
		lblDeclarationMonthYear.LocationFloat = new PointFloat(102f, 136f);
		lblDeclarationMonthYear.Name = "lblDeclarationMonthYear";
		lblDeclarationMonthYear.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDeclarationMonthYear.SizeF = new SizeF(167f, 25f);
		lblDeclarationMonthYear.StylePriority.UseBackColor = false;
		lblDeclarationMonthYear.StylePriority.UseTextAlignment = false;
		lblDeclarationMonthYear.TextAlignment = TextAlignment.MiddleLeft;
		lblDeclarationMonthYear.WordWrap = false;
		lblDateHeader.CanGrow = false;
		lblDateHeader.Font = new Font("Arial", 8.75f);
		lblDateHeader.LocationFloat = new PointFloat(692f, 6f);
		lblDateHeader.Name = "lblDateHeader";
		lblDateHeader.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDateHeader.SizeF = new SizeF(142f, 25f);
		lblDateHeader.StylePriority.UseFont = false;
		lblDateHeader.StylePriority.UseTextAlignment = false;
		lblDateHeader.Text = "Print date:";
		lblDateHeader.TextAlignment = TextAlignment.MiddleLeft;
		lblDateHeader.WordWrap = false;
		ReportFooter.HeightF = 17f;
		ReportFooter.Name = "ReportFooter";
		TopMarginBand1.HeightF = 0f;
		TopMarginBand1.Name = "TopMarginBand1";
		BottomMarginBand1.HeightF = 0f;
		BottomMarginBand1.Name = "BottomMarginBand1";
		base.Bands.AddRange(new Band[5] { Detail, ReportHeader, ReportFooter, TopMarginBand1, BottomMarginBand1 });
		base.Font = new Font("Arial", 9.75f);
		base.Margins = new Margins(0, 0, 0, 0);
		base.Version = "10.1";
		((ISupportInitialize)this).EndInit();
	}

	public void SetTotals(int totalEntries, decimal totalGoods, decimal totalTriange, decimal totalServices)
	{
		lblTotalEntries.Text = Conversions.ToString(totalEntries);
		lblTotalGoods.Text = totalGoods.ToString("0.00");
		lblTotalTriangle.Text = totalTriange.ToString("0.00");
		lblTotalServices.Text = totalServices.ToString("0.00");
	}

	public void SetDates(DateTime periodFrom, DateTime periodTo, string declarationMonth, string declarationYear, string printDateHeader)
	{
		lblPeriodFrom.Text = periodFrom.ToString("dd/MMM/yyyy");
		lblPeriodTo.Text = periodTo.ToString("dd/MMM/yyyy");
		lblDeclarationMonthYear.Text = declarationMonth + " / " + declarationYear;
		lblDateHeader.Text = printDateHeader;
	}

	public rptVIESSubmissionForm()
	{
		InitializeComponent();
		PrintDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
		base.Name = "VIES Submission Form";
	}
}
