using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Guard_profiler.App_code
{
   public static class StaffPayrollReports
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        public static string reportType = string.Empty;
        public static int _payment_period_id = -1;
        public static string _branch_id = string.Empty;
        public static string _payment_month = string.Empty;
        public static string branch_name = string.Empty;
        public static string bank_name = string.Empty;

        public static DataTable select_staff_payroll(string myQuery,int payment_period_id,string branch_id,string payment_month)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_payroll_report_queries", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@branch_id"].Value = branch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }


        public static DataTable select_staff_payroll_summary(string myQuery, int payment_period_id, string branch_id, string payment_month)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_payroll_report_queries", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@branch_id"].Value = branch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}
