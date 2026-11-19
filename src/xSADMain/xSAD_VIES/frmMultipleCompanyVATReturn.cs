using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using xSAD_VIES.BL;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;
using xSAD_VIES.GUI;
using xSAD_VIES.Properties;

namespace xSAD_VIES;

public class frmMultipleCompanyVATReturn : Form
{
	private Objects.MultipleCompanyObject _CurrentEntity;

	private IContainer components;

	private DataGridView gridMultipleCompanies;

	private DataGridView gridCompanies;

	private GroupBox gbMultipleCompanies;

	private GroupBox gbCompaniesGroups;

	private Button btnDelete;

	private Button btnNew;

	private StatusStrip statusBar;

	private ToolStripStatusLabel lblStatus;

	private Button btnDeleteCompany;

	private Button btnAddCompany;

	private Timer timerMessagingHandling;

	private ToolStripStatusLabel lblImage;

	private Timer timerBlinkImage;

	private Button btnEdit;

	private Button btnViewForm;

	private Button btnChangePeriod;

	private Button btnAddGroup;

	private Button btnGenerateXML;

	private DataGridViewTextBoxColumn PKGroupID;

	private DataGridViewTextBoxColumn GroupName;

	private DataGridViewTextBoxColumn aCompanyName;

	private DataGridViewTextBoxColumn CompanyVATReg;

	private DataGridViewTextBoxColumn Period;

	private DataGridViewTextBoxColumn IsGroup;

	private DataGridViewCheckBoxColumn Include;

	private CheckBox chkReplaceGR;

	public frmMultipleCompanyVATReturn()
	{
		InitializeComponent();
		PrepareControls();
		LoadAllMultipleCompanies();
	}

	private void PrepareControls()
	{
		gridMultipleCompanies.AutoGenerateColumns = false;
		gridCompanies.AutoGenerateColumns = false;
		statusBar.BackColor = Color.White;
		lblStatus.Visible = false;
		lblImage.Visible = false;
		lblImage.Text = "";
		lblImage.Image = Resources.IconSave_32;
	}

	private void GetEntityFromGrid()
	{
		if (_CurrentEntity == null)
		{
			_CurrentEntity = new Objects.MultipleCompanyObject();
		}
		if (gridMultipleCompanies.CurrentRow != null && gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			_CurrentEntity.Name = (string)dataRowView["Name"];
			_CurrentEntity.PkMultipleCompanyId = (int)dataRowView["PKMultipleCompanyID"];
		}
	}

	public void LoadAllChildrenCompanies()
	{
		if (gridMultipleCompanies.CurrentRow != null && gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			gridCompanies.DataSource = Controller.SelectAllChildrenCompanies((int)dataRowView["PKMultipleCompanyID"]);
			gridCompanies.ClearSelection();
			btnDeleteCompany.Enabled = false;
			btnChangePeriod.Enabled = false;
			btnViewForm.Enabled = false;
		}
	}

	public void DisableButtons()
	{
		gbCompaniesGroups.Enabled = false;
		gridCompanies.DataSource = null;
	}

	public void LoadAllMultipleCompanies()
	{
		gridMultipleCompanies.DataSource = Controller.SelectAllMultipleCompanies(Controller2.GetSageVersion());
		gridMultipleCompanies.ClearSelection();
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
		lblImage.Image = Resources.IconError_32;
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
		frmManageMultipleCompany frmManageMultipleCompany = new frmManageMultipleCompany(this);
		frmManageMultipleCompany.IsEditMode = false;
		frmManageMultipleCompany.ShowDialog();
	}

	private void btnEdit_Click(object sender, EventArgs e)
	{
		GetEntityFromGrid();
		frmManageMultipleCompany frmManageMultipleCompany = new frmManageMultipleCompany(this);
		frmManageMultipleCompany.IsEditMode = true;
		frmManageMultipleCompany.CurrentEntity = _CurrentEntity;
		frmManageMultipleCompany.ShowDialog();
	}

