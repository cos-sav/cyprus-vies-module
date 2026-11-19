using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using xSAD_VAT.GUI;
using xSAD_VIES.BL;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;
using xSAD_VIES.Properties;
using xSageDataObjects;

namespace xSAD_VIES.GUI;

public class frmMain : Form
{
	public Engine SageEngine;

	public static frmMain frmmain;

	private List<SageCompany> companiesList;

	private IContainer components;

	private Button btnMultipleCompanyVATReturns;

	private Button btnVATReturnProcess;

	private Panel panel2;

	private DataGridView gridCompanies;

	private BindingSource companyBindingSource;

	private Button btnGroupVATReturns;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem miTool;

	private ToolStripMenuItem miTools;

	private Label label6;

	private ToolStripMenuItem miPathConfiguration;

	private ToolStripMenuItem miXmlFileChecker;

	private Label label7;

	private TextBox txbFilter;

	private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn SageVATRegistrationNumber;

	private OpenFileDialog ofdSelectXml;

	private ToolStripMenuItem fileToolStripMenuItem;

	private ToolStripMenuItem miExit;

	private GroupBox gbOption1;

	private GroupBox gbOption2;

	private Label label1;

	private GroupBox gbOption3;

	private Label label8;

	private Label label2;

	public frmMain()
	{
		InitializeComponent();
		frmmain = this;
		Service.CheckLicensing();
		Service.CheckDatabase();
		companiesList = xSAD_VIES.DAL.SageController.SelectAllSageCompanies();
		gridCompanies.DataSource = companiesList;
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
	}

	private void btnGroupVATReturns_Click(object sender, EventArgs e)
	{
		frmGroupVATReturn frmGroupVATReturn = new frmGroupVATReturn();
		frmGroupVATReturn.TopMost = base.TopMost;
		frmGroupVATReturn.ShowDialog();
	}

	private void frmVATReturnProcess_Click(object sender, EventArgs e)
	{
		OpenSelectedCompany();
	}

	private void OpenSelectedCompany()
	{
		DataGridViewRow currentRow = gridCompanies.CurrentRow;
		if (currentRow == null)
		{
			return;
		}
		SageCompany sageCompany = (SageCompany)currentRow.DataBoundItem;
		SageEngine = new Engine(sageCompany.SageVersion);
		try
		{
			FrmLogin frmLogin = new FrmLogin(sageCompany);
			frmLogin.TopMost = base.TopMost;
			frmLogin.ShowDialog();
			if (frmLogin.dialogResult == DialogResult.OK)
			{
				sageCompany.SageConnectionString = SageEngine.ConnectionString;
				FrmDeclarationProcess frmDeclarationProcess = new FrmDeclarationProcess(sageCompany);
				frmDeclarationProcess.TopMost = base.TopMost;
				frmDeclarationProcess.ShowDialog();
			}
		}
		finally
		{
			SageEngine.Disconnect();
			SageEngine = null;
		}
	}

