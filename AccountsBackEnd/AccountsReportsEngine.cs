using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AccountsBackEnd
{
    public static class AccountsReportsEngine
    {
        #region Globals
        public static string station_code = string.Empty;
        public static string client_id = string.Empty;
        public static string branch = string.Empty;
        public static DateTime begin_date = DateTime.Now;
        public static DateTime end_date = DateTime.Now;
        public static DateTime report_date = DateTime.Now;
        public static string reportName = string.Empty;
        #endregion

        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        #region Invoices
        public static DataTable LoadClientListing(string myQuery)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Reports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@reportName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@reportName"].Value = myQuery;

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

        public static DataTable LoadInvoiceReport(string myQuery,string client_id,DateTime report_date )
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Reports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@reportName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@reportName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@client_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@client_id"].Value = client_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@report_date", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@report_date"].Value = report_date;

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


        public static DataTable LoadAgedDebtorsReport(string myQuery, DateTime start_date,DateTime end_date,string branch)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Reports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@reportName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@reportName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@start_date", SqlDbType.Date);
                            cmd.Parameters["@start_date"].Value = start_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@end_date", SqlDbType.Date);
                            cmd.Parameters["@end_date"].Value = end_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@branch_id"].Value = branch;

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
        #endregion
    }
}
