using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;

namespace xSAD_VIES.GUI;

public class frmSelectCompany : Form
{
	private frmGroupVATReturn _MyParent;

	private frmMultipleCompanyVATReturn _MyParent2;

	private int _GroupID;

	private bool _IsGroup;

	private IContainer components;

	private GroupBox gbPeriods;

	private Button btnCancel;

	private Button btnSelect;

	private DataGridView gridCompanies;

	private DataGridViewTextBoxColumn PKCompanyID;

	private DataGridViewTextBoxColumn CompanyCode;

	private DataGridViewTextBoxColumn GroupName;

	private DataGridViewTextBoxColumn VATReg;

	private TextBox txbFilter;

	private Label label7;

	private Label label2;

	public frmSelectCompany(object ParentForm, int GroupID, bool IsGroup)
	{
		InitializeComponent();
		PrepareControls();
		if (IsGroup)
		{
			_MyParent = (frmGroupVATReturn)ParentForm;
		}
		else
		{
			_MyParent2 = (frmMultipleCompanyVATReturn)ParentForm;
		}
		_GroupID = GroupID;
		_IsGroup = IsGroup;
		LoadAllRecords();
	}

	private void PrepareControls()
	{
		gridCompanies.AutoGenerateColumns = false;
	}

	private void LoadAllRecords()
	{
		List<SageCompany> list = SageController.SelectAllSageCompanies();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (_IsGroup)
			{
				if (Controller.IsCompanyExists(_GroupID, list[num].CompanyCode))
				{
					list.RemoveAt(num);
				}
			}
			else if (Controller.IsChildCompanyExists(_GroupID, list[num].CompanyCode))
			{
				list.RemoveAt(num);
			}
		}
		gridCompanies.DataSource = list;
		if (list.Count == 0)
		{
			btnSelect.Enabled = false;
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnSelect_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow item in (IEnumerable)gridCompanies.Rows)
		{
			if (!item.Selected)
			{
				continue;
			}
			if (!(item.DataBoundItem is SageCompany sageCompany))
			{
				return;
			}
			if (_IsGroup)
			{
				List<ViesEntity> companyViesEntities = XmlFuncs.GetCompanyViesEntities(sageCompany);
				if (companyViesEntities.Count > 0)
				{
					string period = companyViesEntities[companyViesEntities.Count - 1].PeriodFrom.ToString("yyyyMMdd") + "_" + companyViesEntities[companyViesEntities.Count - 1].PeriodTo.ToString("yyyyMMdd");
					Controller.InsertCompany(_GroupID, sageCompany.CompanyCode, sageCompany.Name, sageCompany.SageVatRegistrationNumber, period, include: true);
				}
				else
				{
					Controller.InsertCompany(_GroupID, sageCompany.CompanyCode, sageCompany.Name, sageCompany.SageVatRegistrationNumber, "Not Selected", include: true);
				}
			}
			else
			{
				List<ViesEntity> companyViesEntities2 = XmlFuncs.GetCompanyViesEntities(sageCompany);
				if (companyViesEntities2.Count > 0)
				{
					string period2 = companyViesEntities2[companyViesEntities2.Count - 1].PeriodFrom.ToString("yyyyMMdd") + "_" + companyViesEntities2[companyViesEntities2.Count - 1].PeriodTo.ToString("yyyyMMdd");
					Controller.InsertChildCompany(_GroupID, sageCompany.CompanyCode, sageCompany.Name, sageCompany.SageVatRegistrationNumber, period2, include: true, isGroup: false, -1);
				}
				else
				{
					Controller.InsertChildCompany(_GroupID, sageCompany.CompanyCode, sageCompany.Name, sageCompany.SageVatRegistrationNumber, "Not Selected", include: true, isGroup: false, -1);
				}
			}
		}
		if (_IsGroup)
		{
			_MyParent.LoadAllCompanies();
		}
		else
		{
			_MyParent2.LoadAllChildrenCompanies();
		}
		Close();
	}

	private void frmSelectCompany_Shown(object sender, EventArgs e)
	{
		gridCompanies.ClearSelection();
		btnSelect.Enabled = false;
	}

	private void gridCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && gridCompanies.Rows.Count > 0)
		{
			btnSelect.Enabled = true;
		}
	}

	private void txbFilter_TextChanged(object sender, EventArgs e)
	{
		string filterLower = txbFilter.Text.ToLower();
		LoadAllRecords();
		List<SageCompany> dataSource = ((List<SageCompany>)gridCompanies.DataSource).FindAll((SageCompany c) => c.Name.ToLower().Contains(filterLower) || c.SageVatRegistrationNumber.ToLower().Contains(filterLower));
		gridCompanies.DataSource = dataSource;
		gridCompanies.ClearSelection();
	}

	private void gridCompanies_DoubleClick(object sender, EventArgs e)
	{
		btnSelect_Click(null, null);
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmSelectCompany));
		this.gbPeriods = new System.Windows.Forms.GroupBox();
		this.label2 = new System.Windows.Forms.Label();
		this.txbFilter = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.gridCompanies = new System.Windows.Forms.DataGridView();
		this.PKCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.CompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.VATReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnSelect = new System.Windows.Forms.Button();
		this.gbPeriods.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).BeginInit();
		base.SuspendLayout();
		this.gbPeriods.Controls.Add(this.label2);
		this.gbPeriods.Controls.Add(this.txbFilter);
		this.gbPeriods.Controls.Add(this.label7);
		this.gbPeriods.ForeColor = System.Drawing.Color.Chocolate;
		this.gbPeriods.Location = new System.Drawing.Point(12, 12);
		this.gbPeriods.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbPeriods.Name = "gbPeriods";
		this.gbPeriods.Size = new System.Drawing.Size(509, 352);
		this.gbPeriods.TabIndex = 0;
		this.gbPeriods.TabStop = false;
		this.gbPeriods.Text = "Available Companies";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label2.ForeColor = System.Drawing.Color.Gray;
		this.label2.Location = new System.Drawing.Point(169, 41);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(334, 13);
		this.label2.TabIndex = 9;
		this.label2.Text = " You can search for companies by Name or VAT Registration Number";
		this.txbFilter.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.txbFilter.Location = new System.Drawing.Point(312, 17);
		this.txbFilter.Name = "txbFilter";
		this.txbFilter.Size = new System.Drawing.Size(188, 21);
		this.txbFilter.TabIndex = 8;
		this.txbFilter.TextChanged += new System.EventHandler(txbFilter_TextChanged);
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(266, 20);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 13);
		this.label7.TabIndex = 7;
		this.label7.Text = "Search";
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
		this.gridCompanies.Columns.AddRange(this.PKCompanyID, this.CompanyCode, this.GroupName, this.VATReg);
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.gridCompanies.DefaultCellStyle = dataGridViewCellStyle;
		this.gridCompanies.Location = new System.Drawing.Point(21, 72);
		this.gridCompanies.Margin = new System.Windows.Forms.Padding(6);
		this.gridCompanies.Name = "gridCompanies";
		this.gridCompanies.ReadOnly = true;
		this.gridCompanies.RowHeadersVisible = false;
		this.gridCompanies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
		this.gridCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridCompanies.Size = new System.Drawing.Size(491, 283);
		this.gridCompanies.TabIndex = 1;
		this.gridCompanies.DoubleClick += new System.EventHandler(gridCompanies_DoubleClick);
		this.gridCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(gridCompanies_CellClick);
		this.PKCompanyID.DataPropertyName = "PKCompanyID";
		this.PKCompanyID.HeaderText = "PKCompanyID";
		this.PKCompanyID.Name = "PKCompanyID";
		this.PKCompanyID.ReadOnly = true;
		this.PKCompanyID.Visible = false;
		this.CompanyCode.DataPropertyName = "CompanyCode";
		this.CompanyCode.HeaderText = "CompanyCode";
		this.CompanyCode.Name = "CompanyCode";
		this.CompanyCode.ReadOnly = true;
		this.CompanyCode.Visible = false;
		this.GroupName.DataPropertyName = "Name";
		this.GroupName.FillWeight = 70f;
		this.GroupName.HeaderText = "Name";
		this.GroupName.Name = "GroupName";
		this.GroupName.ReadOnly = true;
		this.VATReg.DataPropertyName = "VATReg";
		this.VATReg.FillWeight = 30f;
		this.VATReg.HeaderText = "VAT Registration";
		this.VATReg.Name = "VATReg";
		this.VATReg.ReadOnly = true;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(446, 377);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 7;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnSelect.Location = new System.Drawing.Point(365, 377);
		this.btnSelect.Name = "btnSelect";
		this.btnSelect.Size = new System.Drawing.Size(75, 23);
		this.btnSelect.TabIndex = 6;
		this.btnSelect.Text = "Select ";
		this.btnSelect.UseVisualStyleBackColor = true;
		this.btnSelect.Click += new System.EventHandler(btnSelect_Click);
		base.AcceptButton = this.btnSelect;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(533, 412);
		base.Controls.Add(this.gridCompanies);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSelect);
		base.Controls.Add(this.gbPeriods);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.HelpButton = true;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmSelectCompany";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Select Company";
		base.Shown += new System.EventHandler(frmSelectCompany_Shown);
		this.gbPeriods.ResumeLayout(false);
		this.gbPeriods.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.gridCompanies).EndInit();
		base.ResumeLayout(false);
	}
}
