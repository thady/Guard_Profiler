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
    class Nss_archive
    {
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        #region Variables
        public static string QueryName = string.Empty;
        public static string record_id = string.Empty;
        public static string payment_year = string.Empty;
        public static string payment_month = string.Empty;
        public static string branch_name = string.Empty;
        public static string guard_number = string.Empty;
        public static string guard_name = string.Empty;
        public static string nss_number = string.Empty;
        public static int days_worked = 0;
        public static decimal basic_amt = 0;
        public static decimal overtime_amt = 0;
        public static decimal transport_amt = 0;
        public static decimal housing_amt = 0;
        public static decimal resident_amt = 0;
        public static decimal special_amt = 0;
        public static decimal bonus_amt = 0;
        public static decimal arrears_amt = 0;
        public static decimal leave_amt = 0;
        public static decimal gross_pay_amt = 0;
        public static decimal advance_amt = 0;
        public static decimal loan_amt = 0;
        public static decimal absentism_amt = 0;
        public static decimal uniform_amt = 0;
        public static decimal penalty_amt = 0;
        public static decimal lst_amt = 0;
        public static decimal paye_amt = 0;
        public static decimal nssf_amt = 0;
        public static decimal employer_nssf_amt = 0;
        public static decimal nssf_total_amt = 0;
        public static decimal net_pay_amt = 0;
        public static string usr_id_create = string.Empty;
        public static string usr_id_update = string.Empty;
        public static DateTime usr_date_create = DateTime.Now;
        public static DateTime usr_date_update = DateTime.Now;
        #endregion

        #region ReportVariables
        public static string Rpayment_year = string.Empty;
        public static string Rpayment_month = string.Empty;
        public static string Rbranch_name = string.Empty;
        #endregion

        public static void save_guard_payroll_details()
        {
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_nss_archive", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = QueryName;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@record_id", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@record_id"].Value = record_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_year", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@payment_year"].Value = payment_year;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@payment_month"].Value = payment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_name", SqlDbType.VarChar, 50);
                            cmd.Parameters["@branch_name"].Value = branch_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@guard_number"].Value = guard_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 150);
                            cmd.Parameters["@guard_name"].Value = guard_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nss_number", SqlDbType.NVarChar, 30);
                            cmd.Parameters["@nss_number"].Value = nss_number;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@days_worked", SqlDbType.Int);
                            cmd.Parameters["@days_worked"].Value = days_worked;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@basic_amt", SqlDbType.Decimal);
                            cmd.Parameters["@basic_amt"].Value = basic_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@overtime_amt", SqlDbType.Decimal);
                            cmd.Parameters["@overtime_amt"].Value = overtime_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@transport_amt", SqlDbType.Decimal);
                            cmd.Parameters["@transport_amt"].Value = transport_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@housing_amt", SqlDbType.Decimal);
                            cmd.Parameters["@housing_amt"].Value = housing_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@resident_amt", SqlDbType.Decimal);
                            cmd.Parameters["@resident_amt"].Value = resident_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@special_amt", SqlDbType.Decimal);
                            cmd.Parameters["@special_amt"].Value = special_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@bonus_amt", SqlDbType.Decimal);
                            cmd.Parameters["@bonus_amt"].Value = bonus_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@arrears_amt", SqlDbType.Decimal);
                            cmd.Parameters["@arrears_amt"].Value = arrears_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@leave_amt", SqlDbType.Decimal);
                            cmd.Parameters["@leave_amt"].Value = leave_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@gross_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@gross_pay_amt"].Value = gross_pay_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@advance_amt", SqlDbType.Decimal);
                            cmd.Parameters["@advance_amt"].Value = advance_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@loan_amt", SqlDbType.Decimal);
                            cmd.Parameters["@loan_amt"].Value = loan_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@absentism_amt", SqlDbType.Decimal);
                            cmd.Parameters["@absentism_amt"].Value = absentism_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@uniform_amt", SqlDbType.Decimal);
                            cmd.Parameters["@uniform_amt"].Value = uniform_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@penalty_amt", SqlDbType.Int);
                            cmd.Parameters["@penalty_amt"].Value = penalty_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@lst_amt", SqlDbType.Int);
                            cmd.Parameters["@lst_amt"].Value = lst_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@paye_amt", SqlDbType.Int);
                            cmd.Parameters["@paye_amt"].Value = paye_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nssf_amt", SqlDbType.Int);
                            cmd.Parameters["@nssf_amt"].Value = nssf_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@employer_nssf_amt", SqlDbType.Decimal);
                            cmd.Parameters["@employer_nssf_amt"].Value = employer_nssf_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@nssf_total_amt", SqlDbType.Decimal);
                            cmd.Parameters["@nssf_total_amt"].Value = nssf_total_amt;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@net_pay_amt", SqlDbType.Decimal);
                            cmd.Parameters["@net_pay_amt"].Value = net_pay_amt;

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
                conn.Close();
            }
        }

        public static DataTable select_list(string myQuery, string payment_year, string payment_month, string guard_name)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_nss_archive", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_year", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_year"].Value = payment_year;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_month"].Value = payment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@guard_name"].Value = guard_name;

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

        public static DataTable select_payroll_details(string myQuery, string record_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_nss_archive", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@record_id", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@record_id"].Value = record_id;

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

        public static DataTable select_payroll_report()
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_nss_archive", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = QueryName;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_year", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_year"].Value = Rpayment_year;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_month"].Value = Rpayment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@branch_name"].Value = Rbranch_name;

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

        public static DataTable select_nssf_report()
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_nss_archive", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@QueryName"].Value = QueryName;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_year", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_year"].Value = Rpayment_year;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@payment_month", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@payment_month"].Value = Rpayment_month;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
                            cmd.Parameters["@branch_name"].Value = Rbranch_name;

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
