using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class Guard_deployment
	{
		private static SqlConnection conn;
        public static DateTime deploy_start_date = DateTime.Today;
        public static DateTime deploy_end_date = DateTime.Today;
		static Guard_deployment()
		{
			Guard_deployment.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static int check_if_deployment_date_is_public_holiday(string myQuery, DateTime deploy_date)
		{
			DataTable dataTable = new DataTable();
			int count = 0;
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
							cmd.Parameters["@deploy_date"].Value = deploy_date;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							count = (int)cmd.ExecuteScalar();
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return count;
		}

		public static int check_if_deployment_period_already_exists(string myQuery, DateTime dt_start_date, DateTime dt_end_date)
		{
			DataTable dataTable = new DataTable();
			int count = 0;
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = dt_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = dt_end_date;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							count = (int)cmd.ExecuteScalar();
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return count;
		}

		public static void delete_guard_marked_as_absent_from_deployment_list_per_date(string QueryName, string record_guid)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static void delete_public_holiday(string QueryName, string record_guid)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static DataTable return_deployment_record_details_by_deploy_details_id(string myQuery, int deploy_details_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_details_id", SqlDbType.Int);
							cmd.Parameters["@deploy_details_id"].Value = deploy_details_id;
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable Return_guard_shift_types(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable Return_list_of_deployment_periods(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

        public static DataTable select_my_active_deployment_period(string myQuery,string user_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@user_id"].Value = user_id;

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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
            return dt;
        }

        public static void save_update_my_current_deployment_period(string myQuery,int deploy_id,string user_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
                            cmd.Parameters["@deploy_id"].Value = deploy_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@user_id"].Value = user_id;

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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
        }

        public static DataTable Return_list_of_deployments_by_deploy_id(string myQuery, int deploy_period_id, string branch_name, string guard_number,string user_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
							cmd.Parameters["@deploy_id"].Value = deploy_period_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch_name;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@user_id"].Value = user_id;

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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_list_of_public_holidays(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

		public static void Save_new_deployment_period(string QueryName, DateTime deploy_start_date, DateTime deploy_end_date, bool active_deployment)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@active_deployment", SqlDbType.Bit);
							cmd.Parameters["@active_deployment"].Value = active_deployment;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static void Save_new_deployment_record(string QueryName, DateTime deploy_start_date, DateTime deploy_end_date, string created_by, string guard_number, DateTime deploy_date, string deploy_type, string branch_name, string client_code, string client_location, string guard_name, string firearm_serial, int number_of_ammunitions, string shift_type, bool is_leave_day_for_guard, bool is_public_holiday, bool is_weekend,string user_id)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@created_by", SqlDbType.NVarChar, 50);
							cmd.Parameters["@created_by"].Value = created_by;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
							cmd.Parameters["@deploy_date"].Value = deploy_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_type", SqlDbType.NVarChar, 50);
							cmd.Parameters["@deploy_type"].Value = deploy_type;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
							cmd.Parameters["@client_code"].Value = client_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_location", SqlDbType.NVarChar, 100);
							cmd.Parameters["@client_location"].Value = client_location;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_name"].Value = guard_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@firearm_serial", SqlDbType.NVarChar, 50);
							cmd.Parameters["@firearm_serial"].Value = firearm_serial;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@number_of_ammunitions", SqlDbType.Int);
							cmd.Parameters["@number_of_ammunitions"].Value = number_of_ammunitions;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@shift_type", SqlDbType.NVarChar, 50);
							cmd.Parameters["@shift_type"].Value = shift_type;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_leave_day_for_guard", SqlDbType.Bit);
							cmd.Parameters["@is_leave_day_for_guard"].Value = is_leave_day_for_guard;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_public_holiday", SqlDbType.Bit);
							cmd.Parameters["@is_public_holiday"].Value = is_public_holiday;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_weekend", SqlDbType.Bit);
							cmd.Parameters["@is_weekend"].Value = is_weekend;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@user_id"].Value = user_id;

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
                    string err = guard_name;
                    string query = QueryName;
                    string guard_n = guard_number;
					throw new Exception(sqlException.ToString());
				}
			}
			finally
			{
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

        public static void Save_deployment_schedule(DateTime deploy_date, int deploy_id,string guard_number)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_schedule", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
                            cmd.Parameters["@deploy_date"].Value = deploy_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
                            cmd.Parameters["@deploy_id"].Value = deploy_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar);
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
                SqlConnection sqlConnection = Guard_deployment.conn;
            }
        }

        public static void save_new_public_holiday(string QueryName, int deployment_period_id, string public_holiday_name, DateTime public_holiday_date)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
							cmd.Parameters["@deploy_id"].Value = deployment_period_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@public_holiday_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@public_holiday_name"].Value = public_holiday_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@public_holiday_date", SqlDbType.Date);
							cmd.Parameters["@public_holiday_date"].Value = public_holiday_date;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static void Save_update_guard_additional_deployment_data(string QueryName, string guard_number, DateTime deploy_start_date, int guard_auto_id, int days_worked, int over_time_days_worked, int days_absent, float total_advance_in_month, float total_arrears_in_month, float special_cash_additions, float residential_cost, float uniform_costs, float local_service_tax_cost, float other_penalties_cost, float other_refunds, int deploy_period_id)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
							cmd.Parameters["@guard_auto_id"].Value = guard_auto_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@days_worked", SqlDbType.Int);
							cmd.Parameters["@days_worked"].Value = days_worked;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@over_time_days_worked", SqlDbType.Int);
							cmd.Parameters["@over_time_days_worked"].Value = over_time_days_worked;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@days_absent", SqlDbType.Int);
							cmd.Parameters["@days_absent"].Value = days_absent;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_advance_in_month", SqlDbType.Float);
							cmd.Parameters["@total_advance_in_month"].Value = total_advance_in_month;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_arrears_in_month", SqlDbType.Float);
							cmd.Parameters["@total_arrears_in_month"].Value = total_arrears_in_month;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@special_cash_additions", SqlDbType.Float);
							cmd.Parameters["@special_cash_additions"].Value = special_cash_additions;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@residential_cost", SqlDbType.Float);
							cmd.Parameters["@residential_cost"].Value = residential_cost;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@uniform_costs", SqlDbType.Float);
							cmd.Parameters["@uniform_costs"].Value = uniform_costs;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@local_service_tax_cost", SqlDbType.Float);
							cmd.Parameters["@local_service_tax_cost"].Value = local_service_tax_cost;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@other_penalties_cost", SqlDbType.Float);
							cmd.Parameters["@other_penalties_cost"].Value = other_penalties_cost;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@other_refunds", SqlDbType.Float);
							cmd.Parameters["@other_refunds"].Value = other_refunds;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static DataTable Select_active_deployment_period(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

        public static DataTable Select_accounts_active_deployment_period(string myQuery,int deploy_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
                            cmd.Parameters["@deploy_period_id"].Value = deploy_id;

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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
            return dt;
        }

        public static DataTable select_list_of_guards_by_branch_and_date_for_batch_deployment(string myQuery, string branch_name,string user_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 200);
							cmd.Parameters["@QueryName"].Value = myQuery;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@branch_name"].Value = branch_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@user_id"].Value = user_id;

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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_list_of_guards_by_branch_and_date_for_selected_date(string myQuery, string branch_name, DateTime deploy_date)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 200);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@branch_name"].Value = branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
							cmd.Parameters["@deploy_date"].Value = deploy_date;
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
				if (Guard_deployment.conn.State == ConnectionState.Open)
				{
					Guard_deployment.conn.Close();
				}
			}
			return dt;
		}

        public static DataTable select_list_of_deployed_guards_by_guard_number(string myQuery, string guard_number)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 200);
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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
            return dt;
        }

  //      public static DataTable select_list_of_guards_for_additional_deployment_data_entry(string myQuery, string branch_name, string guard_number, DateTime deploy_start_date, DateTime deploy_end_date,string user_id)
		//{
		//	DataTable dt = new DataTable();
  //          SqlDataAdapter Adapt;
  //          SqlDataReader rdr;

		//		try
		//		{
		//			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
		//			{
		//				using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
		//				{
		//					cmd.CommandTimeout = 3600;
		//					cmd.CommandType = CommandType.StoredProcedure;
		//					cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
		//					cmd.Parameters["@QueryName"].Value = myQuery;

		//					cmd.CommandType = CommandType.StoredProcedure;
		//					cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
		//					cmd.Parameters["@branch_name"].Value = branch_name;

		//					cmd.CommandType = CommandType.StoredProcedure;
		//					cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
		//					cmd.Parameters["@guard_number"].Value = guard_number;

		//					cmd.CommandType = CommandType.StoredProcedure;
		//					cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
		//					cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;

		//					cmd.CommandType = CommandType.StoredProcedure;
		//					cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
		//					cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;

  //                          cmd.CommandType = CommandType.StoredProcedure;
  //                          cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 50);
  //                          cmd.Parameters["@user_id"].Value = user_id;

  //                          if (conn.State == ConnectionState.Closed)
		//					{
		//						conn.Open();
		//					}
		//					 cmd.Connection = conn;
  //                           rdr = cmd.ExecuteReader();
  //                           dt.Load(rdr);
  //                          //Adapt = new SqlDataAdapter(cmd);
  //                          //Adapt.Fill(dt);

  //                          cmd.Parameters.Clear();
		//					if (conn.State != ConnectionState.Closed)
		//					{
		//						conn.Close();
		//					}
		//				}
		//			}
		//		}
		//		catch (SqlException sqlException)
		//		{
		//			throw new Exception(sqlException.ToString());
		//		}
  //              finally
  //              {
  //                  if (Guard_deployment.conn.State == ConnectionState.Open)
  //                  {
  //                      Guard_deployment.conn.Close();
  //                  }
  //              }
  //              return dt;
		//}

        public static DataTable select_list_of_guards_for_additional_deployment_data_entry(string branch_name, string guard_number, DateTime deploy_start_date, DateTime deploy_end_date, string user_id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            SqlDataReader rdr;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                    {
                        cmd.CommandTimeout = 3600;
                        cmd.CommandType = CommandType.Text;
                        string strSQL = @"--first check if the current deployment month has 31 days to get off the extra day as extra time
	                        DECLARE @xtra_31st_day_of_month AS int = datediff(day, dateadd(day, 1-day('{0}'), '{0}'),
                                      dateadd(month, 1, dateadd(day, 1-day('{0}'), '{0}')));
	                        DECLARE @extra_overtime_day AS int = 0
	                        DECLARE @_deploy_id AS int = 0 
	                        SET @_deploy_id =  (SELECT deploy_period_id FROM Tbl_user_deploy_period_mapping hh WHERE user_id = '{1}')
	                        IF @xtra_31st_day_of_month = 31
	                        BEGIN
	                        SET @extra_overtime_day = 1
                        END
	                        ;With Cte_over_time_days AS(
		                        SELECT guard_number,COUNT(guard_number) AS overtime
		                        FROM Tbl_guard_deployment_summary_details 
	                            WHERE (is_public_holiday = 1 OR is_weekend = 1)
		                        AND deploy_main_id = @_deploy_id
		                        AND ('{2}' IS NULL OR branch_name = '{2}')
		                        AND ('{3}' IS NULL OR guard_number LIKE '%' + '{3}' + '%')
		                        GROUP BY guard_number
	                        )
	                        SELECT D.branch_name AS branch, P.auto_id,P.guard_number,P.full_name,S.total_days_worked as days_worked,ISNULL(A.over_time_days_worked,Cte_over_time_days.overtime + @extra_overtime_day) AS overtime,A.payment_month,
	                        (30 - S.total_days_worked) As days_absent,
	                        A.total_advance_in_month,A.total_arrears_in_month,A.special_cash_additions,A.residential_cost,A.uniform_costs,A.local_service_tax_cost,A.other_penalties_cost,
	                        A.other_refunds
	                        FROM Tbl_sg_profiles P
	                        LEFT JOIN Tbl_guard_deployment_summary_details D ON P.guard_number = D.guard_number
	                        LEFT JOIN Cte_over_time_days ON P.guard_number = Cte_over_time_days.guard_number
	                        LEFT JOIN Tbl_guard_deployment_summary_additional_information A ON (D.guard_number = A.guard_number AND D.deploy_main_id = A.deploy_period_id)
	                        LEFT JOIN TblDeployment_schedule S ON (P.auto_id = S.guard_auto_id AND S.deploy_id = @_deploy_id)
	                        WHERE  D.deploy_date >= '{0}' AND D.deploy_date <= '{4}'
	                        AND D.deploy_main_id = @_deploy_id
	                        AND ('{2}' IS NULL OR '{2}' = '' OR D.branch_name = '{2}')
	                        AND ('{2}' IS NULL OR '{2}' = '' OR D.branch_name = '{2}')
	                        AND ('{3}' IS NULL OR '{3}' = '' OR D.guard_number LIKE '%' + '{3}' + '%') 
	                        --AND D.guard_number = COALESCE(D.guard_number,@guard_number)
	                        GROUP BY D.branch_name, P.auto_id,P.guard_number,P.full_name,S.total_days_worked,ISNULL(A.over_time_days_worked,Cte_over_time_days.overtime + @extra_overtime_day),payment_month,A.total_advance_in_month,
	                        A.total_arrears_in_month,A.special_cash_additions,A.residential_cost,A.uniform_costs,A.local_service_tax_cost,A.other_penalties_cost,
	                        A.other_refunds
	                        ORDER BY (CAST(SUBSTRING(P.guard_number,CHARINDEX('.',P.guard_number)+1,LEN(P.guard_number))
	                        AS INT)) ASC";
                        strSQL = string.Format(strSQL,deploy_start_date,user_id,branch_name,guard_number,deploy_end_date);
                        cmd.CommandText = strSQL;

                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        cmd.Connection = conn;
                        rdr = cmd.ExecuteReader();
                        dt.Load(rdr);
                        //Adapt = new SqlDataAdapter(cmd);
                        //Adapt.Fill(dt);

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
            finally
            {
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
            return dt;
        }

        public static void select_deployment_date_by_deploy_id(string myQuery, int deploy_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
                            cmd.Parameters["@deploy_id"].Value = deploy_id;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;
                            (new SqlDataAdapter(cmd)).Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtRow = dt.Rows[0];
                                deploy_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
                                deploy_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
                            }

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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
        }

        public static void Set_active_deployment(string QueryName, int deploy_id, bool active_deployment)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
							cmd.Parameters["@deploy_id"].Value = deploy_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@active_deployment", SqlDbType.Bit);
							cmd.Parameters["@active_deployment"].Value = active_deployment;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

        public static int check_if_guard_already_deployed_by_date(string QueryName, string guard_number, DateTime deploy_date)
        {
            int count = 0;

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = QueryName;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
                            cmd.Parameters["@guard_auto_id"].Value = ReturnGuardAutoID(guard_number);

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
                            cmd.Parameters["@deploy_date"].Value = deploy_date; 
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            count = (int)cmd.ExecuteScalar();
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
                conn.Close();
            }

            return count;
        }

        public static int ReturnGuardAutoID(string guard_number)
        {
            DataTable dt = new DataTable();
            int guard_auto_id = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT auto_id FROM Tbl_sg_profiles WHERE guard_number = '"+ guard_number +"'", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.Text;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;
                            (new SqlDataAdapter(cmd)).Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtRow = dt.Rows[0];
                                guard_auto_id = Convert.ToInt32( dtRow["auto_id"]);
                            }
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
                if (Guard_deployment.conn.State == ConnectionState.Open)
                {
                    Guard_deployment.conn.Close();
                }
            }
            return guard_auto_id;
        }


        public static void update_deployment_record_single_deploy(string QueryName, int deploy_details_id, DateTime deploy_start_date, DateTime deploy_end_date, string created_by, string guard_number, DateTime deploy_date, string deploy_type, string branch_name, string client_code, string client_location, string guard_name, string firearm_serial, int number_of_ammunitions, string shift_type, bool is_leave_day_for_guard, bool is_public_holiday, bool is_weekend,string user_id)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_details_id", SqlDbType.Int);
							cmd.Parameters["@deploy_details_id"].Value = deploy_details_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@created_by", SqlDbType.NVarChar, 50);
							cmd.Parameters["@created_by"].Value = created_by;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
							cmd.Parameters["@deploy_date"].Value = deploy_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_type", SqlDbType.NVarChar, 50);
							cmd.Parameters["@deploy_type"].Value = deploy_type;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
							cmd.Parameters["@client_code"].Value = client_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_location", SqlDbType.NVarChar, 100);
							cmd.Parameters["@client_location"].Value = client_location;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_name"].Value = guard_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@firearm_serial", SqlDbType.NVarChar, 50);
							cmd.Parameters["@firearm_serial"].Value = firearm_serial;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@number_of_ammunitions", SqlDbType.Int);
							cmd.Parameters["@number_of_ammunitions"].Value = number_of_ammunitions;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@shift_type", SqlDbType.NVarChar, 50);
							cmd.Parameters["@shift_type"].Value = shift_type;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_leave_day_for_guard", SqlDbType.Bit);
							cmd.Parameters["@is_leave_day_for_guard"].Value = is_leave_day_for_guard;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_public_holiday", SqlDbType.Bit);
							cmd.Parameters["@is_public_holiday"].Value = is_public_holiday;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_weekend", SqlDbType.Bit);
							cmd.Parameters["@is_weekend"].Value = is_weekend;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@user_id"].Value = user_id;

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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static void Update_guard_deployment_record(string QueryName, string record_guid, string client_code, string client_location, string firearm_serial, int number_of_ammunitions, string shift_type, bool is_leave_day_for_guard)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
							cmd.Parameters["@client_code"].Value = client_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_location", SqlDbType.NVarChar, 100);
							cmd.Parameters["@client_location"].Value = client_location;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@firearm_serial", SqlDbType.NVarChar, 50);
							cmd.Parameters["@firearm_serial"].Value = firearm_serial;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@number_of_ammunitions", SqlDbType.Int);
							cmd.Parameters["@number_of_ammunitions"].Value = number_of_ammunitions;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@shift_type", SqlDbType.NVarChar, 50);
							cmd.Parameters["@shift_type"].Value = shift_type;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_leave_day_for_guard", SqlDbType.Bit);
							cmd.Parameters["@is_leave_day_for_guard"].Value = is_leave_day_for_guard;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}

		public static void update_public_holiday_details(string QueryName, string record_guid, string public_holiday_name, DateTime public_holiday_date)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@public_holiday_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@public_holiday_name"].Value = public_holiday_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@public_holiday_date", SqlDbType.Date);
							cmd.Parameters["@public_holiday_date"].Value = public_holiday_date;
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
				SqlConnection sqlConnection = Guard_deployment.conn;
			}
		}
	}
}