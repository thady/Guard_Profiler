using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccountsBackEnd
{
    public static class Lookups
    {
        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        #region Accounts_lst_account_type
        public static string acc_type_id = string.Empty;
        public static string  acc_type_number = string.Empty;
        public static string  acc_type_name = string.Empty;
        public static string  active = string.Empty;
        public static string report_id = string.Empty;
        public static string  usr_id_create = string.Empty;
        public static string  usr_id_update = string.Empty;
        public static DateTime usr_date_create = DateTime.Now;
        public static DateTime usr_date_update = DateTime.Now;
        #endregion

        #region LoadLookup
        public static DataTable LoadLookup(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Lookups", conn))
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }

        public static DataTable LoadSubsidiaryAccountByCategory(string myQuery,string sub_category_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Lookups", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_category_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@sub_category_id"].Value = sub_category_id;

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
        #region save
        public static void save_Accounts_lst_account_type(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Lookups", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_type_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@acc_type_id"].Value = acc_type_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_type_number", SqlDbType.VarChar,50);
                            cmd.Parameters["@acc_type_number"].Value = acc_type_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_type_name", SqlDbType.VarChar, 50);
                            cmd.Parameters["@acc_type_name"].Value = acc_type_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@active", SqlDbType.VarChar, 1);
                            cmd.Parameters["@active"].Value = active;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@report_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@report_id"].Value = report_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_date_create", SqlDbType.Date);
                            cmd.Parameters["@usr_date_create"].Value = usr_date_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_date_update", SqlDbType.Date);
                            cmd.Parameters["@usr_date_update"].Value = usr_date_update;

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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        #endregion
    }
}
