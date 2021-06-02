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
   public static class InvoiceManager
    {
        #region SQLConnection
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #endregion

        #region Variables
        public static string journal_entry_id = string.Empty;
        public static string cat_id = string.Empty;
        public static DateTime date = DateTime.Today;
        public static string reference_number = string.Empty;
        public static string cheque_number = string.Empty;
        public static string batch_id = string.Empty;
        public static string payee_desc = string.Empty;
        public static string entry_desc = string.Empty;
        public static decimal transaction_amt = 0;
        public static string dr_account = string.Empty;
        public static string cr_account = string.Empty;
        public static string sub_ledger_id = string.Empty;
        public static string sub_ledger_item_id = string.Empty;
        public static string sub_ledger_dr_cr = string.Empty;
        public static string transaction_month = string.Empty;
        public static int guard_count = 0;
        public static int guard_days_worked = 0;
        public static decimal client_rate = 0;
        public static bool record_audited = false;
        public static string audit_comment = string.Empty;
        public static string branch_id = string.Empty;
        public static bool is_on_hold = false;
        public static bool is_posted = false;
        public static string fy_id = string.Empty;
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
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_journal_Entry", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@journal_entry_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@journal_entry_id"].Value = journal_entry_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@cat_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@cat_id"].Value = cat_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@date", SqlDbType.Date);
                            cmd.Parameters["@date"].Value = date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@reference_number", SqlDbType.VarChar, 50);
                            cmd.Parameters["@reference_number"].Value = reference_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@cheque_number", SqlDbType.VarChar, 50);
                            cmd.Parameters["@cheque_number"].Value = cheque_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@batch_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@batch_id"].Value = batch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payee_desc", SqlDbType.VarChar, 300);
                            cmd.Parameters["@payee_desc"].Value = payee_desc;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@entry_desc", SqlDbType.VarChar, 1000);
                            cmd.Parameters["@entry_desc"].Value = entry_desc;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transaction_amt", SqlDbType.Decimal);
                            cmd.Parameters["@transaction_amt"].Value = transaction_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@dr_account", SqlDbType.VarChar, 50);
                            cmd.Parameters["@dr_account"].Value = dr_account;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@cr_account", SqlDbType.VarChar, 50);
                            cmd.Parameters["@cr_account"].Value = cr_account;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_ledger_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@sub_ledger_id"].Value = sub_ledger_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_ledger_item_id", SqlDbType.VarChar, 150);
                            cmd.Parameters["@sub_ledger_item_id"].Value = sub_ledger_item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_ledger_dr_cr", SqlDbType.VarChar, 50);
                            cmd.Parameters["@sub_ledger_dr_cr"].Value = sub_ledger_dr_cr;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transaction_month", SqlDbType.VarChar, 50);
                            cmd.Parameters["@transaction_month"].Value = transaction_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_count", SqlDbType.Int);
                            cmd.Parameters["@guard_count"].Value = guard_count;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_days_worked", SqlDbType.Int);
                            cmd.Parameters["@guard_days_worked"].Value = guard_days_worked;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@client_rate", SqlDbType.Decimal);
                            cmd.Parameters["@client_rate"].Value = client_rate;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@record_audited", SqlDbType.Bit);
                            cmd.Parameters["@record_audited"].Value = record_audited;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@audit_comment", SqlDbType.VarChar, 1000);
                            cmd.Parameters["@audit_comment"].Value = audit_comment;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@branch_id"].Value = branch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@fy_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@fy_id"].Value = fy_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@is_on_hold", SqlDbType.Bit);
                            cmd.Parameters["@is_on_hold"].Value = is_on_hold;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@is_posted", SqlDbType.Bit);
                            cmd.Parameters["@is_posted"].Value = is_posted;

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
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_journal_Entry", conn))
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

        public static DataTable LoadListingSearch(string myQuery, DateTime? date_from, DateTime? date_to, string reference_number, string cheque_number)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_journal_Entry", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@date_from", SqlDbType.Date);
                            cmd.Parameters["@date_from"].Value = date_from;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@date_to", SqlDbType.Date);
                            cmd.Parameters["@date_to"].Value = date_to;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@reference_number", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@reference_number"].Value = reference_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@cheque_number", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@cheque_number"].Value = cheque_number;

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

        public static DataTable LoadRecordDetails(string myQuery, string id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_journal_Entry", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@journal_entry_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@journal_entry_id"].Value = id;

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

        public static string LoadSubsidiaryAccountBranchID(string myQuery,string sub_ledger_item_id)
        {
            DataTable dt = new DataTable();
            string branchid = string.Empty;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Accounts_journal_Entry", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@sub_ledger_item_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@sub_ledger_item_id"].Value = sub_ledger_item_id;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;
                            (new SqlDataAdapter(cmd)).Fill(dt);
                            DataRow dtRow = dt.Rows[0];
                            branchid = dtRow["branch_id"].ToString();
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
            return branchid;
        }

    }
}
