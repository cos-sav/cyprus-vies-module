using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.BL;
using xSAD_VIES.DAL;

namespace xSAD_VIES.GUI;

public class frmManageGroup : Form
{
	private Objects.GroupObject _CurrentEntity;

	private bool _IsEditMode;

	private frmGroupVATReturn _MyParent;

	private IContainer components;

	private GroupBox gbGroups;

	private Label lblVATReg;

	private Label lblGroupName;

	private TextBox txtVATReg;

	private TextBox txtName;

	private Button btnSave;

	private Button btnCancel;

	private ErrorProvider errorProvider;

	private Timer timerMessagingHandling;

	public Objects.GroupObject CurrentEntity
	{
		get
		{
			return _CurrentEntity;
		}
		set
		{
			_CurrentEntity = value;
			txtName.Text = _CurrentEntity.Name;
			txtVATReg.Text = _CurrentEntity.VatReg;
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

	public frmManageGroup(frmGroupVATReturn _ParentForm)
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
			if (!Controller.IsGroupNameExists(txtName.Text, -1))
			{
				if (!Controller.IsGroupVatRegExists(txtVATReg.Text, -1))
				{
					if (_CurrentEntity == null)
					{
						_CurrentEntity = new Objects.GroupObject();
					}
					_CurrentEntity.Name = txtName.Text;
					_CurrentEntity.VatReg = txtVATReg.Text;
					_CurrentEntity.PkGroupId = Controller.InsertGroup(_CurrentEntity.Name, _CurrentEntity.VatReg, Controller2.GetSageVersion());
					_MyParent.ShowMessage("New Group <" + txtName.Text + "> created!");
					_MyParent.LoadAllGroups();
					_MyParent.DisableButtons();
					Close();
				}
				else
				{
					errorProvider.SetError(txtVATReg, "VAT registration number already exits!");
					timerMessagingHandling.Enabled = true;
					timerMessagingHandling.Start();
				}
			}
			else
			{
				errorProvider.SetError(txtName, "Group's name already added!");
				timerMessagingHandling.Enabled = true;
				timerMessagingHandling.Start();
			}
		}
		else if (!Controller.IsGroupNameExists(txtName.Text, _CurrentEntity.PkGroupId))
		{
			if (!Controller.IsGroupVatRegExists(txtVATReg.Text, _CurrentEntity.PkGroupId))
			{
				Controller.SaveGroup(_CurrentEntity.PkGroupId, txtName.Text, txtVATReg.Text);
				Service.RenameGroupFolder(_CurrentEntity.Name, txtName.Text);
				_MyParent.DisableButtons();
				_MyParent.LoadAllGroups();
				_MyParent.ShowMessage("Group <" + txtName.Text + "> saved!");
				Close();
			}
			else
			{
				errorProvider.SetError(txtVATReg, "VAT registration number already exits!");
				timerMessagingHandling.Enabled = true;
				timerMessagingHandling.Start();
			}
		}
		else
		{
			errorProvider.SetError(txtName, "Group's name already added!");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.frmManageGroup));
		this.gbGroups = new System.Windows.Forms.GroupBox();
		this.lblVATReg = new System.Windows.Forms.Label();
		this.lblGroupName = new System.Windows.Forms.Label();
		this.txtVATReg = new System.Windows.Forms.TextBox();
		this.txtName = new System.Windows.Forms.TextBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
		this.timerMessagingHandling = new System.Windows.Forms.Timer(this.components);
		this.gbGroups.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).BeginInit();
		base.SuspendLayout();
		this.gbGroups.BackColor = System.Drawing.Color.Transparent;
		this.gbGroups.Controls.Add(this.lblVATReg);
		this.gbGroups.Controls.Add(this.lblGroupName);
		this.gbGroups.Controls.Add(this.txtVATReg);
		this.gbGroups.Controls.Add(this.txtName);
		this.gbGroups.ForeColor = System.Drawing.Color.Chocolate;
		this.gbGroups.Location = new System.Drawing.Point(12, 12);
		this.gbGroups.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.gbGroups.Name = "gbGroups";
		this.gbGroups.Size = new System.Drawing.Size(420, 112);
		this.gbGroups.TabIndex = 0;
		this.gbGroups.TabStop = false;
		this.gbGroups.Text = "Group Details";
		this.lblVATReg.AutoSize = true;
		this.lblVATReg.ForeColor = System.Drawing.SystemColors.ControlText;
		this.lblVATReg.Location = new System.Drawing.Point(15, 52);
		this.lblVATReg.Name = "lblVATReg";
		this.lblVATReg.Size = new System.Drawing.Size(51, 13);
		this.lblVATReg.TabIndex = 13;
		this.lblVATReg.Text = "VAT Reg";
		this.lblGroupName.AutoSize = true;
		this.lblGroupName.ForeColor = System.Drawing.SystemColors.ControlText;
		this.lblGroupName.Location = new System.Drawing.Point(15, 26);
		this.lblGroupName.Name = "lblGroupName";
		this.lblGroupName.Size = new System.Drawing.Size(35, 13);
		this.lblGroupName.TabIndex = 12;
		this.lblGroupName.Text = "Name";
		this.txtVATReg.Location = new System.Drawing.Point(107, 49);
		this.txtVATReg.Name = "txtVATReg";
		this.txtVATReg.Size = new System.Drawing.Size(142, 20);
		this.txtVATReg.TabIndex = 2;
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
		base.Name = "frmManageGroup";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Add New Group";
		this.gbGroups.ResumeLayout(false);
		this.gbGroups.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.errorProvider).EndInit();
		base.ResumeLayout(false);
	}
}
