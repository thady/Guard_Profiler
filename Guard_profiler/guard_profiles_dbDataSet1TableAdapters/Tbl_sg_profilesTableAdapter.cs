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

namespace Guard_profiler.guard_profiles_dbDataSet1TableAdapters
{
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapter")]
	[ToolboxItem(true)]
	public class Tbl_sg_profilesTableAdapter : Component
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
		public Tbl_sg_profilesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(guard_profiles_dbDataSet1.Tbl_sg_profilesDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
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
		public virtual guard_profiles_dbDataSet1.Tbl_sg_profilesDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			guard_profiles_dbDataSet1.Tbl_sg_profilesDataTable dataTable = new guard_profiles_dbDataSet1.Tbl_sg_profilesDataTable();
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
				DataSetTable = "Tbl_sg_profiles"
			};
			tableMapping.ColumnMappings.Add("guard_number", "guard_number");
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
			this._adapter.InsertCommand = new SqlCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO [dbo].[Tbl_sg_profiles] ([full_name], [phone], [branch], [position], [department], [registered_date], [birth_place], [dob], [age], [gender], [home_district], [home_county], [home_sub_county], [home_parish], [home_village_lc1], [religion], [marital_status], [partners_name], [current_residence_district], [current_residence_sub_county], [current_residence_parish], [current_residence_zone], [current_landlord_name], [father_name], [father_district], [father_county], [father_village], [father_zone], [prev_employer_name], [prev_employer_address], [cause_of_departure], [tin_number], [previous_salary], [start_date], [institution_name], [award_name], [study_start_date], [study_end_date], [refferees], [image_data]) VALUES (@full_name, @phone, @branch, @position, @department, @registered_date, @birth_place, @dob, @age, @gender, @home_district, @home_county, @home_sub_county, @home_parish, @home_village_lc1, @religion, @marital_status, @partners_name, @current_residence_district, @current_residence_sub_county, @current_residence_parish, @current_residence_zone, @current_landlord_name, @father_name, @father_district, @father_county, @father_village, @father_zone, @prev_employer_name, @prev_employer_address, @cause_of_departure, @tin_number, @previous_salary, @start_date, @institution_name, @award_name, @study_start_date, @study_end_date, @refferees, @image_data)",
				CommandType = CommandType.Text
			};
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@full_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "full_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "phone", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@branch", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "branch", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@position", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "position", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@department", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "department", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@registered_date", SqlDbType.Date, 0, ParameterDirection.Input, 0, 0, "registered_date", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@birth_place", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "birth_place", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@dob", SqlDbType.Date, 0, ParameterDirection.Input, 0, 0, "dob", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "age", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@gender", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "gender", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@home_district", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "home_district", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@home_county", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "home_county", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@home_sub_county", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "home_sub_county", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@home_parish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "home_parish", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@home_village_lc1", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "home_village_lc1", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@religion", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "religion", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@marital_status", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "marital_status", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@partners_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "partners_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@current_residence_district", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "current_residence_district", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@current_residence_sub_county", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "current_residence_sub_county", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@current_residence_parish", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "current_residence_parish", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@current_residence_zone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "current_residence_zone", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@current_landlord_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "current_landlord_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@father_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "father_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@father_district", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "father_district", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@father_county", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "father_county", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@father_village", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "father_village", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@father_zone", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "father_zone", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@prev_employer_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "prev_employer_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@prev_employer_address", SqlDbType.NText, 0, ParameterDirection.Input, 0, 0, "prev_employer_address", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@cause_of_departure", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "cause_of_departure", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@tin_number", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "tin_number", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@previous_salary", SqlDbType.NText, 0, ParameterDirection.Input, 0, 0, "previous_salary", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@start_date", SqlDbType.Date, 0, ParameterDirection.Input, 0, 0, "start_date", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@institution_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "institution_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@award_name", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "award_name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@study_start_date", SqlDbType.Date, 0, ParameterDirection.Input, 0, 0, "study_start_date", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@study_end_date", SqlDbType.Date, 0, ParameterDirection.Input, 0, 0, "study_end_date", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@refferees", SqlDbType.NText, 0, ParameterDirection.Input, 0, 0, "refferees", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@image_data", SqlDbType.VarBinary, 0, ParameterDirection.Input, 0, 0, "image_data", DataRowVersion.Current, false, null, "", "", ""));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[] { new SqlCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT guard_number, full_name, phone, branch, position, department, registered_date, birth_place, dob, age, gender, home_district, home_county, home_sub_county, home_parish, home_village_lc1, religion, marital_status, partners_name, current_residence_district, current_residence_sub_county, current_residence_parish, current_residence_zone, current_landlord_name, father_name, father_district, father_county, father_village, father_zone, prev_employer_name, prev_employer_address, cause_of_departure, tin_number, previous_salary, start_date, institution_name, award_name, study_start_date, study_end_date, refferees, image_data FROM dbo.Tbl_sg_profiles";
			this._commandCollection[0].CommandType = CommandType.Text;
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

		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Insert(string full_name, string phone, string branch, string position, string department, DateTime? registered_date, string birth_place, DateTime? dob, int? age, string gender, string home_district, string home_county, string home_sub_county, string home_parish, string home_village_lc1, string religion, string marital_status, string partners_name, string current_residence_district, string current_residence_sub_county, string current_residence_parish, string current_residence_zone, string current_landlord_name, string father_name, string father_district, string father_county, string father_village, string father_zone, string prev_employer_name, string prev_employer_address, string cause_of_departure, string tin_number, string previous_salary, DateTime? start_date, string institution_name, string award_name, DateTime? study_start_date, DateTime? study_end_date, string refferees, byte[] image_data)
		{
			int num;
			if (full_name != null)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = full_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			if (phone != null)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = phone;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			if (branch != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = branch;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (position != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = position;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (department != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = department;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!registered_date.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = registered_date.Value;
			}
			if (birth_place != null)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = birth_place;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!dob.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = dob.Value;
			}
			if (!age.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = age.Value;
			}
			if (gender != null)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = gender;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			if (home_district != null)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = home_district;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			if (home_county != null)
			{
				this.Adapter.InsertCommand.Parameters[11].Value = home_county;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[11].Value = DBNull.Value;
			}
			if (home_sub_county != null)
			{
				this.Adapter.InsertCommand.Parameters[12].Value = home_sub_county;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
			}
			if (home_parish != null)
			{
				this.Adapter.InsertCommand.Parameters[13].Value = home_parish;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[13].Value = DBNull.Value;
			}
			if (home_village_lc1 != null)
			{
				this.Adapter.InsertCommand.Parameters[14].Value = home_village_lc1;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
			}
			if (religion != null)
			{
				this.Adapter.InsertCommand.Parameters[15].Value = religion;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
			}
			if (marital_status != null)
			{
				this.Adapter.InsertCommand.Parameters[16].Value = marital_status;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
			}
			if (partners_name != null)
			{
				this.Adapter.InsertCommand.Parameters[17].Value = partners_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[17].Value = DBNull.Value;
			}
			if (current_residence_district != null)
			{
				this.Adapter.InsertCommand.Parameters[18].Value = current_residence_district;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[18].Value = DBNull.Value;
			}
			if (current_residence_sub_county != null)
			{
				this.Adapter.InsertCommand.Parameters[19].Value = current_residence_sub_county;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[19].Value = DBNull.Value;
			}
			if (current_residence_parish != null)
			{
				this.Adapter.InsertCommand.Parameters[20].Value = current_residence_parish;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[20].Value = DBNull.Value;
			}
			if (current_residence_zone != null)
			{
				this.Adapter.InsertCommand.Parameters[21].Value = current_residence_zone;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[21].Value = DBNull.Value;
			}
			if (current_landlord_name != null)
			{
				this.Adapter.InsertCommand.Parameters[22].Value = current_landlord_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
			}
			if (father_name != null)
			{
				this.Adapter.InsertCommand.Parameters[23].Value = father_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
			}
			if (father_district != null)
			{
				this.Adapter.InsertCommand.Parameters[24].Value = father_district;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
			}
			if (father_county != null)
			{
				this.Adapter.InsertCommand.Parameters[25].Value = father_county;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[25].Value = DBNull.Value;
			}
			if (father_village != null)
			{
				this.Adapter.InsertCommand.Parameters[26].Value = father_village;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
			}
			if (father_zone != null)
			{
				this.Adapter.InsertCommand.Parameters[27].Value = father_zone;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
			}
			if (prev_employer_name != null)
			{
				this.Adapter.InsertCommand.Parameters[28].Value = prev_employer_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
			}
			if (prev_employer_address != null)
			{
				this.Adapter.InsertCommand.Parameters[29].Value = prev_employer_address;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[29].Value = DBNull.Value;
			}
			if (cause_of_departure != null)
			{
				this.Adapter.InsertCommand.Parameters[30].Value = cause_of_departure;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[30].Value = DBNull.Value;
			}
			if (tin_number != null)
			{
				this.Adapter.InsertCommand.Parameters[31].Value = tin_number;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[31].Value = DBNull.Value;
			}
			if (previous_salary != null)
			{
				this.Adapter.InsertCommand.Parameters[32].Value = previous_salary;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[32].Value = DBNull.Value;
			}
			if (!start_date.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[33].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[33].Value = start_date.Value;
			}
			if (institution_name != null)
			{
				this.Adapter.InsertCommand.Parameters[34].Value = institution_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[34].Value = DBNull.Value;
			}
			if (award_name != null)
			{
				this.Adapter.InsertCommand.Parameters[35].Value = award_name;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[35].Value = DBNull.Value;
			}
			if (!study_start_date.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[36].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[36].Value = study_start_date.Value;
			}
			if (!study_end_date.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[37].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[37].Value = study_end_date.Value;
			}
			if (refferees != null)
			{
				this.Adapter.InsertCommand.Parameters[38].Value = refferees;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[38].Value = DBNull.Value;
			}
			if (image_data != null)
			{
				this.Adapter.InsertCommand.Parameters[39].Value = image_data;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[39].Value = DBNull.Value;
			}
			ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
			if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			try
			{
				num = this.Adapter.InsertCommand.ExecuteNonQuery();
			}
			finally
			{
				if (previousConnectionState == ConnectionState.Closed)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return num;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(guard_profiles_dbDataSet1.Tbl_sg_profilesDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(guard_profiles_dbDataSet1 dataSet)
		{
			return this.Adapter.Update(dataSet, "Tbl_sg_profiles");
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[] { dataRow });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}
	}
}