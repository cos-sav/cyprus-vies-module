using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using xSAD_VIES.BL;
using xSAD_VIES.DAL;

namespace xSAD_VAT.GUI;

/// <summary>
/// Settings &gt; Path Configuration. Same layout as the Cyprus VAT Return module:
/// a Sage Version drop-down, the Sage installation (data) directory, and the user's XML folder.
/// Nothing is saved until Save is pressed.
/// </summary>
public class FrmPathConfiguration : Form
{
	/// <summary>One entry in the Sage Version drop-down.</summary>
	private sealed class SageVersionItem
	{
		public string Key { get; }

		public string Caption { get; }

		public SageVersionItem(string key)
		{
			Key = key;
			Caption = key.StartsWith("V", StringComparison.OrdinalIgnoreCase) ? "Sage 50 " + key.ToUpperInvariant() : "Sage 50 v" + key;
		}

		public override string ToString()
		{
			return Caption;
		}
	}

	/// <summary>Sage data folder names the module supports, oldest first (see SageController.TryParseSageFolder).</summary>
	private static readonly string[] SupportedSageVersions = new string[19]
	{
		"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018",
		"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "V33"
	};

	private IContainer components;

	private GroupBox groupBox1;

	private ComboBox cmbSageVersion;

	private GroupBox groupBox2;

	private TextBox txbSageInstallationDirectory;

	private GroupBox groupBox3;

	private TextBox txbCurrentUserXmlDirectory;

	private Button btnSelectFolder;

	private Button btnSave;

	private Button btnCancel;

	public FrmPathConfiguration()
	{
		InitializeComponent();
		txbCurrentUserXmlDirectory.Text = Service.UserXmlFolder;
	}

	private void FrmConfigurationLoad(object sender, EventArgs e)
	{
		string activeSagePath = Service.GetActiveSagePath() ?? "";
		string activeKey = "";
		if (activeSagePath != "")
		{
			string folderName = Path.GetFileName(activeSagePath.TrimEnd('\\', '/'));
			foreach (string version in SupportedSageVersions)
			{
				if (string.Equals(version, folderName, StringComparison.OrdinalIgnoreCase))
				{
					activeKey = version;
					break;
				}
			}
		}
		// List the versions installed on this PC (they have a Sage data folder), as the old radio list
		// only enabled those. If none are found, list them all so a version can still be chosen.
		List<SageVersionItem> items = new List<SageVersionItem>();
		foreach (string version in SupportedSageVersions)
		{
			if (version == activeKey || Directory.Exists(SageController.GetSagePath(version)))
			{
				items.Add(new SageVersionItem(version));
			}
		}
		if (items.Count == 0)
		{
			foreach (string version in SupportedSageVersions)
			{
				items.Add(new SageVersionItem(version));
			}
		}
		cmbSageVersion.BeginUpdate();
		cmbSageVersion.Items.Clear();
		foreach (SageVersionItem item in items)
		{
			cmbSageVersion.Items.Add(item);
		}
		cmbSageVersion.EndUpdate();
		SageVersionItem selected = items.Find((SageVersionItem i) => i.Key == activeKey);
		if (selected != null)
		{
			cmbSageVersion.SelectedItem = selected;
		}
		else
		{
			cmbSageVersion.SelectedIndex = -1;
		}
		txbSageInstallationDirectory.Text = activeSagePath;
	}

	private void CmbSageVersionSelectedIndexChanged(object sender, EventArgs e)
	{
		if (cmbSageVersion.SelectedItem is SageVersionItem item)
		{
			txbSageInstallationDirectory.Text = SageController.GetSagePath(item.Key);
		}
	}

