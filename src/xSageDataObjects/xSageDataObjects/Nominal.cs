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
[XmlRoot("Nominal")]
[HelpKeyword("vs.data.DataSet")]
public class Nominal : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void NominalAccountsListRowChangeEventHandler(object sender, NominalAccountsListRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void NominalControlAccountsListRowChangeEventHandler(object sender, NominalControlAccountsListRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class NominalAccountsListDataTable : TypedTableBase<NominalAccountsListRow>
	{
		private DataColumn columnACCOUNT_REF;

		private DataColumn columnNAME;

		private DataColumn columnACCOUNT_TYPE;

		private DataColumn columnBALANCE;

		private DataColumn columnQUICK_RATIO;

		private DataColumn columnSOFA_ID;

		private DataColumn columnPRIOR_YR_MTH1;

		private DataColumn columnPRIOR_YR_MTH2;

		private DataColumn columnPRIOR_YR_MTH3;

		private DataColumn columnPRIOR_YR_MTH4;

		private DataColumn columnPRIOR_YR_MTH5;

		private DataColumn columnPRIOR_YR_MTH6;

		private DataColumn columnPRIOR_YR_MTH7;

		private DataColumn columnPRIOR_YR_MTH8;

		private DataColumn columnPRIOR_YR_MTH9;

		private DataColumn columnPRIOR_YR_MTH10;

		private DataColumn columnPRIOR_YR_MTH11;

		private DataColumn columnPRIOR_YR_MTH12;

		private DataColumn columnPRIOR_YR2_MTH1;

		private DataColumn columnPRIOR_YR2_MTH2;

		private DataColumn columnPRIOR_YR2_MTH3;

		private DataColumn columnPRIOR_YR2_MTH4;

		private DataColumn columnPRIOR_YR2_MTH5;

		private DataColumn columnPRIOR_YR2_MTH6;

		private DataColumn columnPRIOR_YR2_MTH7;

		private DataColumn columnPRIOR_YR2_MTH8;

		private DataColumn columnPRIOR_YR2_MTH9;

		private DataColumn columnPRIOR_YR2_MTH10;

		private DataColumn columnPRIOR_YR2_MTH11;

		private DataColumn columnPRIOR_YR2_MTH12;

		private DataColumn columnPRIOR_YR3_MTH1;

		private DataColumn columnPRIOR_YR3_MTH2;

		private DataColumn columnPRIOR_YR3_MTH3;

		private DataColumn columnPRIOR_YR3_MTH4;

		private DataColumn columnPRIOR_YR3_MTH5;

		private DataColumn columnPRIOR_YR3_MTH6;

		private DataColumn columnPRIOR_YR3_MTH7;

		private DataColumn columnPRIOR_YR3_MTH8;

		private DataColumn columnPRIOR_YR3_MTH9;

		private DataColumn columnPRIOR_YR3_MTH10;

		private DataColumn columnPRIOR_YR3_MTH11;

		private DataColumn columnPRIOR_YR3_MTH12;

		private DataColumn columnPRIOR_YR4_MTH1;

		private DataColumn columnPRIOR_YR4_MTH2;

		private DataColumn columnPRIOR_YR4_MTH3;

		private DataColumn columnPRIOR_YR4_MTH4;

		private DataColumn columnPRIOR_YR4_MTH5;

		private DataColumn columnPRIOR_YR4_MTH6;

		private DataColumn columnPRIOR_YR4_MTH7;

		private DataColumn columnPRIOR_YR4_MTH8;

		private DataColumn columnPRIOR_YR4_MTH9;

		private DataColumn columnPRIOR_YR4_MTH10;

		private DataColumn columnPRIOR_YR4_MTH11;

		private DataColumn columnPRIOR_YR4_MTH12;

		private DataColumn columnPRIOR_YR5_MTH1;

		private DataColumn columnPRIOR_YR5_MTH2;

		private DataColumn columnPRIOR_YR5_MTH3;

		private DataColumn columnPRIOR_YR5_MTH4;

		private DataColumn columnPRIOR_YR5_MTH5;

		private DataColumn columnPRIOR_YR5_MTH6;

		private DataColumn columnPRIOR_YR5_MTH7;

		private DataColumn columnPRIOR_YR5_MTH8;

		private DataColumn columnPRIOR_YR5_MTH9;

		private DataColumn columnPRIOR_YR5_MTH10;

		private DataColumn columnPRIOR_YR5_MTH11;

		private DataColumn columnPRIOR_YR5_MTH12;

		private DataColumn columnBUDGET_MTH1;

		private DataColumn columnBUDGET_MTH2;

		private DataColumn columnBUDGET_MTH3;

		private DataColumn columnBUDGET_MTH4;

		private DataColumn columnBUDGET_MTH5;

		private DataColumn columnBUDGET_MTH6;

		private DataColumn columnBUDGET_MTH7;

		private DataColumn columnBUDGET_MTH8;

		private DataColumn columnBUDGET_MTH9;

		private DataColumn columnBUDGET_MTH10;

		private DataColumn columnBUDGET_MTH11;

		private DataColumn columnBUDGET_MTH12;

		private DataColumn columnBALANCE_BF;

		private DataColumn columnBALANCE_MTH1;

		private DataColumn columnBALANCE_MTH2;

		private DataColumn columnBALANCE_MTH3;

		private DataColumn columnBALANCE_MTH4;

		private DataColumn columnBALANCE_MTH5;

		private DataColumn columnBALANCE_MTH6;

		private DataColumn columnBALANCE_MTH7;

		private DataColumn columnBALANCE_MTH8;

		private DataColumn columnBALANCE_MTH9;

		private DataColumn columnBALANCE_MTH10;

		private DataColumn columnBALANCE_MTH11;

		private DataColumn columnBALANCE_MTH12;

		private DataColumn columnBALANCE_FUTURE;

		private DataColumn columnDEBIT_BF;

		private DataColumn columnDEBIT_MTH1;

		private DataColumn columnDEBIT_MTH2;

		private DataColumn columnDEBIT_MTH3;

		private DataColumn columnDEBIT_MTH4;

		private DataColumn columnDEBIT_MTH5;

		private DataColumn columnDEBIT_MTH6;

		private DataColumn columnDEBIT_MTH7;

		private DataColumn columnDEBIT_MTH8;

		private DataColumn columnDEBIT_MTH9;

		private DataColumn columnDEBIT_MTH10;

		private DataColumn columnDEBIT_MTH11;

		private DataColumn columnDEBIT_MTH12;

		private DataColumn columnDEBIT_FUTURE;

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

		private DataColumn columnCREDIT_FUTURE;

		private DataColumn columnRECORD_CREATE_DATE;

		private DataColumn columnRECORD_MODIFY_DATE;

		private DataColumn columnRECORD_DELETED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_REFColumn => columnACCOUNT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NAMEColumn => columnNAME;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_TYPEColumn => columnACCOUNT_TYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCEColumn => columnBALANCE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn QUICK_RATIOColumn => columnQUICK_RATIO;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SOFA_IDColumn => columnSOFA_ID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH1Column => columnPRIOR_YR_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH2Column => columnPRIOR_YR_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH3Column => columnPRIOR_YR_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH4Column => columnPRIOR_YR_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH5Column => columnPRIOR_YR_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH6Column => columnPRIOR_YR_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH7Column => columnPRIOR_YR_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH8Column => columnPRIOR_YR_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH9Column => columnPRIOR_YR_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH10Column => columnPRIOR_YR_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH11Column => columnPRIOR_YR_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR_MTH12Column => columnPRIOR_YR_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH1Column => columnPRIOR_YR2_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH2Column => columnPRIOR_YR2_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH3Column => columnPRIOR_YR2_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH4Column => columnPRIOR_YR2_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH5Column => columnPRIOR_YR2_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH6Column => columnPRIOR_YR2_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH7Column => columnPRIOR_YR2_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH8Column => columnPRIOR_YR2_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH9Column => columnPRIOR_YR2_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH10Column => columnPRIOR_YR2_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH11Column => columnPRIOR_YR2_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR2_MTH12Column => columnPRIOR_YR2_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH1Column => columnPRIOR_YR3_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH2Column => columnPRIOR_YR3_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH3Column => columnPRIOR_YR3_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH4Column => columnPRIOR_YR3_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH5Column => columnPRIOR_YR3_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH6Column => columnPRIOR_YR3_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH7Column => columnPRIOR_YR3_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH8Column => columnPRIOR_YR3_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH9Column => columnPRIOR_YR3_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH10Column => columnPRIOR_YR3_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH11Column => columnPRIOR_YR3_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR3_MTH12Column => columnPRIOR_YR3_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH1Column => columnPRIOR_YR4_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH2Column => columnPRIOR_YR4_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH3Column => columnPRIOR_YR4_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH4Column => columnPRIOR_YR4_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH5Column => columnPRIOR_YR4_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH6Column => columnPRIOR_YR4_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH7Column => columnPRIOR_YR4_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH8Column => columnPRIOR_YR4_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH9Column => columnPRIOR_YR4_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH10Column => columnPRIOR_YR4_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH11Column => columnPRIOR_YR4_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR4_MTH12Column => columnPRIOR_YR4_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH1Column => columnPRIOR_YR5_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH2Column => columnPRIOR_YR5_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH3Column => columnPRIOR_YR5_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH4Column => columnPRIOR_YR5_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH5Column => columnPRIOR_YR5_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH6Column => columnPRIOR_YR5_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH7Column => columnPRIOR_YR5_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH8Column => columnPRIOR_YR5_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH9Column => columnPRIOR_YR5_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH10Column => columnPRIOR_YR5_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH11Column => columnPRIOR_YR5_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PRIOR_YR5_MTH12Column => columnPRIOR_YR5_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH1Column => columnBUDGET_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH2Column => columnBUDGET_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH3Column => columnBUDGET_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH4Column => columnBUDGET_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH5Column => columnBUDGET_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH6Column => columnBUDGET_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH7Column => columnBUDGET_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH8Column => columnBUDGET_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH9Column => columnBUDGET_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH10Column => columnBUDGET_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH11Column => columnBUDGET_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BUDGET_MTH12Column => columnBUDGET_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_BFColumn => columnBALANCE_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH1Column => columnBALANCE_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH2Column => columnBALANCE_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH3Column => columnBALANCE_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH4Column => columnBALANCE_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH5Column => columnBALANCE_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH6Column => columnBALANCE_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH7Column => columnBALANCE_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH8Column => columnBALANCE_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH9Column => columnBALANCE_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH10Column => columnBALANCE_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH11Column => columnBALANCE_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_MTH12Column => columnBALANCE_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BALANCE_FUTUREColumn => columnBALANCE_FUTURE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_BFColumn => columnDEBIT_BF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH1Column => columnDEBIT_MTH1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH2Column => columnDEBIT_MTH2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH3Column => columnDEBIT_MTH3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH4Column => columnDEBIT_MTH4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH5Column => columnDEBIT_MTH5;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH6Column => columnDEBIT_MTH6;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH7Column => columnDEBIT_MTH7;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH8Column => columnDEBIT_MTH8;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH9Column => columnDEBIT_MTH9;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH10Column => columnDEBIT_MTH10;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH11Column => columnDEBIT_MTH11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_MTH12Column => columnDEBIT_MTH12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBIT_FUTUREColumn => columnDEBIT_FUTURE;

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
		public DataColumn CREDIT_FUTUREColumn => columnCREDIT_FUTURE;

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
		public NominalAccountsListRow this[int index] => (NominalAccountsListRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalAccountsListRowChangeEventHandler NominalAccountsListRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalAccountsListRowChangeEventHandler NominalAccountsListRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalAccountsListRowChangeEventHandler NominalAccountsListRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalAccountsListRowChangeEventHandler NominalAccountsListRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalAccountsListDataTable()
		{
			base.TableName = "NominalAccountsList";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal NominalAccountsListDataTable(DataTable table)
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
		protected NominalAccountsListDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddNominalAccountsListRow(NominalAccountsListRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalAccountsListRow AddNominalAccountsListRow(string ACCOUNT_REF, string NAME, short ACCOUNT_TYPE, double BALANCE, short QUICK_RATIO, int SOFA_ID, double PRIOR_YR_MTH1, double PRIOR_YR_MTH2, double PRIOR_YR_MTH3, double PRIOR_YR_MTH4, double PRIOR_YR_MTH5, double PRIOR_YR_MTH6, double PRIOR_YR_MTH7, double PRIOR_YR_MTH8, double PRIOR_YR_MTH9, double PRIOR_YR_MTH10, double PRIOR_YR_MTH11, double PRIOR_YR_MTH12, double PRIOR_YR2_MTH1, double PRIOR_YR2_MTH2, double PRIOR_YR2_MTH3, double PRIOR_YR2_MTH4, double PRIOR_YR2_MTH5, double PRIOR_YR2_MTH6, double PRIOR_YR2_MTH7, double PRIOR_YR2_MTH8, double PRIOR_YR2_MTH9, double PRIOR_YR2_MTH10, double PRIOR_YR2_MTH11, double PRIOR_YR2_MTH12, double PRIOR_YR3_MTH1, double PRIOR_YR3_MTH2, double PRIOR_YR3_MTH3, double PRIOR_YR3_MTH4, double PRIOR_YR3_MTH5, double PRIOR_YR3_MTH6, double PRIOR_YR3_MTH7, double PRIOR_YR3_MTH8, double PRIOR_YR3_MTH9, double PRIOR_YR3_MTH10, double PRIOR_YR3_MTH11, double PRIOR_YR3_MTH12, double PRIOR_YR4_MTH1, double PRIOR_YR4_MTH2, double PRIOR_YR4_MTH3, double PRIOR_YR4_MTH4, double PRIOR_YR4_MTH5, double PRIOR_YR4_MTH6, double PRIOR_YR4_MTH7, double PRIOR_YR4_MTH8, double PRIOR_YR4_MTH9, double PRIOR_YR4_MTH10, double PRIOR_YR4_MTH11, double PRIOR_YR4_MTH12, double PRIOR_YR5_MTH1, double PRIOR_YR5_MTH2, double PRIOR_YR5_MTH3, double PRIOR_YR5_MTH4, double PRIOR_YR5_MTH5, double PRIOR_YR5_MTH6, double PRIOR_YR5_MTH7, double PRIOR_YR5_MTH8, double PRIOR_YR5_MTH9, double PRIOR_YR5_MTH10, double PRIOR_YR5_MTH11, double PRIOR_YR5_MTH12, double BUDGET_MTH1, double BUDGET_MTH2, double BUDGET_MTH3, double BUDGET_MTH4, double BUDGET_MTH5, double BUDGET_MTH6, double BUDGET_MTH7, double BUDGET_MTH8, double BUDGET_MTH9, double BUDGET_MTH10, double BUDGET_MTH11, double BUDGET_MTH12, double BALANCE_BF, double BALANCE_MTH1, double BALANCE_MTH2, double BALANCE_MTH3, double BALANCE_MTH4, double BALANCE_MTH5, double BALANCE_MTH6, double BALANCE_MTH7, double BALANCE_MTH8, double BALANCE_MTH9, double BALANCE_MTH10, double BALANCE_MTH11, double BALANCE_MTH12, double BALANCE_FUTURE, double DEBIT_BF, double DEBIT_MTH1, double DEBIT_MTH2, double DEBIT_MTH3, double DEBIT_MTH4, double DEBIT_MTH5, double DEBIT_MTH6, double DEBIT_MTH7, double DEBIT_MTH8, double DEBIT_MTH9, double DEBIT_MTH10, double DEBIT_MTH11, double DEBIT_MTH12, double DEBIT_FUTURE, double CREDIT_BF, double CREDIT_MTH1, double CREDIT_MTH2, double CREDIT_MTH3, double CREDIT_MTH4, double CREDIT_MTH5, double CREDIT_MTH6, double CREDIT_MTH7, double CREDIT_MTH8, double CREDIT_MTH9, double CREDIT_MTH10, double CREDIT_MTH11, double CREDIT_MTH12, double CREDIT_FUTURE, DateTime RECORD_CREATE_DATE, DateTime RECORD_MODIFY_DATE, short RECORD_DELETED)
		{
			NominalAccountsListRow nominalAccountsListRow = (NominalAccountsListRow)NewRow();
			object[] itemArray = new object[123]
			{
				ACCOUNT_REF, NAME, ACCOUNT_TYPE, BALANCE, QUICK_RATIO, SOFA_ID, PRIOR_YR_MTH1, PRIOR_YR_MTH2, PRIOR_YR_MTH3, PRIOR_YR_MTH4,
				PRIOR_YR_MTH5, PRIOR_YR_MTH6, PRIOR_YR_MTH7, PRIOR_YR_MTH8, PRIOR_YR_MTH9, PRIOR_YR_MTH10, PRIOR_YR_MTH11, PRIOR_YR_MTH12, PRIOR_YR2_MTH1, PRIOR_YR2_MTH2,
				PRIOR_YR2_MTH3, PRIOR_YR2_MTH4, PRIOR_YR2_MTH5, PRIOR_YR2_MTH6, PRIOR_YR2_MTH7, PRIOR_YR2_MTH8, PRIOR_YR2_MTH9, PRIOR_YR2_MTH10, PRIOR_YR2_MTH11, PRIOR_YR2_MTH12,
				PRIOR_YR3_MTH1, PRIOR_YR3_MTH2, PRIOR_YR3_MTH3, PRIOR_YR3_MTH4, PRIOR_YR3_MTH5, PRIOR_YR3_MTH6, PRIOR_YR3_MTH7, PRIOR_YR3_MTH8, PRIOR_YR3_MTH9, PRIOR_YR3_MTH10,
				PRIOR_YR3_MTH11, PRIOR_YR3_MTH12, PRIOR_YR4_MTH1, PRIOR_YR4_MTH2, PRIOR_YR4_MTH3, PRIOR_YR4_MTH4, PRIOR_YR4_MTH5, PRIOR_YR4_MTH6, PRIOR_YR4_MTH7, PRIOR_YR4_MTH8,
				PRIOR_YR4_MTH9, PRIOR_YR4_MTH10, PRIOR_YR4_MTH11, PRIOR_YR4_MTH12, PRIOR_YR5_MTH1, PRIOR_YR5_MTH2, PRIOR_YR5_MTH3, PRIOR_YR5_MTH4, PRIOR_YR5_MTH5, PRIOR_YR5_MTH6,
				PRIOR_YR5_MTH7, PRIOR_YR5_MTH8, PRIOR_YR5_MTH9, PRIOR_YR5_MTH10, PRIOR_YR5_MTH11, PRIOR_YR5_MTH12, BUDGET_MTH1, BUDGET_MTH2, BUDGET_MTH3, BUDGET_MTH4,
				BUDGET_MTH5, BUDGET_MTH6, BUDGET_MTH7, BUDGET_MTH8, BUDGET_MTH9, BUDGET_MTH10, BUDGET_MTH11, BUDGET_MTH12, BALANCE_BF, BALANCE_MTH1,
				BALANCE_MTH2, BALANCE_MTH3, BALANCE_MTH4, BALANCE_MTH5, BALANCE_MTH6, BALANCE_MTH7, BALANCE_MTH8, BALANCE_MTH9, BALANCE_MTH10, BALANCE_MTH11,
				BALANCE_MTH12, BALANCE_FUTURE, DEBIT_BF, DEBIT_MTH1, DEBIT_MTH2, DEBIT_MTH3, DEBIT_MTH4, DEBIT_MTH5, DEBIT_MTH6, DEBIT_MTH7,
				DEBIT_MTH8, DEBIT_MTH9, DEBIT_MTH10, DEBIT_MTH11, DEBIT_MTH12, DEBIT_FUTURE, CREDIT_BF, CREDIT_MTH1, CREDIT_MTH2, CREDIT_MTH3,
				CREDIT_MTH4, CREDIT_MTH5, CREDIT_MTH6, CREDIT_MTH7, CREDIT_MTH8, CREDIT_MTH9, CREDIT_MTH10, CREDIT_MTH11, CREDIT_MTH12, CREDIT_FUTURE,
				RECORD_CREATE_DATE, RECORD_MODIFY_DATE, RECORD_DELETED
			};
			nominalAccountsListRow.ItemArray = itemArray;
			base.Rows.Add(nominalAccountsListRow);
			return nominalAccountsListRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			NominalAccountsListDataTable obj = (NominalAccountsListDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new NominalAccountsListDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnACCOUNT_REF = base.Columns["ACCOUNT_REF"];
			columnNAME = base.Columns["NAME"];
			columnACCOUNT_TYPE = base.Columns["ACCOUNT_TYPE"];
			columnBALANCE = base.Columns["BALANCE"];
			columnQUICK_RATIO = base.Columns["QUICK_RATIO"];
			columnSOFA_ID = base.Columns["SOFA_ID"];
			columnPRIOR_YR_MTH1 = base.Columns["PRIOR_YR_MTH1"];
			columnPRIOR_YR_MTH2 = base.Columns["PRIOR_YR_MTH2"];
			columnPRIOR_YR_MTH3 = base.Columns["PRIOR_YR_MTH3"];
			columnPRIOR_YR_MTH4 = base.Columns["PRIOR_YR_MTH4"];
			columnPRIOR_YR_MTH5 = base.Columns["PRIOR_YR_MTH5"];
			columnPRIOR_YR_MTH6 = base.Columns["PRIOR_YR_MTH6"];
			columnPRIOR_YR_MTH7 = base.Columns["PRIOR_YR_MTH7"];
			columnPRIOR_YR_MTH8 = base.Columns["PRIOR_YR_MTH8"];
			columnPRIOR_YR_MTH9 = base.Columns["PRIOR_YR_MTH9"];
			columnPRIOR_YR_MTH10 = base.Columns["PRIOR_YR_MTH10"];
			columnPRIOR_YR_MTH11 = base.Columns["PRIOR_YR_MTH11"];
			columnPRIOR_YR_MTH12 = base.Columns["PRIOR_YR_MTH12"];
			columnPRIOR_YR2_MTH1 = base.Columns["PRIOR_YR2_MTH1"];
			columnPRIOR_YR2_MTH2 = base.Columns["PRIOR_YR2_MTH2"];
			columnPRIOR_YR2_MTH3 = base.Columns["PRIOR_YR2_MTH3"];
			columnPRIOR_YR2_MTH4 = base.Columns["PRIOR_YR2_MTH4"];
			columnPRIOR_YR2_MTH5 = base.Columns["PRIOR_YR2_MTH5"];
			columnPRIOR_YR2_MTH6 = base.Columns["PRIOR_YR2_MTH6"];
			columnPRIOR_YR2_MTH7 = base.Columns["PRIOR_YR2_MTH7"];
			columnPRIOR_YR2_MTH8 = base.Columns["PRIOR_YR2_MTH8"];
			columnPRIOR_YR2_MTH9 = base.Columns["PRIOR_YR2_MTH9"];
			columnPRIOR_YR2_MTH10 = base.Columns["PRIOR_YR2_MTH10"];
			columnPRIOR_YR2_MTH11 = base.Columns["PRIOR_YR2_MTH11"];
			columnPRIOR_YR2_MTH12 = base.Columns["PRIOR_YR2_MTH12"];
			columnPRIOR_YR3_MTH1 = base.Columns["PRIOR_YR3_MTH1"];
			columnPRIOR_YR3_MTH2 = base.Columns["PRIOR_YR3_MTH2"];
			columnPRIOR_YR3_MTH3 = base.Columns["PRIOR_YR3_MTH3"];
			columnPRIOR_YR3_MTH4 = base.Columns["PRIOR_YR3_MTH4"];
			columnPRIOR_YR3_MTH5 = base.Columns["PRIOR_YR3_MTH5"];
			columnPRIOR_YR3_MTH6 = base.Columns["PRIOR_YR3_MTH6"];
			columnPRIOR_YR3_MTH7 = base.Columns["PRIOR_YR3_MTH7"];
			columnPRIOR_YR3_MTH8 = base.Columns["PRIOR_YR3_MTH8"];
			columnPRIOR_YR3_MTH9 = base.Columns["PRIOR_YR3_MTH9"];
			columnPRIOR_YR3_MTH10 = base.Columns["PRIOR_YR3_MTH10"];
			columnPRIOR_YR3_MTH11 = base.Columns["PRIOR_YR3_MTH11"];
			columnPRIOR_YR3_MTH12 = base.Columns["PRIOR_YR3_MTH12"];
			columnPRIOR_YR4_MTH1 = base.Columns["PRIOR_YR4_MTH1"];
			columnPRIOR_YR4_MTH2 = base.Columns["PRIOR_YR4_MTH2"];
			columnPRIOR_YR4_MTH3 = base.Columns["PRIOR_YR4_MTH3"];
			columnPRIOR_YR4_MTH4 = base.Columns["PRIOR_YR4_MTH4"];
			columnPRIOR_YR4_MTH5 = base.Columns["PRIOR_YR4_MTH5"];
			columnPRIOR_YR4_MTH6 = base.Columns["PRIOR_YR4_MTH6"];
			columnPRIOR_YR4_MTH7 = base.Columns["PRIOR_YR4_MTH7"];
			columnPRIOR_YR4_MTH8 = base.Columns["PRIOR_YR4_MTH8"];
			columnPRIOR_YR4_MTH9 = base.Columns["PRIOR_YR4_MTH9"];
			columnPRIOR_YR4_MTH10 = base.Columns["PRIOR_YR4_MTH10"];
			columnPRIOR_YR4_MTH11 = base.Columns["PRIOR_YR4_MTH11"];
			columnPRIOR_YR4_MTH12 = base.Columns["PRIOR_YR4_MTH12"];
			columnPRIOR_YR5_MTH1 = base.Columns["PRIOR_YR5_MTH1"];
			columnPRIOR_YR5_MTH2 = base.Columns["PRIOR_YR5_MTH2"];
			columnPRIOR_YR5_MTH3 = base.Columns["PRIOR_YR5_MTH3"];
			columnPRIOR_YR5_MTH4 = base.Columns["PRIOR_YR5_MTH4"];
			columnPRIOR_YR5_MTH5 = base.Columns["PRIOR_YR5_MTH5"];
			columnPRIOR_YR5_MTH6 = base.Columns["PRIOR_YR5_MTH6"];
			columnPRIOR_YR5_MTH7 = base.Columns["PRIOR_YR5_MTH7"];
			columnPRIOR_YR5_MTH8 = base.Columns["PRIOR_YR5_MTH8"];
			columnPRIOR_YR5_MTH9 = base.Columns["PRIOR_YR5_MTH9"];
			columnPRIOR_YR5_MTH10 = base.Columns["PRIOR_YR5_MTH10"];
			columnPRIOR_YR5_MTH11 = base.Columns["PRIOR_YR5_MTH11"];
			columnPRIOR_YR5_MTH12 = base.Columns["PRIOR_YR5_MTH12"];
			columnBUDGET_MTH1 = base.Columns["BUDGET_MTH1"];
			columnBUDGET_MTH2 = base.Columns["BUDGET_MTH2"];
			columnBUDGET_MTH3 = base.Columns["BUDGET_MTH3"];
			columnBUDGET_MTH4 = base.Columns["BUDGET_MTH4"];
			columnBUDGET_MTH5 = base.Columns["BUDGET_MTH5"];
			columnBUDGET_MTH6 = base.Columns["BUDGET_MTH6"];
			columnBUDGET_MTH7 = base.Columns["BUDGET_MTH7"];
			columnBUDGET_MTH8 = base.Columns["BUDGET_MTH8"];
			columnBUDGET_MTH9 = base.Columns["BUDGET_MTH9"];
			columnBUDGET_MTH10 = base.Columns["BUDGET_MTH10"];
			columnBUDGET_MTH11 = base.Columns["BUDGET_MTH11"];
			columnBUDGET_MTH12 = base.Columns["BUDGET_MTH12"];
			columnBALANCE_BF = base.Columns["BALANCE_BF"];
			columnBALANCE_MTH1 = base.Columns["BALANCE_MTH1"];
			columnBALANCE_MTH2 = base.Columns["BALANCE_MTH2"];
			columnBALANCE_MTH3 = base.Columns["BALANCE_MTH3"];
			columnBALANCE_MTH4 = base.Columns["BALANCE_MTH4"];
			columnBALANCE_MTH5 = base.Columns["BALANCE_MTH5"];
			columnBALANCE_MTH6 = base.Columns["BALANCE_MTH6"];
			columnBALANCE_MTH7 = base.Columns["BALANCE_MTH7"];
			columnBALANCE_MTH8 = base.Columns["BALANCE_MTH8"];
			columnBALANCE_MTH9 = base.Columns["BALANCE_MTH9"];
			columnBALANCE_MTH10 = base.Columns["BALANCE_MTH10"];
			columnBALANCE_MTH11 = base.Columns["BALANCE_MTH11"];
			columnBALANCE_MTH12 = base.Columns["BALANCE_MTH12"];
			columnBALANCE_FUTURE = base.Columns["BALANCE_FUTURE"];
			columnDEBIT_BF = base.Columns["DEBIT_BF"];
			columnDEBIT_MTH1 = base.Columns["DEBIT_MTH1"];
			columnDEBIT_MTH2 = base.Columns["DEBIT_MTH2"];
			columnDEBIT_MTH3 = base.Columns["DEBIT_MTH3"];
			columnDEBIT_MTH4 = base.Columns["DEBIT_MTH4"];
			columnDEBIT_MTH5 = base.Columns["DEBIT_MTH5"];
			columnDEBIT_MTH6 = base.Columns["DEBIT_MTH6"];
			columnDEBIT_MTH7 = base.Columns["DEBIT_MTH7"];
			columnDEBIT_MTH8 = base.Columns["DEBIT_MTH8"];
			columnDEBIT_MTH9 = base.Columns["DEBIT_MTH9"];
			columnDEBIT_MTH10 = base.Columns["DEBIT_MTH10"];
			columnDEBIT_MTH11 = base.Columns["DEBIT_MTH11"];
			columnDEBIT_MTH12 = base.Columns["DEBIT_MTH12"];
			columnDEBIT_FUTURE = base.Columns["DEBIT_FUTURE"];
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
			columnCREDIT_FUTURE = base.Columns["CREDIT_FUTURE"];
			columnRECORD_CREATE_DATE = base.Columns["RECORD_CREATE_DATE"];
			columnRECORD_MODIFY_DATE = base.Columns["RECORD_MODIFY_DATE"];
			columnRECORD_DELETED = base.Columns["RECORD_DELETED"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnACCOUNT_REF = new DataColumn("ACCOUNT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_REF);
			columnNAME = new DataColumn("NAME", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNAME);
			columnACCOUNT_TYPE = new DataColumn("ACCOUNT_TYPE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_TYPE);
			columnBALANCE = new DataColumn("BALANCE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE);
			columnQUICK_RATIO = new DataColumn("QUICK_RATIO", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnQUICK_RATIO);
			columnSOFA_ID = new DataColumn("SOFA_ID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSOFA_ID);
			columnPRIOR_YR_MTH1 = new DataColumn("PRIOR_YR_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH1);
			columnPRIOR_YR_MTH2 = new DataColumn("PRIOR_YR_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH2);
			columnPRIOR_YR_MTH3 = new DataColumn("PRIOR_YR_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH3);
			columnPRIOR_YR_MTH4 = new DataColumn("PRIOR_YR_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH4);
			columnPRIOR_YR_MTH5 = new DataColumn("PRIOR_YR_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH5);
			columnPRIOR_YR_MTH6 = new DataColumn("PRIOR_YR_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH6);
			columnPRIOR_YR_MTH7 = new DataColumn("PRIOR_YR_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH7);
			columnPRIOR_YR_MTH8 = new DataColumn("PRIOR_YR_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH8);
			columnPRIOR_YR_MTH9 = new DataColumn("PRIOR_YR_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH9);
			columnPRIOR_YR_MTH10 = new DataColumn("PRIOR_YR_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH10);
			columnPRIOR_YR_MTH11 = new DataColumn("PRIOR_YR_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH11);
			columnPRIOR_YR_MTH12 = new DataColumn("PRIOR_YR_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR_MTH12);
			columnPRIOR_YR2_MTH1 = new DataColumn("PRIOR_YR2_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH1);
			columnPRIOR_YR2_MTH2 = new DataColumn("PRIOR_YR2_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH2);
			columnPRIOR_YR2_MTH3 = new DataColumn("PRIOR_YR2_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH3);
			columnPRIOR_YR2_MTH4 = new DataColumn("PRIOR_YR2_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH4);
			columnPRIOR_YR2_MTH5 = new DataColumn("PRIOR_YR2_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH5);
			columnPRIOR_YR2_MTH6 = new DataColumn("PRIOR_YR2_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH6);
			columnPRIOR_YR2_MTH7 = new DataColumn("PRIOR_YR2_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH7);
			columnPRIOR_YR2_MTH8 = new DataColumn("PRIOR_YR2_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH8);
			columnPRIOR_YR2_MTH9 = new DataColumn("PRIOR_YR2_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH9);
			columnPRIOR_YR2_MTH10 = new DataColumn("PRIOR_YR2_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH10);
			columnPRIOR_YR2_MTH11 = new DataColumn("PRIOR_YR2_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH11);
			columnPRIOR_YR2_MTH12 = new DataColumn("PRIOR_YR2_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR2_MTH12);
			columnPRIOR_YR3_MTH1 = new DataColumn("PRIOR_YR3_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH1);
			columnPRIOR_YR3_MTH2 = new DataColumn("PRIOR_YR3_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH2);
			columnPRIOR_YR3_MTH3 = new DataColumn("PRIOR_YR3_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH3);
			columnPRIOR_YR3_MTH4 = new DataColumn("PRIOR_YR3_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH4);
			columnPRIOR_YR3_MTH5 = new DataColumn("PRIOR_YR3_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH5);
			columnPRIOR_YR3_MTH6 = new DataColumn("PRIOR_YR3_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH6);
			columnPRIOR_YR3_MTH7 = new DataColumn("PRIOR_YR3_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH7);
			columnPRIOR_YR3_MTH8 = new DataColumn("PRIOR_YR3_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH8);
			columnPRIOR_YR3_MTH9 = new DataColumn("PRIOR_YR3_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH9);
			columnPRIOR_YR3_MTH10 = new DataColumn("PRIOR_YR3_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH10);
			columnPRIOR_YR3_MTH11 = new DataColumn("PRIOR_YR3_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH11);
			columnPRIOR_YR3_MTH12 = new DataColumn("PRIOR_YR3_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR3_MTH12);
			columnPRIOR_YR4_MTH1 = new DataColumn("PRIOR_YR4_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH1);
			columnPRIOR_YR4_MTH2 = new DataColumn("PRIOR_YR4_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH2);
			columnPRIOR_YR4_MTH3 = new DataColumn("PRIOR_YR4_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH3);
			columnPRIOR_YR4_MTH4 = new DataColumn("PRIOR_YR4_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH4);
			columnPRIOR_YR4_MTH5 = new DataColumn("PRIOR_YR4_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH5);
			columnPRIOR_YR4_MTH6 = new DataColumn("PRIOR_YR4_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH6);
			columnPRIOR_YR4_MTH7 = new DataColumn("PRIOR_YR4_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH7);
			columnPRIOR_YR4_MTH8 = new DataColumn("PRIOR_YR4_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH8);
			columnPRIOR_YR4_MTH9 = new DataColumn("PRIOR_YR4_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH9);
			columnPRIOR_YR4_MTH10 = new DataColumn("PRIOR_YR4_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH10);
			columnPRIOR_YR4_MTH11 = new DataColumn("PRIOR_YR4_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH11);
			columnPRIOR_YR4_MTH12 = new DataColumn("PRIOR_YR4_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR4_MTH12);
			columnPRIOR_YR5_MTH1 = new DataColumn("PRIOR_YR5_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH1);
			columnPRIOR_YR5_MTH2 = new DataColumn("PRIOR_YR5_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH2);
			columnPRIOR_YR5_MTH3 = new DataColumn("PRIOR_YR5_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH3);
			columnPRIOR_YR5_MTH4 = new DataColumn("PRIOR_YR5_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH4);
			columnPRIOR_YR5_MTH5 = new DataColumn("PRIOR_YR5_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH5);
			columnPRIOR_YR5_MTH6 = new DataColumn("PRIOR_YR5_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH6);
			columnPRIOR_YR5_MTH7 = new DataColumn("PRIOR_YR5_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH7);
			columnPRIOR_YR5_MTH8 = new DataColumn("PRIOR_YR5_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH8);
			columnPRIOR_YR5_MTH9 = new DataColumn("PRIOR_YR5_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH9);
			columnPRIOR_YR5_MTH10 = new DataColumn("PRIOR_YR5_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH10);
			columnPRIOR_YR5_MTH11 = new DataColumn("PRIOR_YR5_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH11);
			columnPRIOR_YR5_MTH12 = new DataColumn("PRIOR_YR5_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnPRIOR_YR5_MTH12);
			columnBUDGET_MTH1 = new DataColumn("BUDGET_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH1);
			columnBUDGET_MTH2 = new DataColumn("BUDGET_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH2);
			columnBUDGET_MTH3 = new DataColumn("BUDGET_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH3);
			columnBUDGET_MTH4 = new DataColumn("BUDGET_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH4);
			columnBUDGET_MTH5 = new DataColumn("BUDGET_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH5);
			columnBUDGET_MTH6 = new DataColumn("BUDGET_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH6);
			columnBUDGET_MTH7 = new DataColumn("BUDGET_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH7);
			columnBUDGET_MTH8 = new DataColumn("BUDGET_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH8);
			columnBUDGET_MTH9 = new DataColumn("BUDGET_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH9);
			columnBUDGET_MTH10 = new DataColumn("BUDGET_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH10);
			columnBUDGET_MTH11 = new DataColumn("BUDGET_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH11);
			columnBUDGET_MTH12 = new DataColumn("BUDGET_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBUDGET_MTH12);
			columnBALANCE_BF = new DataColumn("BALANCE_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_BF);
			columnBALANCE_MTH1 = new DataColumn("BALANCE_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH1);
			columnBALANCE_MTH2 = new DataColumn("BALANCE_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH2);
			columnBALANCE_MTH3 = new DataColumn("BALANCE_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH3);
			columnBALANCE_MTH4 = new DataColumn("BALANCE_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH4);
			columnBALANCE_MTH5 = new DataColumn("BALANCE_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH5);
			columnBALANCE_MTH6 = new DataColumn("BALANCE_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH6);
			columnBALANCE_MTH7 = new DataColumn("BALANCE_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH7);
			columnBALANCE_MTH8 = new DataColumn("BALANCE_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH8);
			columnBALANCE_MTH9 = new DataColumn("BALANCE_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH9);
			columnBALANCE_MTH10 = new DataColumn("BALANCE_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH10);
			columnBALANCE_MTH11 = new DataColumn("BALANCE_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH11);
			columnBALANCE_MTH12 = new DataColumn("BALANCE_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_MTH12);
			columnBALANCE_FUTURE = new DataColumn("BALANCE_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnBALANCE_FUTURE);
			columnDEBIT_BF = new DataColumn("DEBIT_BF", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_BF);
			columnDEBIT_MTH1 = new DataColumn("DEBIT_MTH1", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH1);
			columnDEBIT_MTH2 = new DataColumn("DEBIT_MTH2", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH2);
			columnDEBIT_MTH3 = new DataColumn("DEBIT_MTH3", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH3);
			columnDEBIT_MTH4 = new DataColumn("DEBIT_MTH4", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH4);
			columnDEBIT_MTH5 = new DataColumn("DEBIT_MTH5", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH5);
			columnDEBIT_MTH6 = new DataColumn("DEBIT_MTH6", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH6);
			columnDEBIT_MTH7 = new DataColumn("DEBIT_MTH7", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH7);
			columnDEBIT_MTH8 = new DataColumn("DEBIT_MTH8", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH8);
			columnDEBIT_MTH9 = new DataColumn("DEBIT_MTH9", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH9);
			columnDEBIT_MTH10 = new DataColumn("DEBIT_MTH10", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH10);
			columnDEBIT_MTH11 = new DataColumn("DEBIT_MTH11", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH11);
			columnDEBIT_MTH12 = new DataColumn("DEBIT_MTH12", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_MTH12);
			columnDEBIT_FUTURE = new DataColumn("DEBIT_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnDEBIT_FUTURE);
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
			columnCREDIT_FUTURE = new DataColumn("CREDIT_FUTURE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_FUTURE);
			columnRECORD_CREATE_DATE = new DataColumn("RECORD_CREATE_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_CREATE_DATE);
			columnRECORD_MODIFY_DATE = new DataColumn("RECORD_MODIFY_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnRECORD_MODIFY_DATE);
			columnRECORD_DELETED = new DataColumn("RECORD_DELETED", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRECORD_DELETED);
			columnACCOUNT_REF.MaxLength = 8;
			columnNAME.MaxLength = 60;
			columnACCOUNT_TYPE.AllowDBNull = false;
			columnQUICK_RATIO.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalAccountsListRow NewNominalAccountsListRow()
		{
			return (NominalAccountsListRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new NominalAccountsListRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(NominalAccountsListRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (NominalAccountsListRowChanged != null)
			{
				NominalAccountsListRowChanged?.Invoke(this, new NominalAccountsListRowChangeEvent((NominalAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (NominalAccountsListRowChanging != null)
			{
				NominalAccountsListRowChanging?.Invoke(this, new NominalAccountsListRowChangeEvent((NominalAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (NominalAccountsListRowDeleted != null)
			{
				NominalAccountsListRowDeleted?.Invoke(this, new NominalAccountsListRowChangeEvent((NominalAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (NominalAccountsListRowDeleting != null)
			{
				NominalAccountsListRowDeleting?.Invoke(this, new NominalAccountsListRowChangeEvent((NominalAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveNominalAccountsListRow(NominalAccountsListRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Nominal nominal = new Nominal();
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
			xmlSchemaAttribute.FixedValue = nominal.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "NominalAccountsListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = nominal.GetSchemaSerializable();
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
	public class NominalControlAccountsListDataTable : TypedTableBase<NominalControlAccountsListRow>
	{
		private DataColumn columnDEBTORS;

		private DataColumn columnVAT_SALES;

		private DataColumn columnCREDITORS;

		private DataColumn columnVAT_PURCHASE;

		private DataColumn columnDISCOUNT_SALES;

		private DataColumn columnDISCOUNT_PURCHASE;

		private DataColumn columnDEFAULT_BANK;

		private DataColumn columnDEFAULT_SALES;

		private DataColumn columnRETAINED_EARNINGS;

		private DataColumn columnCREDIT_CHARGES;

		private DataColumn columnBAD_DEBTS;

		private DataColumn columnACCRUALS;

		private DataColumn columnPREPAYMENTS;

		private DataColumn columnSUSPENSE;

		private DataColumn columnMISPOSTINGS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEBTORSColumn => columnDEBTORS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_SALESColumn => columnVAT_SALES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDITORSColumn => columnCREDITORS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_PURCHASEColumn => columnVAT_PURCHASE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISCOUNT_SALESColumn => columnDISCOUNT_SALES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DISCOUNT_PURCHASEColumn => columnDISCOUNT_PURCHASE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEFAULT_BANKColumn => columnDEFAULT_BANK;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DEFAULT_SALESColumn => columnDEFAULT_SALES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RETAINED_EARNINGSColumn => columnRETAINED_EARNINGS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn CREDIT_CHARGESColumn => columnCREDIT_CHARGES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BAD_DEBTSColumn => columnBAD_DEBTS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCRUALSColumn => columnACCRUALS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn PREPAYMENTSColumn => columnPREPAYMENTS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SUSPENSEColumn => columnSUSPENSE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MISPOSTINGSColumn => columnMISPOSTINGS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListRow this[int index] => (NominalControlAccountsListRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalControlAccountsListRowChangeEventHandler NominalControlAccountsListRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalControlAccountsListRowChangeEventHandler NominalControlAccountsListRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalControlAccountsListRowChangeEventHandler NominalControlAccountsListRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event NominalControlAccountsListRowChangeEventHandler NominalControlAccountsListRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListDataTable()
		{
			base.TableName = "NominalControlAccountsList";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal NominalControlAccountsListDataTable(DataTable table)
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
		protected NominalControlAccountsListDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddNominalControlAccountsListRow(NominalControlAccountsListRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListRow AddNominalControlAccountsListRow(string DEBTORS, string VAT_SALES, string CREDITORS, string VAT_PURCHASE, string DISCOUNT_SALES, string DISCOUNT_PURCHASE, string DEFAULT_BANK, string DEFAULT_SALES, string RETAINED_EARNINGS, string CREDIT_CHARGES, string BAD_DEBTS, string ACCRUALS, string PREPAYMENTS, string SUSPENSE, string MISPOSTINGS)
		{
			NominalControlAccountsListRow nominalControlAccountsListRow = (NominalControlAccountsListRow)NewRow();
			object[] itemArray = new object[15]
			{
				DEBTORS, VAT_SALES, CREDITORS, VAT_PURCHASE, DISCOUNT_SALES, DISCOUNT_PURCHASE, DEFAULT_BANK, DEFAULT_SALES, RETAINED_EARNINGS, CREDIT_CHARGES,
				BAD_DEBTS, ACCRUALS, PREPAYMENTS, SUSPENSE, MISPOSTINGS
			};
			nominalControlAccountsListRow.ItemArray = itemArray;
			base.Rows.Add(nominalControlAccountsListRow);
			return nominalControlAccountsListRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			NominalControlAccountsListDataTable obj = (NominalControlAccountsListDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new NominalControlAccountsListDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnDEBTORS = base.Columns["DEBTORS"];
			columnVAT_SALES = base.Columns["VAT_SALES"];
			columnCREDITORS = base.Columns["CREDITORS"];
			columnVAT_PURCHASE = base.Columns["VAT_PURCHASE"];
			columnDISCOUNT_SALES = base.Columns["DISCOUNT_SALES"];
			columnDISCOUNT_PURCHASE = base.Columns["DISCOUNT_PURCHASE"];
			columnDEFAULT_BANK = base.Columns["DEFAULT_BANK"];
			columnDEFAULT_SALES = base.Columns["DEFAULT_SALES"];
			columnRETAINED_EARNINGS = base.Columns["RETAINED_EARNINGS"];
			columnCREDIT_CHARGES = base.Columns["CREDIT_CHARGES"];
			columnBAD_DEBTS = base.Columns["BAD_DEBTS"];
			columnACCRUALS = base.Columns["ACCRUALS"];
			columnPREPAYMENTS = base.Columns["PREPAYMENTS"];
			columnSUSPENSE = base.Columns["SUSPENSE"];
			columnMISPOSTINGS = base.Columns["MISPOSTINGS"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnDEBTORS = new DataColumn("DEBTORS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEBTORS);
			columnVAT_SALES = new DataColumn("VAT_SALES", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVAT_SALES);
			columnCREDITORS = new DataColumn("CREDITORS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCREDITORS);
			columnVAT_PURCHASE = new DataColumn("VAT_PURCHASE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVAT_PURCHASE);
			columnDISCOUNT_SALES = new DataColumn("DISCOUNT_SALES", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDISCOUNT_SALES);
			columnDISCOUNT_PURCHASE = new DataColumn("DISCOUNT_PURCHASE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDISCOUNT_PURCHASE);
			columnDEFAULT_BANK = new DataColumn("DEFAULT_BANK", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEFAULT_BANK);
			columnDEFAULT_SALES = new DataColumn("DEFAULT_SALES", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDEFAULT_SALES);
			columnRETAINED_EARNINGS = new DataColumn("RETAINED_EARNINGS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnRETAINED_EARNINGS);
			columnCREDIT_CHARGES = new DataColumn("CREDIT_CHARGES", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCREDIT_CHARGES);
			columnBAD_DEBTS = new DataColumn("BAD_DEBTS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBAD_DEBTS);
			columnACCRUALS = new DataColumn("ACCRUALS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCRUALS);
			columnPREPAYMENTS = new DataColumn("PREPAYMENTS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnPREPAYMENTS);
			columnSUSPENSE = new DataColumn("SUSPENSE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSUSPENSE);
			columnMISPOSTINGS = new DataColumn("MISPOSTINGS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMISPOSTINGS);
			columnDEBTORS.MaxLength = 10;
			columnVAT_SALES.MaxLength = 10;
			columnCREDITORS.MaxLength = 10;
			columnVAT_PURCHASE.MaxLength = 10;
			columnDISCOUNT_SALES.MaxLength = 10;
			columnDISCOUNT_PURCHASE.MaxLength = 10;
			columnDEFAULT_BANK.MaxLength = 10;
			columnDEFAULT_SALES.MaxLength = 10;
			columnRETAINED_EARNINGS.MaxLength = 10;
			columnCREDIT_CHARGES.MaxLength = 10;
			columnBAD_DEBTS.MaxLength = 10;
			columnACCRUALS.MaxLength = 10;
			columnPREPAYMENTS.MaxLength = 10;
			columnSUSPENSE.MaxLength = 10;
			columnMISPOSTINGS.MaxLength = 10;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListRow NewNominalControlAccountsListRow()
		{
			return (NominalControlAccountsListRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new NominalControlAccountsListRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(NominalControlAccountsListRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (NominalControlAccountsListRowChanged != null)
			{
				NominalControlAccountsListRowChanged?.Invoke(this, new NominalControlAccountsListRowChangeEvent((NominalControlAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (NominalControlAccountsListRowChanging != null)
			{
				NominalControlAccountsListRowChanging?.Invoke(this, new NominalControlAccountsListRowChangeEvent((NominalControlAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (NominalControlAccountsListRowDeleted != null)
			{
				NominalControlAccountsListRowDeleted?.Invoke(this, new NominalControlAccountsListRowChangeEvent((NominalControlAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (NominalControlAccountsListRowDeleting != null)
			{
				NominalControlAccountsListRowDeleting?.Invoke(this, new NominalControlAccountsListRowChangeEvent((NominalControlAccountsListRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveNominalControlAccountsListRow(NominalControlAccountsListRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Nominal nominal = new Nominal();
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
			xmlSchemaAttribute.FixedValue = nominal.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "NominalControlAccountsListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = nominal.GetSchemaSerializable();
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
	public class NominalAccountsListRow : DataRow
	{
		private NominalAccountsListDataTable tableNominalAccountsList;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ACCOUNT_REF
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalAccountsList.ACCOUNT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCOUNT_REF' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.ACCOUNT_REFColumn] = value;
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
					return Conversions.ToString(base[tableNominalAccountsList.NAMEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NAME' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.NAMEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short ACCOUNT_TYPE
		{
			get
			{
				return Conversions.ToShort(base[tableNominalAccountsList.ACCOUNT_TYPEColumn]);
			}
			set
			{
				base[tableNominalAccountsList.ACCOUNT_TYPEColumn] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short QUICK_RATIO
		{
			get
			{
				return Conversions.ToShort(base[tableNominalAccountsList.QUICK_RATIOColumn]);
			}
			set
			{
				base[tableNominalAccountsList.QUICK_RATIOColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int SOFA_ID
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableNominalAccountsList.SOFA_IDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SOFA_ID' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.SOFA_IDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR2_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR2_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR2_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR2_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR3_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR3_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR3_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR3_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR4_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR4_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR4_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR4_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double PRIOR_YR5_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.PRIOR_YR5_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PRIOR_YR5_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.PRIOR_YR5_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BUDGET_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BUDGET_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BUDGET_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BUDGET_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_BF' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double BALANCE_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.BALANCE_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BALANCE_FUTURE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.BALANCE_FUTUREColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_BF
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_BF' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_BFColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH1
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH2
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH3
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH4
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH5
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH5Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH6
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH6Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH7
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH7Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH8
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH8Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH9
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH9Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH10
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH10Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH11
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_MTH12
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double DEBIT_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.DEBIT_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBIT_FUTURE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.DEBIT_FUTUREColumn] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_BFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_BF' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_BFColumn] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH1Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH1' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH1Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH2Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH2' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH2Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH3Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH3' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH3Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH4Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH4' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH4Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH5Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH5' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH5Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH6Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH6' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH6Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH7Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH7' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH7Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH8Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH8' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH8Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH9Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH9' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH9Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH10Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH10' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH10Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH11Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH11' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH11Column] = value;
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
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_MTH12Column]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_MTH12' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_MTH12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double CREDIT_FUTURE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableNominalAccountsList.CREDIT_FUTUREColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_FUTURE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.CREDIT_FUTUREColumn] = value;
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
					return Conversions.ToDate(base[tableNominalAccountsList.RECORD_CREATE_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_CREATE_DATE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.RECORD_CREATE_DATEColumn] = value;
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
					return Conversions.ToDate(base[tableNominalAccountsList.RECORD_MODIFY_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_MODIFY_DATE' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.RECORD_MODIFY_DATEColumn] = value;
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
					return Conversions.ToShort(base[tableNominalAccountsList.RECORD_DELETEDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RECORD_DELETED' in table 'NominalAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalAccountsList.RECORD_DELETEDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal NominalAccountsListRow(DataRowBuilder rb)
			: base(rb)
		{
			tableNominalAccountsList = (NominalAccountsListDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCOUNT_REFNull()
		{
			return IsNull(tableNominalAccountsList.ACCOUNT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCOUNT_REFNull()
		{
			base[tableNominalAccountsList.ACCOUNT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNAMENull()
		{
			return IsNull(tableNominalAccountsList.NAMEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNAMENull()
		{
			base[tableNominalAccountsList.NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCENull()
		{
			return IsNull(tableNominalAccountsList.BALANCEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCENull()
		{
			base[tableNominalAccountsList.BALANCEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSOFA_IDNull()
		{
			return IsNull(tableNominalAccountsList.SOFA_IDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSOFA_IDNull()
		{
			base[tableNominalAccountsList.SOFA_IDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH1Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH2Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH3Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH4Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH5Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH6Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH7Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH8Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH9Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH10Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH11Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR_MTH12Null()
		{
			base[tableNominalAccountsList.PRIOR_YR_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH1Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH2Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH3Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH4Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH5Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH6Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH7Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH8Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH9Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH10Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH11Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR2_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR2_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR2_MTH12Null()
		{
			base[tableNominalAccountsList.PRIOR_YR2_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH1Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH2Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH3Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH4Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH5Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH6Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH7Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH8Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH9Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH10Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH11Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR3_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR3_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR3_MTH12Null()
		{
			base[tableNominalAccountsList.PRIOR_YR3_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH1Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH2Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH3Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH4Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH5Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH6Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH7Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH8Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH9Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH10Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH11Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR4_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR4_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR4_MTH12Null()
		{
			base[tableNominalAccountsList.PRIOR_YR4_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH1Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH2Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH3Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH4Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH5Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH6Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH7Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH8Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH9Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH10Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH11Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPRIOR_YR5_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.PRIOR_YR5_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPRIOR_YR5_MTH12Null()
		{
			base[tableNominalAccountsList.PRIOR_YR5_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH1Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH2Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH3Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH4Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH5Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH6Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH7Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH8Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH9Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH10Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH11Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBUDGET_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.BUDGET_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBUDGET_MTH12Null()
		{
			base[tableNominalAccountsList.BUDGET_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_BFNull()
		{
			return IsNull(tableNominalAccountsList.BALANCE_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_BFNull()
		{
			base[tableNominalAccountsList.BALANCE_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH1Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH2Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH3Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH4Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH5Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH6Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH7Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH8Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH9Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH10Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH11Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.BALANCE_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_MTH12Null()
		{
			base[tableNominalAccountsList.BALANCE_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBALANCE_FUTURENull()
		{
			return IsNull(tableNominalAccountsList.BALANCE_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBALANCE_FUTURENull()
		{
			base[tableNominalAccountsList.BALANCE_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_BFNull()
		{
			return IsNull(tableNominalAccountsList.DEBIT_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_BFNull()
		{
			base[tableNominalAccountsList.DEBIT_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH1Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH2Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH3Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH4Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH5Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH6Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH7Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH8Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH9Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH10Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH11Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.DEBIT_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_MTH12Null()
		{
			base[tableNominalAccountsList.DEBIT_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBIT_FUTURENull()
		{
			return IsNull(tableNominalAccountsList.DEBIT_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBIT_FUTURENull()
		{
			base[tableNominalAccountsList.DEBIT_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_BFNull()
		{
			return IsNull(tableNominalAccountsList.CREDIT_BFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_BFNull()
		{
			base[tableNominalAccountsList.CREDIT_BFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH1Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH1Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH1Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH2Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH2Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH2Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH3Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH3Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH3Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH4Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH4Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH4Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH5Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH5Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH5Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH5Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH6Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH6Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH6Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH6Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH7Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH7Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH7Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH7Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH8Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH8Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH8Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH8Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH9Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH9Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH9Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH9Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH10Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH10Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH10Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH10Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH11Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH11Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH11Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_MTH12Null()
		{
			return IsNull(tableNominalAccountsList.CREDIT_MTH12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_MTH12Null()
		{
			base[tableNominalAccountsList.CREDIT_MTH12Column] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_FUTURENull()
		{
			return IsNull(tableNominalAccountsList.CREDIT_FUTUREColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_FUTURENull()
		{
			base[tableNominalAccountsList.CREDIT_FUTUREColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_CREATE_DATENull()
		{
			return IsNull(tableNominalAccountsList.RECORD_CREATE_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_CREATE_DATENull()
		{
			base[tableNominalAccountsList.RECORD_CREATE_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_MODIFY_DATENull()
		{
			return IsNull(tableNominalAccountsList.RECORD_MODIFY_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_MODIFY_DATENull()
		{
			base[tableNominalAccountsList.RECORD_MODIFY_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRECORD_DELETEDNull()
		{
			return IsNull(tableNominalAccountsList.RECORD_DELETEDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRECORD_DELETEDNull()
		{
			base[tableNominalAccountsList.RECORD_DELETEDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class NominalControlAccountsListRow : DataRow
	{
		private NominalControlAccountsListDataTable tableNominalControlAccountsList;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEBTORS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.DEBTORSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEBTORS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.DEBTORSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string VAT_SALES
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.VAT_SALESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_SALES' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.VAT_SALESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CREDITORS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.CREDITORSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDITORS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.CREDITORSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string VAT_PURCHASE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.VAT_PURCHASEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_PURCHASE' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.VAT_PURCHASEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DISCOUNT_SALES
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.DISCOUNT_SALESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISCOUNT_SALES' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.DISCOUNT_SALESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DISCOUNT_PURCHASE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.DISCOUNT_PURCHASEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DISCOUNT_PURCHASE' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.DISCOUNT_PURCHASEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEFAULT_BANK
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.DEFAULT_BANKColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEFAULT_BANK' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.DEFAULT_BANKColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DEFAULT_SALES
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.DEFAULT_SALESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DEFAULT_SALES' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.DEFAULT_SALESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string RETAINED_EARNINGS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.RETAINED_EARNINGSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RETAINED_EARNINGS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.RETAINED_EARNINGSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string CREDIT_CHARGES
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.CREDIT_CHARGESColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'CREDIT_CHARGES' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.CREDIT_CHARGESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BAD_DEBTS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.BAD_DEBTSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'BAD_DEBTS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.BAD_DEBTSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ACCRUALS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.ACCRUALSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCRUALS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.ACCRUALSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string PREPAYMENTS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.PREPAYMENTSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'PREPAYMENTS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.PREPAYMENTSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SUSPENSE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.SUSPENSEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SUSPENSE' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.SUSPENSEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string MISPOSTINGS
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableNominalControlAccountsList.MISPOSTINGSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'MISPOSTINGS' in table 'NominalControlAccountsList' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableNominalControlAccountsList.MISPOSTINGSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal NominalControlAccountsListRow(DataRowBuilder rb)
			: base(rb)
		{
			tableNominalControlAccountsList = (NominalControlAccountsListDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEBTORSNull()
		{
			return IsNull(tableNominalControlAccountsList.DEBTORSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEBTORSNull()
		{
			base[tableNominalControlAccountsList.DEBTORSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_SALESNull()
		{
			return IsNull(tableNominalControlAccountsList.VAT_SALESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_SALESNull()
		{
			base[tableNominalControlAccountsList.VAT_SALESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDITORSNull()
		{
			return IsNull(tableNominalControlAccountsList.CREDITORSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDITORSNull()
		{
			base[tableNominalControlAccountsList.CREDITORSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_PURCHASENull()
		{
			return IsNull(tableNominalControlAccountsList.VAT_PURCHASEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_PURCHASENull()
		{
			base[tableNominalControlAccountsList.VAT_PURCHASEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISCOUNT_SALESNull()
		{
			return IsNull(tableNominalControlAccountsList.DISCOUNT_SALESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISCOUNT_SALESNull()
		{
			base[tableNominalControlAccountsList.DISCOUNT_SALESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDISCOUNT_PURCHASENull()
		{
			return IsNull(tableNominalControlAccountsList.DISCOUNT_PURCHASEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDISCOUNT_PURCHASENull()
		{
			base[tableNominalControlAccountsList.DISCOUNT_PURCHASEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEFAULT_BANKNull()
		{
			return IsNull(tableNominalControlAccountsList.DEFAULT_BANKColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEFAULT_BANKNull()
		{
			base[tableNominalControlAccountsList.DEFAULT_BANKColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDEFAULT_SALESNull()
		{
			return IsNull(tableNominalControlAccountsList.DEFAULT_SALESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDEFAULT_SALESNull()
		{
			base[tableNominalControlAccountsList.DEFAULT_SALESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRETAINED_EARNINGSNull()
		{
			return IsNull(tableNominalControlAccountsList.RETAINED_EARNINGSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRETAINED_EARNINGSNull()
		{
			base[tableNominalControlAccountsList.RETAINED_EARNINGSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsCREDIT_CHARGESNull()
		{
			return IsNull(tableNominalControlAccountsList.CREDIT_CHARGESColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetCREDIT_CHARGESNull()
		{
			base[tableNominalControlAccountsList.CREDIT_CHARGESColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBAD_DEBTSNull()
		{
			return IsNull(tableNominalControlAccountsList.BAD_DEBTSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetBAD_DEBTSNull()
		{
			base[tableNominalControlAccountsList.BAD_DEBTSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCRUALSNull()
		{
			return IsNull(tableNominalControlAccountsList.ACCRUALSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCRUALSNull()
		{
			base[tableNominalControlAccountsList.ACCRUALSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsPREPAYMENTSNull()
		{
			return IsNull(tableNominalControlAccountsList.PREPAYMENTSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetPREPAYMENTSNull()
		{
			base[tableNominalControlAccountsList.PREPAYMENTSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSUSPENSENull()
		{
			return IsNull(tableNominalControlAccountsList.SUSPENSEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSUSPENSENull()
		{
			base[tableNominalControlAccountsList.SUSPENSEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMISPOSTINGSNull()
		{
			return IsNull(tableNominalControlAccountsList.MISPOSTINGSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMISPOSTINGSNull()
		{
			base[tableNominalControlAccountsList.MISPOSTINGSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class NominalAccountsListRowChangeEvent : EventArgs
	{
		private NominalAccountsListRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalAccountsListRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalAccountsListRowChangeEvent(NominalAccountsListRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class NominalControlAccountsListRowChangeEvent : EventArgs
	{
		private NominalControlAccountsListRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public NominalControlAccountsListRowChangeEvent(NominalControlAccountsListRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private NominalAccountsListDataTable tableNominalAccountsList;

	private NominalControlAccountsListDataTable tableNominalControlAccountsList;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public NominalAccountsListDataTable NominalAccountsList => tableNominalAccountsList;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public NominalControlAccountsListDataTable NominalControlAccountsList => tableNominalControlAccountsList;

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
	public Nominal()
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
	protected Nominal(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["NominalAccountsList"] != null)
			{
				base.Tables.Add(new NominalAccountsListDataTable(dataSet.Tables["NominalAccountsList"]));
			}
			if (dataSet.Tables["NominalControlAccountsList"] != null)
			{
				base.Tables.Add(new NominalControlAccountsListDataTable(dataSet.Tables["NominalControlAccountsList"]));
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
		Nominal obj = (Nominal)base.Clone();
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
			if (dataSet.Tables["NominalAccountsList"] != null)
			{
				base.Tables.Add(new NominalAccountsListDataTable(dataSet.Tables["NominalAccountsList"]));
			}
			if (dataSet.Tables["NominalControlAccountsList"] != null)
			{
				base.Tables.Add(new NominalControlAccountsListDataTable(dataSet.Tables["NominalControlAccountsList"]));
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
		tableNominalAccountsList = (NominalAccountsListDataTable)base.Tables["NominalAccountsList"];
		if (initTable && tableNominalAccountsList != null)
		{
			tableNominalAccountsList.InitVars();
		}
		tableNominalControlAccountsList = (NominalControlAccountsListDataTable)base.Tables["NominalControlAccountsList"];
		if (initTable && tableNominalControlAccountsList != null)
		{
			tableNominalControlAccountsList.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "Nominal";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/Nominal.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableNominalAccountsList = new NominalAccountsListDataTable();
		base.Tables.Add(tableNominalAccountsList);
		tableNominalControlAccountsList = new NominalControlAccountsListDataTable();
		base.Tables.Add(tableNominalControlAccountsList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeNominalAccountsList()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeNominalControlAccountsList()
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
		Nominal nominal = new Nominal();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = nominal.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = nominal.GetSchemaSerializable();
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
