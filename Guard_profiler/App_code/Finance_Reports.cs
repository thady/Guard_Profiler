using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal class Finance_Reports
	{
		private static SqlConnection conn;

		static Finance_Reports()
		{
			Finance_Reports.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public Finance_Reports()
		{
		}

		public static DataTable select_bank_payment_report(string myQuery, string station_name, int deploy_period_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_name", SqlDbType.NVarChar, 500);
							cmd.Parameters["@station_name"].Value = station_name;
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
				if (Finance_Reports.conn.State == ConnectionState.Open)
				{
					Finance_Reports.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_client_guard_mapping_report(string myQuery, string client_code, DateTime datefrom, DateTime dateto)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 10);
							cmd.Parameters["@client_code"].Value = client_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date_from", SqlDbType.Date);
							cmd.Parameters["@deploy_date_from"].Value = datefrom;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date_to", SqlDbType.Date);
							cmd.Parameters["@deploy_date_to"].Value = dateto;
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
				if (Finance_Reports.conn.State == ConnectionState.Open)
				{
					Finance_Reports.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_guard_client_mapping_report(string myQuery, string guard_number, DateTime datefrom, DateTime dateto)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 20);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date_from", SqlDbType.Date);
							cmd.Parameters["@deploy_date_from"].Value = datefrom;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_date_to", SqlDbType.Date);
							cmd.Parameters["@deploy_date_to"].Value = dateto;
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
				if (Finance_Reports.conn.State == ConnectionState.Open)
				{
					Finance_Reports.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_guard_payroll_summary_details_by_station(string myQuery, int deploy_period_id, string station_code, string station_name,string guard_rank)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
						{
							cmd.CommandTimeout = 3600;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_code", SqlDbType.NVarChar, 100);
							cmd.Parameters["@station_code"].Value = station_code;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@station_name"].Value = station_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_rank", SqlDbType.NVarChar, 10);
                            cmd.Parameters["@guard_rank"].Value = guard_rank;

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
				if (Finance_Reports.conn.State == ConnectionState.Open)
				{
					Finance_Reports.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_local_service_tax_nssf_andpaye_report(string myQuery, string station_name, string station_code, int deploy_period_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_name", SqlDbType.NVarChar, 500);
							cmd.Parameters["@station_name"].Value = station_name;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_code", SqlDbType.NVarChar, 50);
							cmd.Parameters["@station_code"].Value = station_code;

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
				if (Finance_Reports.conn.State == ConnectionState.Open)
				{
					Finance_Reports.conn.Close();
				}
			}
			return dt;
		}

        public static DataTable select_guard_deployment_schedule_report(string myQuery, string station_name, int deploy_period_id)
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
                            cmd.Parameters["@deploy_id"].Value = deploy_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 500);
                            cmd.Parameters["@branch_name"].Value = station_name;

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
                if (Finance_Reports.conn.State == ConnectionState.Open)
                {
                    Finance_Reports.conn.Close();
                }
            }
            return dt;
        }

        public static DataTable select_client_billing_report(string myQuery, string station_name, int deploy_period_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_report_queries", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
                            cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@station_name", SqlDbType.NVarChar, 500);
                            cmd.Parameters["@station_name"].Value = station_name;

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
                if (Finance_Reports.conn.State == ConnectionState.Open)
                {
                    Finance_Reports.conn.Close();
                }
            }
            return dt;
        }
    }
}