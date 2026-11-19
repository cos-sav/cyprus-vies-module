using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using xSADReports;
using xSAD_VIES.BL;
using xSAD_VIES.Common;
using xSAD_VIES.DAL;
using xSAD_VIES.Entities;
using xSAD_VIES.Properties;
using xSageDataObjects;

namespace xSAD_VIES.GUI;

public class FrmDeclarationProcess : Form
{
	private ViesEntity _viesEntity;

	private readonly SageCompany _sageCompanyEntity;

	private bool _cancelPressed;

	private List<ViesRowEntity> _calculaterViesRows;

	private readonly bool _singleCompany = true;

	private bool _loadingEntity;

	public readonly bool FormCanceled;

	private readonly Color _normalForeColor = Color.FromArgb(255, 0, 0, 0);

	private readonly Color _editedColor = Color.LightSkyBlue;

	private const string ProgramTitle = "Cyprus VIES";

	private IContainer components;

	private Label lblVatRegistration;

	private Label lblCompanyAddress2;

	private Label lblCompanyAddress1;

	private Label lblCompanyName;

	private Label label8;

	private DateTimePicker dtPeriodFrom;

	private Label label5;

	private DateTimePicker dtPeriodTo;

	private Button btnCalculate;

	private Panel pnlTop;

	private Panel pnlMiddle;

	private Panel pnlBottomButtons;

	private Button btnAnalysisReport;

	private Button btnVATForm;

	private DataGridView dgvViesEditor;

	private Button btnGenerateXML;

	private Button btnCancel;

	private Button btnOpenFolder;

	private GroupBox gbxPeriod;

	private GroupBox gbxCompanyInfo;

	private GroupBox gbxActions;

	private ProgressBar prbProgress;

	private Label label2;

	private Label label1;

	private ComboBox cbDeclarationYear;

	private ComboBox cbDeclarationMonth;

	private Panel pnlTotals;

	private Label lblEntriesCount;

	private Label lblTotalServices;

	private Label lblTotalTriangular;

	private Label lblTotalGoods;

	private Label txbTotalServices;

	private Label txbTotalTriangular;

	private Label txbTotalGoods;

	private Label txbEntriesCount;

	private Button btnTriangle;

	private System.Windows.Forms.Timer timerHideTriangle;

	private GroupBox groupBox1;

	private DataGridViewTextBoxColumn colNumber;

	private DataGridViewComboBoxColumn colCountryName;

	private DataGridViewTextBoxColumn colCountryCode;

	private DataGridViewTextBoxColumn colVATRegistration;

	private DataGridViewTextBoxColumn colName;

	private DataGridViewTextBoxColumn colGoods;

	private DataGridViewImageColumn colTriangleButton;

	private DataGridViewTextBoxColumn colTriangle;

	private DataGridViewTextBoxColumn colServices;

	private DataGridViewImageColumn colRemoveRow;

	private CheckBox chkReplaceGR;

	private CheckBox chkLoadCountriesListFromSage;

	public FrmDeclarationProcess(SageCompany sageCompany)
	{
		InitializeComponent();
		_singleCompany = true;
		_sageCompanyEntity = sageCompany;
		foreach (KeyValuePair<string, string> country in Service.GetCountries(chkLoadCountriesListFromSage.Checked, _sageCompanyEntity.SageConnectionString))
		{
			colCountryName.Items.Add(country.Key);
		}
		PrepareForm();
		LoadEntity(sageCompany);
	}

	public FrmDeclarationProcess(int groupId, string groupName, string groupVatReg)
	{
		InitializeComponent();
		SageCompany sageCompany = new SageCompany();
		string getUserXmlFolder = Service.GetUserXmlFolder;
		getUserXmlFolder = Path.Combine(getUserXmlFolder, "Group_" + groupName);
		sageCompany.CompanyXmlPath = getUserXmlFolder;
		sageCompany.CompanyCode = groupName;
		foreach (KeyValuePair<string, string> country in Service.GetCountries(chkLoadCountriesListFromSage.Checked, _sageCompanyEntity.SageConnectionString))
		{
			colCountryName.Items.Add(country.Key);
		}
		ViesEntity viesEntity = xSAD_VIES.DAL.SageController.MergeVatEntityForGroupId(groupId);
		if (viesEntity == null)
		{
			FormCanceled = true;
			return;
		}
		_singleCompany = false;
		_viesEntity = viesEntity;
		_sageCompanyEntity = sageCompany;
		_sageCompanyEntity.Name = groupName;
		_sageCompanyEntity.SageVatRegistrationNumber = groupVatReg;
		colTriangleButton.Visible = false;
		PrepareForm();
		_viesEntity.TaxPayer = groupVatReg;
		LoadEntityFromEntity(_viesEntity);
		lblCompanyName.Text = groupName;
		lblVatRegistration.Text = groupVatReg;
		gbxActions.Enabled = true;
		btnAnalysisReport.Visible = false;
		btnCalculate.Visible = false;
		dgvViesEditor.Enabled = true;
	}

