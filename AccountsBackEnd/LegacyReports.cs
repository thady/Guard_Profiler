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
   public static class LegacyReports
    {
        #region Globals
       public static string station_code = string.Empty;
        public static string client_code = string.Empty;
        public static DateTime begin_date = DateTime.Now;
       public static DateTime end_date = DateTime.Now;
        public static string reportType = string.Empty;
        #endregion

        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        public static DataTable LoadDebtorsListing(string myQuery,string station_code,DateTime begin_date, DateTime end_date)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@station_code", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@station_code"].Value = station_code;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@begin_date", SqlDbType.Date);
                            cmd.Parameters["@begin_date"].Value = begin_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@end_date", SqlDbType.Date);
                            cmd.Parameters["@end_date"].Value = end_date;

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

        public static DataTable LoadIncomeandExpenditureReport(string myQuery, string station_code, DateTime begin_date, DateTime end_date)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@subpcode", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@subpcode"].Value = station_code;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@begin_date", SqlDbType.Date);
                            cmd.Parameters["@begin_date"].Value = begin_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@end_date", SqlDbType.Date);
                            cmd.Parameters["@end_date"].Value = end_date;

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

        public static DataTable LoadBranches(string myQuery)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;

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


        public static DataTable LoadClients(string myQuery,string station_code)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;


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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }


        public static DataTable LoadClientStatement(string myQuery, string client_code, DateTime begin_date, DateTime end_date)
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@client_code"].Value = client_code;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@begin_date", SqlDbType.Date);
                            cmd.Parameters["@begin_date"].Value = begin_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@end_date", SqlDbType.Date);
                            cmd.Parameters["@end_date"].Value = end_date;

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

        public static DataTable LoadLegacyAccountEntries(string myQuery,int year) 
        {
            DataTable dt = new DataTable();

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_AccountsLegacyReports", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@queryname", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@queryname"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@year", SqlDbType.Int);
                            cmd.Parameters["@year"].Value = year;

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
