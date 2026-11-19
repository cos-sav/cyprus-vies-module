using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;

namespace xSAD_VIES.GUI;

public class frmSelectGroup : Form
{
	private frmMultipleCompanyVATReturn _MyParent;

	private int _MultipleCompanyID;

	private IContainer components;

	private GroupBox gbPeriods;

	private Button btnCancel;

	private Button btnSelect;

	private DataGridView gridGroups;

	private DataGridViewTextBoxColumn PKGroupID;

	private DataGridViewTextBoxColumn GroupName;

	private DataGridViewTextBoxColumn VATReg;

	private Label label2;

	private TextBox txbFilter;

	private Label label7;

	public frmSelectGroup(frmMultipleCompanyVATReturn ParentForm, int MultipleCompanyID)
	{
		InitializeComponent();
		PrepareControls();
		_MyParent = ParentForm;
		_MultipleCompanyID = MultipleCompanyID;
		LoadAllGroups();
	}

	private void PrepareControls()
	{
		gridGroups.AutoGenerateColumns = false;
	}

	private void LoadAllGroups()
	{
		DataTable dataTable = Controller.SelectAllGroups(Controller2.GetSageVersion());
		for (int num = dataTable.Rows.Count - 1; num >= 0; num--)
		{
			if (Controller.IsGroupMultipleCompanyExists(_MultipleCompanyID, (int)dataTable.Rows[num]["PKGroupID"]))
			{
				dataTable.Rows.RemoveAt(num);
			}
		}
		gridGroups.DataSource = dataTable;
		if (dataTable.Rows.Count == 0)
		{
			btnSelect.Enabled = false;
		}
		gridGroups.ClearSelection();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnSelect_Click(object sender, EventArgs e)
	{
		foreach (DataGridViewRow item in (IEnumerable)gridGroups.Rows)
		{
			if (item.Selected)
			{
				if (!(item.DataBoundItem is DataRowView dataRowView))
				{
					return;
				}
				List<ViesEntity> groupViesEntities = XmlFuncs.GetGroupViesEntities((int)dataRowView["PKGroupID"]);
				if (groupViesEntities.Count > 0)
				{
					string period = groupViesEntities[groupViesEntities.Count - 1].PeriodFrom.ToString("yyyyMMdd") + "_" + groupViesEntities[groupViesEntities.Count - 1].PeriodTo.ToString("yyyyMMdd");
					Controller.InsertChildCompany(_MultipleCompanyID, "", (string)dataRowView["Name"], (string)dataRowView["VATReg"], period, include: true, isGroup: true, (int)dataRowView["PKGroupID"]);
				}
				else
				{
					Controller.InsertChildCompany(_MultipleCompanyID, "", (string)dataRowView["Name"], (string)dataRowView["VATReg"], "Not Selected", include: true, isGroup: true, (int)dataRowView["PKGroupID"]);
				}
			}
		}
		_MyParent.LoadAllChildrenCompanies();
		Close();
	}

	private void gridGroups_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && gridGroups.Rows.Count > 0)
		{
			btnSelect.Enabled = true;
		}
	}

	private void frmSelectGroup_Shown(object sender, EventArgs e)
	{
		gridGroups.ClearSelection();
		btnSelect.Enabled = false;
	}

	private void txbFilter_TextChanged(object sender, EventArgs e)
	{
		if (txbFilter.Text != string.Empty)
		{
			((DataTable)gridGroups.DataSource).DefaultView.RowFilter = string.Format("NAME LIKE '%{0}%' OR VATReg LIKE '%{0}%'", txbFilter.Text);
		}
		else
		{
			((DataTable)gridGroups.DataSource).DefaultView.RowFilter = "";
		}
	}

	private void gridGroups_DoubleClick(object sender, EventArgs e)
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
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmSelectGroup));
		this.gbPeriods = new System.Windows.Forms.GroupBox();
		this.label2 = new System.Windows.Forms.Label();
		this.txbFilter = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.gridGroups = new System.Windows.Forms.DataGridView();
		this.PKGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.VATReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnSelect = new System.Windows.Forms.Button();
		this.gbPeriods.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.gridGroups).BeginInit();
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
		this.gbPeriods.Text = "Available Groups";
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label2.ForeColor = System.Drawing.Color.Gray;
		this.label2.Location = new System.Drawing.Point(187, 43);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(317, 13);
		this.label2.TabIndex = 12;
		this.label2.Text = " You can search for groups by Name or VAT Registration Number";
		this.txbFilter.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.txbFilter.Location = new System.Drawing.Point(312, 19);
		this.txbFilter.Name = "txbFilter";
		this.txbFilter.Size = new System.Drawing.Size(188, 21);
		this.txbFilter.TabIndex = 11;
		this.txbFilter.TextChanged += new System.EventHandler(txbFilter_TextChanged);
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 8.25f);
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(266, 22);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 13);
		this.label7.TabIndex = 10;
		this.label7.Text = "Search";
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
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.gridGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.gridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gridGroups.Columns.AddRange(this.PKGroupID, this.GroupName, this.VATReg);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.gridGroups.DefaultCellStyle = dataGridViewCellStyle2;
		this.gridGroups.Location = new System.Drawing.Point(21, 74);
		this.gridGroups.Margin = new System.Windows.Forms.Padding(6);
		this.gridGroups.Name = "gridGroups";
		this.gridGroups.ReadOnly = true;
		this.gridGroups.RowHeadersVisible = false;
		this.gridGroups.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
		this.gridGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
		this.gridGroups.Size = new System.Drawing.Size(491, 281);
		this.gridGroups.TabIndex = 1;
		this.gridGroups.DoubleClick += new System.EventHandler(gridGroups_DoubleClick);
		this.gridGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(gridGroups_CellClick);
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
		this.VATReg.HeaderText = "VAT Registration";
		this.VATReg.Name = "VATReg";
		this.VATReg.ReadOnly = true;
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(446, 377);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 2;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnSelect.Location = new System.Drawing.Point(365, 377);
		this.btnSelect.Name = "btnSelect";
		this.btnSelect.Size = new System.Drawing.Size(75, 23);
		this.btnSelect.TabIndex = 1;
		this.btnSelect.Text = "Select ";
		this.btnSelect.UseVisualStyleBackColor = true;
		this.btnSelect.Click += new System.EventHandler(btnSelect_Click);
		base.AcceptButton = this.btnSelect;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(533, 412);
		base.Controls.Add(this.gridGroups);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSelect);
		base.Controls.Add(this.gbPeriods);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmSelectGroup";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Select Group";
		base.Shown += new System.EventHandler(frmSelectGroup_Shown);
		this.gbPeriods.ResumeLayout(false);
		this.gbPeriods.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.gridGroups).EndInit();
		base.ResumeLayout(false);
	}
}
