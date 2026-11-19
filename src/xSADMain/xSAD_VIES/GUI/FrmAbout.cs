using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Properties;

namespace xSAD_VIES.GUI;

public class FrmAbout : Form
{
	private IContainer components;

	private GroupBox groupBox2;

	private Label label3;

	private Button btnOk;

	private GroupBox groupBox1;

	private Label label4;

	private Label label2;

	private Label label1;

	private Label label6;

	private Label lblVersion;

	private Label label7;

	private Label label5;

	private PictureBox pictureBox1;

	private Label label8;

	private Label label9;

	public FrmAbout()
	{
		InitializeComponent();
		lblVersion.Text = Application.ProductVersion;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmAbout));
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.btnOk = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label8 = new System.Windows.Forms.Label();
		this.label9 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.lblVersion = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox2.SuspendLayout();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.groupBox2.Location = new System.Drawing.Point(218, 12);
		this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(303, 100);
		this.groupBox2.TabIndex = 8;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Developed by : ";
		this.label5.AutoSize = true;
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(12, 25);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(211, 52);
		this.label5.TabIndex = 9;
		this.label5.Text = "AccountsTech Software Developments Ltd\r\n\r\nCopyright © 2010-2011\r\nAll Rights Reserved";
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.FromArgb(93, 135, 38);
		this.label3.Location = new System.Drawing.Point(4, 44);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(221, 45);
		this.label3.TabIndex = 10;
		this.label3.Text = "Cyprus VIES";
		this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnOk.Location = new System.Drawing.Point(446, 377);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 7;
		this.btnOk.Text = "Close";
		this.btnOk.UseVisualStyleBackColor = true;
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.label9);
		this.groupBox1.Controls.Add(this.pictureBox1);
		this.groupBox1.Controls.Add(this.label7);
		this.groupBox1.Controls.Add(this.label6);
		this.groupBox1.Controls.Add(this.lblVersion);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(62, 92, 25);
		this.groupBox1.Location = new System.Drawing.Point(218, 125);
		this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(303, 239);
		this.groupBox1.TabIndex = 11;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "System Information : ";
		this.label8.AutoSize = true;
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(120, 144);
		this.label8.Margin = new System.Windows.Forms.Padding(3);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(49, 13);
		this.label8.TabIndex = 10;
		this.label8.Text = "2010-1.0";
		this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label9.AutoSize = true;
		this.label9.ForeColor = System.Drawing.Color.Black;
		this.label9.Location = new System.Drawing.Point(11, 144);
		this.label9.Margin = new System.Windows.Forms.Padding(3);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(92, 13);
		this.label9.TabIndex = 9;
		this.label9.Text = "XML File Version :";
		this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.pictureBox1.Image = xSAD_VIES.Properties.Resources.accountstechDevLogo;
		this.pictureBox1.Location = new System.Drawing.Point(14, 171);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(274, 54);
		this.pictureBox1.TabIndex = 8;
		this.pictureBox1.TabStop = false;
		this.label7.AutoSize = true;
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(121, 125);
		this.label7.Margin = new System.Windows.Forms.Padding(3);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(133, 13);
		this.label7.TabIndex = 5;
		this.label7.Text = "ΕΝΤΥΠΟ Φ.Π.A 4 (E09-01)";
		this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label6.AutoSize = true;
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(121, 50);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(115, 78);
		this.label6.TabIndex = 4;
		this.label6.Text = "Sage Instant Accounts\r\nSage 50 Range\r\n\r\nVersion 2009 (15)\r\nVersion 2010 (16)\r\n\r\n";
		this.lblVersion.AutoSize = true;
		this.lblVersion.ForeColor = System.Drawing.Color.Black;
		this.lblVersion.Location = new System.Drawing.Point(121, 26);
		this.lblVersion.Name = "lblVersion";
		this.lblVersion.Size = new System.Drawing.Size(109, 13);
		this.lblVersion.TabIndex = 3;
		this.lblVersion.Text = "<Application Version>";
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(12, 125);
		this.label4.Margin = new System.Windows.Forms.Padding(3);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(98, 13);
		this.label4.TabIndex = 2;
		this.label4.Text = "VAT Specification :";
		this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(12, 50);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(82, 13);
		this.label2.TabIndex = 1;
		this.label2.Text = "Integrates with :";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(12, 26);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(48, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Version :";
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnOk;
		base.ClientSize = new System.Drawing.Size(533, 412);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.btnOk);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmAbout";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "About";
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
