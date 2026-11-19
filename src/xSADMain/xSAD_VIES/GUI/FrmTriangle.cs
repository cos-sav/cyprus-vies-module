using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using xSAD_VIES.Entities;

namespace xSAD_VIES.GUI;

public class FrmTriangle : Form
{
	private readonly List<TransactionEntity> _transactionsList;

	private readonly Dictionary<int, bool> _initialTriangularStatuses;

	private bool _savePressed;

	private IContainer components;

	private DataGridView dataGridView1;

	private Panel panel1;

	private Label label1;

	private Label lblCountryCode;

	private Label lblVatRegistrationNumber;

	private Label label2;

	private Label lblAccountReference;

	private Label lblCustomerName;

	private Label label8;

	private Label label4;

	private Panel panel2;

	private Label lblDirectTotal;

	private Label label5;

	private Button btnClose;

	private Button btnSave;

	private Label lblTriangularTotal;

	private Label label10;

	private Button btnSelectAll;

	private BindingSource transactionEntityBindingSource;

	private Button btnSelectNone;

	private GroupBox groupBox1;

	private Panel panel3;

	private GroupBox gbGrid;

	private GroupBox gbTotals;

	private GroupBox gbButtons;

	private DataGridViewTextBoxColumn colTransactionType;

	private DataGridViewTextBoxColumn colTransactionNo;

	private DataGridViewTextBoxColumn colTransactionNC;

	private DataGridViewTextBoxColumn colAccount;

	private DataGridViewTextBoxColumn colTransactionDate;

	private DataGridViewTextBoxColumn colAccountReference;

	private DataGridViewTextBoxColumn colGoodService;

	private DataGridViewTextBoxColumn colDetails;

	private DataGridViewTextBoxColumn colAmount;

	private DataGridViewCheckBoxColumn colTriangular;

	public FrmTriangle()
	{
		InitializeComponent();
	}

	public FrmTriangle(List<TransactionEntity> transactionsList)
	{
		InitializeComponent();
		_transactionsList = transactionsList;
		btnSelectAll.Parent = this;
		btnSelectAll.BringToFront();
		btnSelectNone.Parent = this;
		btnSelectNone.BringToFront();
		btnSelectAll.Top += 45;
		btnSelectNone.Top += 45;
		btnSelectAll.Left += 27;
		btnSelectNone.Left += 27;
		dataGridView1.AutoGenerateColumns = false;
		dataGridView1.DataSource = transactionsList;
		lblCountryCode.Text = transactionsList[0].CountryCode;
		lblAccountReference.Text = transactionsList[0].AccountReference;
		lblCustomerName.Text = transactionsList[0].AccountName;
		lblVatRegistrationNumber.Text = transactionsList[0].VatRegistrationNumber;
		CalculateTotals();
		_initialTriangularStatuses = new Dictionary<int, bool>();
		foreach (TransactionEntity transactions in _transactionsList)
		{
			_initialTriangularStatuses.Add(transactions.TransactionNumber, transactions.IsTriangular);
		}
	}

	private void BtnCloseClick(object sender, EventArgs e)
	{
		Close();
	}

