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
[XmlRoot("Products")]
[HelpKeyword("vs.data.DataSet")]
public class Products : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void ProductsListRowChangeEventHandler(object sender, ProductsListRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class ProductsListDataTable : TypedTableBase<ProductsListRow>
	{
		private DataColumn columnSTOCK_CODE;

		private DataColumn columnDESCRIPTION;

		private DataColumn columnUNIT_OF_SALE;

		private DataColumn columnNOMINAL_CODE;

		private DataColumn columnPURCHASE_REF;

		private DataColumn columnSUPPLIER_PART_NUMBER;

		private DataColumn columnLOCATION;

		private DataColumn columnCOMMODITY_CODE;

		private DataColumn columnSALES_PRICE;

		private DataColumn columnWEB_DESCRIPTION;

		private DataColumn columnWEB_DETAILS;

		private DataColumn columnWEB_CATEGORY_1;

		private DataColumn columnWEB_CATEGORY_2;

		private DataColumn columnWEB_CATEGORY_3;

		private DataColumn columnWEB_IMAGE_FILE;

		private DataColumn columnWEB_PUBLISH;

		private DataColumn columnWEB_SPECIAL;

		private DataColumn columnINTRASTAT_COMM_CODE;

		private DataColumn columnIGNORE_STK_LVL_FLAG;

		private DataColumn columnDEPT_NUMBER;

		private DataColumn columnDEPT_NAME;

		private DataColumn columnTAX_CODE;

		private DataColumn columnASSEMBLY_LEVEL;

		private DataColumn columnLINK_LEVEL;

		private DataColumn columnSTOCK_CAT;

		private DataColumn columnSTOCK_CAT_NAME;

		private DataColumn columnSTOCK_TAKE_DATE;

		private DataColumn columnLAST_PURCHASE_PRICE;

		private DataColumn columnLAST_DISC_PURCHASE_PRICE;

		private DataColumn columnAVERAGE_COST_PRICE;

		private DataColumn columnQTY_IN_STOCK;

		private DataColumn columnQTY_ON_ORDER;

		private DataColumn columnQTY_ALLOCATED;

		private DataColumn columnQTY_LAST_ORDER;

		private DataColumn columnQTY_REORDER;

		private DataColumn columnQTY_REORDER_LEVEL;

		private DataColumn columnQTY_LAST_STOCK_TAKE;

		private DataColumn columnQTY_MAKEUP;

		private DataColumn columnLAST_SALE_DATE;

		private DataColumn columnLAST_PURCHASE_DATE;

		private DataColumn columnUNIT_WEIGHT;

		private DataColumn columnHAS_NO_COMPONENT;

		private DataColumn columnHAS_BOM;

		private DataColumn columnBARCODE;

		private DataColumn columnCOMPONENT_CODE_1;

		private DataColumn columnCOMPONENT_CODE_2;

		private DataColumn columnCOMPONENT_CODE_3;

		private DataColumn columnCOMPONENT_CODE_4;

		private DataColumn columnCOMPONENT_CODE_5;

		private DataColumn columnCOMPONENT_CODE_6;

		private DataColumn columnCOMPONENT_CODE_7;

		private DataColumn columnCOMPONENT_CODE_8;

		private DataColumn columnCOMPONENT_CODE_9;

		private DataColumn columnCOMPONENT_CODE_10;

		private DataColumn columnCOMPONENT_CODE_11;

		private DataColumn columnCOMPONENT_CODE_12;

		private DataColumn columnCOMPONENT_CODE_13;

		private DataColumn columnCOMPONENT_CODE_14;

		private DataColumn columnCOMPONENT_CODE_15;

		private DataColumn columnCOMPONENT_CODE_16;

		private DataColumn columnCOMPONENT_CODE_17;

		private DataColumn columnCOMPONENT_CODE_18;

		private DataColumn columnCOMPONENT_CODE_19;

		private DataColumn columnCOMPONENT_CODE_20;

		private DataColumn columnCOMPONENT_CODE_21;

		private DataColumn columnCOMPONENT_CODE_22;

		private DataColumn columnCOMPONENT_CODE_23;

		private DataColumn columnCOMPONENT_CODE_24;

		private DataColumn columnCOMPONENT_CODE_25;

		private DataColumn columnCOMPONENT_CODE_26;

		private DataColumn columnCOMPONENT_CODE_27;

		private DataColumn columnCOMPONENT_CODE_28;

		private DataColumn columnCOMPONENT_CODE_29;

		private DataColumn columnCOMPONENT_CODE_30;

		private DataColumn columnCOMPONENT_CODE_31;

		private DataColumn columnCOMPONENT_CODE_32;

		private DataColumn columnCOMPONENT_CODE_33;

		private DataColumn columnCOMPONENT_CODE_34;

		private DataColumn columnCOMPONENT_CODE_35;

		private DataColumn columnCOMPONENT_CODE_36;

		private DataColumn columnCOMPONENT_CODE_37;

		private DataColumn columnCOMPONENT_CODE_38;

		private DataColumn columnCOMPONENT_CODE_39;

		private DataColumn columnCOMPONENT_CODE_40;

		private DataColumn columnCOMPONENT_CODE_41;

		private DataColumn columnCOMPONENT_CODE_42;

		private DataColumn columnCOMPONENT_CODE_43;

		private DataColumn columnCOMPONENT_CODE_44;

		private DataColumn columnCOMPONENT_CODE_45;

		private DataColumn columnCOMPONENT_CODE_46;

		private DataColumn columnCOMPONENT_CODE_47;

		private DataColumn columnCOMPONENT_CODE_48;

		private DataColumn columnCOMPONENT_CODE_49;

		private DataColumn columnCOMPONENT_CODE_50;

		private DataColumn columnCOMPONENT_QTY_1;

		private DataColumn columnCOMPONENT_QTY_2;

		private DataColumn columnCOMPONENT_QTY_3;

		private DataColumn columnCOMPONENT_QTY_4;

		private DataColumn columnCOMPONENT_QTY_5;

		private DataColumn columnCOMPONENT_QTY_6;

		private DataColumn columnCOMPONENT_QTY_7;

		private DataColumn columnCOMPONENT_QTY_8;

		private DataColumn columnCOMPONENT_QTY_9;

		private DataColumn columnCOMPONENT_QTY_10;

		private DataColumn columnCOMPONENT_QTY_11;

		private DataColumn columnCOMPONENT_QTY_12;

		private DataColumn columnCOMPONENT_QTY_13;

		private DataColumn columnCOMPONENT_QTY_14;

		private DataColumn columnCOMPONENT_QTY_15;

		private DataColumn columnCOMPONENT_QTY_16;

		private DataColumn columnCOMPONENT_QTY_17;

		private DataColumn columnCOMPONENT_QTY_18;

		private DataColumn columnCOMPONENT_QTY_19;

		private DataColumn columnCOMPONENT_QTY_20;

		private DataColumn columnCOMPONENT_QTY_21;

		private DataColumn columnCOMPONENT_QTY_22;

		private DataColumn columnCOMPONENT_QTY_23;

		private DataColumn columnCOMPONENT_QTY_24;

		private DataColumn columnCOMPONENT_QTY_25;

		private DataColumn columnCOMPONENT_QTY_26;

		private DataColumn columnCOMPONENT_QTY_27;

		private DataColumn columnCOMPONENT_QTY_28;

		private DataColumn columnCOMPONENT_QTY_29;

		private DataColumn columnCOMPONENT_QTY_30;

		private DataColumn columnCOMPONENT_QTY_31;

		private DataColumn columnCOMPONENT_QTY_32;

		private DataColumn columnCOMPONENT_QTY_33;

		private DataColumn columnCOMPONENT_QTY_34;

		private DataColumn columnCOMPONENT_QTY_35;

		private DataColumn columnCOMPONENT_QTY_36;

		private DataColumn columnCOMPONENT_QTY_37;

		private DataColumn columnCOMPONENT_QTY_38;

		private DataColumn columnCOMPONENT_QTY_39;

		private DataColumn columnCOMPONENT_QTY_40;

		private DataColumn columnCOMPONENT_QTY_41;

		private DataColumn columnCOMPONENT_QTY_42;

		private DataColumn columnCOMPONENT_QTY_43;

		private DataColumn columnCOMPONENT_QTY_44;

		private DataColumn columnCOMPONENT_QTY_45;

		private DataColumn columnCOMPONENT_QTY_46;

		private DataColumn columnCOMPONENT_QTY_47;

		private DataColumn columnCOMPONENT_QTY_48;

		private DataColumn columnCOMPONENT_QTY_49;

		private DataColumn columnCOMPONENT_QTY_50;

		private DataColumn columnQTY_SOLD_BF;

		private DataColumn columnQTY_SOLD_MTH1;

		private DataColumn columnQTY_SOLD_MTH2;

		private DataColumn columnQTY_SOLD_MTH3;

		private DataColumn columnQTY_SOLD_MTH4;

		private DataColumn columnQTY_SOLD_MTH5;

		private DataColumn columnQTY_SOLD_MTH6;

		private DataColumn columnQTY_SOLD_MTH7;

		private DataColumn columnQTY_SOLD_MTH8;

		private DataColumn columnQTY_SOLD_MTH9;

		private DataColumn columnQTY_SOLD_MTH10;

		private DataColumn columnQTY_SOLD_MTH11;

		private DataColumn columnQTY_SOLD_MTH12;

		private DataColumn columnQTY_SOLD_FUTURE;

		private DataColumn columnSALES_BF;

		private DataColumn columnSALES_MTH1;

		private DataColumn columnSALES_MTH2;

		private DataColumn columnSALES_MTH3;

		private DataColumn columnSALES_MTH4;

		private DataColumn columnSALES_MTH5;

		private DataColumn columnSALES_MTH6;

		private DataColumn columnSALES_MTH7;

		private DataColumn columnSALES_MTH8;

		private DataColumn columnSALES_MTH9;

		private DataColumn columnSALES_MTH10;

		private DataColumn columnSALES_MTH11;

		private DataColumn columnSALES_MTH12;

		private DataColumn columnSALES_FUTURE;

		private DataColumn columnCOST_BF;

		private DataColumn columnCOST_MTH1;

		private DataColumn columnCOST_MTH2;

		private DataColumn columnCOST_MTH3;

		private DataColumn columnCOST_MTH4;

		private DataColumn columnCOST_MTH5;

		private DataColumn columnCOST_MTH6;

		private DataColumn columnCOST_MTH7;

		private DataColumn columnCOST_MTH8;

		private DataColumn columnCOST_MTH9;

		private DataColumn columnCOST_MTH10;

		private DataColumn columnCOST_MTH11;

		private DataColumn columnCOST_MTH12;

		private DataColumn columnCOST_FUTURE;

		private DataColumn columnTHIS_RECORD;

		private DataColumn columnBUDGET_QTY_SOLD_BF;

		private DataColumn columnBUDGET_QTY_SOLD_MTH1;

		private DataColumn columnBUDGET_QTY_SOLD_MTH2;

		private DataColumn columnBUDGET_QTY_SOLD_MTH3;

		private DataColumn columnBUDGET_QTY_SOLD_MTH4;

		private DataColumn columnBUDGET_QTY_SOLD_MTH5;

		private DataColumn columnBUDGET_QTY_SOLD_MTH6;

		private DataColumn columnBUDGET_QTY_SOLD_MTH7;

		private DataColumn columnBUDGET_QTY_SOLD_MTH8;

		private DataColumn columnBUDGET_QTY_SOLD_MTH9;

		private DataColumn columnBUDGET_QTY_SOLD_MTH10;

		private DataColumn columnBUDGET_QTY_SOLD_MTH11;

		private DataColumn columnBUDGET_QTY_SOLD_MTH12;

		private DataColumn columnBUDGET_QTY_SOLD_FUTURE;

		private DataColumn columnBUDGET_SALES_BF;

		private DataColumn columnBUDGET_SALES_MTH1;

		private DataColumn columnBUDGET_SALES_MTH2;

		private DataColumn columnBUDGET_SALES_MTH3;

		private DataColumn columnBUDGET_SALES_MTH4;

		private DataColumn columnBUDGET_SALES_MTH5;

		private DataColumn columnBUDGET_SALES_MTH6;

		private DataColumn columnBUDGET_SALES_MTH7;

		private DataColumn columnBUDGET_SALES_MTH8;

		private DataColumn columnBUDGET_SALES_MTH9;

		private DataColumn columnBUDGET_SALES_MTH10;

		private DataColumn columnBUDGET_SALES_MTH11;

		private DataColumn columnBUDGET_SALES_MTH12;

		private DataColumn columnBUDGET_SALES_FUTURE;

		private DataColumn columnPRIOR_YR_QTY_SOLD_BF;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH1;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH2;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH3;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH4;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH5;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH6;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH7;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH8;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH9;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH10;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH11;

		private DataColumn columnPRIOR_YR_QTY_SOLD_MTH12;

		private DataColumn columnPRIOR_YR_QTY_SOLD_FUTURE;

		private DataColumn columnPRIOR_YR_SALES_BF;

		private DataColumn columnPRIOR_YR_SALES_MTH1;

		private DataColumn columnPRIOR_YR_SALES_MTH2;

		private DataColumn columnPRIOR_YR_SALES_MTH3;

		private DataColumn columnPRIOR_YR_SALES_MTH4;

		private DataColumn columnPRIOR_YR_SALES_MTH5;

		private DataColumn columnPRIOR_YR_SALES_MTH6;

		private DataColumn columnPRIOR_YR_SALES_MTH7;

		private DataColumn columnPRIOR_YR_SALES_MTH8;

		private DataColumn columnPRIOR_YR_SALES_MTH9;

		private DataColumn columnPRIOR_YR_SALES_MTH10;

		private DataColumn columnPRIOR_YR_SALES_MTH11;

		private DataColumn columnPRIOR_YR_SALES_MTH12;

		private DataColumn columnPRIOR_YR_SALES_FUTURE;

		private DataColumn columnPRIOR_YR_COST_BF;

		private DataColumn columnPRIOR_YR_COST_MTH1;

		private DataColumn columnPRIOR_YR_COST_MTH2;

		private DataColumn columnPRIOR_YR_COST_MTH3;

		private DataColumn columnPRIOR_YR_COST_MTH4;

		private DataColumn columnPRIOR_YR_COST_MTH5;

		private DataColumn columnPRIOR_YR_COST_MTH6;

		private DataColumn columnPRIOR_YR_COST_MTH7;

		private DataColumn columnPRIOR_YR_COST_MTH8;

		private DataColumn columnPRIOR_YR_COST_MTH9;

		private DataColumn columnPRIOR_YR_COST_MTH10;

		private DataColumn columnPRIOR_YR_COST_MTH11;

		private DataColumn columnPRIOR_YR_COST_MTH12;

		private DataColumn columnPRIOR_YR_COST_FUTURE;

		private DataColumn columnDISC_A_LEVEL_1_QTY;

		private DataColumn columnDISC_A_LEVEL_2_QTY;

		private DataColumn columnDISC_A_LEVEL_3_QTY;

		private DataColumn columnDISC_A_LEVEL_4_QTY;

		private DataColumn columnDISC_A_LEVEL_5_QTY;

		private DataColumn columnDISC_A_LEVEL_6_QTY;

		private DataColumn columnDISC_A_LEVEL_7_QTY;

		private DataColumn columnDISC_A_LEVEL_8_QTY;

		private DataColumn columnDISC_A_LEVEL_9_QTY;

		private DataColumn columnDISC_A_LEVEL_10_QTY;

		private DataColumn columnDISC_A_LEVEL_1_RATE;

		private DataColumn columnDISC_A_LEVEL_2_RATE;

		private DataColumn columnDISC_A_LEVEL_3_RATE;

		private DataColumn columnDISC_A_LEVEL_4_RATE;

		private DataColumn columnDISC_A_LEVEL_5_RATE;

		private DataColumn columnDISC_A_LEVEL_6_RATE;

		private DataColumn columnDISC_A_LEVEL_7_RATE;

		private DataColumn columnDISC_A_LEVEL_8_RATE;

		private DataColumn columnDISC_A_LEVEL_9_RATE;

		private DataColumn columnDISC_A_LEVEL_10_RATE;

		private DataColumn columnDISC_B_LEVEL_1_QTY;

		private DataColumn columnDISC_B_LEVEL_2_QTY;

		private DataColumn columnDISC_B_LEVEL_3_QTY;

		private DataColumn columnDISC_B_LEVEL_4_QTY;

		private DataColumn columnDISC_B_LEVEL_5_QTY;

		private DataColumn columnDISC_B_LEVEL_6_QTY;

		private DataColumn columnDISC_B_LEVEL_7_QTY;

		private DataColumn columnDISC_B_LEVEL_8_QTY;

		private DataColumn columnDISC_B_LEVEL_9_QTY;

		private DataColumn columnDISC_B_LEVEL_10_QTY;

		private DataColumn columnDISC_B_LEVEL_1_RATE;

		private DataColumn columnDISC_B_LEVEL_2_RATE;

		private DataColumn columnDISC_B_LEVEL_3_RATE;

		private DataColumn columnDISC_B_LEVEL_4_RATE;

		private DataColumn columnDISC_B_LEVEL_5_RATE;

		private DataColumn columnDISC_B_LEVEL_6_RATE;

		private DataColumn columnDISC_B_LEVEL_7_RATE;

		private DataColumn columnDISC_B_LEVEL_8_RATE;

		private DataColumn columnDISC_B_LEVEL_9_RATE;

		private DataColumn columnDISC_B_LEVEL_10_RATE;

		private DataColumn columnDISC_C_LEVEL_1_QTY;

		private DataColumn columnDISC_C_LEVEL_2_QTY;

		private DataColumn columnDISC_C_LEVEL_3_QTY;

		private DataColumn columnDISC_C_LEVEL_4_QTY;

		private DataColumn columnDISC_C_LEVEL_5_QTY;

		private DataColumn columnDISC_C_LEVEL_6_QTY;

		private DataColumn columnDISC_C_LEVEL_7_QTY;

		private DataColumn columnDISC_C_LEVEL_8_QTY;

		private DataColumn columnDISC_C_LEVEL_9_QTY;

		private DataColumn columnDISC_C_LEVEL_10_QTY;

		private DataColumn columnDISC_C_LEVEL_1_RATE;

		private DataColumn columnDISC_C_LEVEL_2_RATE;

		private DataColumn columnDISC_C_LEVEL_3_RATE;

		private DataColumn columnDISC_C_LEVEL_4_RATE;

		private DataColumn columnDISC_C_LEVEL_5_RATE;

		private DataColumn columnDISC_C_LEVEL_6_RATE;

		private DataColumn columnDISC_C_LEVEL_7_RATE;

		private DataColumn columnDISC_C_LEVEL_8_RATE;

		private DataColumn columnDISC_C_LEVEL_9_RATE;

		private DataColumn columnDISC_C_LEVEL_10_RATE;

		private DataColumn columnDISC_D_LEVEL_1_QTY;

		private DataColumn columnDISC_D_LEVEL_2_QTY;

		private DataColumn columnDISC_D_LEVEL_3_QTY;

		private DataColumn columnDISC_D_LEVEL_4_QTY;

		private DataColumn columnDISC_D_LEVEL_5_QTY;

		private DataColumn columnDISC_D_LEVEL_6_QTY;

		private DataColumn columnDISC_D_LEVEL_7_QTY;

		private DataColumn columnDISC_D_LEVEL_8_QTY;

		private DataColumn columnDISC_D_LEVEL_9_QTY;

		private DataColumn columnDISC_D_LEVEL_10_QTY;

		private DataColumn columnDISC_D_LEVEL_1_RATE;

		private DataColumn columnDISC_D_LEVEL_2_RATE;

		private DataColumn columnDISC_D_LEVEL_3_RATE;

		private DataColumn columnDISC_D_LEVEL_4_RATE;

		private DataColumn columnDISC_D_LEVEL_5_RATE;

		private DataColumn columnDISC_D_LEVEL_6_RATE;

		private DataColumn columnDISC_D_LEVEL_7_RATE;

		private DataColumn columnDISC_D_LEVEL_8_RATE;

		private DataColumn columnDISC_D_LEVEL_9_RATE;

		private DataColumn columnDISC_D_LEVEL_10_RATE;

		private DataColumn columnDISC_E_LEVEL_1_QTY;

		private DataColumn columnDISC_E_LEVEL_2_QTY;

		private DataColumn columnDISC_E_LEVEL_3_QTY;

		private DataColumn columnDISC_E_LEVEL_4_QTY;

		private DataColumn columnDISC_E_LEVEL_5_QTY;

		private DataColumn columnDISC_E_LEVEL_6_QTY;

		private DataColumn columnDISC_E_LEVEL_7_QTY;

		private DataColumn columnDISC_E_LEVEL_8_QTY;

		private DataColumn columnDISC_E_LEVEL_9_QTY;

		private DataColumn columnDISC_E_LEVEL_10_QTY;

		private DataColumn columnDISC_E_LEVEL_1_RATE;

		private DataColumn columnDISC_E_LEVEL_2_RATE;

		private DataColumn columnDISC_E_LEVEL_3_RATE;

		private DataColumn columnDISC_E_LEVEL_4_RATE;

		private DataColumn columnDISC_E_LEVEL_5_RATE;

		private DataColumn columnDISC_E_LEVEL_6_RATE;

		private DataColumn columnDISC_E_LEVEL_7_RATE;

		private DataColumn columnDISC_E_LEVEL_8_RATE;

		private DataColumn columnDISC_E_LEVEL_9_RATE;

		private DataColumn columnDISC_E_LEVEL_10_RATE;

		private DataColumn columnPURCHASE_NOMINAL_CODE;

		private DataColumn columnRECORD_CREATE_DATE;

		private DataColumn columnRECORD_MODIFY_DATE;

		private DataColumn columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STOCK_CODEColumn => columnSTOCK_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DESCRIPTIONColumn => columnDESCRIPTION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UNIT_OF_SALEColumn => columnUNIT_OF_SALE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NOMINAL_CODEColumn => columnNOMINAL_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PURCHASE_REFColumn => columnPURCHASE_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SUPPLIER_PART_NUMBERColumn => columnSUPPLIER_PART_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LOCATIONColumn => columnLOCATION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMMODITY_CODEColumn => columnCOMMODITY_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_PRICEColumn => columnSALES_PRICE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_DESCRIPTIONColumn => columnWEB_DESCRIPTION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_DETAILSColumn => columnWEB_DETAILS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_CATEGORY_1Column => columnWEB_CATEGORY_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_CATEGORY_2Column => columnWEB_CATEGORY_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_CATEGORY_3Column => columnWEB_CATEGORY_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_IMAGE_FILEColumn => columnWEB_IMAGE_FILE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_PUBLISHColumn => columnWEB_PUBLISH;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn WEB_SPECIALColumn => columnWEB_SPECIAL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INTRASTAT_COMM_CODEColumn => columnINTRASTAT_COMM_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IGNORE_STK_LVL_FLAGColumn => columnIGNORE_STK_LVL_FLAG;

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
		public DataColumn ASSEMBLY_LEVELColumn => columnASSEMBLY_LEVEL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LINK_LEVELColumn => columnLINK_LEVEL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STOCK_CATColumn => columnSTOCK_CAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STOCK_CAT_NAMEColumn => columnSTOCK_CAT_NAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn STOCK_TAKE_DATEColumn => columnSTOCK_TAKE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_PURCHASE_PRICEColumn => columnLAST_PURCHASE_PRICE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_DISC_PURCHASE_PRICEColumn => columnLAST_DISC_PURCHASE_PRICE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn AVERAGE_COST_PRICEColumn => columnAVERAGE_COST_PRICE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_IN_STOCKColumn => columnQTY_IN_STOCK;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_ON_ORDERColumn => columnQTY_ON_ORDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_ALLOCATEDColumn => columnQTY_ALLOCATED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_LAST_ORDERColumn => columnQTY_LAST_ORDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_REORDERColumn => columnQTY_REORDER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_REORDER_LEVELColumn => columnQTY_REORDER_LEVEL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_LAST_STOCK_TAKEColumn => columnQTY_LAST_STOCK_TAKE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_MAKEUPColumn => columnQTY_MAKEUP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_SALE_DATEColumn => columnLAST_SALE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LAST_PURCHASE_DATEColumn => columnLAST_PURCHASE_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UNIT_WEIGHTColumn => columnUNIT_WEIGHT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HAS_NO_COMPONENTColumn => columnHAS_NO_COMPONENT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HAS_BOMColumn => columnHAS_BOM;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BARCODEColumn => columnBARCODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_1Column => columnCOMPONENT_CODE_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_2Column => columnCOMPONENT_CODE_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_3Column => columnCOMPONENT_CODE_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_4Column => columnCOMPONENT_CODE_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_5Column => columnCOMPONENT_CODE_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_6Column => columnCOMPONENT_CODE_6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_7Column => columnCOMPONENT_CODE_7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_8Column => columnCOMPONENT_CODE_8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_9Column => columnCOMPONENT_CODE_9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_10Column => columnCOMPONENT_CODE_10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_11Column => columnCOMPONENT_CODE_11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_12Column => columnCOMPONENT_CODE_12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_13Column => columnCOMPONENT_CODE_13;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_14Column => columnCOMPONENT_CODE_14;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_15Column => columnCOMPONENT_CODE_15;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_16Column => columnCOMPONENT_CODE_16;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_17Column => columnCOMPONENT_CODE_17;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_18Column => columnCOMPONENT_CODE_18;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_19Column => columnCOMPONENT_CODE_19;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_20Column => columnCOMPONENT_CODE_20;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_21Column => columnCOMPONENT_CODE_21;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_22Column => columnCOMPONENT_CODE_22;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_23Column => columnCOMPONENT_CODE_23;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_24Column => columnCOMPONENT_CODE_24;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_25Column => columnCOMPONENT_CODE_25;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_26Column => columnCOMPONENT_CODE_26;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_27Column => columnCOMPONENT_CODE_27;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_28Column => columnCOMPONENT_CODE_28;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_29Column => columnCOMPONENT_CODE_29;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_30Column => columnCOMPONENT_CODE_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_31Column => columnCOMPONENT_CODE_31;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_32Column => columnCOMPONENT_CODE_32;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_33Column => columnCOMPONENT_CODE_33;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_34Column => columnCOMPONENT_CODE_34;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_35Column => columnCOMPONENT_CODE_35;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_36Column => columnCOMPONENT_CODE_36;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_37Column => columnCOMPONENT_CODE_37;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_38Column => columnCOMPONENT_CODE_38;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_39Column => columnCOMPONENT_CODE_39;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_40Column => columnCOMPONENT_CODE_40;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_41Column => columnCOMPONENT_CODE_41;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_42Column => columnCOMPONENT_CODE_42;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_43Column => columnCOMPONENT_CODE_43;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_44Column => columnCOMPONENT_CODE_44;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_45Column => columnCOMPONENT_CODE_45;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_46Column => columnCOMPONENT_CODE_46;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_47Column => columnCOMPONENT_CODE_47;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_48Column => columnCOMPONENT_CODE_48;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_49Column => columnCOMPONENT_CODE_49;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_CODE_50Column => columnCOMPONENT_CODE_50;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_1Column => columnCOMPONENT_QTY_1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_2Column => columnCOMPONENT_QTY_2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_3Column => columnCOMPONENT_QTY_3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_4Column => columnCOMPONENT_QTY_4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_5Column => columnCOMPONENT_QTY_5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_6Column => columnCOMPONENT_QTY_6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_7Column => columnCOMPONENT_QTY_7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_8Column => columnCOMPONENT_QTY_8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_9Column => columnCOMPONENT_QTY_9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_10Column => columnCOMPONENT_QTY_10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_11Column => columnCOMPONENT_QTY_11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_12Column => columnCOMPONENT_QTY_12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_13Column => columnCOMPONENT_QTY_13;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_14Column => columnCOMPONENT_QTY_14;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_15Column => columnCOMPONENT_QTY_15;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_16Column => columnCOMPONENT_QTY_16;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_17Column => columnCOMPONENT_QTY_17;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_18Column => columnCOMPONENT_QTY_18;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_19Column => columnCOMPONENT_QTY_19;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_20Column => columnCOMPONENT_QTY_20;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_21Column => columnCOMPONENT_QTY_21;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_22Column => columnCOMPONENT_QTY_22;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_23Column => columnCOMPONENT_QTY_23;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_24Column => columnCOMPONENT_QTY_24;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_25Column => columnCOMPONENT_QTY_25;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_26Column => columnCOMPONENT_QTY_26;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_27Column => columnCOMPONENT_QTY_27;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_28Column => columnCOMPONENT_QTY_28;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_29Column => columnCOMPONENT_QTY_29;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_30Column => columnCOMPONENT_QTY_30;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_31Column => columnCOMPONENT_QTY_31;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_32Column => columnCOMPONENT_QTY_32;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_33Column => columnCOMPONENT_QTY_33;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_34Column => columnCOMPONENT_QTY_34;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_35Column => columnCOMPONENT_QTY_35;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_36Column => columnCOMPONENT_QTY_36;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_37Column => columnCOMPONENT_QTY_37;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_38Column => columnCOMPONENT_QTY_38;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_39Column => columnCOMPONENT_QTY_39;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_40Column => columnCOMPONENT_QTY_40;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_41Column => columnCOMPONENT_QTY_41;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_42Column => columnCOMPONENT_QTY_42;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_43Column => columnCOMPONENT_QTY_43;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_44Column => columnCOMPONENT_QTY_44;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_45Column => columnCOMPONENT_QTY_45;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_46Column => columnCOMPONENT_QTY_46;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_47Column => columnCOMPONENT_QTY_47;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_48Column => columnCOMPONENT_QTY_48;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_49Column => columnCOMPONENT_QTY_49;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COMPONENT_QTY_50Column => columnCOMPONENT_QTY_50;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_BFColumn => columnQTY_SOLD_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH1Column => columnQTY_SOLD_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH2Column => columnQTY_SOLD_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH3Column => columnQTY_SOLD_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH4Column => columnQTY_SOLD_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH5Column => columnQTY_SOLD_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH6Column => columnQTY_SOLD_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH7Column => columnQTY_SOLD_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH8Column => columnQTY_SOLD_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH9Column => columnQTY_SOLD_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH10Column => columnQTY_SOLD_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH11Column => columnQTY_SOLD_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_MTH12Column => columnQTY_SOLD_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QTY_SOLD_FUTUREColumn => columnQTY_SOLD_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_BFColumn => columnSALES_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH1Column => columnSALES_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH2Column => columnSALES_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH3Column => columnSALES_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH4Column => columnSALES_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH5Column => columnSALES_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH6Column => columnSALES_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH7Column => columnSALES_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH8Column => columnSALES_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH9Column => columnSALES_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH10Column => columnSALES_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH11Column => columnSALES_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_MTH12Column => columnSALES_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SALES_FUTUREColumn => columnSALES_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_BFColumn => columnCOST_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH1Column => columnCOST_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH2Column => columnCOST_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH3Column => columnCOST_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH4Column => columnCOST_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH5Column => columnCOST_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH6Column => columnCOST_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH7Column => columnCOST_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH8Column => columnCOST_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH9Column => columnCOST_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH10Column => columnCOST_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH11Column => columnCOST_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_MTH12Column => columnCOST_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn COST_FUTUREColumn => columnCOST_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn THIS_RECORDColumn => columnTHIS_RECORD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_BFColumn => columnBUDGET_QTY_SOLD_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH1Column => columnBUDGET_QTY_SOLD_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH2Column => columnBUDGET_QTY_SOLD_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH3Column => columnBUDGET_QTY_SOLD_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH4Column => columnBUDGET_QTY_SOLD_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH5Column => columnBUDGET_QTY_SOLD_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH6Column => columnBUDGET_QTY_SOLD_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH7Column => columnBUDGET_QTY_SOLD_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH8Column => columnBUDGET_QTY_SOLD_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH9Column => columnBUDGET_QTY_SOLD_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH10Column => columnBUDGET_QTY_SOLD_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH11Column => columnBUDGET_QTY_SOLD_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_MTH12Column => columnBUDGET_QTY_SOLD_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_QTY_SOLD_FUTUREColumn => columnBUDGET_QTY_SOLD_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_BFColumn => columnBUDGET_SALES_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH1Column => columnBUDGET_SALES_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH2Column => columnBUDGET_SALES_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH3Column => columnBUDGET_SALES_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH4Column => columnBUDGET_SALES_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH5Column => columnBUDGET_SALES_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH6Column => columnBUDGET_SALES_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH7Column => columnBUDGET_SALES_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH8Column => columnBUDGET_SALES_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH9Column => columnBUDGET_SALES_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH10Column => columnBUDGET_SALES_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH11Column => columnBUDGET_SALES_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_MTH12Column => columnBUDGET_SALES_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_SALES_FUTUREColumn => columnBUDGET_SALES_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_BFColumn => columnPRIOR_YR_QTY_SOLD_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH1Column => columnPRIOR_YR_QTY_SOLD_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH2Column => columnPRIOR_YR_QTY_SOLD_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH3Column => columnPRIOR_YR_QTY_SOLD_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH4Column => columnPRIOR_YR_QTY_SOLD_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH5Column => columnPRIOR_YR_QTY_SOLD_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH6Column => columnPRIOR_YR_QTY_SOLD_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH7Column => columnPRIOR_YR_QTY_SOLD_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH8Column => columnPRIOR_YR_QTY_SOLD_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH9Column => columnPRIOR_YR_QTY_SOLD_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH10Column => columnPRIOR_YR_QTY_SOLD_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH11Column => columnPRIOR_YR_QTY_SOLD_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_MTH12Column => columnPRIOR_YR_QTY_SOLD_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_QTY_SOLD_FUTUREColumn => columnPRIOR_YR_QTY_SOLD_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_BFColumn => columnPRIOR_YR_SALES_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH1Column => columnPRIOR_YR_SALES_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH2Column => columnPRIOR_YR_SALES_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH3Column => columnPRIOR_YR_SALES_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH4Column => columnPRIOR_YR_SALES_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH5Column => columnPRIOR_YR_SALES_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH6Column => columnPRIOR_YR_SALES_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH7Column => columnPRIOR_YR_SALES_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH8Column => columnPRIOR_YR_SALES_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH9Column => columnPRIOR_YR_SALES_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH10Column => columnPRIOR_YR_SALES_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH11Column => columnPRIOR_YR_SALES_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_MTH12Column => columnPRIOR_YR_SALES_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_SALES_FUTUREColumn => columnPRIOR_YR_SALES_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_BFColumn => columnPRIOR_YR_COST_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH1Column => columnPRIOR_YR_COST_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH2Column => columnPRIOR_YR_COST_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH3Column => columnPRIOR_YR_COST_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH4Column => columnPRIOR_YR_COST_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH5Column => columnPRIOR_YR_COST_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH6Column => columnPRIOR_YR_COST_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH7Column => columnPRIOR_YR_COST_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH8Column => columnPRIOR_YR_COST_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH9Column => columnPRIOR_YR_COST_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH10Column => columnPRIOR_YR_COST_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH11Column => columnPRIOR_YR_COST_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_MTH12Column => columnPRIOR_YR_COST_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_COST_FUTUREColumn => columnPRIOR_YR_COST_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_1_QTYColumn => columnDISC_A_LEVEL_1_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_2_QTYColumn => columnDISC_A_LEVEL_2_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_3_QTYColumn => columnDISC_A_LEVEL_3_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_4_QTYColumn => columnDISC_A_LEVEL_4_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_5_QTYColumn => columnDISC_A_LEVEL_5_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_6_QTYColumn => columnDISC_A_LEVEL_6_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_7_QTYColumn => columnDISC_A_LEVEL_7_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_8_QTYColumn => columnDISC_A_LEVEL_8_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_9_QTYColumn => columnDISC_A_LEVEL_9_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_10_QTYColumn => columnDISC_A_LEVEL_10_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_1_RATEColumn => columnDISC_A_LEVEL_1_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_2_RATEColumn => columnDISC_A_LEVEL_2_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_3_RATEColumn => columnDISC_A_LEVEL_3_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_4_RATEColumn => columnDISC_A_LEVEL_4_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_5_RATEColumn => columnDISC_A_LEVEL_5_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_6_RATEColumn => columnDISC_A_LEVEL_6_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_7_RATEColumn => columnDISC_A_LEVEL_7_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_8_RATEColumn => columnDISC_A_LEVEL_8_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_9_RATEColumn => columnDISC_A_LEVEL_9_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_A_LEVEL_10_RATEColumn => columnDISC_A_LEVEL_10_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_1_QTYColumn => columnDISC_B_LEVEL_1_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_2_QTYColumn => columnDISC_B_LEVEL_2_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_3_QTYColumn => columnDISC_B_LEVEL_3_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_4_QTYColumn => columnDISC_B_LEVEL_4_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_5_QTYColumn => columnDISC_B_LEVEL_5_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_6_QTYColumn => columnDISC_B_LEVEL_6_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_7_QTYColumn => columnDISC_B_LEVEL_7_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_8_QTYColumn => columnDISC_B_LEVEL_8_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_9_QTYColumn => columnDISC_B_LEVEL_9_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_10_QTYColumn => columnDISC_B_LEVEL_10_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_1_RATEColumn => columnDISC_B_LEVEL_1_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_2_RATEColumn => columnDISC_B_LEVEL_2_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_3_RATEColumn => columnDISC_B_LEVEL_3_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_4_RATEColumn => columnDISC_B_LEVEL_4_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_5_RATEColumn => columnDISC_B_LEVEL_5_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_6_RATEColumn => columnDISC_B_LEVEL_6_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_7_RATEColumn => columnDISC_B_LEVEL_7_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_8_RATEColumn => columnDISC_B_LEVEL_8_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_9_RATEColumn => columnDISC_B_LEVEL_9_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_B_LEVEL_10_RATEColumn => columnDISC_B_LEVEL_10_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_1_QTYColumn => columnDISC_C_LEVEL_1_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_2_QTYColumn => columnDISC_C_LEVEL_2_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_3_QTYColumn => columnDISC_C_LEVEL_3_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_4_QTYColumn => columnDISC_C_LEVEL_4_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_5_QTYColumn => columnDISC_C_LEVEL_5_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_6_QTYColumn => columnDISC_C_LEVEL_6_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_7_QTYColumn => columnDISC_C_LEVEL_7_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_8_QTYColumn => columnDISC_C_LEVEL_8_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_9_QTYColumn => columnDISC_C_LEVEL_9_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_10_QTYColumn => columnDISC_C_LEVEL_10_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_1_RATEColumn => columnDISC_C_LEVEL_1_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_2_RATEColumn => columnDISC_C_LEVEL_2_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_3_RATEColumn => columnDISC_C_LEVEL_3_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_4_RATEColumn => columnDISC_C_LEVEL_4_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_5_RATEColumn => columnDISC_C_LEVEL_5_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_6_RATEColumn => columnDISC_C_LEVEL_6_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_7_RATEColumn => columnDISC_C_LEVEL_7_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_8_RATEColumn => columnDISC_C_LEVEL_8_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_9_RATEColumn => columnDISC_C_LEVEL_9_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_C_LEVEL_10_RATEColumn => columnDISC_C_LEVEL_10_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_1_QTYColumn => columnDISC_D_LEVEL_1_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_2_QTYColumn => columnDISC_D_LEVEL_2_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_3_QTYColumn => columnDISC_D_LEVEL_3_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_4_QTYColumn => columnDISC_D_LEVEL_4_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_5_QTYColumn => columnDISC_D_LEVEL_5_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_6_QTYColumn => columnDISC_D_LEVEL_6_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_7_QTYColumn => columnDISC_D_LEVEL_7_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_8_QTYColumn => columnDISC_D_LEVEL_8_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_9_QTYColumn => columnDISC_D_LEVEL_9_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_10_QTYColumn => columnDISC_D_LEVEL_10_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_1_RATEColumn => columnDISC_D_LEVEL_1_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_2_RATEColumn => columnDISC_D_LEVEL_2_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_3_RATEColumn => columnDISC_D_LEVEL_3_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_4_RATEColumn => columnDISC_D_LEVEL_4_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_5_RATEColumn => columnDISC_D_LEVEL_5_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_6_RATEColumn => columnDISC_D_LEVEL_6_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_7_RATEColumn => columnDISC_D_LEVEL_7_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_8_RATEColumn => columnDISC_D_LEVEL_8_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_9_RATEColumn => columnDISC_D_LEVEL_9_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_D_LEVEL_10_RATEColumn => columnDISC_D_LEVEL_10_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_1_QTYColumn => columnDISC_E_LEVEL_1_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_2_QTYColumn => columnDISC_E_LEVEL_2_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_3_QTYColumn => columnDISC_E_LEVEL_3_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_4_QTYColumn => columnDISC_E_LEVEL_4_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_5_QTYColumn => columnDISC_E_LEVEL_5_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_6_QTYColumn => columnDISC_E_LEVEL_6_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_7_QTYColumn => columnDISC_E_LEVEL_7_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_8_QTYColumn => columnDISC_E_LEVEL_8_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_9_QTYColumn => columnDISC_E_LEVEL_9_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_10_QTYColumn => columnDISC_E_LEVEL_10_QTY;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_1_RATEColumn => columnDISC_E_LEVEL_1_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_2_RATEColumn => columnDISC_E_LEVEL_2_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_3_RATEColumn => columnDISC_E_LEVEL_3_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_4_RATEColumn => columnDISC_E_LEVEL_4_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_5_RATEColumn => columnDISC_E_LEVEL_5_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_6_RATEColumn => columnDISC_E_LEVEL_6_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_7_RATEColumn => columnDISC_E_LEVEL_7_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_8_RATEColumn => columnDISC_E_LEVEL_8_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_9_RATEColumn => columnDISC_E_LEVEL_9_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISC_E_LEVEL_10_RATEColumn => columnDISC_E_LEVEL_10_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PURCHASE_NOMINAL_CODEColumn => columnPURCHASE_NOMINAL_CODE;

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
		public ProductsListRow this[int index] => (ProductsListRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ProductsListRowChangeEventHandler ProductsListRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ProductsListRowChangeEventHandler ProductsListRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ProductsListRowChangeEventHandler ProductsListRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event ProductsListRowChangeEventHandler ProductsListRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductsListDataTable()
		{
			base.TableName = "ProductsList";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ProductsListDataTable(DataTable table)
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
		protected ProductsListDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddProductsListRow(ProductsListRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductsListRow AddProductsListRow(string STOCK_CODE, string DESCRIPTION, string UNIT_OF_SALE, string NOMINAL_CODE, string PURCHASE_REF, string SUPPLIER_PART_NUMBER, string LOCATION, string COMMODITY_CODE, double SALES_PRICE, string WEB_DESCRIPTION, string WEB_DETAILS, string WEB_CATEGORY_1, string WEB_CATEGORY_2, string WEB_CATEGORY_3, string WEB_IMAGE_FILE, short WEB_PUBLISH, short WEB_SPECIAL, string INTRASTAT_COMM_CODE, short IGNORE_STK_LVL_FLAG, short DEPT_NUMBER, string DEPT_NAME, string TAX_CODE, short ASSEMBLY_LEVEL, short LINK_LEVEL, short STOCK_CAT, string STOCK_CAT_NAME, DateTime STOCK_TAKE_DATE, double LAST_PURCHASE_PRICE, double LAST_DISC_PURCHASE_PRICE, double AVERAGE_COST_PRICE, double QTY_IN_STOCK, double QTY_ON_ORDER, double QTY_ALLOCATED, double QTY_LAST_ORDER, double QTY_REORDER, double QTY_REORDER_LEVEL, double QTY_LAST_STOCK_TAKE, double QTY_MAKEUP, DateTime LAST_SALE_DATE, DateTime LAST_PURCHASE_DATE, double UNIT_WEIGHT, short HAS_NO_COMPONENT, string HAS_BOM, string BARCODE, string COMPONENT_CODE_1, string COMPONENT_CODE_2, string COMPONENT_CODE_3, string COMPONENT_CODE_4, string COMPONENT_CODE_5, string COMPONENT_CODE_6, string COMPONENT_CODE_7, string COMPONENT_CODE_8, string COMPONENT_CODE_9, string COMPONENT_CODE_10, string COMPONENT_CODE_11, string COMPONENT_CODE_12, string COMPONENT_CODE_13, string COMPONENT_CODE_14, string COMPONENT_CODE_15, string COMPONENT_CODE_16, string COMPONENT_CODE_17, string COMPONENT_CODE_18, string COMPONENT_CODE_19, string COMPONENT_CODE_20, string COMPONENT_CODE_21, string COMPONENT_CODE_22, string COMPONENT_CODE_23, string COMPONENT_CODE_24, string COMPONENT_CODE_25, string COMPONENT_CODE_26, string COMPONENT_CODE_27, string COMPONENT_CODE_28, string COMPONENT_CODE_29, string COMPONENT_CODE_30, string COMPONENT_CODE_31, string COMPONENT_CODE_32, string COMPONENT_CODE_33, string COMPONENT_CODE_34, string COMPONENT_CODE_35, string COMPONENT_CODE_36, string COMPONENT_CODE_37, string COMPONENT_CODE_38, string COMPONENT_CODE_39, string COMPONENT_CODE_40, string COMPONENT_CODE_41, string COMPONENT_CODE_42, string COMPONENT_CODE_43, string COMPONENT_CODE_44, string COMPONENT_CODE_45, string COMPONENT_CODE_46, string COMPONENT_CODE_47, string COMPONENT_CODE_48, string COMPONENT_CODE_49, string COMPONENT_CODE_50, double COMPONENT_QTY_1, double COMPONENT_QTY_2, double COMPONENT_QTY_3, double COMPONENT_QTY_4, double COMPONENT_QTY_5, double COMPONENT_QTY_6, double COMPONENT_QTY_7, double COMPONENT_QTY_8, double COMPONENT_QTY_9, double COMPONENT_QTY_10, double COMPONENT_QTY_11, double COMPONENT_QTY_12, double COMPONENT_QTY_13, double COMPONENT_QTY_14, double COMPONENT_QTY_15, double COMPONENT_QTY_16, double COMPONENT_QTY_17, double COMPONENT_QTY_18, double COMPONENT_QTY_19, double COMPONENT_QTY_20, double COMPONENT_QTY_21, double COMPONENT_QTY_22, double COMPONENT_QTY_23, double COMPONENT_QTY_24, double COMPONENT_QTY_25, double COMPONENT_QTY_26, double COMPONENT_QTY_27, double COMPONENT_QTY_28, double COMPONENT_QTY_29, double COMPONENT_QTY_30, double COMPONENT_QTY_31, double COMPONENT_QTY_32, double COMPONENT_QTY_33, double COMPONENT_QTY_34, double COMPONENT_QTY_35, double COMPONENT_QTY_36, double COMPONENT_QTY_37, double COMPONENT_QTY_38, double COMPONENT_QTY_39, double COMPONENT_QTY_40, double COMPONENT_QTY_41, double COMPONENT_QTY_42, double COMPONENT_QTY_43, double COMPONENT_QTY_44, double COMPONENT_QTY_45, double COMPONENT_QTY_46, double COMPONENT_QTY_47, double COMPONENT_QTY_48, double COMPONENT_QTY_49, double COMPONENT_QTY_50, double QTY_SOLD_BF, double QTY_SOLD_MTH1, double QTY_SOLD_MTH2, double QTY_SOLD_MTH3, double QTY_SOLD_MTH4, double QTY_SOLD_MTH5, double QTY_SOLD_MTH6, double QTY_SOLD_MTH7, double QTY_SOLD_MTH8, double QTY_SOLD_MTH9, double QTY_SOLD_MTH10, double QTY_SOLD_MTH11, double QTY_SOLD_MTH12, double QTY_SOLD_FUTURE, double SALES_BF, double SALES_MTH1, double SALES_MTH2, double SALES_MTH3, double SALES_MTH4, double SALES_MTH5, double SALES_MTH6, double SALES_MTH7, double SALES_MTH8, double SALES_MTH9, double SALES_MTH10, double SALES_MTH11, double SALES_MTH12, double SALES_FUTURE, double COST_BF, double COST_MTH1, double COST_MTH2, double COST_MTH3, double COST_MTH4, double COST_MTH5, double COST_MTH6, double COST_MTH7, double COST_MTH8, double COST_MTH9, double COST_MTH10, double COST_MTH11, double COST_MTH12, double COST_FUTURE, int THIS_RECORD, double BUDGET_QTY_SOLD_BF, double BUDGET_QTY_SOLD_MTH1, double BUDGET_QTY_SOLD_MTH2, double BUDGET_QTY_SOLD_MTH3, double BUDGET_QTY_SOLD_MTH4, double BUDGET_QTY_SOLD_MTH5, double BUDGET_QTY_SOLD_MTH6, double BUDGET_QTY_SOLD_MTH7, double BUDGET_QTY_SOLD_MTH8, double BUDGET_QTY_SOLD_MTH9, double BUDGET_QTY_SOLD_MTH10, double BUDGET_QTY_SOLD_MTH11, double BUDGET_QTY_SOLD_MTH12, double BUDGET_QTY_SOLD_FUTURE, double BUDGET_SALES_BF, double BUDGET_SALES_MTH1, double BUDGET_SALES_MTH2, double BUDGET_SALES_MTH3, double BUDGET_SALES_MTH4, double BUDGET_SALES_MTH5, double BUDGET_SALES_MTH6, double BUDGET_SALES_MTH7, double BUDGET_SALES_MTH8, double BUDGET_SALES_MTH9, double BUDGET_SALES_MTH10, double BUDGET_SALES_MTH11, double BUDGET_SALES_MTH12, double BUDGET_SALES_FUTURE, double PRIOR_YR_QTY_SOLD_BF, double PRIOR_YR_QTY_SOLD_MTH1, double PRIOR_YR_QTY_SOLD_MTH2, double PRIOR_YR_QTY_SOLD_MTH3, double PRIOR_YR_QTY_SOLD_MTH4, double PRIOR_YR_QTY_SOLD_MTH5, double PRIOR_YR_QTY_SOLD_MTH6, double PRIOR_YR_QTY_SOLD_MTH7, double PRIOR_YR_QTY_SOLD_MTH8, double PRIOR_YR_QTY_SOLD_MTH9, double PRIOR_YR_QTY_SOLD_MTH10, double PRIOR_YR_QTY_SOLD_MTH11, double PRIOR_YR_QTY_SOLD_MTH12, double PRIOR_YR_QTY_SOLD_FUTURE, double PRIOR_YR_SALES_BF, double PRIOR_YR_SALES_MTH1, double PRIOR_YR_SALES_MTH2, double PRIOR_YR_SALES_MTH3, double PRIOR_YR_SALES_MTH4, double PRIOR_YR_SALES_MTH5, double PRIOR_YR_SALES_MTH6, double PRIOR_YR_SALES_MTH7, double PRIOR_YR_SALES_MTH8, double PRIOR_YR_SALES_MTH9, double PRIOR_YR_SALES_MTH10, double PRIOR_YR_SALES_MTH11, double PRIOR_YR_SALES_MTH12, double PRIOR_YR_SALES_FUTURE, double PRIOR_YR_COST_BF, double PRIOR_YR_COST_MTH1, double PRIOR_YR_COST_MTH2, double PRIOR_YR_COST_MTH3, double PRIOR_YR_COST_MTH4, double PRIOR_YR_COST_MTH5, double PRIOR_YR_COST_MTH6, double PRIOR_YR_COST_MTH7, double PRIOR_YR_COST_MTH8, double PRIOR_YR_COST_MTH9, double PRIOR_YR_COST_MTH10, double PRIOR_YR_COST_MTH11, double PRIOR_YR_COST_MTH12, double PRIOR_YR_COST_FUTURE, double DISC_A_LEVEL_1_QTY, double DISC_A_LEVEL_2_QTY, double DISC_A_LEVEL_3_QTY, double DISC_A_LEVEL_4_QTY, double DISC_A_LEVEL_5_QTY, double DISC_A_LEVEL_6_QTY, double DISC_A_LEVEL_7_QTY, double DISC_A_LEVEL_8_QTY, double DISC_A_LEVEL_9_QTY, double DISC_A_LEVEL_10_QTY, double DISC_A_LEVEL_1_RATE, double DISC_A_LEVEL_2_RATE, double DISC_A_LEVEL_3_RATE, double DISC_A_LEVEL_4_RATE, double DISC_A_LEVEL_5_RATE, double DISC_A_LEVEL_6_RATE, double DISC_A_LEVEL_7_RATE, double DISC_A_LEVEL_8_RATE, double DISC_A_LEVEL_9_RATE, double DISC_A_LEVEL_10_RATE, double DISC_B_LEVEL_1_QTY, double DISC_B_LEVEL_2_QTY, double DISC_B_LEVEL_3_QTY, double DISC_B_LEVEL_4_QTY, double DISC_B_LEVEL_5_QTY, double DISC_B_LEVEL_6_QTY, double DISC_B_LEVEL_7_QTY, double DISC_B_LEVEL_8_QTY, double DISC_B_LEVEL_9_QTY, double DISC_B_LEVEL_10_QTY, double DISC_B_LEVEL_1_RATE, double DISC_B_LEVEL_2_RATE, double DISC_B_LEVEL_3_RATE, double DISC_B_LEVEL_4_RATE, double DISC_B_LEVEL_5_RATE, double DISC_B_LEVEL_6_RATE, double DISC_B_LEVEL_7_RATE, double DISC_B_LEVEL_8_RATE, double DISC_B_LEVEL_9_RATE, double DISC_B_LEVEL_10_RATE, double DISC_C_LEVEL_1_QTY, double DISC_C_LEVEL_2_QTY, double DISC_C_LEVEL_3_QTY, double DISC_C_LEVEL_4_QTY, double DISC_C_LEVEL_5_QTY, double DISC_C_LEVEL_6_QTY, double DISC_C_LEVEL_7_QTY, double DISC_C_LEVEL_8_QTY, double DISC_C_LEVEL_9_QTY, double DISC_C_LEVEL_10_QTY, double DISC_C_LEVEL_1_RATE, double DISC_C_LEVEL_2_RATE, double DISC_C_LEVEL_3_RATE, double DISC_C_LEVEL_4_RATE, double DISC_C_LEVEL_5_RATE, double DISC_C_LEVEL_6_RATE, double DISC_C_LEVEL_7_RATE, double DISC_C_LEVEL_8_RATE, double DISC_C_LEVEL_9_RATE, double DISC_C_LEVEL_10_RATE, double DISC_D_LEVEL_1_QTY, double DISC_D_LEVEL_2_QTY, double DISC_D_LEVEL_3_QTY, double DISC_D_LEVEL_4_QTY, double DISC_D_LEVEL_5_QTY, double DISC_D_LEVEL_6_QTY, double DISC_D_LEVEL_7_QTY, double DISC_D_LEVEL_8_QTY, double DISC_D_LEVEL_9_QTY, double DISC_D_LEVEL_10_QTY, double DISC_D_LEVEL_1_RATE, double DISC_D_LEVEL_2_RATE, double DISC_D_LEVEL_3_RATE, double DISC_D_LEVEL_4_RATE, double DISC_D_LEVEL_5_RATE, double DISC_D_LEVEL_6_RATE, double DISC_D_LEVEL_7_RATE, double DISC_D_LEVEL_8_RATE, double DISC_D_LEVEL_9_RATE, double DISC_D_LEVEL_10_RATE, double DISC_E_LEVEL_1_QTY, double DISC_E_LEVEL_2_QTY, double DISC_E_LEVEL_3_QTY, double DISC_E_LEVEL_4_QTY, double DISC_E_LEVEL_5_QTY, double DISC_E_LEVEL_6_QTY, double DISC_E_LEVEL_7_QTY, double DISC_E_LEVEL_8_QTY, double DISC_E_LEVEL_9_QTY, double DISC_E_LEVEL_10_QTY, double DISC_E_LEVEL_1_RATE, double DISC_E_LEVEL_2_RATE, double DISC_E_LEVEL_3_RATE, double DISC_E_LEVEL_4_RATE, double DISC_E_LEVEL_5_RATE, double DISC_E_LEVEL_6_RATE, double DISC_E_LEVEL_7_RATE, double DISC_E_LEVEL_8_RATE, double DISC_E_LEVEL_9_RATE, double DISC_E_LEVEL_10_RATE, string PURCHASE_NOMINAL_CODE, DateTime RECORD_CREATE_DATE, DateTime RECORD_MODIFY_DATE, short RECORD_DELETED)
		{
			ProductsListRow productsListRow = (ProductsListRow)NewRow();
			object[] itemArray = new object[361]
			{
				STOCK_CODE, DESCRIPTION, UNIT_OF_SALE, NOMINAL_CODE, PURCHASE_REF, SUPPLIER_PART_NUMBER, LOCATION, COMMODITY_CODE, SALES_PRICE, WEB_DESCRIPTION,
				WEB_DETAILS, WEB_CATEGORY_1, WEB_CATEGORY_2, WEB_CATEGORY_3, WEB_IMAGE_FILE, WEB_PUBLISH, WEB_SPECIAL, INTRASTAT_COMM_CODE, IGNORE_STK_LVL_FLAG, DEPT_NUMBER,
				DEPT_NAME, TAX_CODE, ASSEMBLY_LEVEL, LINK_LEVEL, STOCK_CAT, STOCK_CAT_NAME, STOCK_TAKE_DATE, LAST_PURCHASE_PRICE, LAST_DISC_PURCHASE_PRICE, AVERAGE_COST_PRICE,
				QTY_IN_STOCK, QTY_ON_ORDER, QTY_ALLOCATED, QTY_LAST_ORDER, QTY_REORDER, QTY_REORDER_LEVEL, QTY_LAST_STOCK_TAKE, QTY_MAKEUP, LAST_SALE_DATE, LAST_PURCHASE_DATE,
				UNIT_WEIGHT, HAS_NO_COMPONENT, HAS_BOM, BARCODE, COMPONENT_CODE_1, COMPONENT_CODE_2, COMPONENT_CODE_3, COMPONENT_CODE_4, COMPONENT_CODE_5, COMPONENT_CODE_6,
				COMPONENT_CODE_7, COMPONENT_CODE_8, COMPONENT_CODE_9, COMPONENT_CODE_10, COMPONENT_CODE_11, COMPONENT_CODE_12, COMPONENT_CODE_13, COMPONENT_CODE_14, COMPONENT_CODE_15, COMPONENT_CODE_16,
				COMPONENT_CODE_17, COMPONENT_CODE_18, COMPONENT_CODE_19, COMPONENT_CODE_20, COMPONENT_CODE_21, COMPONENT_CODE_22, COMPONENT_CODE_23, COMPONENT_CODE_24, COMPONENT_CODE_25, COMPONENT_CODE_26,
				COMPONENT_CODE_27, COMPONENT_CODE_28, COMPONENT_CODE_29, COMPONENT_CODE_30, COMPONENT_CODE_31, COMPONENT_CODE_32, COMPONENT_CODE_33, COMPONENT_CODE_34, COMPONENT_CODE_35, COMPONENT_CODE_36,
				COMPONENT_CODE_37, COMPONENT_CODE_38, COMPONENT_CODE_39, COMPONENT_CODE_40, COMPONENT_CODE_41, COMPONENT_CODE_42, COMPONENT_CODE_43, COMPONENT_CODE_44, COMPONENT_CODE_45, COMPONENT_CODE_46,
				COMPONENT_CODE_47, COMPONENT_CODE_48, COMPONENT_CODE_49, COMPONENT_CODE_50, COMPONENT_QTY_1, COMPONENT_QTY_2, COMPONENT_QTY_3, COMPONENT_QTY_4, COMPONENT_QTY_5, COMPONENT_QTY_6,
				COMPONENT_QTY_7, COMPONENT_QTY_8, COMPONENT_QTY_9, COMPONENT_QTY_10, COMPONENT_QTY_11, COMPONENT_QTY_12, COMPONENT_QTY_13, COMPONENT_QTY_14, COMPONENT_QTY_15, COMPONENT_QTY_16,
				COMPONENT_QTY_17, COMPONENT_QTY_18, COMPONENT_QTY_19, COMPONENT_QTY_20, COMPONENT_QTY_21, COMPONENT_QTY_22, COMPONENT_QTY_23, COMPONENT_QTY_24, COMPONENT_QTY_25, COMPONENT_QTY_26,
				COMPONENT_QTY_27, COMPONENT_QTY_28, COMPONENT_QTY_29, COMPONENT_QTY_30, COMPONENT_QTY_31, COMPONENT_QTY_32, COMPONENT_QTY_33, COMPONENT_QTY_34, COMPONENT_QTY_35, COMPONENT_QTY_36,
				COMPONENT_QTY_37, COMPONENT_QTY_38, COMPONENT_QTY_39, COMPONENT_QTY_40, COMPONENT_QTY_41, COMPONENT_QTY_42, COMPONENT_QTY_43, COMPONENT_QTY_44, COMPONENT_QTY_45, COMPONENT_QTY_46,
				COMPONENT_QTY_47, COMPONENT_QTY_48, COMPONENT_QTY_49, COMPONENT_QTY_50, QTY_SOLD_BF, QTY_SOLD_MTH1, QTY_SOLD_MTH2, QTY_SOLD_MTH3, QTY_SOLD_MTH4, QTY_SOLD_MTH5,
				QTY_SOLD_MTH6, QTY_SOLD_MTH7, QTY_SOLD_MTH8, QTY_SOLD_MTH9, QTY_SOLD_MTH10, QTY_SOLD_MTH11, QTY_SOLD_MTH12, QTY_SOLD_FUTURE, SALES_BF, SALES_MTH1,
				SALES_MTH2, SALES_MTH3, SALES_MTH4, SALES_MTH5, SALES_MTH6, SALES_MTH7, SALES_MTH8, SALES_MTH9, SALES_MTH10, SALES_MTH11,
				SALES_MTH12, SALES_FUTURE, COST_BF, COST_MTH1, COST_MTH2, COST_MTH3, COST_MTH4, COST_MTH5, COST_MTH6, COST_MTH7,
				COST_MTH8, COST_MTH9, COST_MTH10, COST_MTH11, COST_MTH12, COST_FUTURE, THIS_RECORD, BUDGET_QTY_SOLD_BF, BUDGET_QTY_SOLD_MTH1, BUDGET_QTY_SOLD_MTH2,
				BUDGET_QTY_SOLD_MTH3, BUDGET_QTY_SOLD_MTH4, BUDGET_QTY_SOLD_MTH5, BUDGET_QTY_SOLD_MTH6, BUDGET_QTY_SOLD_MTH7, BUDGET_QTY_SOLD_MTH8, BUDGET_QTY_SOLD_MTH9, BUDGET_QTY_SOLD_MTH10, BUDGET_QTY_SOLD_MTH11, BUDGET_QTY_SOLD_MTH12,
				BUDGET_QTY_SOLD_FUTURE, BUDGET_SALES_BF, BUDGET_SALES_MTH1, BUDGET_SALES_MTH2, BUDGET_SALES_MTH3, BUDGET_SALES_MTH4, BUDGET_SALES_MTH5, BUDGET_SALES_MTH6, BUDGET_SALES_MTH7, BUDGET_SALES_MTH8,
				BUDGET_SALES_MTH9, BUDGET_SALES_MTH10, BUDGET_SALES_MTH11, BUDGET_SALES_MTH12, BUDGET_SALES_FUTURE, PRIOR_YR_QTY_SOLD_BF, PRIOR_YR_QTY_SOLD_MTH1, PRIOR_YR_QTY_SOLD_MTH2, PRIOR_YR_QTY_SOLD_MTH3, PRIOR_YR_QTY_SOLD_MTH4,
				PRIOR_YR_QTY_SOLD_MTH5, PRIOR_YR_QTY_SOLD_MTH6, PRIOR_YR_QTY_SOLD_MTH7, PRIOR_YR_QTY_SOLD_MTH8, PRIOR_YR_QTY_SOLD_MTH9, PRIOR_YR_QTY_SOLD_MTH10, PRIOR_YR_QTY_SOLD_MTH11, PRIOR_YR_QTY_SOLD_MTH12, PRIOR_YR_QTY_SOLD_FUTURE, PRIOR_YR_SALES_BF,
				PRIOR_YR_SALES_MTH1, PRIOR_YR_SALES_MTH2, PRIOR_YR_SALES_MTH3, PRIOR_YR_SALES_MTH4, PRIOR_YR_SALES_MTH5, PRIOR_YR_SALES_MTH6, PRIOR_YR_SALES_MTH7, PRIOR_YR_SALES_MTH8, PRIOR_YR_SALES_MTH9, PRIOR_YR_SALES_MTH10,
				PRIOR_YR_SALES_MTH11, PRIOR_YR_SALES_MTH12, PRIOR_YR_SALES_FUTURE, PRIOR_YR_COST_BF, PRIOR_YR_COST_MTH1, PRIOR_YR_COST_MTH2, PRIOR_YR_COST_MTH3, PRIOR_YR_COST_MTH4, PRIOR_YR_COST_MTH5, PRIOR_YR_COST_MTH6,
				PRIOR_YR_COST_MTH7, PRIOR_YR_COST_MTH8, PRIOR_YR_COST_MTH9, PRIOR_YR_COST_MTH10, PRIOR_YR_COST_MTH11, PRIOR_YR_COST_MTH12, PRIOR_YR_COST_FUTURE, DISC_A_LEVEL_1_QTY, DISC_A_LEVEL_2_QTY, DISC_A_LEVEL_3_QTY,
				DISC_A_LEVEL_4_QTY, DISC_A_LEVEL_5_QTY, DISC_A_LEVEL_6_QTY, DISC_A_LEVEL_7_QTY, DISC_A_LEVEL_8_QTY, DISC_A_LEVEL_9_QTY, DISC_A_LEVEL_10_QTY, DISC_A_LEVEL_1_RATE, DISC_A_LEVEL_2_RATE, DISC_A_LEVEL_3_RATE,
				DISC_A_LEVEL_4_RATE, DISC_A_LEVEL_5_RATE, DISC_A_LEVEL_6_RATE, DISC_A_LEVEL_7_RATE, DISC_A_LEVEL_8_RATE, DISC_A_LEVEL_9_RATE, DISC_A_LEVEL_10_RATE, DISC_B_LEVEL_1_QTY, DISC_B_LEVEL_2_QTY, DISC_B_LEVEL_3_QTY,
				DISC_B_LEVEL_4_QTY, DISC_B_LEVEL_5_QTY, DISC_B_LEVEL_6_QTY, DISC_B_LEVEL_7_QTY, DISC_B_LEVEL_8_QTY, DISC_B_LEVEL_9_QTY, DISC_B_LEVEL_10_QTY, DISC_B_LEVEL_1_RATE, DISC_B_LEVEL_2_RATE, DISC_B_LEVEL_3_RATE,
				DISC_B_LEVEL_4_RATE, DISC_B_LEVEL_5_RATE, DISC_B_LEVEL_6_RATE, DISC_B_LEVEL_7_RATE, DISC_B_LEVEL_8_RATE, DISC_B_LEVEL_9_RATE, DISC_B_LEVEL_10_RATE, DISC_C_LEVEL_1_QTY, DISC_C_LEVEL_2_QTY, DISC_C_LEVEL_3_QTY,
				DISC_C_LEVEL_4_QTY, DISC_C_LEVEL_5_QTY, DISC_C_LEVEL_6_QTY, DISC_C_LEVEL_7_QTY, DISC_C_LEVEL_8_QTY, DISC_C_LEVEL_9_QTY, DISC_C_LEVEL_10_QTY, DISC_C_LEVEL_1_RATE, DISC_C_LEVEL_2_RATE, DISC_C_LEVEL_3_RATE,
				DISC_C_LEVEL_4_RATE, DISC_C_LEVEL_5_RATE, DISC_C_LEVEL_6_RATE, DISC_C_LEVEL_7_RATE, DISC_C_LEVEL_8_RATE, DISC_C_LEVEL_9_RATE, DISC_C_LEVEL_10_RATE, DISC_D_LEVEL_1_QTY, DISC_D_LEVEL_2_QTY, DISC_D_LEVEL_3_QTY,
				DISC_D_LEVEL_4_QTY, DISC_D_LEVEL_5_QTY, DISC_D_LEVEL_6_QTY, DISC_D_LEVEL_7_QTY, DISC_D_LEVEL_8_QTY, DISC_D_LEVEL_9_QTY, DISC_D_LEVEL_10_QTY, DISC_D_LEVEL_1_RATE, DISC_D_LEVEL_2_RATE, DISC_D_LEVEL_3_RATE,
				DISC_D_LEVEL_4_RATE, DISC_D_LEVEL_5_RATE, DISC_D_LEVEL_6_RATE, DISC_D_LEVEL_7_RATE, DISC_D_LEVEL_8_RATE, DISC_D_LEVEL_9_RATE, DISC_D_LEVEL_10_RATE, DISC_E_LEVEL_1_QTY, DISC_E_LEVEL_2_QTY, DISC_E_LEVEL_3_QTY,
				DISC_E_LEVEL_4_QTY, DISC_E_LEVEL_5_QTY, DISC_E_LEVEL_6_QTY, DISC_E_LEVEL_7_QTY, DISC_E_LEVEL_8_QTY, DISC_E_LEVEL_9_QTY, DISC_E_LEVEL_10_QTY, DISC_E_LEVEL_1_RATE, DISC_E_LEVEL_2_RATE, DISC_E_LEVEL_3_RATE,
				DISC_E_LEVEL_4_RATE, DISC_E_LEVEL_5_RATE, DISC_E_LEVEL_6_RATE, DISC_E_LEVEL_7_RATE, DISC_E_LEVEL_8_RATE, DISC_E_LEVEL_9_RATE, DISC_E_LEVEL_10_RATE, PURCHASE_NOMINAL_CODE, RECORD_CREATE_DATE, RECORD_MODIFY_DATE,
				RECORD_DELETED
			};
			productsListRow.ItemArray = itemArray;
			base.Rows.Add(productsListRow);
			return productsListRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			ProductsListDataTable obj = (ProductsListDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new ProductsListDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnSTOCK_CODE = base.Columns["STOCK_CODE"];
			columnDESCRIPTION = base.Columns["DESCRIPTION"];
			columnUNIT_OF_SALE = base.Columns["UNIT_OF_SALE"];
			columnNOMINAL_CODE = base.Columns["NOMINAL_CODE"];
			columnPURCHASE_REF = base.Columns["PURCHASE_REF"];
			columnSUPPLIER_PART_NUMBER = base.Columns["SUPPLIER_PART_NUMBER"];
			columnLOCATION = base.Columns["LOCATION"];
			columnCOMMODITY_CODE = base.Columns["COMMODITY_CODE"];
			columnSALES_PRICE = base.Columns["SALES_PRICE"];
			columnWEB_DESCRIPTION = base.Columns["WEB_DESCRIPTION"];
			columnWEB_DETAILS = base.Columns["WEB_DETAILS"];
			columnWEB_CATEGORY_1 = base.Columns["WEB_CATEGORY_1"];
			columnWEB_CATEGORY_2 = base.Columns["WEB_CATEGORY_2"];
			columnWEB_CATEGORY_3 = base.Columns["WEB_CATEGORY_3"];
			columnWEB_IMAGE_FILE = base.Columns["WEB_IMAGE_FILE"];
			columnWEB_PUBLISH = base.Columns["WEB_PUBLISH"];
			columnWEB_SPECIAL = base.Columns["WEB_SPECIAL"];
			columnINTRASTAT_COMM_CODE = base.Columns["INTRASTAT_COMM_CODE"];
			columnIGNORE_STK_LVL_FLAG = base.Columns["IGNORE_STK_LVL_FLAG"];
			columnDEPT_NUMBER = base.Columns["DEPT_NUMBER"];
			columnDEPT_NAME = base.Columns["DEPT_NAME"];
			columnTAX_CODE = base.Columns["TAX_CODE"];
			columnASSEMBLY_LEVEL = base.Columns["ASSEMBLY_LEVEL"];
			columnLINK_LEVEL = base.Columns["LINK_LEVEL"];
			columnSTOCK_CAT = base.Columns["STOCK_CAT"];
			columnSTOCK_CAT_NAME = base.Columns["STOCK_CAT_NAME"];
			columnSTOCK_TAKE_DATE = base.Columns["STOCK_TAKE_DATE"];
			columnLAST_PURCHASE_PRICE = base.Columns["LAST_PURCHASE_PRICE"];
			columnLAST_DISC_PURCHASE_PRICE = base.Columns["LAST_DISC_PURCHASE_PRICE"];
			columnAVERAGE_COST_PRICE = base.Columns["AVERAGE_COST_PRICE"];
			columnQTY_IN_STOCK = base.Columns["QTY_IN_STOCK"];
			columnQTY_ON_ORDER = base.Columns["QTY_ON_ORDER"];
			columnQTY_ALLOCATED = base.Columns["QTY_ALLOCATED"];
			columnQTY_LAST_ORDER = base.Columns["QTY_LAST_ORDER"];
			columnQTY_REORDER = base.Columns["QTY_REORDER"];
			columnQTY_REORDER_LEVEL = base.Columns["QTY_REORDER_LEVEL"];
			columnQTY_LAST_STOCK_TAKE = base.Columns["QTY_LAST_STOCK_TAKE"];
			columnQTY_MAKEUP = base.Columns["QTY_MAKEUP"];
			columnLAST_SALE_DATE = base.Columns["LAST_SALE_DATE"];
			columnLAST_PURCHASE_DATE = base.Columns["LAST_PURCHASE_DATE"];
			columnUNIT_WEIGHT = base.Columns["UNIT_WEIGHT"];
			columnHAS_NO_COMPONENT = base.Columns["HAS_NO_COMPONENT"];
			columnHAS_BOM = base.Columns["HAS_BOM"];
			columnBARCODE = base.Columns["BARCODE"];
			columnCOMPONENT_CODE_1 = base.Columns["COMPONENT_CODE_1"];
			columnCOMPONENT_CODE_2 = base.Columns["COMPONENT_CODE_2"];
			columnCOMPONENT_CODE_3 = base.Columns["COMPONENT_CODE_3"];
			columnCOMPONENT_CODE_4 = base.Columns["COMPONENT_CODE_4"];
			columnCOMPONENT_CODE_5 = base.Columns["COMPONENT_CODE_5"];
			columnCOMPONENT_CODE_6 = base.Columns["COMPONENT_CODE_6"];
			columnCOMPONENT_CODE_7 = base.Columns["COMPONENT_CODE_7"];
			columnCOMPONENT_CODE_8 = base.Columns["COMPONENT_CODE_8"];
			columnCOMPONENT_CODE_9 = base.Columns["COMPONENT_CODE_9"];
			columnCOMPONENT_CODE_10 = base.Columns["COMPONENT_CODE_10"];
			columnCOMPONENT_CODE_11 = base.Columns["COMPONENT_CODE_11"];
			columnCOMPONENT_CODE_12 = base.Columns["COMPONENT_CODE_12"];
			columnCOMPONENT_CODE_13 = base.Columns["COMPONENT_CODE_13"];
			columnCOMPONENT_CODE_14 = base.Columns["COMPONENT_CODE_14"];
			columnCOMPONENT_CODE_15 = base.Columns["COMPONENT_CODE_15"];
			columnCOMPONENT_CODE_16 = base.Columns["COMPONENT_CODE_16"];
			columnCOMPONENT_CODE_17 = base.Columns["COMPONENT_CODE_17"];
			columnCOMPONENT_CODE_18 = base.Columns["COMPONENT_CODE_18"];
			columnCOMPONENT_CODE_19 = base.Columns["COMPONENT_CODE_19"];
			columnCOMPONENT_CODE_20 = base.Columns["COMPONENT_CODE_20"];
			columnCOMPONENT_CODE_21 = base.Columns["COMPONENT_CODE_21"];
			columnCOMPONENT_CODE_22 = base.Columns["COMPONENT_CODE_22"];
			columnCOMPONENT_CODE_23 = base.Columns["COMPONENT_CODE_23"];
			columnCOMPONENT_CODE_24 = base.Columns["COMPONENT_CODE_24"];
			columnCOMPONENT_CODE_25 = base.Columns["COMPONENT_CODE_25"];
			columnCOMPONENT_CODE_26 = base.Columns["COMPONENT_CODE_26"];
			columnCOMPONENT_CODE_27 = base.Columns["COMPONENT_CODE_27"];
			columnCOMPONENT_CODE_28 = base.Columns["COMPONENT_CODE_28"];
			columnCOMPONENT_CODE_29 = base.Columns["COMPONENT_CODE_29"];
			columnCOMPONENT_CODE_30 = base.Columns["COMPONENT_CODE_30"];
			columnCOMPONENT_CODE_31 = base.Columns["COMPONENT_CODE_31"];
			columnCOMPONENT_CODE_32 = base.Columns["COMPONENT_CODE_32"];
			columnCOMPONENT_CODE_33 = base.Columns["COMPONENT_CODE_33"];
			columnCOMPONENT_CODE_34 = base.Columns["COMPONENT_CODE_34"];
			columnCOMPONENT_CODE_35 = base.Columns["COMPONENT_CODE_35"];
			columnCOMPONENT_CODE_36 = base.Columns["COMPONENT_CODE_36"];
			columnCOMPONENT_CODE_37 = base.Columns["COMPONENT_CODE_37"];
			columnCOMPONENT_CODE_38 = base.Columns["COMPONENT_CODE_38"];
			columnCOMPONENT_CODE_39 = base.Columns["COMPONENT_CODE_39"];
			columnCOMPONENT_CODE_40 = base.Columns["COMPONENT_CODE_40"];
			columnCOMPONENT_CODE_41 = base.Columns["COMPONENT_CODE_41"];
			columnCOMPONENT_CODE_42 = base.Columns["COMPONENT_CODE_42"];
			columnCOMPONENT_CODE_43 = base.Columns["COMPONENT_CODE_43"];
			columnCOMPONENT_CODE_44 = base.Columns["COMPONENT_CODE_44"];
			columnCOMPONENT_CODE_45 = base.Columns["COMPONENT_CODE_45"];
			columnCOMPONENT_CODE_46 = base.Columns["COMPONENT_CODE_46"];
			columnCOMPONENT_CODE_47 = base.Columns["COMPONENT_CODE_47"];
			columnCOMPONENT_CODE_48 = base.Columns["COMPONENT_CODE_48"];
			columnCOMPONENT_CODE_49 = base.Columns["COMPONENT_CODE_49"];
			columnCOMPONENT_CODE_50 = base.Columns["COMPONENT_CODE_50"];
			columnCOMPONENT_QTY_1 = base.Columns["COMPONENT_QTY_1"];
			columnCOMPONENT_QTY_2 = base.Columns["COMPONENT_QTY_2"];
			columnCOMPONENT_QTY_3 = base.Columns["COMPONENT_QTY_3"];
			columnCOMPONENT_QTY_4 = base.Columns["COMPONENT_QTY_4"];
			columnCOMPONENT_QTY_5 = base.Columns["COMPONENT_QTY_5"];
			columnCOMPONENT_QTY_6 = base.Columns["COMPONENT_QTY_6"];
			columnCOMPONENT_QTY_7 = base.Columns["COMPONENT_QTY_7"];
			columnCOMPONENT_QTY_8 = base.Columns["COMPONENT_QTY_8"];
			columnCOMPONENT_QTY_9 = base.Columns["COMPONENT_QTY_9"];
			columnCOMPONENT_QTY_10 = base.Columns["COMPONENT_QTY_10"];
			columnCOMPONENT_QTY_11 = base.Columns["COMPONENT_QTY_11"];
			columnCOMPONENT_QTY_12 = base.Columns["COMPONENT_QTY_12"];
			columnCOMPONENT_QTY_13 = base.Columns["COMPONENT_QTY_13"];
			columnCOMPONENT_QTY_14 = base.Columns["COMPONENT_QTY_14"];
			columnCOMPONENT_QTY_15 = base.Columns["COMPONENT_QTY_15"];
			columnCOMPONENT_QTY_16 = base.Columns["COMPONENT_QTY_16"];
			columnCOMPONENT_QTY_17 = base.Columns["COMPONENT_QTY_17"];
			columnCOMPONENT_QTY_18 = base.Columns["COMPONENT_QTY_18"];
			columnCOMPONENT_QTY_19 = base.Columns["COMPONENT_QTY_19"];
			columnCOMPONENT_QTY_20 = base.Columns["COMPONENT_QTY_20"];
			columnCOMPONENT_QTY_21 = base.Columns["COMPONENT_QTY_21"];
			columnCOMPONENT_QTY_22 = base.Columns["COMPONENT_QTY_22"];
			columnCOMPONENT_QTY_23 = base.Columns["COMPONENT_QTY_23"];
			columnCOMPONENT_QTY_24 = base.Columns["COMPONENT_QTY_24"];
			columnCOMPONENT_QTY_25 = base.Columns["COMPONENT_QTY_25"];
			columnCOMPONENT_QTY_26 = base.Columns["COMPONENT_QTY_26"];
			columnCOMPONENT_QTY_27 = base.Columns["COMPONENT_QTY_27"];
			columnCOMPONENT_QTY_28 = base.Columns["COMPONENT_QTY_28"];
			columnCOMPONENT_QTY_29 = base.Columns["COMPONENT_QTY_29"];
			columnCOMPONENT_QTY_30 = base.Columns["COMPONENT_QTY_30"];
			columnCOMPONENT_QTY_31 = base.Columns["COMPONENT_QTY_31"];
			columnCOMPONENT_QTY_32 = base.Columns["COMPONENT_QTY_32"];
			columnCOMPONENT_QTY_33 = base.Columns["COMPONENT_QTY_33"];
			columnCOMPONENT_QTY_34 = base.Columns["COMPONENT_QTY_34"];
			columnCOMPONENT_QTY_35 = base.Columns["COMPONENT_QTY_35"];
			columnCOMPONENT_QTY_36 = base.Columns["COMPONENT_QTY_36"];
			columnCOMPONENT_QTY_37 = base.Columns["COMPONENT_QTY_37"];
			columnCOMPONENT_QTY_38 = base.Columns["COMPONENT_QTY_38"];
			columnCOMPONENT_QTY_39 = base.Columns["COMPONENT_QTY_39"];
			columnCOMPONENT_QTY_40 = base.Columns["COMPONENT_QTY_40"];
			columnCOMPONENT_QTY_41 = base.Columns["COMPONENT_QTY_41"];
			columnCOMPONENT_QTY_42 = base.Columns["COMPONENT_QTY_42"];
			columnCOMPONENT_QTY_43 = base.Columns["COMPONENT_QTY_43"];
			columnCOMPONENT_QTY_44 = base.Columns["COMPONENT_QTY_44"];
			columnCOMPONENT_QTY_45 = base.Columns["COMPONENT_QTY_45"];
			columnCOMPONENT_QTY_46 = base.Columns["COMPONENT_QTY_46"];
			columnCOMPONENT_QTY_47 = base.Columns["COMPONENT_QTY_47"];
			columnCOMPONENT_QTY_48 = base.Columns["COMPONENT_QTY_48"];
			columnCOMPONENT_QTY_49 = base.Columns["COMPONENT_QTY_49"];
			columnCOMPONENT_QTY_50 = base.Columns["COMPONENT_QTY_50"];
			columnQTY_SOLD_BF = base.Columns["QTY_SOLD_BF"];
			columnQTY_SOLD_MTH1 = base.Columns["QTY_SOLD_MTH1"];
			columnQTY_SOLD_MTH2 = base.Columns["QTY_SOLD_MTH2"];
			columnQTY_SOLD_MTH3 = base.Columns["QTY_SOLD_MTH3"];
			columnQTY_SOLD_MTH4 = base.Columns["QTY_SOLD_MTH4"];
			columnQTY_SOLD_MTH5 = base.Columns["QTY_SOLD_MTH5"];
			columnQTY_SOLD_MTH6 = base.Columns["QTY_SOLD_MTH6"];
			columnQTY_SOLD_MTH7 = base.Columns["QTY_SOLD_MTH7"];
			columnQTY_SOLD_MTH8 = base.Columns["QTY_SOLD_MTH8"];
			columnQTY_SOLD_MTH9 = base.Columns["QTY_SOLD_MTH9"];
			columnQTY_SOLD_MTH10 = base.Columns["QTY_SOLD_MTH10"];
			columnQTY_SOLD_MTH11 = base.Columns["QTY_SOLD_MTH11"];
			columnQTY_SOLD_MTH12 = base.Columns["QTY_SOLD_MTH12"];
			columnQTY_SOLD_FUTURE = base.Columns["QTY_SOLD_FUTURE"];
			columnSALES_BF = base.Columns["SALES_BF"];
			columnSALES_MTH1 = base.Columns["SALES_MTH1"];
			columnSALES_MTH2 = base.Columns["SALES_MTH2"];
			columnSALES_MTH3 = base.Columns["SALES_MTH3"];
			columnSALES_MTH4 = base.Columns["SALES_MTH4"];
			columnSALES_MTH5 = base.Columns["SALES_MTH5"];
			columnSALES_MTH6 = base.Columns["SALES_MTH6"];
			columnSALES_MTH7 = base.Columns["SALES_MTH7"];
			columnSALES_MTH8 = base.Columns["SALES_MTH8"];
			columnSALES_MTH9 = base.Columns["SALES_MTH9"];
			columnSALES_MTH10 = base.Columns["SALES_MTH10"];
			columnSALES_MTH11 = base.Columns["SALES_MTH11"];
			columnSALES_MTH12 = base.Columns["SALES_MTH12"];
			columnSALES_FUTURE = base.Columns["SALES_FUTURE"];
			columnCOST_BF = base.Columns["COST_BF"];
			columnCOST_MTH1 = base.Columns["COST_MTH1"];
			columnCOST_MTH2 = base.Columns["COST_MTH2"];
			columnCOST_MTH3 = base.Columns["COST_MTH3"];
			columnCOST_MTH4 = base.Columns["COST_MTH4"];
			columnCOST_MTH5 = base.Columns["COST_MTH5"];
			columnCOST_MTH6 = base.Columns["COST_MTH6"];
			columnCOST_MTH7 = base.Columns["COST_MTH7"];
			columnCOST_MTH8 = base.Columns["COST_MTH8"];
			columnCOST_MTH9 = base.Columns["COST_MTH9"];
			columnCOST_MTH10 = base.Columns["COST_MTH10"];
			columnCOST_MTH11 = base.Columns["COST_MTH11"];
			columnCOST_MTH12 = base.Columns["COST_MTH12"];
			columnCOST_FUTURE = base.Columns["COST_FUTURE"];
			columnTHIS_RECORD = base.Columns["THIS_RECORD"];
			columnBUDGET_QTY_SOLD_BF = base.Columns["BUDGET_QTY_SOLD_BF"];
			columnBUDGET_QTY_SOLD_MTH1 = base.Columns["BUDGET_QTY_SOLD_MTH1"];
			columnBUDGET_QTY_SOLD_MTH2 = base.Columns["BUDGET_QTY_SOLD_MTH2"];
			columnBUDGET_QTY_SOLD_MTH3 = base.Columns["BUDGET_QTY_SOLD_MTH3"];
			columnBUDGET_QTY_SOLD_MTH4 = base.Columns["BUDGET_QTY_SOLD_MTH4"];
			columnBUDGET_QTY_SOLD_MTH5 = base.Columns["BUDGET_QTY_SOLD_MTH5"];
			columnBUDGET_QTY_SOLD_MTH6 = base.Columns["BUDGET_QTY_SOLD_MTH6"];
			columnBUDGET_QTY_SOLD_MTH7 = base.Columns["BUDGET_QTY_SOLD_MTH7"];
			columnBUDGET_QTY_SOLD_MTH8 = base.Columns["BUDGET_QTY_SOLD_MTH8"];
			columnBUDGET_QTY_SOLD_MTH9 = base.Columns["BUDGET_QTY_SOLD_MTH9"];
			columnBUDGET_QTY_SOLD_MTH10 = base.Columns["BUDGET_QTY_SOLD_MTH10"];
			columnBUDGET_QTY_SOLD_MTH11 = base.Columns["BUDGET_QTY_SOLD_MTH11"];
			columnBUDGET_QTY_SOLD_MTH12 = base.Columns["BUDGET_QTY_SOLD_MTH12"];
			columnBUDGET_QTY_SOLD_FUTURE = base.Columns["BUDGET_QTY_SOLD_FUTURE"];
			columnBUDGET_SALES_BF = base.Columns["BUDGET_SALES_BF"];
			columnBUDGET_SALES_MTH1 = base.Columns["BUDGET_SALES_MTH1"];
			columnBUDGET_SALES_MTH2 = base.Columns["BUDGET_SALES_MTH2"];
			columnBUDGET_SALES_MTH3 = base.Columns["BUDGET_SALES_MTH3"];
			columnBUDGET_SALES_MTH4 = base.Columns["BUDGET_SALES_MTH4"];
			columnBUDGET_SALES_MTH5 = base.Columns["BUDGET_SALES_MTH5"];
			columnBUDGET_SALES_MTH6 = base.Columns["BUDGET_SALES_MTH6"];
			columnBUDGET_SALES_MTH7 = base.Columns["BUDGET_SALES_MTH7"];
			columnBUDGET_SALES_MTH8 = base.Columns["BUDGET_SALES_MTH8"];
			columnBUDGET_SALES_MTH9 = base.Columns["BUDGET_SALES_MTH9"];
			columnBUDGET_SALES_MTH10 = base.Columns["BUDGET_SALES_MTH10"];
			columnBUDGET_SALES_MTH11 = base.Columns["BUDGET_SALES_MTH11"];
			columnBUDGET_SALES_MTH12 = base.Columns["BUDGET_SALES_MTH12"];
			columnBUDGET_SALES_FUTURE = base.Columns["BUDGET_SALES_FUTURE"];
			columnPRIOR_YR_QTY_SOLD_BF = base.Columns["PRIOR_YR_QTY_SOLD_BF"];
			columnPRIOR_YR_QTY_SOLD_MTH1 = base.Columns["PRIOR_YR_QTY_SOLD_MTH1"];
			columnPRIOR_YR_QTY_SOLD_MTH2 = base.Columns["PRIOR_YR_QTY_SOLD_MTH2"];
			columnPRIOR_YR_QTY_SOLD_MTH3 = base.Columns["PRIOR_YR_QTY_SOLD_MTH3"];
			columnPRIOR_YR_QTY_SOLD_MTH4 = base.Columns["PRIOR_YR_QTY_SOLD_MTH4"];
			columnPRIOR_YR_QTY_SOLD_MTH5 = base.Columns["PRIOR_YR_QTY_SOLD_MTH5"];
			columnPRIOR_YR_QTY_SOLD_MTH6 = base.Columns["PRIOR_YR_QTY_SOLD_MTH6"];
			columnPRIOR_YR_QTY_SOLD_MTH7 = base.Columns["PRIOR_YR_QTY_SOLD_MTH7"];
			columnPRIOR_YR_QTY_SOLD_MTH8 = base.Columns["PRIOR_YR_QTY_SOLD_MTH8"];
			columnPRIOR_YR_QTY_SOLD_MTH9 = base.Columns["PRIOR_YR_QTY_SOLD_MTH9"];
			columnPRIOR_YR_QTY_SOLD_MTH10 = base.Columns["PRIOR_YR_QTY_SOLD_MTH10"];
			columnPRIOR_YR_QTY_SOLD_MTH11 = base.Columns["PRIOR_YR_QTY_SOLD_MTH11"];
			columnPRIOR_YR_QTY_SOLD_MTH12 = base.Columns["PRIOR_YR_QTY_SOLD_MTH12"];
			columnPRIOR_YR_QTY_SOLD_FUTURE = base.Columns["PRIOR_YR_QTY_SOLD_FUTURE"];
			columnPRIOR_YR_SALES_BF = base.Columns["PRIOR_YR_SALES_BF"];
			columnPRIOR_YR_SALES_MTH1 = base.Columns["PRIOR_YR_SALES_MTH1"];
			columnPRIOR_YR_SALES_MTH2 = base.Columns["PRIOR_YR_SALES_MTH2"];
			columnPRIOR_YR_SALES_MTH3 = base.Columns["PRIOR_YR_SALES_MTH3"];
			columnPRIOR_YR_SALES_MTH4 = base.Columns["PRIOR_YR_SALES_MTH4"];
			columnPRIOR_YR_SALES_MTH5 = base.Columns["PRIOR_YR_SALES_MTH5"];
			columnPRIOR_YR_SALES_MTH6 = base.Columns["PRIOR_YR_SALES_MTH6"];
			columnPRIOR_YR_SALES_MTH7 = base.Columns["PRIOR_YR_SALES_MTH7"];
			columnPRIOR_YR_SALES_MTH8 = base.Columns["PRIOR_YR_SALES_MTH8"];
			columnPRIOR_YR_SALES_MTH9 = base.Columns["PRIOR_YR_SALES_MTH9"];
			columnPRIOR_YR_SALES_MTH10 = base.Columns["PRIOR_YR_SALES_MTH10"];
			columnPRIOR_YR_SALES_MTH11 = base.Columns["PRIOR_YR_SALES_MTH11"];
			columnPRIOR_YR_SALES_MTH12 = base.Columns["PRIOR_YR_SALES_MTH12"];
			columnPRIOR_YR_SALES_FUTURE = base.Columns["PRIOR_YR_SALES_FUTURE"];
			columnPRIOR_YR_COST_BF = base.Columns["PRIOR_YR_COST_BF"];
			columnPRIOR_YR_COST_MTH1 = base.Columns["PRIOR_YR_COST_MTH1"];
			columnPRIOR_YR_COST_MTH2 = base.Columns["PRIOR_YR_COST_MTH2"];
			columnPRIOR_YR_COST_MTH3 = base.Columns["PRIOR_YR_COST_MTH3"];
			columnPRIOR_YR_COST_MTH4 = base.Columns["PRIOR_YR_COST_MTH4"];
			columnPRIOR_YR_COST_MTH5 = base.Columns["PRIOR_YR_COST_MTH5"];
			columnPRIOR_YR_COST_MTH6 = base.Columns["PRIOR_YR_COST_MTH6"];
			columnPRIOR_YR_COST_MTH7 = base.Columns["PRIOR_YR_COST_MTH7"];
			columnPRIOR_YR_COST_MTH8 = base.Columns["PRIOR_YR_COST_MTH8"];
			columnPRIOR_YR_COST_MTH9 = base.Columns["PRIOR_YR_COST_MTH9"];
			columnPRIOR_YR_COST_MTH10 = base.Columns["PRIOR_YR_COST_MTH10"];
			columnPRIOR_YR_COST_MTH11 = base.Columns["PRIOR_YR_COST_MTH11"];
			columnPRIOR_YR_COST_MTH12 = base.Columns["PRIOR_YR_COST_MTH12"];
			columnPRIOR_YR_COST_FUTURE = base.Columns["PRIOR_YR_COST_FUTURE"];
			columnDISC_A_LEVEL_1_QTY = base.Columns["DISC_A_LEVEL_1_QTY"];
			columnDISC_A_LEVEL_2_QTY = base.Columns["DISC_A_LEVEL_2_QTY"];
			columnDISC_A_LEVEL_3_QTY = base.Columns["DISC_A_LEVEL_3_QTY"];
			columnDISC_A_LEVEL_4_QTY = base.Columns["DISC_A_LEVEL_4_QTY"];
			columnDISC_A_LEVEL_5_QTY = base.Columns["DISC_A_LEVEL_5_QTY"];
			columnDISC_A_LEVEL_6_QTY = base.Columns["DISC_A_LEVEL_6_QTY"];
			columnDISC_A_LEVEL_7_QTY = base.Columns["DISC_A_LEVEL_7_QTY"];
			columnDISC_A_LEVEL_8_QTY = base.Columns["DISC_A_LEVEL_8_QTY"];
			columnDISC_A_LEVEL_9_QTY = base.Columns["DISC_A_LEVEL_9_QTY"];
			columnDISC_A_LEVEL_10_QTY = base.Columns["DISC_A_LEVEL_10_QTY"];
			columnDISC_A_LEVEL_1_RATE = base.Columns["DISC_A_LEVEL_1_RATE"];
			columnDISC_A_LEVEL_2_RATE = base.Columns["DISC_A_LEVEL_2_RATE"];
			columnDISC_A_LEVEL_3_RATE = base.Columns["DISC_A_LEVEL_3_RATE"];
			columnDISC_A_LEVEL_4_RATE = base.Columns["DISC_A_LEVEL_4_RATE"];
			columnDISC_A_LEVEL_5_RATE = base.Columns["DISC_A_LEVEL_5_RATE"];
			columnDISC_A_LEVEL_6_RATE = base.Columns["DISC_A_LEVEL_6_RATE"];
			columnDISC_A_LEVEL_7_RATE = base.Columns["DISC_A_LEVEL_7_RATE"];
			columnDISC_A_LEVEL_8_RATE = base.Columns["DISC_A_LEVEL_8_RATE"];
			columnDISC_A_LEVEL_9_RATE = base.Columns["DISC_A_LEVEL_9_RATE"];
			columnDISC_A_LEVEL_10_RATE = base.Columns["DISC_A_LEVEL_10_RATE"];
			columnDISC_B_LEVEL_1_QTY = base.Columns["DISC_B_LEVEL_1_QTY"];
			columnDISC_B_LEVEL_2_QTY = base.Columns["DISC_B_LEVEL_2_QTY"];
			columnDISC_B_LEVEL_3_QTY = base.Columns["DISC_B_LEVEL_3_QTY"];
			columnDISC_B_LEVEL_4_QTY = base.Columns["DISC_B_LEVEL_4_QTY"];
			columnDISC_B_LEVEL_5_QTY = base.Columns["DISC_B_LEVEL_5_QTY"];
			columnDISC_B_LEVEL_6_QTY = base.Columns["DISC_B_LEVEL_6_QTY"];
			columnDISC_B_LEVEL_7_QTY = base.Columns["DISC_B_LEVEL_7_QTY"];
			columnDISC_B_LEVEL_8_QTY = base.Columns["DISC_B_LEVEL_8_QTY"];
			columnDISC_B_LEVEL_9_QTY = base.Columns["DISC_B_LEVEL_9_QTY"];
			columnDISC_B_LEVEL_10_QTY = base.Columns["DISC_B_LEVEL_10_QTY"];
			columnDISC_B_LEVEL_1_RATE = base.Columns["DISC_B_LEVEL_1_RATE"];
			columnDISC_B_LEVEL_2_RATE = base.Columns["DISC_B_LEVEL_2_RATE"];
			columnDISC_B_LEVEL_3_RATE = base.Columns["DISC_B_LEVEL_3_RATE"];
			columnDISC_B_LEVEL_4_RATE = base.Columns["DISC_B_LEVEL_4_RATE"];
			columnDISC_B_LEVEL_5_RATE = base.Columns["DISC_B_LEVEL_5_RATE"];
			columnDISC_B_LEVEL_6_RATE = base.Columns["DISC_B_LEVEL_6_RATE"];
			columnDISC_B_LEVEL_7_RATE = base.Columns["DISC_B_LEVEL_7_RATE"];
			columnDISC_B_LEVEL_8_RATE = base.Columns["DISC_B_LEVEL_8_RATE"];
			columnDISC_B_LEVEL_9_RATE = base.Columns["DISC_B_LEVEL_9_RATE"];
			columnDISC_B_LEVEL_10_RATE = base.Columns["DISC_B_LEVEL_10_RATE"];
			columnDISC_C_LEVEL_1_QTY = base.Columns["DISC_C_LEVEL_1_QTY"];
			columnDISC_C_LEVEL_2_QTY = base.Columns["DISC_C_LEVEL_2_QTY"];
			columnDISC_C_LEVEL_3_QTY = base.Columns["DISC_C_LEVEL_3_QTY"];
			columnDISC_C_LEVEL_4_QTY = base.Columns["DISC_C_LEVEL_4_QTY"];
			columnDISC_C_LEVEL_5_QTY = base.Columns["DISC_C_LEVEL_5_QTY"];
			columnDISC_C_LEVEL_6_QTY = base.Columns["DISC_C_LEVEL_6_QTY"];
			columnDISC_C_LEVEL_7_QTY = base.Columns["DISC_C_LEVEL_7_QTY"];
			columnDISC_C_LEVEL_8_QTY = base.Columns["DISC_C_LEVEL_8_QTY"];
			columnDISC_C_LEVEL_9_QTY = base.Columns["DISC_C_LEVEL_9_QTY"];
			columnDISC_C_LEVEL_10_QTY = base.Columns["DISC_C_LEVEL_10_QTY"];
			columnDISC_C_LEVEL_1_RATE = base.Columns["DISC_C_LEVEL_1_RATE"];
			columnDISC_C_LEVEL_2_RATE = base.Columns["DISC_C_LEVEL_2_RATE"];
			columnDISC_C_LEVEL_3_RATE = base.Columns["DISC_C_LEVEL_3_RATE"];
			columnDISC_C_LEVEL_4_RATE = base.Columns["DISC_C_LEVEL_4_RATE"];
			columnDISC_C_LEVEL_5_RATE = base.Columns["DISC_C_LEVEL_5_RATE"];
			columnDISC_C_LEVEL_6_RATE = base.Columns["DISC_C_LEVEL_6_RATE"];
			columnDISC_C_LEVEL_7_RATE = base.Columns["DISC_C_LEVEL_7_RATE"];
			columnDISC_C_LEVEL_8_RATE = base.Columns["DISC_C_LEVEL_8_RATE"];
			columnDISC_C_LEVEL_9_RATE = base.Columns["DISC_C_LEVEL_9_RATE"];
			columnDISC_C_LEVEL_10_RATE = base.Columns["DISC_C_LEVEL_10_RATE"];
			columnDISC_D_LEVEL_1_QTY = base.Columns["DISC_D_LEVEL_1_QTY"];
			columnDISC_D_LEVEL_2_QTY = base.Columns["DISC_D_LEVEL_2_QTY"];
			columnDISC_D_LEVEL_3_QTY = base.Columns["DISC_D_LEVEL_3_QTY"];
			columnDISC_D_LEVEL_4_QTY = base.Columns["DISC_D_LEVEL_4_QTY"];
			columnDISC_D_LEVEL_5_QTY = base.Columns["DISC_D_LEVEL_5_QTY"];
			columnDISC_D_LEVEL_6_QTY = base.Columns["DISC_D_LEVEL_6_QTY"];
			columnDISC_D_LEVEL_7_QTY = base.Columns["DISC_D_LEVEL_7_QTY"];
			columnDISC_D_LEVEL_8_QTY = base.Columns["DISC_D_LEVEL_8_QTY"];
			columnDISC_D_LEVEL_9_QTY = base.Columns["DISC_D_LEVEL_9_QTY"];
			columnDISC_D_LEVEL_10_QTY = base.Columns["DISC_D_LEVEL_10_QTY"];
			columnDISC_D_LEVEL_1_RATE = base.Columns["DISC_D_LEVEL_1_RATE"];
			columnDISC_D_LEVEL_2_RATE = base.Columns["DISC_D_LEVEL_2_RATE"];
			columnDISC_D_LEVEL_3_RATE = base.Columns["DISC_D_LEVEL_3_RATE"];
			columnDISC_D_LEVEL_4_RATE = base.Columns["DISC_D_LEVEL_4_RATE"];
			columnDISC_D_LEVEL_5_RATE = base.Columns["DISC_D_LEVEL_5_RATE"];
			columnDISC_D_LEVEL_6_RATE = base.Columns["DISC_D_LEVEL_6_RATE"];
			columnDISC_D_LEVEL_7_RATE = base.Columns["DISC_D_LEVEL_7_RATE"];
			columnDISC_D_LEVEL_8_RATE = base.Columns["DISC_D_LEVEL_8_RATE"];
			columnDISC_D_LEVEL_9_RATE = base.Columns["DISC_D_LEVEL_9_RATE"];
			columnDISC_D_LEVEL_10_RATE = base.Columns["DISC_D_LEVEL_10_RATE"];
			columnDISC_E_LEVEL_1_QTY = base.Columns["DISC_E_LEVEL_1_QTY"];
			columnDISC_E_LEVEL_2_QTY = base.Columns["DISC_E_LEVEL_2_QTY"];
			columnDISC_E_LEVEL_3_QTY = base.Columns["DISC_E_LEVEL_3_QTY"];
			columnDISC_E_LEVEL_4_QTY = base.Columns["DISC_E_LEVEL_4_QTY"];
			columnDISC_E_LEVEL_5_QTY = base.Columns["DISC_E_LEVEL_5_QTY"];
			columnDISC_E_LEVEL_6_QTY = base.Columns["DISC_E_LEVEL_6_QTY"];
			columnDISC_E_LEVEL_7_QTY = base.Columns["DISC_E_LEVEL_7_QTY"];
			columnDISC_E_LEVEL_8_QTY = base.Columns["DISC_E_LEVEL_8_QTY"];
			columnDISC_E_LEVEL_9_QTY = base.Columns["DISC_E_LEVEL_9_QTY"];
			columnDISC_E_LEVEL_10_QTY = base.Columns["DISC_E_LEVEL_10_QTY"];
			columnDISC_E_LEVEL_1_RATE = base.Columns["DISC_E_LEVEL_1_RATE"];
			columnDISC_E_LEVEL_2_RATE = base.Columns["DISC_E_LEVEL_2_RATE"];
			columnDISC_E_LEVEL_3_RATE = base.Columns["DISC_E_LEVEL_3_RATE"];
			columnDISC_E_LEVEL_4_RATE = base.Columns["DISC_E_LEVEL_4_RATE"];
			columnDISC_E_LEVEL_5_RATE = base.Columns["DISC_E_LEVEL_5_RATE"];
			columnDISC_E_LEVEL_6_RATE = base.Columns["DISC_E_LEVEL_6_RATE"];
			columnDISC_E_LEVEL_7_RATE = base.Columns["DISC_E_LEVEL_7_RATE"];
			columnDISC_E_LEVEL_8_RATE = base.Columns["DISC_E_LEVEL_8_RATE"];
			columnDISC_E_LEVEL_9_RATE = base.Columns["DISC_E_LEVEL_9_RATE"];
			columnDISC_E_LEVEL_10_RATE = base.Columns["DISC_E_LEVEL_10_RATE"];
			columnPURCHASE_NOMINAL_CODE = base.Columns["PURCHASE_NOMINAL_CODE"];
			columnRECORD_CREATE_DATE = base.Columns["RECORD_CREATE_DATE"];
			columnRECORD_MODIFY_DATE = base.Columns["RECORD_MODIFY_DATE"];
			columnRECORD_DELETED = base.Columns["RECORD_DELETED"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnSTOCK_CODE = new DataColumn("STOCK_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTOCK_CODE);
			columnDESCRIPTION = new DataColumn("DESCRIPTION", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDESCRIPTION);
			columnUNIT_OF_SALE = new DataColumn("UNIT_OF_SALE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUNIT_OF_SALE);
			columnNOMINAL_CODE = new DataColumn("NOMINAL_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOMINAL_CODE);
			columnPURCHASE_REF = new DataColumn("PURCHASE_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPURCHASE_REF);
			columnSUPPLIER_PART_NUMBER = new DataColumn("SUPPLIER_PART_NUMBER", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSUPPLIER_PART_NUMBER);
			columnLOCATION = new DataColumn("LOCATION", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLOCATION);
			columnCOMMODITY_CODE = new DataColumn("COMMODITY_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMMODITY_CODE);
			columnSALES_PRICE = new DataColumn("SALES_PRICE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_PRICE);
			columnWEB_DESCRIPTION = new DataColumn("WEB_DESCRIPTION", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_DESCRIPTION);
			columnWEB_DETAILS = new DataColumn("WEB_DETAILS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_DETAILS);
			columnWEB_CATEGORY_1 = new DataColumn("WEB_CATEGORY_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_CATEGORY_1);
			columnWEB_CATEGORY_2 = new DataColumn("WEB_CATEGORY_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_CATEGORY_2);
			columnWEB_CATEGORY_3 = new DataColumn("WEB_CATEGORY_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_CATEGORY_3);
			columnWEB_IMAGE_FILE = new DataColumn("WEB_IMAGE_FILE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnWEB_IMAGE_FILE);
			columnWEB_PUBLISH = new DataColumn("WEB_PUBLISH", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnWEB_PUBLISH);
			columnWEB_SPECIAL = new DataColumn("WEB_SPECIAL", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnWEB_SPECIAL);
			columnINTRASTAT_COMM_CODE = new DataColumn("INTRASTAT_COMM_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnINTRASTAT_COMM_CODE);
			columnIGNORE_STK_LVL_FLAG = new DataColumn("IGNORE_STK_LVL_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnIGNORE_STK_LVL_FLAG);
			columnDEPT_NUMBER = new DataColumn("DEPT_NUMBER", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NUMBER);
			columnDEPT_NAME = new DataColumn("DEPT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEPT_NAME);
			columnTAX_CODE = new DataColumn("TAX_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAX_CODE);
			columnASSEMBLY_LEVEL = new DataColumn("ASSEMBLY_LEVEL", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnASSEMBLY_LEVEL);
			columnLINK_LEVEL = new DataColumn("LINK_LEVEL", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnLINK_LEVEL);
			columnSTOCK_CAT = new DataColumn("STOCK_CAT", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnSTOCK_CAT);
			columnSTOCK_CAT_NAME = new DataColumn("STOCK_CAT_NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSTOCK_CAT_NAME);
			columnSTOCK_TAKE_DATE = new DataColumn("STOCK_TAKE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnSTOCK_TAKE_DATE);
			columnLAST_PURCHASE_PRICE = new DataColumn("LAST_PURCHASE_PRICE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnLAST_PURCHASE_PRICE);
			columnLAST_DISC_PURCHASE_PRICE = new DataColumn("LAST_DISC_PURCHASE_PRICE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnLAST_DISC_PURCHASE_PRICE);
			columnAVERAGE_COST_PRICE = new DataColumn("AVERAGE_COST_PRICE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnAVERAGE_COST_PRICE);
			columnQTY_IN_STOCK = new DataColumn("QTY_IN_STOCK", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_IN_STOCK);
			columnQTY_ON_ORDER = new DataColumn("QTY_ON_ORDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_ON_ORDER);
			columnQTY_ALLOCATED = new DataColumn("QTY_ALLOCATED", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_ALLOCATED);
			columnQTY_LAST_ORDER = new DataColumn("QTY_LAST_ORDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_LAST_ORDER);
			columnQTY_REORDER = new DataColumn("QTY_REORDER", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_REORDER);
			columnQTY_REORDER_LEVEL = new DataColumn("QTY_REORDER_LEVEL", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_REORDER_LEVEL);
			columnQTY_LAST_STOCK_TAKE = new DataColumn("QTY_LAST_STOCK_TAKE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_LAST_STOCK_TAKE);
			columnQTY_MAKEUP = new DataColumn("QTY_MAKEUP", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_MAKEUP);
			columnLAST_SALE_DATE = new DataColumn("LAST_SALE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLAST_SALE_DATE);
			columnLAST_PURCHASE_DATE = new DataColumn("LAST_PURCHASE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnLAST_PURCHASE_DATE);
			columnUNIT_WEIGHT = new DataColumn("UNIT_WEIGHT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnUNIT_WEIGHT);
			columnHAS_NO_COMPONENT = new DataColumn("HAS_NO_COMPONENT", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnHAS_NO_COMPONENT);
			columnHAS_BOM = new DataColumn("HAS_BOM", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHAS_BOM);
			columnBARCODE = new DataColumn("BARCODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBARCODE);
			columnCOMPONENT_CODE_1 = new DataColumn("COMPONENT_CODE_1", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_1);
			columnCOMPONENT_CODE_2 = new DataColumn("COMPONENT_CODE_2", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_2);
			columnCOMPONENT_CODE_3 = new DataColumn("COMPONENT_CODE_3", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_3);
			columnCOMPONENT_CODE_4 = new DataColumn("COMPONENT_CODE_4", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_4);
			columnCOMPONENT_CODE_5 = new DataColumn("COMPONENT_CODE_5", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_5);
			columnCOMPONENT_CODE_6 = new DataColumn("COMPONENT_CODE_6", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_6);
			columnCOMPONENT_CODE_7 = new DataColumn("COMPONENT_CODE_7", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_7);
			columnCOMPONENT_CODE_8 = new DataColumn("COMPONENT_CODE_8", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_8);
			columnCOMPONENT_CODE_9 = new DataColumn("COMPONENT_CODE_9", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_9);
			columnCOMPONENT_CODE_10 = new DataColumn("COMPONENT_CODE_10", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_10);
			columnCOMPONENT_CODE_11 = new DataColumn("COMPONENT_CODE_11", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_11);
			columnCOMPONENT_CODE_12 = new DataColumn("COMPONENT_CODE_12", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_12);
			columnCOMPONENT_CODE_13 = new DataColumn("COMPONENT_CODE_13", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_13);
			columnCOMPONENT_CODE_14 = new DataColumn("COMPONENT_CODE_14", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_14);
			columnCOMPONENT_CODE_15 = new DataColumn("COMPONENT_CODE_15", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_15);
			columnCOMPONENT_CODE_16 = new DataColumn("COMPONENT_CODE_16", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_16);
			columnCOMPONENT_CODE_17 = new DataColumn("COMPONENT_CODE_17", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_17);
			columnCOMPONENT_CODE_18 = new DataColumn("COMPONENT_CODE_18", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_18);
			columnCOMPONENT_CODE_19 = new DataColumn("COMPONENT_CODE_19", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_19);
			columnCOMPONENT_CODE_20 = new DataColumn("COMPONENT_CODE_20", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_20);
			columnCOMPONENT_CODE_21 = new DataColumn("COMPONENT_CODE_21", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_21);
			columnCOMPONENT_CODE_22 = new DataColumn("COMPONENT_CODE_22", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_22);
			columnCOMPONENT_CODE_23 = new DataColumn("COMPONENT_CODE_23", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_23);
			columnCOMPONENT_CODE_24 = new DataColumn("COMPONENT_CODE_24", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_24);
			columnCOMPONENT_CODE_25 = new DataColumn("COMPONENT_CODE_25", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_25);
			columnCOMPONENT_CODE_26 = new DataColumn("COMPONENT_CODE_26", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_26);
			columnCOMPONENT_CODE_27 = new DataColumn("COMPONENT_CODE_27", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_27);
			columnCOMPONENT_CODE_28 = new DataColumn("COMPONENT_CODE_28", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_28);
			columnCOMPONENT_CODE_29 = new DataColumn("COMPONENT_CODE_29", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_29);
			columnCOMPONENT_CODE_30 = new DataColumn("COMPONENT_CODE_30", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_30);
			columnCOMPONENT_CODE_31 = new DataColumn("COMPONENT_CODE_31", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_31);
			columnCOMPONENT_CODE_32 = new DataColumn("COMPONENT_CODE_32", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_32);
			columnCOMPONENT_CODE_33 = new DataColumn("COMPONENT_CODE_33", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_33);
			columnCOMPONENT_CODE_34 = new DataColumn("COMPONENT_CODE_34", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_34);
			columnCOMPONENT_CODE_35 = new DataColumn("COMPONENT_CODE_35", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_35);
			columnCOMPONENT_CODE_36 = new DataColumn("COMPONENT_CODE_36", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_36);
			columnCOMPONENT_CODE_37 = new DataColumn("COMPONENT_CODE_37", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_37);
			columnCOMPONENT_CODE_38 = new DataColumn("COMPONENT_CODE_38", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_38);
			columnCOMPONENT_CODE_39 = new DataColumn("COMPONENT_CODE_39", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_39);
			columnCOMPONENT_CODE_40 = new DataColumn("COMPONENT_CODE_40", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_40);
			columnCOMPONENT_CODE_41 = new DataColumn("COMPONENT_CODE_41", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_41);
			columnCOMPONENT_CODE_42 = new DataColumn("COMPONENT_CODE_42", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_42);
			columnCOMPONENT_CODE_43 = new DataColumn("COMPONENT_CODE_43", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_43);
			columnCOMPONENT_CODE_44 = new DataColumn("COMPONENT_CODE_44", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_44);
			columnCOMPONENT_CODE_45 = new DataColumn("COMPONENT_CODE_45", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_45);
			columnCOMPONENT_CODE_46 = new DataColumn("COMPONENT_CODE_46", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_46);
			columnCOMPONENT_CODE_47 = new DataColumn("COMPONENT_CODE_47", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_47);
			columnCOMPONENT_CODE_48 = new DataColumn("COMPONENT_CODE_48", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_48);
			columnCOMPONENT_CODE_49 = new DataColumn("COMPONENT_CODE_49", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_49);
			columnCOMPONENT_CODE_50 = new DataColumn("COMPONENT_CODE_50", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_CODE_50);
			columnCOMPONENT_QTY_1 = new DataColumn("COMPONENT_QTY_1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_1);
			columnCOMPONENT_QTY_2 = new DataColumn("COMPONENT_QTY_2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_2);
			columnCOMPONENT_QTY_3 = new DataColumn("COMPONENT_QTY_3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_3);
			columnCOMPONENT_QTY_4 = new DataColumn("COMPONENT_QTY_4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_4);
			columnCOMPONENT_QTY_5 = new DataColumn("COMPONENT_QTY_5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_5);
			columnCOMPONENT_QTY_6 = new DataColumn("COMPONENT_QTY_6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_6);
			columnCOMPONENT_QTY_7 = new DataColumn("COMPONENT_QTY_7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_7);
			columnCOMPONENT_QTY_8 = new DataColumn("COMPONENT_QTY_8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_8);
			columnCOMPONENT_QTY_9 = new DataColumn("COMPONENT_QTY_9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_9);
			columnCOMPONENT_QTY_10 = new DataColumn("COMPONENT_QTY_10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_10);
			columnCOMPONENT_QTY_11 = new DataColumn("COMPONENT_QTY_11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_11);
			columnCOMPONENT_QTY_12 = new DataColumn("COMPONENT_QTY_12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_12);
			columnCOMPONENT_QTY_13 = new DataColumn("COMPONENT_QTY_13", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_13);
			columnCOMPONENT_QTY_14 = new DataColumn("COMPONENT_QTY_14", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_14);
			columnCOMPONENT_QTY_15 = new DataColumn("COMPONENT_QTY_15", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_15);
			columnCOMPONENT_QTY_16 = new DataColumn("COMPONENT_QTY_16", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_16);
			columnCOMPONENT_QTY_17 = new DataColumn("COMPONENT_QTY_17", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_17);
			columnCOMPONENT_QTY_18 = new DataColumn("COMPONENT_QTY_18", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_18);
			columnCOMPONENT_QTY_19 = new DataColumn("COMPONENT_QTY_19", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_19);
			columnCOMPONENT_QTY_20 = new DataColumn("COMPONENT_QTY_20", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_20);
			columnCOMPONENT_QTY_21 = new DataColumn("COMPONENT_QTY_21", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_21);
			columnCOMPONENT_QTY_22 = new DataColumn("COMPONENT_QTY_22", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_22);
			columnCOMPONENT_QTY_23 = new DataColumn("COMPONENT_QTY_23", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_23);
			columnCOMPONENT_QTY_24 = new DataColumn("COMPONENT_QTY_24", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_24);
			columnCOMPONENT_QTY_25 = new DataColumn("COMPONENT_QTY_25", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_25);
			columnCOMPONENT_QTY_26 = new DataColumn("COMPONENT_QTY_26", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_26);
			columnCOMPONENT_QTY_27 = new DataColumn("COMPONENT_QTY_27", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_27);
			columnCOMPONENT_QTY_28 = new DataColumn("COMPONENT_QTY_28", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_28);
			columnCOMPONENT_QTY_29 = new DataColumn("COMPONENT_QTY_29", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_29);
			columnCOMPONENT_QTY_30 = new DataColumn("COMPONENT_QTY_30", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_30);
			columnCOMPONENT_QTY_31 = new DataColumn("COMPONENT_QTY_31", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_31);
			columnCOMPONENT_QTY_32 = new DataColumn("COMPONENT_QTY_32", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_32);
			columnCOMPONENT_QTY_33 = new DataColumn("COMPONENT_QTY_33", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_33);
			columnCOMPONENT_QTY_34 = new DataColumn("COMPONENT_QTY_34", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_34);
			columnCOMPONENT_QTY_35 = new DataColumn("COMPONENT_QTY_35", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_35);
			columnCOMPONENT_QTY_36 = new DataColumn("COMPONENT_QTY_36", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_36);
			columnCOMPONENT_QTY_37 = new DataColumn("COMPONENT_QTY_37", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_37);
			columnCOMPONENT_QTY_38 = new DataColumn("COMPONENT_QTY_38", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_38);
			columnCOMPONENT_QTY_39 = new DataColumn("COMPONENT_QTY_39", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_39);
			columnCOMPONENT_QTY_40 = new DataColumn("COMPONENT_QTY_40", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_40);
			columnCOMPONENT_QTY_41 = new DataColumn("COMPONENT_QTY_41", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_41);
			columnCOMPONENT_QTY_42 = new DataColumn("COMPONENT_QTY_42", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_42);
			columnCOMPONENT_QTY_43 = new DataColumn("COMPONENT_QTY_43", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_43);
			columnCOMPONENT_QTY_44 = new DataColumn("COMPONENT_QTY_44", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_44);
			columnCOMPONENT_QTY_45 = new DataColumn("COMPONENT_QTY_45", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_45);
			columnCOMPONENT_QTY_46 = new DataColumn("COMPONENT_QTY_46", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_46);
			columnCOMPONENT_QTY_47 = new DataColumn("COMPONENT_QTY_47", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_47);
			columnCOMPONENT_QTY_48 = new DataColumn("COMPONENT_QTY_48", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_48);
			columnCOMPONENT_QTY_49 = new DataColumn("COMPONENT_QTY_49", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_49);
			columnCOMPONENT_QTY_50 = new DataColumn("COMPONENT_QTY_50", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOMPONENT_QTY_50);
			columnQTY_SOLD_BF = new DataColumn("QTY_SOLD_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_BF);
			columnQTY_SOLD_MTH1 = new DataColumn("QTY_SOLD_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH1);
			columnQTY_SOLD_MTH2 = new DataColumn("QTY_SOLD_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH2);
			columnQTY_SOLD_MTH3 = new DataColumn("QTY_SOLD_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH3);
			columnQTY_SOLD_MTH4 = new DataColumn("QTY_SOLD_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH4);
			columnQTY_SOLD_MTH5 = new DataColumn("QTY_SOLD_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH5);
			columnQTY_SOLD_MTH6 = new DataColumn("QTY_SOLD_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH6);
			columnQTY_SOLD_MTH7 = new DataColumn("QTY_SOLD_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH7);
			columnQTY_SOLD_MTH8 = new DataColumn("QTY_SOLD_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH8);
			columnQTY_SOLD_MTH9 = new DataColumn("QTY_SOLD_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH9);
			columnQTY_SOLD_MTH10 = new DataColumn("QTY_SOLD_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH10);
			columnQTY_SOLD_MTH11 = new DataColumn("QTY_SOLD_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH11);
			columnQTY_SOLD_MTH12 = new DataColumn("QTY_SOLD_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_MTH12);
			columnQTY_SOLD_FUTURE = new DataColumn("QTY_SOLD_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnQTY_SOLD_FUTURE);
			columnSALES_BF = new DataColumn("SALES_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_BF);
			columnSALES_MTH1 = new DataColumn("SALES_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH1);
			columnSALES_MTH2 = new DataColumn("SALES_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH2);
			columnSALES_MTH3 = new DataColumn("SALES_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH3);
			columnSALES_MTH4 = new DataColumn("SALES_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH4);
			columnSALES_MTH5 = new DataColumn("SALES_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH5);
			columnSALES_MTH6 = new DataColumn("SALES_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH6);
			columnSALES_MTH7 = new DataColumn("SALES_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH7);
			columnSALES_MTH8 = new DataColumn("SALES_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH8);
			columnSALES_MTH9 = new DataColumn("SALES_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH9);
			columnSALES_MTH10 = new DataColumn("SALES_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH10);
			columnSALES_MTH11 = new DataColumn("SALES_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH11);
			columnSALES_MTH12 = new DataColumn("SALES_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_MTH12);
			columnSALES_FUTURE = new DataColumn("SALES_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnSALES_FUTURE);
			columnCOST_BF = new DataColumn("COST_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_BF);
			columnCOST_MTH1 = new DataColumn("COST_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH1);
			columnCOST_MTH2 = new DataColumn("COST_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH2);
			columnCOST_MTH3 = new DataColumn("COST_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH3);
			columnCOST_MTH4 = new DataColumn("COST_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH4);
			columnCOST_MTH5 = new DataColumn("COST_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH5);
			columnCOST_MTH6 = new DataColumn("COST_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH6);
			columnCOST_MTH7 = new DataColumn("COST_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH7);
			columnCOST_MTH8 = new DataColumn("COST_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH8);
			columnCOST_MTH9 = new DataColumn("COST_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH9);
			columnCOST_MTH10 = new DataColumn("COST_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH10);
			columnCOST_MTH11 = new DataColumn("COST_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH11);
			columnCOST_MTH12 = new DataColumn("COST_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_MTH12);
			columnCOST_FUTURE = new DataColumn("COST_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCOST_FUTURE);
			columnTHIS_RECORD = new DataColumn("THIS_RECORD", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTHIS_RECORD);
			columnBUDGET_QTY_SOLD_BF = new DataColumn("BUDGET_QTY_SOLD_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_BF);
			columnBUDGET_QTY_SOLD_MTH1 = new DataColumn("BUDGET_QTY_SOLD_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH1);
			columnBUDGET_QTY_SOLD_MTH2 = new DataColumn("BUDGET_QTY_SOLD_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH2);
			columnBUDGET_QTY_SOLD_MTH3 = new DataColumn("BUDGET_QTY_SOLD_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH3);
			columnBUDGET_QTY_SOLD_MTH4 = new DataColumn("BUDGET_QTY_SOLD_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH4);
			columnBUDGET_QTY_SOLD_MTH5 = new DataColumn("BUDGET_QTY_SOLD_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH5);
			columnBUDGET_QTY_SOLD_MTH6 = new DataColumn("BUDGET_QTY_SOLD_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH6);
			columnBUDGET_QTY_SOLD_MTH7 = new DataColumn("BUDGET_QTY_SOLD_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH7);
			columnBUDGET_QTY_SOLD_MTH8 = new DataColumn("BUDGET_QTY_SOLD_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH8);
			columnBUDGET_QTY_SOLD_MTH9 = new DataColumn("BUDGET_QTY_SOLD_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH9);
			columnBUDGET_QTY_SOLD_MTH10 = new DataColumn("BUDGET_QTY_SOLD_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH10);
			columnBUDGET_QTY_SOLD_MTH11 = new DataColumn("BUDGET_QTY_SOLD_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH11);
			columnBUDGET_QTY_SOLD_MTH12 = new DataColumn("BUDGET_QTY_SOLD_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_MTH12);
			columnBUDGET_QTY_SOLD_FUTURE = new DataColumn("BUDGET_QTY_SOLD_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_QTY_SOLD_FUTURE);
			columnBUDGET_SALES_BF = new DataColumn("BUDGET_SALES_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_BF);
			columnBUDGET_SALES_MTH1 = new DataColumn("BUDGET_SALES_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH1);
			columnBUDGET_SALES_MTH2 = new DataColumn("BUDGET_SALES_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH2);
			columnBUDGET_SALES_MTH3 = new DataColumn("BUDGET_SALES_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH3);
			columnBUDGET_SALES_MTH4 = new DataColumn("BUDGET_SALES_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH4);
			columnBUDGET_SALES_MTH5 = new DataColumn("BUDGET_SALES_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH5);
			columnBUDGET_SALES_MTH6 = new DataColumn("BUDGET_SALES_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH6);
			columnBUDGET_SALES_MTH7 = new DataColumn("BUDGET_SALES_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH7);
			columnBUDGET_SALES_MTH8 = new DataColumn("BUDGET_SALES_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH8);
			columnBUDGET_SALES_MTH9 = new DataColumn("BUDGET_SALES_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH9);
			columnBUDGET_SALES_MTH10 = new DataColumn("BUDGET_SALES_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH10);
			columnBUDGET_SALES_MTH11 = new DataColumn("BUDGET_SALES_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH11);
			columnBUDGET_SALES_MTH12 = new DataColumn("BUDGET_SALES_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_MTH12);
			columnBUDGET_SALES_FUTURE = new DataColumn("BUDGET_SALES_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_SALES_FUTURE);
			columnPRIOR_YR_QTY_SOLD_BF = new DataColumn("PRIOR_YR_QTY_SOLD_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_BF);
			columnPRIOR_YR_QTY_SOLD_MTH1 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH1);
			columnPRIOR_YR_QTY_SOLD_MTH2 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH2);
			columnPRIOR_YR_QTY_SOLD_MTH3 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH3);
			columnPRIOR_YR_QTY_SOLD_MTH4 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH4);
			columnPRIOR_YR_QTY_SOLD_MTH5 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH5);
			columnPRIOR_YR_QTY_SOLD_MTH6 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH6);
			columnPRIOR_YR_QTY_SOLD_MTH7 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH7);
			columnPRIOR_YR_QTY_SOLD_MTH8 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH8);
			columnPRIOR_YR_QTY_SOLD_MTH9 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH9);
			columnPRIOR_YR_QTY_SOLD_MTH10 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH10);
			columnPRIOR_YR_QTY_SOLD_MTH11 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH11);
			columnPRIOR_YR_QTY_SOLD_MTH12 = new DataColumn("PRIOR_YR_QTY_SOLD_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_MTH12);
			columnPRIOR_YR_QTY_SOLD_FUTURE = new DataColumn("PRIOR_YR_QTY_SOLD_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_QTY_SOLD_FUTURE);
			columnPRIOR_YR_SALES_BF = new DataColumn("PRIOR_YR_SALES_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_BF);
			columnPRIOR_YR_SALES_MTH1 = new DataColumn("PRIOR_YR_SALES_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH1);
			columnPRIOR_YR_SALES_MTH2 = new DataColumn("PRIOR_YR_SALES_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH2);
			columnPRIOR_YR_SALES_MTH3 = new DataColumn("PRIOR_YR_SALES_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH3);
			columnPRIOR_YR_SALES_MTH4 = new DataColumn("PRIOR_YR_SALES_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH4);
			columnPRIOR_YR_SALES_MTH5 = new DataColumn("PRIOR_YR_SALES_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH5);
			columnPRIOR_YR_SALES_MTH6 = new DataColumn("PRIOR_YR_SALES_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH6);
			columnPRIOR_YR_SALES_MTH7 = new DataColumn("PRIOR_YR_SALES_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH7);
			columnPRIOR_YR_SALES_MTH8 = new DataColumn("PRIOR_YR_SALES_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH8);
			columnPRIOR_YR_SALES_MTH9 = new DataColumn("PRIOR_YR_SALES_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH9);
			columnPRIOR_YR_SALES_MTH10 = new DataColumn("PRIOR_YR_SALES_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH10);
			columnPRIOR_YR_SALES_MTH11 = new DataColumn("PRIOR_YR_SALES_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH11);
			columnPRIOR_YR_SALES_MTH12 = new DataColumn("PRIOR_YR_SALES_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_MTH12);
			columnPRIOR_YR_SALES_FUTURE = new DataColumn("PRIOR_YR_SALES_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_SALES_FUTURE);
			columnPRIOR_YR_COST_BF = new DataColumn("PRIOR_YR_COST_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_BF);
			columnPRIOR_YR_COST_MTH1 = new DataColumn("PRIOR_YR_COST_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH1);
			columnPRIOR_YR_COST_MTH2 = new DataColumn("PRIOR_YR_COST_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH2);
			columnPRIOR_YR_COST_MTH3 = new DataColumn("PRIOR_YR_COST_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH3);
			columnPRIOR_YR_COST_MTH4 = new DataColumn("PRIOR_YR_COST_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH4);
			columnPRIOR_YR_COST_MTH5 = new DataColumn("PRIOR_YR_COST_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH5);
			columnPRIOR_YR_COST_MTH6 = new DataColumn("PRIOR_YR_COST_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH6);
			columnPRIOR_YR_COST_MTH7 = new DataColumn("PRIOR_YR_COST_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH7);
			columnPRIOR_YR_COST_MTH8 = new DataColumn("PRIOR_YR_COST_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH8);
			columnPRIOR_YR_COST_MTH9 = new DataColumn("PRIOR_YR_COST_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH9);
			columnPRIOR_YR_COST_MTH10 = new DataColumn("PRIOR_YR_COST_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH10);
			columnPRIOR_YR_COST_MTH11 = new DataColumn("PRIOR_YR_COST_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH11);
			columnPRIOR_YR_COST_MTH12 = new DataColumn("PRIOR_YR_COST_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_MTH12);
			columnPRIOR_YR_COST_FUTURE = new DataColumn("PRIOR_YR_COST_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_COST_FUTURE);
			columnDISC_A_LEVEL_1_QTY = new DataColumn("DISC_A_LEVEL_1_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_1_QTY);
			columnDISC_A_LEVEL_2_QTY = new DataColumn("DISC_A_LEVEL_2_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_2_QTY);
			columnDISC_A_LEVEL_3_QTY = new DataColumn("DISC_A_LEVEL_3_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_3_QTY);
			columnDISC_A_LEVEL_4_QTY = new DataColumn("DISC_A_LEVEL_4_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_4_QTY);
			columnDISC_A_LEVEL_5_QTY = new DataColumn("DISC_A_LEVEL_5_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_5_QTY);
			columnDISC_A_LEVEL_6_QTY = new DataColumn("DISC_A_LEVEL_6_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_6_QTY);
			columnDISC_A_LEVEL_7_QTY = new DataColumn("DISC_A_LEVEL_7_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_7_QTY);
			columnDISC_A_LEVEL_8_QTY = new DataColumn("DISC_A_LEVEL_8_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_8_QTY);
			columnDISC_A_LEVEL_9_QTY = new DataColumn("DISC_A_LEVEL_9_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_9_QTY);
			columnDISC_A_LEVEL_10_QTY = new DataColumn("DISC_A_LEVEL_10_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_10_QTY);
			columnDISC_A_LEVEL_1_RATE = new DataColumn("DISC_A_LEVEL_1_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_1_RATE);
			columnDISC_A_LEVEL_2_RATE = new DataColumn("DISC_A_LEVEL_2_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_2_RATE);
			columnDISC_A_LEVEL_3_RATE = new DataColumn("DISC_A_LEVEL_3_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_3_RATE);
			columnDISC_A_LEVEL_4_RATE = new DataColumn("DISC_A_LEVEL_4_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_4_RATE);
			columnDISC_A_LEVEL_5_RATE = new DataColumn("DISC_A_LEVEL_5_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_5_RATE);
			columnDISC_A_LEVEL_6_RATE = new DataColumn("DISC_A_LEVEL_6_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_6_RATE);
			columnDISC_A_LEVEL_7_RATE = new DataColumn("DISC_A_LEVEL_7_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_7_RATE);
			columnDISC_A_LEVEL_8_RATE = new DataColumn("DISC_A_LEVEL_8_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_8_RATE);
			columnDISC_A_LEVEL_9_RATE = new DataColumn("DISC_A_LEVEL_9_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_9_RATE);
			columnDISC_A_LEVEL_10_RATE = new DataColumn("DISC_A_LEVEL_10_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_A_LEVEL_10_RATE);
			columnDISC_B_LEVEL_1_QTY = new DataColumn("DISC_B_LEVEL_1_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_1_QTY);
			columnDISC_B_LEVEL_2_QTY = new DataColumn("DISC_B_LEVEL_2_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_2_QTY);
			columnDISC_B_LEVEL_3_QTY = new DataColumn("DISC_B_LEVEL_3_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_3_QTY);
			columnDISC_B_LEVEL_4_QTY = new DataColumn("DISC_B_LEVEL_4_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_4_QTY);
			columnDISC_B_LEVEL_5_QTY = new DataColumn("DISC_B_LEVEL_5_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_5_QTY);
			columnDISC_B_LEVEL_6_QTY = new DataColumn("DISC_B_LEVEL_6_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_6_QTY);
			columnDISC_B_LEVEL_7_QTY = new DataColumn("DISC_B_LEVEL_7_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_7_QTY);
			columnDISC_B_LEVEL_8_QTY = new DataColumn("DISC_B_LEVEL_8_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_8_QTY);
			columnDISC_B_LEVEL_9_QTY = new DataColumn("DISC_B_LEVEL_9_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_9_QTY);
			columnDISC_B_LEVEL_10_QTY = new DataColumn("DISC_B_LEVEL_10_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_10_QTY);
			columnDISC_B_LEVEL_1_RATE = new DataColumn("DISC_B_LEVEL_1_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_1_RATE);
			columnDISC_B_LEVEL_2_RATE = new DataColumn("DISC_B_LEVEL_2_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_2_RATE);
			columnDISC_B_LEVEL_3_RATE = new DataColumn("DISC_B_LEVEL_3_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_3_RATE);
			columnDISC_B_LEVEL_4_RATE = new DataColumn("DISC_B_LEVEL_4_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_4_RATE);
			columnDISC_B_LEVEL_5_RATE = new DataColumn("DISC_B_LEVEL_5_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_5_RATE);
			columnDISC_B_LEVEL_6_RATE = new DataColumn("DISC_B_LEVEL_6_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_6_RATE);
			columnDISC_B_LEVEL_7_RATE = new DataColumn("DISC_B_LEVEL_7_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_7_RATE);
			columnDISC_B_LEVEL_8_RATE = new DataColumn("DISC_B_LEVEL_8_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_8_RATE);
			columnDISC_B_LEVEL_9_RATE = new DataColumn("DISC_B_LEVEL_9_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_9_RATE);
			columnDISC_B_LEVEL_10_RATE = new DataColumn("DISC_B_LEVEL_10_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_B_LEVEL_10_RATE);
			columnDISC_C_LEVEL_1_QTY = new DataColumn("DISC_C_LEVEL_1_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_1_QTY);
			columnDISC_C_LEVEL_2_QTY = new DataColumn("DISC_C_LEVEL_2_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_2_QTY);
			columnDISC_C_LEVEL_3_QTY = new DataColumn("DISC_C_LEVEL_3_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_3_QTY);
			columnDISC_C_LEVEL_4_QTY = new DataColumn("DISC_C_LEVEL_4_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_4_QTY);
			columnDISC_C_LEVEL_5_QTY = new DataColumn("DISC_C_LEVEL_5_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_5_QTY);
			columnDISC_C_LEVEL_6_QTY = new DataColumn("DISC_C_LEVEL_6_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_6_QTY);
			columnDISC_C_LEVEL_7_QTY = new DataColumn("DISC_C_LEVEL_7_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_7_QTY);
			columnDISC_C_LEVEL_8_QTY = new DataColumn("DISC_C_LEVEL_8_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_8_QTY);
			columnDISC_C_LEVEL_9_QTY = new DataColumn("DISC_C_LEVEL_9_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_9_QTY);
			columnDISC_C_LEVEL_10_QTY = new DataColumn("DISC_C_LEVEL_10_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_10_QTY);
			columnDISC_C_LEVEL_1_RATE = new DataColumn("DISC_C_LEVEL_1_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_1_RATE);
			columnDISC_C_LEVEL_2_RATE = new DataColumn("DISC_C_LEVEL_2_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_2_RATE);
			columnDISC_C_LEVEL_3_RATE = new DataColumn("DISC_C_LEVEL_3_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_3_RATE);
			columnDISC_C_LEVEL_4_RATE = new DataColumn("DISC_C_LEVEL_4_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_4_RATE);
			columnDISC_C_LEVEL_5_RATE = new DataColumn("DISC_C_LEVEL_5_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_5_RATE);
			columnDISC_C_LEVEL_6_RATE = new DataColumn("DISC_C_LEVEL_6_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_6_RATE);
			columnDISC_C_LEVEL_7_RATE = new DataColumn("DISC_C_LEVEL_7_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_7_RATE);
			columnDISC_C_LEVEL_8_RATE = new DataColumn("DISC_C_LEVEL_8_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_8_RATE);
			columnDISC_C_LEVEL_9_RATE = new DataColumn("DISC_C_LEVEL_9_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_9_RATE);
			columnDISC_C_LEVEL_10_RATE = new DataColumn("DISC_C_LEVEL_10_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_C_LEVEL_10_RATE);
			columnDISC_D_LEVEL_1_QTY = new DataColumn("DISC_D_LEVEL_1_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_1_QTY);
			columnDISC_D_LEVEL_2_QTY = new DataColumn("DISC_D_LEVEL_2_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_2_QTY);
			columnDISC_D_LEVEL_3_QTY = new DataColumn("DISC_D_LEVEL_3_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_3_QTY);
			columnDISC_D_LEVEL_4_QTY = new DataColumn("DISC_D_LEVEL_4_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_4_QTY);
			columnDISC_D_LEVEL_5_QTY = new DataColumn("DISC_D_LEVEL_5_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_5_QTY);
			columnDISC_D_LEVEL_6_QTY = new DataColumn("DISC_D_LEVEL_6_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_6_QTY);
			columnDISC_D_LEVEL_7_QTY = new DataColumn("DISC_D_LEVEL_7_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_7_QTY);
			columnDISC_D_LEVEL_8_QTY = new DataColumn("DISC_D_LEVEL_8_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_8_QTY);
			columnDISC_D_LEVEL_9_QTY = new DataColumn("DISC_D_LEVEL_9_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_9_QTY);
			columnDISC_D_LEVEL_10_QTY = new DataColumn("DISC_D_LEVEL_10_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_10_QTY);
			columnDISC_D_LEVEL_1_RATE = new DataColumn("DISC_D_LEVEL_1_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_1_RATE);
			columnDISC_D_LEVEL_2_RATE = new DataColumn("DISC_D_LEVEL_2_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_2_RATE);
			columnDISC_D_LEVEL_3_RATE = new DataColumn("DISC_D_LEVEL_3_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_3_RATE);
			columnDISC_D_LEVEL_4_RATE = new DataColumn("DISC_D_LEVEL_4_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_4_RATE);
			columnDISC_D_LEVEL_5_RATE = new DataColumn("DISC_D_LEVEL_5_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_5_RATE);
			columnDISC_D_LEVEL_6_RATE = new DataColumn("DISC_D_LEVEL_6_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_6_RATE);
			columnDISC_D_LEVEL_7_RATE = new DataColumn("DISC_D_LEVEL_7_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_7_RATE);
			columnDISC_D_LEVEL_8_RATE = new DataColumn("DISC_D_LEVEL_8_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_8_RATE);
			columnDISC_D_LEVEL_9_RATE = new DataColumn("DISC_D_LEVEL_9_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_9_RATE);
			columnDISC_D_LEVEL_10_RATE = new DataColumn("DISC_D_LEVEL_10_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_D_LEVEL_10_RATE);
			columnDISC_E_LEVEL_1_QTY = new DataColumn("DISC_E_LEVEL_1_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_1_QTY);
			columnDISC_E_LEVEL_2_QTY = new DataColumn("DISC_E_LEVEL_2_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_2_QTY);
			columnDISC_E_LEVEL_3_QTY = new DataColumn("DISC_E_LEVEL_3_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_3_QTY);
			columnDISC_E_LEVEL_4_QTY = new DataColumn("DISC_E_LEVEL_4_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_4_QTY);
			columnDISC_E_LEVEL_5_QTY = new DataColumn("DISC_E_LEVEL_5_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_5_QTY);
			columnDISC_E_LEVEL_6_QTY = new DataColumn("DISC_E_LEVEL_6_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_6_QTY);
			columnDISC_E_LEVEL_7_QTY = new DataColumn("DISC_E_LEVEL_7_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_7_QTY);
			columnDISC_E_LEVEL_8_QTY = new DataColumn("DISC_E_LEVEL_8_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_8_QTY);
			columnDISC_E_LEVEL_9_QTY = new DataColumn("DISC_E_LEVEL_9_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_9_QTY);
			columnDISC_E_LEVEL_10_QTY = new DataColumn("DISC_E_LEVEL_10_QTY", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_10_QTY);
			columnDISC_E_LEVEL_1_RATE = new DataColumn("DISC_E_LEVEL_1_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_1_RATE);
			columnDISC_E_LEVEL_2_RATE = new DataColumn("DISC_E_LEVEL_2_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_2_RATE);
			columnDISC_E_LEVEL_3_RATE = new DataColumn("DISC_E_LEVEL_3_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_3_RATE);
			columnDISC_E_LEVEL_4_RATE = new DataColumn("DISC_E_LEVEL_4_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_4_RATE);
			columnDISC_E_LEVEL_5_RATE = new DataColumn("DISC_E_LEVEL_5_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_5_RATE);
			columnDISC_E_LEVEL_6_RATE = new DataColumn("DISC_E_LEVEL_6_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_6_RATE);
			columnDISC_E_LEVEL_7_RATE = new DataColumn("DISC_E_LEVEL_7_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_7_RATE);
			columnDISC_E_LEVEL_8_RATE = new DataColumn("DISC_E_LEVEL_8_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_8_RATE);
			columnDISC_E_LEVEL_9_RATE = new DataColumn("DISC_E_LEVEL_9_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_9_RATE);
			columnDISC_E_LEVEL_10_RATE = new DataColumn("DISC_E_LEVEL_10_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDISC_E_LEVEL_10_RATE);
			columnPURCHASE_NOMINAL_CODE = new DataColumn("PURCHASE_NOMINAL_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPURCHASE_NOMINAL_CODE);
			columnRECORD_CREATE_DATE = new DataColumn("RECORD_CREATE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_CREATE_DATE);
			columnRECORD_MODIFY_DATE = new DataColumn("RECORD_MODIFY_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_MODIFY_DATE);
			columnRECORD_DELETED = new DataColumn("RECORD_DELETED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRECORD_DELETED);
			columnSTOCK_CODE.MaxLength = 30;
			columnDESCRIPTION.MaxLength = 60;
			columnUNIT_OF_SALE.MaxLength = 8;
			columnNOMINAL_CODE.MaxLength = 8;
			columnPURCHASE_REF.MaxLength = 8;
			columnSUPPLIER_PART_NUMBER.MaxLength = 16;
			columnLOCATION.MaxLength = 16;
			columnCOMMODITY_CODE.MaxLength = 30;
			columnWEB_DESCRIPTION.MaxLength = 60;
			columnWEB_DETAILS.MaxLength = 1023;
			columnWEB_CATEGORY_1.MaxLength = 60;
			columnWEB_CATEGORY_2.MaxLength = 60;
			columnWEB_CATEGORY_3.MaxLength = 60;
			columnWEB_IMAGE_FILE.MaxLength = 60;
			columnINTRASTAT_COMM_CODE.MaxLength = 8;
			columnIGNORE_STK_LVL_FLAG.AllowDBNull = false;
			columnDEPT_NAME.MaxLength = 60;
			columnTAX_CODE.MaxLength = 3;
			columnSTOCK_CAT_NAME.MaxLength = 30;
			columnHAS_BOM.MaxLength = 1;
			columnBARCODE.MaxLength = 60;
			columnCOMPONENT_CODE_1.MaxLength = 30;
			columnCOMPONENT_CODE_2.MaxLength = 30;
			columnCOMPONENT_CODE_3.MaxLength = 30;
			columnCOMPONENT_CODE_4.MaxLength = 30;
			columnCOMPONENT_CODE_5.MaxLength = 30;
			columnCOMPONENT_CODE_6.MaxLength = 30;
			columnCOMPONENT_CODE_7.MaxLength = 30;
			columnCOMPONENT_CODE_8.MaxLength = 30;
			columnCOMPONENT_CODE_9.MaxLength = 30;
			columnCOMPONENT_CODE_10.MaxLength = 30;
			columnCOMPONENT_CODE_11.MaxLength = 30;
			columnCOMPONENT_CODE_12.MaxLength = 30;
			columnCOMPONENT_CODE_13.MaxLength = 30;
			columnCOMPONENT_CODE_14.MaxLength = 30;
			columnCOMPONENT_CODE_15.MaxLength = 30;
			columnCOMPONENT_CODE_16.MaxLength = 30;
			columnCOMPONENT_CODE_17.MaxLength = 30;
			columnCOMPONENT_CODE_18.MaxLength = 30;
			columnCOMPONENT_CODE_19.MaxLength = 30;
			columnCOMPONENT_CODE_20.MaxLength = 30;
			columnCOMPONENT_CODE_21.MaxLength = 30;
			columnCOMPONENT_CODE_22.MaxLength = 30;
			columnCOMPONENT_CODE_23.MaxLength = 30;
			columnCOMPONENT_CODE_24.MaxLength = 30;
			columnCOMPONENT_CODE_25.MaxLength = 30;
			columnCOMPONENT_CODE_26.MaxLength = 30;
			columnCOMPONENT_CODE_27.MaxLength = 30;
			columnCOMPONENT_CODE_28.MaxLength = 30;
			columnCOMPONENT_CODE_29.MaxLength = 30;
			columnCOMPONENT_CODE_30.MaxLength = 30;
			columnCOMPONENT_CODE_31.MaxLength = 30;
			columnCOMPONENT_CODE_32.MaxLength = 30;
			columnCOMPONENT_CODE_33.MaxLength = 30;
			columnCOMPONENT_CODE_34.MaxLength = 30;
			columnCOMPONENT_CODE_35.MaxLength = 30;
			columnCOMPONENT_CODE_36.MaxLength = 30;
			columnCOMPONENT_CODE_37.MaxLength = 30;
			columnCOMPONENT_CODE_38.MaxLength = 30;
			columnCOMPONENT_CODE_39.MaxLength = 30;
			columnCOMPONENT_CODE_40.MaxLength = 30;
			columnCOMPONENT_CODE_41.MaxLength = 30;
			columnCOMPONENT_CODE_42.MaxLength = 30;
			columnCOMPONENT_CODE_43.MaxLength = 30;
			columnCOMPONENT_CODE_44.MaxLength = 30;
			columnCOMPONENT_CODE_45.MaxLength = 30;
			columnCOMPONENT_CODE_46.MaxLength = 30;
			columnCOMPONENT_CODE_47.MaxLength = 30;
			columnCOMPONENT_CODE_48.MaxLength = 30;
			columnCOMPONENT_CODE_49.MaxLength = 30;
			columnCOMPONENT_CODE_50.MaxLength = 30;
			columnPURCHASE_NOMINAL_CODE.MaxLength = 8;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductsListRow NewProductsListRow()
		{
			return (ProductsListRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new ProductsListRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(ProductsListRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (ProductsListRowChanged != null)
			{
				ProductsListRowChanged?.Invoke(this, new ProductsListRowChangeEvent((ProductsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (ProductsListRowChanging != null)
			{
				ProductsListRowChanging?.Invoke(this, new ProductsListRowChangeEvent((ProductsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (ProductsListRowDeleted != null)
			{
				ProductsListRowDeleted?.Invoke(this, new ProductsListRowChangeEvent((ProductsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (ProductsListRowDeleting != null)
			{
				ProductsListRowDeleting?.Invoke(this, new ProductsListRowChangeEvent((ProductsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveProductsListRow(ProductsListRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Products products = new Products();
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
			xmlSchemaAttribute.FixedValue = products.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "ProductsListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = products.GetSchemaSerializable();
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
	public class ProductsListRow : DataRow
	{
		private ProductsListDataTable tableProductsList;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string STOCK_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.STOCK_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STOCK_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.STOCK_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DESCRIPTION
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.DESCRIPTIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DESCRIPTION' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DESCRIPTIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UNIT_OF_SALE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.UNIT_OF_SALEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UNIT_OF_SALE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.UNIT_OF_SALEColumn] = value;
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
					return Conversions.ToString(base[tableProductsList.NOMINAL_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NOMINAL_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.NOMINAL_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PURCHASE_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.PURCHASE_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PURCHASE_REF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PURCHASE_REFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SUPPLIER_PART_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.SUPPLIER_PART_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SUPPLIER_PART_NUMBER' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SUPPLIER_PART_NUMBERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string LOCATION
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.LOCATIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LOCATION' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LOCATIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMMODITY_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMMODITY_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMMODITY_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMMODITY_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_PRICE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_PRICEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_PRICE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_PRICEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_DESCRIPTION
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_DESCRIPTIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_DESCRIPTION' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_DESCRIPTIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_DETAILS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_DETAILSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_DETAILS' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_DETAILSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_CATEGORY_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_CATEGORY_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_CATEGORY_1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_CATEGORY_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_CATEGORY_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_CATEGORY_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_CATEGORY_2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_CATEGORY_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_CATEGORY_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_CATEGORY_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_CATEGORY_3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_CATEGORY_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WEB_IMAGE_FILE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.WEB_IMAGE_FILEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_IMAGE_FILE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_IMAGE_FILEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short WEB_PUBLISH
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.WEB_PUBLISHColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_PUBLISH' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_PUBLISHColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short WEB_SPECIAL
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.WEB_SPECIALColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'WEB_SPECIAL' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.WEB_SPECIALColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string INTRASTAT_COMM_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.INTRASTAT_COMM_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INTRASTAT_COMM_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.INTRASTAT_COMM_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short IGNORE_STK_LVL_FLAG
		{
			get
			{
				return Conversions.ToShort(base[tableProductsList.IGNORE_STK_LVL_FLAGColumn]);
			}
			set
			{
				base[tableProductsList.IGNORE_STK_LVL_FLAGColumn] = value;
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
					return Conversions.ToShort(base[tableProductsList.DEPT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NUMBER' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DEPT_NUMBERColumn] = value;
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
					return Conversions.ToString(base[tableProductsList.DEPT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEPT_NAME' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DEPT_NAMEColumn] = value;
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
					return Conversions.ToString(base[tableProductsList.TAX_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.TAX_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short ASSEMBLY_LEVEL
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.ASSEMBLY_LEVELColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ASSEMBLY_LEVEL' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.ASSEMBLY_LEVELColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short LINK_LEVEL
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.LINK_LEVELColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LINK_LEVEL' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LINK_LEVELColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short STOCK_CAT
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.STOCK_CATColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STOCK_CAT' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.STOCK_CATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string STOCK_CAT_NAME
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.STOCK_CAT_NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STOCK_CAT_NAME' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.STOCK_CAT_NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime STOCK_TAKE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableProductsList.STOCK_TAKE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'STOCK_TAKE_DATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.STOCK_TAKE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double LAST_PURCHASE_PRICE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.LAST_PURCHASE_PRICEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_PURCHASE_PRICE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LAST_PURCHASE_PRICEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double LAST_DISC_PURCHASE_PRICE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.LAST_DISC_PURCHASE_PRICEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_DISC_PURCHASE_PRICE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LAST_DISC_PURCHASE_PRICEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double AVERAGE_COST_PRICE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.AVERAGE_COST_PRICEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'AVERAGE_COST_PRICE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.AVERAGE_COST_PRICEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_IN_STOCK
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_IN_STOCKColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_IN_STOCK' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_IN_STOCKColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_ON_ORDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_ON_ORDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_ON_ORDER' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_ON_ORDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_ALLOCATED
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_ALLOCATEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_ALLOCATED' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_ALLOCATEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_LAST_ORDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_LAST_ORDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_LAST_ORDER' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_LAST_ORDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_REORDER
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_REORDERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_REORDER' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_REORDERColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_REORDER_LEVEL
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_REORDER_LEVELColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_REORDER_LEVEL' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_REORDER_LEVELColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_LAST_STOCK_TAKE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_LAST_STOCK_TAKEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_LAST_STOCK_TAKE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_LAST_STOCK_TAKEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_MAKEUP
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_MAKEUPColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_MAKEUP' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_MAKEUPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime LAST_SALE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableProductsList.LAST_SALE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_SALE_DATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LAST_SALE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime LAST_PURCHASE_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableProductsList.LAST_PURCHASE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'LAST_PURCHASE_DATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.LAST_PURCHASE_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double UNIT_WEIGHT
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.UNIT_WEIGHTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'UNIT_WEIGHT' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.UNIT_WEIGHTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short HAS_NO_COMPONENT
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableProductsList.HAS_NO_COMPONENTColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'HAS_NO_COMPONENT' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.HAS_NO_COMPONENTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HAS_BOM
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.HAS_BOMColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'HAS_BOM' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.HAS_BOMColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BARCODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.BARCODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BARCODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BARCODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_1
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_2
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_3
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_4
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_5
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_6
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_7
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_8
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_9
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_10
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_11
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_12
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_13
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_13Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_13' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_13Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_14
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_14Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_14' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_14Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_15
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_15Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_15' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_15Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_16
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_16Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_16' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_16Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_17
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_17Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_17' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_17Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_18
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_18Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_18' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_18Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_19
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_19Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_19' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_19Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_20
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_20Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_20' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_20Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_21
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_21Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_21' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_21Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_22
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_22Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_22' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_22Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_23
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_23Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_23' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_23Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_24
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_24Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_24' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_24Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_25
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_25Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_25' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_25Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_26
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_26Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_26' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_26Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_27
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_27Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_27' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_27Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_28
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_28Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_28' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_28Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_29
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_29Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_29' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_29Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_30
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_30' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_31
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_31Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_31' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_31Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_32
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_32Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_32' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_32Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_33
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_33Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_33' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_33Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_34
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_34Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_34' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_34Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_35
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_35Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_35' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_35Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_36
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_36Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_36' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_36Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_37
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_37Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_37' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_37Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_38
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_38Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_38' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_38Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_39
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_39Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_39' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_39Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_40
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_40Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_40' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_40Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_41
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_41Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_41' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_41Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_42
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_42Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_42' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_42Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_43
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_43Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_43' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_43Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_44
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_44Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_44' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_44Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_45
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_45Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_45' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_45Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_46
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_46Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_46' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_46Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_47
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_47Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_47' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_47Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_48
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_48Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_48' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_48Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_49
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_49Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_49' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_49Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string COMPONENT_CODE_50
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.COMPONENT_CODE_50Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_CODE_50' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_CODE_50Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_13
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_13Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_13' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_13Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_14
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_14Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_14' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_14Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_15
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_15Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_15' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_15Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_16
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_16Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_16' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_16Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_17
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_17Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_17' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_17Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_18
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_18Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_18' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_18Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_19
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_19Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_19' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_19Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_20
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_20Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_20' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_20Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_21
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_21Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_21' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_21Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_22
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_22Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_22' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_22Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_23
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_23Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_23' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_23Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_24
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_24Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_24' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_24Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_25
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_25Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_25' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_25Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_26
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_26Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_26' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_26Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_27
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_27Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_27' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_27Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_28
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_28Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_28' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_28Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_29
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_29Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_29' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_29Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_30
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_30Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_30' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_30Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_31
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_31Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_31' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_31Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_32
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_32Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_32' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_32Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_33
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_33Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_33' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_33Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_34
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_34Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_34' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_34Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_35
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_35Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_35' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_35Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_36
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_36Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_36' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_36Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_37
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_37Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_37' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_37Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_38
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_38Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_38' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_38Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_39
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_39Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_39' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_39Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_40
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_40Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_40' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_40Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_41
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_41Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_41' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_41Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_42
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_42Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_42' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_42Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_43
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_43Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_43' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_43Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_44
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_44Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_44' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_44Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_45
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_45Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_45' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_45Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_46
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_46Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_46' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_46Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_47
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_47Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_47' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_47Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_48
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_48Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_48' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_48Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_49
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_49Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_49' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_49Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COMPONENT_QTY_50
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COMPONENT_QTY_50Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COMPONENT_QTY_50' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COMPONENT_QTY_50Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double QTY_SOLD_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.QTY_SOLD_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'QTY_SOLD_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.QTY_SOLD_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double SALES_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.SALES_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SALES_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.SALES_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double COST_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.COST_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'COST_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.COST_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int THIS_RECORD
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableProductsList.THIS_RECORDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'THIS_RECORD' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.THIS_RECORDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_QTY_SOLD_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_QTY_SOLD_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_QTY_SOLD_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_QTY_SOLD_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_SALES_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.BUDGET_SALES_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_SALES_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.BUDGET_SALES_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_QTY_SOLD_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_QTY_SOLD_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_QTY_SOLD_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_QTY_SOLD_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_SALES_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_SALES_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_SALES_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_SALES_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_BF' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH1' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH2' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH3' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH4' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH5' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH6' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH7' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH8' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH9' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH10' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH11' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_MTH12' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_COST_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.PRIOR_YR_COST_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_COST_FUTURE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PRIOR_YR_COST_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_1_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_1_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_1_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_1_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_2_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_2_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_2_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_2_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_3_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_3_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_3_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_3_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_4_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_4_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_4_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_4_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_5_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_5_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_5_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_5_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_6_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_6_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_6_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_6_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_7_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_7_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_7_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_7_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_8_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_8_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_8_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_8_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_9_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_9_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_9_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_9_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_10_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_10_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_10_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_10_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_1_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_1_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_1_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_1_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_2_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_2_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_2_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_2_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_3_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_3_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_3_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_3_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_4_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_4_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_4_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_4_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_5_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_5_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_5_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_5_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_6_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_6_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_6_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_6_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_7_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_7_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_7_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_7_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_8_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_8_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_8_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_8_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_9_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_9_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_9_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_9_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_A_LEVEL_10_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_A_LEVEL_10_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_A_LEVEL_10_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_A_LEVEL_10_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_1_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_1_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_1_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_1_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_2_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_2_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_2_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_2_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_3_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_3_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_3_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_3_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_4_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_4_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_4_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_4_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_5_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_5_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_5_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_5_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_6_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_6_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_6_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_6_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_7_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_7_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_7_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_7_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_8_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_8_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_8_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_8_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_9_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_9_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_9_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_9_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_10_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_10_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_10_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_10_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_1_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_1_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_1_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_1_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_2_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_2_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_2_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_2_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_3_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_3_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_3_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_3_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_4_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_4_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_4_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_4_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_5_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_5_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_5_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_5_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_6_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_6_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_6_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_6_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_7_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_7_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_7_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_7_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_8_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_8_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_8_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_8_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_9_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_9_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_9_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_9_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_B_LEVEL_10_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_B_LEVEL_10_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_B_LEVEL_10_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_B_LEVEL_10_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_1_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_1_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_1_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_1_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_2_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_2_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_2_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_2_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_3_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_3_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_3_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_3_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_4_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_4_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_4_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_4_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_5_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_5_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_5_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_5_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_6_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_6_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_6_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_6_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_7_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_7_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_7_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_7_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_8_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_8_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_8_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_8_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_9_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_9_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_9_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_9_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_10_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_10_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_10_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_10_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_1_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_1_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_1_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_1_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_2_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_2_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_2_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_2_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_3_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_3_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_3_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_3_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_4_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_4_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_4_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_4_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_5_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_5_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_5_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_5_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_6_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_6_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_6_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_6_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_7_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_7_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_7_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_7_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_8_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_8_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_8_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_8_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_9_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_9_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_9_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_9_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_C_LEVEL_10_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_C_LEVEL_10_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_C_LEVEL_10_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_C_LEVEL_10_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_1_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_1_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_1_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_1_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_2_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_2_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_2_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_2_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_3_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_3_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_3_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_3_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_4_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_4_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_4_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_4_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_5_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_5_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_5_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_5_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_6_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_6_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_6_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_6_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_7_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_7_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_7_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_7_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_8_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_8_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_8_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_8_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_9_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_9_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_9_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_9_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_10_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_10_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_10_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_10_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_1_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_1_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_1_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_1_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_2_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_2_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_2_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_2_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_3_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_3_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_3_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_3_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_4_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_4_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_4_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_4_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_5_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_5_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_5_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_5_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_6_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_6_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_6_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_6_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_7_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_7_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_7_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_7_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_8_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_8_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_8_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_8_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_9_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_9_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_9_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_9_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_D_LEVEL_10_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_D_LEVEL_10_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_D_LEVEL_10_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_D_LEVEL_10_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_1_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_1_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_1_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_1_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_2_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_2_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_2_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_2_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_3_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_3_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_3_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_3_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_4_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_4_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_4_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_4_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_5_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_5_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_5_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_5_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_6_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_6_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_6_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_6_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_7_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_7_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_7_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_7_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_8_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_8_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_8_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_8_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_9_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_9_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_9_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_9_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_10_QTY
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_10_QTYColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_10_QTY' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_10_QTYColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_1_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_1_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_1_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_1_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_2_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_2_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_2_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_2_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_3_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_3_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_3_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_3_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_4_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_4_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_4_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_4_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_5_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_5_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_5_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_5_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_6_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_6_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_6_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_6_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_7_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_7_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_7_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_7_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_8_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_8_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_8_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_8_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_9_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_9_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_9_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_9_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DISC_E_LEVEL_10_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableProductsList.DISC_E_LEVEL_10_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISC_E_LEVEL_10_RATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.DISC_E_LEVEL_10_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PURCHASE_NOMINAL_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableProductsList.PURCHASE_NOMINAL_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PURCHASE_NOMINAL_CODE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.PURCHASE_NOMINAL_CODEColumn] = value;
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
					return Conversions.ToDate(base[tableProductsList.RECORD_CREATE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_CREATE_DATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.RECORD_CREATE_DATEColumn] = value;
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
					return Conversions.ToDate(base[tableProductsList.RECORD_MODIFY_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_MODIFY_DATE' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.RECORD_MODIFY_DATEColumn] = value;
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
					return Conversions.ToShort(base[tableProductsList.RECORD_DELETEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_DELETED' in table 'ProductsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableProductsList.RECORD_DELETEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ProductsListRow(DataRowBuilder rb)
			: base(rb)
		{
			tableProductsList = (ProductsListDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTOCK_CODENull()
		{
			return IsNull(tableProductsList.STOCK_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTOCK_CODENull()
		{
			base[tableProductsList.STOCK_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDESCRIPTIONNull()
		{
			return IsNull(tableProductsList.DESCRIPTIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDESCRIPTIONNull()
		{
			base[tableProductsList.DESCRIPTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUNIT_OF_SALENull()
		{
			return IsNull(tableProductsList.UNIT_OF_SALEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUNIT_OF_SALENull()
		{
			base[tableProductsList.UNIT_OF_SALEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNOMINAL_CODENull()
		{
			return IsNull(tableProductsList.NOMINAL_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNOMINAL_CODENull()
		{
			base[tableProductsList.NOMINAL_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPURCHASE_REFNull()
		{
			return IsNull(tableProductsList.PURCHASE_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPURCHASE_REFNull()
		{
			base[tableProductsList.PURCHASE_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSUPPLIER_PART_NUMBERNull()
		{
			return IsNull(tableProductsList.SUPPLIER_PART_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSUPPLIER_PART_NUMBERNull()
		{
			base[tableProductsList.SUPPLIER_PART_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLOCATIONNull()
		{
			return IsNull(tableProductsList.LOCATIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLOCATIONNull()
		{
			base[tableProductsList.LOCATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMMODITY_CODENull()
		{
			return IsNull(tableProductsList.COMMODITY_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMMODITY_CODENull()
		{
			base[tableProductsList.COMMODITY_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_PRICENull()
		{
			return IsNull(tableProductsList.SALES_PRICEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_PRICENull()
		{
			base[tableProductsList.SALES_PRICEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_DESCRIPTIONNull()
		{
			return IsNull(tableProductsList.WEB_DESCRIPTIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_DESCRIPTIONNull()
		{
			base[tableProductsList.WEB_DESCRIPTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_DETAILSNull()
		{
			return IsNull(tableProductsList.WEB_DETAILSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_DETAILSNull()
		{
			base[tableProductsList.WEB_DETAILSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_CATEGORY_1Null()
		{
			return IsNull(tableProductsList.WEB_CATEGORY_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_CATEGORY_1Null()
		{
			base[tableProductsList.WEB_CATEGORY_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_CATEGORY_2Null()
		{
			return IsNull(tableProductsList.WEB_CATEGORY_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_CATEGORY_2Null()
		{
			base[tableProductsList.WEB_CATEGORY_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_CATEGORY_3Null()
		{
			return IsNull(tableProductsList.WEB_CATEGORY_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_CATEGORY_3Null()
		{
			base[tableProductsList.WEB_CATEGORY_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_IMAGE_FILENull()
		{
			return IsNull(tableProductsList.WEB_IMAGE_FILEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_IMAGE_FILENull()
		{
			base[tableProductsList.WEB_IMAGE_FILEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_PUBLISHNull()
		{
			return IsNull(tableProductsList.WEB_PUBLISHColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_PUBLISHNull()
		{
			base[tableProductsList.WEB_PUBLISHColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsWEB_SPECIALNull()
		{
			return IsNull(tableProductsList.WEB_SPECIALColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetWEB_SPECIALNull()
		{
			base[tableProductsList.WEB_SPECIALColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINTRASTAT_COMM_CODENull()
		{
			return IsNull(tableProductsList.INTRASTAT_COMM_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINTRASTAT_COMM_CODENull()
		{
			base[tableProductsList.INTRASTAT_COMM_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NUMBERNull()
		{
			return IsNull(tableProductsList.DEPT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NUMBERNull()
		{
			base[tableProductsList.DEPT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEPT_NAMENull()
		{
			return IsNull(tableProductsList.DEPT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEPT_NAMENull()
		{
			base[tableProductsList.DEPT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_CODENull()
		{
			return IsNull(tableProductsList.TAX_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_CODENull()
		{
			base[tableProductsList.TAX_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsASSEMBLY_LEVELNull()
		{
			return IsNull(tableProductsList.ASSEMBLY_LEVELColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetASSEMBLY_LEVELNull()
		{
			base[tableProductsList.ASSEMBLY_LEVELColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLINK_LEVELNull()
		{
			return IsNull(tableProductsList.LINK_LEVELColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLINK_LEVELNull()
		{
			base[tableProductsList.LINK_LEVELColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTOCK_CATNull()
		{
			return IsNull(tableProductsList.STOCK_CATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTOCK_CATNull()
		{
			base[tableProductsList.STOCK_CATColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTOCK_CAT_NAMENull()
		{
			return IsNull(tableProductsList.STOCK_CAT_NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTOCK_CAT_NAMENull()
		{
			base[tableProductsList.STOCK_CAT_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTOCK_TAKE_DATENull()
		{
			return IsNull(tableProductsList.STOCK_TAKE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTOCK_TAKE_DATENull()
		{
			base[tableProductsList.STOCK_TAKE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_PURCHASE_PRICENull()
		{
			return IsNull(tableProductsList.LAST_PURCHASE_PRICEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_PURCHASE_PRICENull()
		{
			base[tableProductsList.LAST_PURCHASE_PRICEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_DISC_PURCHASE_PRICENull()
		{
			return IsNull(tableProductsList.LAST_DISC_PURCHASE_PRICEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_DISC_PURCHASE_PRICENull()
		{
			base[tableProductsList.LAST_DISC_PURCHASE_PRICEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAVERAGE_COST_PRICENull()
		{
			return IsNull(tableProductsList.AVERAGE_COST_PRICEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetAVERAGE_COST_PRICENull()
		{
			base[tableProductsList.AVERAGE_COST_PRICEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_IN_STOCKNull()
		{
			return IsNull(tableProductsList.QTY_IN_STOCKColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_IN_STOCKNull()
		{
			base[tableProductsList.QTY_IN_STOCKColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_ON_ORDERNull()
		{
			return IsNull(tableProductsList.QTY_ON_ORDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_ON_ORDERNull()
		{
			base[tableProductsList.QTY_ON_ORDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_ALLOCATEDNull()
		{
			return IsNull(tableProductsList.QTY_ALLOCATEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_ALLOCATEDNull()
		{
			base[tableProductsList.QTY_ALLOCATEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_LAST_ORDERNull()
		{
			return IsNull(tableProductsList.QTY_LAST_ORDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_LAST_ORDERNull()
		{
			base[tableProductsList.QTY_LAST_ORDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_REORDERNull()
		{
			return IsNull(tableProductsList.QTY_REORDERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_REORDERNull()
		{
			base[tableProductsList.QTY_REORDERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_REORDER_LEVELNull()
		{
			return IsNull(tableProductsList.QTY_REORDER_LEVELColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_REORDER_LEVELNull()
		{
			base[tableProductsList.QTY_REORDER_LEVELColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_LAST_STOCK_TAKENull()
		{
			return IsNull(tableProductsList.QTY_LAST_STOCK_TAKEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_LAST_STOCK_TAKENull()
		{
			base[tableProductsList.QTY_LAST_STOCK_TAKEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_MAKEUPNull()
		{
			return IsNull(tableProductsList.QTY_MAKEUPColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_MAKEUPNull()
		{
			base[tableProductsList.QTY_MAKEUPColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_SALE_DATENull()
		{
			return IsNull(tableProductsList.LAST_SALE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_SALE_DATENull()
		{
			base[tableProductsList.LAST_SALE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLAST_PURCHASE_DATENull()
		{
			return IsNull(tableProductsList.LAST_PURCHASE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetLAST_PURCHASE_DATENull()
		{
			base[tableProductsList.LAST_PURCHASE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUNIT_WEIGHTNull()
		{
			return IsNull(tableProductsList.UNIT_WEIGHTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetUNIT_WEIGHTNull()
		{
			base[tableProductsList.UNIT_WEIGHTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHAS_NO_COMPONENTNull()
		{
			return IsNull(tableProductsList.HAS_NO_COMPONENTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHAS_NO_COMPONENTNull()
		{
			base[tableProductsList.HAS_NO_COMPONENTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHAS_BOMNull()
		{
			return IsNull(tableProductsList.HAS_BOMColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHAS_BOMNull()
		{
			base[tableProductsList.HAS_BOMColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBARCODENull()
		{
			return IsNull(tableProductsList.BARCODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBARCODENull()
		{
			base[tableProductsList.BARCODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_1Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_1Null()
		{
			base[tableProductsList.COMPONENT_CODE_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_2Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_2Null()
		{
			base[tableProductsList.COMPONENT_CODE_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_3Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_3Null()
		{
			base[tableProductsList.COMPONENT_CODE_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_4Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_4Null()
		{
			base[tableProductsList.COMPONENT_CODE_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_5Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_5Null()
		{
			base[tableProductsList.COMPONENT_CODE_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_6Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_6Null()
		{
			base[tableProductsList.COMPONENT_CODE_6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_7Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_7Null()
		{
			base[tableProductsList.COMPONENT_CODE_7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_8Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_8Null()
		{
			base[tableProductsList.COMPONENT_CODE_8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_9Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_9Null()
		{
			base[tableProductsList.COMPONENT_CODE_9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_10Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_10Null()
		{
			base[tableProductsList.COMPONENT_CODE_10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_11Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_11Null()
		{
			base[tableProductsList.COMPONENT_CODE_11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_12Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_12Null()
		{
			base[tableProductsList.COMPONENT_CODE_12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_13Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_13Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_13Null()
		{
			base[tableProductsList.COMPONENT_CODE_13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_14Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_14Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_14Null()
		{
			base[tableProductsList.COMPONENT_CODE_14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_15Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_15Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_15Null()
		{
			base[tableProductsList.COMPONENT_CODE_15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_16Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_16Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_16Null()
		{
			base[tableProductsList.COMPONENT_CODE_16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_17Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_17Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_17Null()
		{
			base[tableProductsList.COMPONENT_CODE_17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_18Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_18Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_18Null()
		{
			base[tableProductsList.COMPONENT_CODE_18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_19Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_19Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_19Null()
		{
			base[tableProductsList.COMPONENT_CODE_19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_20Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_20Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_20Null()
		{
			base[tableProductsList.COMPONENT_CODE_20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_21Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_21Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_21Null()
		{
			base[tableProductsList.COMPONENT_CODE_21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_22Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_22Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_22Null()
		{
			base[tableProductsList.COMPONENT_CODE_22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_23Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_23Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_23Null()
		{
			base[tableProductsList.COMPONENT_CODE_23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_24Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_24Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_24Null()
		{
			base[tableProductsList.COMPONENT_CODE_24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_25Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_25Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_25Null()
		{
			base[tableProductsList.COMPONENT_CODE_25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_26Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_26Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_26Null()
		{
			base[tableProductsList.COMPONENT_CODE_26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_27Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_27Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_27Null()
		{
			base[tableProductsList.COMPONENT_CODE_27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_28Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_28Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_28Null()
		{
			base[tableProductsList.COMPONENT_CODE_28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_29Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_29Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_29Null()
		{
			base[tableProductsList.COMPONENT_CODE_29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_30Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_30Null()
		{
			base[tableProductsList.COMPONENT_CODE_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_31Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_31Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_31Null()
		{
			base[tableProductsList.COMPONENT_CODE_31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_32Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_32Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_32Null()
		{
			base[tableProductsList.COMPONENT_CODE_32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_33Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_33Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_33Null()
		{
			base[tableProductsList.COMPONENT_CODE_33Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_34Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_34Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_34Null()
		{
			base[tableProductsList.COMPONENT_CODE_34Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_35Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_35Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_35Null()
		{
			base[tableProductsList.COMPONENT_CODE_35Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_36Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_36Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_36Null()
		{
			base[tableProductsList.COMPONENT_CODE_36Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_37Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_37Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_37Null()
		{
			base[tableProductsList.COMPONENT_CODE_37Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_38Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_38Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_38Null()
		{
			base[tableProductsList.COMPONENT_CODE_38Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_39Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_39Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_39Null()
		{
			base[tableProductsList.COMPONENT_CODE_39Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_40Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_40Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_40Null()
		{
			base[tableProductsList.COMPONENT_CODE_40Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_41Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_41Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_41Null()
		{
			base[tableProductsList.COMPONENT_CODE_41Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_42Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_42Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_42Null()
		{
			base[tableProductsList.COMPONENT_CODE_42Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_43Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_43Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_43Null()
		{
			base[tableProductsList.COMPONENT_CODE_43Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_44Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_44Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_44Null()
		{
			base[tableProductsList.COMPONENT_CODE_44Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_45Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_45Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_45Null()
		{
			base[tableProductsList.COMPONENT_CODE_45Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_46Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_46Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_46Null()
		{
			base[tableProductsList.COMPONENT_CODE_46Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_47Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_47Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_47Null()
		{
			base[tableProductsList.COMPONENT_CODE_47Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_48Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_48Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_48Null()
		{
			base[tableProductsList.COMPONENT_CODE_48Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_49Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_49Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_49Null()
		{
			base[tableProductsList.COMPONENT_CODE_49Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_CODE_50Null()
		{
			return IsNull(tableProductsList.COMPONENT_CODE_50Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_CODE_50Null()
		{
			base[tableProductsList.COMPONENT_CODE_50Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_1Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_1Null()
		{
			base[tableProductsList.COMPONENT_QTY_1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_2Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_2Null()
		{
			base[tableProductsList.COMPONENT_QTY_2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_3Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_3Null()
		{
			base[tableProductsList.COMPONENT_QTY_3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_4Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_4Null()
		{
			base[tableProductsList.COMPONENT_QTY_4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_5Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_5Null()
		{
			base[tableProductsList.COMPONENT_QTY_5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_6Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_6Null()
		{
			base[tableProductsList.COMPONENT_QTY_6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_7Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_7Null()
		{
			base[tableProductsList.COMPONENT_QTY_7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_8Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_8Null()
		{
			base[tableProductsList.COMPONENT_QTY_8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_9Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_9Null()
		{
			base[tableProductsList.COMPONENT_QTY_9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_10Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_10Null()
		{
			base[tableProductsList.COMPONENT_QTY_10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_11Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_11Null()
		{
			base[tableProductsList.COMPONENT_QTY_11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_12Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_12Null()
		{
			base[tableProductsList.COMPONENT_QTY_12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_13Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_13Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_13Null()
		{
			base[tableProductsList.COMPONENT_QTY_13Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_14Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_14Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_14Null()
		{
			base[tableProductsList.COMPONENT_QTY_14Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_15Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_15Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_15Null()
		{
			base[tableProductsList.COMPONENT_QTY_15Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_16Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_16Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_16Null()
		{
			base[tableProductsList.COMPONENT_QTY_16Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_17Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_17Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_17Null()
		{
			base[tableProductsList.COMPONENT_QTY_17Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_18Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_18Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_18Null()
		{
			base[tableProductsList.COMPONENT_QTY_18Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_19Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_19Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_19Null()
		{
			base[tableProductsList.COMPONENT_QTY_19Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_20Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_20Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_20Null()
		{
			base[tableProductsList.COMPONENT_QTY_20Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_21Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_21Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_21Null()
		{
			base[tableProductsList.COMPONENT_QTY_21Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_22Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_22Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_22Null()
		{
			base[tableProductsList.COMPONENT_QTY_22Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_23Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_23Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_23Null()
		{
			base[tableProductsList.COMPONENT_QTY_23Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_24Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_24Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_24Null()
		{
			base[tableProductsList.COMPONENT_QTY_24Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_25Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_25Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_25Null()
		{
			base[tableProductsList.COMPONENT_QTY_25Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_26Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_26Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_26Null()
		{
			base[tableProductsList.COMPONENT_QTY_26Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_27Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_27Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_27Null()
		{
			base[tableProductsList.COMPONENT_QTY_27Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_28Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_28Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_28Null()
		{
			base[tableProductsList.COMPONENT_QTY_28Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_29Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_29Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_29Null()
		{
			base[tableProductsList.COMPONENT_QTY_29Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_30Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_30Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_30Null()
		{
			base[tableProductsList.COMPONENT_QTY_30Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_31Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_31Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_31Null()
		{
			base[tableProductsList.COMPONENT_QTY_31Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_32Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_32Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_32Null()
		{
			base[tableProductsList.COMPONENT_QTY_32Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_33Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_33Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_33Null()
		{
			base[tableProductsList.COMPONENT_QTY_33Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_34Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_34Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_34Null()
		{
			base[tableProductsList.COMPONENT_QTY_34Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_35Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_35Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_35Null()
		{
			base[tableProductsList.COMPONENT_QTY_35Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_36Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_36Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_36Null()
		{
			base[tableProductsList.COMPONENT_QTY_36Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_37Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_37Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_37Null()
		{
			base[tableProductsList.COMPONENT_QTY_37Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_38Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_38Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_38Null()
		{
			base[tableProductsList.COMPONENT_QTY_38Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_39Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_39Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_39Null()
		{
			base[tableProductsList.COMPONENT_QTY_39Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_40Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_40Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_40Null()
		{
			base[tableProductsList.COMPONENT_QTY_40Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_41Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_41Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_41Null()
		{
			base[tableProductsList.COMPONENT_QTY_41Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_42Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_42Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_42Null()
		{
			base[tableProductsList.COMPONENT_QTY_42Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_43Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_43Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_43Null()
		{
			base[tableProductsList.COMPONENT_QTY_43Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_44Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_44Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_44Null()
		{
			base[tableProductsList.COMPONENT_QTY_44Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_45Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_45Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_45Null()
		{
			base[tableProductsList.COMPONENT_QTY_45Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_46Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_46Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_46Null()
		{
			base[tableProductsList.COMPONENT_QTY_46Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_47Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_47Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_47Null()
		{
			base[tableProductsList.COMPONENT_QTY_47Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_48Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_48Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_48Null()
		{
			base[tableProductsList.COMPONENT_QTY_48Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_49Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_49Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_49Null()
		{
			base[tableProductsList.COMPONENT_QTY_49Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOMPONENT_QTY_50Null()
		{
			return IsNull(tableProductsList.COMPONENT_QTY_50Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOMPONENT_QTY_50Null()
		{
			base[tableProductsList.COMPONENT_QTY_50Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_BFNull()
		{
			return IsNull(tableProductsList.QTY_SOLD_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_BFNull()
		{
			base[tableProductsList.QTY_SOLD_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH1Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH1Null()
		{
			base[tableProductsList.QTY_SOLD_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH2Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH2Null()
		{
			base[tableProductsList.QTY_SOLD_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH3Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH3Null()
		{
			base[tableProductsList.QTY_SOLD_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH4Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH4Null()
		{
			base[tableProductsList.QTY_SOLD_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH5Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH5Null()
		{
			base[tableProductsList.QTY_SOLD_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH6Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH6Null()
		{
			base[tableProductsList.QTY_SOLD_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH7Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH7Null()
		{
			base[tableProductsList.QTY_SOLD_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH8Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH8Null()
		{
			base[tableProductsList.QTY_SOLD_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH9Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH9Null()
		{
			base[tableProductsList.QTY_SOLD_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH10Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH10Null()
		{
			base[tableProductsList.QTY_SOLD_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH11Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH11Null()
		{
			base[tableProductsList.QTY_SOLD_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_MTH12Null()
		{
			return IsNull(tableProductsList.QTY_SOLD_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_MTH12Null()
		{
			base[tableProductsList.QTY_SOLD_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsQTY_SOLD_FUTURENull()
		{
			return IsNull(tableProductsList.QTY_SOLD_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetQTY_SOLD_FUTURENull()
		{
			base[tableProductsList.QTY_SOLD_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_BFNull()
		{
			return IsNull(tableProductsList.SALES_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_BFNull()
		{
			base[tableProductsList.SALES_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH1Null()
		{
			return IsNull(tableProductsList.SALES_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH1Null()
		{
			base[tableProductsList.SALES_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH2Null()
		{
			return IsNull(tableProductsList.SALES_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH2Null()
		{
			base[tableProductsList.SALES_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH3Null()
		{
			return IsNull(tableProductsList.SALES_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH3Null()
		{
			base[tableProductsList.SALES_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH4Null()
		{
			return IsNull(tableProductsList.SALES_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH4Null()
		{
			base[tableProductsList.SALES_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH5Null()
		{
			return IsNull(tableProductsList.SALES_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH5Null()
		{
			base[tableProductsList.SALES_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH6Null()
		{
			return IsNull(tableProductsList.SALES_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH6Null()
		{
			base[tableProductsList.SALES_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH7Null()
		{
			return IsNull(tableProductsList.SALES_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH7Null()
		{
			base[tableProductsList.SALES_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH8Null()
		{
			return IsNull(tableProductsList.SALES_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH8Null()
		{
			base[tableProductsList.SALES_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH9Null()
		{
			return IsNull(tableProductsList.SALES_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH9Null()
		{
			base[tableProductsList.SALES_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH10Null()
		{
			return IsNull(tableProductsList.SALES_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH10Null()
		{
			base[tableProductsList.SALES_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH11Null()
		{
			return IsNull(tableProductsList.SALES_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH11Null()
		{
			base[tableProductsList.SALES_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_MTH12Null()
		{
			return IsNull(tableProductsList.SALES_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_MTH12Null()
		{
			base[tableProductsList.SALES_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSALES_FUTURENull()
		{
			return IsNull(tableProductsList.SALES_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSALES_FUTURENull()
		{
			base[tableProductsList.SALES_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_BFNull()
		{
			return IsNull(tableProductsList.COST_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_BFNull()
		{
			base[tableProductsList.COST_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH1Null()
		{
			return IsNull(tableProductsList.COST_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH1Null()
		{
			base[tableProductsList.COST_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH2Null()
		{
			return IsNull(tableProductsList.COST_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH2Null()
		{
			base[tableProductsList.COST_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH3Null()
		{
			return IsNull(tableProductsList.COST_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH3Null()
		{
			base[tableProductsList.COST_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH4Null()
		{
			return IsNull(tableProductsList.COST_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH4Null()
		{
			base[tableProductsList.COST_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH5Null()
		{
			return IsNull(tableProductsList.COST_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH5Null()
		{
			base[tableProductsList.COST_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH6Null()
		{
			return IsNull(tableProductsList.COST_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH6Null()
		{
			base[tableProductsList.COST_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH7Null()
		{
			return IsNull(tableProductsList.COST_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH7Null()
		{
			base[tableProductsList.COST_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH8Null()
		{
			return IsNull(tableProductsList.COST_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH8Null()
		{
			base[tableProductsList.COST_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH9Null()
		{
			return IsNull(tableProductsList.COST_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH9Null()
		{
			base[tableProductsList.COST_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH10Null()
		{
			return IsNull(tableProductsList.COST_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH10Null()
		{
			base[tableProductsList.COST_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH11Null()
		{
			return IsNull(tableProductsList.COST_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH11Null()
		{
			base[tableProductsList.COST_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_MTH12Null()
		{
			return IsNull(tableProductsList.COST_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_MTH12Null()
		{
			base[tableProductsList.COST_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCOST_FUTURENull()
		{
			return IsNull(tableProductsList.COST_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCOST_FUTURENull()
		{
			base[tableProductsList.COST_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTHIS_RECORDNull()
		{
			return IsNull(tableProductsList.THIS_RECORDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTHIS_RECORDNull()
		{
			base[tableProductsList.THIS_RECORDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_BFNull()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_BFNull()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH1Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH1Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH2Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH2Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH3Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH3Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH4Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH4Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH5Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH5Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH6Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH6Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH7Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH7Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH8Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH8Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH9Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH9Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH10Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH10Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH11Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH11Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_MTH12Null()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_MTH12Null()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_QTY_SOLD_FUTURENull()
		{
			return IsNull(tableProductsList.BUDGET_QTY_SOLD_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_QTY_SOLD_FUTURENull()
		{
			base[tableProductsList.BUDGET_QTY_SOLD_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_BFNull()
		{
			return IsNull(tableProductsList.BUDGET_SALES_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_BFNull()
		{
			base[tableProductsList.BUDGET_SALES_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH1Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH1Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH2Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH2Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH3Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH3Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH4Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH4Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH5Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH5Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH6Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH6Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH7Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH7Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH8Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH8Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH9Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH9Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH10Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH10Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH11Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH11Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_MTH12Null()
		{
			return IsNull(tableProductsList.BUDGET_SALES_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_MTH12Null()
		{
			base[tableProductsList.BUDGET_SALES_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_SALES_FUTURENull()
		{
			return IsNull(tableProductsList.BUDGET_SALES_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_SALES_FUTURENull()
		{
			base[tableProductsList.BUDGET_SALES_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_BFNull()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_BFNull()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH1Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH1Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH2Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH2Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH3Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH3Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH4Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH4Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH5Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH5Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH6Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH6Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH7Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH7Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH8Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH8Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH9Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH9Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH10Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH10Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH11Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH11Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_MTH12Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_MTH12Null()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_QTY_SOLD_FUTURENull()
		{
			return IsNull(tableProductsList.PRIOR_YR_QTY_SOLD_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_QTY_SOLD_FUTURENull()
		{
			base[tableProductsList.PRIOR_YR_QTY_SOLD_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_BFNull()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_BFNull()
		{
			base[tableProductsList.PRIOR_YR_SALES_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH1Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH1Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH2Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH2Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH3Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH3Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH4Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH4Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH5Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH5Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH6Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH6Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH7Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH7Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH8Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH8Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH9Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH9Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH10Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH10Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH11Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH11Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_MTH12Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_MTH12Null()
		{
			base[tableProductsList.PRIOR_YR_SALES_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_SALES_FUTURENull()
		{
			return IsNull(tableProductsList.PRIOR_YR_SALES_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_SALES_FUTURENull()
		{
			base[tableProductsList.PRIOR_YR_SALES_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_BFNull()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_BFNull()
		{
			base[tableProductsList.PRIOR_YR_COST_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH1Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH1Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH2Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH2Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH3Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH3Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH4Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH4Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH5Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH5Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH6Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH6Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH7Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH7Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH8Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH8Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH9Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH9Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH10Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH10Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH11Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH11Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_MTH12Null()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_MTH12Null()
		{
			base[tableProductsList.PRIOR_YR_COST_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_COST_FUTURENull()
		{
			return IsNull(tableProductsList.PRIOR_YR_COST_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_COST_FUTURENull()
		{
			base[tableProductsList.PRIOR_YR_COST_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_1_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_1_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_1_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_1_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_2_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_2_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_2_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_2_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_3_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_3_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_3_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_3_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_4_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_4_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_4_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_4_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_5_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_5_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_5_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_5_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_6_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_6_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_6_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_6_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_7_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_7_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_7_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_7_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_8_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_8_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_8_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_8_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_9_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_9_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_9_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_9_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_10_QTYNull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_10_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_10_QTYNull()
		{
			base[tableProductsList.DISC_A_LEVEL_10_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_1_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_1_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_1_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_1_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_2_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_2_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_2_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_2_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_3_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_3_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_3_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_3_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_4_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_4_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_4_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_4_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_5_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_5_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_5_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_5_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_6_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_6_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_6_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_6_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_7_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_7_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_7_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_7_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_8_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_8_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_8_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_8_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_9_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_9_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_9_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_9_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_A_LEVEL_10_RATENull()
		{
			return IsNull(tableProductsList.DISC_A_LEVEL_10_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_A_LEVEL_10_RATENull()
		{
			base[tableProductsList.DISC_A_LEVEL_10_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_1_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_1_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_1_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_1_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_2_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_2_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_2_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_2_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_3_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_3_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_3_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_3_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_4_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_4_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_4_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_4_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_5_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_5_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_5_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_5_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_6_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_6_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_6_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_6_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_7_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_7_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_7_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_7_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_8_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_8_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_8_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_8_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_9_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_9_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_9_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_9_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_10_QTYNull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_10_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_10_QTYNull()
		{
			base[tableProductsList.DISC_B_LEVEL_10_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_1_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_1_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_1_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_1_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_2_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_2_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_2_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_2_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_3_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_3_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_3_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_3_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_4_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_4_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_4_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_4_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_5_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_5_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_5_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_5_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_6_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_6_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_6_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_6_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_7_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_7_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_7_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_7_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_8_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_8_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_8_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_8_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_9_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_9_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_9_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_9_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_B_LEVEL_10_RATENull()
		{
			return IsNull(tableProductsList.DISC_B_LEVEL_10_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_B_LEVEL_10_RATENull()
		{
			base[tableProductsList.DISC_B_LEVEL_10_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_1_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_1_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_1_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_1_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_2_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_2_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_2_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_2_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_3_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_3_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_3_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_3_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_4_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_4_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_4_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_4_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_5_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_5_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_5_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_5_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_6_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_6_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_6_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_6_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_7_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_7_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_7_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_7_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_8_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_8_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_8_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_8_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_9_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_9_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_9_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_9_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_10_QTYNull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_10_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_10_QTYNull()
		{
			base[tableProductsList.DISC_C_LEVEL_10_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_1_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_1_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_1_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_1_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_2_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_2_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_2_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_2_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_3_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_3_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_3_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_3_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_4_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_4_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_4_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_4_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_5_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_5_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_5_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_5_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_6_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_6_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_6_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_6_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_7_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_7_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_7_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_7_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_8_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_8_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_8_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_8_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_9_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_9_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_9_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_9_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_C_LEVEL_10_RATENull()
		{
			return IsNull(tableProductsList.DISC_C_LEVEL_10_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_C_LEVEL_10_RATENull()
		{
			base[tableProductsList.DISC_C_LEVEL_10_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_1_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_1_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_1_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_1_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_2_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_2_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_2_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_2_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_3_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_3_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_3_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_3_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_4_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_4_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_4_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_4_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_5_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_5_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_5_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_5_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_6_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_6_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_6_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_6_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_7_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_7_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_7_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_7_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_8_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_8_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_8_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_8_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_9_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_9_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_9_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_9_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_10_QTYNull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_10_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_10_QTYNull()
		{
			base[tableProductsList.DISC_D_LEVEL_10_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_1_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_1_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_1_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_1_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_2_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_2_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_2_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_2_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_3_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_3_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_3_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_3_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_4_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_4_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_4_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_4_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_5_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_5_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_5_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_5_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_6_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_6_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_6_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_6_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_7_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_7_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_7_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_7_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_8_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_8_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_8_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_8_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_9_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_9_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_9_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_9_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_D_LEVEL_10_RATENull()
		{
			return IsNull(tableProductsList.DISC_D_LEVEL_10_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_D_LEVEL_10_RATENull()
		{
			base[tableProductsList.DISC_D_LEVEL_10_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_1_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_1_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_1_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_1_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_2_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_2_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_2_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_2_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_3_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_3_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_3_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_3_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_4_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_4_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_4_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_4_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_5_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_5_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_5_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_5_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_6_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_6_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_6_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_6_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_7_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_7_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_7_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_7_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_8_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_8_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_8_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_8_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_9_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_9_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_9_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_9_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_10_QTYNull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_10_QTYColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_10_QTYNull()
		{
			base[tableProductsList.DISC_E_LEVEL_10_QTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_1_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_1_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_1_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_1_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_2_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_2_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_2_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_2_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_3_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_3_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_3_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_3_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_4_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_4_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_4_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_4_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_5_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_5_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_5_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_5_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_6_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_6_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_6_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_6_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_7_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_7_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_7_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_7_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_8_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_8_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_8_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_8_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_9_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_9_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_9_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_9_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISC_E_LEVEL_10_RATENull()
		{
			return IsNull(tableProductsList.DISC_E_LEVEL_10_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISC_E_LEVEL_10_RATENull()
		{
			base[tableProductsList.DISC_E_LEVEL_10_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPURCHASE_NOMINAL_CODENull()
		{
			return IsNull(tableProductsList.PURCHASE_NOMINAL_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPURCHASE_NOMINAL_CODENull()
		{
			base[tableProductsList.PURCHASE_NOMINAL_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_CREATE_DATENull()
		{
			return IsNull(tableProductsList.RECORD_CREATE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_CREATE_DATENull()
		{
			base[tableProductsList.RECORD_CREATE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_MODIFY_DATENull()
		{
			return IsNull(tableProductsList.RECORD_MODIFY_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_MODIFY_DATENull()
		{
			base[tableProductsList.RECORD_MODIFY_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_DELETEDNull()
		{
			return IsNull(tableProductsList.RECORD_DELETEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_DELETEDNull()
		{
			base[tableProductsList.RECORD_DELETEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class ProductsListRowChangeEvent : EventArgs
	{
		private ProductsListRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductsListRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductsListRowChangeEvent(ProductsListRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private ProductsListDataTable tableProductsList;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ProductsListDataTable ProductsList => tableProductsList;

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
	public Products()
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
	protected Products(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["ProductsList"] != null)
			{
				base.Tables.Add(new ProductsListDataTable(dataSet.Tables["ProductsList"]));
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
		Products obj = (Products)base.Clone();
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
			if (dataSet.Tables["ProductsList"] != null)
			{
				base.Tables.Add(new ProductsListDataTable(dataSet.Tables["ProductsList"]));
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
		tableProductsList = (ProductsListDataTable)base.Tables["ProductsList"];
		if (initTable && tableProductsList != null)
		{
			tableProductsList.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "Products";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Products.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableProductsList = new ProductsListDataTable();
		base.Tables.Add(tableProductsList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeProductsList()
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
		Products products = new Products();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = products.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = products.GetSchemaSerializable();
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
