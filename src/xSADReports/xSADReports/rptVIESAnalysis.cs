using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xSADReports;

[DesignerGenerated]
public class rptVIESAnalysis : XtraReport
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTransactionDate")]
	private XRLabel _lblTransactionDate;

	[CompilerGenerated]
	[AccessedThroughProperty("lblAmount")]
	private XRLabel _lblAmount;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTotalVAT1")]
	private XRLabel _lblTotalVAT1;

	[CompilerGenerated]
	[AccessedThroughProperty("lblAccountRef")]
	private XRLabel _lblAccountRef;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTriangular")]
	private XRLabel _lblTriangular;

	[CompilerGenerated]
	[AccessedThroughProperty("lblHeaderCustomerTotal")]
	private XRLabel _lblHeaderCustomerTotal;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTotalCustomer1")]
	private XRLabel _lblTotalCustomer1;

	[CompilerGenerated]
	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTotalCustomer2")]
	private XRLabel _lblTotalCustomer2;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTotalVAT2")]
	private XRLabel _lblTotalVAT2;

	[CompilerGenerated]
	[AccessedThroughProperty("lblTotalVAT")]
	private XRLabel _lblTotalVAT;

	[field: AccessedThroughProperty("Detail")]
	internal virtual DetailBand Detail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PageHeader")]
	internal virtual PageHeaderBand PageHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BottomMargin")]
	internal virtual BottomMarginBand BottomMargin
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupHeader1")]
	internal virtual GroupHeaderBand GroupHeader1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupFooter1")]
	internal virtual GroupFooterBand GroupFooter1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHeaderVATTotal1")]
	internal virtual XRLabel lblHeaderVATTotal1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblVatRegistrationNumber")]
	internal virtual XRLabel lblVatRegistrationNumber
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

	[field: AccessedThroughProperty("ReportHeader")]
	internal virtual ReportHeaderBand ReportHeader
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrControlStyle1")]
	internal virtual XRControlStyle XrControlStyle1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrControlStyle2")]
	internal virtual XRControlStyle XrControlStyle2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrControlStyle3")]
	internal virtual XRControlStyle XrControlStyle3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTransactioNumber")]
	internal virtual XRLabel lblTransactioNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTransactionType")]
	internal virtual XRLabel lblTransactionType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblNC")]
	internal virtual XRLabel lblNC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReference")]
	internal virtual XRLabel lblReference
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel lblTransactionDate
	{
		[CompilerGenerated]
		get
		{
			return _lblTransactionDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTransactionDate_BeforePrint;
			XRLabel xRLabel = _lblTransactionDate;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTransactionDate = value;
			xRLabel = _lblTransactionDate;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblDetails")]
	internal virtual XRLabel lblDetails
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel lblAmount
	{
		[CompilerGenerated]
		get
		{
			return _lblAmount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblAmount_BeforePrint;
			XRLabel xRLabel = _lblAmount;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblAmount = value;
			xRLabel = _lblAmount;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	internal virtual XRLabel lblTotalVAT1
	{
		[CompilerGenerated]
		get
		{
			return _lblTotalVAT1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTotalVAT1_BeforePrint;
			XRLabel xRLabel = _lblTotalVAT1;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTotalVAT1 = value;
			xRLabel = _lblTotalVAT1;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("XrLabel21")]
	internal virtual XRLabel XrLabel21
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTimeNow")]
	internal virtual XRLabel lblTimeNow
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateNow")]
	internal virtual XRLabel lblDateNow
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel15")]
	internal virtual XRLabel XrLabel15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCompany")]
	internal virtual XRLabel lblCompany
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblReportDetails")]
	internal virtual XRLabel lblReportDetails
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblPageInfo")]
	internal virtual XRPageInfo lblPageInfo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateFrom")]
	internal virtual XRLabel lblDateFrom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel19")]
	internal virtual XRLabel XrLabel19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel18")]
	internal virtual XRLabel XrLabel18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblDateTo")]
	internal virtual XRLabel lblDateTo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblHiddenBox")]
	internal virtual XRLabel lblHiddenBox
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

	[field: AccessedThroughProperty("headerNo")]
	internal virtual XRLabel headerNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerType")]
	internal virtual XRLabel headerType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerNC")]
	internal virtual XRLabel headerNC
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerRef")]
	internal virtual XRLabel headerRef
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerDate")]
	internal virtual XRLabel headerDate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerDetails")]
	internal virtual XRLabel headerDetails
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerAmount")]
	internal virtual XRLabel headerAmount
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

	internal virtual XRLabel lblAccountRef
	{
		[CompilerGenerated]
		get
		{
			return _lblAccountRef;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblAccountRef_BeforePrint;
			XRLabel xRLabel = _lblAccountRef;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblAccountRef = value;
			xRLabel = _lblAccountRef;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("XrLabel3")]
	internal virtual XRLabel XrLabel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblCountryCode")]
	internal virtual XRLabel lblCountryCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("headerIndicator")]
	internal virtual XRLabel headerIndicator
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel lblTriangular
	{
		[CompilerGenerated]
		get
		{
			return _lblTriangular;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblITriangular_BeforePrint;
			XRLabel xRLabel = _lblTriangular;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTriangular = value;
			xRLabel = _lblTriangular;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("XrLabel7")]
	internal virtual XRLabel XrLabel7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLine1")]
	internal virtual XRLine XrLine1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupHeader2")]
	internal virtual GroupHeaderBand GroupHeader2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGoodsServices")]
	internal virtual XRLabel lblGoodsServices
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

	[field: AccessedThroughProperty("GroupHeader0")]
	internal virtual GroupHeaderBand GroupHeader0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("XrLabel12")]
	internal virtual XRLabel XrLabel12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupFooter0")]
	internal virtual GroupFooterBand GroupFooter0
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel lblHeaderCustomerTotal
	{
		[CompilerGenerated]
		get
		{
			return _lblHeaderCustomerTotal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblHeaderCustomerTotal_BeforePrint;
			XRLabel xRLabel = _lblHeaderCustomerTotal;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblHeaderCustomerTotal = value;
			xRLabel = _lblHeaderCustomerTotal;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	internal virtual XRLabel lblTotalCustomer1
	{
		[CompilerGenerated]
		get
		{
			return _lblTotalCustomer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTotalCustomer1_BeforePrint;
			XRLabel xRLabel = _lblTotalCustomer1;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTotalCustomer1 = value;
			xRLabel = _lblTotalCustomer1;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblGroup0VatRegistrationNumber")]
	internal virtual XRLabel lblGroup0VatRegistrationNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGroup0AccountReference")]
	internal virtual XRLabel lblGroup0AccountReference
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGroup1VatRegistrationNumber")]
	internal virtual XRLabel lblGroup1VatRegistrationNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel XrLabel2
	{
		[CompilerGenerated]
		get
		{
			return _XrLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = XrLabel2_BeforePrint;
			XRLabel xrLabel = _XrLabel2;
			if (xrLabel != null)
			{
				xrLabel.BeforePrint -= value2;
			}
			_XrLabel2 = value;
			xrLabel = _XrLabel2;
			if (xrLabel != null)
			{
				xrLabel.BeforePrint += value2;
			}
		}
	}

	internal virtual XRLabel lblTotalCustomer2
	{
		[CompilerGenerated]
		get
		{
			return _lblTotalCustomer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTotalCustomer2_BeforePrint;
			XRLabel xRLabel = _lblTotalCustomer2;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTotalCustomer2 = value;
			xRLabel = _lblTotalCustomer2;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("lblHeaderVATTotal2")]
	internal virtual XRLabel lblHeaderVATTotal2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual XRLabel lblTotalVAT2
	{
		[CompilerGenerated]
		get
		{
			return _lblTotalVAT2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTotalVAT2_BeforePrint;
			XRLabel xRLabel = _lblTotalVAT2;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTotalVAT2 = value;
			xRLabel = _lblTotalVAT2;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	internal virtual XRLabel lblTotalVAT
	{
		[CompilerGenerated]
		get
		{
			return _lblTotalVAT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			PrintEventHandler value2 = lblTotalVAT_BeforePrint;
			XRLabel xRLabel = _lblTotalVAT;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint -= value2;
			}
			_lblTotalVAT = value;
			xRLabel = _lblTotalVAT;
			if (xRLabel != null)
			{
				xRLabel.BeforePrint += value2;
			}
		}
	}

	[field: AccessedThroughProperty("XrLabel6")]
	internal virtual XRLabel XrLabel6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGroup0CountryCode")]
	internal virtual XRLabel lblGroup0CountryCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblGroup1CountryCode")]
	internal virtual XRLabel lblGroup1CountryCode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAccountRefHidden")]
	internal virtual XRLabel lblAccountRefHidden
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblAccountNameHidden")]
	internal virtual XRLabel lblAccountNameHidden
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupFooter2")]
	internal virtual GroupFooterBand GroupFooter2
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

	public string DateFrom
	{
		get
		{
			return lblDateFrom.Text;
		}
		set
		{
			lblDateFrom.Text = value;
		}
	}

	public string DateTo
	{
		get
		{
			return lblDateTo.Text;
		}
		set
		{
			lblDateTo.Text = value;
		}
	}

	public string DateNow
	{
		get
		{
			return lblDateNow.Text;
		}
		set
		{
			lblDateNow.Text = value;
		}
	}

	public string TimeNow
	{
		get
		{
			return lblTimeNow.Text;
		}
		set
		{
			lblTimeNow.Text = value;
		}
	}

	public string CompanyName
	{
		get
		{
			return lblCompany.Text;
		}
		set
		{
			lblCompany.Text = value;
		}
	}

	public string ReportDetails
	{
		get
		{
			return lblReportDetails.Text;
		}
		set
		{
			lblReportDetails.Text = value;
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
		XRSummary xRSummary = new XRSummary();
		XRSummary xRSummary2 = new XRSummary();
		XRSummary xRSummary3 = new XRSummary();
		XRSummary xRSummary4 = new XRSummary();
		XRSummary xRSummary5 = new XRSummary();
		Detail = new DetailBand();
		lblDetails = new XRLabel();
		lblTransactioNumber = new XRLabel();
		lblTransactionType = new XRLabel();
		lblNC = new XRLabel();
		lblReference = new XRLabel();
		lblTransactionDate = new XRLabel();
		lblAmount = new XRLabel();
		lblHiddenBox = new XRLabel();
		lblTriangular = new XRLabel();
		PageHeader = new PageHeaderBand();
		XrLabel21 = new XRLabel();
		lblTimeNow = new XRLabel();
		lblDateNow = new XRLabel();
		XrLabel15 = new XRLabel();
		lblCompany = new XRLabel();
		lblReportDetails = new XRLabel();
		lblPageInfo = new XRPageInfo();
		lblDateFrom = new XRLabel();
		XrLabel19 = new XRLabel();
		XrLabel18 = new XRLabel();
		lblDateTo = new XRLabel();
		BottomMargin = new BottomMarginBand();
		GroupHeader1 = new GroupHeaderBand();
		lblAccountRef = new XRLabel();
		XrLabel1 = new XRLabel();
		lblAccountRefHidden = new XRLabel();
		lblAccountNameHidden = new XRLabel();
		XrLabel7 = new XRLabel();
		headerNo = new XRLabel();
		headerNC = new XRLabel();
		headerAmount = new XRLabel();
		headerDetails = new XRLabel();
		headerRef = new XRLabel();
		headerIndicator = new XRLabel();
		headerDate = new XRLabel();
		headerType = new XRLabel();
		XrLabel3 = new XRLabel();
		lblCountryCode = new XRLabel();
		lblVatRegistrationNumber = new XRLabel();
		XrLabel5 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		lblGroup0VatRegistrationNumber = new XRLabel();
		XrLabel2 = new XRLabel();
		lblTotalCustomer2 = new XRLabel();
		lblHeaderCustomerTotal = new XRLabel();
		lblGroup0AccountReference = new XRLabel();
		lblGroup0CountryCode = new XRLabel();
		lblTotalCustomer1 = new XRLabel();
		lblTotalVAT1 = new XRLabel();
		XrLine1 = new XRLine();
		lblGroup1VatRegistrationNumber = new XRLabel();
		lblHeaderVATTotal1 = new XRLabel();
		lblTotalVAT2 = new XRLabel();
		lblHeaderVATTotal2 = new XRLabel();
		lblTotalVAT = new XRLabel();
		XrLabel6 = new XRLabel();
		lblGroup1CountryCode = new XRLabel();
		ReportFooter = new ReportFooterBand();
		ReportHeader = new ReportHeaderBand();
		XrControlStyle1 = new XRControlStyle();
		XrControlStyle2 = new XRControlStyle();
		XrControlStyle3 = new XRControlStyle();
		GroupHeader2 = new GroupHeaderBand();
		lblGoodsServices = new XRLabel();
		XrLabel8 = new XRLabel();
		GroupHeader0 = new GroupHeaderBand();
		XrLabel12 = new XRLabel();
		GroupFooter0 = new GroupFooterBand();
		GroupFooter2 = new GroupFooterBand();
		TopMarginBand1 = new TopMarginBand();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[9] { lblDetails, lblTransactioNumber, lblTransactionType, lblNC, lblReference, lblTransactionDate, lblAmount, lblHiddenBox, lblTriangular });
		Detail.EvenStyleName = "XrControlStyle2";
		Detail.Font = new Font("Tahoma", 9.75f);
		Detail.HeightF = 21f;
		Detail.KeepTogether = true;
		Detail.Name = "Detail";
		Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		Detail.StylePriority.UseFont = false;
		Detail.TextAlignment = TextAlignment.TopLeft;
		lblDetails.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblDetails.ForeColor = Color.Black;
		lblDetails.LocationFloat = new PointFloat(417f, 0f);
		lblDetails.Name = "lblDetails";
		lblDetails.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDetails.SizeF = new SizeF(208f, 12f);
		lblDetails.StylePriority.UseFont = false;
		lblDetails.StylePriority.UseForeColor = false;
		lblDetails.StylePriority.UseTextAlignment = false;
		lblDetails.Text = "[DETAILS]";
		lblDetails.TextAlignment = TextAlignment.MiddleLeft;
		lblDetails.WordWrap = false;
		lblTransactioNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblTransactioNumber.ForeColor = Color.Black;
		lblTransactioNumber.LocationFloat = new PointFloat(8f, 0f);
		lblTransactioNumber.Name = "lblTransactioNumber";
		lblTransactioNumber.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTransactioNumber.SizeF = new SizeF(50f, 12f);
		lblTransactioNumber.StylePriority.UseFont = false;
		lblTransactioNumber.StylePriority.UseForeColor = false;
		lblTransactioNumber.StylePriority.UseTextAlignment = false;
		lblTransactioNumber.Text = "[TRAN_NUMBER]";
		lblTransactioNumber.TextAlignment = TextAlignment.MiddleLeft;
		lblTransactioNumber.WordWrap = false;
		lblTransactionType.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblTransactionType.ForeColor = Color.Black;
		lblTransactionType.LocationFloat = new PointFloat(67f, 0f);
		lblTransactionType.Name = "lblTransactionType";
		lblTransactionType.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTransactionType.SizeF = new SizeF(42f, 12f);
		lblTransactionType.StylePriority.UseFont = false;
		lblTransactionType.StylePriority.UseForeColor = false;
		lblTransactionType.StylePriority.UseTextAlignment = false;
		lblTransactionType.Text = "[TYPE]";
		lblTransactionType.TextAlignment = TextAlignment.MiddleLeft;
		lblTransactionType.WordWrap = false;
		lblNC.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblNC.ForeColor = Color.Black;
		lblNC.LocationFloat = new PointFloat(142f, 0f);
		lblNC.Name = "lblNC";
		lblNC.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblNC.SizeF = new SizeF(83f, 12f);
		lblNC.StylePriority.UseFont = false;
		lblNC.StylePriority.UseForeColor = false;
		lblNC.StylePriority.UseTextAlignment = false;
		lblNC.Text = "[NOMINAL_CODE]";
		lblNC.TextAlignment = TextAlignment.MiddleLeft;
		lblNC.WordWrap = false;
		lblReference.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblReference.ForeColor = Color.Black;
		lblReference.LocationFloat = new PointFloat(242f, 0f);
		lblReference.Name = "lblReference";
		lblReference.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblReference.SizeF = new SizeF(83f, 12f);
		lblReference.StylePriority.UseFont = false;
		lblReference.StylePriority.UseForeColor = false;
		lblReference.StylePriority.UseTextAlignment = false;
		lblReference.Text = "[INV_REF]";
		lblReference.TextAlignment = TextAlignment.MiddleLeft;
		lblReference.WordWrap = false;
		lblTransactionDate.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblTransactionDate.ForeColor = Color.Black;
		lblTransactionDate.LocationFloat = new PointFloat(342f, 0f);
		lblTransactionDate.Name = "lblTransactionDate";
		lblTransactionDate.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTransactionDate.SizeF = new SizeF(75f, 12f);
		lblTransactionDate.StylePriority.UseFont = false;
		lblTransactionDate.StylePriority.UseForeColor = false;
		lblTransactionDate.StylePriority.UseTextAlignment = false;
		lblTransactionDate.Text = "[TRAN_DATE]";
		lblTransactionDate.TextAlignment = TextAlignment.MiddleLeft;
		lblTransactionDate.WordWrap = false;
		lblAmount.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblAmount.ForeColor = Color.Black;
		lblAmount.LocationFloat = new PointFloat(583f, 0f);
		lblAmount.Name = "lblAmount";
		lblAmount.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblAmount.SizeF = new SizeF(103f, 12f);
		lblAmount.StylePriority.UseFont = false;
		lblAmount.StylePriority.UseForeColor = false;
		lblAmount.StylePriority.UseTextAlignment = false;
		lblAmount.Text = "[NET_AMOUNT]";
		lblAmount.TextAlignment = TextAlignment.MiddleRight;
		lblAmount.WordWrap = false;
		lblHiddenBox.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblHiddenBox.ForeColor = Color.Black;
		lblHiddenBox.LocationFloat = new PointFloat(267f, 0f);
		lblHiddenBox.Name = "lblHiddenBox";
		lblHiddenBox.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblHiddenBox.SizeF = new SizeF(83f, 12f);
		lblHiddenBox.StylePriority.UseFont = false;
		lblHiddenBox.StylePriority.UseForeColor = false;
		lblHiddenBox.StylePriority.UseTextAlignment = false;
		lblHiddenBox.Text = "[BOX]";
		lblHiddenBox.TextAlignment = TextAlignment.MiddleLeft;
		lblHiddenBox.Visible = false;
		lblHiddenBox.WordWrap = false;
		lblTriangular.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblTriangular.ForeColor = Color.Black;
		lblTriangular.LocationFloat = new PointFloat(692f, 0f);
		lblTriangular.Name = "lblTriangular";
		lblTriangular.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTriangular.SizeF = new SizeF(61f, 12f);
		lblTriangular.StylePriority.UseFont = false;
		lblTriangular.StylePriority.UseForeColor = false;
		lblTriangular.StylePriority.UseTextAlignment = false;
		lblTriangular.Text = "[Is_Triangular]";
		lblTriangular.TextAlignment = TextAlignment.MiddleCenter;
		lblTriangular.WordWrap = false;
		PageHeader.Controls.AddRange(new XRControl[11]
		{
			XrLabel21, lblTimeNow, lblDateNow, XrLabel15, lblCompany, lblReportDetails, lblPageInfo, lblDateFrom, XrLabel19, XrLabel18,
			lblDateTo
		});
		PageHeader.Font = new Font("Tahoma", 9.75f);
		PageHeader.HeightF = 106f;
		PageHeader.Name = "PageHeader";
		PageHeader.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		PageHeader.StylePriority.UseFont = false;
		PageHeader.TextAlignment = TextAlignment.TopLeft;
		XrLabel21.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel21.ForeColor = SystemColors.ControlText;
		XrLabel21.LocationFloat = new PointFloat(0f, 33f);
		XrLabel21.Name = "XrLabel21";
		XrLabel21.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel21.SizeF = new SizeF(75f, 16f);
		XrLabel21.StylePriority.UseFont = false;
		XrLabel21.StylePriority.UseForeColor = false;
		XrLabel21.StylePriority.UseTextAlignment = false;
		XrLabel21.Text = "Time:";
		XrLabel21.TextAlignment = TextAlignment.MiddleLeft;
		lblTimeNow.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblTimeNow.ForeColor = SystemColors.ControlText;
		lblTimeNow.LocationFloat = new PointFloat(83f, 33f);
		lblTimeNow.Name = "lblTimeNow";
		lblTimeNow.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTimeNow.SizeF = new SizeF(100f, 16f);
		lblTimeNow.StylePriority.UseFont = false;
		lblTimeNow.StylePriority.UseForeColor = false;
		lblTimeNow.StylePriority.UseTextAlignment = false;
		lblTimeNow.Text = "00:00:00";
		lblTimeNow.TextAlignment = TextAlignment.MiddleLeft;
		lblDateNow.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblDateNow.ForeColor = SystemColors.ControlText;
		lblDateNow.LocationFloat = new PointFloat(83f, 17f);
		lblDateNow.Name = "lblDateNow";
		lblDateNow.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDateNow.SizeF = new SizeF(100f, 16f);
		lblDateNow.StylePriority.UseFont = false;
		lblDateNow.StylePriority.UseForeColor = false;
		lblDateNow.StylePriority.UseTextAlignment = false;
		lblDateNow.Text = "1/1/1";
		lblDateNow.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel15.ForeColor = SystemColors.ControlText;
		XrLabel15.LocationFloat = new PointFloat(0f, 17f);
		XrLabel15.Name = "XrLabel15";
		XrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel15.SizeF = new SizeF(75f, 16f);
		XrLabel15.StylePriority.UseFont = false;
		XrLabel15.StylePriority.UseForeColor = false;
		XrLabel15.StylePriority.UseTextAlignment = false;
		XrLabel15.Text = "Date:";
		XrLabel15.TextAlignment = TextAlignment.MiddleLeft;
		lblCompany.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		lblCompany.LocationFloat = new PointFloat(200f, 17f);
		lblCompany.Name = "lblCompany";
		lblCompany.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblCompany.SizeF = new SizeF(425f, 25f);
		lblCompany.StylePriority.UseFont = false;
		lblCompany.StylePriority.UseTextAlignment = false;
		lblCompany.Text = "Stationery & Computer Mart UK";
		lblCompany.TextAlignment = TextAlignment.TopCenter;
		lblReportDetails.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		lblReportDetails.LocationFloat = new PointFloat(200f, 42f);
		lblReportDetails.Name = "lblReportDetails";
		lblReportDetails.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblReportDetails.SizeF = new SizeF(425f, 25f);
		lblReportDetails.StylePriority.UseFont = false;
		lblReportDetails.StylePriority.UseTextAlignment = false;
		lblReportDetails.Text = "VIES Report (Detailed)";
		lblReportDetails.TextAlignment = TextAlignment.TopCenter;
		lblPageInfo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblPageInfo.ForeColor = SystemColors.ControlText;
		lblPageInfo.Format = "Page: {0}";
		lblPageInfo.LocationFloat = new PointFloat(650f, 17f);
		lblPageInfo.Name = "lblPageInfo";
		lblPageInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblPageInfo.SizeF = new SizeF(100f, 13f);
		lblPageInfo.StylePriority.UseFont = false;
		lblPageInfo.StylePriority.UseForeColor = false;
		lblPageInfo.StylePriority.UseTextAlignment = false;
		lblPageInfo.TextAlignment = TextAlignment.TopRight;
		lblDateFrom.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblDateFrom.ForeColor = SystemColors.ControlText;
		lblDateFrom.LocationFloat = new PointFloat(83f, 67f);
		lblDateFrom.Name = "lblDateFrom";
		lblDateFrom.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDateFrom.SizeF = new SizeF(142f, 16f);
		lblDateFrom.StylePriority.UseFont = false;
		lblDateFrom.StylePriority.UseForeColor = false;
		lblDateFrom.StylePriority.UseTextAlignment = false;
		lblDateFrom.Text = "1/1/1";
		lblDateFrom.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel19.ForeColor = SystemColors.ControlText;
		XrLabel19.LocationFloat = new PointFloat(0f, 67f);
		XrLabel19.Name = "XrLabel19";
		XrLabel19.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel19.SizeF = new SizeF(75f, 16f);
		XrLabel19.StylePriority.UseFont = false;
		XrLabel19.StylePriority.UseForeColor = false;
		XrLabel19.StylePriority.UseTextAlignment = false;
		XrLabel19.Text = "Date From:";
		XrLabel19.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel18.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel18.ForeColor = SystemColors.ControlText;
		XrLabel18.LocationFloat = new PointFloat(0f, 83f);
		XrLabel18.Name = "XrLabel18";
		XrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel18.SizeF = new SizeF(75f, 16f);
		XrLabel18.StylePriority.UseFont = false;
		XrLabel18.StylePriority.UseForeColor = false;
		XrLabel18.StylePriority.UseTextAlignment = false;
		XrLabel18.Text = "Date To:";
		XrLabel18.TextAlignment = TextAlignment.MiddleLeft;
		lblDateTo.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblDateTo.ForeColor = SystemColors.ControlText;
		lblDateTo.LocationFloat = new PointFloat(83f, 83f);
		lblDateTo.Name = "lblDateTo";
		lblDateTo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblDateTo.SizeF = new SizeF(142f, 16f);
		lblDateTo.StylePriority.UseFont = false;
		lblDateTo.StylePriority.UseForeColor = false;
		lblDateTo.StylePriority.UseTextAlignment = false;
		lblDateTo.Text = "1/1/1";
		lblDateTo.TextAlignment = TextAlignment.MiddleLeft;
		BottomMargin.HeightF = 65f;
		BottomMargin.Name = "BottomMargin";
		GroupHeader1.Controls.AddRange(new XRControl[13]
		{
			lblAccountRef, XrLabel1, lblAccountRefHidden, lblAccountNameHidden, XrLabel7, headerNo, headerNC, headerAmount, headerDetails, headerRef,
			headerIndicator, headerDate, headerType
		});
		GroupHeader1.Font = new Font("Tahoma", 9.75f);
		GroupHeader1.HeightF = 88f;
		GroupHeader1.Level = 1;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeader1.StylePriority.UseFont = false;
		lblAccountRef.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblAccountRef.ForeColor = SystemColors.ControlText;
		lblAccountRef.LocationFloat = new PointFloat(75f, 33f);
		lblAccountRef.Name = "lblAccountRef";
		lblAccountRef.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblAccountRef.SizeF = new SizeF(350f, 17f);
		lblAccountRef.StylePriority.UseFont = false;
		lblAccountRef.StylePriority.UseForeColor = false;
		lblAccountRef.StylePriority.UseTextAlignment = false;
		lblAccountRef.Text = "[ACCOUNT_REF]";
		lblAccountRef.TextAlignment = TextAlignment.MiddleLeft;
		lblAccountRef.WordWrap = false;
		XrLabel1.BorderColor = Color.FromArgb(200, 200, 200);
		XrLabel1.Borders = BorderSide.Top | BorderSide.Bottom;
		XrLabel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel1.ForeColor = SystemColors.ControlText;
		XrLabel1.LocationFloat = new PointFloat(8f, 32f);
		XrLabel1.Name = "XrLabel1";
		XrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel1.SizeF = new SizeF(417f, 19f);
		XrLabel1.StylePriority.UseBorderColor = false;
		XrLabel1.StylePriority.UseBorders = false;
		XrLabel1.StylePriority.UseFont = false;
		XrLabel1.StylePriority.UseForeColor = false;
		XrLabel1.StylePriority.UseTextAlignment = false;
		XrLabel1.Text = "A/C Ref:";
		XrLabel1.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel1.WordWrap = false;
		lblAccountRefHidden.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblAccountRefHidden.ForeColor = SystemColors.ControlText;
		lblAccountRefHidden.LocationFloat = new PointFloat(442f, 8f);
		lblAccountRefHidden.Name = "lblAccountRefHidden";
		lblAccountRefHidden.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblAccountRefHidden.SizeF = new SizeF(308f, 17f);
		lblAccountRefHidden.StylePriority.UseFont = false;
		lblAccountRefHidden.StylePriority.UseForeColor = false;
		lblAccountRefHidden.StylePriority.UseTextAlignment = false;
		lblAccountRefHidden.Text = "[ACCOUNT_REF]";
		lblAccountRefHidden.TextAlignment = TextAlignment.MiddleLeft;
		lblAccountRefHidden.Visible = false;
		lblAccountRefHidden.WordWrap = false;
		lblAccountNameHidden.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblAccountNameHidden.ForeColor = SystemColors.ControlText;
		lblAccountNameHidden.LocationFloat = new PointFloat(442f, 33f);
		lblAccountNameHidden.Name = "lblAccountNameHidden";
		lblAccountNameHidden.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblAccountNameHidden.SizeF = new SizeF(308f, 17f);
		lblAccountNameHidden.StylePriority.UseFont = false;
		lblAccountNameHidden.StylePriority.UseForeColor = false;
		lblAccountNameHidden.StylePriority.UseTextAlignment = false;
		lblAccountNameHidden.Text = "[NAME]";
		lblAccountNameHidden.TextAlignment = TextAlignment.MiddleLeft;
		lblAccountNameHidden.Visible = false;
		lblAccountNameHidden.WordWrap = false;
		XrLabel7.BackColor = Color.FromArgb(250, 250, 250);
		XrLabel7.BorderColor = Color.FromArgb(230, 230, 230);
		XrLabel7.Borders = BorderSide.None;
		XrLabel7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel7.ForeColor = SystemColors.ControlText;
		XrLabel7.LocationFloat = new PointFloat(0f, 7f);
		XrLabel7.Name = "XrLabel7";
		XrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel7.SizeF = new SizeF(753f, 42f);
		XrLabel7.StylePriority.UseBackColor = false;
		XrLabel7.StylePriority.UseBorderColor = false;
		XrLabel7.StylePriority.UseBorders = false;
		XrLabel7.StylePriority.UseFont = false;
		XrLabel7.StylePriority.UseForeColor = false;
		XrLabel7.StylePriority.UseTextAlignment = false;
		XrLabel7.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel7.WordWrap = false;
		headerNo.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerNo.ForeColor = Color.Black;
		headerNo.LocationFloat = new PointFloat(8f, 67f);
		headerNo.Name = "headerNo";
		headerNo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerNo.SizeF = new SizeF(50f, 21f);
		headerNo.StylePriority.UseFont = false;
		headerNo.StylePriority.UseForeColor = false;
		headerNo.StylePriority.UseTextAlignment = false;
		headerNo.Text = "No";
		headerNo.TextAlignment = TextAlignment.MiddleLeft;
		headerNC.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerNC.ForeColor = Color.Black;
		headerNC.LocationFloat = new PointFloat(142f, 67f);
		headerNC.Name = "headerNC";
		headerNC.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerNC.SizeF = new SizeF(83f, 21f);
		headerNC.StylePriority.UseFont = false;
		headerNC.StylePriority.UseForeColor = false;
		headerNC.StylePriority.UseTextAlignment = false;
		headerNC.Text = "N/C";
		headerNC.TextAlignment = TextAlignment.MiddleLeft;
		headerAmount.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerAmount.ForeColor = Color.Black;
		headerAmount.LocationFloat = new PointFloat(625f, 67f);
		headerAmount.Name = "headerAmount";
		headerAmount.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerAmount.SizeF = new SizeF(61f, 21f);
		headerAmount.StylePriority.UseFont = false;
		headerAmount.StylePriority.UseForeColor = false;
		headerAmount.StylePriority.UseTextAlignment = false;
		headerAmount.Text = "Amount";
		headerAmount.TextAlignment = TextAlignment.MiddleRight;
		headerDetails.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerDetails.ForeColor = Color.Black;
		headerDetails.LocationFloat = new PointFloat(417f, 67f);
		headerDetails.Name = "headerDetails";
		headerDetails.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerDetails.SizeF = new SizeF(208f, 21f);
		headerDetails.StylePriority.UseFont = false;
		headerDetails.StylePriority.UseForeColor = false;
		headerDetails.StylePriority.UseTextAlignment = false;
		headerDetails.Text = "Details";
		headerDetails.TextAlignment = TextAlignment.MiddleLeft;
		headerRef.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerRef.ForeColor = Color.Black;
		headerRef.LocationFloat = new PointFloat(242f, 67f);
		headerRef.Name = "headerRef";
		headerRef.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerRef.SizeF = new SizeF(83f, 21f);
		headerRef.StylePriority.UseFont = false;
		headerRef.StylePriority.UseForeColor = false;
		headerRef.StylePriority.UseTextAlignment = false;
		headerRef.Text = "Ref";
		headerRef.TextAlignment = TextAlignment.MiddleLeft;
		headerIndicator.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerIndicator.ForeColor = Color.Black;
		headerIndicator.LocationFloat = new PointFloat(693f, 67f);
		headerIndicator.Name = "headerIndicator";
		headerIndicator.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerIndicator.SizeF = new SizeF(64f, 21f);
		headerIndicator.StylePriority.UseFont = false;
		headerIndicator.StylePriority.UseForeColor = false;
		headerIndicator.StylePriority.UseTextAlignment = false;
		headerIndicator.Text = "Triangular";
		headerIndicator.TextAlignment = TextAlignment.MiddleLeft;
		headerDate.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerDate.ForeColor = Color.Black;
		headerDate.LocationFloat = new PointFloat(342f, 67f);
		headerDate.Name = "headerDate";
		headerDate.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerDate.SizeF = new SizeF(75f, 21f);
		headerDate.StylePriority.UseFont = false;
		headerDate.StylePriority.UseForeColor = false;
		headerDate.StylePriority.UseTextAlignment = false;
		headerDate.Text = "Date";
		headerDate.TextAlignment = TextAlignment.MiddleLeft;
		headerType.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
		headerType.ForeColor = Color.Black;
		headerType.LocationFloat = new PointFloat(67f, 67f);
		headerType.Name = "headerType";
		headerType.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		headerType.SizeF = new SizeF(42f, 21f);
		headerType.StylePriority.UseFont = false;
		headerType.StylePriority.UseForeColor = false;
		headerType.StylePriority.UseTextAlignment = false;
		headerType.Text = "Type";
		headerType.TextAlignment = TextAlignment.MiddleLeft;
		headerType.WordWrap = false;
		XrLabel3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel3.ForeColor = SystemColors.ControlText;
		XrLabel3.LocationFloat = new PointFloat(442f, 25f);
		XrLabel3.Name = "XrLabel3";
		XrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel3.SizeF = new SizeF(80f, 17f);
		XrLabel3.StylePriority.UseFont = false;
		XrLabel3.StylePriority.UseForeColor = false;
		XrLabel3.StylePriority.UseTextAlignment = false;
		XrLabel3.Text = "Country Code:";
		XrLabel3.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel3.WordWrap = false;
		lblCountryCode.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblCountryCode.ForeColor = SystemColors.ControlText;
		lblCountryCode.LocationFloat = new PointFloat(524f, 25f);
		lblCountryCode.Name = "lblCountryCode";
		lblCountryCode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblCountryCode.SizeF = new SizeF(222f, 17f);
		lblCountryCode.StylePriority.UseFont = false;
		lblCountryCode.StylePriority.UseForeColor = false;
		lblCountryCode.StylePriority.UseTextAlignment = false;
		lblCountryCode.Text = "[COUNTRY_CODE]";
		lblCountryCode.TextAlignment = TextAlignment.MiddleLeft;
		lblCountryCode.WordWrap = false;
		lblVatRegistrationNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblVatRegistrationNumber.ForeColor = SystemColors.ControlText;
		lblVatRegistrationNumber.LocationFloat = new PointFloat(83f, 25f);
		lblVatRegistrationNumber.Name = "lblVatRegistrationNumber";
		lblVatRegistrationNumber.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblVatRegistrationNumber.SizeF = new SizeF(350f, 17f);
		lblVatRegistrationNumber.StylePriority.UseFont = false;
		lblVatRegistrationNumber.StylePriority.UseForeColor = false;
		lblVatRegistrationNumber.StylePriority.UseTextAlignment = false;
		lblVatRegistrationNumber.Text = "[VAT_REG_NUMBER]";
		lblVatRegistrationNumber.TextAlignment = TextAlignment.MiddleLeft;
		lblVatRegistrationNumber.WordWrap = false;
		XrLabel5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel5.ForeColor = SystemColors.ControlText;
		XrLabel5.LocationFloat = new PointFloat(0f, 25f);
		XrLabel5.Name = "XrLabel5";
		XrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel5.SizeF = new SizeF(75f, 17f);
		XrLabel5.StylePriority.UseFont = false;
		XrLabel5.StylePriority.UseForeColor = false;
		XrLabel5.StylePriority.UseTextAlignment = false;
		XrLabel5.Text = "VAT Number:";
		XrLabel5.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel5.WordWrap = false;
		GroupFooter1.Controls.AddRange(new XRControl[7] { lblGroup0VatRegistrationNumber, XrLabel2, lblTotalCustomer2, lblHeaderCustomerTotal, lblGroup0AccountReference, lblGroup0CountryCode, lblTotalCustomer1 });
		GroupFooter1.HeightF = 106f;
		GroupFooter1.Level = 1;
		GroupFooter1.Name = "GroupFooter1";
		lblGroup0VatRegistrationNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGroup0VatRegistrationNumber.ForeColor = SystemColors.ControlText;
		lblGroup0VatRegistrationNumber.LocationFloat = new PointFloat(25f, 8f);
		lblGroup0VatRegistrationNumber.Name = "lblGroup0VatRegistrationNumber";
		lblGroup0VatRegistrationNumber.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGroup0VatRegistrationNumber.SizeF = new SizeF(167f, 17f);
		lblGroup0VatRegistrationNumber.StylePriority.UseFont = false;
		lblGroup0VatRegistrationNumber.StylePriority.UseForeColor = false;
		lblGroup0VatRegistrationNumber.StylePriority.UseTextAlignment = false;
		lblGroup0VatRegistrationNumber.Text = "[VAT_REG_NUMBER]";
		lblGroup0VatRegistrationNumber.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup0VatRegistrationNumber.Visible = false;
		lblGroup0VatRegistrationNumber.WordWrap = false;
		XrLabel2.BorderColor = Color.FromArgb(200, 200, 200);
		XrLabel2.Borders = BorderSide.None;
		XrLabel2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel2.ForeColor = SystemColors.ControlText;
		XrLabel2.LocationFloat = new PointFloat(450f, 33f);
		XrLabel2.Name = "XrLabel2";
		XrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel2.SizeF = new SizeF(300f, 23f);
		XrLabel2.StylePriority.UseBorderColor = false;
		XrLabel2.StylePriority.UseBorders = false;
		XrLabel2.StylePriority.UseFont = false;
		XrLabel2.StylePriority.UseForeColor = false;
		XrLabel2.StylePriority.UseTextAlignment = false;
		xRSummary.FormatString = "Group Total Freezers: {0}";
		xRSummary.Func = SummaryFunc.Count;
		XrLabel2.Summary = xRSummary;
		XrLabel2.Text = "Customer Total (Triangular):";
		XrLabel2.TextAlignment = TextAlignment.MiddleLeft;
		lblTotalCustomer2.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 161);
		lblTotalCustomer2.ForeColor = Color.Black;
		lblTotalCustomer2.LocationFloat = new PointFloat(617f, 33f);
		lblTotalCustomer2.Name = "lblTotalCustomer2";
		lblTotalCustomer2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalCustomer2.SizeF = new SizeF(136f, 12f);
		lblTotalCustomer2.StylePriority.UseFont = false;
		lblTotalCustomer2.StylePriority.UseForeColor = false;
		lblTotalCustomer2.StylePriority.UseTextAlignment = false;
		lblTotalCustomer2.TextAlignment = TextAlignment.MiddleRight;
		lblTotalCustomer2.WordWrap = false;
		lblHeaderCustomerTotal.BorderColor = Color.FromArgb(200, 200, 200);
		lblHeaderCustomerTotal.Borders = BorderSide.None;
		lblHeaderCustomerTotal.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		lblHeaderCustomerTotal.ForeColor = SystemColors.ControlText;
		lblHeaderCustomerTotal.LocationFloat = new PointFloat(450f, 8f);
		lblHeaderCustomerTotal.Name = "lblHeaderCustomerTotal";
		lblHeaderCustomerTotal.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblHeaderCustomerTotal.SizeF = new SizeF(300f, 23f);
		lblHeaderCustomerTotal.StylePriority.UseBorderColor = false;
		lblHeaderCustomerTotal.StylePriority.UseBorders = false;
		lblHeaderCustomerTotal.StylePriority.UseFont = false;
		lblHeaderCustomerTotal.StylePriority.UseForeColor = false;
		lblHeaderCustomerTotal.StylePriority.UseTextAlignment = false;
		xRSummary2.FormatString = "Group Total Freezers: {0}";
		xRSummary2.Func = SummaryFunc.Count;
		lblHeaderCustomerTotal.Summary = xRSummary2;
		lblHeaderCustomerTotal.Text = "Customer Total (Normal):";
		lblHeaderCustomerTotal.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup0AccountReference.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGroup0AccountReference.ForeColor = SystemColors.ControlText;
		lblGroup0AccountReference.LocationFloat = new PointFloat(192f, 8f);
		lblGroup0AccountReference.Name = "lblGroup0AccountReference";
		lblGroup0AccountReference.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGroup0AccountReference.SizeF = new SizeF(125f, 17f);
		lblGroup0AccountReference.StylePriority.UseFont = false;
		lblGroup0AccountReference.StylePriority.UseForeColor = false;
		lblGroup0AccountReference.StylePriority.UseTextAlignment = false;
		lblGroup0AccountReference.Text = "[ACCOUNT_REF]";
		lblGroup0AccountReference.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup0AccountReference.Visible = false;
		lblGroup0AccountReference.WordWrap = false;
		lblGroup0CountryCode.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGroup0CountryCode.ForeColor = SystemColors.ControlText;
		lblGroup0CountryCode.LocationFloat = new PointFloat(25f, 33f);
		lblGroup0CountryCode.Name = "lblGroup0CountryCode";
		lblGroup0CountryCode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGroup0CountryCode.SizeF = new SizeF(167f, 17f);
		lblGroup0CountryCode.StylePriority.UseFont = false;
		lblGroup0CountryCode.StylePriority.UseForeColor = false;
		lblGroup0CountryCode.StylePriority.UseTextAlignment = false;
		lblGroup0CountryCode.Text = "[COUNTRY_CODE]";
		lblGroup0CountryCode.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup0CountryCode.Visible = false;
		lblGroup0CountryCode.WordWrap = false;
		lblTotalCustomer1.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 161);
		lblTotalCustomer1.ForeColor = Color.Black;
		lblTotalCustomer1.LocationFloat = new PointFloat(617f, 8f);
		lblTotalCustomer1.Name = "lblTotalCustomer1";
		lblTotalCustomer1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalCustomer1.SizeF = new SizeF(136f, 12f);
		lblTotalCustomer1.StylePriority.UseFont = false;
		lblTotalCustomer1.StylePriority.UseForeColor = false;
		lblTotalCustomer1.StylePriority.UseTextAlignment = false;
		lblTotalCustomer1.TextAlignment = TextAlignment.MiddleRight;
		lblTotalCustomer1.WordWrap = false;
		lblTotalVAT1.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 161);
		lblTotalVAT1.ForeColor = Color.Black;
		lblTotalVAT1.LocationFloat = new PointFloat(617f, 3f);
		lblTotalVAT1.Name = "lblTotalVAT1";
		lblTotalVAT1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalVAT1.SizeF = new SizeF(136f, 12f);
		lblTotalVAT1.StylePriority.UseFont = false;
		lblTotalVAT1.StylePriority.UseForeColor = false;
		lblTotalVAT1.StylePriority.UseTextAlignment = false;
		lblTotalVAT1.Text = "[GROSS_AMOUNT]";
		lblTotalVAT1.TextAlignment = TextAlignment.MiddleRight;
		lblTotalVAT1.WordWrap = false;
		XrLine1.BackColor = Color.Transparent;
		XrLine1.BorderColor = SystemColors.ControlText;
		XrLine1.Borders = BorderSide.Left;
		XrLine1.ForeColor = Color.LightGray;
		XrLine1.LocationFloat = new PointFloat(0f, 8f);
		XrLine1.Name = "XrLine1";
		XrLine1.SizeF = new SizeF(100f, 25f);
		XrLine1.StylePriority.UseBackColor = false;
		XrLine1.StylePriority.UseBorderColor = false;
		XrLine1.StylePriority.UseBorders = false;
		XrLine1.StylePriority.UseForeColor = false;
		XrLine1.Visible = false;
		lblGroup1VatRegistrationNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGroup1VatRegistrationNumber.ForeColor = SystemColors.ControlText;
		lblGroup1VatRegistrationNumber.LocationFloat = new PointFloat(25f, 8f);
		lblGroup1VatRegistrationNumber.Name = "lblGroup1VatRegistrationNumber";
		lblGroup1VatRegistrationNumber.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGroup1VatRegistrationNumber.SizeF = new SizeF(167f, 17f);
		lblGroup1VatRegistrationNumber.StylePriority.UseFont = false;
		lblGroup1VatRegistrationNumber.StylePriority.UseForeColor = false;
		lblGroup1VatRegistrationNumber.StylePriority.UseTextAlignment = false;
		lblGroup1VatRegistrationNumber.Text = "[VAT_REG_NUMBER]";
		lblGroup1VatRegistrationNumber.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup1VatRegistrationNumber.Visible = false;
		lblGroup1VatRegistrationNumber.WordWrap = false;
		lblHeaderVATTotal1.BorderColor = Color.DarkGray;
		lblHeaderVATTotal1.Borders = BorderSide.None;
		lblHeaderVATTotal1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		lblHeaderVATTotal1.ForeColor = SystemColors.ControlText;
		lblHeaderVATTotal1.LocationFloat = new PointFloat(450f, 0f);
		lblHeaderVATTotal1.Name = "lblHeaderVATTotal1";
		lblHeaderVATTotal1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblHeaderVATTotal1.SizeF = new SizeF(300f, 23f);
		lblHeaderVATTotal1.StylePriority.UseBorderColor = false;
		lblHeaderVATTotal1.StylePriority.UseBorders = false;
		lblHeaderVATTotal1.StylePriority.UseFont = false;
		lblHeaderVATTotal1.StylePriority.UseForeColor = false;
		lblHeaderVATTotal1.StylePriority.UseTextAlignment = false;
		xRSummary3.FormatString = "Group Total Freezers: {0}";
		xRSummary3.Func = SummaryFunc.Count;
		lblHeaderVATTotal1.Summary = xRSummary3;
		lblHeaderVATTotal1.Text = "VAT Total (Normal):";
		lblHeaderVATTotal1.TextAlignment = TextAlignment.MiddleLeft;
		lblTotalVAT2.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 161);
		lblTotalVAT2.ForeColor = Color.Black;
		lblTotalVAT2.LocationFloat = new PointFloat(617f, 30f);
		lblTotalVAT2.Name = "lblTotalVAT2";
		lblTotalVAT2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalVAT2.SizeF = new SizeF(136f, 12f);
		lblTotalVAT2.StylePriority.UseFont = false;
		lblTotalVAT2.StylePriority.UseForeColor = false;
		lblTotalVAT2.StylePriority.UseTextAlignment = false;
		lblTotalVAT2.Text = "[GROSS_AMOUNT]";
		lblTotalVAT2.TextAlignment = TextAlignment.MiddleRight;
		lblTotalVAT2.WordWrap = false;
		lblHeaderVATTotal2.BorderColor = Color.DarkGray;
		lblHeaderVATTotal2.Borders = BorderSide.None;
		lblHeaderVATTotal2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		lblHeaderVATTotal2.ForeColor = SystemColors.ControlText;
		lblHeaderVATTotal2.LocationFloat = new PointFloat(450f, 27f);
		lblHeaderVATTotal2.Name = "lblHeaderVATTotal2";
		lblHeaderVATTotal2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblHeaderVATTotal2.SizeF = new SizeF(300f, 23f);
		lblHeaderVATTotal2.StylePriority.UseBorderColor = false;
		lblHeaderVATTotal2.StylePriority.UseBorders = false;
		lblHeaderVATTotal2.StylePriority.UseFont = false;
		lblHeaderVATTotal2.StylePriority.UseForeColor = false;
		lblHeaderVATTotal2.StylePriority.UseTextAlignment = false;
		xRSummary4.FormatString = "Group Total Freezers: {0}";
		xRSummary4.Func = SummaryFunc.Count;
		lblHeaderVATTotal2.Summary = xRSummary4;
		lblHeaderVATTotal2.Text = "VAT Total (Triangular):";
		lblHeaderVATTotal2.TextAlignment = TextAlignment.MiddleLeft;
		lblTotalVAT.Font = new Font("Tahoma", 8.25f, FontStyle.Underline, GraphicsUnit.Point, 161);
		lblTotalVAT.ForeColor = Color.Black;
		lblTotalVAT.LocationFloat = new PointFloat(617f, 70f);
		lblTotalVAT.Name = "lblTotalVAT";
		lblTotalVAT.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblTotalVAT.SizeF = new SizeF(136f, 12f);
		lblTotalVAT.StylePriority.UseFont = false;
		lblTotalVAT.StylePriority.UseForeColor = false;
		lblTotalVAT.StylePriority.UseTextAlignment = false;
		lblTotalVAT.Text = "[GROSS_AMOUNT]";
		lblTotalVAT.TextAlignment = TextAlignment.MiddleRight;
		lblTotalVAT.WordWrap = false;
		XrLabel6.BorderColor = Color.DarkGray;
		XrLabel6.Borders = BorderSide.Top | BorderSide.Bottom;
		XrLabel6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 161);
		XrLabel6.ForeColor = SystemColors.ControlText;
		XrLabel6.LocationFloat = new PointFloat(450f, 67f);
		XrLabel6.Name = "XrLabel6";
		XrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel6.SizeF = new SizeF(300f, 23f);
		XrLabel6.StylePriority.UseBorderColor = false;
		XrLabel6.StylePriority.UseBorders = false;
		XrLabel6.StylePriority.UseFont = false;
		XrLabel6.StylePriority.UseForeColor = false;
		XrLabel6.StylePriority.UseTextAlignment = false;
		xRSummary5.FormatString = "Group Total Freezers: {0}";
		xRSummary5.Func = SummaryFunc.Count;
		XrLabel6.Summary = xRSummary5;
		XrLabel6.Text = "VAT Total:";
		XrLabel6.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup1CountryCode.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGroup1CountryCode.ForeColor = SystemColors.ControlText;
		lblGroup1CountryCode.LocationFloat = new PointFloat(25f, 25f);
		lblGroup1CountryCode.Name = "lblGroup1CountryCode";
		lblGroup1CountryCode.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGroup1CountryCode.SizeF = new SizeF(167f, 17f);
		lblGroup1CountryCode.StylePriority.UseFont = false;
		lblGroup1CountryCode.StylePriority.UseForeColor = false;
		lblGroup1CountryCode.StylePriority.UseTextAlignment = false;
		lblGroup1CountryCode.Text = "[COUNTRY_CODE]";
		lblGroup1CountryCode.TextAlignment = TextAlignment.MiddleLeft;
		lblGroup1CountryCode.Visible = false;
		lblGroup1CountryCode.WordWrap = false;
		ReportFooter.HeightF = 6f;
		ReportFooter.Name = "ReportFooter";
		ReportHeader.HeightF = 0f;
		ReportHeader.Name = "ReportHeader";
		XrControlStyle1.BackColor = Color.FromArgb(224, 224, 224);
		XrControlStyle1.Name = "XrControlStyle1";
		XrControlStyle1.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		XrControlStyle2.BackColor = Color.Transparent;
		XrControlStyle2.Name = "XrControlStyle2";
		XrControlStyle2.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		XrControlStyle3.Name = "XrControlStyle3";
		XrControlStyle3.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
		GroupHeader2.Controls.AddRange(new XRControl[2] { lblGoodsServices, XrLabel8 });
		GroupHeader2.HeightF = 32f;
		GroupHeader2.Name = "GroupHeader2";
		lblGoodsServices.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		lblGoodsServices.ForeColor = SystemColors.ControlText;
		lblGoodsServices.LocationFloat = new PointFloat(75f, 8f);
		lblGoodsServices.Name = "lblGoodsServices";
		lblGoodsServices.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		lblGoodsServices.SizeF = new SizeF(350f, 17f);
		lblGoodsServices.StylePriority.UseFont = false;
		lblGoodsServices.StylePriority.UseForeColor = false;
		lblGoodsServices.StylePriority.UseTextAlignment = false;
		lblGoodsServices.Text = "[GOODS_SERVICES_TEXT]";
		lblGoodsServices.TextAlignment = TextAlignment.MiddleLeft;
		lblGoodsServices.WordWrap = false;
		XrLabel8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel8.ForeColor = SystemColors.ControlText;
		XrLabel8.LocationFloat = new PointFloat(8f, 8f);
		XrLabel8.Name = "XrLabel8";
		XrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel8.SizeF = new SizeF(75f, 17f);
		XrLabel8.StylePriority.UseFont = false;
		XrLabel8.StylePriority.UseForeColor = false;
		XrLabel8.StylePriority.UseTextAlignment = false;
		XrLabel8.Text = "Type:";
		XrLabel8.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel8.WordWrap = false;
		GroupHeader0.Controls.AddRange(new XRControl[5] { XrLabel5, lblVatRegistrationNumber, XrLabel3, lblCountryCode, XrLabel12 });
		GroupHeader0.HeightF = 50f;
		GroupHeader0.Level = 2;
		GroupHeader0.Name = "GroupHeader0";
		XrLabel12.BackColor = Color.FromArgb(250, 250, 250);
		XrLabel12.BorderColor = Color.FromArgb(200, 200, 200);
		XrLabel12.Borders = BorderSide.Top | BorderSide.Bottom;
		XrLabel12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 161);
		XrLabel12.ForeColor = SystemColors.ControlText;
		XrLabel12.LocationFloat = new PointFloat(0f, 17f);
		XrLabel12.Name = "XrLabel12";
		XrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
		XrLabel12.SizeF = new SizeF(753f, 33f);
		XrLabel12.StylePriority.UseBackColor = false;
		XrLabel12.StylePriority.UseBorderColor = false;
		XrLabel12.StylePriority.UseBorders = false;
		XrLabel12.StylePriority.UseFont = false;
		XrLabel12.StylePriority.UseForeColor = false;
		XrLabel12.StylePriority.UseTextAlignment = false;
		XrLabel12.TextAlignment = TextAlignment.MiddleLeft;
		XrLabel12.WordWrap = false;
		GroupFooter0.HeightF = 17f;
		GroupFooter0.Name = "GroupFooter0";
		GroupFooter2.Controls.AddRange(new XRControl[9] { XrLine1, XrLabel6, lblTotalVAT, lblHeaderVATTotal2, lblTotalVAT2, lblHeaderVATTotal1, lblGroup1VatRegistrationNumber, lblGroup1CountryCode, lblTotalVAT1 });
		GroupFooter2.HeightF = 93f;
		GroupFooter2.Level = 2;
		GroupFooter2.Name = "GroupFooter2";
		TopMarginBand1.HeightF = 32f;
		TopMarginBand1.Name = "TopMarginBand1";
		base.Bands.AddRange(new Band[12]
		{
			Detail, PageHeader, BottomMargin, GroupHeader1, GroupFooter1, ReportFooter, ReportHeader, GroupHeader2, GroupHeader0, GroupFooter0,
			GroupFooter2, TopMarginBand1
		});
		base.Font = new Font("Tahoma", 9.75f);
		base.Margins = new Margins(35, 35, 32, 65);
		base.PageHeight = 1169;
		base.PageWidth = 827;
		base.PaperKind = PaperKind.A4;
		base.StyleSheet.AddRange(new XRControlStyle[3] { XrControlStyle1, XrControlStyle2, XrControlStyle3 });
		base.Version = "10.1";
		((ISupportInitialize)this).EndInit();
	}

	/// <summary>
	/// Constructor
	/// </summary>
	/// <remarks></remarks>
	public rptVIESAnalysis()
	{
		InitializeComponent();
		base.Name = "VAT_Analysis_Form";
	}

	/// <summary>
	/// Initialize Group By
	/// </summary>
	/// <remarks></remarks>
	public void InitializeGroupingSorting()
	{
		((DataTable)base.DataSource).DefaultView.Sort = "[DATE_ENTERED] ASC";
		GroupHeader0.GroupFields.Add(new GroupField("VAT_REG_NUMBER"));
		GroupHeader0.GroupFields.Add(new GroupField("COUNTRY_CODE"));
		GroupHeader1.GroupFields.Add(new GroupField("ACCOUNT_REF"));
		GroupHeader2.GroupFields.Add(new GroupField("GOODS_SERVICES_TEXT"));
		Detail.SortFields.Add(new GroupField("TRAN_DATE"));
	}

	/// <summary>
	/// Before print
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void lblAmount_BeforePrint(object sender, PrintEventArgs e)
	{
		if (!string.IsNullOrEmpty(((XRLabel)sender).Text))
		{
			decimal num = Convert.ToDecimal(((XRLabel)sender).Text);
			((XRLabel)sender).Text = num.ToString("0.00");
		}
	}

	/// <summary>
	/// Before print
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <remarks></remarks>
	private void lblTransactionDate_BeforePrint(object sender, PrintEventArgs e)
	{
		if (!string.IsNullOrEmpty(((XRLabel)sender).Text))
		{
			((XRLabel)sender).Text = Convert.ToDateTime(((XRLabel)sender).Text).ToShortDateString();
		}
	}

	private void lblTotalCustomer1_BeforePrint(object sender, PrintEventArgs e)
	{
		DataTable dataTable = (DataTable)base.DataSource;
		string filter = $"ACCOUNT_REF = '{lblGroup0AccountReference.Text}' AND VAT_REG_NUMBER = '{lblVatRegistrationNumber.Text}' AND COUNTRY_CODE = '{lblCountryCode.Text}' AND EU_MEMBER=1 AND IS_TRIANGULAR=0";
		decimal num;
		try
		{
			num = Conversions.ToDecimal(dataTable.Compute("sum(NET_AMOUNT)", filter));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = default(decimal);
			ProjectData.ClearProjectError();
		}
		lblTotalCustomer1.Text = num.ToString("0.00");
	}

	private void lblTotalCustomer2_BeforePrint(object sender, PrintEventArgs e)
	{
		DataTable dataTable = (DataTable)base.DataSource;
		string filter = $"ACCOUNT_REF = '{lblGroup0AccountReference.Text}' AND VAT_REG_NUMBER = '{lblVatRegistrationNumber.Text}' AND COUNTRY_CODE = '{lblCountryCode.Text}' AND EU_MEMBER=1 AND IS_TRIANGULAR=1";
		decimal num;
		try
		{
			num = Conversions.ToDecimal(dataTable.Compute("sum(NET_AMOUNT)", filter));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = default(decimal);
			ProjectData.ClearProjectError();
		}
		lblTotalCustomer2.Text = num.ToString("0.00");
	}

	private void lblTotalVAT1_BeforePrint(object sender, PrintEventArgs e)
	{
		DataTable dataTable = (DataTable)base.DataSource;
		string filter = $" VAT_REG_NUMBER = '{lblVatRegistrationNumber.Text}' AND COUNTRY_CODE = '{lblCountryCode.Text}' AND EU_MEMBER=1 AND IS_TRIANGULAR=0";
		decimal num;
		try
		{
			num = Conversions.ToDecimal(dataTable.Compute("sum(NET_AMOUNT)", filter));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = default(decimal);
			ProjectData.ClearProjectError();
		}
		lblTotalVAT1.Text = num.ToString("0.00");
	}

	private void lblTotalVAT2_BeforePrint(object sender, PrintEventArgs e)
	{
		DataTable dataTable = (DataTable)base.DataSource;
		string filter = $" VAT_REG_NUMBER = '{lblVatRegistrationNumber.Text}' AND COUNTRY_CODE = '{lblCountryCode.Text}' AND EU_MEMBER=1 AND IS_TRIANGULAR=1";
		decimal num;
		try
		{
			num = Conversions.ToDecimal(dataTable.Compute("sum(NET_AMOUNT)", filter));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = default(decimal);
			ProjectData.ClearProjectError();
		}
		lblTotalVAT2.Text = num.ToString("0.00");
	}

	private void lblTotalVAT_BeforePrint(object sender, PrintEventArgs e)
	{
		DataTable dataTable = (DataTable)base.DataSource;
		string filter = $" VAT_REG_NUMBER = '{lblVatRegistrationNumber.Text}' AND COUNTRY_CODE = '{lblCountryCode.Text}' AND EU_MEMBER=1";
		decimal num;
		try
		{
			num = Conversions.ToDecimal(dataTable.Compute("sum(NET_AMOUNT)", filter));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			num = default(decimal);
			ProjectData.ClearProjectError();
		}
		lblTotalVAT.Text = num.ToString("0.00");
	}

	private void lblHeaderCustomerTotal_BeforePrint(object sender, PrintEventArgs e)
	{
		if (lblGoodsServices.Text.ToLower().Contains("service"))
		{
			lblGoodsServices.Text = "Customer Services Total (Normal):";
		}
		else
		{
			lblGoodsServices.Text = "Customer Goods Total (Normal):";
		}
	}

	private void XrLabel2_BeforePrint(object sender, PrintEventArgs e)
	{
		if (lblGoodsServices.Text.ToLower().Contains("service"))
		{
			lblGoodsServices.Text = "Customer Services Total (Triangular):";
		}
		else
		{
			lblGoodsServices.Text = "Customer Goods Total (Triangular):";
		}
	}

	private void lblITriangular_BeforePrint(object sender, PrintEventArgs e)
	{
		lblTriangular.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(lblTriangular.Text.ToLower(), "true", TextCompare: false) == 0, "Y", "N"));
	}

	private void lblAccountRef_BeforePrint(object sender, PrintEventArgs e)
	{
		lblAccountRef.Text = lblAccountNameHidden.Text + " (" + lblAccountRef.Text + ")";
	}
}
