using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using xSADReports;
using xSAD_VIES.BL;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;
using xSAD_VIES.GUI;
using xSAD_VIES.Properties;

namespace xSAD_VIES;

public class frmGroupVATReturn : Form
{
	private Objects.GroupObject _CurrentEntity;

	private IContainer components;

	private DataGridView gridGroups;

	private DataGridView gridCompanies;

	private GroupBox gbGroups;

	private GroupBox gbCompanies;

	private Button btnDelete;

	private Button btnNew;

	private StatusStrip statusBar;

	private ToolStripStatusLabel lblStatus;

	private Button btnDeleteCompany;

	private ErrorProvider errorProvider;

	private Timer timerMessagingHandling;

	private ToolStripStatusLabel lblImage;

	private Timer timerBlinkImage;

	private Button btnEdit;

	private Button btnViewForm;

	private Button btnChangePeriod;

	private Button btnAddCompany;

	private Button btnVat;

	private DataGridViewTextBoxColumn PKGroupID;

	private DataGridViewTextBoxColumn GroupName;

	private DataGridViewTextBoxColumn VATReg;

	private DataGridViewTextBoxColumn aCompanyName;

	private DataGridViewTextBoxColumn CompanyVATReg;

	private DataGridViewTextBoxColumn Period;

	private DataGridViewCheckBoxColumn Include;

	public frmGroupVATReturn()
	{
		InitializeComponent();
		PrepareControls();
	}

	private void PrepareControls()
	{
		gridGroups.AutoGenerateColumns = false;
		gridCompanies.AutoGenerateColumns = false;
		lblStatus.Visible = false;
		lblImage.Visible = false;
		lblImage.Text = "";
		lblImage.Image = Resources.IconSave_32;
		LoadAllGroups();
	}

	private void GetEntityFromGrid()
	{
		if (_CurrentEntity == null)
		{
			_CurrentEntity = new Objects.GroupObject();
		}
		if (gridGroups.CurrentRow != null && gridGroups.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			_CurrentEntity.Name = (string)dataRowView["Name"];
			_CurrentEntity.VatReg = (string)dataRowView["VATReg"];
			_CurrentEntity.PkGroupId = (int)dataRowView["PKGroupID"];
		}
	}

	public void LoadAllCompanies()
	{
		if (gridGroups.CurrentRow != null && gridGroups.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			gridCompanies.DataSource = Controller.SelectAllCompanies((int)dataRowView["PKGroupID"]);
			gridCompanies.ClearSelection();
			btnDeleteCompany.Enabled = false;
			btnChangePeriod.Enabled = false;
			btnViewForm.Enabled = false;
		}
	}

	public void DisableButtons()
	{
		gbCompanies.Enabled = false;
		gridCompanies.DataSource = null;
	}

	public void LoadAllGroups()
	{
		gridGroups.DataSource = Controller.SelectAllGroups(Controller2.GetSageVersion());
		gridGroups.ClearSelection();
		btnEdit.Enabled = false;
		btnDelete.Enabled = false;
	}

	public void ShowMessage(string msg)
	{
		statusBar.BackColor = Color.FromArgb(119, 174, 47);
		lblImage.Image = Resources.IconSave_32;
		lblStatus.Visible = true;
		lblImage.Visible = true;
		lblStatus.Text = msg;
		timerMessagingHandling.Stop();
		timerMessagingHandling.Enabled = false;
		timerMessagingHandling.Enabled = true;
		timerMessagingHandling.Start();
		timerBlinkImage.Enabled = true;
		timerBlinkImage.Start();
	}

	public void ShowErrorMessage(string msg)
	{
		statusBar.BackColor = Color.FromArgb(231, 116, 131);
		lblStatus.Visible = true;
		lblImage.Visible = true;
		lblStatus.Text = msg;
		timerMessagingHandling.Stop();
		timerMessagingHandling.Enabled = false;
		timerMessagingHandling.Enabled = true;
		timerMessagingHandling.Start();
		timerBlinkImage.Enabled = true;
		timerBlinkImage.Start();
	}

