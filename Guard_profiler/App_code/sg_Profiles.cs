using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class sg_Profiles
	{
		private static SqlConnection conn;

		private static SqlCommand cmd;

		static sg_Profiles()
		{
			sg_Profiles.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static void CHANGE_GUARD_NUMBER(string QueryName, string record_guid, string guard_number)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static int CHECK_IF_GUARD_NUMBER_IS_ASSIGNED(string myQuery, string guard_number)
		{
			DataTable dt = new DataTable();
			int count = 0;
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							count = dt.Rows.Count;
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return count;
		}

		public static void EXECUTE_GUARD_TRANSFER(string QueryName, string record_guid, string guard_number, string new_branch_name)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@new_branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@new_branch_name"].Value = new_branch_name;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static void INSERT_GUARD_TRANSFER_LOG(string QueryName, string record_guid, string guard_full_name, string previous_branch_name, string old_guard_number, string new_branch_name, string new_guard_number, string execute_user)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_full_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_full_name"].Value = guard_full_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@previous_branch_name"].Value = previous_branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@old_guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@old_guard_number"].Value = old_guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@new_branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@new_branch_name"].Value = new_branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@new_guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@new_guard_number"].Value = new_guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@transfered_by", SqlDbType.NVarChar, 100);
							cmd.Parameters["@transfered_by"].Value = execute_user;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static DataTable RETURN_GUARD_DETAILS(string myQuery, string record_guid)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable RETURN_OFFICER_LIST(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable RETURN_OFFICER_LIST_BY_GUARD_NUMBER(string myQuery, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							int count = dt.Rows.Count;
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable RETURN_SEARCH_RESULTS(string myQuery, string sg_full_name)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_search_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@sg_search_name"].Value = sg_full_name;

							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static void SAVE_NEW_SG_PROFILE(string QueryName, string guard_number, string sg_fname, string sg_lname, string phone, string branch, string position, string department, DateTime registered_date, string birth_place, DateTime dob, int age, string gender, string home_district, string home_county, string home_sub_county, string home_parish, string home_village_lc1, string religion, string marital_status, string partners_name, string current_residence_district, string current_residence_sub_county, string current_residence_parish, string current_residence_zone, string current_landlord_name, string father_name, string father_district, string father_county, string father_village, string father_zone, string prev_employer_name, string prev_employer_address, string cause_of_departure, string tin_number, string previous_salary, DateTime start_date, string institution_name, string award_name, DateTime study_start_date, DateTime study_end_date, string refferees, string guard_status, string bank_name, string account_number, string nssf_number)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_fname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_fname"].Value = sg_fname;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_lname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_lname"].Value = sg_lname;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 150);
							cmd.Parameters["@phone"].Value = phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 50);
							cmd.Parameters["@branch"].Value = branch;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@position", SqlDbType.NVarChar, 50);
							cmd.Parameters["@position"].Value = position;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@department", SqlDbType.NVarChar, 50);
							cmd.Parameters["@department"].Value = department;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@registered_date", SqlDbType.Date);
							cmd.Parameters["@registered_date"].Value = registered_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@birth_place", SqlDbType.NVarChar, 50);
							cmd.Parameters["@birth_place"].Value = birth_place;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@dob", SqlDbType.Date);
							cmd.Parameters["@dob"].Value = dob;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@age", SqlDbType.Int);
							cmd.Parameters["@age"].Value = age;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 20);
							cmd.Parameters["@gender"].Value = gender;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_district", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_district"].Value = home_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_county"].Value = home_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_sub_county", SqlDbType.NVarChar, 60);
							cmd.Parameters["@home_sub_county"].Value = home_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_parish", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_parish"].Value = home_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village_lc1", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_village_lc1"].Value = home_village_lc1;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@religion", SqlDbType.NVarChar, 50);
							cmd.Parameters["@religion"].Value = religion;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@marital_status", SqlDbType.NVarChar, 100);
							cmd.Parameters["@marital_status"].Value = marital_status;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partners_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@partners_name"].Value = partners_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_district", SqlDbType.NVarChar, 100);
							cmd.Parameters["@current_residence_district"].Value = current_residence_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_sub_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_sub_county"].Value = current_residence_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_parish", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_parish"].Value = current_residence_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_zone", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_zone"].Value = current_residence_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_landlord_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@current_landlord_name"].Value = current_landlord_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_name"].Value = father_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_district", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_district"].Value = father_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_county", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_county"].Value = father_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_village", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_village"].Value = father_village;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_zone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_zone"].Value = father_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@prev_employer_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@prev_employer_name"].Value = prev_employer_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@prev_employer_address", SqlDbType.NText);
							cmd.Parameters["@prev_employer_address"].Value = prev_employer_address;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@cause_of_departure", SqlDbType.NVarChar, 100);
							cmd.Parameters["@cause_of_departure"].Value = cause_of_departure;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@tin_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@tin_number"].Value = tin_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_salary", SqlDbType.NText);
							cmd.Parameters["@previous_salary"].Value = previous_salary;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@start_date", SqlDbType.Date);
							cmd.Parameters["@start_date"].Value = start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@institution_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@institution_name"].Value = institution_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@award_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@award_name"].Value = award_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@study_start_date", SqlDbType.Date);
							cmd.Parameters["@study_start_date"].Value = study_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@study_end_date", SqlDbType.Date);
							cmd.Parameters["@study_end_date"].Value = study_end_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@refferees", SqlDbType.NText);
							cmd.Parameters["@refferees"].Value = refferees;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_status", SqlDbType.NVarChar);
							cmd.Parameters["@guard_status"].Value = guard_status;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_name", SqlDbType.NVarChar);
							cmd.Parameters["@bank_name"].Value = bank_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@account_number", SqlDbType.NVarChar);
							cmd.Parameters["@account_number"].Value = account_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nssf_number", SqlDbType.NVarChar);
							cmd.Parameters["@nssf_number"].Value = nssf_number;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static DataTable SEARCH_GUARDS_BY_BRANCH(string myQuery, string branch_name)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch"].Value = branch_name;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							int count = dt.Rows.Count;
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable SELECT_GUARD_F_L_NAMES(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
			return dt;
		}

		public static void UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS(string QueryName, string record_guid)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static void UPDATE_GUARD_DETAILS(string QueryName, string record_guid, string sg_fname, string sg_lname, string phone, string branch, string position, string department, DateTime registered_date, string birth_place, DateTime dob, int age, string gender, string home_district, string home_county, string home_sub_county, string home_parish, string home_village_lc1, string religion, string marital_status, string partners_name, string current_residence_district, string current_residence_sub_county, string current_residence_parish, string current_residence_zone, string current_landlord_name, string father_name, string father_district, string father_county, string father_village, string father_zone, string prev_employer_name, string prev_employer_address, string cause_of_departure, string tin_number, string previous_salary, DateTime start_date, string institution_name, string award_name, DateTime study_start_date, DateTime study_end_date, string refferees, string guard_status, string bank_name, string account_number, string nssf_number)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_fname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_fname"].Value = sg_fname;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_lname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_lname"].Value = sg_lname;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 150);
							cmd.Parameters["@phone"].Value = phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 50);
							cmd.Parameters["@branch"].Value = branch;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@position", SqlDbType.NVarChar, 50);
							cmd.Parameters["@position"].Value = position;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@department", SqlDbType.NVarChar, 50);
							cmd.Parameters["@department"].Value = department;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@registered_date", SqlDbType.Date);
							cmd.Parameters["@registered_date"].Value = registered_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@birth_place", SqlDbType.NVarChar, 50);
							cmd.Parameters["@birth_place"].Value = birth_place;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@dob", SqlDbType.Date);
							cmd.Parameters["@dob"].Value = dob;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@age", SqlDbType.Int);
							cmd.Parameters["@age"].Value = age;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 20);
							cmd.Parameters["@gender"].Value = gender;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_district", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_district"].Value = home_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_county"].Value = home_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_sub_county", SqlDbType.NVarChar, 60);
							cmd.Parameters["@home_sub_county"].Value = home_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_parish", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_parish"].Value = home_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village_lc1", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_village_lc1"].Value = home_village_lc1;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@religion", SqlDbType.NVarChar, 50);
							cmd.Parameters["@religion"].Value = religion;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@marital_status", SqlDbType.NVarChar, 100);
							cmd.Parameters["@marital_status"].Value = marital_status;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partners_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@partners_name"].Value = partners_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_district", SqlDbType.NVarChar, 100);
							cmd.Parameters["@current_residence_district"].Value = current_residence_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_sub_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_sub_county"].Value = current_residence_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_parish", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_parish"].Value = current_residence_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_residence_zone", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_residence_zone"].Value = current_residence_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_landlord_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@current_landlord_name"].Value = current_landlord_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_name"].Value = father_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_district", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_district"].Value = father_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_county", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_county"].Value = father_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_village", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_village"].Value = father_village;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_zone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_zone"].Value = father_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@prev_employer_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@prev_employer_name"].Value = prev_employer_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@prev_employer_address", SqlDbType.NText);
							cmd.Parameters["@prev_employer_address"].Value = prev_employer_address;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@cause_of_departure", SqlDbType.NVarChar, 100);
							cmd.Parameters["@cause_of_departure"].Value = cause_of_departure;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@tin_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@tin_number"].Value = tin_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_salary", SqlDbType.NText);
							cmd.Parameters["@previous_salary"].Value = previous_salary;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@start_date", SqlDbType.Date);
							cmd.Parameters["@start_date"].Value = start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@institution_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@institution_name"].Value = institution_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@award_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@award_name"].Value = award_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@study_start_date", SqlDbType.Date);
							cmd.Parameters["@study_start_date"].Value = study_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@study_end_date", SqlDbType.Date);
							cmd.Parameters["@study_end_date"].Value = study_end_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@refferees", SqlDbType.NText);
							cmd.Parameters["@refferees"].Value = refferees;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_status", SqlDbType.NVarChar);
							cmd.Parameters["@guard_status"].Value = guard_status;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_name", SqlDbType.NVarChar);
							cmd.Parameters["@bank_name"].Value = bank_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@account_number", SqlDbType.NVarChar);
							cmd.Parameters["@account_number"].Value = account_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nssf_number", SqlDbType.NVarChar);
							cmd.Parameters["@nssf_number"].Value = nssf_number;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static void UPDATE_GUARD_FIRST_LAST_NAME(string QueryName, int auto_id, string sg_fname, string sg_lname)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@auto_id", SqlDbType.Int);
							cmd.Parameters["@auto_id"].Value = auto_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_fname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_fname"].Value = sg_fname;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@sg_lname", SqlDbType.NVarChar, 50);
							cmd.Parameters["@sg_lname"].Value = sg_lname;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = sg_Profiles.conn;
			}
		}

		public static void UPDATE_IMAGES_FROM_ACCESS(string myQuery, string record_guid, byte[] imageBinary)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@image_data", SqlDbType.VarBinary);
							cmd.Parameters["@image_data"].Value = imageBinary;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();
							if (conn.State != ConnectionState.Closed)
							{
								conn.Close();
							}
						}
					}
				}
				catch (SqlException sqlException)
				{
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				if (sg_Profiles.conn.State == ConnectionState.Open)
				{
					sg_Profiles.conn.Close();
				}
			}
		}
	}
}