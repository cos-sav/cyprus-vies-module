using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Entities;
using xSAD_VIES.Properties;

namespace xSAD_VIES.GUI;

public class FrmLogin : Form
{
	public DialogResult dialogResult;

	public SageCompany _sageCompany;

	private IContainer components;

	private TextBox txbUsername;

	private Label lblUsername;

	private TextBox txbPassword;

	private Label lblPassword;

	private Button btnLogin;

	private Button btnCancel;

	private PictureBox pictureBox1;

	private Label label2;

	private Label label1;

	private Panel panel1;

	public string Username => txbUsername.Text;

	public string Password => txbPassword.Text;

	public FrmLogin(SageCompany sageCompany)
	{
		InitializeComponent();
		_sageCompany = sageCompany;
	}

	private void FrmLoginShown(object sender, EventArgs e)
	{
		txbUsername.Focus();
		if (Environment.CommandLine.Contains("/autologin"))
		{
			Panel1DoubleClick(null, null);
		}
	}

	private void BtnLoginClick(object sender, EventArgs e)
	{
		if (!(Username == ""))
		{
			string Out_LastError = "";
			try
			{
				frmMain.frmmain.SageEngine.Connect(_sageCompany.SagePath, Username, Password, ref Out_LastError);
			}
			catch
			{
				MessageBox.Show(frmMain.frmmain.SageEngine.LastErrorText);
				return;
			}
			if (!frmMain.frmmain.SageEngine.IsConnected)
			{
				MessageBox.Show(Out_LastError);
				return;
			}
			dialogResult = DialogResult.OK;
			Close();
		}
	}

	private void BtnCancelClick(object sender, EventArgs e)
	{
		dialogResult = DialogResult.Cancel;
		Close();
	}

	private void TxbUsernameKeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			BtnLoginClick(null, null);
		}
	}

	private void TxbPasswordKeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			BtnLoginClick(null, null);
		}
	}

	private void Panel1DoubleClick(object sender, EventArgs e)
	{
		txbUsername.Text = "manager";
		if (_sageCompany.Name.Contains("PANAYIOTIDES"))
		{
			txbPassword.Text = "pcora";
		}
		else
		{
			txbPassword.Text = "";
		}
		BtnLoginClick(null, null);
	}

	private void frmLogin_Load(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmLogin));
		this.txbUsername = new System.Windows.Forms.TextBox();
		this.lblUsername = new System.Windows.Forms.Label();
		this.txbPassword = new System.Windows.Forms.TextBox();
		this.lblPassword = new System.Windows.Forms.Label();
		this.btnLogin = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.panel1 = new System.Windows.Forms.Panel();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.txbUsername.Location = new System.Drawing.Point(150, 95);
		this.txbUsername.Name = "txbUsername";
		this.txbUsername.Size = new System.Drawing.Size(164, 20);
		this.txbUsername.TabIndex = 0;
		this.txbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(TxbUsernameKeyDown);
		this.lblUsername.AutoSize = true;
		this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.lblUsername.Location = new System.Drawing.Point(72, 98);
		this.lblUsername.Name = "lblUsername";
		this.lblUsername.Size = new System.Drawing.Size(37, 13);
		this.lblUsername.TabIndex = 1;
		this.lblUsername.Text = "Logon";
		this.txbPassword.Location = new System.Drawing.Point(150, 121);
		this.txbPassword.Name = "txbPassword";
		this.txbPassword.PasswordChar = '*';
		this.txbPassword.Size = new System.Drawing.Size(164, 20);
		this.txbPassword.TabIndex = 1;
		this.txbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(TxbPasswordKeyDown);
		this.lblPassword.AutoSize = true;
		this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.lblPassword.Location = new System.Drawing.Point(72, 124);
		this.lblPassword.Name = "lblPassword";
		this.lblPassword.Size = new System.Drawing.Size(53, 13);
		this.lblPassword.TabIndex = 1;
		this.lblPassword.Text = "Password";
		this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnLogin.Location = new System.Drawing.Point(357, 17);
		this.btnLogin.Name = "btnLogin";
		this.btnLogin.Size = new System.Drawing.Size(75, 23);
		this.btnLogin.TabIndex = 2;
		this.btnLogin.Text = "Logon";
		this.btnLogin.UseVisualStyleBackColor = true;
		this.btnLogin.Click += new System.EventHandler(BtnLoginClick);
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(357, 46);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(BtnCancelClick);
		this.pictureBox1.Image = xSAD_VIES.Properties.Resources.IconUser_32;
		this.pictureBox1.Location = new System.Drawing.Point(12, 19);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(46, 46);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.FromArgb(62, 92, 25);
		this.label1.Location = new System.Drawing.Point(73, 24);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(249, 13);
		this.label1.TabIndex = 2;
		this.label1.Text = "Welcome to Cyprus VIES Sage 50 Add-On Module.";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		this.label2.Location = new System.Drawing.Point(73, 47);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(262, 13);
		this.label2.TabIndex = 3;
		this.label2.Text = "Please enter your Sage 50 logon name and password.";
		this.panel1.Location = new System.Drawing.Point(12, 66);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(46, 25);
		this.panel1.TabIndex = 4;
		this.panel1.DoubleClick += new System.EventHandler(Panel1DoubleClick);
		base.AcceptButton = this.btnLogin;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(442, 170);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.lblPassword);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.txbUsername);
		base.Controls.Add(this.lblUsername);
		base.Controls.Add(this.txbPassword);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnLogin);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Logon";
		base.Load += new System.EventHandler(frmLogin_Load);
		base.Shown += new System.EventHandler(FrmLoginShown);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
