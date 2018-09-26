using Guard_profiler;
using Guard_profiler.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Guard_profiler.dt_guard_profileTableAdapters
{
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapter")]
	[ToolboxItem(true)]
	public class Q_OFFICER_REPORTTableAdapter : Component
	{
		private SqlDataAdapter _adapter;

		private SqlConnection _connection;

		private SqlTransaction _transaction;

		private SqlCommand[] _commandCollection;

		private bool _clearBeforeFill;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				if (this._adapter == null)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				if (this._commandCollection == null)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				if (this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				if (this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				if (this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < (int)this.CommandCollection.Length; i++)
				{
					if (this.CommandCollection[i] != null)
					{
						this.CommandCollection[i].Connection = value;
					}
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				for (int i = 0; i < (int)this.CommandCollection.Length; i++)
				{
					this.CommandCollection[i].Transaction = this._transaction;
				}
				if (this.Adapter != null && this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Transaction = this._transaction;
				}
				if (this.Adapter != null && this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Transaction = this._transaction;
				}
				if (this.Adapter != null && this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Transaction = this._transaction;
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Q_OFFICER_REPORTTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(dt_guard_profile.Q_OFFICER_REPORTDataTable dataTable, string QueryName, string guard_number)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (QueryName != null)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = QueryName;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			if (guard_number != null)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = guard_number;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		[DataObjectMethod(DataObjectMethodType.Select, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual dt_guard_profile.Q_OFFICER_REPORTDataTable GetData(string QueryName, string guard_number)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (QueryName != null)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = QueryName;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			if (guard_number != null)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = guard_number;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			dt_guard_profile.Q_OFFICER_REPORTDataTable dataTable = new dt_guard_profile.Q_OFFICER_REPORTDataTable();
			this.Adapter.Fill(dataTable);
			return dataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping tableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "Q_OFFICER_REPORT"
			};
			tableMapping.ColumnMappings.Add("record_guid", "record_guid");
			tableMapping.ColumnMappings.Add("guard_number", "guard_number");
			tableMapping.ColumnMappings.Add("f_name", "f_name");
			tableMapping.ColumnMappings.Add("l_name", "l_name");
			tableMapping.ColumnMappings.Add("full_name", "full_name");
			tableMapping.ColumnMappings.Add("phone", "phone");
			tableMapping.ColumnMappings.Add("branch", "branch");
			tableMapping.ColumnMappings.Add("position", "position");
			tableMapping.ColumnMappings.Add("department", "department");
			tableMapping.ColumnMappings.Add("registered_date", "registered_date");
			tableMapping.ColumnMappings.Add("birth_place", "birth_place");
			tableMapping.ColumnMappings.Add("dob", "dob");
			tableMapping.ColumnMappings.Add("age", "age");
			tableMapping.ColumnMappings.Add("gender", "gender");
			tableMapping.ColumnMappings.Add("home_district", "home_district");
			tableMapping.ColumnMappings.Add("home_county", "home_county");
			tableMapping.ColumnMappings.Add("home_sub_county", "home_sub_county");
			tableMapping.ColumnMappings.Add("home_parish", "home_parish");
			tableMapping.ColumnMappings.Add("home_village_lc1", "home_village_lc1");
			tableMapping.ColumnMappings.Add("religion", "religion");
			tableMapping.ColumnMappings.Add("marital_status", "marital_status");
			tableMapping.ColumnMappings.Add("partners_name", "partners_name");
			tableMapping.ColumnMappings.Add("current_residence_district", "current_residence_district");
			tableMapping.ColumnMappings.Add("current_residence_sub_county", "current_residence_sub_county");
			tableMapping.ColumnMappings.Add("current_residence_parish", "current_residence_parish");
			tableMapping.ColumnMappings.Add("current_residence_zone", "current_residence_zone");
			tableMapping.ColumnMappings.Add("current_landlord_name", "current_landlord_name");
			tableMapping.ColumnMappings.Add("father_name", "father_name");
			tableMapping.ColumnMappings.Add("father_district", "father_district");
			tableMapping.ColumnMappings.Add("father_county", "father_county");
			tableMapping.ColumnMappings.Add("father_village", "father_village");
			tableMapping.ColumnMappings.Add("father_zone", "father_zone");
			tableMapping.ColumnMappings.Add("prev_employer_name", "prev_employer_name");
			tableMapping.ColumnMappings.Add("prev_employer_address", "prev_employer_address");
			tableMapping.ColumnMappings.Add("cause_of_departure", "cause_of_departure");
			tableMapping.ColumnMappings.Add("tin_number", "tin_number");
			tableMapping.ColumnMappings.Add("previous_salary", "previous_salary");
			tableMapping.ColumnMappings.Add("start_date", "start_date");
			tableMapping.ColumnMappings.Add("institution_name", "institution_name");
			tableMapping.ColumnMappings.Add("award_name", "award_name");
			tableMapping.ColumnMappings.Add("study_start_date", "study_start_date");
			tableMapping.ColumnMappings.Add("study_end_date", "study_end_date");
			tableMapping.ColumnMappings.Add("refferees", "refferees");
			tableMapping.ColumnMappings.Add("image_data", "image_data");
			this._adapter.TableMappings.Add((object)tableMapping);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.Q_OFFICER_REPORT";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@QueryName", SqlDbType.NVarChar, 250, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@guard_number", SqlDbType.NVarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection()
			{
				ConnectionString = Settings.Default.sg_list_report_conn_str
			};
		}
	}
}