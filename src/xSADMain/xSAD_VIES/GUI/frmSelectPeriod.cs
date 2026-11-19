using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;

namespace xSAD_VIES.GUI;

public class frmSelectPeriod : Form
{
	private frmGroupVATReturn _MyParent;

	private frmMultipleCompanyVATReturn _MyParent2;

	private bool _IsGroupForm;

	private bool _IsGroup;

	private string _CompanyCode;

	private int _ID;

	private int _GroupId;

	private IContainer components;

	private GroupBox gbPeriods;

	private Button btnCancel;

	private Button btnSelect;

	private DataGridView gridXMLFilesPeriods;

	private DataGridViewTextBoxColumn PeriodFrom;

	private DataGridViewTextBoxColumn PeriodTo;

	public frmSelectPeriod(object parentForm, bool isGroupForm, string companyCode, int id, bool isGroup, int groupId)
	{
		InitializeComponent();
		PrepareControls();
		_IsGroupForm = isGroupForm;
		_CompanyCode = companyCode;
		_ID = id;
		_IsGroup = isGroup;
		_GroupId = groupId;
		if (_IsGroupForm)
		{
			_MyParent = (frmGroupVATReturn)parentForm;
		}
		else
		{
			_MyParent2 = (frmMultipleCompanyVATReturn)parentForm;
		}
		LoadAllPeriods();
	}

	private void PrepareControls()
	{
		gridXMLFilesPeriods.AutoGenerateColumns = false;
	}

	private void LoadAllPeriods()
	{
		btnSelect.Enabled = false;
		if (_IsGroup)
		{
			gridXMLFilesPeriods.DataSource = XmlFuncs.GetGroupViesEntities(_GroupId);
		}
		else
		{
			SageCompany sageCompanyFromCompanyCode = SageController.GetSageCompanyFromCompanyCode(_CompanyCode);
			if (sageCompanyFromCompanyCode == null)
			{
				return;
			}
			gridXMLFilesPeriods.DataSource = XmlFuncs.GetCompanyViesEntities(sageCompanyFromCompanyCode);
		}
		gridXMLFilesPeriods.ClearSelection();
		gridXMLFilesPeriods.CurrentCell = null;
	}

	private void BtnCancelClick(object sender, EventArgs e)
	{
		Close();
	}

	private void BtnSelectClick(object sender, EventArgs e)
	{
		if (_IsGroupForm)
		{
			if (gridXMLFilesPeriods.CurrentRow == null || !(gridXMLFilesPeriods.CurrentRow.DataBoundItem is ViesEntity viesEntity))
			{
				return;
			}
			Controller.SaveCompanyPeriod(_ID, viesEntity.PeriodFrom.ToString("yyyyMMdd") + "_" + viesEntity.PeriodTo.ToString("yyyyMMdd"));
			_MyParent.LoadAllCompanies();
		}
		else
		{
			if (gridXMLFilesPeriods.CurrentRow == null || !(gridXMLFilesPeriods.CurrentRow.DataBoundItem is ViesEntity viesEntity2))
			{
				return;
			}
			Controller.SaveChildCompanyPeriod(_ID, viesEntity2.PeriodFrom.ToString("yyyyMMdd") + "_" + viesEntity2.PeriodTo.ToString("yyyyMMdd"));
			_MyParent2.LoadAllChildrenCompanies();
		}
		Close();
	}

	private void FrmSelectPeriodShown(object sender, EventArgs e)
	{
		gridXMLFilesPeriods.ClearSelection();
		gridXMLFilesPeriods.Focus();
	}

	private void GridXmlFilesPeriodsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (e.RowIndex > -1)
		{
			e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			e.Value = Convert.ToDateTime(e.Value).ToShortDateString();
		}
	}

	private void GridXmlFilesPeriodsCellClick(object sender, DataGridViewCellEventArgs e)
	{
		btnSelect.Enabled = true;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmSelectPeriod));
		this.gbPeriods = new System.Windows.Forms.GroupBox();
		this.gridXMLFilesPeriods = new System.Windows.Forms.DataGridView();
		this.PeriodFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.PeriodTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnSelect = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)this.gridXMLFilesPeriods).BeginInit();
		base.SuspendLayout();
		this.gbPeriods.ForeColor = System.Drawing.Color.Chocolate;
		this.gbPeriods.Location = new System.Drawing.Point(12, 12);
		this.gbPeriods.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbPeriods.Name = "gbPeriods";
		this.gbPeriods.Size = new System.Drawing.Size(509, 352);
		this.gbPeriods.TabIndex = 0;
		this.gbPeriods.TabStop = false;
		this.gbPeriods.Text = "Available Periods ";
		this.gridXMLFilesPeriods.AllowUserToAddRows = false;
		this.gridXMLFilesPeriods.AllowUserToDeleteRows = false;
		this.gridXMLFilesPeriods.AllowUserToResizeColumns = false;
		this.gridXMLFilesPeriods.AllowUserToResizeRows = false;
		this.gridXMLFilesPeriods.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gridXMLFilesPeriods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.gridXMLFilesPeriods.BackgroundColor = System.Drawing.Color.White;
		this.gridXMLFilesPeriods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.gridXMLFilesPeriods.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
		this.gridXMLFilesPeriods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
		this.gridXMLFilesPeriods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridXMLFilesPeriods.Columns.AddRange(this.PeriodFrom, this.PeriodTo);
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.gridXMLFilesPeriods.DefaultCellStyle = dataGridViewCellStyle;
		this.gridXMLFilesPeriods.Location = new System.Drawing.Point(21, 34);
		this.gridXMLFilesPeriods.Margin = new System.Windows.Forms.Padding(6);
		this.gridXMLFilesPeriods.MultiSelect = false;
		this.gridXMLFilesPeriods.Name = "gridXMLFilesPeriods";
		this.gridXMLFilesPeriods.ReadOnly = true;
		this.gridXMLFilesPeriods.RowHeadersVisible = false;
		this.gridXMLFilesPeriods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
		this.gridXMLFilesPeriods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridXMLFilesPeriods.Size = new System.Drawing.Size(491, 321);
		this.gridXMLFilesPeriods.TabIndex = 1;
		this.gridXMLFilesPeriods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(GridXmlFilesPeriodsCellFormatting);
		this.gridXMLFilesPeriods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(GridXmlFilesPeriodsCellClick);
		this.PeriodFrom.DataPropertyName = "PeriodFrom";
		this.PeriodFrom.HeaderText = "Period From";
		this.PeriodFrom.Name = "PeriodFrom";
		this.PeriodFrom.ReadOnly = true;
		this.PeriodTo.DataPropertyName = "PeriodTo";
		this.PeriodTo.HeaderText = "Period To";
		this.PeriodTo.Name = "PeriodTo";
		this.PeriodTo.ReadOnly = true;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(446, 377);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 2;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(BtnCancelClick);
		this.btnSelect.Location = new System.Drawing.Point(365, 377);
		this.btnSelect.Name = "btnSelect";
		this.btnSelect.Size = new System.Drawing.Size(75, 23);
		this.btnSelect.TabIndex = 1;
		this.btnSelect.Text = "Select ";
		this.btnSelect.UseVisualStyleBackColor = true;
		this.btnSelect.Click += new System.EventHandler(BtnSelectClick);
		base.AcceptButton = this.btnSelect;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(533, 412);
		base.Controls.Add(this.gridXMLFilesPeriods);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSelect);
		base.Controls.Add(this.gbPeriods);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmSelectPeriod";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Select Period";
		base.Shown += new System.EventHandler(FrmSelectPeriodShown);
		((System.ComponentModel.ISupportInitialize)this.gridXMLFilesPeriods).EndInit();
		base.ResumeLayout(false);
	}
}
