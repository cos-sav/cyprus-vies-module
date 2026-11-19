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
[XmlRoot("VAT")]
[HelpKeyword("vs.data.DataSet")]
public class VAT : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void TransactionSplitsRowChangeEventHandler(object sender, TransactionSplitsRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void TaxCodesRowChangeEventHandler(object sender, TaxCodesRowChangeEvent e);

	/// <summary>
	/// Represents the strongly named DataTable class.
	/// </summary>
	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class TransactionSplitsDataTable : TypedTableBase<TransactionSplitsRow>
	{
		private DataColumn columnTRAN_NUMBER;

		private DataColumn columnTYPE;

		private DataColumn columnACCOUNT_REF;

		private DataColumn columnNOMINAL_CODE;

		private DataColumn columnINV_REF;

		private DataColumn columnDETAILS;

		private DataColumn columnNET_AMOUNT;

		private DataColumn columnTAX_AMOUNT;

		private DataColumn columnGROSS_AMOUNT;

		private DataColumn columnTAX_CODE;

		private DataColumn columnTAX_RATE;

		private DataColumn columnSPLIT_NUMBER;

		private DataColumn columnDATE_ENTERED;

		private DataColumn columnDELETED_FLAG;

		private DataColumn columnVAT_FLAG;

		private DataColumn columnVAT_RECONCILED_DATE;

		private DataColumn columnVAT_INCLUDE;

		private DataColumn columnEURO_SALES;

		private DataColumn columnEURO_PURCHASE;

		private DataColumn columnIS_REVERSECHARGE;

		private DataColumn columnRELATED_CODE;

		private DataColumn columnRELATED_RATE;

		private DataColumn columnTRAN_DATE;

		private DataColumn columnBOX;

		private DataColumn columnIsAdd;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TRAN_NUMBERColumn => columnTRAN_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TYPEColumn => columnTYPE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ACCOUNT_REFColumn => columnACCOUNT_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NOMINAL_CODEColumn => columnNOMINAL_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn INV_REFColumn => columnINV_REF;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DETAILSColumn => columnDETAILS;

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
		public DataColumn TAX_CODEColumn => columnTAX_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_RATEColumn => columnTAX_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SPLIT_NUMBERColumn => columnSPLIT_NUMBER;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DATE_ENTEREDColumn => columnDATE_ENTERED;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DELETED_FLAGColumn => columnDELETED_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_FLAGColumn => columnVAT_FLAG;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_RECONCILED_DATEColumn => columnVAT_RECONCILED_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_INCLUDEColumn => columnVAT_INCLUDE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_SALESColumn => columnEURO_SALES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_PURCHASEColumn => columnEURO_PURCHASE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IS_REVERSECHARGEColumn => columnIS_REVERSECHARGE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RELATED_CODEColumn => columnRELATED_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RELATED_RATEColumn => columnRELATED_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TRAN_DATEColumn => columnTRAN_DATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BOXColumn => columnBOX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IsAddColumn => columnIsAdd;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsRow this[int index] => (TransactionSplitsRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TransactionSplitsRowChangeEventHandler TransactionSplitsRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TransactionSplitsRowChangeEventHandler TransactionSplitsRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TransactionSplitsRowChangeEventHandler TransactionSplitsRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TransactionSplitsRowChangeEventHandler TransactionSplitsRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsDataTable()
		{
			base.TableName = "TransactionSplits";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal TransactionSplitsDataTable(DataTable table)
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
		protected TransactionSplitsDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddTransactionSplitsRow(TransactionSplitsRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsRow AddTransactionSplitsRow(int TRAN_NUMBER, string TYPE, string ACCOUNT_REF, string NOMINAL_CODE, string INV_REF, string DETAILS, double NET_AMOUNT, double TAX_AMOUNT, double GROSS_AMOUNT, string TAX_CODE, double TAX_RATE, int SPLIT_NUMBER, DateTime DATE_ENTERED, short DELETED_FLAG, string VAT_FLAG, DateTime VAT_RECONCILED_DATE, short VAT_INCLUDE, short EURO_SALES, short EURO_PURCHASE, short IS_REVERSECHARGE, short RELATED_CODE, double RELATED_RATE, DateTime TRAN_DATE, string BOX, bool IsAdd)
		{
			TransactionSplitsRow transactionSplitsRow = (TransactionSplitsRow)NewRow();
			object[] itemArray = new object[25]
			{
				TRAN_NUMBER, TYPE, ACCOUNT_REF, NOMINAL_CODE, INV_REF, DETAILS, NET_AMOUNT, TAX_AMOUNT, GROSS_AMOUNT, TAX_CODE,
				TAX_RATE, SPLIT_NUMBER, DATE_ENTERED, DELETED_FLAG, VAT_FLAG, VAT_RECONCILED_DATE, VAT_INCLUDE, EURO_SALES, EURO_PURCHASE, IS_REVERSECHARGE,
				RELATED_CODE, RELATED_RATE, TRAN_DATE, BOX, IsAdd
			};
			transactionSplitsRow.ItemArray = itemArray;
			base.Rows.Add(transactionSplitsRow);
			return transactionSplitsRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			TransactionSplitsDataTable obj = (TransactionSplitsDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new TransactionSplitsDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnTRAN_NUMBER = base.Columns["TRAN_NUMBER"];
			columnTYPE = base.Columns["TYPE"];
			columnACCOUNT_REF = base.Columns["ACCOUNT_REF"];
			columnNOMINAL_CODE = base.Columns["NOMINAL_CODE"];
			columnINV_REF = base.Columns["INV_REF"];
			columnDETAILS = base.Columns["DETAILS"];
			columnNET_AMOUNT = base.Columns["NET_AMOUNT"];
			columnTAX_AMOUNT = base.Columns["TAX_AMOUNT"];
			columnGROSS_AMOUNT = base.Columns["GROSS_AMOUNT"];
			columnTAX_CODE = base.Columns["TAX_CODE"];
			columnTAX_RATE = base.Columns["TAX_RATE"];
			columnSPLIT_NUMBER = base.Columns["SPLIT_NUMBER"];
			columnDATE_ENTERED = base.Columns["DATE_ENTERED"];
			columnDELETED_FLAG = base.Columns["DELETED_FLAG"];
			columnVAT_FLAG = base.Columns["VAT_FLAG"];
			columnVAT_RECONCILED_DATE = base.Columns["VAT_RECONCILED_DATE"];
			columnVAT_INCLUDE = base.Columns["VAT_INCLUDE"];
			columnEURO_SALES = base.Columns["EURO_SALES"];
			columnEURO_PURCHASE = base.Columns["EURO_PURCHASE"];
			columnIS_REVERSECHARGE = base.Columns["IS_REVERSECHARGE"];
			columnRELATED_CODE = base.Columns["RELATED_CODE"];
			columnRELATED_RATE = base.Columns["RELATED_RATE"];
			columnTRAN_DATE = base.Columns["TRAN_DATE"];
			columnBOX = base.Columns["BOX"];
			columnIsAdd = base.Columns["IsAdd"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTRAN_NUMBER = new DataColumn("TRAN_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTRAN_NUMBER);
			columnTYPE = new DataColumn("TYPE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTYPE);
			columnACCOUNT_REF = new DataColumn("ACCOUNT_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnACCOUNT_REF);
			columnNOMINAL_CODE = new DataColumn("NOMINAL_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNOMINAL_CODE);
			columnINV_REF = new DataColumn("INV_REF", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnINV_REF);
			columnDETAILS = new DataColumn("DETAILS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDETAILS);
			columnNET_AMOUNT = new DataColumn("NET_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnNET_AMOUNT);
			columnTAX_AMOUNT = new DataColumn("TAX_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTAX_AMOUNT);
			columnGROSS_AMOUNT = new DataColumn("GROSS_AMOUNT", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnGROSS_AMOUNT);
			columnTAX_CODE = new DataColumn("TAX_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAX_CODE);
			columnTAX_RATE = new DataColumn("TAX_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTAX_RATE);
			columnSPLIT_NUMBER = new DataColumn("SPLIT_NUMBER", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSPLIT_NUMBER);
			columnDATE_ENTERED = new DataColumn("DATE_ENTERED", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDATE_ENTERED);
			columnDELETED_FLAG = new DataColumn("DELETED_FLAG", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnDELETED_FLAG);
			columnVAT_FLAG = new DataColumn("VAT_FLAG", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVAT_FLAG);
			columnVAT_RECONCILED_DATE = new DataColumn("VAT_RECONCILED_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnVAT_RECONCILED_DATE);
			columnVAT_INCLUDE = new DataColumn("VAT_INCLUDE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnVAT_INCLUDE);
			columnEURO_SALES = new DataColumn("EURO_SALES", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnEURO_SALES);
			columnEURO_PURCHASE = new DataColumn("EURO_PURCHASE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnEURO_PURCHASE);
			columnIS_REVERSECHARGE = new DataColumn("IS_REVERSECHARGE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnIS_REVERSECHARGE);
			columnRELATED_CODE = new DataColumn("RELATED_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRELATED_CODE);
			columnRELATED_RATE = new DataColumn("RELATED_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnRELATED_RATE);
			columnTRAN_DATE = new DataColumn("TRAN_DATE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnTRAN_DATE);
			columnBOX = new DataColumn("BOX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBOX);
			columnIsAdd = new DataColumn("IsAdd", typeof(bool), null, MappingType.Element);
			base.Columns.Add(columnIsAdd);
			columnTYPE.MaxLength = 2;
			columnACCOUNT_REF.MaxLength = 8;
			columnNOMINAL_CODE.MaxLength = 8;
			columnINV_REF.MaxLength = 30;
			columnDETAILS.MaxLength = 60;
			columnNET_AMOUNT.DefaultValue = 0.0;
			columnTAX_AMOUNT.DefaultValue = 0.0;
			columnGROSS_AMOUNT.DefaultValue = 0.0;
			columnTAX_CODE.MaxLength = 3;
			columnVAT_FLAG.MaxLength = 1;
			columnVAT_INCLUDE.AllowDBNull = false;
			columnEURO_SALES.AllowDBNull = false;
			columnEURO_PURCHASE.AllowDBNull = false;
			columnRELATED_CODE.AllowDBNull = false;
			columnBOX.AllowDBNull = false;
			columnBOX.DefaultValue = "";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsRow NewTransactionSplitsRow()
		{
			return (TransactionSplitsRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new TransactionSplitsRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(TransactionSplitsRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (TransactionSplitsRowChanged != null)
			{
				TransactionSplitsRowChanged?.Invoke(this, new TransactionSplitsRowChangeEvent((TransactionSplitsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (TransactionSplitsRowChanging != null)
			{
				TransactionSplitsRowChanging?.Invoke(this, new TransactionSplitsRowChangeEvent((TransactionSplitsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (TransactionSplitsRowDeleted != null)
			{
				TransactionSplitsRowDeleted?.Invoke(this, new TransactionSplitsRowChangeEvent((TransactionSplitsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (TransactionSplitsRowDeleting != null)
			{
				TransactionSplitsRowDeleting?.Invoke(this, new TransactionSplitsRowChangeEvent((TransactionSplitsRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveTransactionSplitsRow(TransactionSplitsRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			VAT vAT = new VAT();
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
			xmlSchemaAttribute.FixedValue = vAT.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "TransactionSplitsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = vAT.GetSchemaSerializable();
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
	public class TaxCodesDataTable : TypedTableBase<TaxCodesRow>
	{
		private DataColumn columnTAX_CODE;

		private DataColumn columnDESCRIPTION;

		private DataColumn columnTAX_RATE;

		private DataColumn columnVAT_INCLUDE;

		private DataColumn columnEURO_SALES;

		private DataColumn columnEURO_PURCHASE;

		private DataColumn columnRELATED_CODE;

		private DataColumn columnRELATED_RATE;

		private DataColumn columnIS_REVERSECHARGE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_CODEColumn => columnTAX_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DESCRIPTIONColumn => columnDESCRIPTION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TAX_RATEColumn => columnTAX_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VAT_INCLUDEColumn => columnVAT_INCLUDE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_SALESColumn => columnEURO_SALES;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn EURO_PURCHASEColumn => columnEURO_PURCHASE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RELATED_CODEColumn => columnRELATED_CODE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn RELATED_RATEColumn => columnRELATED_RATE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn IS_REVERSECHARGEColumn => columnIS_REVERSECHARGE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesRow this[int index] => (TaxCodesRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TaxCodesRowChangeEventHandler TaxCodesRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TaxCodesRowChangeEventHandler TaxCodesRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TaxCodesRowChangeEventHandler TaxCodesRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event TaxCodesRowChangeEventHandler TaxCodesRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesDataTable()
		{
			base.TableName = "TaxCodes";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal TaxCodesDataTable(DataTable table)
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
		protected TaxCodesDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddTaxCodesRow(TaxCodesRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesRow AddTaxCodesRow(string TAX_CODE, string DESCRIPTION, double TAX_RATE, short VAT_INCLUDE, short EURO_SALES, short EURO_PURCHASE, short RELATED_CODE, double RELATED_RATE, short IS_REVERSECHARGE)
		{
			TaxCodesRow taxCodesRow = (TaxCodesRow)NewRow();
			object[] itemArray = new object[9] { TAX_CODE, DESCRIPTION, TAX_RATE, VAT_INCLUDE, EURO_SALES, EURO_PURCHASE, RELATED_CODE, RELATED_RATE, IS_REVERSECHARGE };
			taxCodesRow.ItemArray = itemArray;
			base.Rows.Add(taxCodesRow);
			return taxCodesRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			TaxCodesDataTable obj = (TaxCodesDataTable)base.Clone();
			obj.InitVars();
			return obj;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new TaxCodesDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnTAX_CODE = base.Columns["TAX_CODE"];
			columnDESCRIPTION = base.Columns["DESCRIPTION"];
			columnTAX_RATE = base.Columns["TAX_RATE"];
			columnVAT_INCLUDE = base.Columns["VAT_INCLUDE"];
			columnEURO_SALES = base.Columns["EURO_SALES"];
			columnEURO_PURCHASE = base.Columns["EURO_PURCHASE"];
			columnRELATED_CODE = base.Columns["RELATED_CODE"];
			columnRELATED_RATE = base.Columns["RELATED_RATE"];
			columnIS_REVERSECHARGE = base.Columns["IS_REVERSECHARGE"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnTAX_CODE = new DataColumn("TAX_CODE", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTAX_CODE);
			columnDESCRIPTION = new DataColumn("DESCRIPTION", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDESCRIPTION);
			columnTAX_RATE = new DataColumn("TAX_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnTAX_RATE);
			columnVAT_INCLUDE = new DataColumn("VAT_INCLUDE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnVAT_INCLUDE);
			columnEURO_SALES = new DataColumn("EURO_SALES", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnEURO_SALES);
			columnEURO_PURCHASE = new DataColumn("EURO_PURCHASE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnEURO_PURCHASE);
			columnRELATED_CODE = new DataColumn("RELATED_CODE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnRELATED_CODE);
			columnRELATED_RATE = new DataColumn("RELATED_RATE", typeof(double), null, MappingType.Element);
			base.Columns.Add(columnRELATED_RATE);
			columnIS_REVERSECHARGE = new DataColumn("IS_REVERSECHARGE", typeof(short), null, MappingType.Element);
			base.Columns.Add(columnIS_REVERSECHARGE);
			columnTAX_CODE.MaxLength = 3;
			columnDESCRIPTION.MaxLength = 60;
			columnVAT_INCLUDE.AllowDBNull = false;
			columnEURO_SALES.AllowDBNull = false;
			columnEURO_PURCHASE.AllowDBNull = false;
			columnRELATED_CODE.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesRow NewTaxCodesRow()
		{
			return (TaxCodesRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new TaxCodesRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(TaxCodesRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (TaxCodesRowChanged != null)
			{
				TaxCodesRowChanged?.Invoke(this, new TaxCodesRowChangeEvent((TaxCodesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (TaxCodesRowChanging != null)
			{
				TaxCodesRowChanging?.Invoke(this, new TaxCodesRowChangeEvent((TaxCodesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (TaxCodesRowDeleted != null)
			{
				TaxCodesRowDeleted?.Invoke(this, new TaxCodesRowChangeEvent((TaxCodesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (TaxCodesRowDeleting != null)
			{
				TaxCodesRowDeleting?.Invoke(this, new TaxCodesRowChangeEvent((TaxCodesRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void RemoveTaxCodesRow(TaxCodesRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			VAT vAT = new VAT();
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
			xmlSchemaAttribute.FixedValue = vAT.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "TaxCodesDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = vAT.GetSchemaSerializable();
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
	public class TransactionSplitsRow : DataRow
	{
		private TransactionSplitsDataTable tableTransactionSplits;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TRAN_NUMBER
		{
			get
			{
				try
				{
					return Conversions.ToInteger(base[tableTransactionSplits.TRAN_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TRAN_NUMBER' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.TRAN_NUMBERColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.TYPEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TYPE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.TYPEColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.ACCOUNT_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'ACCOUNT_REF' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.ACCOUNT_REFColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.NOMINAL_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'NOMINAL_CODE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.NOMINAL_CODEColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.INV_REFColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'INV_REF' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.INV_REFColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.DETAILSColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DETAILS' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.DETAILSColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double NET_AMOUNT
		{
			get
			{
				if (IsNET_AMOUNTNull())
				{
					return 0.0;
				}
				return Conversions.ToDouble(base[tableTransactionSplits.NET_AMOUNTColumn]);
			}
			set
			{
				base[tableTransactionSplits.NET_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TAX_AMOUNT
		{
			get
			{
				if (IsTAX_AMOUNTNull())
				{
					return 0.0;
				}
				return Conversions.ToDouble(base[tableTransactionSplits.TAX_AMOUNTColumn]);
			}
			set
			{
				base[tableTransactionSplits.TAX_AMOUNTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double GROSS_AMOUNT
		{
			get
			{
				if (IsGROSS_AMOUNTNull())
				{
					return 0.0;
				}
				return Conversions.ToDouble(base[tableTransactionSplits.GROSS_AMOUNTColumn]);
			}
			set
			{
				base[tableTransactionSplits.GROSS_AMOUNTColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.TAX_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_CODE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.TAX_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TAX_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableTransactionSplits.TAX_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_RATE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.TAX_RATEColumn] = value;
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
					return Conversions.ToInteger(base[tableTransactionSplits.SPLIT_NUMBERColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'SPLIT_NUMBER' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.SPLIT_NUMBERColumn] = value;
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
					return Conversions.ToDate(base[tableTransactionSplits.DATE_ENTEREDColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DATE_ENTERED' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.DATE_ENTEREDColumn] = value;
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
					return Conversions.ToShort(base[tableTransactionSplits.DELETED_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DELETED_FLAG' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.DELETED_FLAGColumn] = value;
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
					return Conversions.ToString(base[tableTransactionSplits.VAT_FLAGColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_FLAG' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.VAT_FLAGColumn] = value;
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
					return Conversions.ToDate(base[tableTransactionSplits.VAT_RECONCILED_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'VAT_RECONCILED_DATE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.VAT_RECONCILED_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short VAT_INCLUDE
		{
			get
			{
				return Conversions.ToShort(base[tableTransactionSplits.VAT_INCLUDEColumn]);
			}
			set
			{
				base[tableTransactionSplits.VAT_INCLUDEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short EURO_SALES
		{
			get
			{
				return Conversions.ToShort(base[tableTransactionSplits.EURO_SALESColumn]);
			}
			set
			{
				base[tableTransactionSplits.EURO_SALESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short EURO_PURCHASE
		{
			get
			{
				return Conversions.ToShort(base[tableTransactionSplits.EURO_PURCHASEColumn]);
			}
			set
			{
				base[tableTransactionSplits.EURO_PURCHASEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short IS_REVERSECHARGE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableTransactionSplits.IS_REVERSECHARGEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IS_REVERSECHARGE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.IS_REVERSECHARGEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short RELATED_CODE
		{
			get
			{
				return Conversions.ToShort(base[tableTransactionSplits.RELATED_CODEColumn]);
			}
			set
			{
				base[tableTransactionSplits.RELATED_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double RELATED_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableTransactionSplits.RELATED_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RELATED_RATE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.RELATED_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime TRAN_DATE
		{
			get
			{
				try
				{
					return Conversions.ToDate(base[tableTransactionSplits.TRAN_DATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TRAN_DATE' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.TRAN_DATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BOX
		{
			get
			{
				return Conversions.ToString(base[tableTransactionSplits.BOXColumn]);
			}
			set
			{
				base[tableTransactionSplits.BOXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsAdd
		{
			get
			{
				try
				{
					return Conversions.ToBoolean(base[tableTransactionSplits.IsAddColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IsAdd' in table 'TransactionSplits' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTransactionSplits.IsAddColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal TransactionSplitsRow(DataRowBuilder rb)
			: base(rb)
		{
			tableTransactionSplits = (TransactionSplitsDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTRAN_NUMBERNull()
		{
			return IsNull(tableTransactionSplits.TRAN_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTRAN_NUMBERNull()
		{
			base[tableTransactionSplits.TRAN_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTYPENull()
		{
			return IsNull(tableTransactionSplits.TYPEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTYPENull()
		{
			base[tableTransactionSplits.TYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsACCOUNT_REFNull()
		{
			return IsNull(tableTransactionSplits.ACCOUNT_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetACCOUNT_REFNull()
		{
			base[tableTransactionSplits.ACCOUNT_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNOMINAL_CODENull()
		{
			return IsNull(tableTransactionSplits.NOMINAL_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNOMINAL_CODENull()
		{
			base[tableTransactionSplits.NOMINAL_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsINV_REFNull()
		{
			return IsNull(tableTransactionSplits.INV_REFColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetINV_REFNull()
		{
			base[tableTransactionSplits.INV_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDETAILSNull()
		{
			return IsNull(tableTransactionSplits.DETAILSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDETAILSNull()
		{
			base[tableTransactionSplits.DETAILSColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNET_AMOUNTNull()
		{
			return IsNull(tableTransactionSplits.NET_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNET_AMOUNTNull()
		{
			base[tableTransactionSplits.NET_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_AMOUNTNull()
		{
			return IsNull(tableTransactionSplits.TAX_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_AMOUNTNull()
		{
			base[tableTransactionSplits.TAX_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsGROSS_AMOUNTNull()
		{
			return IsNull(tableTransactionSplits.GROSS_AMOUNTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetGROSS_AMOUNTNull()
		{
			base[tableTransactionSplits.GROSS_AMOUNTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_CODENull()
		{
			return IsNull(tableTransactionSplits.TAX_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_CODENull()
		{
			base[tableTransactionSplits.TAX_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_RATENull()
		{
			return IsNull(tableTransactionSplits.TAX_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_RATENull()
		{
			base[tableTransactionSplits.TAX_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSPLIT_NUMBERNull()
		{
			return IsNull(tableTransactionSplits.SPLIT_NUMBERColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSPLIT_NUMBERNull()
		{
			base[tableTransactionSplits.SPLIT_NUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDATE_ENTEREDNull()
		{
			return IsNull(tableTransactionSplits.DATE_ENTEREDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDATE_ENTEREDNull()
		{
			base[tableTransactionSplits.DATE_ENTEREDColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDELETED_FLAGNull()
		{
			return IsNull(tableTransactionSplits.DELETED_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDELETED_FLAGNull()
		{
			base[tableTransactionSplits.DELETED_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_FLAGNull()
		{
			return IsNull(tableTransactionSplits.VAT_FLAGColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_FLAGNull()
		{
			base[tableTransactionSplits.VAT_FLAGColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVAT_RECONCILED_DATENull()
		{
			return IsNull(tableTransactionSplits.VAT_RECONCILED_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVAT_RECONCILED_DATENull()
		{
			base[tableTransactionSplits.VAT_RECONCILED_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIS_REVERSECHARGENull()
		{
			return IsNull(tableTransactionSplits.IS_REVERSECHARGEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIS_REVERSECHARGENull()
		{
			base[tableTransactionSplits.IS_REVERSECHARGEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRELATED_RATENull()
		{
			return IsNull(tableTransactionSplits.RELATED_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRELATED_RATENull()
		{
			base[tableTransactionSplits.RELATED_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTRAN_DATENull()
		{
			return IsNull(tableTransactionSplits.TRAN_DATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTRAN_DATENull()
		{
			base[tableTransactionSplits.TRAN_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIsAddNull()
		{
			return IsNull(tableTransactionSplits.IsAddColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIsAddNull()
		{
			base[tableTransactionSplits.IsAddColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Represents strongly named DataRow class.
	/// </summary>
	public class TaxCodesRow : DataRow
	{
		private TaxCodesDataTable tableTaxCodes;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TAX_CODE
		{
			get
			{
				try
				{
					return Conversions.ToString(base[tableTaxCodes.TAX_CODEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_CODE' in table 'TaxCodes' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTaxCodes.TAX_CODEColumn] = value;
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
					return Conversions.ToString(base[tableTaxCodes.DESCRIPTIONColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'DESCRIPTION' in table 'TaxCodes' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTaxCodes.DESCRIPTIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double TAX_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableTaxCodes.TAX_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'TAX_RATE' in table 'TaxCodes' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTaxCodes.TAX_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short VAT_INCLUDE
		{
			get
			{
				return Conversions.ToShort(base[tableTaxCodes.VAT_INCLUDEColumn]);
			}
			set
			{
				base[tableTaxCodes.VAT_INCLUDEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short EURO_SALES
		{
			get
			{
				return Conversions.ToShort(base[tableTaxCodes.EURO_SALESColumn]);
			}
			set
			{
				base[tableTaxCodes.EURO_SALESColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short EURO_PURCHASE
		{
			get
			{
				return Conversions.ToShort(base[tableTaxCodes.EURO_PURCHASEColumn]);
			}
			set
			{
				base[tableTaxCodes.EURO_PURCHASEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short RELATED_CODE
		{
			get
			{
				return Conversions.ToShort(base[tableTaxCodes.RELATED_CODEColumn]);
			}
			set
			{
				base[tableTaxCodes.RELATED_CODEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public double RELATED_RATE
		{
			get
			{
				try
				{
					return Conversions.ToDouble(base[tableTaxCodes.RELATED_RATEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'RELATED_RATE' in table 'TaxCodes' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTaxCodes.RELATED_RATEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short IS_REVERSECHARGE
		{
			get
			{
				try
				{
					return Conversions.ToShort(base[tableTaxCodes.IS_REVERSECHARGEColumn]);
				}
				catch (InvalidCastException ex)
				{
					ProjectData.SetProjectError(ex);
					InvalidCastException innerException = ex;
					throw new StrongTypingException("The value for column 'IS_REVERSECHARGE' in table 'TaxCodes' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTaxCodes.IS_REVERSECHARGEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal TaxCodesRow(DataRowBuilder rb)
			: base(rb)
		{
			tableTaxCodes = (TaxCodesDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_CODENull()
		{
			return IsNull(tableTaxCodes.TAX_CODEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_CODENull()
		{
			base[tableTaxCodes.TAX_CODEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDESCRIPTIONNull()
		{
			return IsNull(tableTaxCodes.DESCRIPTIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDESCRIPTIONNull()
		{
			base[tableTaxCodes.DESCRIPTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTAX_RATENull()
		{
			return IsNull(tableTaxCodes.TAX_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTAX_RATENull()
		{
			base[tableTaxCodes.TAX_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsRELATED_RATENull()
		{
			return IsNull(tableTaxCodes.RELATED_RATEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetRELATED_RATENull()
		{
			base[tableTaxCodes.RELATED_RATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsIS_REVERSECHARGENull()
		{
			return IsNull(tableTaxCodes.IS_REVERSECHARGEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetIS_REVERSECHARGENull()
		{
			base[tableTaxCodes.IS_REVERSECHARGEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class TransactionSplitsRowChangeEvent : EventArgs
	{
		private TransactionSplitsRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TransactionSplitsRowChangeEvent(TransactionSplitsRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	/// <summary>
	/// Row event argument class
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class TaxCodesRowChangeEvent : EventArgs
	{
		private TaxCodesRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TaxCodesRowChangeEvent(TaxCodesRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private TransactionSplitsDataTable tableTransactionSplits;

	private TaxCodesDataTable tableTaxCodes;

	private SchemaSerializationMode _schemaSerializationMode;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TransactionSplitsDataTable TransactionSplits => tableTransactionSplits;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public TaxCodesDataTable TaxCodes => tableTaxCodes;

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
	public VAT()
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
	protected VAT(SerializationInfo info, StreamingContext context)
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
			if (dataSet.Tables["TransactionSplits"] != null)
			{
				base.Tables.Add(new TransactionSplitsDataTable(dataSet.Tables["TransactionSplits"]));
			}
			if (dataSet.Tables["TaxCodes"] != null)
			{
				base.Tables.Add(new TaxCodesDataTable(dataSet.Tables["TaxCodes"]));
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
		VAT obj = (VAT)base.Clone();
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
			if (dataSet.Tables["TransactionSplits"] != null)
			{
				base.Tables.Add(new TransactionSplitsDataTable(dataSet.Tables["TransactionSplits"]));
			}
			if (dataSet.Tables["TaxCodes"] != null)
			{
				base.Tables.Add(new TaxCodesDataTable(dataSet.Tables["TaxCodes"]));
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
		tableTransactionSplits = (TransactionSplitsDataTable)base.Tables["TransactionSplits"];
		if (initTable && tableTransactionSplits != null)
		{
			tableTransactionSplits.InitVars();
		}
		tableTaxCodes = (TaxCodesDataTable)base.Tables["TaxCodes"];
		if (initTable && tableTaxCodes != null)
		{
			tableTaxCodes.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "VAT";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/AuditTrail.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableTransactionSplits = new TransactionSplitsDataTable();
		base.Tables.Add(tableTransactionSplits);
		tableTaxCodes = new TaxCodesDataTable();
		base.Tables.Add(tableTaxCodes);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTransactionSplits()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTaxCodes()
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
		VAT vAT = new VAT();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = vAT.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = vAT.GetSchemaSerializable();
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
