using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.BL;
using xSAD_VIES.DAL;

namespace xSAD_VIES.GUI;

public class frmManageMultipleCompany : Form
{
	private Objects.MultipleCompanyObject _CurrentEntity;

	private bool _IsEditMode;

	private frmMultipleCompanyVATReturn _MyParent;

	private IContainer components;

	private GroupBox gbGroups;

	private Label lblGroupName;

	private TextBox txtName;

	private Button btnSave;

	private Button btnCancel;

	private ErrorProvider errorProvider;

	private Timer timerMessagingHandling;

	public Objects.MultipleCompanyObject CurrentEntity
	{
		get
		{
			return _CurrentEntity;
		}
		set
		{
			_CurrentEntity = value;
			txtName.Text = _CurrentEntity.Name;
			Text = "Group - " + _CurrentEntity.Name;
		}
	}

	public bool IsEditMode
	{
		get
		{
			return _IsEditMode;
		}
		set
		{
			_IsEditMode = value;
		}
	}

	public frmManageMultipleCompany(frmMultipleCompanyVATReturn _ParentForm)
	{
		InitializeComponent();
		_MyParent = _ParentForm;
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (txtName.Text.Trim() == "")
		{
			errorProvider.SetError(txtName, "Please enter a valid name!");
			timerMessagingHandling.Enabled = true;
			timerMessagingHandling.Start();
		}
		else if (!_IsEditMode)
		{
			if (!Controller.IsMultipleCompanyNameExists(txtName.Text, -1))
			{
				if (_CurrentEntity == null)
				{
					_CurrentEntity = new Objects.MultipleCompanyObject();
				}
				_CurrentEntity.Name = txtName.Text;
				_CurrentEntity.PkMultipleCompanyId = Controller.InsertMultipleCompany(_CurrentEntity.Name, Controller2.GetSageVersion());
				_MyParent.ShowMessage("Company " + txtName.Text + " added!");
				_MyParent.LoadAllMultipleCompanies();
				_MyParent.DisableButtons();
				Close();
			}
			else
			{
				errorProvider.SetError(txtName, "Company with the same name already exists in the list!");
				timerMessagingHandling.Enabled = true;
				timerMessagingHandling.Start();
			}
		}
		else if (!Controller.IsMultipleCompanyNameExists(txtName.Text, _CurrentEntity.PkMultipleCompanyId))
		{
			Controller.SaveMultipleCompany(_CurrentEntity.PkMultipleCompanyId, txtName.Text);
			Service.RenameMultipleEntityFolder(_CurrentEntity.Name, txtName.Text);
			_MyParent.DisableButtons();
			_MyParent.LoadAllMultipleCompanies();
			_MyParent.ShowMessage("Multi " + txtName.Text + " saved!");
			Close();
		}
		else
		{
			errorProvider.SetError(txtName, "Company with the same name already exists in the list!");
			timerMessagingHandling.Enabled = true;
			timerMessagingHandling.Start();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void timerMessagingHandling_Tick(object sender, EventArgs e)
	{
		errorProvider.Clear();
		timerMessagingHandling.Stop();
		timerMessagingHandling.Enabled = false;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmManageMultipleCompany));
		this.gbGroups = new System.Windows.Forms.GroupBox();
		this.lblGroupName = new System.Windows.Forms.Label();
		this.txtName = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
		this.timerMessagingHandling = new System.Windows.Forms.Timer(this.components);
		this.gbGroups.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).BeginInit();
		base.SuspendLayout();
		this.gbGroups.BackColor = System.Drawing.Color.Transparent;
		this.gbGroups.Controls.Add(this.lblGroupName);
		this.gbGroups.Controls.Add(this.txtName);
		this.gbGroups.ForeColor = System.Drawing.Color.Chocolate;
		this.gbGroups.Location = new System.Drawing.Point(12, 12);
		this.gbGroups.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbGroups.Name = "gbGroups";
		this.gbGroups.Size = new System.Drawing.Size(420, 112);
		this.gbGroups.TabIndex = 0;
		this.gbGroups.TabStop = false;
		this.gbGroups.Text = "Multi-Company Declaration Details";
		this.lblGroupName.AutoSize = true;
		this.lblGroupName.ForeColor = System.Drawing.SystemColors.ControlText;
		this.lblGroupName.Location = new System.Drawing.Point(15, 26);
		this.lblGroupName.Name = "lblGroupName";
		this.lblGroupName.Size = new System.Drawing.Size(35, 13);
		this.lblGroupName.TabIndex = 12;
		this.lblGroupName.Text = "Name";
		this.txtName.Location = new System.Drawing.Point(107, 23);
		this.txtName.Name = "txtName";
		this.txtName.Size = new System.Drawing.Size(288, 20);
		this.txtName.TabIndex = 1;
		this.btnSave.Location = new System.Drawing.Point(256, 137);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(85, 23);
		this.btnSave.TabIndex = 3;
		this.btnSave.Text = "Save Changes";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(347, 137);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(85, 23);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(btnCancel_Click);
		this.errorProvider.ContainerControl = this;
		this.timerMessagingHandling.Interval = 3000;
		this.timerMessagingHandling.Tick += new System.EventHandler(timerMessagingHandling_Tick);
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(444, 172);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.gbGroups);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmManageMultipleCompany";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Add New Multi-Company Declaration";
		this.gbGroups.ResumeLayout(false);
		this.gbGroups.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).EndInit();
		base.ResumeLayout(false);
	}
}
