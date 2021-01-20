using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace AccountsBackEnd
{
   public static class SubcidiaryAccount
    {
        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        #region variables
        public static string sub_id = string.Empty;
        public static string sub_code = string.Empty;
        public static string sub_title = string.Empty;
        public static string sub_category_id = string.Empty;
        public static decimal sub_opening_bal = 0;
        public static string nominal_acc_id = string.Empty;
        public static string debit_credit = string.Empty;
        public static bool active = true;
        public static string tel_contact = string.Empty;
        public static string email_adress = string.Empty;
        public static string adress = string.Empty;
        public static string branch_id = string.Empty;
        public static string usr_id_create = string.Empty;
        public static string usr_id_update = string.Empty;
        public static DateTime usr_date_create = DateTime.Now;
        public static DateTime usr_date_update = DateTime.Now;
        #endregion

        public static void save(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_subcidiary_accounts", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@sub_id"].Value = sub_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_code", SqlDbType.VarChar, 50);
                            cmd.Parameters["@sub_code"].Value = sub_code;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_title", SqlDbType.VarChar, 100);
                            cmd.Parameters["@sub_title"].Value = sub_title;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_category_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@sub_category_id"].Value = sub_category_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_opening_bal", SqlDbType.Decimal);
                            cmd.Parameters["@sub_opening_bal"].Value = sub_opening_bal;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nominal_acc_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@nominal_acc_id"].Value = nominal_acc_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@debit_credit", SqlDbType.VarChar, 50);
                            cmd.Parameters["@debit_credit"].Value = debit_credit;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@active", SqlDbType.Bit);
                            cmd.Parameters["@active"].Value = active;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@tel_contact", SqlDbType.VarChar, 50);
                            cmd.Parameters["@tel_contact"].Value = tel_contact;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@email_adress", SqlDbType.VarChar, 50);
                            cmd.Parameters["@email_adress"].Value = email_adress;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@adress", SqlDbType.VarChar, 500);
                            cmd.Parameters["@adress"].Value = adress;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@branch_id"].Value = branch_id;

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

        public static DataTable LoadList(string myQuery,string sub_code,string sub_category_id, string nominal_acc_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_subcidiary_accounts", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_code", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@sub_code"].Value = sub_code;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_category_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@sub_category_id"].Value = sub_category_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nominal_acc_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@nominal_acc_id"].Value = nominal_acc_id;

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

        public static DataTable LoadRecord(string myQuery, string sub_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_subcidiary_accounts", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@sub_id"].Value = sub_id;

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