	private void gridGroups_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		_ = e.RowIndex;
		_ = -1;
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		GetEntityFromGrid();
		if (gridCompanies.Rows.Count == 0)
		{
			Controller.DeleteChildCompany(_CurrentEntity.PkMultipleCompanyId);
			Controller.DeleteMultipleCompany(_CurrentEntity.PkMultipleCompanyId);
			string msg = "Company " + _CurrentEntity.Name + " has been deleted successfully!";
			LoadAllMultipleCompanies();
			DisableButtons();
			ShowMessage(msg);
		}
		else
		{
			ShowErrorMessage("Company " + _CurrentEntity.Name + " has Companies or Groups assigned and can not be deleted!");
		}
	}

	private void frmGroupVATReturn_Shown(object sender, EventArgs e)
	{
		DisableButtons();
		gridMultipleCompanies.ClearSelection();
	}

	private void gridGroups_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		GetEntityFromGrid();
	}

	private void btnDeleteCompany_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			Controller.DeleteChildCompany((int)dataRowView["PKCompanyID"]);
			LoadAllChildrenCompanies();
		}
	}

	private void btnChangePeriod_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			string companyCode = (string)dataRowView["CompanyCode"];
			int id = (int)dataRowView["PKCompanyID"];
			bool isGroup = (bool)dataRowView["IsGroup"];
			int groupId = (int)dataRowView["FKGroupId"];
			frmSelectPeriod frmSelectPeriod = new frmSelectPeriod(this, isGroupForm: false, companyCode, id, isGroup, groupId);
			if ((bool)dataRowView["IsGroup"])
			{
				frmSelectPeriod.Text = "Group - " + (string)dataRowView["Name"];
			}
			else
			{
				frmSelectPeriod.Text = "Company - " + (string)dataRowView["Name"];
			}
			frmSelectPeriod.ShowDialog();
		}
	}

	private void btnViewForm_Click(object sender, EventArgs e)
	{
		if (gridCompanies.CurrentRow == null || !(gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView))
		{
			return;
		}
		string companyCode = (string)dataRowView["CompanyCode"];
		bool flag = (bool)dataRowView["IsGroup"];
		int groupId = (int)dataRowView["FKGroupId"];
		string period = (string)dataRowView["Period"];
		DateTime dateTime = Service.ExtractDateFrom(period);
		DateTime dateTime2 = Service.ExtractDateTo(period);
		_ = (string)dataRowView["VATReg"];
		if (!(dateTime == DateTime.MinValue) && !(dateTime2 == DateTime.MinValue))
		{
			if (flag)
			{
				Service.ShowViesSubmissionForm(SageController.GetGroupVatEntity(groupId, dateTime, dateTime2), this);
			}
			else
			{
				Service.ShowViesSubmissionForm(SageController.GetCompanyVatEntity(companyCode, "", dateTime, dateTime2), this);
			}
		}
	}

	private void BtnAddCompanyClick(object sender, EventArgs e)
	{
		if (gridMultipleCompanies.CurrentRow != null && gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			new frmSelectCompany(this, (int)dataRowView["PKMultipleCompanyID"], IsGroup: false).ShowDialog();
		}
	}

	private void BtnAddGroupClick(object sender, EventArgs e)
	{
		if (gridMultipleCompanies.CurrentRow != null && gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			new frmSelectGroup(this, (int)dataRowView["PKMultipleCompanyID"]).ShowDialog();
		}
	}

	private void GridCompaniesCellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && gridCompanies.Rows.Count > 0)
		{
			btnDeleteCompany.Enabled = true;
			btnChangePeriod.Enabled = true;
			btnViewForm.Enabled = true;
		}
	}

	private void GridCompaniesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex <= -1)
		{
			return;
		}
		if (e.ColumnIndex == 2)
		{
			if (Convert.ToString(e.Value) != "?" && Convert.ToString(e.Value) != "Not Selected")
			{
				string period = Convert.ToString(e.Value);
				DateTime dateTime = Service.ExtractDateFrom(period);
				DateTime dateTime2 = Service.ExtractDateTo(period);
				string value = dateTime.ToShortDateString() + " - " + dateTime2.ToShortDateString();
				e.Value = value;
			}
		}
		else if (e.ColumnIndex == 3)
		{
			e.Value = (((bool)e.Value) ? "    Yes" : "    No");
		}
	}

	private void GridCompaniesCellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (gridCompanies.DataSource != null && gridCompanies.CurrentRow != null && gridCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
		{
			Controller.SaveChildCompanyIsIncluded((int)dataRowView["PKCompanyID"], (bool)dataRowView["Include"]);
		}
	}

	private void BtnGenerateXMLClick(object sender, EventArgs e)
	{
		if (gridMultipleCompanies.CurrentRow == null || !(gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView))
		{
			return;
		}
		int multiGroupId = (int)dataRowView["PKMultipleCompanyID"];
		string text = (string)dataRowView["Name"];
		string xmlFilename = Path.Combine(XmlFuncs.GenerateXmlFilenameForMultipleEntity(text), text + "_cyvies_multiple.xml");
		List<ViesEntity> vatEntitiesForMultiId = SageController.GetVatEntitiesForMultiId(multiGroupId);
		if (vatEntitiesForMultiId != null)
		{
			if (vatEntitiesForMultiId.Count == 0)
			{
				MessageBox.Show("There are no included groups/companies in this Multi-Company selection");
			}
			else
			{
				XmlFuncs.GenerateXmlForListOfEntities(xmlFilename, vatEntitiesForMultiId, chkReplaceGR.Checked);
			}
		}
	}

	private void timerMessagingHandling_Tick(object sender, EventArgs e)
	{
		statusBar.BackColor = BackColor;
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

	private void gridMultipleCompanies_SelectionChanged(object sender, EventArgs e)
	{
		if (gridMultipleCompanies.CurrentRow != null && gridMultipleCompanies.Rows.Count > 0)
		{
			gbCompaniesGroups.Enabled = true;
			if (gridMultipleCompanies.CurrentRow.DataBoundItem is DataRowView dataRowView)
			{
				gridCompanies.DataSource = Controller.SelectAllChildrenCompanies((int)dataRowView["PKMultipleCompanyID"]);
				gridCompanies.ClearSelection();
				btnEdit.Enabled = true;
				btnDelete.Enabled = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.frmMultipleCompanyVATReturn));
		this.gridMultipleCompanies = new System.Windows.Forms.DataGridView();
		this.PKGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.gridCompanies = new System.Windows.Forms.DataGridView();
		this.aCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CompanyVATReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.IsGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.gbMultipleCompanies = new System.Windows.Forms.GroupBox();
		this.btnGenerateXML = new System.Windows.Forms.Button();
		this.btnEdit = new System.Windows.Forms.Button();
		this.btnDelete = new System.Windows.Forms.Button();
		this.btnNew = new System.Windows.Forms.Button();
		this.gbCompaniesGroups = new System.Windows.Forms.GroupBox();
		this.btnAddGroup = new System.Windows.Forms.Button();
		this.btnViewForm = new System.Windows.Forms.Button();
		this.btnChangePeriod = new System.Windows.Forms.Button();
		this.btnDeleteCompany = new System.Windows.Forms.Button();
		this.btnAddCompany = new System.Windows.Forms.Button();
		this.statusBar = new System.Windows.Forms.StatusStrip();
		this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
		this.lblImage = new System.Windows.Forms.ToolStripStatusLabel();
		this.timerMessagingHandling = new System.Windows.Forms.Timer(this.components);
		this.timerBlinkImage = new System.Windows.Forms.Timer(this.components);
		this.chkReplaceGR = new System.Windows.Forms.CheckBox();
		((System.ComponentModel.ISupportInitialize)this.gridMultipleCompanies).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).BeginInit();
		this.gbMultipleCompanies.SuspendLayout();
		this.gbCompaniesGroups.SuspendLayout();
		this.statusBar.SuspendLayout();
		base.SuspendLayout();
		this.gridMultipleCompanies.AllowUserToAddRows = false;
		this.gridMultipleCompanies.AllowUserToDeleteRows = false;
		this.gridMultipleCompanies.AllowUserToResizeColumns = false;
		this.gridMultipleCompanies.AllowUserToResizeRows = false;
		this.gridMultipleCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gridMultipleCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridMultipleCompanies.BackgroundColor = System.Drawing.Color.White;
		this.gridMultipleCompanies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridMultipleCompanies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridMultipleCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridMultipleCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridMultipleCompanies.Columns.AddRange(this.PKGroupID, this.GroupName);
		this.gridMultipleCompanies.Location = new System.Drawing.Point(21, 35);
		this.gridMultipleCompanies.Margin = new System.Windows.Forms.Padding(6);
		this.gridMultipleCompanies.MultiSelect = false;
		this.gridMultipleCompanies.Name = "gridMultipleCompanies";
		this.gridMultipleCompanies.ReadOnly = true;
		this.gridMultipleCompanies.RowHeadersVisible = false;
		this.gridMultipleCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridMultipleCompanies.Size = new System.Drawing.Size(408, 597);
		this.gridMultipleCompanies.TabIndex = 0;
		this.gridMultipleCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(gridGroups_CellClick);
		this.gridMultipleCompanies.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(gridGroups_CellMouseDoubleClick);
		this.gridMultipleCompanies.SelectionChanged += new System.EventHandler(gridMultipleCompanies_SelectionChanged);
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
		this.gridCompanies.AllowUserToAddRows = false;
		this.gridCompanies.AllowUserToDeleteRows = false;
		this.gridCompanies.AllowUserToResizeColumns = false;
		this.gridCompanies.AllowUserToResizeRows = false;
		this.gridCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gridCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridCompanies.BackgroundColor = System.Drawing.Color.White;
		this.gridCompanies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridCompanies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridCompanies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridCompanies.Columns.AddRange(this.aCompanyName, this.CompanyVATReg, this.Period, this.IsGroup, this.Include);
		this.gridCompanies.Location = new System.Drawing.Point(453, 35);
		this.gridCompanies.Margin = new System.Windows.Forms.Padding(6);
		this.gridCompanies.MultiSelect = false;
		this.gridCompanies.Name = "gridCompanies";
		this.gridCompanies.RowHeadersVisible = false;
		this.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridCompanies.Size = new System.Drawing.Size(561, 597);
		this.gridCompanies.TabIndex = 1;
		this.gridCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(GridCompaniesCellClick);
		this.gridCompanies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(GridCompaniesCellFormatting);
		this.gridCompanies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(GridCompaniesCellValueChanged);
		this.aCompanyName.DataPropertyName = "Name";
		this.aCompanyName.FillWeight = 25f;
		this.aCompanyName.HeaderText = "Name";
		this.aCompanyName.Name = "aCompanyName";
		this.aCompanyName.ReadOnly = true;
		this.CompanyVATReg.DataPropertyName = "VATReg";
		this.CompanyVATReg.FillWeight = 25f;
		this.CompanyVATReg.HeaderText = "VAT Reg";
		this.CompanyVATReg.Name = "CompanyVATReg";
		this.CompanyVATReg.ReadOnly = true;
		this.Period.DataPropertyName = "Period";
		this.Period.FillWeight = 30f;
		this.Period.HeaderText = "Period";
		this.Period.Name = "Period";
		this.Period.ReadOnly = true;
		this.Period.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.IsGroup.DataPropertyName = "IsGroup";
		this.IsGroup.FillWeight = 10f;
		this.IsGroup.HeaderText = " Group?";
		this.IsGroup.Name = "IsGroup";
		this.IsGroup.ReadOnly = true;
		this.IsGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		this.IsGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.Include.DataPropertyName = "Include";
		this.Include.FillWeight = 10f;
		this.Include.HeaderText = " Include?";
		this.Include.Name = "Include";
		this.gbMultipleCompanies.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbMultipleCompanies.BackColor = System.Drawing.Color.Transparent;
		this.gbMultipleCompanies.Controls.Add(this.chkReplaceGR);
		this.gbMultipleCompanies.Controls.Add(this.btnGenerateXML);
		this.gbMultipleCompanies.Controls.Add(this.btnEdit);
		this.gbMultipleCompanies.Controls.Add(this.btnDelete);
		this.gbMultipleCompanies.Controls.Add(this.btnNew);
		this.gbMultipleCompanies.ForeColor = System.Drawing.Color.Chocolate;
		this.gbMultipleCompanies.Location = new System.Drawing.Point(12, 12);
		this.gbMultipleCompanies.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbMultipleCompanies.Name = "gbMultipleCompanies";
		this.gbMultipleCompanies.Size = new System.Drawing.Size(426, 687);
		this.gbMultipleCompanies.TabIndex = 2;
		this.gbMultipleCompanies.TabStop = false;
		this.gbMultipleCompanies.Text = "Multi-Company Declarations";
		this.btnGenerateXML.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnGenerateXML.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnGenerateXML.Location = new System.Drawing.Point(188, 629);
		this.btnGenerateXML.Name = "btnGenerateXML";
		this.btnGenerateXML.Size = new System.Drawing.Size(85, 23);
		this.btnGenerateXML.TabIndex = 3;
		this.btnGenerateXML.Text = "Generate XML";
		this.btnGenerateXML.Click += new System.EventHandler(BtnGenerateXMLClick);
		this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnEdit.Location = new System.Drawing.Point(97, 629);
		this.btnEdit.Name = "btnEdit";
		this.btnEdit.Size = new System.Drawing.Size(85, 23);
		this.btnEdit.TabIndex = 2;
		this.btnEdit.Text = "Edit";
		this.btnEdit.Click += new System.EventHandler(btnEdit_Click);
		this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnDelete.Location = new System.Drawing.Point(329, 629);
		this.btnDelete.Name = "btnDelete";
		this.btnDelete.Size = new System.Drawing.Size(85, 23);
		this.btnDelete.TabIndex = 4;
		this.btnDelete.Text = "Delete";
		this.btnDelete.Click += new System.EventHandler(btnDelete_Click);
		this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnNew.Location = new System.Drawing.Point(6, 629);
		this.btnNew.Name = "btnNew";
		this.btnNew.Size = new System.Drawing.Size(85, 23);
		this.btnNew.TabIndex = 1;
		this.btnNew.Text = "Add Multi";
		this.btnNew.Click += new System.EventHandler(btnNew_Click);
		this.gbCompaniesGroups.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbCompaniesGroups.BackColor = System.Drawing.Color.Transparent;
		this.gbCompaniesGroups.Controls.Add(this.btnAddGroup);
		this.gbCompaniesGroups.Controls.Add(this.btnViewForm);
		this.gbCompaniesGroups.Controls.Add(this.btnChangePeriod);
		this.gbCompaniesGroups.Controls.Add(this.btnDeleteCompany);
		this.gbCompaniesGroups.Controls.Add(this.btnAddCompany);
		this.gbCompaniesGroups.ForeColor = System.Drawing.Color.Chocolate;
		this.gbCompaniesGroups.Location = new System.Drawing.Point(444, 12);
		this.gbCompaniesGroups.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbCompaniesGroups.Name = "gbCompaniesGroups";
		this.gbCompaniesGroups.Size = new System.Drawing.Size(579, 687);
		this.gbCompaniesGroups.TabIndex = 2;
		this.gbCompaniesGroups.TabStop = false;
		this.gbCompaniesGroups.Text = "Companies && Groups";
		this.btnAddGroup.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAddGroup.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnAddGroup.Location = new System.Drawing.Point(100, 629);
		this.btnAddGroup.Name = "btnAddGroup";
		this.btnAddGroup.Size = new System.Drawing.Size(85, 23);
		this.btnAddGroup.TabIndex = 6;
		this.btnAddGroup.Text = "Add Group";
		this.btnAddGroup.Click += new System.EventHandler(BtnAddGroupClick);
		this.btnViewForm.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnViewForm.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnViewForm.Location = new System.Drawing.Point(282, 629);
		this.btnViewForm.Name = "btnViewForm";
		this.btnViewForm.Size = new System.Drawing.Size(85, 23);
		this.btnViewForm.TabIndex = 8;
		this.btnViewForm.Text = "View Form";
		this.btnViewForm.Click += new System.EventHandler(btnViewForm_Click);
		this.btnChangePeriod.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnChangePeriod.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnChangePeriod.Location = new System.Drawing.Point(191, 629);
		this.btnChangePeriod.Name = "btnChangePeriod";
		this.btnChangePeriod.Size = new System.Drawing.Size(85, 23);
		this.btnChangePeriod.TabIndex = 7;
		this.btnChangePeriod.Text = "Change Period";
		this.btnChangePeriod.Click += new System.EventHandler(btnChangePeriod_Click);
		this.btnDeleteCompany.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.btnDeleteCompany.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnDeleteCompany.Location = new System.Drawing.Point(485, 629);
		this.btnDeleteCompany.Name = "btnDeleteCompany";
		this.btnDeleteCompany.Size = new System.Drawing.Size(85, 23);
		this.btnDeleteCompany.TabIndex = 9;
		this.btnDeleteCompany.Text = "Remove";
		this.btnDeleteCompany.Click += new System.EventHandler(btnDeleteCompany_Click);
		this.btnAddCompany.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.btnAddCompany.ForeColor = System.Drawing.SystemColors.ControlText;
		this.btnAddCompany.Location = new System.Drawing.Point(9, 629);
		this.btnAddCompany.Name = "btnAddCompany";
		this.btnAddCompany.Size = new System.Drawing.Size(85, 23);
		this.btnAddCompany.TabIndex = 5;
		this.btnAddCompany.Text = "Add Company";
		this.btnAddCompany.Click += new System.EventHandler(BtnAddCompanyClick);
		this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.lblStatus, this.lblImage });
		this.statusBar.Location = new System.Drawing.Point(0, 709);
		this.statusBar.Name = "statusBar";
		this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
		this.statusBar.Size = new System.Drawing.Size(1035, 22);
		this.statusBar.SizingGrip = false;
		this.statusBar.TabIndex = 3;
		this.statusBar.Text = "statusStrip1";
		this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
		this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblStatus.Name = "lblStatus";
		this.lblStatus.Size = new System.Drawing.Size(44, 17);
		this.lblStatus.Text = "Status";
		this.lblImage.BackColor = System.Drawing.SystemColors.Control;
		this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.lblImage.Name = "lblImage";
		this.lblImage.Size = new System.Drawing.Size(45, 17);
		this.lblImage.Text = "Image";
		this.timerMessagingHandling.Interval = 3000;
		this.timerMessagingHandling.Tick += new System.EventHandler(timerMessagingHandling_Tick);
		this.timerBlinkImage.Interval = 250;
		this.timerBlinkImage.Tick += new System.EventHandler(timerBlinkImage_Tick);
		this.chkReplaceGR.AutoSize = true;
		this.chkReplaceGR.Checked = true;
		this.chkReplaceGR.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkReplaceGR.Location = new System.Drawing.Point(188, 658);
		this.chkReplaceGR.Name = "chkReplaceGR";
		this.chkReplaceGR.Size = new System.Drawing.Size(167, 17);
		this.chkReplaceGR.TabIndex = 13;
		this.chkReplaceGR.Text = "Replace \"GR\" with \"EL\" in XML";
		this.chkReplaceGR.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnGenerateXML;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1035, 731);
		base.Controls.Add(this.gridCompanies);
		base.Controls.Add(this.gridMultipleCompanies);
		base.Controls.Add(this.statusBar);
		base.Controls.Add(this.gbMultipleCompanies);
		base.Controls.Add(this.gbCompaniesGroups);
		this.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmMultipleCompanyVATReturn";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Multi-Company VIES Declaration";
		base.Shown += new System.EventHandler(frmGroupVATReturn_Shown);
		((System.ComponentModel.ISupportInitialize)this.gridMultipleCompanies).EndInit();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).EndInit();
		this.gbMultipleCompanies.ResumeLayout(false);
		this.gbMultipleCompanies.PerformLayout();
		this.gbCompaniesGroups.ResumeLayout(false);
		this.statusBar.ResumeLayout(false);
		this.statusBar.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
