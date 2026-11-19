using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace xSageDataObjects.VATTableAdapters;

/// <summary>
/// TableAdapterManager is used to coordinate TableAdapters in the dataset to enable Hierarchical Update scenarios
/// </summary>
[DesignerCategory("code")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
public class TableAdapterManager : Component
{
	/// <summary>
	/// Update Order Option
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	/// <summary>
	/// Used to sort self-referenced table's rows
	/// </summary>
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow GetRoot(DataRow row, ref int distance)
		{
			DataRow result = row;
			distance = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[row] = row;
			DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
			checked
			{
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					distance++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
				}
				if (distance == 0)
				{
					dictionary.Clear();
					dictionary[row] = row;
					parentRow = row.GetParentRow(_relation, DataRowVersion.Original);
					while (parentRow != null && !dictionary.ContainsKey(parentRow))
					{
						distance++;
						result = parentRow;
						dictionary[parentRow] = parentRow;
						parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
					}
				}
				return result;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Compare(DataRow row1, DataRow row2)
		{
			if (object.ReferenceEquals(row1, row2))
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int distance = 0;
			DataRow root = GetRoot(row1, ref distance);
			int distance2 = 0;
			DataRow root2 = GetRoot(row2, ref distance2);
			if (object.ReferenceEquals(root, root2))
			{
				return checked(_childFirst * distance.CompareTo(distance2));
			}
			if (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
			{
				return -1;
			}
			return 1;
		}

		int IComparer<DataRow>.Compare(DataRow row1, DataRow row2)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Compare
			return this.Compare(row1, row2);
		}
	}

	private UpdateOrderOption _updateOrder;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	public int TableAdapterInstanceCount => 0;

	/// <summary>
	/// Update rows in top-down order.
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateUpdatedRows(VAT dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		return 0;
	}

	/// <summary>
	/// Insert rows in top-down order.
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateInsertedRows(VAT dataSet, List<DataRow> allAddedRows)
	{
		return 0;
	}

	/// <summary>
	/// Delete rows in bottom-up order.
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private int UpdateDeletedRows(VAT dataSet, List<DataRow> allChangedRows)
	{
		return 0;
	}

	/// <summary>
	/// Remove inserted rows that become updated rows after calling TableAdapter.Update(inserted rows) first
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in updatedRows)
		{
			if (!allAddedRows.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	/// <summary>
	/// Update all changes to the dataset.
	/// </summary>
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public virtual int UpdateAll(VAT dataSet)
	{
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		IDbConnection connection = Connection;
		if (connection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			connection.Close();
		}
		if (connection.State == ConnectionState.Closed)
		{
			connection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = connection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataAdapter> list3 = new List<DataAdapter>();
		new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet2 = null;
		if (BackupDataSetBeforeUpdate)
		{
			dataSet2 = new DataSet();
			dataSet2.Merge(dataSet);
		}
		checked
		{
			try
			{
				if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
				{
					num += UpdateUpdatedRows(dataSet, list, list2);
					num += UpdateInsertedRows(dataSet, list2);
				}
				else
				{
					num += UpdateInsertedRows(dataSet, list2);
					num += UpdateUpdatedRows(dataSet, list, list2);
				}
				num += UpdateDeletedRows(dataSet, list);
				dbTransaction.Commit();
				if (0 < list2.Count)
				{
					DataRow[] array = new DataRow[list2.Count - 1 + 1];
					list2.CopyTo(array);
					for (int i = 0; i < array.Length; i++)
					{
						array[i].AcceptChanges();
					}
				}
				if (0 < list.Count)
				{
					DataRow[] array2 = new DataRow[list.Count - 1 + 1];
					list.CopyTo(array2);
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].AcceptChanges();
					}
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				dbTransaction.Rollback();
				if (BackupDataSetBeforeUpdate)
				{
					dataSet.Clear();
					dataSet.Merge(dataSet2);
				}
				else if (0 < list2.Count)
				{
					DataRow[] array3 = new DataRow[list2.Count - 1 + 1];
					list2.CopyTo(array3);
					foreach (DataRow obj in array3)
					{
						obj.AcceptChanges();
						obj.SetAdded();
					}
				}
				throw ex2;
			}
			finally
			{
				if (flag)
				{
					connection.Close();
				}
				if (0 < list3.Count)
				{
					DataAdapter[] array4 = new DataAdapter[list3.Count - 1 + 1];
					list3.CopyTo(array4);
					for (int l = 0; l < array4.Length; l++)
					{
						array4[l].AcceptChangesDuringUpdate = true;
					}
				}
			}
			return num;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
