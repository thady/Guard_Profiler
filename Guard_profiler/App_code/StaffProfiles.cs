using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Guard_profiler.App_code
{
    public static class StaffProfiles
    {
       static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        public static string staff_name = string.Empty;
        public static string staff_id = string.Empty;

        public static void save_staff_details(string myQuery,string st_id, string st_number, string branch_id, string st_name, string st_gender, string st_status, string st_position, string nss_number, string bank_acc_number, string bank_id, string bank_branch_id, string tin_number, string usr_id_create,decimal basic,decimal transport,decimal housing)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_number", SqlDbType.VarChar,50);
                            cmd.Parameters["@st_number"].Value = st_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@branch_id"].Value = branch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_name", SqlDbType.VarChar,50);
                            cmd.Parameters["@st_name"].Value = st_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_gender", SqlDbType.VarChar,50);
                            cmd.Parameters["@st_gender"].Value = st_gender;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_status", SqlDbType.VarChar,50);
                            cmd.Parameters["@st_status"].Value = st_status;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_position", SqlDbType.VarChar,50);
                            cmd.Parameters["@st_position"].Value = st_position;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nss_number", SqlDbType.VarChar,50);
                            cmd.Parameters["@nss_number"].Value = nss_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bank_acc_number", SqlDbType.VarChar,50);
                            cmd.Parameters["@bank_acc_number"].Value = bank_acc_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bank_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@bank_id"].Value = bank_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bank_branch_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@bank_branch_id"].Value = bank_branch_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@tin_number", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@tin_number"].Value = tin_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@basic_amt", SqlDbType.Decimal);
                            cmd.Parameters["@basic_amt"].Value = basic;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transport_amt", SqlDbType.Decimal);
                            cmd.Parameters["@transport_amt"].Value = transport;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@housing_amt", SqlDbType.Decimal);
                            cmd.Parameters["@housing_amt"].Value = housing;

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

        public static void save_staff_advance(string myQuery,string st_id,DateTime ad_date,decimal ad_amount,decimal ad_paid_amount,decimal ad_balance_amount,bool ad_fully_paid)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_date", SqlDbType.Date);
                            cmd.Parameters["@ad_date"].Value = ad_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_amount", SqlDbType.Decimal);
                            cmd.Parameters["@ad_amount"].Value = ad_amount;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_paid_amount", SqlDbType.Decimal);
                            cmd.Parameters["@ad_paid_amount"].Value = ad_paid_amount;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_balance_amount", SqlDbType.Decimal);
                            cmd.Parameters["@ad_balance_amount"].Value = ad_balance_amount;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_fully_paid", SqlDbType.Bit);
                            cmd.Parameters["@ad_fully_paid"].Value = ad_fully_paid;

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

        public static DataTable Return_staff_list(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
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


        public static DataTable Return_staff_list_search(string myQuery, string st_name)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_name", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@st_name"].Value = st_name;

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


        public static string AccountsCode(string myQuery,string record_guid)
        {
            DataTable dt = new DataTable();
            string code = string.Empty;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
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
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtRow = dt.Rows[0];
                                code = dtRow["accounts_code"].ToString();
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return code;
        }

        public static DataTable Return_advance_list(string myQuery,string st_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

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

        public static int check_if_staff_has_advance(string myQuery, string st_id)
        {
            DataTable dt = new DataTable();
            int count = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return count;
        }

        public static DataTable select_staff_list_search(string myQuery,string st_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

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

        public static DataTable Return_staff_payroll(string myQuery,string st_id,int payment_period_id,string payment_month)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

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

        public static string select_staff_loan_balance(string myQuery, string st_id)
        {
            DataTable dt = new DataTable();
            int LoanBalance = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;

                            LoanBalance = Convert.ToInt32(cmd.ExecuteScalar());
                            
                            
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
            return String.Format("{0:n0}", LoanBalance); ;
        }

        public static DataTable Return_staff_advance(string myQuery, string st_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

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

        public static DataTable select_staff_details_payroll_setup(string myQuery, string st_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

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

        public static DataTable select_staff_list_payroll_search(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
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

        #region payroll
        public static void save_staff_payroll(string myQuery,string st_id,string user_id,int payment_period_id,string payment_month,decimal basic_amt,decimal transport_amt,decimal bonus_amt,decimal leave_amt,decimal overtime_amt ,decimal special_amt
        ,decimal local_service_tax_amt ,decimal loan_amt,decimal advance_amt,decimal total_nssf_amt,decimal total_paye_amt,decimal gross_pay_amt,decimal total_deductions,decimal staff_net_pay_amt,bool pay_salary,bool pay_paye
        ,bool pay_nssf,bool pay_advance,bool print_bank_schedule,bool print_payroll, string over_time_days)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@user_id"].Value = user_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.VarChar,50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@basic_amt", SqlDbType.Decimal);
                            cmd.Parameters["@basic_amt"].Value = basic_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transport_amt", SqlDbType.Decimal);
                            cmd.Parameters["@transport_amt"].Value = transport_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bonus_amt", SqlDbType.Decimal);
                            cmd.Parameters["@bonus_amt"].Value = bonus_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@leave_amt", SqlDbType.Decimal);
                            cmd.Parameters["@leave_amt"].Value = leave_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@overtime_amt", SqlDbType.Decimal);
                            cmd.Parameters["@overtime_amt"].Value = overtime_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@special_amt", SqlDbType.Decimal);
                            cmd.Parameters["@special_amt"].Value = special_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@local_service_tax_amt", SqlDbType.Decimal);
                            cmd.Parameters["@local_service_tax_amt"].Value = local_service_tax_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@loan_amt", SqlDbType.Decimal);
                            cmd.Parameters["@loan_amt"].Value = loan_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@advance_amt", SqlDbType.Decimal);
                            cmd.Parameters["@advance_amt"].Value = advance_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_nssf_amt", SqlDbType.Decimal);
                            cmd.Parameters["@total_nssf_amt"].Value = total_nssf_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_paye_amt", SqlDbType.Decimal);
                            cmd.Parameters["@total_paye_amt"].Value = total_paye_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@gross_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@gross_pay_amt"].Value = gross_pay_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_deductions", SqlDbType.Decimal);
                            cmd.Parameters["@total_deductions"].Value = total_deductions;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@staff_net_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@staff_net_pay_amt"].Value = staff_net_pay_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_salary", SqlDbType.Bit);
                            cmd.Parameters["@pay_salary"].Value = pay_salary;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_paye", SqlDbType.Bit);
                            cmd.Parameters["@pay_paye"].Value = pay_paye;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_nssf", SqlDbType.Bit);
                            cmd.Parameters["@pay_nssf"].Value = pay_nssf;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_advance", SqlDbType.Bit);
                            cmd.Parameters["@pay_advance"].Value = pay_advance;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@print_bank_schedule", SqlDbType.Bit);
                            cmd.Parameters["@print_bank_schedule"].Value = print_bank_schedule;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@print_payroll", SqlDbType.Bit);
                            cmd.Parameters["@print_payroll"].Value = print_payroll;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@over_time_days", SqlDbType.VarChar, 10);
                            cmd.Parameters["@over_time_days"].Value = over_time_days;

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


        public static void update_staff_payroll(string myQuery, string record_guid, string user_id, int payment_period_id, string payment_month, decimal basic_amt, decimal transport_amt, decimal bonus_amt, decimal leave_amt, decimal overtime_amt, decimal special_amt
       , decimal local_service_tax_amt, decimal loan_amt, decimal advance_amt, decimal total_nssf_amt, decimal total_paye_amt, decimal gross_pay_amt, decimal total_deductions, decimal staff_net_pay_amt, bool pay_salary, bool pay_paye
       , bool pay_nssf, bool pay_advance, bool print_bank_schedule, bool print_payroll,string over_time_days)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@record_guid"].Value = record_guid;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@user_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@user_id"].Value = user_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.VarChar, 50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@basic_amt", SqlDbType.Decimal);
                            cmd.Parameters["@basic_amt"].Value = basic_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transport_amt", SqlDbType.Decimal);
                            cmd.Parameters["@transport_amt"].Value = transport_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bonus_amt", SqlDbType.Decimal);
                            cmd.Parameters["@bonus_amt"].Value = bonus_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@leave_amt", SqlDbType.Decimal);
                            cmd.Parameters["@leave_amt"].Value = leave_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@overtime_amt", SqlDbType.Decimal);
                            cmd.Parameters["@overtime_amt"].Value = overtime_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@special_amt", SqlDbType.Decimal);
                            cmd.Parameters["@special_amt"].Value = special_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@local_service_tax_amt", SqlDbType.Decimal);
                            cmd.Parameters["@local_service_tax_amt"].Value = local_service_tax_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@loan_amt", SqlDbType.Decimal);
                            cmd.Parameters["@loan_amt"].Value = loan_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@advance_amt", SqlDbType.Decimal);
                            cmd.Parameters["@advance_amt"].Value = advance_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_nssf_amt", SqlDbType.Decimal);
                            cmd.Parameters["@total_nssf_amt"].Value = total_nssf_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_paye_amt", SqlDbType.Decimal);
                            cmd.Parameters["@total_paye_amt"].Value = total_paye_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@gross_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@gross_pay_amt"].Value = gross_pay_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@total_deductions", SqlDbType.Decimal);
                            cmd.Parameters["@total_deductions"].Value = total_deductions;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@staff_net_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@staff_net_pay_amt"].Value = staff_net_pay_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_salary", SqlDbType.Bit);
                            cmd.Parameters["@pay_salary"].Value = pay_salary;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_paye", SqlDbType.Bit);
                            cmd.Parameters["@pay_paye"].Value = pay_paye;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_nssf", SqlDbType.Bit);
                            cmd.Parameters["@pay_nssf"].Value = pay_nssf;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@pay_advance", SqlDbType.Bit);
                            cmd.Parameters["@pay_advance"].Value = pay_advance;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@print_bank_schedule", SqlDbType.Bit);
                            cmd.Parameters["@print_bank_schedule"].Value = print_bank_schedule;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@print_payroll", SqlDbType.Bit);
                            cmd.Parameters["@print_payroll"].Value = print_payroll;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@over_time_days", SqlDbType.VarChar,10);
                            cmd.Parameters["@over_time_days"].Value = over_time_days;

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

        public static void update_staff_advance_payment(string myQuery, string st_id,string ad_id, decimal ad_paid_amount, decimal ad_balance_amount)
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_id", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@ad_id"].Value = ad_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_paid_amount", SqlDbType.Decimal);
                            cmd.Parameters["@ad_paid_amount"].Value = ad_paid_amount;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ad_balance_amount", SqlDbType.Decimal);
                            cmd.Parameters["@ad_balance_amount"].Value = ad_balance_amount;


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

        public static int Validate_payroll(string myQuery, string st_id,int payment_period_id,string payment_month)
        {
            DataTable dt = new DataTable();
            int count = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_staff_profiles", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@st_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@st_id"].Value = st_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_period_id", SqlDbType.Int);
                            cmd.Parameters["@payment_period_id"].Value = payment_period_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return count;
        }
        #endregion
    }
}