	private void PrepareForm()
	{
		cbDeclarationMonth.Items.Clear();
		for (int i = 1; i <= 12; i++)
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, i, 1);
			cbDeclarationMonth.Items.Add(dateTime.ToString("MMMM"));
		}
		cbDeclarationYear.Items.Clear();
		for (int j = DateTime.Now.Year - 1; j < DateTime.Now.Year + 10; j++)
		{
			cbDeclarationYear.Items.Add(j);
		}
	}

	private void BtnViesFormClick(object sender, EventArgs e)
	{
		ReadEntityFromGrid();
		if (ValidateInputs())
		{
			Service.ShowViesSubmissionForm(_viesEntity, this);
		}
	}

	private void DataGridView1CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
	}

	private void LoadEntity(SageCompany sageCompany)
	{
		lblCompanyName.Text = sageCompany.Name;
		lblCompanyAddress1.Text = sageCompany.SageAddress1;
		lblCompanyAddress2.Text = sageCompany.SageAddress2;
		lblVatRegistration.Text = sageCompany.SageVatRegistrationNumber;
		_viesEntity = new ViesEntity();
		SetDefaultDates();
		SetEntityOnGrid();
	}

	private void SetDefaultDates()
	{
		DateTime dateTime = DateTime.Now.AddMonths(-1);
		DateTime dateTime2 = DateTime.Now.AddMonths(-1);
		_viesEntity.PeriodFrom = new DateTime(dateTime.Year, dateTime.Month, 1);
		_viesEntity.PeriodTo = new DateTime(dateTime2.Year, dateTime2.Month, DateTime.DaysInMonth(dateTime2.Year, dateTime2.Month));
		_viesEntity.DeclarationMonth = dateTime.Month;
		_viesEntity.DeclarationYear = dateTime.Year;
	}

	private void LoadEntityFromEntity(ViesEntity entity)
	{
		_viesEntity = entity;
		lblCompanyName.Text = "";
		lblCompanyAddress1.Text = "";
		lblCompanyAddress2.Text = "";
		lblVatRegistration.Text = _viesEntity.TaxPayer;
		SetDefaultDates();
		SetEntityOnGrid();
	}

	private void ReadEntityFromGrid()
	{
		_viesEntity = Service.ReadEntityFromGrid(_viesEntity, dgvViesEditor, dtPeriodFrom, dtPeriodTo, cbDeclarationMonth, cbDeclarationYear, lblVatRegistration);
	}

	private void SetEntityOnGrid()
	{
		_loadingEntity = true;
		Service.SetEntityOnGrid(_viesEntity, dgvViesEditor, dtPeriodFrom, dtPeriodTo, cbDeclarationMonth, cbDeclarationYear);
		dgvViesEditor.Rows.Clear();
		foreach (ViesRowEntity viesRow in _viesEntity.ViesRows)
		{
			int rowIndex = dgvViesEditor.Rows.Add();
			dgvViesEditor[colCountryCode.Index, rowIndex].Value = viesRow.CountryCode;
			dgvViesEditor[colVATRegistration.Index, rowIndex].Value = viesRow.VatRegistrationNumber;
			dgvViesEditor[colName.Index, rowIndex].Value = viesRow.CustomerName;
			dgvViesEditor[colGoods.Index, rowIndex].Value = viesRow.SuppliesAmount.ToString("0");
			dgvViesEditor[colTriangle.Index, rowIndex].Value = viesRow.TriangleTransactionsAmount.ToString("0");
			dgvViesEditor[colServices.Index, rowIndex].Value = viesRow.ServicesAmount.ToString("0");
		}
		CalculateTotals();
		_loadingEntity = false;
	}

	private void BtnGenerateXmlClick(object sender, EventArgs e)
	{
		ReadEntityFromGrid();
		if (ValidateInputs() && ValidateInputs2())
		{
			if (_viesEntity.TaxPayer.Trim() == "")
			{
				MessageBox.Show("This {0} does not have a VAT Registration Number.\r\n \r\nIt is not possible to generate an XML file for automatic submission to the Ministry of Finance TAXISNET service\r\nunless you provide the VAT Registration Number.".Replace("{0}", _singleCompany ? "company" : "group"), "Missing VAT Registration Number.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string xmlFileName = XmlFuncs.GenerateXmlFilename(_viesEntity.PeriodFrom, _viesEntity.PeriodTo, _sageCompanyEntity);
			XmlFuncs.SaveEntityToXml(_viesEntity, xmlFileName, chkReplaceGR.Checked);
			MessageBox.Show("The XML file has been generated. Press 'open folder' to locate it.");
		}
	}

	private void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		if (_loadingEntity)
		{
			return;
		}
		string text = (string)dgvViesEditor[e.ColumnIndex, e.RowIndex].Tag;
		string text2 = (dgvViesEditor[e.ColumnIndex, e.RowIndex].Value ?? "").ToString();
		if (e.ColumnIndex == colGoods.Index || e.ColumnIndex == colTriangle.Index || e.ColumnIndex == colServices.Index)
		{
			if (text2 != text)
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.BackColor = _editedColor;
			}
			else
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.FromArgb(255, 255, 255, 210);
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.FromArgb(255, 255, 255, 210);
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.SelectionForeColor = Color.FromArgb(255, 0, 83, 160);
			}
		}
		else if (text2 != text)
		{
			dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.BackColor = _editedColor;
		}
		else
		{
			dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
			dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.White;
			dgvViesEditor[e.ColumnIndex, e.RowIndex].Style.SelectionForeColor = _normalForeColor;
		}
		ReadEntityFromGrid();
		CalculateTotals();
	}

	private void DataGridView1CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex == -1)
		{
			return;
		}
		if (e.ColumnIndex == colGoods.Index || e.ColumnIndex == colTriangle.Index || e.ColumnIndex == colServices.Index)
		{
			try
			{
				decimal num = Convert.ToDecimal(dgvViesEditor[e.ColumnIndex, e.RowIndex].Value.ToString(), CultureInfo.InvariantCulture);
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = num.ToString("0", CultureInfo.InvariantCulture);
			}
			catch
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = "0";
			}
		}
		if (e.ColumnIndex == colCountryCode.Index)
		{
			string countryName = Service.GetCountryName(dgvViesEditor[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper());
			if ((dgvViesEditor[colCountryName.Index, e.RowIndex].Value ?? "").ToString() != countryName)
			{
				dgvViesEditor[colCountryName.Index, e.RowIndex].Value = countryName;
			}
		}
		if (e.ColumnIndex == colCountryName.Index)
		{
			string countryCode = Service.GetCountryCode(dgvViesEditor[e.ColumnIndex, e.RowIndex].Value.ToString().ToUpper());
			if ((dgvViesEditor[colCountryCode.Index, e.RowIndex].Value ?? "").ToString() != countryCode)
			{
				dgvViesEditor[colCountryCode.Index, e.RowIndex].Value = countryCode;
			}
		}
	}

	private void Calculate()
	{
		VIES.TransactionSplitsDataTable dataTable = Service.Calculate(dtPeriodFrom.Value.Date, dtPeriodTo.Value.Date, _sageCompanyEntity);
		List<TransactionEntity> list = Service.ConvertDataTable(dataTable);
		_calculaterViesRows = Service.GroupTransactions(list);
		_viesEntity.ViesTransactions = list;
		_viesEntity.DataTable = dataTable;
	}

	private void BtnCalculateClick(object sender, EventArgs e)
	{
		ReadEntityFromGrid();
		if (!ValidateInputs())
		{
			return;
		}
		_calculaterViesRows = null;
		DisableCalculationControls();
		try
		{
			Thread thread = new Thread(Calculate);
			thread.Start();
			while (thread.IsAlive)
			{
				Thread.Sleep(10);
				Application.DoEvents();
				if (_cancelPressed)
				{
					thread.Abort();
					return;
				}
			}
			btnCancel.Visible = false;
			prbProgress.Visible = false;
			EnableReconciliation();
		}
		finally
		{
			EnableCalculationControls();
		}
		if (_calculaterViesRows == null)
		{
			return;
		}
		List<string> list = Service.CompareEntities(_viesEntity.ViesRows, _calculaterViesRows);
		if (list.Count > 0)
		{
			string text = "";
			foreach (string item in list)
			{
				text = text + "\r\n             - " + item;
			}
			if (MessageBox.Show("Calculation process needs to overwrite values that you have specified             \r\nfor the following boxes :\r\n" + text + "\r\n\r\nWould you like proceed anyway?", "Overwrite Box Values?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return;
			}
		}
		Service.AssignNewValues(_viesEntity, _calculaterViesRows);
		SetEntityOnGrid();
	}

	private void EnableCalculationControls()
	{
		btnCalculate.Enabled = true;
		btnCancel.Visible = false;
		prbProgress.Visible = false;
		dgvViesEditor.Enabled = true;
		btnGenerateXML.Enabled = true;
		btnVATForm.Enabled = true;
		dtPeriodFrom.Enabled = true;
		dtPeriodTo.Enabled = true;
		cbDeclarationMonth.Enabled = true;
		cbDeclarationYear.Enabled = true;
	}

	private void DisableCalculationControls()
	{
		_cancelPressed = false;
		btnCalculate.Enabled = false;
		btnCancel.Visible = true;
		prbProgress.Visible = true;
		DisableReconciliation();
		dgvViesEditor.Enabled = false;
		btnGenerateXML.Enabled = false;
		btnVATForm.Enabled = false;
		dtPeriodFrom.Enabled = false;
		dtPeriodTo.Enabled = false;
		cbDeclarationMonth.Enabled = false;
		cbDeclarationYear.Enabled = false;
	}

	private void BtnCancelClick(object sender, EventArgs e)
	{
		_cancelPressed = true;
	}

	private void BtnOpenFolderClick(object sender, EventArgs e)
	{
		string companyXmlPath = _sageCompanyEntity.CompanyXmlPath;
		Directory.CreateDirectory(companyXmlPath);
		Process.Start(companyXmlPath);
	}

	private bool ValidateInputs()
	{
		List<string> list = new List<string>();
		foreach (ViesRowEntity viesRow in _viesEntity.ViesRows)
		{
			string text = viesRow.CountryCode.Trim() + "-" + viesRow.VatRegistrationNumber;
			if (list.Contains(text))
			{
				MessageBox.Show($"Duplicate rows found.\r\n\r\nVAT {text} number appears more than once.", "Cyprus VIES", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			list.Add(text);
		}
		return true;
	}

	private bool ValidateInputs2()
	{
		foreach (ViesRowEntity viesRow in _viesEntity.ViesRows)
		{
			if (viesRow.VatRegistrationNumber.Trim() == "")
			{
				MessageBox.Show($"Some rows do not have VAT registration numbers.", "Cyprus VIES", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (viesRow.CountryCode.Trim() == "")
			{
				MessageBox.Show($"Some rows do not have country codes.", "Cyprus VIES", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (viesRow.CountryName.Trim() == "")
			{
				MessageBox.Show($"Some rows do not have country names.", "Cyprus VIES", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
		}
		return true;
	}

	private void BtnAnalysisReportClick(object sender, EventArgs e)
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			rptVIESAnalysis rptVIESAnalysis = new rptVIESAnalysis();
			if (_viesEntity.DataTable.Rows.Count == 0)
			{
				MessageBox.Show("No transactions found for this period.\r\n\r\n", "No Transaction Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			foreach (VIES.TransactionSplitsRow item in _viesEntity.DataTable)
			{
				VIES.TransactionSplitsRow row1 = item;
				TransactionEntity transactionEntity = _viesEntity.ViesTransactions.Find((TransactionEntity c) => c.TransactionNumber == (int)row1["TRAN_NUMBER"]);
				if (transactionEntity != null)
				{
					item["IS_TRIANGULAR"] = transactionEntity.IsTriangular;
				}
			}
			_viesEntity.DataTable.DefaultView.RowFilter = "EU_MEMBER=1";
			_viesEntity.DataTable.DefaultView.Sort = "TRAN_DATE desc";
			rptVIESAnalysis.DataSource = _viesEntity.DataTable;
			rptVIESAnalysis.DateFrom = dtPeriodFrom.Value.ToShortDateString();
			rptVIESAnalysis.DateTo = dtPeriodTo.Value.ToShortDateString();
			rptVIESAnalysis.DateNow = DateTime.Now.ToShortDateString();
			rptVIESAnalysis.TimeNow = DateTime.Now.ToString("HH:mm");
			rptVIESAnalysis.CompanyName = _sageCompanyEntity.Name;
			rptVIESAnalysis.InitializeGroupingSorting();
			frmPreview frmPreview = new frmPreview(rptVIESAnalysis, DisplayNotification: false, IsAnalysisReport: true);
			frmPreview.Text = btnAnalysisReport.Text;
			frmPreview.Show();
		}
		finally
		{
			Cursor = Cursors.Default;
		}
	}

	private void DtPeriodFromValueChanged(object sender, EventArgs e)
	{
		if (!_loadingEntity)
		{
			DisableReconciliation();
		}
	}

	private void DtPeriodToValueChanged(object sender, EventArgs e)
	{
		if (!_loadingEntity)
		{
			DisableReconciliation();
		}
	}

	private void DisableReconciliation()
	{
		btnAnalysisReport.Enabled = false;
	}

	private void EnableReconciliation()
	{
		btnAnalysisReport.Enabled = true;
	}

	private void FrmReturnProcessShown(object sender, EventArgs e)
	{
		if (lblVatRegistration.Text.Trim() == "")
		{
			MessageBox.Show("Please provide a VAT Registration Number for this {0}. \r\n\r\nWithout the VAT Registration Number you will not be able to generate XML files for automatic submission\r\nto the Ministry of Finance TAXISNET service.".Replace("{0}", _singleCompany ? "company" : "group"), "Missing VAT Registration Number!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		ReorderRowNumbers();
		CalculateTotals();
		AdjustTotalsLabels();
	}

	private void DgvReturnProcessCellEnter(object sender, DataGridViewCellEventArgs e)
	{
		dgvViesEditor.BeginEdit(selectAll: true);
	}

	private void DgvReturnProcessCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
		string tag;
		try
		{
			tag = dgvViesEditor[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? "";
		}
		catch
		{
			tag = "";
		}
		if (dgvViesEditor[e.ColumnIndex, e.RowIndex].Tag == null)
		{
			dgvViesEditor[e.ColumnIndex, e.RowIndex].Tag = tag;
		}
	}

	private void DgvReturnProcessRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
	{
		ReorderRowNumbers();
		CalculateTotals();
	}

	private void btnGenerateRows_Click(object sender, EventArgs e)
	{
	}

	private void ReorderRowNumbers()
	{
		Bitmap trash_16x = Resources.trash_16x16;
		Bitmap button_off = Resources.button_off;
		foreach (DataGridViewRow item in (IEnumerable)dgvViesEditor.Rows)
		{
			if (item.IsNewRow)
			{
				item.Cells[0].Value = "";
				item.Cells[colRemoveRow.Index].Value = new Bitmap(1, 1);
				item.Cells[colTriangleButton.Index].Value = new Bitmap(1, 1);
			}
			else
			{
				item.Cells[0].Value = item.Cells[0].RowIndex + 1;
				item.Cells[colRemoveRow.Index].Value = trash_16x;
				item.Cells[colTriangleButton.Index].Value = button_off;
			}
		}
		txbEntriesCount.Text = (dgvViesEditor.Rows.Count - 1).ToString();
	}

	private void CalculateTotals()
	{
		decimal sumSuppliesAmount = default(decimal);
		decimal sumTriangleTransactionsAmount = default(decimal);
		decimal sumServicesAmount = default(decimal);
		foreach (DataGridViewRow item in (IEnumerable)dgvViesEditor.Rows)
		{
			if (!item.IsNewRow)
			{
				sumSuppliesAmount += Math.Round(Convert.ToDecimal(item.Cells[colGoods.Index].Value, CultureInfo.InvariantCulture));
				sumTriangleTransactionsAmount += Math.Round(Convert.ToDecimal(item.Cells[colTriangle.Index].Value, CultureInfo.InvariantCulture));
				sumServicesAmount += Math.Round(Convert.ToDecimal(item.Cells[colServices.Index].Value, CultureInfo.InvariantCulture));
			}
		}
		_viesEntity.SumSuppliesAmount = sumSuppliesAmount;
		_viesEntity.SumTriangleTransactionsAmount = sumTriangleTransactionsAmount;
		_viesEntity.SumServicesAmount = sumServicesAmount;
		txbTotalGoods.Text = "€ " + sumSuppliesAmount.ToString("0", CultureInfo.InvariantCulture);
		txbTotalTriangular.Text = "€ " + sumTriangleTransactionsAmount.ToString("0", CultureInfo.InvariantCulture);
		txbTotalServices.Text = "€ " + sumServicesAmount.ToString("0", CultureInfo.InvariantCulture);
	}

	private void DgvViesEditorCellMouseEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1)
		{
			if (dgvViesEditor.Columns[e.ColumnIndex].Name == colRemoveRow.Name && e.RowIndex < dgvViesEditor.Rows.Count - 1)
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = Resources.trash_red_16x16;
			}
			if (dgvViesEditor.Columns[e.ColumnIndex].Name == colTriangleButton.Name && e.RowIndex < dgvViesEditor.Rows.Count - 1)
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = Resources.button_on;
			}
		}
	}

	private void DgvViesEditorCellMouseLeave(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1)
		{
			if (dgvViesEditor.Columns[e.ColumnIndex].Name == colRemoveRow.Name && e.RowIndex < dgvViesEditor.Rows.Count - 1)
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = Resources.trash_16x16;
			}
			if (dgvViesEditor.Columns[e.ColumnIndex].Name == colTriangleButton.Name && e.RowIndex < dgvViesEditor.Rows.Count - 1)
			{
				dgvViesEditor[e.ColumnIndex, e.RowIndex].Value = Resources.button_off;
			}
		}
	}

	private void DgvViesEditorMouseLeave(object sender, EventArgs e)
	{
		timerHideTriangle.Enabled = false;
		timerHideTriangle.Enabled = true;
	}

	private void TimerHideTriangleTick(object sender, EventArgs e)
	{
		timerHideTriangle.Enabled = false;
	}

	private void BtnTriangleMouseEnter(object sender, EventArgs e)
	{
		timerHideTriangle.Enabled = false;
	}

	private void OpenTriangleWindow(int rowIndex)
	{
		ReadEntityFromGrid();
		DataGridViewRow dataGridViewRow = dgvViesEditor.Rows[rowIndex];
		string editedCountryCode = (dataGridViewRow.Cells[colCountryCode.Index].Value ?? "").ToString();
		string editedVatRegistrationNumber = (dataGridViewRow.Cells[colVATRegistration.Index].Value ?? "").ToString();
		List<TransactionEntity> list = _viesEntity.ViesTransactions.FindAll((TransactionEntity c) => c.CountryCode == editedCountryCode && c.VatRegistrationNumber == editedVatRegistrationNumber && c.GoodServiceText == "Goods");
		if (list.Count == 0)
		{
			MessageBox.Show("No transactions found");
		}
		else
		{
			if (new FrmTriangle(list).ShowDialog() != DialogResult.OK)
			{
				return;
			}
			foreach (TransactionEntity item in list)
			{
				TransactionEntity transaction1 = item;
				TransactionEntity transactionEntity = _viesEntity.ViesTransactions.Find((TransactionEntity c) => c.TransactionNumber == transaction1.TransactionNumber);
				if (transactionEntity == null)
				{
					MessageBox.Show("Could not locate row for updating");
					return;
				}
				transactionEntity.IsTriangular = item.IsTriangular;
			}
			_viesEntity.ViesRows = Service.GroupTransactions(_viesEntity.ViesTransactions);
			SetEntityOnGrid();
		}
	}

	private void BtnTriangleClick(object sender, EventArgs e)
	{
	}

	private void DgvViesEditorCellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == colRemoveRow.Index && e.RowIndex < dgvViesEditor.Rows.Count - 1 && e.RowIndex > -1)
		{
			dgvViesEditor.Rows.RemoveAt(e.RowIndex);
			btnTriangle.Hide();
			ReorderRowNumbers();
			CalculateTotals();
			ReadEntityFromGrid();
		}
		if (e.ColumnIndex == colTriangleButton.Index && e.RowIndex > -1 && e.RowIndex < dgvViesEditor.Rows.Count - 1)
		{
			OpenTriangleWindow(e.RowIndex);
		}
	}

	private void FrmDeclarationProcessSizeChanged(object sender, EventArgs e)
	{
		AdjustTotalsLabels();
	}

	private void AdjustTotalsLabels()
	{
		int num = (colTriangleButton.Visible ? colTriangleButton.Width : 0);
		int num2 = colNumber.Width + colCountryName.Width + colCountryCode.Width + colVATRegistration.Width;
		int num3 = num2 + num + colGoods.Width;
		int num4 = num3 + colTriangle.Width;
		lblTotalGoods.Left = num2 + 3;
		lblTotalTriangular.Left = num3 + 3;
		lblTotalServices.Left = num4 + 3;
		lblTotalGoods.Width = colGoods.Width - 6;
		lblTotalTriangular.Width = colTriangle.Width - 6;
		lblTotalServices.Width = colServices.Width - 6;
		txbTotalGoods.Left = lblTotalGoods.Left;
		txbTotalTriangular.Left = lblTotalTriangular.Left;
		txbTotalServices.Left = lblTotalServices.Left;
		txbTotalGoods.Width = lblTotalGoods.Width;
		txbTotalTriangular.Width = lblTotalTriangular.Width;
		txbTotalServices.Width = lblTotalServices.Width;
	}

	private void DgvViesEditorCurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		int columnIndex = dgvViesEditor.CurrentCell.ColumnIndex;
		int rowIndex = dgvViesEditor.CurrentCell.RowIndex;
		if (columnIndex == colCountryName.Index)
		{
			string countryCode = Service.GetCountryCode((dgvViesEditor[columnIndex, rowIndex].Value ?? "").ToString().ToUpper());
			if ((dgvViesEditor[colCountryCode.Index, rowIndex].Value ?? "").ToString() != countryCode)
			{
				dgvViesEditor[colCountryCode.Index, rowIndex].Value = countryCode;
			}
			dgvViesEditor.CurrentCell = dgvViesEditor[0, rowIndex];
		}
	}

	private void chkLoadCountriesListFromSage_CheckedChanged(object sender, EventArgs e)
	{
		colCountryName.Items.Clear();
		foreach (KeyValuePair<string, string> country in Service.GetCountries(chkLoadCountriesListFromSage.Checked, _sageCompanyEntity.SageConnectionString))
		{
			colCountryName.Items.Add(country.Key);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xSAD_VIES.GUI.FrmDeclarationProcess));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
		this.lblVatRegistration = new System.Windows.Forms.Label();
		this.lblCompanyAddress2 = new System.Windows.Forms.Label();
		this.lblCompanyAddress1 = new System.Windows.Forms.Label();
		this.lblCompanyName = new System.Windows.Forms.Label();
		this.btnCancel = new System.Windows.Forms.Button();
		this.btnCalculate = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.dtPeriodTo = new System.Windows.Forms.DateTimePicker();
		this.dtPeriodFrom = new System.Windows.Forms.DateTimePicker();
		this.label8 = new System.Windows.Forms.Label();
		this.pnlTop = new System.Windows.Forms.Panel();
		this.gbxPeriod = new System.Windows.Forms.GroupBox();
		this.cbDeclarationYear = new System.Windows.Forms.ComboBox();
		this.cbDeclarationMonth = new System.Windows.Forms.ComboBox();
		this.prbProgress = new System.Windows.Forms.ProgressBar();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.gbxCompanyInfo = new System.Windows.Forms.GroupBox();
		this.pnlMiddle = new System.Windows.Forms.Panel();
		this.btnTriangle = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.dgvViesEditor = new System.Windows.Forms.DataGridView();
		this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colCountryName = new System.Windows.Forms.DataGridViewComboBoxColumn();
		this.colCountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colVATRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colTriangleButton = new System.Windows.Forms.DataGridViewImageColumn();
		this.colTriangle = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colServices = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.colRemoveRow = new System.Windows.Forms.DataGridViewImageColumn();
		this.pnlTotals = new System.Windows.Forms.Panel();
		this.txbTotalServices = new System.Windows.Forms.Label();
		this.txbTotalTriangular = new System.Windows.Forms.Label();
		this.txbEntriesCount = new System.Windows.Forms.Label();
		this.txbTotalGoods = new System.Windows.Forms.Label();
		this.lblTotalServices = new System.Windows.Forms.Label();
		this.lblTotalTriangular = new System.Windows.Forms.Label();
		this.lblTotalGoods = new System.Windows.Forms.Label();
		this.lblEntriesCount = new System.Windows.Forms.Label();
		this.pnlBottomButtons = new System.Windows.Forms.Panel();
		this.gbxActions = new System.Windows.Forms.GroupBox();
		this.btnOpenFolder = new System.Windows.Forms.Button();
		this.btnGenerateXML = new System.Windows.Forms.Button();
		this.btnVATForm = new System.Windows.Forms.Button();
		this.btnAnalysisReport = new System.Windows.Forms.Button();
		this.timerHideTriangle = new System.Windows.Forms.Timer(this.components);
		this.chkReplaceGR = new System.Windows.Forms.CheckBox();
		this.chkLoadCountriesListFromSage = new System.Windows.Forms.CheckBox();
		this.pnlTop.SuspendLayout();
		this.gbxPeriod.SuspendLayout();
		this.gbxCompanyInfo.SuspendLayout();
		this.pnlMiddle.SuspendLayout();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvViesEditor).BeginInit();
		this.pnlTotals.SuspendLayout();
		this.pnlBottomButtons.SuspendLayout();
		this.gbxActions.SuspendLayout();
		base.SuspendLayout();
		this.lblVatRegistration.AutoSize = true;
		this.lblVatRegistration.ForeColor = System.Drawing.Color.Black;
		this.lblVatRegistration.Location = new System.Drawing.Point(17, 37);
		this.lblVatRegistration.Name = "lblVatRegistration";
		this.lblVatRegistration.Size = new System.Drawing.Size(98, 13);
		this.lblVatRegistration.TabIndex = 1;
		this.lblVatRegistration.Text = "VAT #1231231231";
		this.lblCompanyAddress2.AutoSize = true;
		this.lblCompanyAddress2.ForeColor = System.Drawing.Color.Black;
		this.lblCompanyAddress2.Location = new System.Drawing.Point(286, 31);
		this.lblCompanyAddress2.Name = "lblCompanyAddress2";
		this.lblCompanyAddress2.Size = new System.Drawing.Size(101, 13);
		this.lblCompanyAddress2.TabIndex = 0;
		this.lblCompanyAddress2.Text = "Company Address 2";
		this.lblCompanyAddress2.Visible = false;
		this.lblCompanyAddress1.AutoSize = true;
		this.lblCompanyAddress1.ForeColor = System.Drawing.Color.Black;
		this.lblCompanyAddress1.Location = new System.Drawing.Point(286, 16);
		this.lblCompanyAddress1.Name = "lblCompanyAddress1";
		this.lblCompanyAddress1.Size = new System.Drawing.Size(101, 13);
		this.lblCompanyAddress1.TabIndex = 0;
		this.lblCompanyAddress1.Text = "Company Address 1";
		this.lblCompanyAddress1.Visible = false;
		this.lblCompanyName.AutoSize = true;
		this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.lblCompanyName.ForeColor = System.Drawing.Color.Black;
		this.lblCompanyName.Location = new System.Drawing.Point(8, 17);
		this.lblCompanyName.Name = "lblCompanyName";
		this.lblCompanyName.Size = new System.Drawing.Size(89, 13);
		this.lblCompanyName.TabIndex = 0;
		this.lblCompanyName.Text = "AccountsTech";
		this.btnCancel.ForeColor = System.Drawing.Color.Black;
		this.btnCancel.Location = new System.Drawing.Point(148, 136);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new System.Drawing.Size(52, 23);
		this.btnCancel.TabIndex = 5;
		this.btnCancel.Tag = "";
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnCancel.Visible = false;
		this.btnCancel.Click += new System.EventHandler(BtnCancelClick);
		this.btnCalculate.ForeColor = System.Drawing.Color.Black;
		this.btnCalculate.Location = new System.Drawing.Point(206, 136);
		this.btnCalculate.Name = "btnCalculate";
		this.btnCalculate.Size = new System.Drawing.Size(94, 23);
		this.btnCalculate.TabIndex = 4;
		this.btnCalculate.Text = "Calculate";
		this.btnCalculate.UseVisualStyleBackColor = true;
		this.btnCalculate.Click += new System.EventHandler(BtnCalculateClick);
		this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label5.AutoSize = true;
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(182, 47);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(16, 13);
		this.label5.TabIndex = 2;
		this.label5.Text = "to";
		this.dtPeriodTo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.dtPeriodTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10f);
		this.dtPeriodTo.CalendarForeColor = System.Drawing.Color.FromArgb(0, 83, 160);
		this.dtPeriodTo.CalendarMonthBackground = System.Drawing.Color.White;
		this.dtPeriodTo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(0, 83, 160);
		this.dtPeriodTo.CalendarTitleForeColor = System.Drawing.Color.White;
		this.dtPeriodTo.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(211, 216, 237);
		this.dtPeriodTo.CustomFormat = "dd/MM/yyyy";
		this.dtPeriodTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
		this.dtPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		this.dtPeriodTo.Location = new System.Drawing.Point(204, 43);
		this.dtPeriodTo.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
		this.dtPeriodTo.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
		this.dtPeriodTo.Name = "dtPeriodTo";
		this.dtPeriodTo.Size = new System.Drawing.Size(94, 20);
		this.dtPeriodTo.TabIndex = 2;
		this.dtPeriodTo.ValueChanged += new System.EventHandler(DtPeriodToValueChanged);
		this.dtPeriodFrom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.dtPeriodFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.dtPeriodFrom.CalendarForeColor = System.Drawing.Color.FromArgb(0, 83, 160);
		this.dtPeriodFrom.CalendarMonthBackground = System.Drawing.Color.White;
		this.dtPeriodFrom.CalendarTitleBackColor = System.Drawing.Color.FromArgb(0, 83, 160);
		this.dtPeriodFrom.CalendarTitleForeColor = System.Drawing.Color.White;
		this.dtPeriodFrom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(211, 216, 237);
		this.dtPeriodFrom.CustomFormat = "dd/MM/yyyy";
		this.dtPeriodFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
		this.dtPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
		this.dtPeriodFrom.Location = new System.Drawing.Point(204, 17);
		this.dtPeriodFrom.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
		this.dtPeriodFrom.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
		this.dtPeriodFrom.Name = "dtPeriodFrom";
		this.dtPeriodFrom.Size = new System.Drawing.Size(94, 20);
		this.dtPeriodFrom.TabIndex = 1;
		this.dtPeriodFrom.ValueChanged += new System.EventHandler(DtPeriodFromValueChanged);
		this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label8.AutoSize = true;
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(67, 21);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(131, 13);
		this.label8.TabIndex = 0;
		this.label8.Text = "Declaration for period from";
		this.pnlTop.Controls.Add(this.chkLoadCountriesListFromSage);
		this.pnlTop.Controls.Add(this.gbxPeriod);
		this.pnlTop.Controls.Add(this.gbxCompanyInfo);
		this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
		this.pnlTop.Location = new System.Drawing.Point(0, 0);
		this.pnlTop.Name = "pnlTop";
		this.pnlTop.Size = new System.Drawing.Size(794, 187);
		this.pnlTop.TabIndex = 1;
		this.gbxPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.gbxPeriod.Controls.Add(this.cbDeclarationYear);
		this.gbxPeriod.Controls.Add(this.cbDeclarationMonth);
		this.gbxPeriod.Controls.Add(this.btnCancel);
		this.gbxPeriod.Controls.Add(this.dtPeriodTo);
		this.gbxPeriod.Controls.Add(this.btnCalculate);
		this.gbxPeriod.Controls.Add(this.prbProgress);
		this.gbxPeriod.Controls.Add(this.label5);
		this.gbxPeriod.Controls.Add(this.dtPeriodFrom);
		this.gbxPeriod.Controls.Add(this.label2);
		this.gbxPeriod.Controls.Add(this.label1);
		this.gbxPeriod.Controls.Add(this.label8);
		this.gbxPeriod.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.gbxPeriod.Location = new System.Drawing.Point(475, 8);
		this.gbxPeriod.Name = "gbxPeriod";
		this.gbxPeriod.Size = new System.Drawing.Size(309, 173);
		this.gbxPeriod.TabIndex = 1;
		this.gbxPeriod.TabStop = false;
		this.gbxPeriod.Text = "Declaration Period";
		this.cbDeclarationYear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.cbDeclarationYear.FormattingEnabled = true;
		this.cbDeclarationYear.Location = new System.Drawing.Point(204, 96);
		this.cbDeclarationYear.Name = "cbDeclarationYear";
		this.cbDeclarationYear.Size = new System.Drawing.Size(94, 21);
		this.cbDeclarationYear.TabIndex = 6;
		this.cbDeclarationMonth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.cbDeclarationMonth.FormattingEnabled = true;
		this.cbDeclarationMonth.Location = new System.Drawing.Point(204, 69);
		this.cbDeclarationMonth.Name = "cbDeclarationMonth";
		this.cbDeclarationMonth.Size = new System.Drawing.Size(94, 21);
		this.cbDeclarationMonth.TabIndex = 6;
		this.prbProgress.Location = new System.Drawing.Point(15, 137);
		this.prbProgress.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
		this.prbProgress.Name = "prbProgress";
		this.prbProgress.Size = new System.Drawing.Size(127, 22);
		this.prbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
		this.prbProgress.TabIndex = 0;
		this.prbProgress.Visible = false;
		this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(114, 99);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(84, 13);
		this.label2.TabIndex = 0;
		this.label2.Text = "Declaration year";
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(105, 72);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(93, 13);
		this.label1.TabIndex = 0;
		this.label1.Text = "Declaration month";
		this.gbxCompanyInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbxCompanyInfo.Controls.Add(this.lblVatRegistration);
		this.gbxCompanyInfo.Controls.Add(this.lblCompanyName);
		this.gbxCompanyInfo.Controls.Add(this.lblCompanyAddress2);
		this.gbxCompanyInfo.Controls.Add(this.lblCompanyAddress1);
		this.gbxCompanyInfo.ForeColor = System.Drawing.Color.FromArgb(209, 109, 8);
		this.gbxCompanyInfo.Location = new System.Drawing.Point(10, 8);
		this.gbxCompanyInfo.Name = "gbxCompanyInfo";
		this.gbxCompanyInfo.Size = new System.Drawing.Size(452, 145);
		this.gbxCompanyInfo.TabIndex = 1;
		this.gbxCompanyInfo.TabStop = false;
		this.gbxCompanyInfo.Text = "Company Information";
		this.pnlMiddle.Controls.Add(this.btnTriangle);
		this.pnlMiddle.Controls.Add(this.groupBox1);
		this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
		this.pnlMiddle.Location = new System.Drawing.Point(0, 187);
		this.pnlMiddle.Name = "pnlMiddle";
		this.pnlMiddle.Padding = new System.Windows.Forms.Padding(10);
		this.pnlMiddle.Size = new System.Drawing.Size(794, 453);
		this.pnlMiddle.TabIndex = 2;
		this.btnTriangle.Location = new System.Drawing.Point(586, 187);
		this.btnTriangle.Name = "btnTriangle";
		this.btnTriangle.Size = new System.Drawing.Size(28, 20);
		this.btnTriangle.TabIndex = 4;
		this.btnTriangle.Text = ">";
		this.btnTriangle.UseVisualStyleBackColor = true;
		this.btnTriangle.Visible = false;
		this.btnTriangle.Click += new System.EventHandler(BtnTriangleClick);
		this.btnTriangle.MouseEnter += new System.EventHandler(BtnTriangleMouseEnter);
		this.groupBox1.Controls.Add(this.dgvViesEditor);
		this.groupBox1.Controls.Add(this.pnlTotals);
		this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.groupBox1.ForeColor = System.Drawing.Color.Black;
		this.groupBox1.Location = new System.Drawing.Point(10, 10);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(774, 433);
		this.groupBox1.TabIndex = 5;
		this.groupBox1.TabStop = false;
		this.dgvViesEditor.AllowUserToResizeColumns = false;
		this.dgvViesEditor.AllowUserToResizeRows = false;
		this.dgvViesEditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvViesEditor.BackgroundColor = System.Drawing.Color.White;
		this.dgvViesEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(211, 216, 237);
		dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvViesEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dgvViesEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvViesEditor.Columns.AddRange(this.colNumber, this.colCountryName, this.colCountryCode, this.colVATRegistration, this.colName, this.colGoods, this.colTriangleButton, this.colTriangle, this.colServices, this.colRemoveRow);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
		dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvViesEditor.DefaultCellStyle = dataGridViewCellStyle2;
		this.dgvViesEditor.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgvViesEditor.GridColor = System.Drawing.Color.FromArgb(78, 135, 209);
		this.dgvViesEditor.Location = new System.Drawing.Point(3, 116);
		this.dgvViesEditor.MultiSelect = false;
		this.dgvViesEditor.Name = "dgvViesEditor";
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dgvViesEditor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
		this.dgvViesEditor.RowHeadersVisible = false;
		this.dgvViesEditor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
		this.dgvViesEditor.Size = new System.Drawing.Size(768, 314);
		this.dgvViesEditor.TabIndex = 0;
		this.dgvViesEditor.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(DgvReturnProcessCellBeginEdit);
		this.dgvViesEditor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(DgvViesEditorCellClick);
		this.dgvViesEditor.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridView1CellEndEdit);
		this.dgvViesEditor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(DgvReturnProcessCellEnter);
		this.dgvViesEditor.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(DgvViesEditorCellMouseEnter);
		this.dgvViesEditor.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(DgvViesEditorCellMouseLeave);
		this.dgvViesEditor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(DataGridView1CellPainting);
		this.dgvViesEditor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridView1CellValueChanged);
		this.dgvViesEditor.CurrentCellDirtyStateChanged += new System.EventHandler(DgvViesEditorCurrentCellDirtyStateChanged);
		this.dgvViesEditor.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(DgvReturnProcessRowsAdded);
		this.dgvViesEditor.MouseLeave += new System.EventHandler(DgvViesEditorMouseLeave);
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(211, 216, 237);
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(0, 83, 160);
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(211, 216, 237);
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(0, 83, 160);
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.colNumber.DefaultCellStyle = dataGridViewCellStyle4;
		this.colNumber.FillWeight = 24.44878f;
		this.colNumber.HeaderText = "S/N";
		this.colNumber.Name = "colNumber";
		this.colNumber.ReadOnly = true;
		this.colNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.colCountryName.FillWeight = 75.42146f;
		this.colCountryName.HeaderText = "Country Name";
		this.colCountryName.Name = "colCountryName";
		this.colCountryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.colCountryCode.DefaultCellStyle = dataGridViewCellStyle5;
		this.colCountryCode.FillWeight = 34.05286f;
		this.colCountryCode.HeaderText = "Country Code";
		this.colCountryCode.Name = "colCountryCode";
		this.colCountryCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.colVATRegistration.FillWeight = 83.42146f;
		this.colVATRegistration.HeaderText = "VAT Registration";
		this.colVATRegistration.Name = "colVATRegistration";
		this.colVATRegistration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.colName.FillWeight = 98.1626f;
		this.colName.HeaderText = "Name";
		this.colName.Name = "colName";
		this.colName.Visible = false;
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
		this.colGoods.DefaultCellStyle = dataGridViewCellStyle6;
		this.colGoods.FillWeight = 83.42146f;
		this.colGoods.HeaderText = "                 Goods €";
		this.colGoods.Name = "colGoods";
		this.colGoods.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle7.NullValue = resources.GetObject("dataGridViewCellStyle65.NullValue");
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
		this.colTriangleButton.DefaultCellStyle = dataGridViewCellStyle7;
		this.colTriangleButton.FillWeight = 10f;
		this.colTriangleButton.HeaderText = "";
		this.colTriangleButton.Name = "colTriangleButton";
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
		this.colTriangle.DefaultCellStyle = dataGridViewCellStyle8;
		this.colTriangle.FillWeight = 83.42146f;
		this.colTriangle.HeaderText = "         Triangular €";
		this.colTriangle.Name = "colTriangle";
		this.colTriangle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
		dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
		dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(255, 255, 210);
		dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
		this.colServices.DefaultCellStyle = dataGridViewCellStyle9;
		this.colServices.FillWeight = 83.42146f;
		this.colServices.HeaderText = "            Services €";
		this.colServices.Name = "colServices";
		this.colServices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		dataGridViewCellStyle10.NullValue = resources.GetObject("dataGridViewCellStyle68.NullValue");
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
		this.colRemoveRow.DefaultCellStyle = dataGridViewCellStyle10;
		this.colRemoveRow.FillWeight = 16.64448f;
		this.colRemoveRow.HeaderText = "";
		this.colRemoveRow.Image = xSAD_VIES.Properties.Resources.trash_red_16x16;
		this.colRemoveRow.Name = "colRemoveRow";
		this.pnlTotals.Controls.Add(this.txbTotalServices);
		this.pnlTotals.Controls.Add(this.txbTotalTriangular);
		this.pnlTotals.Controls.Add(this.txbEntriesCount);
		this.pnlTotals.Controls.Add(this.txbTotalGoods);
		this.pnlTotals.Controls.Add(this.lblTotalServices);
		this.pnlTotals.Controls.Add(this.lblTotalTriangular);
		this.pnlTotals.Controls.Add(this.lblTotalGoods);
		this.pnlTotals.Controls.Add(this.lblEntriesCount);
		this.pnlTotals.Dock = System.Windows.Forms.DockStyle.Top;
		this.pnlTotals.Location = new System.Drawing.Point(3, 16);
		this.pnlTotals.Name = "pnlTotals";
		this.pnlTotals.Size = new System.Drawing.Size(768, 100);
		this.pnlTotals.TabIndex = 3;
		this.txbTotalServices.BackColor = System.Drawing.Color.FromArgb(200, 200, 240);
		this.txbTotalServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.txbTotalServices.Location = new System.Drawing.Point(645, 66);
		this.txbTotalServices.Name = "txbTotalServices";
		this.txbTotalServices.Size = new System.Drawing.Size(112, 24);
		this.txbTotalServices.TabIndex = 5;
		this.txbTotalServices.Text = "€ 0.00";
		this.txbTotalServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.txbTotalTriangular.BackColor = System.Drawing.Color.FromArgb(200, 200, 240);
		this.txbTotalTriangular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.txbTotalTriangular.Location = new System.Drawing.Point(498, 66);
		this.txbTotalTriangular.Name = "txbTotalTriangular";
		this.txbTotalTriangular.Size = new System.Drawing.Size(112, 24);
		this.txbTotalTriangular.TabIndex = 5;
		this.txbTotalTriangular.Text = "€ 0.00";
		this.txbTotalTriangular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.txbEntriesCount.BackColor = System.Drawing.Color.FromArgb(200, 200, 240);
		this.txbEntriesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.txbEntriesCount.Location = new System.Drawing.Point(22, 66);
		this.txbEntriesCount.Name = "txbEntriesCount";
		this.txbEntriesCount.Size = new System.Drawing.Size(73, 24);
		this.txbEntriesCount.TabIndex = 5;
		this.txbEntriesCount.Text = "0";
		this.txbEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.txbTotalGoods.BackColor = System.Drawing.Color.FromArgb(200, 200, 240);
		this.txbTotalGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
		this.txbTotalGoods.Location = new System.Drawing.Point(351, 66);
		this.txbTotalGoods.Name = "txbTotalGoods";
		this.txbTotalGoods.Size = new System.Drawing.Size(112, 24);
		this.txbTotalGoods.TabIndex = 5;
		this.txbTotalGoods.Text = "€ 0.00";
		this.txbTotalGoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.lblTotalServices.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.lblTotalServices.Location = new System.Drawing.Point(645, 7);
		this.lblTotalServices.Name = "lblTotalServices";
		this.lblTotalServices.Size = new System.Drawing.Size(112, 59);
		this.lblTotalServices.TabIndex = 0;
		this.lblTotalServices.Text = "Total value of sales of services";
		this.lblTotalServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblTotalTriangular.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.lblTotalTriangular.Location = new System.Drawing.Point(498, 7);
		this.lblTotalTriangular.Name = "lblTotalTriangular";
		this.lblTotalTriangular.Size = new System.Drawing.Size(112, 59);
		this.lblTotalTriangular.TabIndex = 0;
		this.lblTotalTriangular.Text = "Total value of triangular transactions";
		this.lblTotalTriangular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblTotalGoods.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.lblTotalGoods.Location = new System.Drawing.Point(351, 7);
		this.lblTotalGoods.Name = "lblTotalGoods";
		this.lblTotalGoods.Size = new System.Drawing.Size(112, 59);
		this.lblTotalGoods.TabIndex = 0;
		this.lblTotalGoods.Text = "Total value of sales of goods";
		this.lblTotalGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.lblEntriesCount.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
		this.lblEntriesCount.Location = new System.Drawing.Point(23, 7);
		this.lblEntriesCount.Name = "lblEntriesCount";
		this.lblEntriesCount.Size = new System.Drawing.Size(72, 59);
		this.lblEntriesCount.TabIndex = 0;
		this.lblEntriesCount.Text = "Total number of entries";
		this.lblEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.pnlBottomButtons.Controls.Add(this.gbxActions);
		this.pnlBottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.pnlBottomButtons.Location = new System.Drawing.Point(0, 640);
		this.pnlBottomButtons.Name = "pnlBottomButtons";
		this.pnlBottomButtons.Size = new System.Drawing.Size(794, 93);
		this.pnlBottomButtons.TabIndex = 3;
		this.gbxActions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.gbxActions.Controls.Add(this.chkReplaceGR);
		this.gbxActions.Controls.Add(this.btnOpenFolder);
		this.gbxActions.Controls.Add(this.btnGenerateXML);
		this.gbxActions.Controls.Add(this.btnVATForm);
		this.gbxActions.Controls.Add(this.btnAnalysisReport);
		this.gbxActions.ForeColor = System.Drawing.Color.FromArgb(0, 83, 160);
		this.gbxActions.Location = new System.Drawing.Point(10, 6);
		this.gbxActions.Name = "gbxActions";
		this.gbxActions.Size = new System.Drawing.Size(774, 75);
		this.gbxActions.TabIndex = 1;
		this.gbxActions.TabStop = false;
		this.gbxActions.Text = "View VIES form && Analysis report";
		this.btnOpenFolder.ForeColor = System.Drawing.Color.Black;
		this.btnOpenFolder.Location = new System.Drawing.Point(439, 19);
		this.btnOpenFolder.Name = "btnOpenFolder";
		this.btnOpenFolder.Size = new System.Drawing.Size(136, 23);
		this.btnOpenFolder.TabIndex = 9;
		this.btnOpenFolder.Text = "Open Folder";
		this.btnOpenFolder.UseVisualStyleBackColor = true;
		this.btnOpenFolder.Click += new System.EventHandler(BtnOpenFolderClick);
		this.btnGenerateXML.ForeColor = System.Drawing.Color.Black;
		this.btnGenerateXML.Location = new System.Drawing.Point(297, 20);
		this.btnGenerateXML.Name = "btnGenerateXML";
		this.btnGenerateXML.Size = new System.Drawing.Size(136, 23);
		this.btnGenerateXML.TabIndex = 8;
		this.btnGenerateXML.Text = "Generate XML";
		this.btnGenerateXML.UseVisualStyleBackColor = true;
		this.btnGenerateXML.Click += new System.EventHandler(BtnGenerateXmlClick);
		this.btnVATForm.ForeColor = System.Drawing.Color.Black;
		this.btnVATForm.Location = new System.Drawing.Point(13, 20);
		this.btnVATForm.Name = "btnVATForm";
		this.btnVATForm.Size = new System.Drawing.Size(136, 23);
		this.btnVATForm.TabIndex = 10;
		this.btnVATForm.Text = "VIES Declaration Form";
		this.btnVATForm.UseVisualStyleBackColor = true;
		this.btnVATForm.Click += new System.EventHandler(BtnViesFormClick);
		this.btnAnalysisReport.Enabled = false;
		this.btnAnalysisReport.ForeColor = System.Drawing.Color.Black;
		this.btnAnalysisReport.Location = new System.Drawing.Point(155, 20);
		this.btnAnalysisReport.Name = "btnAnalysisReport";
		this.btnAnalysisReport.Size = new System.Drawing.Size(136, 23);
		this.btnAnalysisReport.TabIndex = 11;
		this.btnAnalysisReport.Text = "Analysis Report";
		this.btnAnalysisReport.UseVisualStyleBackColor = true;
		this.btnAnalysisReport.Click += new System.EventHandler(BtnAnalysisReportClick);
		this.timerHideTriangle.Interval = 300;
		this.timerHideTriangle.Tick += new System.EventHandler(TimerHideTriangleTick);
		this.chkReplaceGR.AutoSize = true;
		this.chkReplaceGR.Checked = true;
		this.chkReplaceGR.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkReplaceGR.Location = new System.Drawing.Point(297, 48);
		this.chkReplaceGR.Name = "chkReplaceGR";
		this.chkReplaceGR.Size = new System.Drawing.Size(179, 17);
		this.chkReplaceGR.TabIndex = 12;
		this.chkReplaceGR.Text = "Replace \"GR\" with \"EL\" in XML";
		this.chkReplaceGR.UseVisualStyleBackColor = true;
		this.chkLoadCountriesListFromSage.AutoSize = true;
		this.chkLoadCountriesListFromSage.Checked = true;
		this.chkLoadCountriesListFromSage.CheckState = System.Windows.Forms.CheckState.Checked;
		this.chkLoadCountriesListFromSage.Location = new System.Drawing.Point(10, 159);
		this.chkLoadCountriesListFromSage.Name = "chkLoadCountriesListFromSage";
		this.chkLoadCountriesListFromSage.Size = new System.Drawing.Size(162, 17);
		this.chkLoadCountriesListFromSage.TabIndex = 13;
		this.chkLoadCountriesListFromSage.Text = "Load countries list from Sage";
		this.chkLoadCountriesListFromSage.UseVisualStyleBackColor = true;
		this.chkLoadCountriesListFromSage.CheckedChanged += new System.EventHandler(chkLoadCountriesListFromSage_CheckedChanged);
		base.AcceptButton = this.btnCalculate;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(794, 733);
		base.Controls.Add(this.pnlMiddle);
		base.Controls.Add(this.pnlBottomButtons);
		base.Controls.Add(this.pnlTop);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FrmDeclarationProcess";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Cyprus VIES Declaration";
		base.Shown += new System.EventHandler(FrmReturnProcessShown);
		base.SizeChanged += new System.EventHandler(FrmDeclarationProcessSizeChanged);
		this.pnlTop.ResumeLayout(false);
		this.pnlTop.PerformLayout();
		this.gbxPeriod.ResumeLayout(false);
		this.gbxPeriod.PerformLayout();
		this.gbxCompanyInfo.ResumeLayout(false);
		this.gbxCompanyInfo.PerformLayout();
		this.pnlMiddle.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.dgvViesEditor).EndInit();
		this.pnlTotals.ResumeLayout(false);
		this.pnlBottomButtons.ResumeLayout(false);
		this.gbxActions.ResumeLayout(false);
		this.gbxActions.PerformLayout();
		base.ResumeLayout(false);
	}
}