	private void BtnSaveClick(object sender, EventArgs e)
	{
		_savePressed = true;
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1.Rows)
		{
			((TransactionEntity)item.DataBoundItem).IsTriangular = item.Cells[colTriangular.Index].Value != null && (bool)item.Cells[colTriangular.Index].Value;
		}
		Close();
	}

	private void BtnSelectAllClick(object sender, EventArgs e)
	{
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1.Rows)
		{
			item.Cells[colTriangular.Index].Value = sender == btnSelectAll;
		}
	}

	private void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotals();
	}

	private void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		CalculateTotals();
	}

	private void CalculateTotals()
	{
		if (_transactionsList == null)
		{
			return;
		}
		decimal num = default(decimal);
		decimal num2 = default(decimal);
		foreach (DataGridViewRow item in (IEnumerable)dataGridView1.Rows)
		{
			((TransactionEntity)item.DataBoundItem).IsTriangular = item.Cells[colTriangular.Index].Value != null && (bool)item.Cells[colTriangular.Index].Value;
		}
		foreach (TransactionEntity transactions in _transactionsList)
		{
			if (!transactions.IsTriangular)
			{
				num += transactions.NetAmount;
			}
			else
			{
				num2 += transactions.NetAmount;
			}
		}
		lblTriangularTotal.Text = num2.ToString("0.00");
		lblDirectTotal.Text = num.ToString("0.00");
	}

	private void DataGridView1CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex != -1)
		{
			dataGridView1.CurrentCell = dataGridView1[0, e.RowIndex];
			CalculateTotals();
		}
	}

	private bool IsChangesMade()
	{
		foreach (TransactionEntity transactions in _transactionsList)
		{
			if (_initialTriangularStatuses[transactions.TransactionNumber] != transactions.IsTriangular)
			{
				return true;
			}
		}
		return false;
	}

	private void FrmTriangleFormClosing(object sender, FormClosingEventArgs e)
	{
		if (IsChangesMade() && !_savePressed)
		{
			switch (MessageBox.Show("Changes made. Exit anyway?", "", MessageBoxButtons.YesNoCancel))
			{
			case DialogResult.Cancel:
				e.Cancel = true;
				break;
			case DialogResult.Yes:
				e.Cancel = false;
				break;
			default:
				e.Cancel = true;
				break;
			}
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
		this.components = new System.ComponentModel.Container();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmTriangle));
		this.dataGridView1 = new System.Windows.Forms.DataGridView();
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.btnSelectNone = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.btnSelectAll = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.lblVatRegistrationNumber = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.lblAccountReference = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.lblCustomerName = new System.Windows.Forms.Label();
		this.lblCountryCode = new System.Windows.Forms.Label();
		this.panel2 = new System.Windows.Forms.Panel();
		this.gbButtons = new System.Windows.Forms.GroupBox();
		this.btnSave = new System.Windows.Forms.Button();
		this.btnClose = new System.Windows.Forms.Button();
		this.gbTotals = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.lblDirectTotal = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.lblTriangularTotal = new System.Windows.Forms.Label();
		this.panel3 = new System.Windows.Forms.Panel();
		this.gbGrid = new System.Windows.Forms.GroupBox();
		this.transactionEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
		this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colTransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colTransactionNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colAccountReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colGoodService = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colTriangular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.panel2.SuspendLayout();
		this.gbButtons.SuspendLayout();
		this.gbTotals.SuspendLayout();
		this.panel3.SuspendLayout();
		this.gbGrid.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.transactionEntityBindingSource).BeginInit();
		base.SuspendLayout();
		this.dataGridView1.AllowUserToAddRows = false;
		this.dataGridView1.AllowUserToDeleteRows = false;
		this.dataGridView1.AllowUserToResizeColumns = false;
		this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 211);
		this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(215, 215, 190);
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView1.Columns.AddRange(this.colTransactionType, this.colTransactionNo, this.colTransactionNC, this.colAccount, this.colTransactionDate, this.colAccountReference, this.colGoodService, this.colDetails, this.colAmount, this.colTriangular);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
		this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
		this.dataGridView1.Location = new System.Drawing.Point(3, 16);
		this.dataGridView1.Name = "dataGridView1";
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.dataGridView1.RowHeadersVisible = false;
		this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 211);
		this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
		this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 211);
		this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
		this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.dataGridView1.Size = new System.Drawing.Size(769, 168);
		this.dataGridView1.TabIndex = 0;
		this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridView1CellValueChanged);
		this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(DataGridView1CellMouseUp);
		this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridView1CellEndEdit);
		this.panel1.BackColor = System.Drawing.Color.White;
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Padding = new System.Windows.Forms.Padding(12);
		this.panel1.Size = new System.Drawing.Size(799, 67);
		this.panel1.TabIndex = 1;
		this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
		this.groupBox1.Controls.Add(this.btnSelectNone);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.btnSelectAll);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.lblVatRegistrationNumber);
		this.groupBox1.Controls.Add(this.label4);
		this.groupBox1.Controls.Add(this.lblAccountReference);
		this.groupBox1.Controls.Add(this.label8);
		this.groupBox1.Controls.Add(this.lblCustomerName);
		this.groupBox1.Controls.Add(this.lblCountryCode);
		this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox1.Location = new System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(775, 43);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.btnSelectNone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnSelectNone.Location = new System.Drawing.Point(683, 13);
		this.btnSelectNone.Name = "btnSelectNone";
		this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
		this.btnSelectNone.TabIndex = 3;
		this.btnSelectNone.Text = "Deselect all";
		this.btnSelectNone.UseVisualStyleBackColor = true;
		this.btnSelectNone.Click += new System.EventHandler(BtnSelectAllClick);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(308, 16);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(74, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Country Code:";
		this.btnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnSelectAll.Location = new System.Drawing.Point(602, 13);
		this.btnSelectAll.Name = "btnSelectAll";
		this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
		this.btnSelectAll.TabIndex = 3;
		this.btnSelectAll.Text = "Select all";
		this.btnSelectAll.UseVisualStyleBackColor = true;
		this.btnSelectAll.Click += new System.EventHandler(BtnSelectAllClick);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(6, 16);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(107, 13);
		this.label2.TabIndex = 0;
		this.label2.Text = "VAT Registration No.";
		this.lblVatRegistrationNumber.BackColor = System.Drawing.Color.NavajoWhite;
		this.lblVatRegistrationNumber.Location = new System.Drawing.Point(119, 12);
		this.lblVatRegistrationNumber.Name = "lblVatRegistrationNumber";
		this.lblVatRegistrationNumber.Size = new System.Drawing.Size(149, 20);
		this.lblVatRegistrationNumber.TabIndex = 1;
		this.lblVatRegistrationNumber.Text = "111-111111-111111";
		this.lblVatRegistrationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(6, 47);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(85, 13);
		this.label4.TabIndex = 0;
		this.label4.Text = "Customer Name:";
		this.label4.Visible = false;
		this.lblAccountReference.BackColor = System.Drawing.Color.White;
		this.lblAccountReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.lblAccountReference.Location = new System.Drawing.Point(95, 74);
		this.lblAccountReference.Name = "lblAccountReference";
		this.lblAccountReference.Size = new System.Drawing.Size(287, 20);
		this.lblAccountReference.TabIndex = 1;
		this.lblAccountReference.Text = "EU";
		this.lblAccountReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblAccountReference.Visible = false;
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(6, 78);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(29, 13);
		this.label8.TabIndex = 0;
		this.label8.Text = "A\\C:";
		this.label8.Visible = false;
		this.lblCustomerName.BackColor = System.Drawing.Color.White;
		this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.lblCustomerName.Location = new System.Drawing.Point(95, 43);
		this.lblCustomerName.Name = "lblCustomerName";
		this.lblCustomerName.Size = new System.Drawing.Size(287, 20);
		this.lblCustomerName.TabIndex = 1;
		this.lblCustomerName.Text = "EU";
		this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.lblCustomerName.Visible = false;
		this.lblCountryCode.BackColor = System.Drawing.Color.NavajoWhite;
		this.lblCountryCode.Location = new System.Drawing.Point(397, 12);
		this.lblCountryCode.Name = "lblCountryCode";
		this.lblCountryCode.Size = new System.Drawing.Size(32, 20);
		this.lblCountryCode.TabIndex = 1;
		this.lblCountryCode.Text = "EU";
		this.lblCountryCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.panel2.BackColor = System.Drawing.Color.White;
		this.panel2.Controls.Add(this.gbButtons);
		this.panel2.Controls.Add(this.gbTotals);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.panel2.Location = new System.Drawing.Point(0, 278);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(799, 136);
		this.panel2.TabIndex = 3;
		this.gbButtons.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbButtons.BackColor = System.Drawing.Color.WhiteSmoke;
		this.gbButtons.Controls.Add(this.btnSave);
		this.gbButtons.Controls.Add(this.btnClose);
		this.gbButtons.Location = new System.Drawing.Point(12, 82);
		this.gbButtons.Name = "gbButtons";
		this.gbButtons.Size = new System.Drawing.Size(775, 45);
		this.gbButtons.TabIndex = 4;
		this.gbButtons.TabStop = false;
		this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.btnSave.Location = new System.Drawing.Point(531, 15);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(120, 23);
		this.btnSave.TabIndex = 2;
		this.btnSave.Text = "Save and Close";
		this.btnSave.UseVisualStyleBackColor = true;
		this.btnSave.Click += new System.EventHandler(BtnSaveClick);
		this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		this.btnClose.Location = new System.Drawing.Point(657, 15);
		this.btnClose.Name = "btnClose";
		this.btnClose.Size = new System.Drawing.Size(108, 23);
		this.btnClose.TabIndex = 2;
		this.btnClose.Text = "Cancel Changes";
		this.btnClose.UseVisualStyleBackColor = true;
		this.btnClose.Click += new System.EventHandler(BtnCloseClick);
		this.gbTotals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.gbTotals.BackColor = System.Drawing.Color.WhiteSmoke;
		this.gbTotals.Controls.Add(this.label5);
		this.gbTotals.Controls.Add(this.lblDirectTotal);
		this.gbTotals.Controls.Add(this.label10);
		this.gbTotals.Controls.Add(this.lblTriangularTotal);
		this.gbTotals.Location = new System.Drawing.Point(464, 7);
		this.gbTotals.Name = "gbTotals";
		this.gbTotals.Size = new System.Drawing.Size(323, 69);
		this.gbTotals.TabIndex = 3;
		this.gbTotals.TabStop = false;
		this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(14, 16);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(114, 13);
		this.label5.TabIndex = 0;
		this.label5.Text = "Direct Deliveries Total:";
		this.lblDirectTotal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.lblDirectTotal.BackColor = System.Drawing.Color.NavajoWhite;
		this.lblDirectTotal.Location = new System.Drawing.Point(164, 12);
		this.lblDirectTotal.Name = "lblDirectTotal";
		this.lblDirectTotal.Size = new System.Drawing.Size(149, 20);
		this.lblDirectTotal.TabIndex = 1;
		this.lblDirectTotal.Text = "111-111111-111111";
		this.lblDirectTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(14, 42);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(148, 13);
		this.label10.TabIndex = 0;
		this.label10.Text = "Triangular Transactions Total:";
		this.lblTriangularTotal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.lblTriangularTotal.BackColor = System.Drawing.Color.NavajoWhite;
		this.lblTriangularTotal.Location = new System.Drawing.Point(164, 38);
		this.lblTriangularTotal.Name = "lblTriangularTotal";
		this.lblTriangularTotal.Size = new System.Drawing.Size(149, 20);
		this.lblTriangularTotal.TabIndex = 1;
		this.lblTriangularTotal.Text = "111-111111-111111";
		this.lblTriangularTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
		this.panel3.Controls.Add(this.gbGrid);
		this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel3.Location = new System.Drawing.Point(0, 67);
		this.panel3.Name = "panel3";
		this.panel3.Padding = new System.Windows.Forms.Padding(12);
		this.panel3.Size = new System.Drawing.Size(799, 211);
		this.panel3.TabIndex = 4;
		this.gbGrid.Controls.Add(this.dataGridView1);
		this.gbGrid.Dock = System.Windows.Forms.DockStyle.Fill;
		this.gbGrid.Location = new System.Drawing.Point(12, 12);
		this.gbGrid.Name = "gbGrid";
		this.gbGrid.Size = new System.Drawing.Size(775, 187);
		this.gbGrid.TabIndex = 1;
		this.gbGrid.TabStop = false;
		this.transactionEntityBindingSource.DataSource = typeof(xSAD_VIES.Entities.TransactionEntity);
		this.colTransactionType.DataPropertyName = "TransactionType";
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
		this.colTransactionType.DefaultCellStyle = dataGridViewCellStyle4;
		this.colTransactionType.FillWeight = 10f;
		this.colTransactionType.HeaderText = "Type";
		this.colTransactionType.Name = "colTransactionType";
		this.colTransactionType.ReadOnly = true;
		this.colTransactionType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colTransactionNo.DataPropertyName = "TransactionNumber";
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
		this.colTransactionNo.DefaultCellStyle = dataGridViewCellStyle5;
		this.colTransactionNo.FillWeight = 10f;
		this.colTransactionNo.HeaderText = "No.";
		this.colTransactionNo.Name = "colTransactionNo";
		this.colTransactionNo.ReadOnly = true;
		this.colTransactionNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
		this.colTransactionNC.DefaultCellStyle = dataGridViewCellStyle6;
		this.colTransactionNC.FillWeight = 10f;
		this.colTransactionNC.HeaderText = "N/C";
		this.colTransactionNC.Name = "colTransactionNC";
		this.colTransactionNC.ReadOnly = true;
		this.colTransactionNC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colAccount.DataPropertyName = "AccountNameAndReference";
		this.colAccount.FillWeight = 45f;
		this.colAccount.HeaderText = "Account";
		this.colAccount.Name = "colAccount";
		this.colTransactionDate.DataPropertyName = "TranscationDate";
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
		this.colTransactionDate.DefaultCellStyle = dataGridViewCellStyle7;
		this.colTransactionDate.FillWeight = 20f;
		this.colTransactionDate.HeaderText = "Date";
		this.colTransactionDate.Name = "colTransactionDate";
		this.colTransactionDate.ReadOnly = true;
		this.colTransactionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colAccountReference.DataPropertyName = "InvoiceNumber";
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
		this.colAccountReference.DefaultCellStyle = dataGridViewCellStyle8;
		this.colAccountReference.FillWeight = 20f;
		this.colAccountReference.HeaderText = "Ref";
		this.colAccountReference.Name = "colAccountReference";
		this.colAccountReference.ReadOnly = true;
		this.colAccountReference.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colGoodService.DataPropertyName = "GoodServiceText";
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
		this.colGoodService.DefaultCellStyle = dataGridViewCellStyle9;
		this.colGoodService.FillWeight = 23f;
		this.colGoodService.HeaderText = "Goods\\Service";
		this.colGoodService.Name = "colGoodService";
		this.colGoodService.ReadOnly = true;
		this.colGoodService.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colGoodService.Visible = false;
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
		this.colDetails.DefaultCellStyle = dataGridViewCellStyle10;
		this.colDetails.FillWeight = 40f;
		this.colDetails.HeaderText = "Details";
		this.colDetails.Name = "colDetails";
		this.colDetails.ReadOnly = true;
		this.colDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colAmount.DataPropertyName = "NetAmount";
		dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle11.Format = "0.00";
		dataGridViewCellStyle11.NullValue = null;
		dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
		this.colAmount.DefaultCellStyle = dataGridViewCellStyle11;
		this.colAmount.FillWeight = 25f;
		this.colAmount.HeaderText = "Amount";
		this.colAmount.Name = "colAmount";
		this.colAmount.ReadOnly = true;
		this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.colTriangular.DataPropertyName = "IsTriangular";
		dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle12.NullValue = false;
		dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
		dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
		this.colTriangular.DefaultCellStyle = dataGridViewCellStyle12;
		this.colTriangular.FillWeight = 16f;
		this.colTriangular.HeaderText = "Triangular";
		this.colTriangular.Name = "colTriangular";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(799, 414);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmTriangle";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Triangular Transactions Window";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FrmTriangleFormClosing);
		((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
		this.panel1.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.gbButtons.ResumeLayout(false);
		this.gbTotals.ResumeLayout(false);
		this.gbTotals.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.gbGrid.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.transactionEntityBindingSource).EndInit();
		base.ResumeLayout(false);
	}
}