	private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1)
		{
			OpenSelectedCompany();
		}
	}

	private void miAbout_Click(object sender, EventArgs e)
	{
		FrmAbout frmAbout = new FrmAbout();
		frmAbout.TopMost = base.TopMost;
		frmAbout.ShowDialog();
	}

	private void txbFilter_TextChanged(object sender, EventArgs e)
	{
		string filterLower = txbFilter.Text.ToLower();
		List<SageCompany> dataSource = companiesList.FindAll((SageCompany c) => c.Name.ToLower().Contains(filterLower) || c.SageVatRegistrationNumber.ToLower().Contains(filterLower));
		gridCompanies.DataSource = dataSource;
	}

	private void miPathConfiguration_Click(object sender, EventArgs e)
	{
		FrmPathConfiguration frmPathConfiguration = new FrmPathConfiguration();
		frmPathConfiguration.TopMost = base.TopMost;
		frmPathConfiguration.ShowDialog();
		companiesList = xSAD_VIES.DAL.SageController.SelectAllSageCompanies();
		gridCompanies.DataSource = companiesList;
	}

	private void miXmlFileChecker_Click(object sender, EventArgs e)
	{
		ofdSelectXml.Filter = "XML files (*.xml)|*.xml";
		ofdSelectXml.FileName = Service.GetUserXmlFolder + "\\*.xml";
		if (ofdSelectXml.ShowDialog() == DialogResult.Cancel)
		{
			return;
		}
		string fileName = ofdSelectXml.FileName;
		if (fileName.ToLower().Contains("multiple"))
		{
			MessageBox.Show("Multi-Company Declaration XML files are not supported by the XML File Checker Utility.", "XML File Checker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		else if (File.Exists(fileName))
		{
			try
			{
				Service.ShowViesSubmissionForm(XmlFuncs.ReadEntityFromXml(fileName), this);
			}
			catch
			{
				MessageBox.Show("Selected XML file is not of a correct format.", "XML File Checker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}

	private void btnMultipleCompanyVATReturns_Click(object sender, EventArgs e)
	{
		frmMultipleCompanyVATReturn frmMultipleCompanyVATReturn = new frmMultipleCompanyVATReturn();
		frmMultipleCompanyVATReturn.TopMost = base.TopMost;
		frmMultipleCompanyVATReturn.ShowDialog();
	}

	private void miTechnicalSupport_Click(object sender, EventArgs e)
	{
		FrmTechSupport frmTechSupport = new FrmTechSupport();
		frmTechSupport.TopMost = base.TopMost;
		frmTechSupport.ShowDialog();
	}

	private void miExit_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Are you sure you want to close the Cyprus VIES application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			Application.Exit();
		}
	}

	private void onlineSubmissionManualToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Documentation\\OnlineSubmissionManual.pdf");
		if (!File.Exists(text))
		{
			MessageBox.Show(Resources.MessageUnableToFindTheOnlineSubmissionManualHelpFile, "Missing File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		try
		{
			Process.Start(text);
		}
		catch (Exception ex)
		{
			if (ex.Message.Contains(Resources.msgNoApplicationAssociated))
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile1, "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile2 + ex.Message + "\n\r\n\r\n\rPlease contact support.", "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	private void frmMain_Shown(object sender, EventArgs e)
	{
		if (companiesList.Count == 0)
		{
			string sagePath = Service.GetActiveSagePath();
			MessageBox.Show("No Sage 50 companies were found" + (sagePath == "" ? "." : " in:\r\n" + sagePath) + "\r\n\r\nPlease select your Sage version under Settings > Path Configuration.", "Sage Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Documentation\\Software License Agreement - March 2010.pdf");
		if (!File.Exists(text))
		{
			MessageBox.Show(Resources.MessageUnableToFindTheOnlineSubmissionManualHelpFile, "Missing File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		try
		{
			Process.Start(text);
		}
		catch (Exception ex)
		{
			if (ex.Message.Contains(Resources.msgNoApplicationAssociated))
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile1, "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile2 + ex.Message + "\n\r\n\r\n\rPlease contact support.", "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	private void miUserManual_Click(object sender, EventArgs e)
	{
		string text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Documentation\\Cyprus VIES Declaration User Manual v1.1.pdf");
		if (!File.Exists(text))
		{
			MessageBox.Show(Resources.MessageUnableToFindTheOnlineSubmissionManualHelpFile, "Missing File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		try
		{
			Process.Start(text);
		}
		catch (Exception ex)
		{
			if (ex.Message.Contains(Resources.msgNoApplicationAssociated))
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile1, "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				MessageBox.Show(Resources.UnableToOpenTheOnlineSubmissionManualHelpFile2 + ex.Message + "\n\r\n\r\n\rPlease contact support.", "Unable to Open File!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmMain));
		this.btnMultipleCompanyVATReturns = new System.Windows.Forms.Button();
		this.btnVATReturnProcess = new System.Windows.Forms.Button();
		this.panel2 = new System.Windows.Forms.Panel();
		this.gridCompanies = new System.Windows.Forms.DataGridView();
		this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.SageVATRegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.gbOption2 = new System.Windows.Forms.GroupBox();
		this.btnGroupVATReturns = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.gbOption3 = new System.Windows.Forms.GroupBox();
		this.label8 = new System.Windows.Forms.Label();
		this.menuStrip1 = new System.Windows.Forms.MenuStrip();
		this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.miExit = new System.Windows.Forms.ToolStripMenuItem();
		this.miTool = new System.Windows.Forms.ToolStripMenuItem();
		this.miPathConfiguration = new System.Windows.Forms.ToolStripMenuItem();
		this.miTools = new System.Windows.Forms.ToolStripMenuItem();
		this.miXmlFileChecker = new System.Windows.Forms.ToolStripMenuItem();
		this.gbOption1 = new System.Windows.Forms.GroupBox();
		this.txbFilter = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.ofdSelectXml = new System.Windows.Forms.OpenFileDialog();
		this.panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.companyBindingSource).BeginInit();
		this.gbOption2.SuspendLayout();
		this.gbOption3.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		this.gbOption1.SuspendLayout();
		base.SuspendLayout();
		this.btnMultipleCompanyVATReturns.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.btnMultipleCompanyVATReturns.ForeColor = System.Drawing.Color.Black;
		this.btnMultipleCompanyVATReturns.Location = new System.Drawing.Point(555, 88);
		this.btnMultipleCompanyVATReturns.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.btnMultipleCompanyVATReturns.Name = "btnMultipleCompanyVATReturns";
		this.btnMultipleCompanyVATReturns.Size = new System.Drawing.Size(188, 23);
		this.btnMultipleCompanyVATReturns.TabIndex = 3;
		this.btnMultipleCompanyVATReturns.Text = "Multi-Company VIES Declaration";
		this.btnMultipleCompanyVATReturns.UseVisualStyleBackColor = true;
		this.btnMultipleCompanyVATReturns.Click += new System.EventHandler(btnMultipleCompanyVATReturns_Click);
		this.btnVATReturnProcess.BackColor = System.Drawing.Color.White;
		this.btnVATReturnProcess.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.btnVATReturnProcess.ForeColor = System.Drawing.Color.Black;
		this.btnVATReturnProcess.Location = new System.Drawing.Point(555, 353);
		this.btnVATReturnProcess.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.btnVATReturnProcess.Name = "btnVATReturnProcess";
		this.btnVATReturnProcess.Size = new System.Drawing.Size(188, 23);
		this.btnVATReturnProcess.TabIndex = 2;
		this.btnVATReturnProcess.Text = "Single Company VIES Declaration";
		this.btnVATReturnProcess.UseVisualStyleBackColor = false;
		this.btnVATReturnProcess.Click += new System.EventHandler(frmVATReturnProcess_Click);
		this.panel2.Controls.Add(this.gridCompanies);
		this.panel2.Controls.Add(this.gbOption2);
		this.panel2.Controls.Add(this.gbOption3);
		this.panel2.Controls.Add(this.menuStrip1);
		this.panel2.Controls.Add(this.gbOption1);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(0, 0);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(784, 691);
		this.panel2.TabIndex = 2;
		this.gridCompanies.AllowUserToAddRows = false;
		this.gridCompanies.AllowUserToDeleteRows = false;
		this.gridCompanies.AllowUserToResizeColumns = false;
		this.gridCompanies.AllowUserToResizeRows = false;
		this.gridCompanies.AutoGenerateColumns = false;
		this.gridCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridCompanies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.gridCompanies.BackgroundColor = System.Drawing.Color.White;
		this.gridCompanies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridCompanies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridCompanies.Columns.AddRange(this.nameDataGridViewTextBoxColumn, this.SageVATRegistrationNumber);
		this.gridCompanies.DataSource = this.companyBindingSource;
		this.gridCompanies.Location = new System.Drawing.Point(26, 177);
		this.gridCompanies.MultiSelect = false;
		this.gridCompanies.Name = "gridCompanies";
		this.gridCompanies.ReadOnly = true;
		this.gridCompanies.RowHeadersVisible = false;
		this.gridCompanies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridCompanies.Size = new System.Drawing.Size(729, 199);
		this.gridCompanies.TabIndex = 0;
		this.gridCompanies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridView1CellClick);
		this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
		this.nameDataGridViewTextBoxColumn.FillWeight = 70f;
		this.nameDataGridViewTextBoxColumn.HeaderText = "Company Name";
		this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
		this.nameDataGridViewTextBoxColumn.ReadOnly = true;
		this.SageVATRegistrationNumber.DataPropertyName = "SageVATRegistrationNumber";
		this.SageVATRegistrationNumber.FillWeight = 30f;
		this.SageVATRegistrationNumber.HeaderText = "VAT Number";
		this.SageVATRegistrationNumber.Name = "SageVATRegistrationNumber";
		this.SageVATRegistrationNumber.ReadOnly = true;
		this.companyBindingSource.DataSource = typeof(xSAD_VIES.Entities.SageCompany);
		this.gbOption2.Controls.Add(this.btnGroupVATReturns);
		this.gbOption2.Controls.Add(this.label1);
		this.gbOption2.Font = new System.Drawing.Font("Tahoma", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.gbOption2.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.gbOption2.Location = new System.Drawing.Point(12, 436);
		this.gbOption2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
		this.gbOption2.Name = "gbOption2";
		this.gbOption2.Size = new System.Drawing.Size(761, 128);
		this.gbOption2.TabIndex = 5;
		this.gbOption2.TabStop = false;
		this.gbOption2.Text = "2. VIES Declaration for a Group of Companies";
		this.btnGroupVATReturns.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.btnGroupVATReturns.ForeColor = System.Drawing.Color.Black;
		this.btnGroupVATReturns.Location = new System.Drawing.Point(555, 93);
		this.btnGroupVATReturns.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.btnGroupVATReturns.Name = "btnGroupVATReturns";
		this.btnGroupVATReturns.Size = new System.Drawing.Size(188, 23);
		this.btnGroupVATReturns.TabIndex = 4;
		this.btnGroupVATReturns.Text = "Group VIES Declaration";
		this.btnGroupVATReturns.UseVisualStyleBackColor = true;
		this.btnGroupVATReturns.Click += new System.EventHandler(btnGroupVATReturns_Click);
		this.label1.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label1.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.label1.Location = new System.Drawing.Point(11, 31);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(732, 92);
		this.label1.TabIndex = 4;
		this.label1.Text = resources.GetString("label1.Text");
		this.gbOption3.Controls.Add(this.btnMultipleCompanyVATReturns);
		this.gbOption3.Controls.Add(this.label8);
		this.gbOption3.Font = new System.Drawing.Font("Tahoma", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.gbOption3.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.gbOption3.Location = new System.Drawing.Point(12, 569);
		this.gbOption3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
		this.gbOption3.Name = "gbOption3";
		this.gbOption3.Size = new System.Drawing.Size(761, 116);
		this.gbOption3.TabIndex = 5;
		this.gbOption3.TabStop = false;
		this.gbOption3.Text = "3. VIES Declaration for Multiple Companies";
		this.label8.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label8.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.label8.Location = new System.Drawing.Point(11, 31);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(732, 82);
		this.label8.TabIndex = 4;
		this.label8.Text = resources.GetString("label8.Text");
		this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.fileToolStripMenuItem, this.miTool, this.miTools });
		this.menuStrip1.Location = new System.Drawing.Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
		this.menuStrip1.Size = new System.Drawing.Size(784, 24);
		this.menuStrip1.TabIndex = 4;
		this.menuStrip1.Text = "menuStrip1";
		this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.miExit });
		this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
		this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
		this.fileToolStripMenuItem.Text = "&File";
		this.miExit.Image = xSAD_VIES.Properties.Resources.IconClose_24;
		this.miExit.Name = "miExit";
		this.miExit.Size = new System.Drawing.Size(180, 22);
		this.miExit.Text = "&Exit";
		this.miExit.Click += new System.EventHandler(miExit_Click);
		this.miTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.miPathConfiguration });
		this.miTool.Name = "miTool";
		this.miTool.Size = new System.Drawing.Size(61, 20);
		this.miTool.Text = "&Settings";
		this.miPathConfiguration.Image = xSAD_VIES.Properties.Resources.IconConfig_24;
		this.miPathConfiguration.Name = "miPathConfiguration";
		this.miPathConfiguration.Size = new System.Drawing.Size(175, 22);
		this.miPathConfiguration.Text = "&Path Configuration";
		this.miPathConfiguration.Click += new System.EventHandler(miPathConfiguration_Click);
		this.miTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.miXmlFileChecker });
		this.miTools.Name = "miTools";
		this.miTools.Size = new System.Drawing.Size(46, 20);
		this.miTools.Text = "&Tools";
		this.miXmlFileChecker.Image = xSAD_VIES.Properties.Resources.IconChecker_24;
		this.miXmlFileChecker.Name = "miXmlFileChecker";
		this.miXmlFileChecker.Size = new System.Drawing.Size(165, 22);
		this.miXmlFileChecker.Text = "&XML File Checker";
		this.miXmlFileChecker.Click += new System.EventHandler(miXmlFileChecker_Click);
		this.gbOption1.Controls.Add(this.txbFilter);
		this.gbOption1.Controls.Add(this.btnVATReturnProcess);
		this.gbOption1.Controls.Add(this.label7);
		this.gbOption1.Controls.Add(this.label2);
		this.gbOption1.Controls.Add(this.label6);
		this.gbOption1.Font = new System.Drawing.Font("Tahoma", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.gbOption1.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.gbOption1.Location = new System.Drawing.Point(12, 34);
		this.gbOption1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
		this.gbOption1.Name = "gbOption1";
		this.gbOption1.Size = new System.Drawing.Size(761, 389);
		this.gbOption1.TabIndex = 5;
		this.gbOption1.TabStop = false;
		this.gbOption1.Text = "1. Single Company VIES Declaration";
		this.txbFilter.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.txbFilter.Location = new System.Drawing.Point(555, 97);
		this.txbFilter.Name = "txbFilter";
		this.txbFilter.Size = new System.Drawing.Size(188, 21);
		this.txbFilter.TabIndex = 1;
		this.txbFilter.TextChanged += new System.EventHandler(txbFilter_TextChanged);
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(509, 100);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 13);
		this.label7.TabIndex = 5;
		this.label7.Text = "Search";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label2.ForeColor = System.Drawing.Color.Gray;
		this.label2.Location = new System.Drawing.Point(413, 124);
		this.label2.Margin = new System.Windows.Forms.Padding(3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(334, 13);
		this.label2.TabIndex = 4;
		this.label2.Text = " You can search for companies by Name or VAT Registration Number";
		this.label6.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label6.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.label6.Location = new System.Drawing.Point(14, 36);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(729, 57);
		this.label6.TabIndex = 4;
		this.label6.Text = resources.GetString("label6.Text");
		this.ofdSelectXml.FileName = "openFileDialog1";
		base.AcceptButton = this.btnVATReturnProcess;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoScroll = true;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(784, 691);
		base.Controls.Add(this.panel2);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MainMenuStrip = this.menuStrip1;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmMain";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "VIES";
		base.Load += new System.EventHandler(frmMain_Load);
		base.Shown += new System.EventHandler(frmMain_Shown);
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).EndInit();
		((System.ComponentModel.ISupportInitialize)this.companyBindingSource).EndInit();
		this.gbOption2.ResumeLayout(false);
		this.gbOption3.ResumeLayout(false);
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		this.gbOption1.ResumeLayout(false);
		this.gbOption1.PerformLayout();
		base.ResumeLayout(false);
	}
}
