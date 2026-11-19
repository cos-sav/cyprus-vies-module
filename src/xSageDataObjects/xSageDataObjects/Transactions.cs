using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects;

/// <summary>
/// Represents a strongly typed in-memory cache of data.
/// </summary>
[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("Transactions")]
[HelpKeyword("vs.data.DataSet")]
public class Transactions : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void AUDIT_SPLITRowChangeEventHandler(object sender, AUDIT_SPLITRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void AUDIT_HEADERRowChangeEventHandler(object sender, AUDIT_HEADERRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class AUDIT_SPLITDataTable : TypedTableBase<AUDIT_SPLITRow>
	{
		private DataColumn columnTRAN_NUMBER;

		private DataColumn columnTYPE;

		private DataColumn columnDATE;

		private DataColumn columnACCOUNT_REF;

		private DataColumn columnNOMINAL_CODE;

		private DataColumn columnBANK_CODE;

		private DataColumn columnINV_REF;

		private DataColumn columnUSER_NAME;

		private DataColumn columnDETAILS;

		private DataColumn columnEXTRA_REF;

		private DataColumn columnDISPUTED;

		private DataColumn columnSTMT_TEXT;

		private DataColumn columnBANK_FLAG;

		private DataColumn columnVAT_FLAG;

		private DataColumn columnPAID_FLAG;

		private DataColumn columnPAID_STATUS;

		private DataColumn columnDEPT_NUMBER;

		private DataColumn columnDEPT_NAME;

		private DataColumn columnTAX_CODE;

		private DataColumn columnDELETED_FLAG;

		private DataColumn columnNET_AMOUNT;

		private DataColumn columnTAX_AMOUNT;

		private DataColumn columnGROSS_AMOUNT;

		private DataColumn columnAMOUNT_PAID;

		private DataColumn columnPAYMENT;

		private DataColumn columnOUTSTANDING;

		private DataColumn columnFOREIGN_NET_AMOUNT;

		private DataColumn columnFOREIGN_TAX_AMOUNT;

		private DataColumn columnFOREIGN_GROSS_AMOUNT;

		private DataColumn columnFOREIGN_AMOUNT_PAID;

		private DataColumn columnAGED_BALANCE;

		private DataColumn columnAGED_FUTURE;

		private DataColumn columnAGED_CURRENT;

		private DataColumn columnAGED_30;

		private DataColumn columnAGED_60;

		private DataColumn columnAGED_90;

		private DataColumn columnAGED_OLDER;

		private DataColumn columnAGED_CUM_CURRENT;

		private DataColumn columnAGED_CUM_30;

		private DataColumn columnAGED_CUM_60;

		private DataColumn columnAGED_CUM_90;

		private DataColumn columnFOREIGN_AGED_BALANCE;

		private DataColumn columnFOREIGN_AGED_FUTURE;

		private DataColumn columnFOREIGN_AGED_CURRENT;

		private DataColumn columnFOREIGN_AGED_30;

		private DataColumn columnFOREIGN_AGED_60;

		private DataColumn columnFOREIGN_AGED_90;

		private DataColumn columnFOREIGN_AGED_OLDER;

		private DataColumn columnFOREIGN_AGED_CUM_CURRENT;

		private DataColumn columnFOREIGN_AGED_CUM_30;

		private DataColumn columnFOREIGN_AGED_CUM_60;

		private DataColumn columnFOREIGN_AGED_CUM_90;

		private DataColumn columnSPLIT_NUMBER;

		private DataColumn columnHEADER_NUMBER;

		private DataColumn columnVAT_FLAG_CODE;

		private DataColumn columnDATE_FLAG;

		private DataColumn columnDATE_ENTERED;

		private DataColumn columnVAT_RECONCILED_DATE;

		private DataColumn columnDISPUTE_CODE;

		private DataColumn columnFUND_ID;

		private DataColumn columnVAT_LEDGER_RETURN_ID;

		private DataColumn columnRECORD_CREATE_DATE;

		private DataColumn columnRECORD_MODIFY_DATE;

		private DataColumn columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TRAN_NUMBERColumn => columnTRAN_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TYPEColumn => columnTYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATEColumn => columnDATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_REFColumn => columnACCOUNT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NOMINAL_CODEColumn => columnNOMINAL_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_CODEColumn => columnBANK_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INV_REFColumn => columnINV_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn USER_NAMEColumn => columnUSER_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DETAILSColumn => columnDETAILS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EXTRA_REFColumn => columnEXTRA_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISPUTEDColumn => columnDISPUTED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STMT_TEXTColumn => columnSTMT_TEXT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_FLAGColumn => columnBANK_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_FLAGColumn => columnVAT_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAID_FLAGColumn => columnPAID_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAID_STATUSColumn => columnPAID_STATUS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPT_NUMBERColumn => columnDEPT_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPT_NAMEColumn => columnDEPT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_CODEColumn => columnTAX_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DELETED_FLAGColumn => columnDELETED_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NET_AMOUNTColumn => columnNET_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_AMOUNTColumn => columnTAX_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn GROSS_AMOUNTColumn => columnGROSS_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AMOUNT_PAIDColumn => columnAMOUNT_PAID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENTColumn => columnPAYMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OUTSTANDINGColumn => columnOUTSTANDING;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_NET_AMOUNTColumn => columnFOREIGN_NET_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_TAX_AMOUNTColumn => columnFOREIGN_TAX_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_GROSS_AMOUNTColumn => columnFOREIGN_GROSS_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AMOUNT_PAIDColumn => columnFOREIGN_AMOUNT_PAID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_BALANCEColumn => columnAGED_BALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_FUTUREColumn => columnAGED_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CURRENTColumn => columnAGED_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_30Column => columnAGED_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_60Column => columnAGED_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_90Column => columnAGED_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_OLDERColumn => columnAGED_OLDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_CURRENTColumn => columnAGED_CUM_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_30Column => columnAGED_CUM_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_60Column => columnAGED_CUM_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_90Column => columnAGED_CUM_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_BALANCEColumn => columnFOREIGN_AGED_BALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_FUTUREColumn => columnFOREIGN_AGED_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CURRENTColumn => columnFOREIGN_AGED_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_30Column => columnFOREIGN_AGED_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_60Column => columnFOREIGN_AGED_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_90Column => columnFOREIGN_AGED_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_OLDERColumn => columnFOREIGN_AGED_OLDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_CURRENTColumn => columnFOREIGN_AGED_CUM_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_30Column => columnFOREIGN_AGED_CUM_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_60Column => columnFOREIGN_AGED_CUM_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_90Column => columnFOREIGN_AGED_CUM_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SPLIT_NUMBERColumn => columnSPLIT_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HEADER_NUMBERColumn => columnHEADER_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_FLAG_CODEColumn => columnVAT_FLAG_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_FLAGColumn => columnDATE_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_ENTEREDColumn => columnDATE_ENTERED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_RECONCILED_DATEColumn => columnVAT_RECONCILED_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISPUTE_CODEColumn => columnDISPUTE_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FUND_IDColumn => columnFUND_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_LEDGER_RETURN_IDColumn => columnVAT_LEDGER_RETURN_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_CREATE_DATEColumn => columnRECORD_CREATE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_MODIFY_DATEColumn => columnRECORD_MODIFY_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_DELETEDColumn => columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITRow this[int index] => (AUDIT_SPLITRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_SPLITRowChangeEventHandler AUDIT_SPLITRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_SPLITRowChangeEventHandler AUDIT_SPLITRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_SPLITRowChangeEventHandler AUDIT_SPLITRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_SPLITRowChangeEventHandler AUDIT_SPLITRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITDataTable()
		{
			base.TableName = "AUDIT_SPLIT";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal AUDIT_SPLITDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				base.Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected AUDIT_SPLITDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddAUDIT_SPLITRow(AUDIT_SPLITRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITRow AddAUDIT_SPLITRow(int TRAN_NUMBER, string TYPE, DateTime _DATE, string ACCOUNT_REF, string NOMINAL_CODE, string BANK_CODE, string INV_REF, string USER_NAME, string DETAILS, string EXTRA_REF, short DISPUTED, string STMT_TEXT, string BANK_FLAG, string VAT_FLAG, string PAID_FLAG, string PAID_STATUS, short DEPT_NUMBER, string DEPT_NAME, string TAX_CODE, short DELETED_FLAG, double NET_AMOUNT, double TAX_AMOUNT, double GROSS_AMOUNT, double AMOUNT_PAID, double PAYMENT, double OUTSTANDING, double FOREIGN_NET_AMOUNT, double FOREIGN_TAX_AMOUNT, double FOREIGN_GROSS_AMOUNT, double FOREIGN_AMOUNT_PAID, double AGED_BALANCE, double AGED_FUTURE, double AGED_CURRENT, double AGED_30, double AGED_60, double AGED_90, double AGED_OLDER, double AGED_CUM_CURRENT, double AGED_CUM_30, double AGED_CUM_60, double AGED_CUM_90, double FOREIGN_AGED_BALANCE, double FOREIGN_AGED_FUTURE, double FOREIGN_AGED_CURRENT, double FOREIGN_AGED_30, double FOREIGN_AGED_60, double FOREIGN_AGED_90, double FOREIGN_AGED_OLDER, double FOREIGN_AGED_CUM_CURRENT, double FOREIGN_AGED_CUM_30, double FOREIGN_AGED_CUM_60, double FOREIGN_AGED_CUM_90, int SPLIT_NUMBER, int HEADER_NUMBER, short VAT_FLAG_CODE, short DATE_FLAG, DateTime DATE_ENTERED, DateTime VAT_RECONCILED_DATE, short DISPUTE_CODE, int FUND_ID, int VAT_LEDGER_RETURN_ID, DateTime RECORD_CREATE_DATE, DateTime RECORD_MODIFY_DATE, short RECORD_DELETED)
		{
			AUDIT_SPLITRow aUDIT_SPLITRow = (AUDIT_SPLITRow)NewRow();
			object[] itemArray = new object[64]
			{
				TRAN_NUMBER, TYPE, _DATE, ACCOUNT_REF, NOMINAL_CODE, BANK_CODE, INV_REF, USER_NAME, DETAILS, EXTRA_REF,
				DISPUTED, STMT_TEXT, BANK_FLAG, VAT_FLAG, PAID_FLAG, PAID_STATUS, DEPT_NUMBER, DEPT_NAME, TAX_CODE, DELETED_FLAG,
				NET_AMOUNT, TAX_AMOUNT, GROSS_AMOUNT, AMOUNT_PAID, PAYMENT, OUTSTANDING, FOREIGN_NET_AMOUNT, FOREIGN_TAX_AMOUNT, FOREIGN_GROSS_AMOUNT, FOREIGN_AMOUNT_PAID,
				AGED_BALANCE, AGED_FUTURE, AGED_CURRENT, AGED_30, AGED_60, AGED_90, AGED_OLDER, AGED_CUM_CURRENT, AGED_CUM_30, AGED_CUM_60,
				AGED_CUM_90, FOREIGN_AGED_BALANCE, FOREIGN_AGED_FUTURE, FOREIGN_AGED_CURRENT, FOREIGN_AGED_30, FOREIGN_AGED_60, FOREIGN_AGED_90, FOREIGN_AGED_OLDER, FOREIGN_AGED_CUM_CURRENT, FOREIGN_AGED_CUM_30,
				FOREIGN_AGED_CUM_60, FOREIGN_AGED_CUM_90, SPLIT_NUMBER, HEADER_NUMBER, VAT_FLAG_CODE, DATE_FLAG, DATE_ENTERED, VAT_RECONCILED_DATE, DISPUTE_CODE, FUND_ID,
				VAT_LEDGER_RETURN_ID, RECORD_CREATE_DATE, RECORD_MODIFY_DATE, RECORD_DELETED
			};
			aUDIT_SPLITRow.ItemArray = itemArray;
			base.Rows.Add(aUDIT_SPLITRow);
			return aUDIT_SPLITRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			AUDIT_SPLITDataTable obj = (AUDIT_SPLITDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new AUDIT_SPLITDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnTRAN_NUMBER = base.Columns["TRAN_NUMBER"];
			columnTYPE = base.Columns["TYPE"];
			columnDATE = base.Columns["DATE"];
			columnACCOUNT_REF = base.Columns["ACCOUNT_REF"];
			columnNOMINAL_CODE = base.Columns["NOMINAL_CODE"];
			columnBANK_CODE = base.Columns["BANK_CODE"];
			columnINV_REF = base.Columns["INV_REF"];
			columnUSER_NAME = base.Columns["USER_NAME"];
			columnDETAILS = base.Columns["DETAILS"];
			columnEXTRA_REF = base.Columns["EXTRA_REF"];
			columnDISPUTED = base.Columns["DISPUTED"];
			columnSTMT_TEXT = base.Columns["STMT_TEXT"];
			columnBANK_FLAG = base.Columns["BANK_FLAG"];
			columnVAT_FLAG = base.Columns["VAT_FLAG"];
			columnPAID_FLAG = base.Columns["PAID_FLAG"];
			columnPAID_STATUS = base.Columns["PAID_STATUS"];
			columnDEPT_NUMBER = base.Columns["DEPT_NUMBER"];
			columnDEPT_NAME = base.Columns["DEPT_NAME"];
			columnTAX_CODE = base.Columns["TAX_CODE"];
			columnDELETED_FLAG = base.Columns["DELETED_FLAG"];
			columnNET_AMOUNT = base.Columns["NET_AMOUNT"];
			columnTAX_AMOUNT = base.Columns["TAX_AMOUNT"];
			columnGROSS_AMOUNT = base.Columns["GROSS_AMOUNT"];
			columnAMOUNT_PAID = base.Columns["AMOUNT_PAID"];
			columnPAYMENT = base.Columns["PAYMENT"];
			columnOUTSTANDING = base.Columns["OUTSTANDING"];
			columnFOREIGN_NET_AMOUNT = base.Columns["FOREIGN_NET_AMOUNT"];
			columnFOREIGN_TAX_AMOUNT = base.Columns["FOREIGN_TAX_AMOUNT"];
			columnFOREIGN_GROSS_AMOUNT = base.Columns["FOREIGN_GROSS_AMOUNT"];
			columnFOREIGN_AMOUNT_PAID = base.Columns["FOREIGN_AMOUNT_PAID"];
			columnAGED_BALANCE = base.Columns["AGED_BALANCE"];
			columnAGED_FUTURE = base.Columns["AGED_FUTURE"];
			columnAGED_CURRENT = base.Columns["AGED_CURRENT"];
			columnAGED_30 = base.Columns["AGED_30"];
			columnAGED_60 = base.Columns["AGED_60"];
			columnAGED_90 = base.Columns["AGED_90"];
			columnAGED_OLDER = base.Columns["AGED_OLDER"];
			columnAGED_CUM_CURRENT = base.Columns["AGED_CUM_CURRENT"];
			columnAGED_CUM_30 = base.Columns["AGED_CUM_30"];
			columnAGED_CUM_60 = base.Columns["AGED_CUM_60"];
			columnAGED_CUM_90 = base.Columns["AGED_CUM_90"];
			columnFOREIGN_AGED_BALANCE = base.Columns["FOREIGN_AGED_BALANCE"];
			columnFOREIGN_AGED_FUTURE = base.Columns["FOREIGN_AGED_FUTURE"];
			columnFOREIGN_AGED_CURRENT = base.Columns["FOREIGN_AGED_CURRENT"];
			columnFOREIGN_AGED_30 = base.Columns["FOREIGN_AGED_30"];
			columnFOREIGN_AGED_60 = base.Columns["FOREIGN_AGED_60"];
			columnFOREIGN_AGED_90 = base.Columns["FOREIGN_AGED_90"];
			columnFOREIGN_AGED_OLDER = base.Columns["FOREIGN_AGED_OLDER"];
			columnFOREIGN_AGED_CUM_CURRENT = base.Columns["FOREIGN_AGED_CUM_CURRENT"];
			columnFOREIGN_AGED_CUM_30 = base.Columns["FOREIGN_AGED_CUM_30"];
			columnFOREIGN_AGED_CUM_60 = base.Columns["FOREIGN_AGED_CUM_60"];
			columnFOREIGN_AGED_CUM_90 = base.Columns["FOREIGN_AGED_CUM_90"];
			columnSPLIT_NUMBER = base.Columns["SPLIT_NUMBER"];
			columnHEADER_NUMBER = base.Columns["HEADER_NUMBER"];
			columnVAT_FLAG_CODE = base.Columns["VAT_FLAG_CODE"];
			columnDATE_FLAG = base.Columns["DATE_FLAG"];
			columnDATE_ENTERED = base.Columns["DATE_ENTERED"];
			columnVAT_RECONCILED_DATE = base.Columns["VAT_RECONCILED_DATE"];
			columnDISPUTE_CODE = base.Columns["DISPUTE_CODE"];
			columnFUND_ID = base.Columns["FUND_ID"];
			columnVAT_LEDGER_RETURN_ID = base.Columns["VAT_LEDGER_RETURN_ID"];
			columnRECORD_CREATE_DATE = base.Columns["RECORD_CREATE_DATE"];
			columnRECORD_MODIFY_DATE = base.Columns["RECORD_MODIFY_DATE"];
			columnRECORD_DELETED = base.Columns["RECORD_DELETED"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTRAN_NUMBER = new DataColumn("TRAN_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTRAN_NUMBER);
			columnTYPE = new DataColumn("TYPE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTYPE);
			columnDATE = new DataColumn("DATE", typeof(DateTime), null, MappingType.Element);
			columnDATE.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "DATEColumn");
			columnDATE.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnDATE");
			columnDATE.ExtendedProperties.Add("Generator_UserColumnName", "DATE");
			base.Columns.Add(columnDATE);
			columnACCOUNT_REF = new DataColumn("ACCOUNT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_REF);
			columnNOMINAL_CODE = new DataColumn("NOMINAL_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOMINAL_CODE);
			columnBANK_CODE = new DataColumn("BANK_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_CODE);
			columnINV_REF = new DataColumn("INV_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnINV_REF);
			columnUSER_NAME = new DataColumn("USER_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUSER_NAME);
			columnDETAILS = new DataColumn("DETAILS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDETAILS);
			columnEXTRA_REF = new DataColumn("EXTRA_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnEXTRA_REF);
			columnDISPUTED = new DataColumn("DISPUTED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDISPUTED);
			columnSTMT_TEXT = new DataColumn("STMT_TEXT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTMT_TEXT);
			columnBANK_FLAG = new DataColumn("BANK_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_FLAG);
			columnVAT_FLAG = new DataColumn("VAT_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVAT_FLAG);
			columnPAID_FLAG = new DataColumn("PAID_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPAID_FLAG);
			columnPAID_STATUS = new DataColumn("PAID_STATUS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPAID_STATUS);
			columnDEPT_NUMBER = new DataColumn("DEPT_NUMBER", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NUMBER);
			columnDEPT_NAME = new DataColumn("DEPT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NAME);
			columnTAX_CODE = new DataColumn("TAX_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAX_CODE);
			columnDELETED_FLAG = new DataColumn("DELETED_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDELETED_FLAG);
			columnNET_AMOUNT = new DataColumn("NET_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnNET_AMOUNT);
			columnTAX_AMOUNT = new DataColumn("TAX_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTAX_AMOUNT);
			columnGROSS_AMOUNT = new DataColumn("GROSS_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnGROSS_AMOUNT);
			columnAMOUNT_PAID = new DataColumn("AMOUNT_PAID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAMOUNT_PAID);
			columnPAYMENT = new DataColumn("PAYMENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT);
			columnOUTSTANDING = new DataColumn("OUTSTANDING", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnOUTSTANDING);
			columnFOREIGN_NET_AMOUNT = new DataColumn("FOREIGN_NET_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_NET_AMOUNT);
			columnFOREIGN_TAX_AMOUNT = new DataColumn("FOREIGN_TAX_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_TAX_AMOUNT);
			columnFOREIGN_GROSS_AMOUNT = new DataColumn("FOREIGN_GROSS_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_GROSS_AMOUNT);
			columnFOREIGN_AMOUNT_PAID = new DataColumn("FOREIGN_AMOUNT_PAID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AMOUNT_PAID);
			columnAGED_BALANCE = new DataColumn("AGED_BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_BALANCE);
			columnAGED_FUTURE = new DataColumn("AGED_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_FUTURE);
			columnAGED_CURRENT = new DataColumn("AGED_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CURRENT);
			columnAGED_30 = new DataColumn("AGED_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_30);
			columnAGED_60 = new DataColumn("AGED_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_60);
			columnAGED_90 = new DataColumn("AGED_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_90);
			columnAGED_OLDER = new DataColumn("AGED_OLDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_OLDER);
			columnAGED_CUM_CURRENT = new DataColumn("AGED_CUM_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_CURRENT);
			columnAGED_CUM_30 = new DataColumn("AGED_CUM_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_30);
			columnAGED_CUM_60 = new DataColumn("AGED_CUM_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_60);
			columnAGED_CUM_90 = new DataColumn("AGED_CUM_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_90);
			columnFOREIGN_AGED_BALANCE = new DataColumn("FOREIGN_AGED_BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_BALANCE);
			columnFOREIGN_AGED_FUTURE = new DataColumn("FOREIGN_AGED_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_FUTURE);
			columnFOREIGN_AGED_CURRENT = new DataColumn("FOREIGN_AGED_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CURRENT);
			columnFOREIGN_AGED_30 = new DataColumn("FOREIGN_AGED_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_30);
			columnFOREIGN_AGED_60 = new DataColumn("FOREIGN_AGED_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_60);
			columnFOREIGN_AGED_90 = new DataColumn("FOREIGN_AGED_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_90);
			columnFOREIGN_AGED_OLDER = new DataColumn("FOREIGN_AGED_OLDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_OLDER);
			columnFOREIGN_AGED_CUM_CURRENT = new DataColumn("FOREIGN_AGED_CUM_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_CURRENT);
			columnFOREIGN_AGED_CUM_30 = new DataColumn("FOREIGN_AGED_CUM_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_30);
			columnFOREIGN_AGED_CUM_60 = new DataColumn("FOREIGN_AGED_CUM_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_60);
			columnFOREIGN_AGED_CUM_90 = new DataColumn("FOREIGN_AGED_CUM_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_90);
			columnSPLIT_NUMBER = new DataColumn("SPLIT_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSPLIT_NUMBER);
			columnHEADER_NUMBER = new DataColumn("HEADER_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnHEADER_NUMBER);
			columnVAT_FLAG_CODE = new DataColumn("VAT_FLAG_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnVAT_FLAG_CODE);
			columnDATE_FLAG = new DataColumn("DATE_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDATE_FLAG);
			columnDATE_ENTERED = new DataColumn("DATE_ENTERED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_ENTERED);
			columnVAT_RECONCILED_DATE = new DataColumn("VAT_RECONCILED_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnVAT_RECONCILED_DATE);
			columnDISPUTE_CODE = new DataColumn("DISPUTE_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDISPUTE_CODE);
			columnFUND_ID = new DataColumn("FUND_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnFUND_ID);
			columnVAT_LEDGER_RETURN_ID = new DataColumn("VAT_LEDGER_RETURN_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnVAT_LEDGER_RETURN_ID);
			columnRECORD_CREATE_DATE = new DataColumn("RECORD_CREATE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_CREATE_DATE);
			columnRECORD_MODIFY_DATE = new DataColumn("RECORD_MODIFY_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_MODIFY_DATE);
			columnRECORD_DELETED = new DataColumn("RECORD_DELETED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRECORD_DELETED);
			columnTYPE.MaxLength = 2;
			columnACCOUNT_REF.MaxLength = 8;
			columnNOMINAL_CODE.MaxLength = 8;
			columnBANK_CODE.MaxLength = 8;
			columnINV_REF.MaxLength = 30;
			columnUSER_NAME.MaxLength = 32;
			columnDETAILS.MaxLength = 60;
			columnEXTRA_REF.MaxLength = 60;
			columnSTMT_TEXT.MaxLength = 60;
			columnBANK_FLAG.MaxLength = 1;
			columnVAT_FLAG.MaxLength = 1;
			columnPAID_FLAG.MaxLength = 1;
			columnPAID_STATUS.MaxLength = 2;
			columnDEPT_NAME.MaxLength = 60;
			columnTAX_CODE.MaxLength = 3;
			columnVAT_FLAG_CODE.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITRow NewAUDIT_SPLITRow()
		{
			return (AUDIT_SPLITRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new AUDIT_SPLITRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(AUDIT_SPLITRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (AUDIT_SPLITRowChanged != null)
			{
				AUDIT_SPLITRowChanged?.Invoke(this, new AUDIT_SPLITRowChangeEvent((AUDIT_SPLITRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (AUDIT_SPLITRowChanging != null)
			{
				AUDIT_SPLITRowChanging?.Invoke(this, new AUDIT_SPLITRowChangeEvent((AUDIT_SPLITRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (AUDIT_SPLITRowDeleted != null)
			{
				AUDIT_SPLITRowDeleted?.Invoke(this, new AUDIT_SPLITRowChangeEvent((AUDIT_SPLITRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (AUDIT_SPLITRowDeleting != null)
			{
				AUDIT_SPLITRowDeleting?.Invoke(this, new AUDIT_SPLITRowChangeEvent((AUDIT_SPLITRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveAUDIT_SPLITRow(AUDIT_SPLITRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Transactions transactions = new Transactions();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = transactions.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "AUDIT_SPLITDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = transactions.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema obj = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						obj.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class AUDIT_HEADERDataTable : TypedTableBase<AUDIT_HEADERRow>
	{
		private DataColumn columnTRAN_NUMBER;

		private DataColumn columnITEM_COUNT;

		private DataColumn columnTYPE;

		private DataColumn columnDATE;

		private DataColumn columnACCOUNT_REF;

		private DataColumn columnSALES_PURCHASE_REF;

		private DataColumn columnBANK_CODE;

		private DataColumn columnBANK_NAME;

		private DataColumn columnINV_REF;

		private DataColumn columnINV_REF_NUMERIC;

		private DataColumn columnUSER_NAME;

		private DataColumn columnDETAILS;

		private DataColumn columnDUE_DATE;

		private DataColumn columnLAST_CHARGE_DATE;

		private DataColumn columnFINANCE_CHARGE;

		private DataColumn columnINTEREST_RATE;

		private DataColumn columnELECTRONIC_TRANS;

		private DataColumn columnDISPUTED;

		private DataColumn columnPAID_FLAG;

		private DataColumn columnPAID_STATUS;

		private DataColumn columnDELETED_FLAG;

		private DataColumn columnDATE_FLAG;

		private DataColumn columnDATE_BF;

		private DataColumn columnDATE_FROM;

		private DataColumn columnDATE_TO;

		private DataColumn columnNET_AMOUNT;

		private DataColumn columnTAX_AMOUNT;

		private DataColumn columnGROSS_AMOUNT;

		private DataColumn columnBANK_AMOUNT;

		private DataColumn columnAMOUNT_PAID;

		private DataColumn columnPAYMENT;

		private DataColumn columnOUTSTANDING;

		private DataColumn columnFOREIGN_NET_AMOUNT;

		private DataColumn columnFOREIGN_TAX_AMOUNT;

		private DataColumn columnFOREIGN_GROSS_AMOUNT;

		private DataColumn columnFOREIGN_AMOUNT_PAID;

		private DataColumn columnFOREIGN_BANK_AMOUNT;

		private DataColumn columnCURRENCY;

		private DataColumn columnCURRENCY_TYPE;

		private DataColumn columnEURO_GROSS;

		private DataColumn columnEURO_RATE;

		private DataColumn columnFOREIGN_RATE;

		private DataColumn columnAGED_BALANCE;

		private DataColumn columnAGED_FUTURE;

		private DataColumn columnAGED_CURRENT;

		private DataColumn columnAGED_30;

		private DataColumn columnAGED_60;

		private DataColumn columnAGED_90;

		private DataColumn columnAGED_OLDER;

		private DataColumn columnAGED_CUM_CURRENT;

		private DataColumn columnAGED_CUM_30;

		private DataColumn columnAGED_CUM_60;

		private DataColumn columnAGED_CUM_90;

		private DataColumn columnFOREIGN_AGED_BALANCE;

		private DataColumn columnFOREIGN_AGED_FUTURE;

		private DataColumn columnFOREIGN_AGED_CURRENT;

		private DataColumn columnFOREIGN_AGED_30;

		private DataColumn columnFOREIGN_AGED_60;

		private DataColumn columnFOREIGN_AGED_90;

		private DataColumn columnFOREIGN_AGED_OLDER;

		private DataColumn columnFOREIGN_AGED_CUM_CURRENT;

		private DataColumn columnFOREIGN_AGED_CUM_30;

		private DataColumn columnFOREIGN_AGED_CUM_60;

		private DataColumn columnFOREIGN_AGED_CUM_90;

		private DataColumn columnBANK_FLAG;

		private DataColumn columnHEADER_NUMBER;

		private DataColumn columnDATE_ENTERED;

		private DataColumn columnDATE_BANK_RECONCILED;

		private DataColumn columnCIS_RECONCILED;

		private DataColumn columnSPS_REF;

		private DataColumn columnDEPOSIT_DATE;

		private DataColumn columnDEPOSIT_FLAG;

		private DataColumn columnRECURRING_ENTRY_ID;

		private DataColumn columnRECORD_CREATE_DATE;

		private DataColumn columnRECORD_MODIFY_DATE;

		private DataColumn columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TRAN_NUMBERColumn => columnTRAN_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ITEM_COUNTColumn => columnITEM_COUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TYPEColumn => columnTYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATEColumn => columnDATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_REFColumn => columnACCOUNT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_PURCHASE_REFColumn => columnSALES_PURCHASE_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_CODEColumn => columnBANK_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_NAMEColumn => columnBANK_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INV_REFColumn => columnINV_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INV_REF_NUMERICColumn => columnINV_REF_NUMERIC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn USER_NAMEColumn => columnUSER_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DETAILSColumn => columnDETAILS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DUE_DATEColumn => columnDUE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_CHARGE_DATEColumn => columnLAST_CHARGE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FINANCE_CHARGEColumn => columnFINANCE_CHARGE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INTEREST_RATEColumn => columnINTEREST_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ELECTRONIC_TRANSColumn => columnELECTRONIC_TRANS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISPUTEDColumn => columnDISPUTED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAID_FLAGColumn => columnPAID_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAID_STATUSColumn => columnPAID_STATUS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DELETED_FLAGColumn => columnDELETED_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_FLAGColumn => columnDATE_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_BFColumn => columnDATE_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_FROMColumn => columnDATE_FROM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_TOColumn => columnDATE_TO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NET_AMOUNTColumn => columnNET_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_AMOUNTColumn => columnTAX_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn GROSS_AMOUNTColumn => columnGROSS_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_AMOUNTColumn => columnBANK_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AMOUNT_PAIDColumn => columnAMOUNT_PAID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENTColumn => columnPAYMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OUTSTANDINGColumn => columnOUTSTANDING;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_NET_AMOUNTColumn => columnFOREIGN_NET_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_TAX_AMOUNTColumn => columnFOREIGN_TAX_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_GROSS_AMOUNTColumn => columnFOREIGN_GROSS_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AMOUNT_PAIDColumn => columnFOREIGN_AMOUNT_PAID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_BANK_AMOUNTColumn => columnFOREIGN_BANK_AMOUNT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CURRENCYColumn => columnCURRENCY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CURRENCY_TYPEColumn => columnCURRENCY_TYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_GROSSColumn => columnEURO_GROSS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_RATEColumn => columnEURO_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_RATEColumn => columnFOREIGN_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_BALANCEColumn => columnAGED_BALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_FUTUREColumn => columnAGED_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CURRENTColumn => columnAGED_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_30Column => columnAGED_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_60Column => columnAGED_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_90Column => columnAGED_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_OLDERColumn => columnAGED_OLDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_CURRENTColumn => columnAGED_CUM_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_30Column => columnAGED_CUM_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_60Column => columnAGED_CUM_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AGED_CUM_90Column => columnAGED_CUM_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_BALANCEColumn => columnFOREIGN_AGED_BALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_FUTUREColumn => columnFOREIGN_AGED_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CURRENTColumn => columnFOREIGN_AGED_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_30Column => columnFOREIGN_AGED_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_60Column => columnFOREIGN_AGED_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_90Column => columnFOREIGN_AGED_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_OLDERColumn => columnFOREIGN_AGED_OLDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_CURRENTColumn => columnFOREIGN_AGED_CUM_CURRENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_30Column => columnFOREIGN_AGED_CUM_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_60Column => columnFOREIGN_AGED_CUM_60;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FOREIGN_AGED_CUM_90Column => columnFOREIGN_AGED_CUM_90;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_FLAGColumn => columnBANK_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HEADER_NUMBERColumn => columnHEADER_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_ENTEREDColumn => columnDATE_ENTERED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_BANK_RECONCILEDColumn => columnDATE_BANK_RECONCILED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CIS_RECONCILEDColumn => columnCIS_RECONCILED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SPS_REFColumn => columnSPS_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPOSIT_DATEColumn => columnDEPOSIT_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPOSIT_FLAGColumn => columnDEPOSIT_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECURRING_ENTRY_IDColumn => columnRECURRING_ENTRY_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_CREATE_DATEColumn => columnRECORD_CREATE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_MODIFY_DATEColumn => columnRECORD_MODIFY_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RECORD_DELETEDColumn => columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERRow this[int index] => (AUDIT_HEADERRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_HEADERRowChangeEventHandler AUDIT_HEADERRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_HEADERRowChangeEventHandler AUDIT_HEADERRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_HEADERRowChangeEventHandler AUDIT_HEADERRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event AUDIT_HEADERRowChangeEventHandler AUDIT_HEADERRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERDataTable()
		{
			base.TableName = "AUDIT_HEADER";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal AUDIT_HEADERDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
			{
				base.Locale = table.Locale;
			}
			if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected AUDIT_HEADERDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddAUDIT_HEADERRow(AUDIT_HEADERRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERRow AddAUDIT_HEADERRow(int TRAN_NUMBER, int ITEM_COUNT, string TYPE, DateTime _DATE, string ACCOUNT_REF, string SALES_PURCHASE_REF, string BANK_CODE, string BANK_NAME, string INV_REF, int INV_REF_NUMERIC, string USER_NAME, string DETAILS, DateTime DUE_DATE, DateTime LAST_CHARGE_DATE, short FINANCE_CHARGE, double INTEREST_RATE, short ELECTRONIC_TRANS, short DISPUTED, string PAID_FLAG, string PAID_STATUS, short DELETED_FLAG, short DATE_FLAG, DateTime DATE_BF, DateTime DATE_FROM, DateTime DATE_TO, double NET_AMOUNT, double TAX_AMOUNT, double GROSS_AMOUNT, double BANK_AMOUNT, double AMOUNT_PAID, double PAYMENT, double OUTSTANDING, double FOREIGN_NET_AMOUNT, double FOREIGN_TAX_AMOUNT, double FOREIGN_GROSS_AMOUNT, double FOREIGN_AMOUNT_PAID, double FOREIGN_BANK_AMOUNT, short CURRENCY, short CURRENCY_TYPE, double EURO_GROSS, double EURO_RATE, double FOREIGN_RATE, double AGED_BALANCE, double AGED_FUTURE, double AGED_CURRENT, double AGED_30, double AGED_60, double AGED_90, double AGED_OLDER, double AGED_CUM_CURRENT, double AGED_CUM_30, double AGED_CUM_60, double AGED_CUM_90, double FOREIGN_AGED_BALANCE, double FOREIGN_AGED_FUTURE, double FOREIGN_AGED_CURRENT, double FOREIGN_AGED_30, double FOREIGN_AGED_60, double FOREIGN_AGED_90, double FOREIGN_AGED_OLDER, double FOREIGN_AGED_CUM_CURRENT, double FOREIGN_AGED_CUM_30, double FOREIGN_AGED_CUM_60, double FOREIGN_AGED_CUM_90, string BANK_FLAG, int HEADER_NUMBER, DateTime DATE_ENTERED, DateTime DATE_BANK_RECONCILED, short CIS_RECONCILED, string SPS_REF, DateTime DEPOSIT_DATE, string DEPOSIT_FLAG, int RECURRING_ENTRY_ID, DateTime RECORD_CREATE_DATE, DateTime RECORD_MODIFY_DATE, short RECORD_DELETED)
		{
			AUDIT_HEADERRow aUDIT_HEADERRow = (AUDIT_HEADERRow)NewRow();
			object[] itemArray = new object[76]
			{
				TRAN_NUMBER, ITEM_COUNT, TYPE, _DATE, ACCOUNT_REF, SALES_PURCHASE_REF, BANK_CODE, BANK_NAME, INV_REF, INV_REF_NUMERIC,
				USER_NAME, DETAILS, DUE_DATE, LAST_CHARGE_DATE, FINANCE_CHARGE, INTEREST_RATE, ELECTRONIC_TRANS, DISPUTED, PAID_FLAG, PAID_STATUS,
				DELETED_FLAG, DATE_FLAG, DATE_BF, DATE_FROM, DATE_TO, NET_AMOUNT, TAX_AMOUNT, GROSS_AMOUNT, BANK_AMOUNT, AMOUNT_PAID,
				PAYMENT, OUTSTANDING, FOREIGN_NET_AMOUNT, FOREIGN_TAX_AMOUNT, FOREIGN_GROSS_AMOUNT, FOREIGN_AMOUNT_PAID, FOREIGN_BANK_AMOUNT, CURRENCY, CURRENCY_TYPE, EURO_GROSS,
				EURO_RATE, FOREIGN_RATE, AGED_BALANCE, AGED_FUTURE, AGED_CURRENT, AGED_30, AGED_60, AGED_90, AGED_OLDER, AGED_CUM_CURRENT,
				AGED_CUM_30, AGED_CUM_60, AGED_CUM_90, FOREIGN_AGED_BALANCE, FOREIGN_AGED_FUTURE, FOREIGN_AGED_CURRENT, FOREIGN_AGED_30, FOREIGN_AGED_60, FOREIGN_AGED_90, FOREIGN_AGED_OLDER,
				FOREIGN_AGED_CUM_CURRENT, FOREIGN_AGED_CUM_30, FOREIGN_AGED_CUM_60, FOREIGN_AGED_CUM_90, BANK_FLAG, HEADER_NUMBER, DATE_ENTERED, DATE_BANK_RECONCILED, CIS_RECONCILED, SPS_REF,
				DEPOSIT_DATE, DEPOSIT_FLAG, RECURRING_ENTRY_ID, RECORD_CREATE_DATE, RECORD_MODIFY_DATE, RECORD_DELETED
			};
			aUDIT_HEADERRow.ItemArray = itemArray;
			base.Rows.Add(aUDIT_HEADERRow);
			return aUDIT_HEADERRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			AUDIT_HEADERDataTable obj = (AUDIT_HEADERDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new AUDIT_HEADERDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnTRAN_NUMBER = base.Columns["TRAN_NUMBER"];
			columnITEM_COUNT = base.Columns["ITEM_COUNT"];
			columnTYPE = base.Columns["TYPE"];
			columnDATE = base.Columns["DATE"];
			columnACCOUNT_REF = base.Columns["ACCOUNT_REF"];
			columnSALES_PURCHASE_REF = base.Columns["SALES_PURCHASE_REF"];
			columnBANK_CODE = base.Columns["BANK_CODE"];
			columnBANK_NAME = base.Columns["BANK_NAME"];
			columnINV_REF = base.Columns["INV_REF"];
			columnINV_REF_NUMERIC = base.Columns["INV_REF_NUMERIC"];
			columnUSER_NAME = base.Columns["USER_NAME"];
			columnDETAILS = base.Columns["DETAILS"];
			columnDUE_DATE = base.Columns["DUE_DATE"];
			columnLAST_CHARGE_DATE = base.Columns["LAST_CHARGE_DATE"];
			columnFINANCE_CHARGE = base.Columns["FINANCE_CHARGE"];
			columnINTEREST_RATE = base.Columns["INTEREST_RATE"];
			columnELECTRONIC_TRANS = base.Columns["ELECTRONIC_TRANS"];
			columnDISPUTED = base.Columns["DISPUTED"];
			columnPAID_FLAG = base.Columns["PAID_FLAG"];
			columnPAID_STATUS = base.Columns["PAID_STATUS"];
			columnDELETED_FLAG = base.Columns["DELETED_FLAG"];
			columnDATE_FLAG = base.Columns["DATE_FLAG"];
			columnDATE_BF = base.Columns["DATE_BF"];
			columnDATE_FROM = base.Columns["DATE_FROM"];
			columnDATE_TO = base.Columns["DATE_TO"];
			columnNET_AMOUNT = base.Columns["NET_AMOUNT"];
			columnTAX_AMOUNT = base.Columns["TAX_AMOUNT"];
			columnGROSS_AMOUNT = base.Columns["GROSS_AMOUNT"];
			columnBANK_AMOUNT = base.Columns["BANK_AMOUNT"];
			columnAMOUNT_PAID = base.Columns["AMOUNT_PAID"];
			columnPAYMENT = base.Columns["PAYMENT"];
			columnOUTSTANDING = base.Columns["OUTSTANDING"];
			columnFOREIGN_NET_AMOUNT = base.Columns["FOREIGN_NET_AMOUNT"];
			columnFOREIGN_TAX_AMOUNT = base.Columns["FOREIGN_TAX_AMOUNT"];
			columnFOREIGN_GROSS_AMOUNT = base.Columns["FOREIGN_GROSS_AMOUNT"];
			columnFOREIGN_AMOUNT_PAID = base.Columns["FOREIGN_AMOUNT_PAID"];
			columnFOREIGN_BANK_AMOUNT = base.Columns["FOREIGN_BANK_AMOUNT"];
			columnCURRENCY = base.Columns["CURRENCY"];
			columnCURRENCY_TYPE = base.Columns["CURRENCY_TYPE"];
			columnEURO_GROSS = base.Columns["EURO_GROSS"];
			columnEURO_RATE = base.Columns["EURO_RATE"];
			columnFOREIGN_RATE = base.Columns["FOREIGN_RATE"];
			columnAGED_BALANCE = base.Columns["AGED_BALANCE"];
			columnAGED_FUTURE = base.Columns["AGED_FUTURE"];
			columnAGED_CURRENT = base.Columns["AGED_CURRENT"];
			columnAGED_30 = base.Columns["AGED_30"];
			columnAGED_60 = base.Columns["AGED_60"];
			columnAGED_90 = base.Columns["AGED_90"];
			columnAGED_OLDER = base.Columns["AGED_OLDER"];
			columnAGED_CUM_CURRENT = base.Columns["AGED_CUM_CURRENT"];
			columnAGED_CUM_30 = base.Columns["AGED_CUM_30"];
			columnAGED_CUM_60 = base.Columns["AGED_CUM_60"];
			columnAGED_CUM_90 = base.Columns["AGED_CUM_90"];
			columnFOREIGN_AGED_BALANCE = base.Columns["FOREIGN_AGED_BALANCE"];
			columnFOREIGN_AGED_FUTURE = base.Columns["FOREIGN_AGED_FUTURE"];
			columnFOREIGN_AGED_CURRENT = base.Columns["FOREIGN_AGED_CURRENT"];
			columnFOREIGN_AGED_30 = base.Columns["FOREIGN_AGED_30"];
			columnFOREIGN_AGED_60 = base.Columns["FOREIGN_AGED_60"];
			columnFOREIGN_AGED_90 = base.Columns["FOREIGN_AGED_90"];
			columnFOREIGN_AGED_OLDER = base.Columns["FOREIGN_AGED_OLDER"];
			columnFOREIGN_AGED_CUM_CURRENT = base.Columns["FOREIGN_AGED_CUM_CURRENT"];
			columnFOREIGN_AGED_CUM_30 = base.Columns["FOREIGN_AGED_CUM_30"];
			columnFOREIGN_AGED_CUM_60 = base.Columns["FOREIGN_AGED_CUM_60"];
			columnFOREIGN_AGED_CUM_90 = base.Columns["FOREIGN_AGED_CUM_90"];
			columnBANK_FLAG = base.Columns["BANK_FLAG"];
			columnHEADER_NUMBER = base.Columns["HEADER_NUMBER"];
			columnDATE_ENTERED = base.Columns["DATE_ENTERED"];
			columnDATE_BANK_RECONCILED = base.Columns["DATE_BANK_RECONCILED"];
			columnCIS_RECONCILED = base.Columns["CIS_RECONCILED"];
			columnSPS_REF = base.Columns["SPS_REF"];
			columnDEPOSIT_DATE = base.Columns["DEPOSIT_DATE"];
			columnDEPOSIT_FLAG = base.Columns["DEPOSIT_FLAG"];
			columnRECURRING_ENTRY_ID = base.Columns["RECURRING_ENTRY_ID"];
			columnRECORD_CREATE_DATE = base.Columns["RECORD_CREATE_DATE"];
			columnRECORD_MODIFY_DATE = base.Columns["RECORD_MODIFY_DATE"];
			columnRECORD_DELETED = base.Columns["RECORD_DELETED"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTRAN_NUMBER = new DataColumn("TRAN_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTRAN_NUMBER);
			columnITEM_COUNT = new DataColumn("ITEM_COUNT", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnITEM_COUNT);
			columnTYPE = new DataColumn("TYPE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTYPE);
			columnDATE = new DataColumn("DATE", typeof(DateTime), null, MappingType.Element);
			columnDATE.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "DATEColumn");
			columnDATE.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "columnDATE");
			columnDATE.ExtendedProperties.Add("Generator_UserColumnName", "DATE");
			base.Columns.Add(columnDATE);
			columnACCOUNT_REF = new DataColumn("ACCOUNT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_REF);
			columnSALES_PURCHASE_REF = new DataColumn("SALES_PURCHASE_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSALES_PURCHASE_REF);
			columnBANK_CODE = new DataColumn("BANK_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_CODE);
			columnBANK_NAME = new DataColumn("BANK_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_NAME);
			columnINV_REF = new DataColumn("INV_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnINV_REF);
			columnINV_REF_NUMERIC = new DataColumn("INV_REF_NUMERIC", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnINV_REF_NUMERIC);
			columnUSER_NAME = new DataColumn("USER_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUSER_NAME);
			columnDETAILS = new DataColumn("DETAILS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDETAILS);
			columnDUE_DATE = new DataColumn("DUE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDUE_DATE);
			columnLAST_CHARGE_DATE = new DataColumn("LAST_CHARGE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLAST_CHARGE_DATE);
			columnFINANCE_CHARGE = new DataColumn("FINANCE_CHARGE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnFINANCE_CHARGE);
			columnINTEREST_RATE = new DataColumn("INTEREST_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINTEREST_RATE);
			columnELECTRONIC_TRANS = new DataColumn("ELECTRONIC_TRANS", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnELECTRONIC_TRANS);
			columnDISPUTED = new DataColumn("DISPUTED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDISPUTED);
			columnPAID_FLAG = new DataColumn("PAID_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPAID_FLAG);
			columnPAID_STATUS = new DataColumn("PAID_STATUS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPAID_STATUS);
			columnDELETED_FLAG = new DataColumn("DELETED_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDELETED_FLAG);
			columnDATE_FLAG = new DataColumn("DATE_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDATE_FLAG);
			columnDATE_BF = new DataColumn("DATE_BF", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_BF);
			columnDATE_FROM = new DataColumn("DATE_FROM", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_FROM);
			columnDATE_TO = new DataColumn("DATE_TO", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_TO);
			columnNET_AMOUNT = new DataColumn("NET_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnNET_AMOUNT);
			columnTAX_AMOUNT = new DataColumn("TAX_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTAX_AMOUNT);
			columnGROSS_AMOUNT = new DataColumn("GROSS_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnGROSS_AMOUNT);
			columnBANK_AMOUNT = new DataColumn("BANK_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBANK_AMOUNT);
			columnAMOUNT_PAID = new DataColumn("AMOUNT_PAID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAMOUNT_PAID);
			columnPAYMENT = new DataColumn("PAYMENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT);
			columnOUTSTANDING = new DataColumn("OUTSTANDING", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnOUTSTANDING);
			columnFOREIGN_NET_AMOUNT = new DataColumn("FOREIGN_NET_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_NET_AMOUNT);
			columnFOREIGN_TAX_AMOUNT = new DataColumn("FOREIGN_TAX_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_TAX_AMOUNT);
			columnFOREIGN_GROSS_AMOUNT = new DataColumn("FOREIGN_GROSS_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_GROSS_AMOUNT);
			columnFOREIGN_AMOUNT_PAID = new DataColumn("FOREIGN_AMOUNT_PAID", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AMOUNT_PAID);
			columnFOREIGN_BANK_AMOUNT = new DataColumn("FOREIGN_BANK_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_BANK_AMOUNT);
			columnCURRENCY = new DataColumn("CURRENCY", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCURRENCY);
			columnCURRENCY_TYPE = new DataColumn("CURRENCY_TYPE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCURRENCY_TYPE);
			columnEURO_GROSS = new DataColumn("EURO_GROSS", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnEURO_GROSS);
			columnEURO_RATE = new DataColumn("EURO_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnEURO_RATE);
			columnFOREIGN_RATE = new DataColumn("FOREIGN_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_RATE);
			columnAGED_BALANCE = new DataColumn("AGED_BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_BALANCE);
			columnAGED_FUTURE = new DataColumn("AGED_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_FUTURE);
			columnAGED_CURRENT = new DataColumn("AGED_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CURRENT);
			columnAGED_30 = new DataColumn("AGED_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_30);
			columnAGED_60 = new DataColumn("AGED_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_60);
			columnAGED_90 = new DataColumn("AGED_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_90);
			columnAGED_OLDER = new DataColumn("AGED_OLDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_OLDER);
			columnAGED_CUM_CURRENT = new DataColumn("AGED_CUM_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_CURRENT);
			columnAGED_CUM_30 = new DataColumn("AGED_CUM_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_30);
			columnAGED_CUM_60 = new DataColumn("AGED_CUM_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_60);
			columnAGED_CUM_90 = new DataColumn("AGED_CUM_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAGED_CUM_90);
			columnFOREIGN_AGED_BALANCE = new DataColumn("FOREIGN_AGED_BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_BALANCE);
			columnFOREIGN_AGED_FUTURE = new DataColumn("FOREIGN_AGED_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_FUTURE);
			columnFOREIGN_AGED_CURRENT = new DataColumn("FOREIGN_AGED_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CURRENT);
			columnFOREIGN_AGED_30 = new DataColumn("FOREIGN_AGED_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_30);
			columnFOREIGN_AGED_60 = new DataColumn("FOREIGN_AGED_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_60);
			columnFOREIGN_AGED_90 = new DataColumn("FOREIGN_AGED_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_90);
			columnFOREIGN_AGED_OLDER = new DataColumn("FOREIGN_AGED_OLDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_OLDER);
			columnFOREIGN_AGED_CUM_CURRENT = new DataColumn("FOREIGN_AGED_CUM_CURRENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_CURRENT);
			columnFOREIGN_AGED_CUM_30 = new DataColumn("FOREIGN_AGED_CUM_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_30);
			columnFOREIGN_AGED_CUM_60 = new DataColumn("FOREIGN_AGED_CUM_60", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_60);
			columnFOREIGN_AGED_CUM_90 = new DataColumn("FOREIGN_AGED_CUM_90", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnFOREIGN_AGED_CUM_90);
			columnBANK_FLAG = new DataColumn("BANK_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_FLAG);
			columnHEADER_NUMBER = new DataColumn("HEADER_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnHEADER_NUMBER);
			columnDATE_ENTERED = new DataColumn("DATE_ENTERED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_ENTERED);
			columnDATE_BANK_RECONCILED = new DataColumn("DATE_BANK_RECONCILED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_BANK_RECONCILED);
			columnCIS_RECONCILED = new DataColumn("CIS_RECONCILED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCIS_RECONCILED);
			columnSPS_REF = new DataColumn("SPS_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSPS_REF);
			columnDEPOSIT_DATE = new DataColumn("DEPOSIT_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDEPOSIT_DATE);
			columnDEPOSIT_FLAG = new DataColumn("DEPOSIT_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEPOSIT_FLAG);
			columnRECURRING_ENTRY_ID = new DataColumn("RECURRING_ENTRY_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnRECURRING_ENTRY_ID);
			columnRECORD_CREATE_DATE = new DataColumn("RECORD_CREATE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_CREATE_DATE);
			columnRECORD_MODIFY_DATE = new DataColumn("RECORD_MODIFY_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_MODIFY_DATE);
			columnRECORD_DELETED = new DataColumn("RECORD_DELETED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRECORD_DELETED);
			columnTYPE.MaxLength = 2;
			columnACCOUNT_REF.MaxLength = 8;
			columnSALES_PURCHASE_REF.MaxLength = 8;
			columnBANK_CODE.MaxLength = 8;
			columnBANK_NAME.MaxLength = 60;
			columnINV_REF.MaxLength = 30;
			columnUSER_NAME.MaxLength = 32;
			columnDETAILS.MaxLength = 60;
			columnFINANCE_CHARGE.AllowDBNull = false;
			columnPAID_FLAG.MaxLength = 1;
			columnPAID_STATUS.MaxLength = 2;
			columnCURRENCY.AllowDBNull = false;
			columnCURRENCY_TYPE.AllowDBNull = false;
			columnBANK_FLAG.MaxLength = 1;
			columnSPS_REF.MaxLength = 40;
			columnDEPOSIT_FLAG.MaxLength = 1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERRow NewAUDIT_HEADERRow()
		{
			return (AUDIT_HEADERRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new AUDIT_HEADERRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(AUDIT_HEADERRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (AUDIT_HEADERRowChanged != null)
			{
				AUDIT_HEADERRowChanged?.Invoke(this, new AUDIT_HEADERRowChangeEvent((AUDIT_HEADERRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (AUDIT_HEADERRowChanging != null)
			{
				AUDIT_HEADERRowChanging?.Invoke(this, new AUDIT_HEADERRowChangeEvent((AUDIT_HEADERRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (AUDIT_HEADERRowDeleted != null)
			{
				AUDIT_HEADERRowDeleted?.Invoke(this, new AUDIT_HEADERRowChangeEvent((AUDIT_HEADERRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (AUDIT_HEADERRowDeleting != null)
			{
				AUDIT_HEADERRowDeleting?.Invoke(this, new AUDIT_HEADERRowChangeEvent((AUDIT_HEADERRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveAUDIT_HEADERRow(AUDIT_HEADERRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Transactions transactions = new Transactions();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = transactions.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "AUDIT_HEADERDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = transactions.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						XmlSchema obj = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						obj.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class AUDIT_SPLITRow : DataRow
	{
		private AUDIT_SPLITDataTable tableAUDIT_SPLIT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TRAN_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_SPLIT.TRAN_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TRAN_NUMBER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.TRAN_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TYPE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.TYPEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TYPE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.TYPEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime _DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_SPLIT.DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ACCOUNT_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.ACCOUNT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCOUNT_REF' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.ACCOUNT_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NOMINAL_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.NOMINAL_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NOMINAL_CODE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.NOMINAL_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.BANK_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_CODE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.BANK_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string INV_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.INV_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INV_REF' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.INV_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string USER_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.USER_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'USER_NAME' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.USER_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DETAILS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.DETAILSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DETAILS' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DETAILSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string EXTRA_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.EXTRA_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'EXTRA_REF' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.EXTRA_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DISPUTED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.DISPUTEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISPUTED' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DISPUTEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string STMT_TEXT
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.STMT_TEXTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STMT_TEXT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.STMT_TEXTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.BANK_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_FLAG' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.BANK_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string VAT_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.VAT_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_FLAG' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.VAT_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PAID_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.PAID_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAID_FLAG' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.PAID_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PAID_STATUS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.PAID_STATUSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAID_STATUS' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.PAID_STATUSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DEPT_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.DEPT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NUMBER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DEPT_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEPT_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.DEPT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NAME' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DEPT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TAX_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_SPLIT.TAX_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_CODE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.TAX_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DELETED_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.DELETED_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DELETED_FLAG' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DELETED_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double NET_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.NET_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NET_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.NET_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TAX_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.TAX_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.TAX_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double GROSS_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.GROSS_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'GROSS_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.GROSS_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AMOUNT_PAID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AMOUNT_PAIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AMOUNT_PAID' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AMOUNT_PAIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.PAYMENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.PAYMENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double OUTSTANDING
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.OUTSTANDINGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'OUTSTANDING' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.OUTSTANDINGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_NET_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_NET_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_NET_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_NET_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_TAX_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_TAX_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_TAX_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_TAX_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_GROSS_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_GROSS_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_GROSS_AMOUNT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_GROSS_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AMOUNT_PAID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AMOUNT_PAIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AMOUNT_PAID' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AMOUNT_PAIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_BALANCE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_BALANCE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_FUTURE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CURRENT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_30' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_60' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_90' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_OLDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_OLDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_OLDER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_OLDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_CUM_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_CURRENT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_CUM_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_CUM_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_30' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_CUM_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_CUM_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_60' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_CUM_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.AGED_CUM_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_90' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.AGED_CUM_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_BALANCE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_BALANCE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_FUTURE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CURRENT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_30' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_60' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_90' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_OLDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_OLDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_OLDER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_OLDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_CURRENT' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_30' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_60' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_90' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int SPLIT_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_SPLIT.SPLIT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SPLIT_NUMBER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.SPLIT_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int HEADER_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_SPLIT.HEADER_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'HEADER_NUMBER' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.HEADER_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short VAT_FLAG_CODE
		{
			get
			{
				return Conversions.ToShort(base[tableAUDIT_SPLIT.VAT_FLAG_CODEColumn]);
			}
			set
			{
				base[tableAUDIT_SPLIT.VAT_FLAG_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DATE_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.DATE_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_FLAG' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DATE_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_ENTERED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_SPLIT.DATE_ENTEREDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_ENTERED' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DATE_ENTEREDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime VAT_RECONCILED_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_SPLIT.VAT_RECONCILED_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_RECONCILED_DATE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.VAT_RECONCILED_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DISPUTE_CODE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.DISPUTE_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISPUTE_CODE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.DISPUTE_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int FUND_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_SPLIT.FUND_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FUND_ID' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.FUND_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int VAT_LEDGER_RETURN_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_SPLIT.VAT_LEDGER_RETURN_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_LEDGER_RETURN_ID' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.VAT_LEDGER_RETURN_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime RECORD_CREATE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_SPLIT.RECORD_CREATE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_CREATE_DATE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.RECORD_CREATE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime RECORD_MODIFY_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_SPLIT.RECORD_MODIFY_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_MODIFY_DATE' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.RECORD_MODIFY_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short RECORD_DELETED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_SPLIT.RECORD_DELETEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_DELETED' in table 'AUDIT_SPLIT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_SPLIT.RECORD_DELETEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal AUDIT_SPLITRow(DataRowBuilder rb)
			: base(rb)
		{
			tableAUDIT_SPLIT = (AUDIT_SPLITDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTRAN_NUMBERNull()
		{
			return IsNull(tableAUDIT_SPLIT.TRAN_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTRAN_NUMBERNull()
		{
			base[tableAUDIT_SPLIT.TRAN_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTYPENull()
		{
			return IsNull(tableAUDIT_SPLIT.TYPEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTYPENull()
		{
			base[tableAUDIT_SPLIT.TYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Is_DATENull()
		{
			return IsNull(tableAUDIT_SPLIT.DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Set_DATENull()
		{
			base[tableAUDIT_SPLIT.DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCOUNT_REFNull()
		{
			return IsNull(tableAUDIT_SPLIT.ACCOUNT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCOUNT_REFNull()
		{
			base[tableAUDIT_SPLIT.ACCOUNT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNOMINAL_CODENull()
		{
			return IsNull(tableAUDIT_SPLIT.NOMINAL_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNOMINAL_CODENull()
		{
			base[tableAUDIT_SPLIT.NOMINAL_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_CODENull()
		{
			return IsNull(tableAUDIT_SPLIT.BANK_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_CODENull()
		{
			base[tableAUDIT_SPLIT.BANK_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINV_REFNull()
		{
			return IsNull(tableAUDIT_SPLIT.INV_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINV_REFNull()
		{
			base[tableAUDIT_SPLIT.INV_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUSER_NAMENull()
		{
			return IsNull(tableAUDIT_SPLIT.USER_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUSER_NAMENull()
		{
			base[tableAUDIT_SPLIT.USER_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDETAILSNull()
		{
			return IsNull(tableAUDIT_SPLIT.DETAILSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDETAILSNull()
		{
			base[tableAUDIT_SPLIT.DETAILSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEXTRA_REFNull()
		{
			return IsNull(tableAUDIT_SPLIT.EXTRA_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEXTRA_REFNull()
		{
			base[tableAUDIT_SPLIT.EXTRA_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISPUTEDNull()
		{
			return IsNull(tableAUDIT_SPLIT.DISPUTEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISPUTEDNull()
		{
			base[tableAUDIT_SPLIT.DISPUTEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTMT_TEXTNull()
		{
			return IsNull(tableAUDIT_SPLIT.STMT_TEXTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTMT_TEXTNull()
		{
			base[tableAUDIT_SPLIT.STMT_TEXTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_FLAGNull()
		{
			return IsNull(tableAUDIT_SPLIT.BANK_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_FLAGNull()
		{
			base[tableAUDIT_SPLIT.BANK_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_FLAGNull()
		{
			return IsNull(tableAUDIT_SPLIT.VAT_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_FLAGNull()
		{
			base[tableAUDIT_SPLIT.VAT_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAID_FLAGNull()
		{
			return IsNull(tableAUDIT_SPLIT.PAID_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAID_FLAGNull()
		{
			base[tableAUDIT_SPLIT.PAID_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAID_STATUSNull()
		{
			return IsNull(tableAUDIT_SPLIT.PAID_STATUSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAID_STATUSNull()
		{
			base[tableAUDIT_SPLIT.PAID_STATUSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NUMBERNull()
		{
			return IsNull(tableAUDIT_SPLIT.DEPT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NUMBERNull()
		{
			base[tableAUDIT_SPLIT.DEPT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NAMENull()
		{
			return IsNull(tableAUDIT_SPLIT.DEPT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NAMENull()
		{
			base[tableAUDIT_SPLIT.DEPT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_CODENull()
		{
			return IsNull(tableAUDIT_SPLIT.TAX_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_CODENull()
		{
			base[tableAUDIT_SPLIT.TAX_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDELETED_FLAGNull()
		{
			return IsNull(tableAUDIT_SPLIT.DELETED_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDELETED_FLAGNull()
		{
			base[tableAUDIT_SPLIT.DELETED_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNET_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.NET_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNET_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.NET_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.TAX_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.TAX_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGROSS_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.GROSS_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetGROSS_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.GROSS_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAMOUNT_PAIDNull()
		{
			return IsNull(tableAUDIT_SPLIT.AMOUNT_PAIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAMOUNT_PAIDNull()
		{
			base[tableAUDIT_SPLIT.AMOUNT_PAIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENTNull()
		{
			return IsNull(tableAUDIT_SPLIT.PAYMENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENTNull()
		{
			base[tableAUDIT_SPLIT.PAYMENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOUTSTANDINGNull()
		{
			return IsNull(tableAUDIT_SPLIT.OUTSTANDINGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOUTSTANDINGNull()
		{
			base[tableAUDIT_SPLIT.OUTSTANDINGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_NET_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_NET_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_NET_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_NET_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_TAX_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_TAX_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_TAX_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_TAX_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_GROSS_AMOUNTNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_GROSS_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_GROSS_AMOUNTNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_GROSS_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AMOUNT_PAIDNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AMOUNT_PAIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AMOUNT_PAIDNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AMOUNT_PAIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_BALANCENull()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_BALANCENull()
		{
			base[tableAUDIT_SPLIT.AGED_BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_FUTURENull()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_FUTURENull()
		{
			base[tableAUDIT_SPLIT.AGED_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CURRENTNull()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CURRENTNull()
		{
			base[tableAUDIT_SPLIT.AGED_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_30Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_30Null()
		{
			base[tableAUDIT_SPLIT.AGED_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_60Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_60Null()
		{
			base[tableAUDIT_SPLIT.AGED_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_90Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_90Null()
		{
			base[tableAUDIT_SPLIT.AGED_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_OLDERNull()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_OLDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_OLDERNull()
		{
			base[tableAUDIT_SPLIT.AGED_OLDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_CURRENTNull()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_CUM_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_CURRENTNull()
		{
			base[tableAUDIT_SPLIT.AGED_CUM_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_30Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_CUM_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_30Null()
		{
			base[tableAUDIT_SPLIT.AGED_CUM_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_60Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_CUM_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_60Null()
		{
			base[tableAUDIT_SPLIT.AGED_CUM_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_90Null()
		{
			return IsNull(tableAUDIT_SPLIT.AGED_CUM_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_90Null()
		{
			base[tableAUDIT_SPLIT.AGED_CUM_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_BALANCENull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_BALANCENull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_FUTURENull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_FUTURENull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CURRENTNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CURRENTNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_30Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_30Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_60Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_60Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_90Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_90Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_OLDERNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_OLDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_OLDERNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_OLDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_CURRENTNull()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_CUM_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_CURRENTNull()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_30Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_CUM_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_30Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_60Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_CUM_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_60Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_90Null()
		{
			return IsNull(tableAUDIT_SPLIT.FOREIGN_AGED_CUM_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_90Null()
		{
			base[tableAUDIT_SPLIT.FOREIGN_AGED_CUM_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSPLIT_NUMBERNull()
		{
			return IsNull(tableAUDIT_SPLIT.SPLIT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSPLIT_NUMBERNull()
		{
			base[tableAUDIT_SPLIT.SPLIT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHEADER_NUMBERNull()
		{
			return IsNull(tableAUDIT_SPLIT.HEADER_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHEADER_NUMBERNull()
		{
			base[tableAUDIT_SPLIT.HEADER_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_FLAGNull()
		{
			return IsNull(tableAUDIT_SPLIT.DATE_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_FLAGNull()
		{
			base[tableAUDIT_SPLIT.DATE_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_ENTEREDNull()
		{
			return IsNull(tableAUDIT_SPLIT.DATE_ENTEREDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_ENTEREDNull()
		{
			base[tableAUDIT_SPLIT.DATE_ENTEREDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_RECONCILED_DATENull()
		{
			return IsNull(tableAUDIT_SPLIT.VAT_RECONCILED_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_RECONCILED_DATENull()
		{
			base[tableAUDIT_SPLIT.VAT_RECONCILED_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISPUTE_CODENull()
		{
			return IsNull(tableAUDIT_SPLIT.DISPUTE_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISPUTE_CODENull()
		{
			base[tableAUDIT_SPLIT.DISPUTE_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFUND_IDNull()
		{
			return IsNull(tableAUDIT_SPLIT.FUND_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFUND_IDNull()
		{
			base[tableAUDIT_SPLIT.FUND_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_LEDGER_RETURN_IDNull()
		{
			return IsNull(tableAUDIT_SPLIT.VAT_LEDGER_RETURN_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_LEDGER_RETURN_IDNull()
		{
			base[tableAUDIT_SPLIT.VAT_LEDGER_RETURN_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_CREATE_DATENull()
		{
			return IsNull(tableAUDIT_SPLIT.RECORD_CREATE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_CREATE_DATENull()
		{
			base[tableAUDIT_SPLIT.RECORD_CREATE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_MODIFY_DATENull()
		{
			return IsNull(tableAUDIT_SPLIT.RECORD_MODIFY_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_MODIFY_DATENull()
		{
			base[tableAUDIT_SPLIT.RECORD_MODIFY_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_DELETEDNull()
		{
			return IsNull(tableAUDIT_SPLIT.RECORD_DELETEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_DELETEDNull()
		{
			base[tableAUDIT_SPLIT.RECORD_DELETEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class AUDIT_HEADERRow : DataRow
	{
		private AUDIT_HEADERDataTable tableAUDIT_HEADER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TRAN_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_HEADER.TRAN_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TRAN_NUMBER' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.TRAN_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int ITEM_COUNT
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_HEADER.ITEM_COUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ITEM_COUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.ITEM_COUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TYPE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.TYPEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TYPE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.TYPEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime _DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ACCOUNT_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.ACCOUNT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCOUNT_REF' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.ACCOUNT_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SALES_PURCHASE_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.SALES_PURCHASE_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_PURCHASE_REF' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.SALES_PURCHASE_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.BANK_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_CODE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.BANK_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.BANK_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_NAME' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.BANK_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string INV_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.INV_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INV_REF' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.INV_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int INV_REF_NUMERIC
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_HEADER.INV_REF_NUMERICColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INV_REF_NUMERIC' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.INV_REF_NUMERICColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string USER_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.USER_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'USER_NAME' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.USER_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DETAILS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.DETAILSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DETAILS' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DETAILSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DUE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DUE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DUE_DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DUE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime LAST_CHARGE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.LAST_CHARGE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_CHARGE_DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.LAST_CHARGE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short FINANCE_CHARGE
		{
			get
			{
				return Conversions.ToShort(base[tableAUDIT_HEADER.FINANCE_CHARGEColumn]);
			}
			set
			{
				base[tableAUDIT_HEADER.FINANCE_CHARGEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INTEREST_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.INTEREST_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INTEREST_RATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.INTEREST_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short ELECTRONIC_TRANS
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.ELECTRONIC_TRANSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ELECTRONIC_TRANS' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.ELECTRONIC_TRANSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DISPUTED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.DISPUTEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISPUTED' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DISPUTEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PAID_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.PAID_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAID_FLAG' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.PAID_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PAID_STATUS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.PAID_STATUSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAID_STATUS' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.PAID_STATUSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DELETED_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.DELETED_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DELETED_FLAG' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DELETED_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DATE_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.DATE_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_FLAG' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_BF
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATE_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_BF' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_FROM
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATE_FROMColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_FROM' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_FROMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_TO
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATE_TOColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_TO' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_TOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double NET_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.NET_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NET_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.NET_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TAX_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.TAX_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.TAX_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double GROSS_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.GROSS_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'GROSS_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.GROSS_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BANK_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.BANK_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.BANK_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AMOUNT_PAID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AMOUNT_PAIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AMOUNT_PAID' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AMOUNT_PAIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.PAYMENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.PAYMENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double OUTSTANDING
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.OUTSTANDINGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'OUTSTANDING' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.OUTSTANDINGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_NET_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_NET_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_NET_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_NET_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_TAX_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_TAX_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_TAX_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_TAX_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_GROSS_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_GROSS_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_GROSS_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_GROSS_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AMOUNT_PAID
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AMOUNT_PAIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AMOUNT_PAID' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AMOUNT_PAIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_BANK_AMOUNT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_BANK_AMOUNTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_BANK_AMOUNT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_BANK_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CURRENCY
		{
			get
			{
				return Conversions.ToShort(base[tableAUDIT_HEADER.CURRENCYColumn]);
			}
			set
			{
				base[tableAUDIT_HEADER.CURRENCYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CURRENCY_TYPE
		{
			get
			{
				return Conversions.ToShort(base[tableAUDIT_HEADER.CURRENCY_TYPEColumn]);
			}
			set
			{
				base[tableAUDIT_HEADER.CURRENCY_TYPEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double EURO_GROSS
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.EURO_GROSSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'EURO_GROSS' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.EURO_GROSSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double EURO_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.EURO_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'EURO_RATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.EURO_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_RATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_BALANCE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_BALANCE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_FUTURE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CURRENT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_30' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_60' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_90' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_OLDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_OLDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_OLDER' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_OLDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_CUM_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_CURRENT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_CUM_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_CUM_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_30' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_CUM_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_CUM_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_60' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_CUM_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AGED_CUM_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.AGED_CUM_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AGED_CUM_90' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.AGED_CUM_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_BALANCE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_BALANCE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_FUTURE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CURRENT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_30' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_60' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_90' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_OLDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_OLDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_OLDER' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_OLDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_CURRENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_CURRENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_CURRENT' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_CURRENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_30' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_60
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_60Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_60' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_60Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double FOREIGN_AGED_CUM_90
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_90Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FOREIGN_AGED_CUM_90' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_90Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.BANK_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_FLAG' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.BANK_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int HEADER_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_HEADER.HEADER_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'HEADER_NUMBER' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.HEADER_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_ENTERED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATE_ENTEREDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_ENTERED' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_ENTEREDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_BANK_RECONCILED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DATE_BANK_RECONCILEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_BANK_RECONCILED' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DATE_BANK_RECONCILEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CIS_RECONCILED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.CIS_RECONCILEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CIS_RECONCILED' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.CIS_RECONCILEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SPS_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.SPS_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SPS_REF' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.SPS_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DEPOSIT_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.DEPOSIT_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPOSIT_DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DEPOSIT_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEPOSIT_FLAG
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableAUDIT_HEADER.DEPOSIT_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPOSIT_FLAG' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.DEPOSIT_FLAGColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int RECURRING_ENTRY_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableAUDIT_HEADER.RECURRING_ENTRY_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECURRING_ENTRY_ID' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.RECURRING_ENTRY_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime RECORD_CREATE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.RECORD_CREATE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_CREATE_DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.RECORD_CREATE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime RECORD_MODIFY_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableAUDIT_HEADER.RECORD_MODIFY_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_MODIFY_DATE' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.RECORD_MODIFY_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short RECORD_DELETED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableAUDIT_HEADER.RECORD_DELETEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_DELETED' in table 'AUDIT_HEADER' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableAUDIT_HEADER.RECORD_DELETEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal AUDIT_HEADERRow(DataRowBuilder rb)
			: base(rb)
		{
			tableAUDIT_HEADER = (AUDIT_HEADERDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTRAN_NUMBERNull()
		{
			return IsNull(tableAUDIT_HEADER.TRAN_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTRAN_NUMBERNull()
		{
			base[tableAUDIT_HEADER.TRAN_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsITEM_COUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.ITEM_COUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetITEM_COUNTNull()
		{
			base[tableAUDIT_HEADER.ITEM_COUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTYPENull()
		{
			return IsNull(tableAUDIT_HEADER.TYPEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTYPENull()
		{
			base[tableAUDIT_HEADER.TYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Is_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void Set_DATENull()
		{
			base[tableAUDIT_HEADER.DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCOUNT_REFNull()
		{
			return IsNull(tableAUDIT_HEADER.ACCOUNT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCOUNT_REFNull()
		{
			base[tableAUDIT_HEADER.ACCOUNT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_PURCHASE_REFNull()
		{
			return IsNull(tableAUDIT_HEADER.SALES_PURCHASE_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_PURCHASE_REFNull()
		{
			base[tableAUDIT_HEADER.SALES_PURCHASE_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_CODENull()
		{
			return IsNull(tableAUDIT_HEADER.BANK_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_CODENull()
		{
			base[tableAUDIT_HEADER.BANK_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_NAMENull()
		{
			return IsNull(tableAUDIT_HEADER.BANK_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_NAMENull()
		{
			base[tableAUDIT_HEADER.BANK_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINV_REFNull()
		{
			return IsNull(tableAUDIT_HEADER.INV_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINV_REFNull()
		{
			base[tableAUDIT_HEADER.INV_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINV_REF_NUMERICNull()
		{
			return IsNull(tableAUDIT_HEADER.INV_REF_NUMERICColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINV_REF_NUMERICNull()
		{
			base[tableAUDIT_HEADER.INV_REF_NUMERICColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUSER_NAMENull()
		{
			return IsNull(tableAUDIT_HEADER.USER_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUSER_NAMENull()
		{
			base[tableAUDIT_HEADER.USER_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDETAILSNull()
		{
			return IsNull(tableAUDIT_HEADER.DETAILSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDETAILSNull()
		{
			base[tableAUDIT_HEADER.DETAILSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDUE_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.DUE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDUE_DATENull()
		{
			base[tableAUDIT_HEADER.DUE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_CHARGE_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.LAST_CHARGE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_CHARGE_DATENull()
		{
			base[tableAUDIT_HEADER.LAST_CHARGE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINTEREST_RATENull()
		{
			return IsNull(tableAUDIT_HEADER.INTEREST_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINTEREST_RATENull()
		{
			base[tableAUDIT_HEADER.INTEREST_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsELECTRONIC_TRANSNull()
		{
			return IsNull(tableAUDIT_HEADER.ELECTRONIC_TRANSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetELECTRONIC_TRANSNull()
		{
			base[tableAUDIT_HEADER.ELECTRONIC_TRANSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISPUTEDNull()
		{
			return IsNull(tableAUDIT_HEADER.DISPUTEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISPUTEDNull()
		{
			base[tableAUDIT_HEADER.DISPUTEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAID_FLAGNull()
		{
			return IsNull(tableAUDIT_HEADER.PAID_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAID_FLAGNull()
		{
			base[tableAUDIT_HEADER.PAID_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAID_STATUSNull()
		{
			return IsNull(tableAUDIT_HEADER.PAID_STATUSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAID_STATUSNull()
		{
			base[tableAUDIT_HEADER.PAID_STATUSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDELETED_FLAGNull()
		{
			return IsNull(tableAUDIT_HEADER.DELETED_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDELETED_FLAGNull()
		{
			base[tableAUDIT_HEADER.DELETED_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_FLAGNull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_FLAGNull()
		{
			base[tableAUDIT_HEADER.DATE_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_BFNull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_BFNull()
		{
			base[tableAUDIT_HEADER.DATE_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_FROMNull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_FROMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_FROMNull()
		{
			base[tableAUDIT_HEADER.DATE_FROMColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_TONull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_TOColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_TONull()
		{
			base[tableAUDIT_HEADER.DATE_TOColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNET_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.NET_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNET_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.NET_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.TAX_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.TAX_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGROSS_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.GROSS_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetGROSS_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.GROSS_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.BANK_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.BANK_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAMOUNT_PAIDNull()
		{
			return IsNull(tableAUDIT_HEADER.AMOUNT_PAIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAMOUNT_PAIDNull()
		{
			base[tableAUDIT_HEADER.AMOUNT_PAIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENTNull()
		{
			return IsNull(tableAUDIT_HEADER.PAYMENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENTNull()
		{
			base[tableAUDIT_HEADER.PAYMENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsOUTSTANDINGNull()
		{
			return IsNull(tableAUDIT_HEADER.OUTSTANDINGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetOUTSTANDINGNull()
		{
			base[tableAUDIT_HEADER.OUTSTANDINGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_NET_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_NET_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_NET_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_NET_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_TAX_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_TAX_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_TAX_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_TAX_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_GROSS_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_GROSS_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_GROSS_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_GROSS_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AMOUNT_PAIDNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AMOUNT_PAIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AMOUNT_PAIDNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AMOUNT_PAIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_BANK_AMOUNTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_BANK_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_BANK_AMOUNTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_BANK_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEURO_GROSSNull()
		{
			return IsNull(tableAUDIT_HEADER.EURO_GROSSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEURO_GROSSNull()
		{
			base[tableAUDIT_HEADER.EURO_GROSSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEURO_RATENull()
		{
			return IsNull(tableAUDIT_HEADER.EURO_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEURO_RATENull()
		{
			base[tableAUDIT_HEADER.EURO_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_RATENull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_RATENull()
		{
			base[tableAUDIT_HEADER.FOREIGN_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_BALANCENull()
		{
			return IsNull(tableAUDIT_HEADER.AGED_BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_BALANCENull()
		{
			base[tableAUDIT_HEADER.AGED_BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_FUTURENull()
		{
			return IsNull(tableAUDIT_HEADER.AGED_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_FUTURENull()
		{
			base[tableAUDIT_HEADER.AGED_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CURRENTNull()
		{
			return IsNull(tableAUDIT_HEADER.AGED_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CURRENTNull()
		{
			base[tableAUDIT_HEADER.AGED_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_30Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_30Null()
		{
			base[tableAUDIT_HEADER.AGED_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_60Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_60Null()
		{
			base[tableAUDIT_HEADER.AGED_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_90Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_90Null()
		{
			base[tableAUDIT_HEADER.AGED_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_OLDERNull()
		{
			return IsNull(tableAUDIT_HEADER.AGED_OLDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_OLDERNull()
		{
			base[tableAUDIT_HEADER.AGED_OLDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_CURRENTNull()
		{
			return IsNull(tableAUDIT_HEADER.AGED_CUM_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_CURRENTNull()
		{
			base[tableAUDIT_HEADER.AGED_CUM_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_30Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_CUM_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_30Null()
		{
			base[tableAUDIT_HEADER.AGED_CUM_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_60Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_CUM_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_60Null()
		{
			base[tableAUDIT_HEADER.AGED_CUM_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAGED_CUM_90Null()
		{
			return IsNull(tableAUDIT_HEADER.AGED_CUM_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAGED_CUM_90Null()
		{
			base[tableAUDIT_HEADER.AGED_CUM_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_BALANCENull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_BALANCENull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_FUTURENull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_FUTURENull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CURRENTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CURRENTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_30Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_30Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_60Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_60Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_90Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_90Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_OLDERNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_OLDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_OLDERNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_OLDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_CURRENTNull()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_CUM_CURRENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_CURRENTNull()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_CURRENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_30Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_CUM_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_30Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_60Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_CUM_60Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_60Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_60Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFOREIGN_AGED_CUM_90Null()
		{
			return IsNull(tableAUDIT_HEADER.FOREIGN_AGED_CUM_90Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFOREIGN_AGED_CUM_90Null()
		{
			base[tableAUDIT_HEADER.FOREIGN_AGED_CUM_90Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_FLAGNull()
		{
			return IsNull(tableAUDIT_HEADER.BANK_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_FLAGNull()
		{
			base[tableAUDIT_HEADER.BANK_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHEADER_NUMBERNull()
		{
			return IsNull(tableAUDIT_HEADER.HEADER_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHEADER_NUMBERNull()
		{
			base[tableAUDIT_HEADER.HEADER_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_ENTEREDNull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_ENTEREDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_ENTEREDNull()
		{
			base[tableAUDIT_HEADER.DATE_ENTEREDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_BANK_RECONCILEDNull()
		{
			return IsNull(tableAUDIT_HEADER.DATE_BANK_RECONCILEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_BANK_RECONCILEDNull()
		{
			base[tableAUDIT_HEADER.DATE_BANK_RECONCILEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCIS_RECONCILEDNull()
		{
			return IsNull(tableAUDIT_HEADER.CIS_RECONCILEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCIS_RECONCILEDNull()
		{
			base[tableAUDIT_HEADER.CIS_RECONCILEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSPS_REFNull()
		{
			return IsNull(tableAUDIT_HEADER.SPS_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSPS_REFNull()
		{
			base[tableAUDIT_HEADER.SPS_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPOSIT_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.DEPOSIT_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPOSIT_DATENull()
		{
			base[tableAUDIT_HEADER.DEPOSIT_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPOSIT_FLAGNull()
		{
			return IsNull(tableAUDIT_HEADER.DEPOSIT_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPOSIT_FLAGNull()
		{
			base[tableAUDIT_HEADER.DEPOSIT_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECURRING_ENTRY_IDNull()
		{
			return IsNull(tableAUDIT_HEADER.RECURRING_ENTRY_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECURRING_ENTRY_IDNull()
		{
			base[tableAUDIT_HEADER.RECURRING_ENTRY_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_CREATE_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.RECORD_CREATE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_CREATE_DATENull()
		{
			base[tableAUDIT_HEADER.RECORD_CREATE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_MODIFY_DATENull()
		{
			return IsNull(tableAUDIT_HEADER.RECORD_MODIFY_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_MODIFY_DATENull()
		{
			base[tableAUDIT_HEADER.RECORD_MODIFY_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_DELETEDNull()
		{
			return IsNull(tableAUDIT_HEADER.RECORD_DELETEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_DELETEDNull()
		{
			base[tableAUDIT_HEADER.RECORD_DELETEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class AUDIT_SPLITRowChangeEvent : EventArgs
	{
		private AUDIT_SPLITRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_SPLITRowChangeEvent(AUDIT_SPLITRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class AUDIT_HEADERRowChangeEvent : EventArgs
	{
		private AUDIT_HEADERRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AUDIT_HEADERRowChangeEvent(AUDIT_HEADERRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private AUDIT_SPLITDataTable tableAUDIT_SPLIT;

	private AUDIT_HEADERDataTable tableAUDIT_HEADER;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public AUDIT_SPLITDataTable AUDIT_SPLIT => tableAUDIT_SPLIT;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public AUDIT_HEADERDataTable AUDIT_HEADER => tableAUDIT_HEADER;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Transactions()
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected Transactions(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["AUDIT_SPLIT"] != null)
			{
				base.Tables.Add(new AUDIT_SPLITDataTable(dataSet.Tables["AUDIT_SPLIT"]));
			}
			if (dataSet.Tables["AUDIT_HEADER"] != null)
			{
				base.Tables.Add(new AUDIT_HEADERDataTable(dataSet.Tables["AUDIT_HEADER"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		Transactions obj = (Transactions)base.Clone();
		obj.InitVars();
		obj.SchemaSerializationMode = SchemaSerializationMode;
		return obj;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["AUDIT_SPLIT"] != null)
			{
				base.Tables.Add(new AUDIT_SPLITDataTable(dataSet.Tables["AUDIT_SPLIT"]));
			}
			if (dataSet.Tables["AUDIT_HEADER"] != null)
			{
				base.Tables.Add(new AUDIT_HEADERDataTable(dataSet.Tables["AUDIT_HEADER"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableAUDIT_SPLIT = (AUDIT_SPLITDataTable)base.Tables["AUDIT_SPLIT"];
		if (initTable && tableAUDIT_SPLIT != null)
		{
			tableAUDIT_SPLIT.InitVars();
		}
		tableAUDIT_HEADER = (AUDIT_HEADERDataTable)base.Tables["AUDIT_HEADER"];
		if (initTable && tableAUDIT_HEADER != null)
		{
			tableAUDIT_HEADER.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "Transactions";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Transactions.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableAUDIT_SPLIT = new AUDIT_SPLITDataTable();
		base.Tables.Add(tableAUDIT_SPLIT);
		tableAUDIT_HEADER = new AUDIT_HEADERDataTable();
		base.Tables.Add(tableAUDIT_HEADER);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeAUDIT_SPLIT()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeAUDIT_HEADER()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		Transactions transactions = new Transactions();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = transactions.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = transactions.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					XmlSchema obj = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					obj.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