	private void btnNew_Click(object sender, EventArgs e)
	{
		frmManageGroup frmManageGroup = new frmManageGroup(this);
		frmManageGroup.IsEditMode = false;
		frmManageGroup.ShowDialog();
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		GetEntityFromGrid();
		frmManageGroup frmManageGroup = new frmManageGroup(this);
		frmManageGroup.IsEditMode = true;
		frmManageGroup.CurrentEntity = _CurrentEntity;
		frmManageGroup.ShowDialog();
	}

	private void gridGroups_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = e.RowIndex;
		_ = -1;
	}

	private void BtnDeleteClick(object sender, EventArgs e)
	{
		if (gridCompanies.Rows.Count == 0)
		{
			GetEntityFromGrid();
			Controller.DeleteGroupCompanies(_CurrentEntity.PkGroupId);
			Controller.DeleteGroup(_CurrentEntity.PkGroupId);
			string msg = "Group " + _CurrentEntity.Name + " has been deleted successfully!";
			LoadAllGroups();
			DisableButtons();
			ShowMessage(msg);
		}
		else
		{
			ShowErrorMessage("Group " + _CurrentEntity.Name + " has companies assigned and can not be deleted!");
		}
	}

	private void frmGroupVATReturn_Shown(object sender, EventArgs e)
	{
		DisableButtons();
		gridGroups.ClearSelection();
	}

	private void gridGroups_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		GetEntityFromGrid();
		frmManageGroup frmManageGroup = new frmManageGroup(this);
		frmManageGroup.IsEditMode = true;
		frmManageGroup.CurrentEntity = _CurrentEntity;
		frmManageGroup.ShowDialog();
	}

	private void btnDeleteCompany_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			Controller.DeleteCompany((int)dataRowView["PKCompanyID"]);
			LoadAllCompanies();
		}
	}

	private void btnAddCompany_Click_1(object sender, EventArgs e)
	{
		new frmSelectCompany(this, _CurrentEntity.PkGroupId, IsGroup: true).ShowDialog();
	}

	private void gridCompanies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (gridCompanies.DataSource != null && gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			Controller.SaveCompanyIsIncluded((int)dataRowView["PKCompanyID"], (bool)dataRowView["Include"]);
		}
	}

	private void btnChangePeriod_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			frmSelectPeriod frmSelectPeriod = new frmSelectPeriod(this, isGroupForm: true, (string)dataRowView["CompanyCode"], (int)dataRowView["PKCompanyID"], isGroup: false, 0);
			frmSelectPeriod.Text = "Company - " + (string)dataRowView["Name"];
			frmSelectPeriod.ShowDialog();
		}
	}

	private void btnViewForm_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			string companyCode = (string)dataRowView["CompanyCode"];
			string period = (string)dataRowView["Period"];
			DateTime periodFrom = Service.ExtractDateFrom(period);
			DateTime periodTo = Service.ExtractDateTo(period);
			ViesEntity companyVatEntity = SageController.GetCompanyVatEntity(companyCode, "", periodFrom, periodTo);
			SageCompany sageCompanyFromCompanyCode = SageController.GetSageCompanyFromCompanyCode(companyCode);
			rptVIESSubmissionForm rptVIESSubmissionForm = new rptVIESSubmissionForm();
			rptVIESSubmissionForm.TaxPayerValue = sageCompanyFromCompanyCode.SageVatRegistrationNumber;
			rptVIESSubmissionForm.DataSource = companyVatEntity.ViesRows;
			rptVIESSubmissionForm.SetTotals(companyVatEntity.TotalRows, companyVatEntity.SumSuppliesAmount, companyVatEntity.SumTriangleTransactionsAmount, companyVatEntity.SumServicesAmount);
			rptVIESSubmissionForm.SetDates(companyVatEntity.PeriodFrom, companyVatEntity.PeriodTo, companyVatEntity.DeclarationMonth.ToString(), companyVatEntity.DeclarationYear.ToString(), "Ημερομηνία εκτύπωσης");
			frmPreview frmPreview = new frmPreview(rptVIESSubmissionForm, Service.GetFormNotificationSetting);
			frmPreview.Text = "VIES Declaration Form";
			frmPreview.ShowDialog();
			if (frmPreview.DisableNotification)
			{
				Service.DisableFormNotification();
			}
		}
	}

	private void gridCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && gridCompanies.Rows.Count > 0)
		{
			btnDeleteCompany.Enabled = true;
			btnChangePeriod.Enabled = true;
			btnViewForm.Enabled = true;
		}
	}

	private void gridCompanies_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex > -1 && e.ColumnIndex == 2 && Convert.ToString(e.Value) != "?" && Convert.ToString(e.Value) != "Not Selected")
		{
			string period = Convert.ToString(e.Value);
			DateTime dateTime = Service.ExtractDateFrom(period);
			DateTime dateTime2 = Service.ExtractDateTo(period);
			string value = dateTime.ToShortDateString() + " - " + dateTime2.ToShortDateString();
			e.Value = value;
		}
	}

	private void timerMessagingHandling_Tick(object sender, EventArgs e)
	{
		statusBar.BackColor = BackColor;
		errorProvider.Clear();
		timerMessagingHandling.Stop();
		timerMessagingHandling.Enabled = false;
		lblStatus.Visible = false;
		lblImage.Visible = false;
		timerBlinkImage.Stop();
		timerBlinkImage.Enabled = false;
	}

	private void timerBlinkImage_Tick(object sender, EventArgs e)
	{
		lblImage.Visible = !lblImage.Visible;
	}

	private void btnVat_Click(object sender, EventArgs e)
	{
		if (gridGroups.CurrentRow == null || !(gridGroups.CurrentRow.DataBoundItem is DataRowView dataRowView))
		{
			return;
		}
		int num = (int)dataRowView["PKGroupID"];
		string groupName = (string)dataRowView["Name"];
		string groupVatReg = (string)dataRowView["VatReg"];
		if (Controller.SelectAllIncludedCompanies(num).Rows.Count == 0)
		{
			MessageBox.Show("There are no included companies in this group");
			return;
		}
		FrmDeclarationProcess frmDeclarationProcess = new FrmDeclarationProcess(num, groupName, groupVatReg);
		if (!frmDeclarationProcess.FormCanceled)
		{
			frmDeclarationProcess.ShowDialog();
		}
	}

	private void gridGroups_SelectionChanged(object sender, EventArgs e)
	{
		if (gridGroups.CurrentRow != null && gridGroups.Rows.Count > 0)
		{
			GetEntityFromGrid();
			gbCompanies.Enabled = true;
			if (gridGroups.CurrentRow.DataBoundItem is DataRowView dataRowView)
			{
				gridCompanies.DataSource = Controller.SelectAllCompanies((int)dataRowView["PKGroupID"]);
				btnEdit.Enabled = true;
				btnDelete.Enabled = true;
				gridCompanies.ClearSelection();
				btnDeleteCompany.Enabled = false;
				btnChangePeriod.Enabled = false;
				btnViewForm.Enabled = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.frmGroupVATReturn));
		this.gridGroups = new System.Windows.Forms.DataGridView();
		this.PKGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.VATReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.gridCompanies = new System.Windows.Forms.DataGridView();
		this.aCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CompanyVATReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.gbGroups = new System.Windows.Forms.GroupBox();
		this.btnVat = new System.Windows.Forms.Button();
		this.btnEdit = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnNew = new System.Windows.Forms.Button();
		this.gbCompanies = new System.Windows.Forms.GroupBox();
		this.btnAddCompany = new System.Windows.Forms.Button();
		this.btnViewForm = new System.Windows.Forms.Button();
		this.btnChangePeriod = new System.Windows.Forms.Button();
		this.btnDeleteCompany = new System.Windows.Forms.Button();
		this.statusBar = new System.Windows.Forms.StatusStrip();
		this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblImage = new System.Windows.Forms.ToolStripStatusLabel();
		this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
		this.timerMessagingHandling = new System.Windows.Forms.Timer(this.components);
		this.timerBlinkImage = new System.Windows.Forms.Timer(this.components);
		((System.ComponentModel.ISupportInitialize)this.gridGroups).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).BeginInit();
		this.gbGroups.SuspendLayout();
		this.gbCompanies.SuspendLayout();
		this.statusBar.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).BeginInit();
		base.SuspendLayout();
		this.gridGroups.AllowUserToAddRows = false;
		this.gridGroups.AllowUserToDeleteRows = false;
		this.gridGroups.AllowUserToResizeColumns = false;
		this.gridGroups.AllowUserToResizeRows = false;
		this.gridGroups.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gridGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridGroups.BackgroundColor = System.Drawing.Color.White;
		this.gridGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridGroups.Columns.AddRange(this.PKGroupID, this.GroupName, this.VATReg);
		this.gridGroups.Location = new System.Drawing.Point(21, 35);
		this.gridGroups.Margin = new System.Windows.Forms.Padding(6);
		this.gridGroups.MultiSelect = false;
		this.gridGroups.Name = "gridGroups";
		this.gridGroups.ReadOnly = true;
		this.gridGroups.RowHeadersVisible = false;
		this.gridGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridGroups.Size = new System.Drawing.Size(408, 561);
		this.gridGroups.TabIndex = 0;
		this.gridGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(gridGroups_CellClick);
		this.gridGroups.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(gridGroups_CellMouseDoubleClick);
		this.gridGroups.SelectionChanged += new System.EventHandler(gridGroups_SelectionChanged);
		this.PKGroupID.DataPropertyName = "PKGroupID";
		this.PKGroupID.HeaderText = "PKGroupID";
		this.PKGroupID.Name = "PKGroupID";
		this.PKGroupID.ReadOnly = true;
		this.PKGroupID.Visible = false;
		this.GroupName.DataPropertyName = "Name";
		this.GroupName.FillWeight = 70f;
		this.GroupName.HeaderText = "Name";
		this.GroupName.Name = "GroupName";
		this.GroupName.ReadOnly = true;
		this.VATReg.DataPropertyName = "VATReg";
		this.VATReg.FillWeight = 30f;
		this.VATReg.HeaderText = "VAT Reg";
		this.VATReg.Name = "VATReg";
		this.VATReg.ReadOnly = true;
		this.gridCompanies.AllowUserToAddRows = false;
		this.gridCompanies.AllowUserToDeleteRows = false;
		this.gridCompanies.AllowUserToResizeColumns = false;
		this.gridCompanies.AllowUserToResizeRows = false;
		this.gridCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gridCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridCompanies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
		this.gridCompanies.BackgroundColor = System.Drawing.Color.White;
		this.gridCompanies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridCompanies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridCompanies.Columns.AddRange(this.aCompanyName, this.CompanyVATReg, this.Period, this.Include);
		this.gridCompanies.Location = new System.Drawing.Point(453, 35);
		this.gridCompanies.Margin = new System.Windows.Forms.Padding(6);
		this.gridCompanies.MultiSelect = false;
		this.gridCompanies.Name = "gridCompanies";
		this.gridCompanies.RowHeadersVisible = false;
		this.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridCompanies.Size = new System.Drawing.Size(561, 561);
		this.gridCompanies.TabIndex = 1;
		this.gridCompanies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(gridCompanies_CellValueChanged);
		this.gridCompanies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(gridCompanies_CellFormatting);
		this.gridCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(gridCompanies_CellClick);
		this.aCompanyName.DataPropertyName = "Name";
		this.aCompanyName.FillWeight = 45f;
		this.aCompanyName.HeaderText = "Name";
		this.aCompanyName.Name = "aCompanyName";
		this.aCompanyName.ReadOnly = true;
		this.CompanyVATReg.DataPropertyName = "VATReg";
		this.CompanyVATReg.FillWeight = 20f;
		this.CompanyVATReg.HeaderText = "VAT Reg";
		this.CompanyVATReg.Name = "CompanyVATReg";
		this.CompanyVATReg.ReadOnly = true;
		this.Period.DataPropertyName = "Period";
		this.Period.FillWeight = 45f;
		this.Period.HeaderText = "Period";
		this.Period.Name = "Period";
		this.Period.ReadOnly = true;
		this.Period.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.Include.DataPropertyName = "Include";
		this.Include.FillWeight = 15f;
		this.Include.HeaderText = "   Include?";
		this.Include.Name = "Include";
		this.gbGroups.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbGroups.BackColor = System.Drawing.Color.Transparent;
		this.gbGroups.Controls.Add(this.btnVat);
		this.gbGroups.Controls.Add(this.btnEdit);
		this.gbGroups.Controls.Add(this.btnDelete);
		this.gbGroups.Controls.Add(this.btnNew);
		this.gbGroups.ForeColor = System.Drawing.Color.Chocolate;
		this.gbGroups.Location = new System.Drawing.Point(12, 12);
		this.gbGroups.Name = "gbGroups";
		this.gbGroups.Size = new System.Drawing.Size(426, 622);
		this.gbGroups.TabIndex = 2;
		this.gbGroups.TabStop = false;
		this.gbGroups.Text = "Groups";
		this.btnVat.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnVat.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnVat.Location = new System.Drawing.Point(191, 593);
		this.btnVat.Name = "btnVat";
		this.btnVat.Size = new System.Drawing.Size(85, 23);
		this.btnVat.TabIndex = 3;
		this.btnVat.Text = "VIES";
		this.btnVat.UseVisualStyleBackColor = true;
		this.btnVat.Click += new System.EventHandler(btnVat_Click);
		this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnEdit.Location = new System.Drawing.Point(100, 593);
		this.btnEdit.Name = "btnEdit";
		this.btnEdit.Size = new System.Drawing.Size(85, 23);
		this.btnEdit.TabIndex = 2;
		this.btnEdit.Text = "Edit";
		this.btnEdit.UseVisualStyleBackColor = true;
		this.btnEdit.Click += new System.EventHandler(btnEdit_Click);
		this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnDelete.Location = new System.Drawing.Point(332, 593);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(85, 23);
		this.btnDelete.TabIndex = 4;
		this.btnDelete.Text = "Delete";
		this.btnDelete.UseVisualStyleBackColor = true;
		this.btnDelete.Click += new System.EventHandler(BtnDeleteClick);
		this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnNew.Location = new System.Drawing.Point(9, 593);
		this.btnNew.Name = "btnNew";
		this.btnNew.Size = new System.Drawing.Size(85, 23);
		this.btnNew.TabIndex = 1;
		this.btnNew.Text = "Add Group";
		this.btnNew.UseVisualStyleBackColor = true;
		this.btnNew.Click += new System.EventHandler(btnNew_Click);
		this.gbCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbCompanies.BackColor = System.Drawing.Color.Transparent;
		this.gbCompanies.Controls.Add(this.btnAddCompany);
		this.gbCompanies.Controls.Add(this.btnViewForm);
		this.gbCompanies.Controls.Add(this.btnChangePeriod);
		this.gbCompanies.Controls.Add(this.btnDeleteCompany);
		this.gbCompanies.ForeColor = System.Drawing.Color.Chocolate;
		this.gbCompanies.Location = new System.Drawing.Point(444, 12);
		this.gbCompanies.Name = "gbCompanies";
		this.gbCompanies.Size = new System.Drawing.Size(579, 622);
		this.gbCompanies.TabIndex = 2;
		this.gbCompanies.TabStop = false;
		this.gbCompanies.Text = "Companies";
		this.btnAddCompany.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnAddCompany.Location = new System.Drawing.Point(9, 593);
		this.btnAddCompany.Name = "btnAddCompany";
		this.btnAddCompany.Size = new System.Drawing.Size(85, 23);
		this.btnAddCompany.TabIndex = 5;
		this.btnAddCompany.Text = "Add Company";
		this.btnAddCompany.UseVisualStyleBackColor = true;
		this.btnAddCompany.Click += new System.EventHandler(btnAddCompany_Click_1);
		this.btnViewForm.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnViewForm.Location = new System.Drawing.Point(191, 593);
		this.btnViewForm.Name = "btnViewForm";
		this.btnViewForm.Size = new System.Drawing.Size(85, 23);
		this.btnViewForm.TabIndex = 7;
		this.btnViewForm.Text = "View Form";
		this.btnViewForm.UseVisualStyleBackColor = true;
		this.btnViewForm.Click += new System.EventHandler(btnViewForm_Click);
		this.btnChangePeriod.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnChangePeriod.Location = new System.Drawing.Point(100, 593);
		this.btnChangePeriod.Name = "btnChangePeriod";
		this.btnChangePeriod.Size = new System.Drawing.Size(85, 23);
		this.btnChangePeriod.TabIndex = 6;
		this.btnChangePeriod.Text = "Change Period";
		this.btnChangePeriod.UseVisualStyleBackColor = true;
		this.btnChangePeriod.Click += new System.EventHandler(btnChangePeriod_Click);
		this.btnDeleteCompany.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnDeleteCompany.Location = new System.Drawing.Point(485, 593);
		this.btnDeleteCompany.Name = "btnDeleteCompany";
		this.btnDeleteCompany.Size = new System.Drawing.Size(85, 23);
		this.btnDeleteCompany.TabIndex = 8;
		this.btnDeleteCompany.Text = "Remove";
		this.btnDeleteCompany.UseVisualStyleBackColor = true;
		this.btnDeleteCompany.Click += new System.EventHandler(btnDeleteCompany_Click);
		this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.lblStatus, this.lblImage });
		this.statusBar.Location = new System.Drawing.Point(0, 643);
		this.statusBar.Name = "statusBar";
		this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.statusBar.Size = new System.Drawing.Size(1035, 22);
		this.statusBar.SizingGrip = false;
		this.statusBar.TabIndex = 3;
		this.statusBar.Text = "statusStrip1";
		this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
		this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(45, 17);
		this.lblStatus.Text = "Status";
		this.lblImage.BackColor = System.Drawing.SystemColors.Control;
		this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblImage.Name = "lblImage";
		this.lblImage.Size = new System.Drawing.Size(46, 17);
		this.lblImage.Text = "Image";
		this.errorProvider.ContainerControl = this;
		this.timerMessagingHandling.Interval = 3000;
		this.timerMessagingHandling.Tick += new System.EventHandler(timerMessagingHandling_Tick);
		this.timerBlinkImage.Interval = 250;
		this.timerBlinkImage.Tick += new System.EventHandler(timerBlinkImage_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1035, 665);
		base.Controls.Add(this.gridCompanies);
		base.Controls.Add(this.gridGroups);
		base.Controls.Add(this.statusBar);
		base.Controls.Add(this.gbGroups);
		base.Controls.Add(this.gbCompanies);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmGroupVATReturn";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Group VIES Declaration";
		base.Shown += new System.EventHandler(frmGroupVATReturn_Shown);
		((System.ComponentModel.ISupportInitialize)this.gridGroups).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).EndInit();
		this.gbGroups.ResumeLayout(false);
		this.gbCompanies.ResumeLayout(false);
		this.statusBar.ResumeLayout(false);
		this.statusBar.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
