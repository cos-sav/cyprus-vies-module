using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace xSADReports;

[DesignerGenerated]
public class frmPleaseNote : Form
{
	private IContainer components;

	[CompilerGenerated]
	[AccessedThroughProperty("button1")]
	private Button _button1;

	private Button button1
	{
		[CompilerGenerated]
		get
		{
			return _button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler value2 = button1_Click;
			Button button = _button1;
			if (button != null)
			{
				button.Click -= value2;
			}
			_button1 = value;
			button = _button1;
			if (button != null)
			{
				button.Click += value2;
			}
		}
	}

	[field: AccessedThroughProperty("cbDisplayNotifiaction")]
	private CheckBox cbDisplayNotifiaction
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("label1")]
	private Label label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public object DisableNotification => cbDisplayNotifiaction.Checked;

	public frmPleaseNote()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSADReports.frmPleaseNote));
		this.button1 = new System.Windows.Forms.Button();
		this.cbDisplayNotifiaction = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.button1.Location = new System.Drawing.Point(165, 114);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 5;
		this.button1.Text = "OK";
		this.button1.UseVisualStyleBackColor = true;
		this.cbDisplayNotifiaction.AutoSize = true;
		this.cbDisplayNotifiaction.Location = new System.Drawing.Point(15, 84);
		this.cbDisplayNotifiaction.Name = "cbDisplayNotifiaction";
		this.cbDisplayNotifiaction.Size = new System.Drawing.Size(128, 17);
		this.cbDisplayNotifiaction.TabIndex = 4;
		this.cbDisplayNotifiaction.Text = "Don’t show this again";
		this.cbDisplayNotifiaction.UseVisualStyleBackColor = true;
		this.label1.Location = new System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(382, 71);
		this.label1.TabIndex = 3;
		this.label1.Text = resources.GetString("label1.Text");
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(406, 149);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.cbDisplayNotifiaction);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmPleaseNote";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Please Note";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}
}
