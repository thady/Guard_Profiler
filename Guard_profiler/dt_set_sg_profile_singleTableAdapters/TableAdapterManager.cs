using Guard_profiler;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Guard_profiler.dt_set_sg_profile_singleTableAdapters
{
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	[ToolboxItem(true)]
	public class TableAdapterManager : Component
	{
		private TableAdapterManager.UpdateOrderOption _updateOrder;

		private Guard_profiler.dt_set_sg_profile_singleTableAdapters.Tbl_sg_profilesTableAdapter _tbl_sg_profilesTableAdapter;

		private bool _backupDataSetBeforeUpdate;

		private IDbConnection _connection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public IDbConnection Connection
		{
			get
			{
				if (this._connection != null)
				{
					return this._connection;
				}
				if (this._tbl_sg_profilesTableAdapter == null || this._tbl_sg_profilesTableAdapter.Connection == null)
				{
					return null;
				}
				return this._tbl_sg_profilesTableAdapter.Connection;
			}
			set
			{
				this._connection = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TableAdapterInstanceCount
		{
			get
			{
				int count = 0;
				if (this._tbl_sg_profilesTableAdapter != null)
				{
					count++;
				}
				return count;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Guard_profiler.dt_set_sg_profile_singleTableAdapters.Tbl_sg_profilesTableAdapter Tbl_sg_profilesTableAdapter
		{
			get
			{
				return this._tbl_sg_profilesTableAdapter;
			}
			set
			{
				this._tbl_sg_profilesTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		public TableAdapterManager()
		{
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			if (updatedRows == null || (int)updatedRows.Length < 1)
			{
				return updatedRows;
			}
			if (allAddedRows == null || allAddedRows.Count < 1)
			{
				return updatedRows;
			}
			List<DataRow> realUpdatedRows = new List<DataRow>();
			for (int i = 0; i < (int)updatedRows.Length; i++)
			{
				DataRow row = updatedRows[i];
				if (!allAddedRows.Contains(row))
				{
					realUpdatedRows.Add(row);
				}
			}
			return realUpdatedRows.ToArray();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			if (this._connection != null)
			{
				return true;
			}
			if (this.Connection == null || inputConnection == null)
			{
				return true;
			}
			if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
			{
				return true;
			}
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(dt_set_sg_profile_single dataSet)
		{
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (!dataSet.HasChanges())
			{
				return 0;
			}
			if (this._tbl_sg_profilesTableAdapter != null && !this.MatchTableAdapterConnection(this._tbl_sg_profilesTableAdapter.Connection))
			{
				throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
			}
			IDbConnection workConnection = this.Connection;
			if (workConnection == null)
			{
				throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
			}
			bool workConnOpened = false;
			if ((workConnection.State & ConnectionState.Broken) == ConnectionState.Broken)
			{
				workConnection.Close();
			}
			if (workConnection.State == ConnectionState.Closed)
			{
				workConnection.Open();
				workConnOpened = true;
			}
			IDbTransaction workTransaction = workConnection.BeginTransaction();
			if (workTransaction == null)
			{
				throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
			}
			List<DataRow> allChangedRows = new List<DataRow>();
			List<DataRow> allAddedRows = new List<DataRow>();
			List<DataAdapter> adaptersWithAcceptChangesDuringUpdate = new List<DataAdapter>();
			Dictionary<object, IDbConnection> revertConnections = new Dictionary<object, IDbConnection>();
			int result = 0;
			DataSet backupDataSet = null;
			if (this.BackupDataSetBeforeUpdate)
			{
				backupDataSet = new DataSet();
				backupDataSet.Merge(dataSet);
			}
			try
			{
				try
				{
					if (this._tbl_sg_profilesTableAdapter != null)
					{
						revertConnections.Add(this._tbl_sg_profilesTableAdapter, this._tbl_sg_profilesTableAdapter.Connection);
						this._tbl_sg_profilesTableAdapter.Connection = (SqlConnection)workConnection;
						this._tbl_sg_profilesTableAdapter.Transaction = (SqlTransaction)workTransaction;
						if (this._tbl_sg_profilesTableAdapter.Adapter.AcceptChangesDuringUpdate)
						{
							this._tbl_sg_profilesTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							adaptersWithAcceptChangesDuringUpdate.Add(this._tbl_sg_profilesTableAdapter.Adapter);
						}
					}
					if (this.UpdateOrder != TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
					{
						result += this.UpdateInsertedRows(dataSet, allAddedRows);
						result += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
					}
					else
					{
						result += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
						result += this.UpdateInsertedRows(dataSet, allAddedRows);
					}
					result += this.UpdateDeletedRows(dataSet, allChangedRows);
					workTransaction.Commit();
					if (0 < allAddedRows.Count)
					{
						DataRow[] rows = new DataRow[allAddedRows.Count];
						allAddedRows.CopyTo(rows);
						for (int i = 0; i < (int)rows.Length; i++)
						{
							rows[i].AcceptChanges();
						}
					}
					if (0 < allChangedRows.Count)
					{
						DataRow[] rows = new DataRow[allChangedRows.Count];
						allChangedRows.CopyTo(rows);
						for (int i = 0; i < (int)rows.Length; i++)
						{
							rows[i].AcceptChanges();
						}
					}
				}
				catch (Exception exception)
				{
					Exception ex = exception;
					workTransaction.Rollback();
					if (this.BackupDataSetBeforeUpdate)
					{
						dataSet.Clear();
						dataSet.Merge(backupDataSet);
					}
					else if (0 < allAddedRows.Count)
					{
						DataRow[] rows = new DataRow[allAddedRows.Count];
						allAddedRows.CopyTo(rows);
						for (int i = 0; i < (int)rows.Length; i++)
						{
							DataRow row = rows[i];
							row.AcceptChanges();
							row.SetAdded();
						}
					}
					throw ex;
				}
			}
			finally
			{
				if (workConnOpened)
				{
					workConnection.Close();
				}
				if (this._tbl_sg_profilesTableAdapter != null)
				{
					this._tbl_sg_profilesTableAdapter.Connection = (SqlConnection)revertConnections[this._tbl_sg_profilesTableAdapter];
					this._tbl_sg_profilesTableAdapter.Transaction = null;
				}
				if (0 < adaptersWithAcceptChangesDuringUpdate.Count)
				{
					DataAdapter[] adapters = new DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
					adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
					for (int i = 0; i < (int)adapters.Length; i++)
					{
						adapters[i].AcceptChangesDuringUpdate = true;
					}
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(dt_set_sg_profile_single dataSet, List<DataRow> allChangedRows)
		{
			int result = 0;
			if (this._tbl_sg_profilesTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.Tbl_sg_profiles.Select(null, null, DataViewRowState.Deleted);
				if (deletedRows != null && 0 < (int)deletedRows.Length)
				{
					result += this._tbl_sg_profilesTableAdapter.Update(deletedRows);
					allChangedRows.AddRange(deletedRows);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(dt_set_sg_profile_single dataSet, List<DataRow> allAddedRows)
		{
			int result = 0;
			if (this._tbl_sg_profilesTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.Tbl_sg_profiles.Select(null, null, DataViewRowState.Added);
				if (addedRows != null && 0 < (int)addedRows.Length)
				{
					result += this._tbl_sg_profilesTableAdapter.Update(addedRows);
					allAddedRows.AddRange(addedRows);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(dt_set_sg_profile_single dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int result = 0;
			if (this._tbl_sg_profilesTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.Tbl_sg_profiles.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
				if (updatedRows != null && 0 < (int)updatedRows.Length)
				{
					result += this._tbl_sg_profilesTableAdapter.Update(updatedRows);
					allChangedRows.AddRange(updatedRows);
				}
			}
			return result;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			private DataRelation _relation;

			private int _childFirst;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (childFirst)
				{
					this._childFirst = -1;
					return;
				}
				this._childFirst = 1;
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
				int distance1 = 0;
				DataRow root1 = this.GetRoot(row1, out distance1);
				int distance2 = 0;
				DataRow root2 = this.GetRoot(row2, out distance2);
				if (object.ReferenceEquals(root1, root2))
				{
					return this._childFirst * distance1.CompareTo(distance2);
				}
				if (root1.Table.Rows.IndexOf(root1) < root2.Table.Rows.IndexOf(root2))
				{
					return -1;
				}
				return 1;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, out int distance)
			{
				DataRow parent;
				DataRow root = row;
				distance = 0;
				IDictionary<DataRow, DataRow> traversedRows = new Dictionary<DataRow, DataRow>();
				traversedRows[row] = row;
				for (parent = row.GetParentRow(this._relation, DataRowVersion.Default); parent != null && !traversedRows.ContainsKey(parent); parent = parent.GetParentRow(this._relation, DataRowVersion.Default))
				{
					distance++;
					root = parent;
					traversedRows[parent] = parent;
				}
				if (distance == 0)
				{
					traversedRows.Clear();
					traversedRows[row] = row;
					for (parent = row.GetParentRow(this._relation, DataRowVersion.Original); parent != null && !traversedRows.ContainsKey(parent); parent = parent.GetParentRow(this._relation, DataRowVersion.Original))
					{
						distance++;
						root = parent;
						traversedRows[parent] = parent;
					}
				}
				return root;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			InsertUpdateDelete,
			UpdateInsertDelete
		}
	}
}