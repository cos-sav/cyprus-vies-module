using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Properties;

namespace xSAD_VIES.GUI;

public class FrmTechSupport : Form
{
	private IContainer components;

	private Button btnOk;

	private PictureBox pbxImage;

	private Label label3;

	private GroupBox groupBox2;

	private PictureBox pictureBox1;

	private LinkLabel lblEmail;

	private LinkLabel lblWWW;

	private Label label5;

	private Label label6;

	private Label label2;

	private Label label4;

	private Label label1;

	private Label label7;

	private Label label8;

	public FrmTechSupport()
	{
		InitializeComponent();
	}

	private void LblWwwLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			Process.Start(lblWWW.Text);
		}
		catch (Exception)
		{
		}
		finally
		{
			Cursor = Cursors.Default;
		}
	}

	private void LblEmailLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			Process.Start("mailto:" + lblEmail.Text);
		}
		catch (Exception)
		{
		}
		finally
		{
			Cursor = Cursors.Default;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmTechSupport));
		this.btnOk = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.lblEmail = new System.Windows.Forms.LinkLabel();
		this.lblWWW = new System.Windows.Forms.LinkLabel();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.pbxImage = new System.Windows.Forms.PictureBox();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pbxImage).BeginInit();
		base.SuspendLayout();
		this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnOk.Location = new System.Drawing.Point(446, 377);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 1;
		this.btnOk.Text = "Close";
		this.btnOk.UseVisualStyleBackColor = true;
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.FromArgb(93, 135, 38);
		this.label3.Location = new System.Drawing.Point(4, 44);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(221, 45);
		this.label3.TabIndex = 6;
		this.label3.Text = "Cyprus VIES";
		this.groupBox2.Controls.Add(this.label8);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.label1);
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Controls.Add(this.lblEmail);
		this.groupBox2.Controls.Add(this.lblWWW);
		this.groupBox2.Controls.Add(this.pictureBox1);
		this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.groupBox2.Location = new System.Drawing.Point(218, 12);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(303, 352);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "For Technical Support please contact : ";
		this.label8.AutoSize = true;
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(12, 220);
		this.label8.Margin = new System.Windows.Forms.Padding(3);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(41, 13);
		this.label8.TabIndex = 16;
		this.label8.Text = "E-mail :";
		this.label7.AutoSize = true;
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(12, 201);
		this.label7.Margin = new System.Windows.Forms.Padding(3);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(36, 13);
		this.label7.TabIndex = 15;
		this.label7.Text = "Web :";
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(83, 182);
		this.label6.Margin = new System.Windows.Forms.Padding(3);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(88, 13);
		this.label6.TabIndex = 14;
		this.label6.Text = "+357 22 660 826";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(83, 163);
		this.label2.Margin = new System.Windows.Forms.Padding(3);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(88, 13);
		this.label2.TabIndex = 14;
		this.label2.Text = "+357 22 444 453";
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(12, 182);
		this.label4.Margin = new System.Windows.Forms.Padding(3);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(30, 13);
		this.label4.TabIndex = 13;
		this.label4.Text = "Fax :";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(12, 163);
		this.label1.Margin = new System.Windows.Forms.Padding(3);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(64, 13);
		this.label1.TabIndex = 13;
		this.label1.Text = "Telephone :";
		this.label5.AutoSize = true;
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(12, 25);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(151, 104);
		this.label5.TabIndex = 10;
		this.label5.Text = "AccountsTech Solutions Ltd\r\n\r\nSupport Department\r\n\r\n41, Arch. Makarios III Ave\r\nMakariou Toumazis Tower\r\nOffice Suite 22, 1065 Nicosia, \r\nCyprus";
		this.lblEmail.AutoSize = true;
		this.lblEmail.ForeColor = System.Drawing.Color.Blue;
		this.lblEmail.Location = new System.Drawing.Point(83, 220);
		this.lblEmail.Name = "lblEmail";
		this.lblEmail.Size = new System.Drawing.Size(164, 13);
		this.lblEmail.TabIndex = 12;
		this.lblEmail.TabStop = true;
		this.lblEmail.Text = "sagesupport@accountstech.com";
		this.lblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LblEmailLinkClicked);
		this.lblWWW.AutoSize = true;
		this.lblWWW.ForeColor = System.Drawing.Color.Blue;
		this.lblWWW.Location = new System.Drawing.Point(83, 201);
		this.lblWWW.Margin = new System.Windows.Forms.Padding(3);
		this.lblWWW.Name = "lblWWW";
		this.lblWWW.Size = new System.Drawing.Size(122, 13);
		this.lblWWW.TabIndex = 11;
		this.lblWWW.TabStop = true;
		this.lblWWW.Text = "www.accountstech.com";
		this.lblWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LblWwwLinkClicked);
		this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.pictureBox1.Image = xSAD_VIES.Properties.Resources.accountstechLogo;
		this.pictureBox1.Location = new System.Drawing.Point(14, 284);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(274, 54);
		this.pictureBox1.TabIndex = 7;
		this.pictureBox1.TabStop = false;
		this.pbxImage.Image = xSAD_VIES.Properties.Resources.ImageLines3;
		this.pbxImage.Location = new System.Drawing.Point(12, 175);
		this.pbxImage.Name = "pbxImage";
		this.pbxImage.Size = new System.Drawing.Size(192, 189);
		this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.pbxImage.TabIndex = 2;
		this.pbxImage.TabStop = false;
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnOk;
		base.ClientSize = new System.Drawing.Size(533, 412);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.pbxImage);
		base.Controls.Add(this.btnOk);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmTechSupport";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Technical Support";
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pbxImage).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
