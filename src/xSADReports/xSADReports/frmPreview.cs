using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;
using DevExpress.XtraWizard;
using Microsoft.VisualBasic.CompilerServices;

namespace xSADReports;

[DesignerGenerated]
public class frmPreview : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("btnExport")]
	private BarButtonItem _btnExport;

	[CompilerGenerated]
	[AccessedThroughProperty("btnExportToPDF2")]
	private BarButtonItem _btnExportToPDF2;

	[CompilerGenerated]
	[AccessedThroughProperty("btnExportToCSV2")]
	private BarButtonItem _btnExportToCSV2;

	public bool DisableNotification;

	private bool _DisplayNotification;

	[field: AccessedThroughProperty("PrintPreview")]
	internal virtual PrintControl PrintPreview
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintBarManager1")]
	internal virtual PrintBarManager PrintBarManager1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PreviewBar1")]
	internal virtual PreviewBar PreviewBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem8")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem9")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem11")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem15")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ZoomBarEditItem1")]
	internal virtual ZoomBarEditItem ZoomBarEditItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewRepositoryItemComboBox1")]
	internal virtual PrintPreviewRepositoryItemComboBox PrintPreviewRepositoryItemComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem16")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem17")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem18")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem18
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem19")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem19
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem20")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem20
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("btnExport1")]
	internal virtual PrintPreviewBarItem btnExport1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PreviewBar2")]
	internal virtual PreviewBar PreviewBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewStaticItem1")]
	internal virtual PrintPreviewStaticItem PrintPreviewStaticItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BarStaticItem1")]
	internal virtual BarStaticItem BarStaticItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBarEditItem1")]
	internal virtual ProgressBarEditItem ProgressBarEditItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RepositoryItemProgressBar1")]
	internal virtual RepositoryItemProgressBar RepositoryItemProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem1")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BarButtonItem1")]
	internal virtual BarButtonItem BarButtonItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewStaticItem2")]
	internal virtual PrintPreviewStaticItem PrintPreviewStaticItem2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barDockControlTop")]
	internal virtual BarDockControl barDockControlTop
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barDockControlBottom")]
	internal virtual BarDockControl barDockControlBottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barDockControlLeft")]
	internal virtual BarDockControl barDockControlLeft
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("barDockControlRight")]
	internal virtual BarDockControl barDockControlRight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewSubItem1")]
	internal virtual PrintPreviewSubItem PrintPreviewSubItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewSubItem2")]
	internal virtual PrintPreviewSubItem PrintPreviewSubItem2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewSubItem4")]
	internal virtual PrintPreviewSubItem PrintPreviewSubItem4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem27")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem27
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarItem28")]
	internal virtual PrintPreviewBarItem PrintPreviewBarItem28
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BarToolbarsListItem1")]
	internal virtual BarToolbarsListItem BarToolbarsListItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewSubItem3")]
	internal virtual PrintPreviewSubItem PrintPreviewSubItem3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem1")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem2")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem3")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem4")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem5")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem6")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem7")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem8")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem9")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem10")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem11")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem12")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem13")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem13
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem14")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem15")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem16")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PrintPreviewBarCheckItem17")]
	internal virtual PrintPreviewBarCheckItem PrintPreviewBarCheckItem17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BarButtonItem btnExport
	{
		[CompilerGenerated]
		get
		{
			return _btnExport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ItemClickEventHandler value2 = btnExport_ItemClick;
			BarButtonItem barButtonItem = _btnExport;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick -= value2;
			}
			_btnExport = value;
			barButtonItem = _btnExport;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick += value2;
			}
		}
	}

	[field: AccessedThroughProperty("WizardControl1")]
	internal virtual WizardControl WizardControl1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WelcomeWizardPage1")]
	internal virtual WelcomeWizardPage WelcomeWizardPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("WizardPage1")]
	internal virtual DevExpress.XtraWizard.WizardPage WizardPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CompletionWizardPage1")]
	internal virtual CompletionWizardPage CompletionWizardPage1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PopupMenu1")]
	internal virtual PopupMenu PopupMenu1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual BarButtonItem btnExportToPDF2
	{
		[CompilerGenerated]
		get
		{
			return _btnExportToPDF2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ItemClickEventHandler value2 = btnExportToPDF_ItemClick;
			BarButtonItem barButtonItem = _btnExportToPDF2;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick -= value2;
			}
			_btnExportToPDF2 = value;
			barButtonItem = _btnExportToPDF2;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick += value2;
			}
		}
	}

	internal virtual BarButtonItem btnExportToCSV2
	{
		[CompilerGenerated]
		get
		{
			return _btnExportToCSV2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ItemClickEventHandler value2 = btnExportToCSV2_ItemClick;
			BarButtonItem barButtonItem = _btnExportToCSV2;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick -= value2;
			}
			_btnExportToCSV2 = value;
			barButtonItem = _btnExportToCSV2;
			if (barButtonItem != null)
			{
				barButtonItem.ItemClick += value2;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSADReports.frmPreview));
		this.PrintPreview = new DevExpress.XtraPrinting.Control.PrintControl();
		this.PrintBarManager1 = new DevExpress.XtraPrinting.Preview.PrintBarManager();
		this.PreviewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
		this.PrintPreviewBarItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.ZoomBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
		this.PrintPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
		this.PrintPreviewBarItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.btnExport1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.btnExport = new DevExpress.XtraBars.BarButtonItem();
		this.PopupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
		this.btnExportToPDF2 = new DevExpress.XtraBars.BarButtonItem();
		this.btnExportToCSV2 = new DevExpress.XtraBars.BarButtonItem();
		this.PreviewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
		this.PrintPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
		this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
		this.ProgressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
		this.RepositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
		this.PrintPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
		this.PrintPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
		this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
		this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
		this.PrintPreviewSubItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewSubItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewSubItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewBarItem27 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.PrintPreviewBarItem28 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
		this.BarToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
		this.PrintPreviewSubItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
		this.PrintPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.PrintPreviewBarCheckItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
		this.WizardControl1 = new DevExpress.XtraWizard.WizardControl();
		this.WelcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
		this.WizardPage1 = new DevExpress.XtraWizard.WizardPage();
		this.CompletionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
		((System.ComponentModel.ISupportInitialize)this.PrintBarManager1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PopupMenu1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemProgressBar1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.WizardControl1).BeginInit();
		this.WizardControl1.SuspendLayout();
		base.SuspendLayout();
		this.PrintPreview.BackColor = System.Drawing.Color.Empty;
		this.PrintPreview.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PrintPreview.ForeColor = System.Drawing.Color.Empty;
		this.PrintPreview.IsMetric = true;
		this.PrintPreview.Location = new System.Drawing.Point(0, 26);
		this.PrintPreview.Name = "PrintPreview";
		this.PrintPreview.Size = new System.Drawing.Size(1016, 686);
		this.PrintPreview.TabIndex = 4;
		this.PrintPreview.TooltipFont = new System.Drawing.Font("Tahoma", 8.25f);
		this.PrintBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[2] { this.PreviewBar1, this.PreviewBar2 });
		this.PrintBarManager1.DockControls.Add(this.barDockControlTop);
		this.PrintBarManager1.DockControls.Add(this.barDockControlBottom);
		this.PrintBarManager1.DockControls.Add(this.barDockControlLeft);
		this.PrintBarManager1.DockControls.Add(this.barDockControlRight);
		this.PrintBarManager1.Form = this;
		this.PrintBarManager1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("PrintBarManager1.ImageStream");
		this.PrintBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[44]
		{
			this.PrintPreviewStaticItem1, this.BarStaticItem1, this.ProgressBarEditItem1, this.PrintPreviewBarItem1, this.BarButtonItem1, this.PrintPreviewStaticItem2, this.PrintPreviewBarItem8, this.PrintPreviewBarItem9, this.PrintPreviewBarItem11, this.PrintPreviewBarItem15,
			this.ZoomBarEditItem1, this.PrintPreviewBarItem16, this.PrintPreviewBarItem17, this.PrintPreviewBarItem18, this.PrintPreviewBarItem19, this.PrintPreviewBarItem20, this.btnExport1, this.PrintPreviewSubItem1, this.PrintPreviewSubItem2, this.PrintPreviewSubItem3,
			this.PrintPreviewSubItem4, this.PrintPreviewBarItem27, this.PrintPreviewBarItem28, this.BarToolbarsListItem1, this.PrintPreviewBarCheckItem1, this.PrintPreviewBarCheckItem2, this.PrintPreviewBarCheckItem3, this.PrintPreviewBarCheckItem4, this.PrintPreviewBarCheckItem5, this.PrintPreviewBarCheckItem6,
			this.PrintPreviewBarCheckItem7, this.PrintPreviewBarCheckItem8, this.PrintPreviewBarCheckItem9, this.PrintPreviewBarCheckItem10, this.PrintPreviewBarCheckItem11, this.PrintPreviewBarCheckItem12, this.PrintPreviewBarCheckItem13, this.PrintPreviewBarCheckItem14, this.PrintPreviewBarCheckItem15, this.PrintPreviewBarCheckItem16,
			this.PrintPreviewBarCheckItem17, this.btnExport, this.btnExportToPDF2, this.btnExportToCSV2
		});
		this.PrintBarManager1.MaxItemId = 62;
		this.PrintBarManager1.PreviewBar = this.PreviewBar1;
		this.PrintBarManager1.PrintControl = this.PrintPreview;
		this.PrintBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[2] { this.RepositoryItemProgressBar1, this.PrintPreviewRepositoryItemComboBox1 });
		this.PrintBarManager1.StatusBar = this.PreviewBar2;
		this.PreviewBar1.BarName = "Toolbar";
		this.PreviewBar1.DockCol = 0;
		this.PreviewBar1.DockRow = 0;
		this.PreviewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
		this.PreviewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[12]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem11),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem15, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.ZoomBarEditItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem16),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem17, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem18),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem19),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem20),
			new DevExpress.XtraBars.LinkPersistInfo(this.btnExport1, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.btnExport)
		});
		this.PreviewBar1.Text = "Toolbar";
		this.PrintPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem8.Caption = "&Print...";
		this.PrintPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
		this.PrintPreviewBarItem8.Enabled = false;
		this.PrintPreviewBarItem8.Hint = "Print";
		this.PrintPreviewBarItem8.Id = 12;
		this.PrintPreviewBarItem8.ImageIndex = 0;
		this.PrintPreviewBarItem8.Name = "PrintPreviewBarItem8";
		this.PrintPreviewBarItem9.Caption = "P&rint";
		this.PrintPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
		this.PrintPreviewBarItem9.Enabled = false;
		this.PrintPreviewBarItem9.Hint = "Quick Print";
		this.PrintPreviewBarItem9.Id = 13;
		this.PrintPreviewBarItem9.ImageIndex = 1;
		this.PrintPreviewBarItem9.Name = "PrintPreviewBarItem9";
		this.PrintPreviewBarItem11.Caption = "Header And Footer";
		this.PrintPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
		this.PrintPreviewBarItem11.Enabled = false;
		this.PrintPreviewBarItem11.Hint = "Header And Footer";
		this.PrintPreviewBarItem11.Id = 15;
		this.PrintPreviewBarItem11.ImageIndex = 15;
		this.PrintPreviewBarItem11.Name = "PrintPreviewBarItem11";
		this.PrintPreviewBarItem15.Caption = "Zoom Out";
		this.PrintPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
		this.PrintPreviewBarItem15.Enabled = false;
		this.PrintPreviewBarItem15.Hint = "Zoom Out";
		this.PrintPreviewBarItem15.Id = 19;
		this.PrintPreviewBarItem15.ImageIndex = 5;
		this.PrintPreviewBarItem15.Name = "PrintPreviewBarItem15";
		this.ZoomBarEditItem1.Caption = "Zoom";
		this.ZoomBarEditItem1.Edit = this.PrintPreviewRepositoryItemComboBox1;
		this.ZoomBarEditItem1.EditValue = "100%";
		this.ZoomBarEditItem1.Enabled = false;
		this.ZoomBarEditItem1.Hint = "Zoom";
		this.ZoomBarEditItem1.Id = 20;
		this.ZoomBarEditItem1.Name = "ZoomBarEditItem1";
		this.ZoomBarEditItem1.Width = 70;
		this.PrintPreviewRepositoryItemComboBox1.AutoComplete = false;
		this.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[1]
		{
			new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
		});
		this.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11;
		this.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1";
		this.PrintPreviewBarItem16.Caption = "Zoom In";
		this.PrintPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
		this.PrintPreviewBarItem16.Enabled = false;
		this.PrintPreviewBarItem16.Hint = "Zoom In";
		this.PrintPreviewBarItem16.Id = 21;
		this.PrintPreviewBarItem16.ImageIndex = 4;
		this.PrintPreviewBarItem16.Name = "PrintPreviewBarItem16";
		this.PrintPreviewBarItem17.Caption = "First Page";
		this.PrintPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
		this.PrintPreviewBarItem17.Enabled = false;
		this.PrintPreviewBarItem17.Hint = "First Page";
		this.PrintPreviewBarItem17.Id = 22;
		this.PrintPreviewBarItem17.ImageIndex = 7;
		this.PrintPreviewBarItem17.Name = "PrintPreviewBarItem17";
		this.PrintPreviewBarItem18.Caption = "Previous Page";
		this.PrintPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
		this.PrintPreviewBarItem18.Enabled = false;
		this.PrintPreviewBarItem18.Hint = "Previous Page";
		this.PrintPreviewBarItem18.Id = 23;
		this.PrintPreviewBarItem18.ImageIndex = 8;
		this.PrintPreviewBarItem18.Name = "PrintPreviewBarItem18";
		this.PrintPreviewBarItem19.Caption = "Next Page";
		this.PrintPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
		this.PrintPreviewBarItem19.Enabled = false;
		this.PrintPreviewBarItem19.Hint = "Next Page";
		this.PrintPreviewBarItem19.Id = 24;
		this.PrintPreviewBarItem19.ImageIndex = 9;
		this.PrintPreviewBarItem19.Name = "PrintPreviewBarItem19";
		this.PrintPreviewBarItem20.Caption = "Last Page";
		this.PrintPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
		this.PrintPreviewBarItem20.Enabled = false;
		this.PrintPreviewBarItem20.Hint = "Last Page";
		this.PrintPreviewBarItem20.Id = 25;
		this.PrintPreviewBarItem20.ImageIndex = 10;
		this.PrintPreviewBarItem20.Name = "PrintPreviewBarItem20";
		this.btnExport1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.btnExport1.Caption = "Export Document...";
		this.btnExport1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
		this.btnExport1.Enabled = false;
		this.btnExport1.Hint = "Export Document...";
		this.btnExport1.Id = 29;
		this.btnExport1.ImageIndex = 18;
		this.btnExport1.Name = "btnExport1";
		this.btnExport1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.btnExport.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
		this.btnExport.Caption = "PDF";
		this.btnExport.DropDownControl = this.PopupMenu1;
		this.btnExport.Id = 57;
		this.btnExport.ImageIndex = 18;
		this.btnExport.Name = "btnExport";
		this.PopupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToPDF2),
			new DevExpress.XtraBars.LinkPersistInfo(this.btnExportToCSV2)
		});
		this.PopupMenu1.Manager = this.PrintBarManager1;
		this.PopupMenu1.Name = "PopupMenu1";
		this.btnExportToPDF2.Caption = "Export To PDF";
		this.btnExportToPDF2.Id = 60;
		this.btnExportToPDF2.Name = "btnExportToPDF2";
		this.btnExportToCSV2.Caption = "Export To CSV";
		this.btnExportToCSV2.Id = 61;
		this.btnExportToCSV2.Name = "btnExportToCSV2";
		this.PreviewBar2.BarName = "Status Bar";
		this.PreviewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
		this.PreviewBar2.DockCol = 0;
		this.PreviewBar2.DockRow = 0;
		this.PreviewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
		this.PreviewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[6]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarStaticItem1, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.ProgressBarEditItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarButtonItem1),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem2, true)
		});
		this.PreviewBar2.OptionsBar.AllowQuickCustomization = false;
		this.PreviewBar2.OptionsBar.DrawDragBorder = false;
		this.PreviewBar2.OptionsBar.UseWholeRow = true;
		this.PreviewBar2.Text = "Status Bar";
		this.PrintPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.PrintPreviewStaticItem1.Caption = "Page 0 of 0";
		this.PrintPreviewStaticItem1.Id = 0;
		this.PrintPreviewStaticItem1.LeftIndent = 1;
		this.PrintPreviewStaticItem1.Name = "PrintPreviewStaticItem1";
		this.PrintPreviewStaticItem1.RightIndent = 1;
		this.PrintPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
		this.PrintPreviewStaticItem1.Type = "PageOfPages";
		this.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.BarStaticItem1.Id = 1;
		this.BarStaticItem1.Name = "BarStaticItem1";
		this.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
		this.ProgressBarEditItem1.Edit = this.RepositoryItemProgressBar1;
		this.ProgressBarEditItem1.EditHeight = 12;
		this.ProgressBarEditItem1.Id = 2;
		this.ProgressBarEditItem1.Name = "ProgressBarEditItem1";
		this.ProgressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.ProgressBarEditItem1.Width = 150;
		this.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1";
		this.PrintPreviewBarItem1.Caption = "Stop";
		this.PrintPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
		this.PrintPreviewBarItem1.Enabled = false;
		this.PrintPreviewBarItem1.Hint = "Stop";
		this.PrintPreviewBarItem1.Id = 3;
		this.PrintPreviewBarItem1.Name = "PrintPreviewBarItem1";
		this.PrintPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
		this.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
		this.BarButtonItem1.Enabled = false;
		this.BarButtonItem1.Id = 4;
		this.BarButtonItem1.Name = "BarButtonItem1";
		this.PrintPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
		this.PrintPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
		this.PrintPreviewStaticItem2.Caption = "Zoom Factor: 100%";
		this.PrintPreviewStaticItem2.Id = 5;
		this.PrintPreviewStaticItem2.Name = "PrintPreviewStaticItem2";
		this.PrintPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
		this.PrintPreviewStaticItem2.Type = "ZoomFactor";
		this.PrintPreviewStaticItem2.Width = 40;
		this.PrintPreviewSubItem1.Caption = "&File";
		this.PrintPreviewSubItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
		this.PrintPreviewSubItem1.Id = 32;
		this.PrintPreviewSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[3]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
			new DevExpress.XtraBars.LinkPersistInfo(this.btnExport1, true)
		});
		this.PrintPreviewSubItem1.Name = "PrintPreviewSubItem1";
		this.PrintPreviewSubItem2.Caption = "&View";
		this.PrintPreviewSubItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
		this.PrintPreviewSubItem2.Id = 33;
		this.PrintPreviewSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem4, true),
			new DevExpress.XtraBars.LinkPersistInfo(this.BarToolbarsListItem1, true)
		});
		this.PrintPreviewSubItem2.Name = "PrintPreviewSubItem2";
		this.PrintPreviewSubItem4.Caption = "&Page Layout";
		this.PrintPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
		this.PrintPreviewSubItem4.Id = 35;
		this.PrintPreviewSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[2]
		{
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem27),
			new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem28)
		});
		this.PrintPreviewSubItem4.Name = "PrintPreviewSubItem4";
		this.PrintPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem27.Caption = "&Facing";
		this.PrintPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
		this.PrintPreviewBarItem27.Enabled = false;
		this.PrintPreviewBarItem27.GroupIndex = 100;
		this.PrintPreviewBarItem27.Id = 36;
		this.PrintPreviewBarItem27.Name = "PrintPreviewBarItem27";
		this.PrintPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
		this.PrintPreviewBarItem28.Caption = "&Continuous";
		this.PrintPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
		this.PrintPreviewBarItem28.Enabled = false;
		this.PrintPreviewBarItem28.GroupIndex = 100;
		this.PrintPreviewBarItem28.Id = 37;
		this.PrintPreviewBarItem28.Name = "PrintPreviewBarItem28";
		this.BarToolbarsListItem1.Caption = "Bars";
		this.BarToolbarsListItem1.Id = 38;
		this.BarToolbarsListItem1.Name = "BarToolbarsListItem1";
		this.PrintPreviewSubItem3.Caption = "&Background";
		this.PrintPreviewSubItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background;
		this.PrintPreviewSubItem3.Id = 34;
		this.PrintPreviewSubItem3.Name = "PrintPreviewSubItem3";
		this.PrintPreviewBarCheckItem1.Caption = "PDF File";
		this.PrintPreviewBarCheckItem1.Checked = true;
		this.PrintPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
		this.PrintPreviewBarCheckItem1.Enabled = false;
		this.PrintPreviewBarCheckItem1.GroupIndex = 1;
		this.PrintPreviewBarCheckItem1.Hint = "PDF File";
		this.PrintPreviewBarCheckItem1.Id = 39;
		this.PrintPreviewBarCheckItem1.Name = "PrintPreviewBarCheckItem1";
		this.PrintPreviewBarCheckItem2.Caption = "HTML File";
		this.PrintPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
		this.PrintPreviewBarCheckItem2.Enabled = false;
		this.PrintPreviewBarCheckItem2.GroupIndex = 1;
		this.PrintPreviewBarCheckItem2.Hint = "HTML File";
		this.PrintPreviewBarCheckItem2.Id = 40;
		this.PrintPreviewBarCheckItem2.Name = "PrintPreviewBarCheckItem2";
		this.PrintPreviewBarCheckItem3.Caption = "MHT File";
		this.PrintPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
		this.PrintPreviewBarCheckItem3.Enabled = false;
		this.PrintPreviewBarCheckItem3.GroupIndex = 1;
		this.PrintPreviewBarCheckItem3.Hint = "MHT File";
		this.PrintPreviewBarCheckItem3.Id = 41;
		this.PrintPreviewBarCheckItem3.Name = "PrintPreviewBarCheckItem3";
		this.PrintPreviewBarCheckItem4.Caption = "RTF File";
		this.PrintPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
		this.PrintPreviewBarCheckItem4.Enabled = false;
		this.PrintPreviewBarCheckItem4.GroupIndex = 1;
		this.PrintPreviewBarCheckItem4.Hint = "RTF File";
		this.PrintPreviewBarCheckItem4.Id = 42;
		this.PrintPreviewBarCheckItem4.Name = "PrintPreviewBarCheckItem4";
		this.PrintPreviewBarCheckItem5.Caption = "XLS File";
		this.PrintPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
		this.PrintPreviewBarCheckItem5.Enabled = false;
		this.PrintPreviewBarCheckItem5.GroupIndex = 1;
		this.PrintPreviewBarCheckItem5.Hint = "XLS File";
		this.PrintPreviewBarCheckItem5.Id = 43;
		this.PrintPreviewBarCheckItem5.Name = "PrintPreviewBarCheckItem5";
		this.PrintPreviewBarCheckItem6.Caption = "XLSX File";
		this.PrintPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
		this.PrintPreviewBarCheckItem6.Enabled = false;
		this.PrintPreviewBarCheckItem6.GroupIndex = 1;
		this.PrintPreviewBarCheckItem6.Hint = "XLSX File";
		this.PrintPreviewBarCheckItem6.Id = 44;
		this.PrintPreviewBarCheckItem6.Name = "PrintPreviewBarCheckItem6";
		this.PrintPreviewBarCheckItem7.Caption = "CSV File";
		this.PrintPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
		this.PrintPreviewBarCheckItem7.Enabled = false;
		this.PrintPreviewBarCheckItem7.GroupIndex = 1;
		this.PrintPreviewBarCheckItem7.Hint = "CSV File";
		this.PrintPreviewBarCheckItem7.Id = 45;
		this.PrintPreviewBarCheckItem7.Name = "PrintPreviewBarCheckItem7";
		this.PrintPreviewBarCheckItem8.Caption = "Text File";
		this.PrintPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
		this.PrintPreviewBarCheckItem8.Enabled = false;
		this.PrintPreviewBarCheckItem8.GroupIndex = 1;
		this.PrintPreviewBarCheckItem8.Hint = "Text File";
		this.PrintPreviewBarCheckItem8.Id = 46;
		this.PrintPreviewBarCheckItem8.Name = "PrintPreviewBarCheckItem8";
		this.PrintPreviewBarCheckItem9.Caption = "Image File";
		this.PrintPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
		this.PrintPreviewBarCheckItem9.Enabled = false;
		this.PrintPreviewBarCheckItem9.GroupIndex = 1;
		this.PrintPreviewBarCheckItem9.Hint = "Image File";
		this.PrintPreviewBarCheckItem9.Id = 47;
		this.PrintPreviewBarCheckItem9.Name = "PrintPreviewBarCheckItem9";
		this.PrintPreviewBarCheckItem10.Caption = "PDF File";
		this.PrintPreviewBarCheckItem10.Checked = true;
		this.PrintPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
		this.PrintPreviewBarCheckItem10.Enabled = false;
		this.PrintPreviewBarCheckItem10.GroupIndex = 1;
		this.PrintPreviewBarCheckItem10.Hint = "PDF File";
		this.PrintPreviewBarCheckItem10.Id = 48;
		this.PrintPreviewBarCheckItem10.Name = "PrintPreviewBarCheckItem10";
		this.PrintPreviewBarCheckItem11.Caption = "MHT File";
		this.PrintPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
		this.PrintPreviewBarCheckItem11.Enabled = false;
		this.PrintPreviewBarCheckItem11.GroupIndex = 1;
		this.PrintPreviewBarCheckItem11.Hint = "MHT File";
		this.PrintPreviewBarCheckItem11.Id = 49;
		this.PrintPreviewBarCheckItem11.Name = "PrintPreviewBarCheckItem11";
		this.PrintPreviewBarCheckItem12.Caption = "RTF File";
		this.PrintPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
		this.PrintPreviewBarCheckItem12.Enabled = false;
		this.PrintPreviewBarCheckItem12.GroupIndex = 1;
		this.PrintPreviewBarCheckItem12.Hint = "RTF File";
		this.PrintPreviewBarCheckItem12.Id = 50;
		this.PrintPreviewBarCheckItem12.Name = "PrintPreviewBarCheckItem12";
		this.PrintPreviewBarCheckItem13.Caption = "XLS File";
		this.PrintPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
		this.PrintPreviewBarCheckItem13.Enabled = false;
		this.PrintPreviewBarCheckItem13.GroupIndex = 1;
		this.PrintPreviewBarCheckItem13.Hint = "XLS File";
		this.PrintPreviewBarCheckItem13.Id = 51;
		this.PrintPreviewBarCheckItem13.Name = "PrintPreviewBarCheckItem13";
		this.PrintPreviewBarCheckItem14.Caption = "XLSX File";
		this.PrintPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
		this.PrintPreviewBarCheckItem14.Enabled = false;
		this.PrintPreviewBarCheckItem14.GroupIndex = 1;
		this.PrintPreviewBarCheckItem14.Hint = "XLSX File";
		this.PrintPreviewBarCheckItem14.Id = 52;
		this.PrintPreviewBarCheckItem14.Name = "PrintPreviewBarCheckItem14";
		this.PrintPreviewBarCheckItem15.Caption = "CSV File";
		this.PrintPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
		this.PrintPreviewBarCheckItem15.Enabled = false;
		this.PrintPreviewBarCheckItem15.GroupIndex = 1;
		this.PrintPreviewBarCheckItem15.Hint = "CSV File";
		this.PrintPreviewBarCheckItem15.Id = 53;
		this.PrintPreviewBarCheckItem15.Name = "PrintPreviewBarCheckItem15";
		this.PrintPreviewBarCheckItem16.Caption = "Text File";
		this.PrintPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
		this.PrintPreviewBarCheckItem16.Enabled = false;
		this.PrintPreviewBarCheckItem16.GroupIndex = 1;
		this.PrintPreviewBarCheckItem16.Hint = "Text File";
		this.PrintPreviewBarCheckItem16.Id = 54;
		this.PrintPreviewBarCheckItem16.Name = "PrintPreviewBarCheckItem16";
		this.PrintPreviewBarCheckItem17.Caption = "Image File";
		this.PrintPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
		this.PrintPreviewBarCheckItem17.Enabled = false;
		this.PrintPreviewBarCheckItem17.GroupIndex = 1;
		this.PrintPreviewBarCheckItem17.Hint = "Image File";
		this.PrintPreviewBarCheckItem17.Id = 55;
		this.PrintPreviewBarCheckItem17.Name = "PrintPreviewBarCheckItem17";
		this.WizardControl1.Controls.Add(this.WelcomeWizardPage1);
		this.WizardControl1.Controls.Add(this.WizardPage1);
		this.WizardControl1.Controls.Add(this.CompletionWizardPage1);
		this.WizardControl1.Name = "WizardControl1";
		this.WizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[3] { this.WelcomeWizardPage1, this.WizardPage1, this.CompletionWizardPage1 });
		this.WelcomeWizardPage1.Name = "WelcomeWizardPage1";
		this.WelcomeWizardPage1.Size = new System.Drawing.Size(183, 144);
		this.WizardPage1.Name = "WizardPage1";
		this.WizardPage1.Size = new System.Drawing.Size(368, 155);
		this.CompletionWizardPage1.Name = "CompletionWizardPage1";
		this.CompletionWizardPage1.Size = new System.Drawing.Size(183, 144);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1016, 734);
		base.Controls.Add(this.PrintPreview);
		base.Controls.Add(this.barDockControlLeft);
		base.Controls.Add(this.barDockControlRight);
		base.Controls.Add(this.barDockControlBottom);
		base.Controls.Add(this.barDockControlTop);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "frmPreview";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "VIES Declaration Form";
		((System.ComponentModel.ISupportInitialize)this.PrintBarManager1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PopupMenu1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.RepositoryItemProgressBar1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.WizardControl1).EndInit();
		this.WizardControl1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	/// <summary>
	/// Constructor
	/// </summary>
	/// <remarks></remarks>
	public frmPreview(XtraReport Report, bool DisplayNotification, bool IsAnalysisReport = false)
	{
		base.Shown += frmPreview_Shown;
		InitializeComponent();
		_DisplayNotification = DisplayNotification;
		PrintingSystemCommand[] commands = new PrintingSystemCommand[8]
		{
			PrintingSystemCommand.ExportGraphic,
			PrintingSystemCommand.ExportHtm,
			PrintingSystemCommand.ExportMht,
			PrintingSystemCommand.ExportTxt,
			PrintingSystemCommand.ExportXls,
			PrintingSystemCommand.ExportXlsx,
			PrintingSystemCommand.ExportXps,
			PrintingSystemCommand.ExportCsv
		};
		PrintingSystemCommand[] commands2 = new PrintingSystemCommand[8]
		{
			PrintingSystemCommand.ExportGraphic,
			PrintingSystemCommand.ExportHtm,
			PrintingSystemCommand.ExportMht,
			PrintingSystemCommand.ExportTxt,
			PrintingSystemCommand.ExportXls,
			PrintingSystemCommand.ExportXlsx,
			PrintingSystemCommand.ExportXps,
			PrintingSystemCommand.ExportRtf
		};
		PrintPreview.PrintingSystem = Report.PrintingSystem;
		if (IsAnalysisReport)
		{
			PrintPreview.PrintingSystem.SetCommandVisibility(commands2, CommandVisibility.None);
		}
		else
		{
			PrintPreview.PrintingSystem.SetCommandVisibility(commands, CommandVisibility.None);
		}
		Report.CreateDocument();
		PrintPreview.Show();
		PrintPreview.ShowPageMargins = false;
		PrintPreview.PrintingSystem.ShowMarginsWarning = false;
	}

	private void frmPreview_Shown(object sender, EventArgs e)
	{
		PrintBarManager1.Items.Remove(btnExport1);
	}

	private void btnExportToPDF_ItemClick(object sender, ItemClickEventArgs e)
	{
		using SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
		saveFileDialog.FileName = Text + ".pdf";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			PrintPreview.PrintingSystem.ExportToPdf(saveFileDialog.FileName);
		}
	}

	private void btnExportToCSV2_ItemClick(object sender, ItemClickEventArgs e)
	{
		using SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
		saveFileDialog.FileName = Text + ".csv";
		if (saveFileDialog.ShowDialog() == DialogResult.OK)
		{
			PrintPreview.PrintingSystem.ExportToCsv(saveFileDialog.FileName);
		}
	}

	private void btnExport_ItemClick(object sender, ItemClickEventArgs e)
	{
		btnExportToPDF_ItemClick(null, null);
	}
}
