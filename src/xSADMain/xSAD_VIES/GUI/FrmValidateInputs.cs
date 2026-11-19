using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace xSAD_VIES.GUI;

public class FrmValidateInputs : Form
{
	public DialogResult dialogResult;

	private IContainer components;

	private Button btnOK;

	private Button btnCancel;

	public Label lblMessage;

	public FrmValidateInputs()
	{
		InitializeComponent();
	}

	private void FormValidateInputsLoad(object sender, EventArgs e)
	{
		dialogResult = DialogResult.Cancel;
	}

	private void BtnOkClick(object sender, EventArgs e)
	{
		dialogResult = DialogResult.OK;
		Close();
	}

	private void BtnCancelClick(object sender, EventArgs e)
	{
		dialogResult = DialogResult.Cancel;
		Close();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmValidateInputs));
		this.lblMessage = new System.Windows.Forms.Label();
		this.btnOK = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.lblMessage.Location = new System.Drawing.Point(13, 13);
		this.lblMessage.Name = "lblMessage";
		this.lblMessage.Size = new System.Drawing.Size(398, 74);
		this.lblMessage.TabIndex = 0;
		this.lblMessage.Text = "---";
		this.btnOK.Location = new System.Drawing.Point(117, 100);
		this.btnOK.Name = "btnOK";
		this.btnOK.Size = new System.Drawing.Size(75, 23);
		this.btnOK.TabIndex = 1;
		this.btnOK.Text = "Proceed";
		this.btnOK.UseVisualStyleBackColor = true;
		this.btnOK.Click += new System.EventHandler(BtnOkClick);
		this.btnCancel.Location = new System.Drawing.Point(227, 100);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 1;
		this.btnCancel.Text = "Go back";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(BtnCancelClick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(423, 135);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOK);
		base.Controls.Add(this.lblMessage);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmValidateInputs";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Missing inputs";
		base.Load += new System.EventHandler(FormValidateInputsLoad);
		base.ResumeLayout(false);
	}
}
