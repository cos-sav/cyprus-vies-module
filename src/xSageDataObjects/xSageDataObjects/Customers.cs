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
[XmlRoot("Customers")]
[HelpKeyword("vs.data.DataSet")]
public class Customers : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void CustomersListRowChangeEventHandler(object sender, CustomersListRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class CustomersListDataTable : TypedTableBase<CustomersListRow>
	{
		private DataColumn columnACCOUNT_REF;

		private DataColumn columnNAME;

		private DataColumn columnADDRESS_1;

		private DataColumn columnADDRESS_2;

		private DataColumn columnADDRESS_3;

		private DataColumn columnADDRESS_4;

		private DataColumn columnADDRESS_5;

		private DataColumn columnC_ADDRESS_1;

		private DataColumn columnC_ADDRESS_2;

		private DataColumn columnC_ADDRESS_3;

		private DataColumn columnC_ADDRESS_4;

		private DataColumn columnC_ADDRESS_5;

		private DataColumn columnCONTACT_NAME;

		private DataColumn columnTELEPHONE;

		private DataColumn columnTELEPHONE_2;

		private DataColumn columnFAX;

		private DataColumn columnE_MAIL;

		private DataColumn columnWEB_ADDRESS;

		private DataColumn columnTRADE_CONTACT;

		private DataColumn columnDEL_NAME;

		private DataColumn columnDEL_ADDRESS_1;

		private DataColumn columnDEL_ADDRESS_2;

		private DataColumn columnDEL_ADDRESS_3;

		private DataColumn columnDEL_ADDRESS_4;

		private DataColumn columnDEL_ADDRESS_5;

		private DataColumn columnDEL_CONTACT_NAME;

		private DataColumn columnDEL_TELEPHONE;

		private DataColumn columnDEL_FAX;

		private DataColumn columnANALYSIS_1;

		private DataColumn columnANALYSIS_2;

		private DataColumn columnANALYSIS_3;

		private DataColumn columnDEPT_NUMBER;

		private DataColumn columnDEPT_NAME;

		private DataColumn columnSTATUS_NUMBER;

		private DataColumn columnSTATUS_TEXT;

		private DataColumn columnDEF_TAX_CODE;

		private DataColumn columnDEF_NOM_CODE;

		private DataColumn columnVAT_REG_NUMBER;

		private DataColumn columnCURRENCY;

		private DataColumn columnCOUNTRY_CODE;

		private DataColumn columnDISCOUNT_TYPE;

		private DataColumn columnDISCOUNT_RATE;

		private DataColumn columnPRICING_REF;

		private DataColumn columnSETTLEMENT_DISC_RATE;

		private DataColumn columnSETTLEMENT_DUE_DAYS;

		private DataColumn columnPAYMENT_DUE_DAYS;

		private DataColumn columnCREDIT_LIMIT;

		private DataColumn columnACCOUNT_ON_HOLD;

		private DataColumn columnTERMS;

		private DataColumn columnRESTRICT_MAIL;

		private DataColumn columnTERMS_AGREED;

		private DataColumn columnDATE_ACCOUNT_OPENED;

		private DataColumn columnDATE_NEXT_CREDIT;

		private DataColumn columnDATE_LAST_CREDIT;

		private DataColumn columnCREDIT_POSITION;

		private DataColumn columnCREDIT_POS_CODE;

		private DataColumn columnCAN_CHARGE;

		private DataColumn columnUSE_BACS;

		private DataColumn columnBACS_REF;

		private DataColumn columnBUREAU_CODE;

		private DataColumn columnCREDIT_REF;

		private DataColumn columnDATE_CREDIT_APPLIED;

		private DataColumn columnDATE_CREDIT_RECEIVED;

		private DataColumn columnOVERRIDE_TAX_CODE;

		private DataColumn columnLAST_PAYMENT_DATE;

		private DataColumn columnFIRST_INV_DATE;

		private DataColumn columnAVERAGE_PAY_DAYS;

		private DataColumn columnLAST_INV_DATE;

		private DataColumn columnBALANCE;

		private DataColumn columnTURNOVER_MTD;

		private DataColumn columnTURNOVER_YTD;

		private DataColumn columnPRIOR_YEAR;

		private DataColumn columnBANK_NAME;

		private DataColumn columnBANK_ADDRESS_1;

		private DataColumn columnBANK_ADDRESS_2;

		private DataColumn columnBANK_ADDRESS_3;

		private DataColumn columnBANK_ADDRESS_4;

		private DataColumn columnBANK_ADDRESS_5;

		private DataColumn columnBANK_SORT_CODE;

		private DataColumn columnBANK_ACCOUNT_NAME;

		private DataColumn columnBANK_ACCOUNT_NUMBER;

		private DataColumn columnBANK_IBAN;

		private DataColumn columnBANK_BIC;

		private DataColumn columnBANK_ROLLNUMBER;

		private DataColumn columnBANK_ADDITIONALREF1;

		private DataColumn columnBANK_ADDITIONALREF2;

		private DataColumn columnBANK_ADDITIONALREF3;

		private DataColumn columnDEFAULT_FUND_ID;

		private DataColumn columnGIFT_AID;

		private DataColumn columnINVOICE_BF;

		private DataColumn columnINVOICE_MTH1;

		private DataColumn columnINVOICE_MTH2;

		private DataColumn columnINVOICE_MTH3;

		private DataColumn columnINVOICE_MTH4;

		private DataColumn columnINVOICE_MTH5;

		private DataColumn columnINVOICE_MTH6;

		private DataColumn columnINVOICE_MTH7;

		private DataColumn columnINVOICE_MTH8;

		private DataColumn columnINVOICE_MTH9;

		private DataColumn columnINVOICE_MTH10;

		private DataColumn columnINVOICE_MTH11;

		private DataColumn columnINVOICE_MTH12;

		private DataColumn columnINVOICE_CF;

		private DataColumn columnCREDIT_BF;

		private DataColumn columnCREDIT_MTH1;

		private DataColumn columnCREDIT_MTH2;

		private DataColumn columnCREDIT_MTH3;

		private DataColumn columnCREDIT_MTH4;

		private DataColumn columnCREDIT_MTH5;

		private DataColumn columnCREDIT_MTH6;

		private DataColumn columnCREDIT_MTH7;

		private DataColumn columnCREDIT_MTH8;

		private DataColumn columnCREDIT_MTH9;

		private DataColumn columnCREDIT_MTH10;

		private DataColumn columnCREDIT_MTH11;

		private DataColumn columnCREDIT_MTH12;

		private DataColumn columnCREDIT_CF;

		private DataColumn columnPAYMENT_BF;

		private DataColumn columnPAYMENT_MTH1;

		private DataColumn columnPAYMENT_MTH2;

		private DataColumn columnPAYMENT_MTH3;

		private DataColumn columnPAYMENT_MTH4;

		private DataColumn columnPAYMENT_MTH5;

		private DataColumn columnPAYMENT_MTH6;

		private DataColumn columnPAYMENT_MTH7;

		private DataColumn columnPAYMENT_MTH8;

		private DataColumn columnPAYMENT_MTH9;

		private DataColumn columnPAYMENT_MTH10;

		private DataColumn columnPAYMENT_MTH11;

		private DataColumn columnPAYMENT_MTH12;

		private DataColumn columnPAYMENT_CF;

		private DataColumn columnDUNS_NUMBER;

		private DataColumn columnPRIORITY;

		private DataColumn columnPROMISED_PAYMENT;

		private DataColumn columnPROMISED_PAYMENT_DATE;

		private DataColumn columnREPORT_PASSWORD;

		private DataColumn columnLETTERS_VIA_EMAIL;

		private DataColumn columnPAYMENT_METHOD_ID;

		private DataColumn columnRECORD_CREATE_DATE;

		private DataColumn columnRECORD_MODIFY_DATE;

		private DataColumn columnRECORD_DELETED;

		private DataColumn columnEU_MEMBER;

		private DataColumn columnCOUNTRY_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_REFColumn => columnACCOUNT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NAMEColumn => columnNAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ADDRESS_1Column => columnADDRESS_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ADDRESS_2Column => columnADDRESS_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ADDRESS_3Column => columnADDRESS_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ADDRESS_4Column => columnADDRESS_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ADDRESS_5Column => columnADDRESS_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn C_ADDRESS_1Column => columnC_ADDRESS_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn C_ADDRESS_2Column => columnC_ADDRESS_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn C_ADDRESS_3Column => columnC_ADDRESS_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn C_ADDRESS_4Column => columnC_ADDRESS_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn C_ADDRESS_5Column => columnC_ADDRESS_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CONTACT_NAMEColumn => columnCONTACT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TELEPHONEColumn => columnTELEPHONE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TELEPHONE_2Column => columnTELEPHONE_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FAXColumn => columnFAX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn E_MAILColumn => columnE_MAIL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_ADDRESSColumn => columnWEB_ADDRESS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TRADE_CONTACTColumn => columnTRADE_CONTACT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_NAMEColumn => columnDEL_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_ADDRESS_1Column => columnDEL_ADDRESS_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_ADDRESS_2Column => columnDEL_ADDRESS_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_ADDRESS_3Column => columnDEL_ADDRESS_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_ADDRESS_4Column => columnDEL_ADDRESS_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_ADDRESS_5Column => columnDEL_ADDRESS_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_CONTACT_NAMEColumn => columnDEL_CONTACT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_TELEPHONEColumn => columnDEL_TELEPHONE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEL_FAXColumn => columnDEL_FAX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ANALYSIS_1Column => columnANALYSIS_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ANALYSIS_2Column => columnANALYSIS_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ANALYSIS_3Column => columnANALYSIS_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPT_NUMBERColumn => columnDEPT_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEPT_NAMEColumn => columnDEPT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STATUS_NUMBERColumn => columnSTATUS_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STATUS_TEXTColumn => columnSTATUS_TEXT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEF_TAX_CODEColumn => columnDEF_TAX_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEF_NOM_CODEColumn => columnDEF_NOM_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_REG_NUMBERColumn => columnVAT_REG_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CURRENCYColumn => columnCURRENCY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COUNTRY_CODEColumn => columnCOUNTRY_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISCOUNT_TYPEColumn => columnDISCOUNT_TYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISCOUNT_RATEColumn => columnDISCOUNT_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRICING_REFColumn => columnPRICING_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SETTLEMENT_DISC_RATEColumn => columnSETTLEMENT_DISC_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SETTLEMENT_DUE_DAYSColumn => columnSETTLEMENT_DUE_DAYS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_DUE_DAYSColumn => columnPAYMENT_DUE_DAYS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_LIMITColumn => columnCREDIT_LIMIT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_ON_HOLDColumn => columnACCOUNT_ON_HOLD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TERMSColumn => columnTERMS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RESTRICT_MAILColumn => columnRESTRICT_MAIL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TERMS_AGREEDColumn => columnTERMS_AGREED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_ACCOUNT_OPENEDColumn => columnDATE_ACCOUNT_OPENED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_NEXT_CREDITColumn => columnDATE_NEXT_CREDIT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_LAST_CREDITColumn => columnDATE_LAST_CREDIT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_POSITIONColumn => columnCREDIT_POSITION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_POS_CODEColumn => columnCREDIT_POS_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CAN_CHARGEColumn => columnCAN_CHARGE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn USE_BACSColumn => columnUSE_BACS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BACS_REFColumn => columnBACS_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUREAU_CODEColumn => columnBUREAU_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_REFColumn => columnCREDIT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_CREDIT_APPLIEDColumn => columnDATE_CREDIT_APPLIED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_CREDIT_RECEIVEDColumn => columnDATE_CREDIT_RECEIVED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn OVERRIDE_TAX_CODEColumn => columnOVERRIDE_TAX_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_PAYMENT_DATEColumn => columnLAST_PAYMENT_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FIRST_INV_DATEColumn => columnFIRST_INV_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AVERAGE_PAY_DAYSColumn => columnAVERAGE_PAY_DAYS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_INV_DATEColumn => columnLAST_INV_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCEColumn => columnBALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TURNOVER_MTDColumn => columnTURNOVER_MTD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TURNOVER_YTDColumn => columnTURNOVER_YTD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YEARColumn => columnPRIOR_YEAR;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_NAMEColumn => columnBANK_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDRESS_1Column => columnBANK_ADDRESS_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDRESS_2Column => columnBANK_ADDRESS_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDRESS_3Column => columnBANK_ADDRESS_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDRESS_4Column => columnBANK_ADDRESS_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDRESS_5Column => columnBANK_ADDRESS_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_SORT_CODEColumn => columnBANK_SORT_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ACCOUNT_NAMEColumn => columnBANK_ACCOUNT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ACCOUNT_NUMBERColumn => columnBANK_ACCOUNT_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_IBANColumn => columnBANK_IBAN;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_BICColumn => columnBANK_BIC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ROLLNUMBERColumn => columnBANK_ROLLNUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDITIONALREF1Column => columnBANK_ADDITIONALREF1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDITIONALREF2Column => columnBANK_ADDITIONALREF2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BANK_ADDITIONALREF3Column => columnBANK_ADDITIONALREF3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEFAULT_FUND_IDColumn => columnDEFAULT_FUND_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn GIFT_AIDColumn => columnGIFT_AID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_BFColumn => columnINVOICE_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH1Column => columnINVOICE_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH2Column => columnINVOICE_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH3Column => columnINVOICE_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH4Column => columnINVOICE_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH5Column => columnINVOICE_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH6Column => columnINVOICE_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH7Column => columnINVOICE_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH8Column => columnINVOICE_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH9Column => columnINVOICE_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH10Column => columnINVOICE_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH11Column => columnINVOICE_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_MTH12Column => columnINVOICE_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INVOICE_CFColumn => columnINVOICE_CF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_BFColumn => columnCREDIT_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH1Column => columnCREDIT_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH2Column => columnCREDIT_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH3Column => columnCREDIT_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH4Column => columnCREDIT_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH5Column => columnCREDIT_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH6Column => columnCREDIT_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH7Column => columnCREDIT_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH8Column => columnCREDIT_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH9Column => columnCREDIT_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH10Column => columnCREDIT_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH11Column => columnCREDIT_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_MTH12Column => columnCREDIT_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_CFColumn => columnCREDIT_CF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_BFColumn => columnPAYMENT_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH1Column => columnPAYMENT_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH2Column => columnPAYMENT_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH3Column => columnPAYMENT_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH4Column => columnPAYMENT_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH5Column => columnPAYMENT_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH6Column => columnPAYMENT_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH7Column => columnPAYMENT_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH8Column => columnPAYMENT_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH9Column => columnPAYMENT_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH10Column => columnPAYMENT_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH11Column => columnPAYMENT_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_MTH12Column => columnPAYMENT_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_CFColumn => columnPAYMENT_CF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DUNS_NUMBERColumn => columnDUNS_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIORITYColumn => columnPRIORITY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PROMISED_PAYMENTColumn => columnPROMISED_PAYMENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PROMISED_PAYMENT_DATEColumn => columnPROMISED_PAYMENT_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn REPORT_PASSWORDColumn => columnREPORT_PASSWORD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LETTERS_VIA_EMAILColumn => columnLETTERS_VIA_EMAIL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PAYMENT_METHOD_IDColumn => columnPAYMENT_METHOD_ID;

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
		public DataColumn EU_MEMBERColumn => columnEU_MEMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COUNTRY_NAMEColumn => columnCOUNTRY_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListRow this[int index] => (CustomersListRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event CustomersListRowChangeEventHandler CustomersListRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event CustomersListRowChangeEventHandler CustomersListRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event CustomersListRowChangeEventHandler CustomersListRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event CustomersListRowChangeEventHandler CustomersListRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListDataTable()
		{
			base.TableName = "CustomersList";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal CustomersListDataTable(DataTable table)
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
		protected CustomersListDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddCustomersListRow(CustomersListRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListRow AddCustomersListRow(string ACCOUNT_REF, string NAME, string ADDRESS_1, string ADDRESS_2, string ADDRESS_3, string ADDRESS_4, string ADDRESS_5, string C_ADDRESS_1, string C_ADDRESS_2, string C_ADDRESS_3, string C_ADDRESS_4, string C_ADDRESS_5, string CONTACT_NAME, string TELEPHONE, string TELEPHONE_2, string FAX, string E_MAIL, string WEB_ADDRESS, string TRADE_CONTACT, string DEL_NAME, string DEL_ADDRESS_1, string DEL_ADDRESS_2, string DEL_ADDRESS_3, string DEL_ADDRESS_4, string DEL_ADDRESS_5, string DEL_CONTACT_NAME, string DEL_TELEPHONE, string DEL_FAX, string ANALYSIS_1, string ANALYSIS_2, string ANALYSIS_3, short DEPT_NUMBER, string DEPT_NAME, short STATUS_NUMBER, string STATUS_TEXT, string DEF_TAX_CODE, string DEF_NOM_CODE, string VAT_REG_NUMBER, short CURRENCY, string COUNTRY_CODE, short DISCOUNT_TYPE, double DISCOUNT_RATE, string PRICING_REF, double SETTLEMENT_DISC_RATE, short SETTLEMENT_DUE_DAYS, short PAYMENT_DUE_DAYS, double CREDIT_LIMIT, short ACCOUNT_ON_HOLD, string TERMS, short RESTRICT_MAIL, short TERMS_AGREED, DateTime DATE_ACCOUNT_OPENED, DateTime DATE_NEXT_CREDIT, DateTime DATE_LAST_CREDIT, string CREDIT_POSITION, short CREDIT_POS_CODE, short CAN_CHARGE, short USE_BACS, string BACS_REF, short BUREAU_CODE, string CREDIT_REF, DateTime DATE_CREDIT_APPLIED, DateTime DATE_CREDIT_RECEIVED, short OVERRIDE_TAX_CODE, DateTime LAST_PAYMENT_DATE, DateTime FIRST_INV_DATE, double AVERAGE_PAY_DAYS, DateTime LAST_INV_DATE, double BALANCE, double TURNOVER_MTD, double TURNOVER_YTD, double PRIOR_YEAR, string BANK_NAME, string BANK_ADDRESS_1, string BANK_ADDRESS_2, string BANK_ADDRESS_3, string BANK_ADDRESS_4, string BANK_ADDRESS_5, string BANK_SORT_CODE, string BANK_ACCOUNT_NAME, string BANK_ACCOUNT_NUMBER, string BANK_IBAN, string BANK_BIC, string BANK_ROLLNUMBER, string BANK_ADDITIONALREF1, string BANK_ADDITIONALREF2, string BANK_ADDITIONALREF3, int DEFAULT_FUND_ID, short GIFT_AID, double INVOICE_BF, double INVOICE_MTH1, double INVOICE_MTH2, double INVOICE_MTH3, double INVOICE_MTH4, double INVOICE_MTH5, double INVOICE_MTH6, double INVOICE_MTH7, double INVOICE_MTH8, double INVOICE_MTH9, double INVOICE_MTH10, double INVOICE_MTH11, double INVOICE_MTH12, double INVOICE_CF, double CREDIT_BF, double CREDIT_MTH1, double CREDIT_MTH2, double CREDIT_MTH3, double CREDIT_MTH4, double CREDIT_MTH5, double CREDIT_MTH6, double CREDIT_MTH7, double CREDIT_MTH8, double CREDIT_MTH9, double CREDIT_MTH10, double CREDIT_MTH11, double CREDIT_MTH12, double CREDIT_CF, double PAYMENT_BF, double PAYMENT_MTH1, double PAYMENT_MTH2, double PAYMENT_MTH3, double PAYMENT_MTH4, double PAYMENT_MTH5, double PAYMENT_MTH6, double PAYMENT_MTH7, double PAYMENT_MTH8, double PAYMENT_MTH9, double PAYMENT_MTH10, double PAYMENT_MTH11, double PAYMENT_MTH12, double PAYMENT_CF, string DUNS_NUMBER, short PRIORITY, double PROMISED_PAYMENT, DateTime PROMISED_PAYMENT_DATE, string REPORT_PASSWORD, short LETTERS_VIA_EMAIL, int PAYMENT_METHOD_ID, DateTime RECORD_CREATE_DATE, DateTime RECORD_MODIFY_DATE, short RECORD_DELETED, short EU_MEMBER, string COUNTRY_NAME)
		{
			CustomersListRow customersListRow = (CustomersListRow)NewRow();
			object[] itemArray = new object[143]
			{
				ACCOUNT_REF, NAME, ADDRESS_1, ADDRESS_2, ADDRESS_3, ADDRESS_4, ADDRESS_5, C_ADDRESS_1, C_ADDRESS_2, C_ADDRESS_3,
				C_ADDRESS_4, C_ADDRESS_5, CONTACT_NAME, TELEPHONE, TELEPHONE_2, FAX, E_MAIL, WEB_ADDRESS, TRADE_CONTACT, DEL_NAME,
				DEL_ADDRESS_1, DEL_ADDRESS_2, DEL_ADDRESS_3, DEL_ADDRESS_4, DEL_ADDRESS_5, DEL_CONTACT_NAME, DEL_TELEPHONE, DEL_FAX, ANALYSIS_1, ANALYSIS_2,
				ANALYSIS_3, DEPT_NUMBER, DEPT_NAME, STATUS_NUMBER, STATUS_TEXT, DEF_TAX_CODE, DEF_NOM_CODE, VAT_REG_NUMBER, CURRENCY, COUNTRY_CODE,
				DISCOUNT_TYPE, DISCOUNT_RATE, PRICING_REF, SETTLEMENT_DISC_RATE, SETTLEMENT_DUE_DAYS, PAYMENT_DUE_DAYS, CREDIT_LIMIT, ACCOUNT_ON_HOLD, TERMS, RESTRICT_MAIL,
				TERMS_AGREED, DATE_ACCOUNT_OPENED, DATE_NEXT_CREDIT, DATE_LAST_CREDIT, CREDIT_POSITION, CREDIT_POS_CODE, CAN_CHARGE, USE_BACS, BACS_REF, BUREAU_CODE,
				CREDIT_REF, DATE_CREDIT_APPLIED, DATE_CREDIT_RECEIVED, OVERRIDE_TAX_CODE, LAST_PAYMENT_DATE, FIRST_INV_DATE, AVERAGE_PAY_DAYS, LAST_INV_DATE, BALANCE, TURNOVER_MTD,
				TURNOVER_YTD, PRIOR_YEAR, BANK_NAME, BANK_ADDRESS_1, BANK_ADDRESS_2, BANK_ADDRESS_3, BANK_ADDRESS_4, BANK_ADDRESS_5, BANK_SORT_CODE, BANK_ACCOUNT_NAME,
				BANK_ACCOUNT_NUMBER, BANK_IBAN, BANK_BIC, BANK_ROLLNUMBER, BANK_ADDITIONALREF1, BANK_ADDITIONALREF2, BANK_ADDITIONALREF3, DEFAULT_FUND_ID, GIFT_AID, INVOICE_BF,
				INVOICE_MTH1, INVOICE_MTH2, INVOICE_MTH3, INVOICE_MTH4, INVOICE_MTH5, INVOICE_MTH6, INVOICE_MTH7, INVOICE_MTH8, INVOICE_MTH9, INVOICE_MTH10,
				INVOICE_MTH11, INVOICE_MTH12, INVOICE_CF, CREDIT_BF, CREDIT_MTH1, CREDIT_MTH2, CREDIT_MTH3, CREDIT_MTH4, CREDIT_MTH5, CREDIT_MTH6,
				CREDIT_MTH7, CREDIT_MTH8, CREDIT_MTH9, CREDIT_MTH10, CREDIT_MTH11, CREDIT_MTH12, CREDIT_CF, PAYMENT_BF, PAYMENT_MTH1, PAYMENT_MTH2,
				PAYMENT_MTH3, PAYMENT_MTH4, PAYMENT_MTH5, PAYMENT_MTH6, PAYMENT_MTH7, PAYMENT_MTH8, PAYMENT_MTH9, PAYMENT_MTH10, PAYMENT_MTH11, PAYMENT_MTH12,
				PAYMENT_CF, DUNS_NUMBER, PRIORITY, PROMISED_PAYMENT, PROMISED_PAYMENT_DATE, REPORT_PASSWORD, LETTERS_VIA_EMAIL, PAYMENT_METHOD_ID, RECORD_CREATE_DATE, RECORD_MODIFY_DATE,
				RECORD_DELETED, EU_MEMBER, COUNTRY_NAME
			};
			customersListRow.ItemArray = itemArray;
			base.Rows.Add(customersListRow);
			return customersListRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			CustomersListDataTable obj = (CustomersListDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new CustomersListDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnACCOUNT_REF = base.Columns["ACCOUNT_REF"];
			columnNAME = base.Columns["NAME"];
			columnADDRESS_1 = base.Columns["ADDRESS_1"];
			columnADDRESS_2 = base.Columns["ADDRESS_2"];
			columnADDRESS_3 = base.Columns["ADDRESS_3"];
			columnADDRESS_4 = base.Columns["ADDRESS_4"];
			columnADDRESS_5 = base.Columns["ADDRESS_5"];
			columnC_ADDRESS_1 = base.Columns["C_ADDRESS_1"];
			columnC_ADDRESS_2 = base.Columns["C_ADDRESS_2"];
			columnC_ADDRESS_3 = base.Columns["C_ADDRESS_3"];
			columnC_ADDRESS_4 = base.Columns["C_ADDRESS_4"];
			columnC_ADDRESS_5 = base.Columns["C_ADDRESS_5"];
			columnCONTACT_NAME = base.Columns["CONTACT_NAME"];
			columnTELEPHONE = base.Columns["TELEPHONE"];
			columnTELEPHONE_2 = base.Columns["TELEPHONE_2"];
			columnFAX = base.Columns["FAX"];
			columnE_MAIL = base.Columns["E_MAIL"];
			columnWEB_ADDRESS = base.Columns["WEB_ADDRESS"];
			columnTRADE_CONTACT = base.Columns["TRADE_CONTACT"];
			columnDEL_NAME = base.Columns["DEL_NAME"];
			columnDEL_ADDRESS_1 = base.Columns["DEL_ADDRESS_1"];
			columnDEL_ADDRESS_2 = base.Columns["DEL_ADDRESS_2"];
			columnDEL_ADDRESS_3 = base.Columns["DEL_ADDRESS_3"];
			columnDEL_ADDRESS_4 = base.Columns["DEL_ADDRESS_4"];
			columnDEL_ADDRESS_5 = base.Columns["DEL_ADDRESS_5"];
			columnDEL_CONTACT_NAME = base.Columns["DEL_CONTACT_NAME"];
			columnDEL_TELEPHONE = base.Columns["DEL_TELEPHONE"];
			columnDEL_FAX = base.Columns["DEL_FAX"];
			columnANALYSIS_1 = base.Columns["ANALYSIS_1"];
			columnANALYSIS_2 = base.Columns["ANALYSIS_2"];
			columnANALYSIS_3 = base.Columns["ANALYSIS_3"];
			columnDEPT_NUMBER = base.Columns["DEPT_NUMBER"];
			columnDEPT_NAME = base.Columns["DEPT_NAME"];
			columnSTATUS_NUMBER = base.Columns["STATUS_NUMBER"];
			columnSTATUS_TEXT = base.Columns["STATUS_TEXT"];
			columnDEF_TAX_CODE = base.Columns["DEF_TAX_CODE"];
			columnDEF_NOM_CODE = base.Columns["DEF_NOM_CODE"];
			columnVAT_REG_NUMBER = base.Columns["VAT_REG_NUMBER"];
			columnCURRENCY = base.Columns["CURRENCY"];
			columnCOUNTRY_CODE = base.Columns["COUNTRY_CODE"];
			columnDISCOUNT_TYPE = base.Columns["DISCOUNT_TYPE"];
			columnDISCOUNT_RATE = base.Columns["DISCOUNT_RATE"];
			columnPRICING_REF = base.Columns["PRICING_REF"];
			columnSETTLEMENT_DISC_RATE = base.Columns["SETTLEMENT_DISC_RATE"];
			columnSETTLEMENT_DUE_DAYS = base.Columns["SETTLEMENT_DUE_DAYS"];
			columnPAYMENT_DUE_DAYS = base.Columns["PAYMENT_DUE_DAYS"];
			columnCREDIT_LIMIT = base.Columns["CREDIT_LIMIT"];
			columnACCOUNT_ON_HOLD = base.Columns["ACCOUNT_ON_HOLD"];
			columnTERMS = base.Columns["TERMS"];
			columnRESTRICT_MAIL = base.Columns["RESTRICT_MAIL"];
			columnTERMS_AGREED = base.Columns["TERMS_AGREED"];
			columnDATE_ACCOUNT_OPENED = base.Columns["DATE_ACCOUNT_OPENED"];
			columnDATE_NEXT_CREDIT = base.Columns["DATE_NEXT_CREDIT"];
			columnDATE_LAST_CREDIT = base.Columns["DATE_LAST_CREDIT"];
			columnCREDIT_POSITION = base.Columns["CREDIT_POSITION"];
			columnCREDIT_POS_CODE = base.Columns["CREDIT_POS_CODE"];
			columnCAN_CHARGE = base.Columns["CAN_CHARGE"];
			columnUSE_BACS = base.Columns["USE_BACS"];
			columnBACS_REF = base.Columns["BACS_REF"];
			columnBUREAU_CODE = base.Columns["BUREAU_CODE"];
			columnCREDIT_REF = base.Columns["CREDIT_REF"];
			columnDATE_CREDIT_APPLIED = base.Columns["DATE_CREDIT_APPLIED"];
			columnDATE_CREDIT_RECEIVED = base.Columns["DATE_CREDIT_RECEIVED"];
			columnOVERRIDE_TAX_CODE = base.Columns["OVERRIDE_TAX_CODE"];
			columnLAST_PAYMENT_DATE = base.Columns["LAST_PAYMENT_DATE"];
			columnFIRST_INV_DATE = base.Columns["FIRST_INV_DATE"];
			columnAVERAGE_PAY_DAYS = base.Columns["AVERAGE_PAY_DAYS"];
			columnLAST_INV_DATE = base.Columns["LAST_INV_DATE"];
			columnBALANCE = base.Columns["BALANCE"];
			columnTURNOVER_MTD = base.Columns["TURNOVER_MTD"];
			columnTURNOVER_YTD = base.Columns["TURNOVER_YTD"];
			columnPRIOR_YEAR = base.Columns["PRIOR_YEAR"];
			columnBANK_NAME = base.Columns["BANK_NAME"];
			columnBANK_ADDRESS_1 = base.Columns["BANK_ADDRESS_1"];
			columnBANK_ADDRESS_2 = base.Columns["BANK_ADDRESS_2"];
			columnBANK_ADDRESS_3 = base.Columns["BANK_ADDRESS_3"];
			columnBANK_ADDRESS_4 = base.Columns["BANK_ADDRESS_4"];
			columnBANK_ADDRESS_5 = base.Columns["BANK_ADDRESS_5"];
			columnBANK_SORT_CODE = base.Columns["BANK_SORT_CODE"];
			columnBANK_ACCOUNT_NAME = base.Columns["BANK_ACCOUNT_NAME"];
			columnBANK_ACCOUNT_NUMBER = base.Columns["BANK_ACCOUNT_NUMBER"];
			columnBANK_IBAN = base.Columns["BANK_IBAN"];
			columnBANK_BIC = base.Columns["BANK_BIC"];
			columnBANK_ROLLNUMBER = base.Columns["BANK_ROLLNUMBER"];
			columnBANK_ADDITIONALREF1 = base.Columns["BANK_ADDITIONALREF1"];
			columnBANK_ADDITIONALREF2 = base.Columns["BANK_ADDITIONALREF2"];
			columnBANK_ADDITIONALREF3 = base.Columns["BANK_ADDITIONALREF3"];
			columnDEFAULT_FUND_ID = base.Columns["DEFAULT_FUND_ID"];
			columnGIFT_AID = base.Columns["GIFT_AID"];
			columnINVOICE_BF = base.Columns["INVOICE_BF"];
			columnINVOICE_MTH1 = base.Columns["INVOICE_MTH1"];
			columnINVOICE_MTH2 = base.Columns["INVOICE_MTH2"];
			columnINVOICE_MTH3 = base.Columns["INVOICE_MTH3"];
			columnINVOICE_MTH4 = base.Columns["INVOICE_MTH4"];
			columnINVOICE_MTH5 = base.Columns["INVOICE_MTH5"];
			columnINVOICE_MTH6 = base.Columns["INVOICE_MTH6"];
			columnINVOICE_MTH7 = base.Columns["INVOICE_MTH7"];
			columnINVOICE_MTH8 = base.Columns["INVOICE_MTH8"];
			columnINVOICE_MTH9 = base.Columns["INVOICE_MTH9"];
			columnINVOICE_MTH10 = base.Columns["INVOICE_MTH10"];
			columnINVOICE_MTH11 = base.Columns["INVOICE_MTH11"];
			columnINVOICE_MTH12 = base.Columns["INVOICE_MTH12"];
			columnINVOICE_CF = base.Columns["INVOICE_CF"];
			columnCREDIT_BF = base.Columns["CREDIT_BF"];
			columnCREDIT_MTH1 = base.Columns["CREDIT_MTH1"];
			columnCREDIT_MTH2 = base.Columns["CREDIT_MTH2"];
			columnCREDIT_MTH3 = base.Columns["CREDIT_MTH3"];
			columnCREDIT_MTH4 = base.Columns["CREDIT_MTH4"];
			columnCREDIT_MTH5 = base.Columns["CREDIT_MTH5"];
			columnCREDIT_MTH6 = base.Columns["CREDIT_MTH6"];
			columnCREDIT_MTH7 = base.Columns["CREDIT_MTH7"];
			columnCREDIT_MTH8 = base.Columns["CREDIT_MTH8"];
			columnCREDIT_MTH9 = base.Columns["CREDIT_MTH9"];
			columnCREDIT_MTH10 = base.Columns["CREDIT_MTH10"];
			columnCREDIT_MTH11 = base.Columns["CREDIT_MTH11"];
			columnCREDIT_MTH12 = base.Columns["CREDIT_MTH12"];
			columnCREDIT_CF = base.Columns["CREDIT_CF"];
			columnPAYMENT_BF = base.Columns["PAYMENT_BF"];
			columnPAYMENT_MTH1 = base.Columns["PAYMENT_MTH1"];
			columnPAYMENT_MTH2 = base.Columns["PAYMENT_MTH2"];
			columnPAYMENT_MTH3 = base.Columns["PAYMENT_MTH3"];
			columnPAYMENT_MTH4 = base.Columns["PAYMENT_MTH4"];
			columnPAYMENT_MTH5 = base.Columns["PAYMENT_MTH5"];
			columnPAYMENT_MTH6 = base.Columns["PAYMENT_MTH6"];
			columnPAYMENT_MTH7 = base.Columns["PAYMENT_MTH7"];
			columnPAYMENT_MTH8 = base.Columns["PAYMENT_MTH8"];
			columnPAYMENT_MTH9 = base.Columns["PAYMENT_MTH9"];
			columnPAYMENT_MTH10 = base.Columns["PAYMENT_MTH10"];
			columnPAYMENT_MTH11 = base.Columns["PAYMENT_MTH11"];
			columnPAYMENT_MTH12 = base.Columns["PAYMENT_MTH12"];
			columnPAYMENT_CF = base.Columns["PAYMENT_CF"];
			columnDUNS_NUMBER = base.Columns["DUNS_NUMBER"];
			columnPRIORITY = base.Columns["PRIORITY"];
			columnPROMISED_PAYMENT = base.Columns["PROMISED_PAYMENT"];
			columnPROMISED_PAYMENT_DATE = base.Columns["PROMISED_PAYMENT_DATE"];
			columnREPORT_PASSWORD = base.Columns["REPORT_PASSWORD"];
			columnLETTERS_VIA_EMAIL = base.Columns["LETTERS_VIA_EMAIL"];
			columnPAYMENT_METHOD_ID = base.Columns["PAYMENT_METHOD_ID"];
			columnRECORD_CREATE_DATE = base.Columns["RECORD_CREATE_DATE"];
			columnRECORD_MODIFY_DATE = base.Columns["RECORD_MODIFY_DATE"];
			columnRECORD_DELETED = base.Columns["RECORD_DELETED"];
			columnEU_MEMBER = base.Columns["EU_MEMBER"];
			columnCOUNTRY_NAME = base.Columns["COUNTRY_NAME"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnACCOUNT_REF = new DataColumn("ACCOUNT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_REF);
			columnNAME = new DataColumn("NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNAME);
			columnADDRESS_1 = new DataColumn("ADDRESS_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS_1);
			columnADDRESS_2 = new DataColumn("ADDRESS_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS_2);
			columnADDRESS_3 = new DataColumn("ADDRESS_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS_3);
			columnADDRESS_4 = new DataColumn("ADDRESS_4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS_4);
			columnADDRESS_5 = new DataColumn("ADDRESS_5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS_5);
			columnC_ADDRESS_1 = new DataColumn("C_ADDRESS_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnC_ADDRESS_1);
			columnC_ADDRESS_2 = new DataColumn("C_ADDRESS_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnC_ADDRESS_2);
			columnC_ADDRESS_3 = new DataColumn("C_ADDRESS_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnC_ADDRESS_3);
			columnC_ADDRESS_4 = new DataColumn("C_ADDRESS_4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnC_ADDRESS_4);
			columnC_ADDRESS_5 = new DataColumn("C_ADDRESS_5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnC_ADDRESS_5);
			columnCONTACT_NAME = new DataColumn("CONTACT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCONTACT_NAME);
			columnTELEPHONE = new DataColumn("TELEPHONE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTELEPHONE);
			columnTELEPHONE_2 = new DataColumn("TELEPHONE_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTELEPHONE_2);
			columnFAX = new DataColumn("FAX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFAX);
			columnE_MAIL = new DataColumn("E_MAIL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnE_MAIL);
			columnWEB_ADDRESS = new DataColumn("WEB_ADDRESS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_ADDRESS);
			columnTRADE_CONTACT = new DataColumn("TRADE_CONTACT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTRADE_CONTACT);
			columnDEL_NAME = new DataColumn("DEL_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_NAME);
			columnDEL_ADDRESS_1 = new DataColumn("DEL_ADDRESS_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_ADDRESS_1);
			columnDEL_ADDRESS_2 = new DataColumn("DEL_ADDRESS_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_ADDRESS_2);
			columnDEL_ADDRESS_3 = new DataColumn("DEL_ADDRESS_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_ADDRESS_3);
			columnDEL_ADDRESS_4 = new DataColumn("DEL_ADDRESS_4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_ADDRESS_4);
			columnDEL_ADDRESS_5 = new DataColumn("DEL_ADDRESS_5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_ADDRESS_5);
			columnDEL_CONTACT_NAME = new DataColumn("DEL_CONTACT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_CONTACT_NAME);
			columnDEL_TELEPHONE = new DataColumn("DEL_TELEPHONE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_TELEPHONE);
			columnDEL_FAX = new DataColumn("DEL_FAX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEL_FAX);
			columnANALYSIS_1 = new DataColumn("ANALYSIS_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnANALYSIS_1);
			columnANALYSIS_2 = new DataColumn("ANALYSIS_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnANALYSIS_2);
			columnANALYSIS_3 = new DataColumn("ANALYSIS_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnANALYSIS_3);
			columnDEPT_NUMBER = new DataColumn("DEPT_NUMBER", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NUMBER);
			columnDEPT_NAME = new DataColumn("DEPT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NAME);
			columnSTATUS_NUMBER = new DataColumn("STATUS_NUMBER", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnSTATUS_NUMBER);
			columnSTATUS_TEXT = new DataColumn("STATUS_TEXT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTATUS_TEXT);
			columnDEF_TAX_CODE = new DataColumn("DEF_TAX_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEF_TAX_CODE);
			columnDEF_NOM_CODE = new DataColumn("DEF_NOM_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEF_NOM_CODE);
			columnVAT_REG_NUMBER = new DataColumn("VAT_REG_NUMBER", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVAT_REG_NUMBER);
			columnCURRENCY = new DataColumn("CURRENCY", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCURRENCY);
			columnCOUNTRY_CODE = new DataColumn("COUNTRY_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOUNTRY_CODE);
			columnDISCOUNT_TYPE = new DataColumn("DISCOUNT_TYPE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDISCOUNT_TYPE);
			columnDISCOUNT_RATE = new DataColumn("DISCOUNT_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISCOUNT_RATE);
			columnPRICING_REF = new DataColumn("PRICING_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPRICING_REF);
			columnSETTLEMENT_DISC_RATE = new DataColumn("SETTLEMENT_DISC_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSETTLEMENT_DISC_RATE);
			columnSETTLEMENT_DUE_DAYS = new DataColumn("SETTLEMENT_DUE_DAYS", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnSETTLEMENT_DUE_DAYS);
			columnPAYMENT_DUE_DAYS = new DataColumn("PAYMENT_DUE_DAYS", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_DUE_DAYS);
			columnCREDIT_LIMIT = new DataColumn("CREDIT_LIMIT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_LIMIT);
			columnACCOUNT_ON_HOLD = new DataColumn("ACCOUNT_ON_HOLD", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_ON_HOLD);
			columnTERMS = new DataColumn("TERMS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTERMS);
			columnRESTRICT_MAIL = new DataColumn("RESTRICT_MAIL", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRESTRICT_MAIL);
			columnTERMS_AGREED = new DataColumn("TERMS_AGREED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnTERMS_AGREED);
			columnDATE_ACCOUNT_OPENED = new DataColumn("DATE_ACCOUNT_OPENED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_ACCOUNT_OPENED);
			columnDATE_NEXT_CREDIT = new DataColumn("DATE_NEXT_CREDIT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_NEXT_CREDIT);
			columnDATE_LAST_CREDIT = new DataColumn("DATE_LAST_CREDIT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_LAST_CREDIT);
			columnCREDIT_POSITION = new DataColumn("CREDIT_POSITION", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_POSITION);
			columnCREDIT_POS_CODE = new DataColumn("CREDIT_POS_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_POS_CODE);
			columnCAN_CHARGE = new DataColumn("CAN_CHARGE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnCAN_CHARGE);
			columnUSE_BACS = new DataColumn("USE_BACS", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnUSE_BACS);
			columnBACS_REF = new DataColumn("BACS_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBACS_REF);
			columnBUREAU_CODE = new DataColumn("BUREAU_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnBUREAU_CODE);
			columnCREDIT_REF = new DataColumn("CREDIT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_REF);
			columnDATE_CREDIT_APPLIED = new DataColumn("DATE_CREDIT_APPLIED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_CREDIT_APPLIED);
			columnDATE_CREDIT_RECEIVED = new DataColumn("DATE_CREDIT_RECEIVED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_CREDIT_RECEIVED);
			columnOVERRIDE_TAX_CODE = new DataColumn("OVERRIDE_TAX_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnOVERRIDE_TAX_CODE);
			columnLAST_PAYMENT_DATE = new DataColumn("LAST_PAYMENT_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLAST_PAYMENT_DATE);
			columnFIRST_INV_DATE = new DataColumn("FIRST_INV_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnFIRST_INV_DATE);
			columnAVERAGE_PAY_DAYS = new DataColumn("AVERAGE_PAY_DAYS", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAVERAGE_PAY_DAYS);
			columnLAST_INV_DATE = new DataColumn("LAST_INV_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLAST_INV_DATE);
			columnBALANCE = new DataColumn("BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE);
			columnTURNOVER_MTD = new DataColumn("TURNOVER_MTD", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTURNOVER_MTD);
			columnTURNOVER_YTD = new DataColumn("TURNOVER_YTD", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTURNOVER_YTD);
			columnPRIOR_YEAR = new DataColumn("PRIOR_YEAR", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YEAR);
			columnBANK_NAME = new DataColumn("BANK_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_NAME);
			columnBANK_ADDRESS_1 = new DataColumn("BANK_ADDRESS_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDRESS_1);
			columnBANK_ADDRESS_2 = new DataColumn("BANK_ADDRESS_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDRESS_2);
			columnBANK_ADDRESS_3 = new DataColumn("BANK_ADDRESS_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDRESS_3);
			columnBANK_ADDRESS_4 = new DataColumn("BANK_ADDRESS_4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDRESS_4);
			columnBANK_ADDRESS_5 = new DataColumn("BANK_ADDRESS_5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDRESS_5);
			columnBANK_SORT_CODE = new DataColumn("BANK_SORT_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_SORT_CODE);
			columnBANK_ACCOUNT_NAME = new DataColumn("BANK_ACCOUNT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ACCOUNT_NAME);
			columnBANK_ACCOUNT_NUMBER = new DataColumn("BANK_ACCOUNT_NUMBER", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ACCOUNT_NUMBER);
			columnBANK_IBAN = new DataColumn("BANK_IBAN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_IBAN);
			columnBANK_BIC = new DataColumn("BANK_BIC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_BIC);
			columnBANK_ROLLNUMBER = new DataColumn("BANK_ROLLNUMBER", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ROLLNUMBER);
			columnBANK_ADDITIONALREF1 = new DataColumn("BANK_ADDITIONALREF1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDITIONALREF1);
			columnBANK_ADDITIONALREF2 = new DataColumn("BANK_ADDITIONALREF2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDITIONALREF2);
			columnBANK_ADDITIONALREF3 = new DataColumn("BANK_ADDITIONALREF3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBANK_ADDITIONALREF3);
			columnDEFAULT_FUND_ID = new DataColumn("DEFAULT_FUND_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnDEFAULT_FUND_ID);
			columnGIFT_AID = new DataColumn("GIFT_AID", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnGIFT_AID);
			columnINVOICE_BF = new DataColumn("INVOICE_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_BF);
			columnINVOICE_MTH1 = new DataColumn("INVOICE_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH1);
			columnINVOICE_MTH2 = new DataColumn("INVOICE_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH2);
			columnINVOICE_MTH3 = new DataColumn("INVOICE_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH3);
			columnINVOICE_MTH4 = new DataColumn("INVOICE_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH4);
			columnINVOICE_MTH5 = new DataColumn("INVOICE_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH5);
			columnINVOICE_MTH6 = new DataColumn("INVOICE_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH6);
			columnINVOICE_MTH7 = new DataColumn("INVOICE_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH7);
			columnINVOICE_MTH8 = new DataColumn("INVOICE_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH8);
			columnINVOICE_MTH9 = new DataColumn("INVOICE_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH9);
			columnINVOICE_MTH10 = new DataColumn("INVOICE_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH10);
			columnINVOICE_MTH11 = new DataColumn("INVOICE_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH11);
			columnINVOICE_MTH12 = new DataColumn("INVOICE_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_MTH12);
			columnINVOICE_CF = new DataColumn("INVOICE_CF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnINVOICE_CF);
			columnCREDIT_BF = new DataColumn("CREDIT_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_BF);
			columnCREDIT_MTH1 = new DataColumn("CREDIT_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH1);
			columnCREDIT_MTH2 = new DataColumn("CREDIT_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH2);
			columnCREDIT_MTH3 = new DataColumn("CREDIT_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH3);
			columnCREDIT_MTH4 = new DataColumn("CREDIT_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH4);
			columnCREDIT_MTH5 = new DataColumn("CREDIT_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH5);
			columnCREDIT_MTH6 = new DataColumn("CREDIT_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH6);
			columnCREDIT_MTH7 = new DataColumn("CREDIT_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH7);
			columnCREDIT_MTH8 = new DataColumn("CREDIT_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH8);
			columnCREDIT_MTH9 = new DataColumn("CREDIT_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH9);
			columnCREDIT_MTH10 = new DataColumn("CREDIT_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH10);
			columnCREDIT_MTH11 = new DataColumn("CREDIT_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH11);
			columnCREDIT_MTH12 = new DataColumn("CREDIT_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_MTH12);
			columnCREDIT_CF = new DataColumn("CREDIT_CF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_CF);
			columnPAYMENT_BF = new DataColumn("PAYMENT_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_BF);
			columnPAYMENT_MTH1 = new DataColumn("PAYMENT_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH1);
			columnPAYMENT_MTH2 = new DataColumn("PAYMENT_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH2);
			columnPAYMENT_MTH3 = new DataColumn("PAYMENT_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH3);
			columnPAYMENT_MTH4 = new DataColumn("PAYMENT_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH4);
			columnPAYMENT_MTH5 = new DataColumn("PAYMENT_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH5);
			columnPAYMENT_MTH6 = new DataColumn("PAYMENT_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH6);
			columnPAYMENT_MTH7 = new DataColumn("PAYMENT_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH7);
			columnPAYMENT_MTH8 = new DataColumn("PAYMENT_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH8);
			columnPAYMENT_MTH9 = new DataColumn("PAYMENT_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH9);
			columnPAYMENT_MTH10 = new DataColumn("PAYMENT_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH10);
			columnPAYMENT_MTH11 = new DataColumn("PAYMENT_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH11);
			columnPAYMENT_MTH12 = new DataColumn("PAYMENT_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_MTH12);
			columnPAYMENT_CF = new DataColumn("PAYMENT_CF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_CF);
			columnDUNS_NUMBER = new DataColumn("DUNS_NUMBER", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDUNS_NUMBER);
			columnPRIORITY = new DataColumn("PRIORITY", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnPRIORITY);
			columnPROMISED_PAYMENT = new DataColumn("PROMISED_PAYMENT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPROMISED_PAYMENT);
			columnPROMISED_PAYMENT_DATE = new DataColumn("PROMISED_PAYMENT_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnPROMISED_PAYMENT_DATE);
			columnREPORT_PASSWORD = new DataColumn("REPORT_PASSWORD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnREPORT_PASSWORD);
			columnLETTERS_VIA_EMAIL = new DataColumn("LETTERS_VIA_EMAIL", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnLETTERS_VIA_EMAIL);
			columnPAYMENT_METHOD_ID = new DataColumn("PAYMENT_METHOD_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnPAYMENT_METHOD_ID);
			columnRECORD_CREATE_DATE = new DataColumn("RECORD_CREATE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_CREATE_DATE);
			columnRECORD_MODIFY_DATE = new DataColumn("RECORD_MODIFY_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_MODIFY_DATE);
			columnRECORD_DELETED = new DataColumn("RECORD_DELETED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRECORD_DELETED);
			columnEU_MEMBER = new DataColumn("EU_MEMBER", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnEU_MEMBER);
			columnCOUNTRY_NAME = new DataColumn("COUNTRY_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOUNTRY_NAME);
			columnACCOUNT_REF.MaxLength = 8;
			columnNAME.MaxLength = 60;
			columnADDRESS_1.MaxLength = 60;
			columnADDRESS_2.MaxLength = 60;
			columnADDRESS_3.MaxLength = 60;
			columnADDRESS_4.MaxLength = 60;
			columnADDRESS_5.MaxLength = 60;
			columnC_ADDRESS_1.MaxLength = 60;
			columnC_ADDRESS_2.MaxLength = 60;
			columnC_ADDRESS_3.MaxLength = 60;
			columnC_ADDRESS_4.MaxLength = 60;
			columnC_ADDRESS_5.MaxLength = 60;
			columnCONTACT_NAME.MaxLength = 30;
			columnTELEPHONE.MaxLength = 30;
			columnTELEPHONE_2.MaxLength = 30;
			columnFAX.MaxLength = 30;
			columnE_MAIL.MaxLength = 255;
			columnWEB_ADDRESS.MaxLength = 255;
			columnTRADE_CONTACT.MaxLength = 30;
			columnDEL_NAME.MaxLength = 60;
			columnDEL_ADDRESS_1.MaxLength = 60;
			columnDEL_ADDRESS_2.MaxLength = 60;
			columnDEL_ADDRESS_3.MaxLength = 60;
			columnDEL_ADDRESS_4.MaxLength = 60;
			columnDEL_ADDRESS_5.MaxLength = 60;
			columnDEL_CONTACT_NAME.MaxLength = 30;
			columnDEL_TELEPHONE.MaxLength = 30;
			columnDEL_FAX.MaxLength = 30;
			columnANALYSIS_1.MaxLength = 30;
			columnANALYSIS_2.MaxLength = 30;
			columnANALYSIS_3.MaxLength = 30;
			columnDEPT_NAME.MaxLength = 60;
			columnSTATUS_TEXT.MaxLength = 60;
			columnDEF_TAX_CODE.MaxLength = 3;
			columnDEF_NOM_CODE.MaxLength = 8;
			columnVAT_REG_NUMBER.MaxLength = 30;
			columnCURRENCY.AllowDBNull = false;
			columnCOUNTRY_CODE.MaxLength = 2;
			columnDISCOUNT_TYPE.AllowDBNull = false;
			columnPRICING_REF.MaxLength = 8;
			columnACCOUNT_ON_HOLD.AllowDBNull = false;
			columnTERMS.MaxLength = 30;
			columnCREDIT_POSITION.MaxLength = 19;
			columnBACS_REF.MaxLength = 60;
			columnCREDIT_REF.MaxLength = 60;
			columnOVERRIDE_TAX_CODE.AllowDBNull = false;
			columnBANK_NAME.MaxLength = 60;
			columnBANK_ADDRESS_1.MaxLength = 60;
			columnBANK_ADDRESS_2.MaxLength = 60;
			columnBANK_ADDRESS_3.MaxLength = 60;
			columnBANK_ADDRESS_4.MaxLength = 60;
			columnBANK_ADDRESS_5.MaxLength = 60;
			columnBANK_SORT_CODE.MaxLength = 10;
			columnBANK_ACCOUNT_NAME.MaxLength = 60;
			columnBANK_ACCOUNT_NUMBER.MaxLength = 60;
			columnBANK_IBAN.MaxLength = 60;
			columnBANK_BIC.MaxLength = 60;
			columnBANK_ROLLNUMBER.MaxLength = 60;
			columnBANK_ADDITIONALREF1.MaxLength = 60;
			columnBANK_ADDITIONALREF2.MaxLength = 60;
			columnBANK_ADDITIONALREF3.MaxLength = 60;
			columnDUNS_NUMBER.MaxLength = 9;
			columnREPORT_PASSWORD.MaxLength = 31;
			columnCOUNTRY_NAME.MaxLength = 30;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListRow NewCustomersListRow()
		{
			return (CustomersListRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new CustomersListRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(CustomersListRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (CustomersListRowChanged != null)
			{
				CustomersListRowChanged?.Invoke(this, new CustomersListRowChangeEvent((CustomersListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (CustomersListRowChanging != null)
			{
				CustomersListRowChanging?.Invoke(this, new CustomersListRowChangeEvent((CustomersListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (CustomersListRowDeleted != null)
			{
				CustomersListRowDeleted?.Invoke(this, new CustomersListRowChangeEvent((CustomersListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (CustomersListRowDeleting != null)
			{
				CustomersListRowDeleting?.Invoke(this, new CustomersListRowChangeEvent((CustomersListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveCustomersListRow(CustomersListRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Customers customers = new Customers();
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
			xmlSchemaAttribute.FixedValue = customers.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "CustomersListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = customers.GetSchemaSerializable();
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
	public class CustomersListRow : DataRow
	{
		private CustomersListDataTable tableCustomersList;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ACCOUNT_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ACCOUNT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCOUNT_REF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ACCOUNT_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ADDRESS_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ADDRESS_1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ADDRESS_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ADDRESS_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ADDRESS_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ADDRESS_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ADDRESS_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ADDRESS_3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ADDRESS_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS_4
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ADDRESS_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ADDRESS_4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ADDRESS_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS_5
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ADDRESS_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ADDRESS_5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ADDRESS_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string C_ADDRESS_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.C_ADDRESS_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'C_ADDRESS_1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.C_ADDRESS_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string C_ADDRESS_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.C_ADDRESS_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'C_ADDRESS_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.C_ADDRESS_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string C_ADDRESS_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.C_ADDRESS_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'C_ADDRESS_3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.C_ADDRESS_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string C_ADDRESS_4
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.C_ADDRESS_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'C_ADDRESS_4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.C_ADDRESS_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string C_ADDRESS_5
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.C_ADDRESS_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'C_ADDRESS_5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.C_ADDRESS_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CONTACT_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.CONTACT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CONTACT_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CONTACT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TELEPHONE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.TELEPHONEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TELEPHONE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TELEPHONEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TELEPHONE_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.TELEPHONE_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TELEPHONE_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TELEPHONE_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FAX
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.FAXColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FAX' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.FAXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string E_MAIL
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.E_MAILColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'E_MAIL' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.E_MAILColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_ADDRESS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.WEB_ADDRESSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_ADDRESS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.WEB_ADDRESSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TRADE_CONTACT
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.TRADE_CONTACTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TRADE_CONTACT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TRADE_CONTACTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_ADDRESS_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_ADDRESS_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_ADDRESS_1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_ADDRESS_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_ADDRESS_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_ADDRESS_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_ADDRESS_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_ADDRESS_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_ADDRESS_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_ADDRESS_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_ADDRESS_3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_ADDRESS_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_ADDRESS_4
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_ADDRESS_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_ADDRESS_4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_ADDRESS_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_ADDRESS_5
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_ADDRESS_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_ADDRESS_5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_ADDRESS_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_CONTACT_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_CONTACT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_CONTACT_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_CONTACT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_TELEPHONE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_TELEPHONEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_TELEPHONE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_TELEPHONEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEL_FAX
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEL_FAXColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEL_FAX' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEL_FAXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ANALYSIS_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ANALYSIS_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ANALYSIS_1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ANALYSIS_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ANALYSIS_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ANALYSIS_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ANALYSIS_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ANALYSIS_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ANALYSIS_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.ANALYSIS_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ANALYSIS_3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.ANALYSIS_3Column] = value;
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
					return Conversions.ToShort(base[tableCustomersList.DEPT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEPT_NUMBERColumn] = value;
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
					return Conversions.ToString(base[tableCustomersList.DEPT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEPT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short STATUS_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.STATUS_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STATUS_NUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.STATUS_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string STATUS_TEXT
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.STATUS_TEXTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STATUS_TEXT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.STATUS_TEXTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEF_TAX_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEF_TAX_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEF_TAX_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEF_TAX_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEF_NOM_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DEF_NOM_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEF_NOM_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEF_NOM_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string VAT_REG_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.VAT_REG_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_REG_NUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.VAT_REG_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CURRENCY
		{
			get
			{
				return Conversions.ToShort(base[tableCustomersList.CURRENCYColumn]);
			}
			set
			{
				base[tableCustomersList.CURRENCYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COUNTRY_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.COUNTRY_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COUNTRY_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.COUNTRY_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short DISCOUNT_TYPE
		{
			get
			{
				return Conversions.ToShort(base[tableCustomersList.DISCOUNT_TYPEColumn]);
			}
			set
			{
				base[tableCustomersList.DISCOUNT_TYPEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISCOUNT_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.DISCOUNT_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISCOUNT_RATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DISCOUNT_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PRICING_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.PRICING_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRICING_REF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PRICING_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SETTLEMENT_DISC_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.SETTLEMENT_DISC_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SETTLEMENT_DISC_RATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.SETTLEMENT_DISC_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short SETTLEMENT_DUE_DAYS
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.SETTLEMENT_DUE_DAYSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SETTLEMENT_DUE_DAYS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.SETTLEMENT_DUE_DAYSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short PAYMENT_DUE_DAYS
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.PAYMENT_DUE_DAYSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_DUE_DAYS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_DUE_DAYSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_LIMIT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_LIMITColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_LIMIT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_LIMITColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short ACCOUNT_ON_HOLD
		{
			get
			{
				return Conversions.ToShort(base[tableCustomersList.ACCOUNT_ON_HOLDColumn]);
			}
			set
			{
				base[tableCustomersList.ACCOUNT_ON_HOLDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TERMS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.TERMSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TERMS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TERMSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short RESTRICT_MAIL
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.RESTRICT_MAILColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RESTRICT_MAIL' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.RESTRICT_MAILColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short TERMS_AGREED
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.TERMS_AGREEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TERMS_AGREED' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TERMS_AGREEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_ACCOUNT_OPENED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.DATE_ACCOUNT_OPENEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_ACCOUNT_OPENED' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DATE_ACCOUNT_OPENEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_NEXT_CREDIT
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.DATE_NEXT_CREDITColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_NEXT_CREDIT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DATE_NEXT_CREDITColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_LAST_CREDIT
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.DATE_LAST_CREDITColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_LAST_CREDIT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DATE_LAST_CREDITColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CREDIT_POSITION
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.CREDIT_POSITIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_POSITION' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_POSITIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CREDIT_POS_CODE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.CREDIT_POS_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_POS_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_POS_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short CAN_CHARGE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.CAN_CHARGEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CAN_CHARGE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CAN_CHARGEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short USE_BACS
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.USE_BACSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'USE_BACS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.USE_BACSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BACS_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BACS_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BACS_REF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BACS_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short BUREAU_CODE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.BUREAU_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUREAU_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BUREAU_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CREDIT_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.CREDIT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_REF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_CREDIT_APPLIED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.DATE_CREDIT_APPLIEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_CREDIT_APPLIED' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DATE_CREDIT_APPLIEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DATE_CREDIT_RECEIVED
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.DATE_CREDIT_RECEIVEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_CREDIT_RECEIVED' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DATE_CREDIT_RECEIVEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short OVERRIDE_TAX_CODE
		{
			get
			{
				return Conversions.ToShort(base[tableCustomersList.OVERRIDE_TAX_CODEColumn]);
			}
			set
			{
				base[tableCustomersList.OVERRIDE_TAX_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime LAST_PAYMENT_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.LAST_PAYMENT_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_PAYMENT_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.LAST_PAYMENT_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime FIRST_INV_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.FIRST_INV_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'FIRST_INV_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.FIRST_INV_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AVERAGE_PAY_DAYS
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.AVERAGE_PAY_DAYSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AVERAGE_PAY_DAYS' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.AVERAGE_PAY_DAYSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime LAST_INV_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.LAST_INV_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_INV_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.LAST_INV_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TURNOVER_MTD
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.TURNOVER_MTDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TURNOVER_MTD' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TURNOVER_MTDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TURNOVER_YTD
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.TURNOVER_YTDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TURNOVER_YTD' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.TURNOVER_YTDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YEAR
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PRIOR_YEARColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YEAR' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PRIOR_YEARColumn] = value;
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
					return Conversions.ToString(base[tableCustomersList.BANK_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDRESS_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDRESS_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDRESS_1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDRESS_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDRESS_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDRESS_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDRESS_2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDRESS_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDRESS_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDRESS_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDRESS_3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDRESS_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDRESS_4
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDRESS_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDRESS_4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDRESS_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDRESS_5
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDRESS_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDRESS_5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDRESS_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_SORT_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_SORT_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_SORT_CODE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_SORT_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ACCOUNT_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ACCOUNT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ACCOUNT_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ACCOUNT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ACCOUNT_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ACCOUNT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ACCOUNT_NUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ACCOUNT_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_IBAN
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_IBANColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_IBAN' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_IBANColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_BIC
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_BICColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_BIC' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_BICColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ROLLNUMBER
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ROLLNUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ROLLNUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ROLLNUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDITIONALREF1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDITIONALREF1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDITIONALREF1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDITIONALREF1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDITIONALREF2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDITIONALREF2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDITIONALREF2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDITIONALREF2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BANK_ADDITIONALREF3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.BANK_ADDITIONALREF3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BANK_ADDITIONALREF3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.BANK_ADDITIONALREF3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int DEFAULT_FUND_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableCustomersList.DEFAULT_FUND_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEFAULT_FUND_ID' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DEFAULT_FUND_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short GIFT_AID
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.GIFT_AIDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'GIFT_AID' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.GIFT_AIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_BF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH6' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH7' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH8' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH9' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH10' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH11' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_MTH12' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double INVOICE_CF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.INVOICE_CFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INVOICE_CF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.INVOICE_CFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_BF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH6' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH7' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH8' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH9' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH10' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH11' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH12' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_CF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.CREDIT_CFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_CF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.CREDIT_CFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_BF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH1' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH2' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH3' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH4' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH5' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH6' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH7' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH8' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH9' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH10' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH11' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_MTH12' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PAYMENT_CF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PAYMENT_CFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_CF' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_CFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DUNS_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.DUNS_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DUNS_NUMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.DUNS_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short PRIORITY
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.PRIORITYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIORITY' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PRIORITYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PROMISED_PAYMENT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableCustomersList.PROMISED_PAYMENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PROMISED_PAYMENT' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PROMISED_PAYMENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime PROMISED_PAYMENT_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableCustomersList.PROMISED_PAYMENT_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PROMISED_PAYMENT_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PROMISED_PAYMENT_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string REPORT_PASSWORD
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.REPORT_PASSWORDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'REPORT_PASSWORD' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.REPORT_PASSWORDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short LETTERS_VIA_EMAIL
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.LETTERS_VIA_EMAILColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LETTERS_VIA_EMAIL' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.LETTERS_VIA_EMAILColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int PAYMENT_METHOD_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableCustomersList.PAYMENT_METHOD_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PAYMENT_METHOD_ID' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.PAYMENT_METHOD_IDColumn] = value;
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
					return Conversions.ToDate(base[tableCustomersList.RECORD_CREATE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_CREATE_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.RECORD_CREATE_DATEColumn] = value;
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
					return Conversions.ToDate(base[tableCustomersList.RECORD_MODIFY_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_MODIFY_DATE' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.RECORD_MODIFY_DATEColumn] = value;
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
					return Conversions.ToShort(base[tableCustomersList.RECORD_DELETEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_DELETED' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.RECORD_DELETEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short EU_MEMBER
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableCustomersList.EU_MEMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'EU_MEMBER' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.EU_MEMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COUNTRY_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableCustomersList.COUNTRY_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COUNTRY_NAME' in table 'CustomersList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableCustomersList.COUNTRY_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal CustomersListRow(DataRowBuilder rb)
			: base(rb)
		{
			tableCustomersList = (CustomersListDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCOUNT_REFNull()
		{
			return IsNull(tableCustomersList.ACCOUNT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCOUNT_REFNull()
		{
			base[tableCustomersList.ACCOUNT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNAMENull()
		{
			return IsNull(tableCustomersList.NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNAMENull()
		{
			base[tableCustomersList.NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsADDRESS_1Null()
		{
			return IsNull(tableCustomersList.ADDRESS_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESS_1Null()
		{
			base[tableCustomersList.ADDRESS_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsADDRESS_2Null()
		{
			return IsNull(tableCustomersList.ADDRESS_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESS_2Null()
		{
			base[tableCustomersList.ADDRESS_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsADDRESS_3Null()
		{
			return IsNull(tableCustomersList.ADDRESS_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESS_3Null()
		{
			base[tableCustomersList.ADDRESS_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsADDRESS_4Null()
		{
			return IsNull(tableCustomersList.ADDRESS_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESS_4Null()
		{
			base[tableCustomersList.ADDRESS_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsADDRESS_5Null()
		{
			return IsNull(tableCustomersList.ADDRESS_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESS_5Null()
		{
			base[tableCustomersList.ADDRESS_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsC_ADDRESS_1Null()
		{
			return IsNull(tableCustomersList.C_ADDRESS_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetC_ADDRESS_1Null()
		{
			base[tableCustomersList.C_ADDRESS_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsC_ADDRESS_2Null()
		{
			return IsNull(tableCustomersList.C_ADDRESS_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetC_ADDRESS_2Null()
		{
			base[tableCustomersList.C_ADDRESS_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsC_ADDRESS_3Null()
		{
			return IsNull(tableCustomersList.C_ADDRESS_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetC_ADDRESS_3Null()
		{
			base[tableCustomersList.C_ADDRESS_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsC_ADDRESS_4Null()
		{
			return IsNull(tableCustomersList.C_ADDRESS_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetC_ADDRESS_4Null()
		{
			base[tableCustomersList.C_ADDRESS_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsC_ADDRESS_5Null()
		{
			return IsNull(tableCustomersList.C_ADDRESS_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetC_ADDRESS_5Null()
		{
			base[tableCustomersList.C_ADDRESS_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCONTACT_NAMENull()
		{
			return IsNull(tableCustomersList.CONTACT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCONTACT_NAMENull()
		{
			base[tableCustomersList.CONTACT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTELEPHONENull()
		{
			return IsNull(tableCustomersList.TELEPHONEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTELEPHONENull()
		{
			base[tableCustomersList.TELEPHONEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTELEPHONE_2Null()
		{
			return IsNull(tableCustomersList.TELEPHONE_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTELEPHONE_2Null()
		{
			base[tableCustomersList.TELEPHONE_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFAXNull()
		{
			return IsNull(tableCustomersList.FAXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFAXNull()
		{
			base[tableCustomersList.FAXColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsE_MAILNull()
		{
			return IsNull(tableCustomersList.E_MAILColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetE_MAILNull()
		{
			base[tableCustomersList.E_MAILColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_ADDRESSNull()
		{
			return IsNull(tableCustomersList.WEB_ADDRESSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_ADDRESSNull()
		{
			base[tableCustomersList.WEB_ADDRESSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTRADE_CONTACTNull()
		{
			return IsNull(tableCustomersList.TRADE_CONTACTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTRADE_CONTACTNull()
		{
			base[tableCustomersList.TRADE_CONTACTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_NAMENull()
		{
			return IsNull(tableCustomersList.DEL_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_NAMENull()
		{
			base[tableCustomersList.DEL_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_ADDRESS_1Null()
		{
			return IsNull(tableCustomersList.DEL_ADDRESS_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_ADDRESS_1Null()
		{
			base[tableCustomersList.DEL_ADDRESS_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_ADDRESS_2Null()
		{
			return IsNull(tableCustomersList.DEL_ADDRESS_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_ADDRESS_2Null()
		{
			base[tableCustomersList.DEL_ADDRESS_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_ADDRESS_3Null()
		{
			return IsNull(tableCustomersList.DEL_ADDRESS_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_ADDRESS_3Null()
		{
			base[tableCustomersList.DEL_ADDRESS_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_ADDRESS_4Null()
		{
			return IsNull(tableCustomersList.DEL_ADDRESS_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_ADDRESS_4Null()
		{
			base[tableCustomersList.DEL_ADDRESS_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_ADDRESS_5Null()
		{
			return IsNull(tableCustomersList.DEL_ADDRESS_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_ADDRESS_5Null()
		{
			base[tableCustomersList.DEL_ADDRESS_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_CONTACT_NAMENull()
		{
			return IsNull(tableCustomersList.DEL_CONTACT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_CONTACT_NAMENull()
		{
			base[tableCustomersList.DEL_CONTACT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_TELEPHONENull()
		{
			return IsNull(tableCustomersList.DEL_TELEPHONEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_TELEPHONENull()
		{
			base[tableCustomersList.DEL_TELEPHONEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEL_FAXNull()
		{
			return IsNull(tableCustomersList.DEL_FAXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEL_FAXNull()
		{
			base[tableCustomersList.DEL_FAXColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsANALYSIS_1Null()
		{
			return IsNull(tableCustomersList.ANALYSIS_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetANALYSIS_1Null()
		{
			base[tableCustomersList.ANALYSIS_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsANALYSIS_2Null()
		{
			return IsNull(tableCustomersList.ANALYSIS_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetANALYSIS_2Null()
		{
			base[tableCustomersList.ANALYSIS_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsANALYSIS_3Null()
		{
			return IsNull(tableCustomersList.ANALYSIS_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetANALYSIS_3Null()
		{
			base[tableCustomersList.ANALYSIS_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NUMBERNull()
		{
			return IsNull(tableCustomersList.DEPT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NUMBERNull()
		{
			base[tableCustomersList.DEPT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NAMENull()
		{
			return IsNull(tableCustomersList.DEPT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NAMENull()
		{
			base[tableCustomersList.DEPT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTATUS_NUMBERNull()
		{
			return IsNull(tableCustomersList.STATUS_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTATUS_NUMBERNull()
		{
			base[tableCustomersList.STATUS_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTATUS_TEXTNull()
		{
			return IsNull(tableCustomersList.STATUS_TEXTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTATUS_TEXTNull()
		{
			base[tableCustomersList.STATUS_TEXTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEF_TAX_CODENull()
		{
			return IsNull(tableCustomersList.DEF_TAX_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEF_TAX_CODENull()
		{
			base[tableCustomersList.DEF_TAX_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEF_NOM_CODENull()
		{
			return IsNull(tableCustomersList.DEF_NOM_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEF_NOM_CODENull()
		{
			base[tableCustomersList.DEF_NOM_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_REG_NUMBERNull()
		{
			return IsNull(tableCustomersList.VAT_REG_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_REG_NUMBERNull()
		{
			base[tableCustomersList.VAT_REG_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOUNTRY_CODENull()
		{
			return IsNull(tableCustomersList.COUNTRY_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOUNTRY_CODENull()
		{
			base[tableCustomersList.COUNTRY_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISCOUNT_RATENull()
		{
			return IsNull(tableCustomersList.DISCOUNT_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISCOUNT_RATENull()
		{
			base[tableCustomersList.DISCOUNT_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRICING_REFNull()
		{
			return IsNull(tableCustomersList.PRICING_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRICING_REFNull()
		{
			base[tableCustomersList.PRICING_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSETTLEMENT_DISC_RATENull()
		{
			return IsNull(tableCustomersList.SETTLEMENT_DISC_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSETTLEMENT_DISC_RATENull()
		{
			base[tableCustomersList.SETTLEMENT_DISC_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSETTLEMENT_DUE_DAYSNull()
		{
			return IsNull(tableCustomersList.SETTLEMENT_DUE_DAYSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSETTLEMENT_DUE_DAYSNull()
		{
			base[tableCustomersList.SETTLEMENT_DUE_DAYSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_DUE_DAYSNull()
		{
			return IsNull(tableCustomersList.PAYMENT_DUE_DAYSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_DUE_DAYSNull()
		{
			base[tableCustomersList.PAYMENT_DUE_DAYSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_LIMITNull()
		{
			return IsNull(tableCustomersList.CREDIT_LIMITColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_LIMITNull()
		{
			base[tableCustomersList.CREDIT_LIMITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTERMSNull()
		{
			return IsNull(tableCustomersList.TERMSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTERMSNull()
		{
			base[tableCustomersList.TERMSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRESTRICT_MAILNull()
		{
			return IsNull(tableCustomersList.RESTRICT_MAILColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRESTRICT_MAILNull()
		{
			base[tableCustomersList.RESTRICT_MAILColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTERMS_AGREEDNull()
		{
			return IsNull(tableCustomersList.TERMS_AGREEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTERMS_AGREEDNull()
		{
			base[tableCustomersList.TERMS_AGREEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_ACCOUNT_OPENEDNull()
		{
			return IsNull(tableCustomersList.DATE_ACCOUNT_OPENEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_ACCOUNT_OPENEDNull()
		{
			base[tableCustomersList.DATE_ACCOUNT_OPENEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_NEXT_CREDITNull()
		{
			return IsNull(tableCustomersList.DATE_NEXT_CREDITColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_NEXT_CREDITNull()
		{
			base[tableCustomersList.DATE_NEXT_CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_LAST_CREDITNull()
		{
			return IsNull(tableCustomersList.DATE_LAST_CREDITColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_LAST_CREDITNull()
		{
			base[tableCustomersList.DATE_LAST_CREDITColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_POSITIONNull()
		{
			return IsNull(tableCustomersList.CREDIT_POSITIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_POSITIONNull()
		{
			base[tableCustomersList.CREDIT_POSITIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_POS_CODENull()
		{
			return IsNull(tableCustomersList.CREDIT_POS_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_POS_CODENull()
		{
			base[tableCustomersList.CREDIT_POS_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCAN_CHARGENull()
		{
			return IsNull(tableCustomersList.CAN_CHARGEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCAN_CHARGENull()
		{
			base[tableCustomersList.CAN_CHARGEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUSE_BACSNull()
		{
			return IsNull(tableCustomersList.USE_BACSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUSE_BACSNull()
		{
			base[tableCustomersList.USE_BACSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBACS_REFNull()
		{
			return IsNull(tableCustomersList.BACS_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBACS_REFNull()
		{
			base[tableCustomersList.BACS_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUREAU_CODENull()
		{
			return IsNull(tableCustomersList.BUREAU_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUREAU_CODENull()
		{
			base[tableCustomersList.BUREAU_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_REFNull()
		{
			return IsNull(tableCustomersList.CREDIT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_REFNull()
		{
			base[tableCustomersList.CREDIT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_CREDIT_APPLIEDNull()
		{
			return IsNull(tableCustomersList.DATE_CREDIT_APPLIEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_CREDIT_APPLIEDNull()
		{
			base[tableCustomersList.DATE_CREDIT_APPLIEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_CREDIT_RECEIVEDNull()
		{
			return IsNull(tableCustomersList.DATE_CREDIT_RECEIVEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_CREDIT_RECEIVEDNull()
		{
			base[tableCustomersList.DATE_CREDIT_RECEIVEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_PAYMENT_DATENull()
		{
			return IsNull(tableCustomersList.LAST_PAYMENT_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_PAYMENT_DATENull()
		{
			base[tableCustomersList.LAST_PAYMENT_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFIRST_INV_DATENull()
		{
			return IsNull(tableCustomersList.FIRST_INV_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFIRST_INV_DATENull()
		{
			base[tableCustomersList.FIRST_INV_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAVERAGE_PAY_DAYSNull()
		{
			return IsNull(tableCustomersList.AVERAGE_PAY_DAYSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAVERAGE_PAY_DAYSNull()
		{
			base[tableCustomersList.AVERAGE_PAY_DAYSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_INV_DATENull()
		{
			return IsNull(tableCustomersList.LAST_INV_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_INV_DATENull()
		{
			base[tableCustomersList.LAST_INV_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCENull()
		{
			return IsNull(tableCustomersList.BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCENull()
		{
			base[tableCustomersList.BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTURNOVER_MTDNull()
		{
			return IsNull(tableCustomersList.TURNOVER_MTDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTURNOVER_MTDNull()
		{
			base[tableCustomersList.TURNOVER_MTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTURNOVER_YTDNull()
		{
			return IsNull(tableCustomersList.TURNOVER_YTDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTURNOVER_YTDNull()
		{
			base[tableCustomersList.TURNOVER_YTDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YEARNull()
		{
			return IsNull(tableCustomersList.PRIOR_YEARColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YEARNull()
		{
			base[tableCustomersList.PRIOR_YEARColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_NAMENull()
		{
			return IsNull(tableCustomersList.BANK_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_NAMENull()
		{
			base[tableCustomersList.BANK_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDRESS_1Null()
		{
			return IsNull(tableCustomersList.BANK_ADDRESS_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDRESS_1Null()
		{
			base[tableCustomersList.BANK_ADDRESS_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDRESS_2Null()
		{
			return IsNull(tableCustomersList.BANK_ADDRESS_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDRESS_2Null()
		{
			base[tableCustomersList.BANK_ADDRESS_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDRESS_3Null()
		{
			return IsNull(tableCustomersList.BANK_ADDRESS_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDRESS_3Null()
		{
			base[tableCustomersList.BANK_ADDRESS_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDRESS_4Null()
		{
			return IsNull(tableCustomersList.BANK_ADDRESS_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDRESS_4Null()
		{
			base[tableCustomersList.BANK_ADDRESS_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDRESS_5Null()
		{
			return IsNull(tableCustomersList.BANK_ADDRESS_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDRESS_5Null()
		{
			base[tableCustomersList.BANK_ADDRESS_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_SORT_CODENull()
		{
			return IsNull(tableCustomersList.BANK_SORT_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_SORT_CODENull()
		{
			base[tableCustomersList.BANK_SORT_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ACCOUNT_NAMENull()
		{
			return IsNull(tableCustomersList.BANK_ACCOUNT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ACCOUNT_NAMENull()
		{
			base[tableCustomersList.BANK_ACCOUNT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ACCOUNT_NUMBERNull()
		{
			return IsNull(tableCustomersList.BANK_ACCOUNT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ACCOUNT_NUMBERNull()
		{
			base[tableCustomersList.BANK_ACCOUNT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_IBANNull()
		{
			return IsNull(tableCustomersList.BANK_IBANColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_IBANNull()
		{
			base[tableCustomersList.BANK_IBANColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_BICNull()
		{
			return IsNull(tableCustomersList.BANK_BICColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_BICNull()
		{
			base[tableCustomersList.BANK_BICColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ROLLNUMBERNull()
		{
			return IsNull(tableCustomersList.BANK_ROLLNUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ROLLNUMBERNull()
		{
			base[tableCustomersList.BANK_ROLLNUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDITIONALREF1Null()
		{
			return IsNull(tableCustomersList.BANK_ADDITIONALREF1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDITIONALREF1Null()
		{
			base[tableCustomersList.BANK_ADDITIONALREF1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDITIONALREF2Null()
		{
			return IsNull(tableCustomersList.BANK_ADDITIONALREF2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDITIONALREF2Null()
		{
			base[tableCustomersList.BANK_ADDITIONALREF2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBANK_ADDITIONALREF3Null()
		{
			return IsNull(tableCustomersList.BANK_ADDITIONALREF3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBANK_ADDITIONALREF3Null()
		{
			base[tableCustomersList.BANK_ADDITIONALREF3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEFAULT_FUND_IDNull()
		{
			return IsNull(tableCustomersList.DEFAULT_FUND_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEFAULT_FUND_IDNull()
		{
			base[tableCustomersList.DEFAULT_FUND_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGIFT_AIDNull()
		{
			return IsNull(tableCustomersList.GIFT_AIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetGIFT_AIDNull()
		{
			base[tableCustomersList.GIFT_AIDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_BFNull()
		{
			return IsNull(tableCustomersList.INVOICE_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_BFNull()
		{
			base[tableCustomersList.INVOICE_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH1Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH1Null()
		{
			base[tableCustomersList.INVOICE_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH2Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH2Null()
		{
			base[tableCustomersList.INVOICE_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH3Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH3Null()
		{
			base[tableCustomersList.INVOICE_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH4Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH4Null()
		{
			base[tableCustomersList.INVOICE_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH5Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH5Null()
		{
			base[tableCustomersList.INVOICE_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH6Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH6Null()
		{
			base[tableCustomersList.INVOICE_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH7Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH7Null()
		{
			base[tableCustomersList.INVOICE_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH8Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH8Null()
		{
			base[tableCustomersList.INVOICE_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH9Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH9Null()
		{
			base[tableCustomersList.INVOICE_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH10Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH10Null()
		{
			base[tableCustomersList.INVOICE_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH11Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH11Null()
		{
			base[tableCustomersList.INVOICE_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_MTH12Null()
		{
			return IsNull(tableCustomersList.INVOICE_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_MTH12Null()
		{
			base[tableCustomersList.INVOICE_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINVOICE_CFNull()
		{
			return IsNull(tableCustomersList.INVOICE_CFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINVOICE_CFNull()
		{
			base[tableCustomersList.INVOICE_CFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_BFNull()
		{
			return IsNull(tableCustomersList.CREDIT_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_BFNull()
		{
			base[tableCustomersList.CREDIT_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH1Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH1Null()
		{
			base[tableCustomersList.CREDIT_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH2Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH2Null()
		{
			base[tableCustomersList.CREDIT_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH3Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH3Null()
		{
			base[tableCustomersList.CREDIT_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH4Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH4Null()
		{
			base[tableCustomersList.CREDIT_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH5Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH5Null()
		{
			base[tableCustomersList.CREDIT_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH6Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH6Null()
		{
			base[tableCustomersList.CREDIT_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH7Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH7Null()
		{
			base[tableCustomersList.CREDIT_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH8Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH8Null()
		{
			base[tableCustomersList.CREDIT_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH9Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH9Null()
		{
			base[tableCustomersList.CREDIT_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH10Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH10Null()
		{
			base[tableCustomersList.CREDIT_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH11Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH11Null()
		{
			base[tableCustomersList.CREDIT_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH12Null()
		{
			return IsNull(tableCustomersList.CREDIT_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH12Null()
		{
			base[tableCustomersList.CREDIT_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_CFNull()
		{
			return IsNull(tableCustomersList.CREDIT_CFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_CFNull()
		{
			base[tableCustomersList.CREDIT_CFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_BFNull()
		{
			return IsNull(tableCustomersList.PAYMENT_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_BFNull()
		{
			base[tableCustomersList.PAYMENT_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH1Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH1Null()
		{
			base[tableCustomersList.PAYMENT_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH2Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH2Null()
		{
			base[tableCustomersList.PAYMENT_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH3Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH3Null()
		{
			base[tableCustomersList.PAYMENT_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH4Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH4Null()
		{
			base[tableCustomersList.PAYMENT_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH5Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH5Null()
		{
			base[tableCustomersList.PAYMENT_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH6Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH6Null()
		{
			base[tableCustomersList.PAYMENT_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH7Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH7Null()
		{
			base[tableCustomersList.PAYMENT_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH8Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH8Null()
		{
			base[tableCustomersList.PAYMENT_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH9Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH9Null()
		{
			base[tableCustomersList.PAYMENT_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH10Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH10Null()
		{
			base[tableCustomersList.PAYMENT_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH11Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH11Null()
		{
			base[tableCustomersList.PAYMENT_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_MTH12Null()
		{
			return IsNull(tableCustomersList.PAYMENT_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_MTH12Null()
		{
			base[tableCustomersList.PAYMENT_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_CFNull()
		{
			return IsNull(tableCustomersList.PAYMENT_CFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_CFNull()
		{
			base[tableCustomersList.PAYMENT_CFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDUNS_NUMBERNull()
		{
			return IsNull(tableCustomersList.DUNS_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDUNS_NUMBERNull()
		{
			base[tableCustomersList.DUNS_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIORITYNull()
		{
			return IsNull(tableCustomersList.PRIORITYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIORITYNull()
		{
			base[tableCustomersList.PRIORITYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPROMISED_PAYMENTNull()
		{
			return IsNull(tableCustomersList.PROMISED_PAYMENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPROMISED_PAYMENTNull()
		{
			base[tableCustomersList.PROMISED_PAYMENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPROMISED_PAYMENT_DATENull()
		{
			return IsNull(tableCustomersList.PROMISED_PAYMENT_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPROMISED_PAYMENT_DATENull()
		{
			base[tableCustomersList.PROMISED_PAYMENT_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsREPORT_PASSWORDNull()
		{
			return IsNull(tableCustomersList.REPORT_PASSWORDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetREPORT_PASSWORDNull()
		{
			base[tableCustomersList.REPORT_PASSWORDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLETTERS_VIA_EMAILNull()
		{
			return IsNull(tableCustomersList.LETTERS_VIA_EMAILColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLETTERS_VIA_EMAILNull()
		{
			base[tableCustomersList.LETTERS_VIA_EMAILColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPAYMENT_METHOD_IDNull()
		{
			return IsNull(tableCustomersList.PAYMENT_METHOD_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPAYMENT_METHOD_IDNull()
		{
			base[tableCustomersList.PAYMENT_METHOD_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_CREATE_DATENull()
		{
			return IsNull(tableCustomersList.RECORD_CREATE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_CREATE_DATENull()
		{
			base[tableCustomersList.RECORD_CREATE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_MODIFY_DATENull()
		{
			return IsNull(tableCustomersList.RECORD_MODIFY_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_MODIFY_DATENull()
		{
			base[tableCustomersList.RECORD_MODIFY_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_DELETEDNull()
		{
			return IsNull(tableCustomersList.RECORD_DELETEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_DELETEDNull()
		{
			base[tableCustomersList.RECORD_DELETEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsEU_MEMBERNull()
		{
			return IsNull(tableCustomersList.EU_MEMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetEU_MEMBERNull()
		{
			base[tableCustomersList.EU_MEMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOUNTRY_NAMENull()
		{
			return IsNull(tableCustomersList.COUNTRY_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOUNTRY_NAMENull()
		{
			base[tableCustomersList.COUNTRY_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class CustomersListRowChangeEvent : EventArgs
	{
		private CustomersListRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CustomersListRowChangeEvent(CustomersListRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private CustomersListDataTable tableCustomersList;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public CustomersListDataTable CustomersList => tableCustomersList;

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
	public Customers()
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
	protected Customers(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["CustomersList"] != null)
			{
				base.Tables.Add(new CustomersListDataTable(dataSet.Tables["CustomersList"]));
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
		Customers obj = (Customers)base.Clone();
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
			if (dataSet.Tables["CustomersList"] != null)
			{
				base.Tables.Add(new CustomersListDataTable(dataSet.Tables["CustomersList"]));
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
		tableCustomersList = (CustomersListDataTable)base.Tables["CustomersList"];
		if (initTable && tableCustomersList != null)
		{
			tableCustomersList.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "Customers";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Customers.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableCustomersList = new CustomersListDataTable();
		base.Tables.Add(tableCustomersList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeCustomersList()
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
		Customers customers = new Customers();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = customers.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = customers.GetSchemaSerializable();
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