	private void BtnSaveClick(object sender, EventArgs e)
	{
		if (cmbSageVersion.SelectedItem is SageVersionItem item)
		{
			if (!Directory.Exists(SageController.GetSagePath(item.Key)) && MessageBox.Show(this, "The Sage data folder for " + item.Caption + " was not found:\r\n" + SageController.GetSagePath(item.Key) + "\r\n\r\nSave it anyway?", "Path Configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				base.DialogResult = DialogResult.None;
				return;
			}
			Controller2.SetSageVersion(item.Key);
		}
		Controller2.SetUserXmlFolder(txbCurrentUserXmlDirectory.Text);
		Close();
	}

	private void BtnCancelClick(object sender, EventArgs e)
	{
		Close();
	}

	private void BtnSelectFolderClick(object sender, EventArgs e)
	{
		using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		if (Directory.Exists(txbCurrentUserXmlDirectory.Text))
		{
			folderBrowserDialog.SelectedPath = txbCurrentUserXmlDirectory.Text;
		}
		if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
		{
			txbCurrentUserXmlDirectory.Text = folderBrowserDialog.SelectedPath;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VAT.GUI.FrmPathConfiguration));
		System.Drawing.Color groupColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.cmbSageVersion = new System.Windows.Forms.ComboBox();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.txbSageInstallationDirectory = new System.Windows.Forms.TextBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.txbCurrentUserXmlDirectory = new System.Windows.Forms.TextBox();
		this.btnSelectFolder = new System.Windows.Forms.Button();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnCancel = new System.Windows.Forms.Button();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		this.groupBox3.SuspendLayout();
		base.SuspendLayout();
		// groupBox1 – Sage Version
		this.groupBox1.Controls.Add(this.cmbSageVersion);
		this.groupBox1.ForeColor = groupColor;
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(511, 64);
		this.groupBox1.TabIndex = 0;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Sage Version";
		this.cmbSageVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cmbSageVersion.ForeColor = System.Drawing.Color.Black;
		this.cmbSageVersion.FormattingEnabled = true;
		this.cmbSageVersion.Location = new System.Drawing.Point(23, 24);
		this.cmbSageVersion.MaxDropDownItems = 20;
		this.cmbSageVersion.Name = "cmbSageVersion";
		this.cmbSageVersion.Size = new System.Drawing.Size(467, 21);
		this.cmbSageVersion.TabIndex = 0;
		this.cmbSageVersion.SelectedIndexChanged += new System.EventHandler(CmbSageVersionSelectedIndexChanged);
		// groupBox2 – Sage Installation Directory
		this.groupBox2.Controls.Add(this.txbSageInstallationDirectory);
		this.groupBox2.ForeColor = groupColor;
		this.groupBox2.Location = new System.Drawing.Point(12, 84);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(511, 64);
		this.groupBox2.TabIndex = 1;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Sage Installation Directory";
		this.txbSageInstallationDirectory.BackColor = System.Drawing.Color.White;
		this.txbSageInstallationDirectory.ForeColor = System.Drawing.Color.Black;
		this.txbSageInstallationDirectory.Location = new System.Drawing.Point(23, 26);
		this.txbSageInstallationDirectory.Name = "txbSageInstallationDirectory";
		this.txbSageInstallationDirectory.ReadOnly = true;
		this.txbSageInstallationDirectory.Size = new System.Drawing.Size(467, 20);
		this.txbSageInstallationDirectory.TabIndex = 0;
		// groupBox3 – Current user xml folder
		this.groupBox3.Controls.Add(this.txbCurrentUserXmlDirectory);
		this.groupBox3.Controls.Add(this.btnSelectFolder);
		this.groupBox3.ForeColor = groupColor;
		this.groupBox3.Location = new System.Drawing.Point(12, 156);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(511, 64);
		this.groupBox3.TabIndex = 2;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Current user xml folder";
		this.txbCurrentUserXmlDirectory.BackColor = System.Drawing.Color.White;
		this.txbCurrentUserXmlDirectory.ForeColor = System.Drawing.Color.Black;
		this.txbCurrentUserXmlDirectory.Location = new System.Drawing.Point(23, 26);
		this.txbCurrentUserXmlDirectory.Name = "txbCurrentUserXmlDirectory";
		this.txbCurrentUserXmlDirectory.Size = new System.Drawing.Size(431, 20);
		this.txbCurrentUserXmlDirectory.TabIndex = 0;
		this.btnSelectFolder.ForeColor = System.Drawing.Color.Black;
		this.btnSelectFolder.Location = new System.Drawing.Point(459, 24);
		this.btnSelectFolder.Name = "btnSelectFolder";
		this.btnSelectFolder.Size = new System.Drawing.Size(31, 23);
		this.btnSelectFolder.TabIndex = 1;
		this.btnSelectFolder.Text = "...";
		this.btnSelectFolder.UseVisualStyleBackColor = true;
		this.btnSelectFolder.Click += new System.EventHandler(BtnSelectFolderClick);
		// Save / Cancel
		this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnSave.Location = new System.Drawing.Point(367, 230);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(75, 23);
		this.btnSave.TabIndex = 3;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(BtnSaveClick);
		this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new System.Drawing.Point(448, 230);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 4;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Click += new System.EventHandler(BtnCancelClick);
		// Form
		base.AcceptButton = this.btnSave;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new System.Drawing.Size(535, 265);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox3);
		base.Controls.Add(this.btnSave);
		base.Controls.Add(this.btnCancel);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmPathConfiguration";
		base.ShowInTaskbar = false;
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Path Configuration";
		base.Load += new System.EventHandler(FrmConfigurationLoad);
		this.groupBox1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		base.ResumeLayout(false);
	}
}
