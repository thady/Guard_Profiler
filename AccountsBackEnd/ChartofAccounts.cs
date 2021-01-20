﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AccountsBackEnd
{
    public static class ChartofAccounts
    {
        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        #region Variables
        public static string acc_id = string.Empty;
        public static string acc_type_id = string.Empty;
        public static string  acc_number = string.Empty;
        public static string bank = string.Empty;
        public static string acc_name = string.Empty;
        public static decimal opening_bal = 0;
        public static string debit_credit = string.Empty;
        public static string branch_id = string.Empty;
        public static string usr_id_create = string.Empty;
        public static string usr_id_update = string.Empty;
        public static DateTime usr_date_create = DateTime.Now;
        public static DateTime usr_date_update = DateTime.Now;
        #endregion


        #region save
        public static void save(string myQuery)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Chart_of_accounts", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@acc_id"].Value = acc_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_type_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@acc_type_id"].Value = acc_type_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_number", SqlDbType.VarChar, 50);
                            cmd.Parameters["@acc_number"].Value = acc_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bank", SqlDbType.VarChar, 50);
                            cmd.Parameters["@bank"].Value = bank;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@acc_name", SqlDbType.VarChar, 50);
                            cmd.Parameters["@acc_name"].Value = acc_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@opening_bal", SqlDbType.Decimal);
                            cmd.Parameters["@opening_bal"].Value = opening_bal;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@debit_credit", SqlDbType.VarChar, 50);
                            cmd.Parameters["@debit_credit"].Value = debit_credit;

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
        #endregion
        #region LoadListing
        public static DataTable LoadListing(string myQuery) 
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_Chart_of_accounts", conn))
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
        #endregion
    }
}
