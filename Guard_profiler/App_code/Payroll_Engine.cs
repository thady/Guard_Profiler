using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class Payroll_Engine
	{
		private static SqlConnection conn;

		static Payroll_Engine()
		{
			Payroll_Engine.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static DataTable Return_guard_shift_types(string myQuery, string branch_name, DateTime deploy_start_date, DateTime deploy_end_date)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
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
				if (Payroll_Engine.conn.State == ConnectionState.Open)
				{
					Payroll_Engine.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable Return_guard_shift_types(string myQuery, DateTime deploy_start_date, DateTime deploy_end_date)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
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
				if (Payroll_Engine.conn.State == ConnectionState.Open)
				{
					Payroll_Engine.conn.Close();
				}
			}
			return dt;
		}

		public static void save_or_update_guard_payroll_details(string QueryName, string record_guid, string user_id, string station_code, int deploy_period_id, string station_name, string guard_number, string guard_name, string salary_scale_code, string bank_code, string bank_name, string bank_branch, string bank_account_number, string grade, string nssf_number, decimal basic_amt, decimal transport_amt, decimal housing_amt, decimal resident_amt, decimal bonus_amt, decimal leave_amt, decimal uniform_amt, decimal local_service_tax_amt, decimal overtime_amt, decimal special_amt, decimal arrears_amt, decimal advance_amt, decimal penalty_amt, decimal absentism_amt, int total_days_worked, int total_overtime_days_worked, int total_resident_days, int total_penalty_days, decimal total_tax_relief_for_guard, decimal gross_pay_amt, decimal total_paye_amt, decimal total_nssf_amt, decimal total_deductions, decimal guard_net_pay_amt, bool pay_salary, bool pay_paye, bool pay_nssf, bool pay_advance,bool print_bank_schedule)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_id", SqlDbType.NVarChar, 50);
							cmd.Parameters["@user_id"].Value = user_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_code", SqlDbType.NVarChar, 50);
							cmd.Parameters["@station_code"].Value = station_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@station_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@station_name"].Value = station_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 30);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 150);
							cmd.Parameters["@guard_name"].Value = guard_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@salary_scale_code", SqlDbType.NVarChar, 30);
							cmd.Parameters["@salary_scale_code"].Value = salary_scale_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_code", SqlDbType.NVarChar, 30);
							cmd.Parameters["@bank_code"].Value = bank_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@bank_name"].Value = bank_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_branch", SqlDbType.NVarChar, 100);
							cmd.Parameters["@bank_branch"].Value = bank_branch;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_account_number", SqlDbType.NVarChar, 60);
							cmd.Parameters["@bank_account_number"].Value = bank_account_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@grade", SqlDbType.NVarChar, 100);
							cmd.Parameters["@grade"].Value = grade;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nssf_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@nssf_number"].Value = nssf_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@basic_amt", SqlDbType.Decimal);
							cmd.Parameters["@basic_amt"].Value = basic_amt;
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
							cmd.Parameters.Add("@bonus_amt", SqlDbType.Decimal);
							cmd.Parameters["@bonus_amt"].Value = bonus_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@leave_amt", SqlDbType.Decimal);
							cmd.Parameters["@leave_amt"].Value = leave_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@uniform_amt", SqlDbType.Decimal);
							cmd.Parameters["@uniform_amt"].Value = uniform_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@local_service_tax_amt", SqlDbType.Decimal);
							cmd.Parameters["@local_service_tax_amt"].Value = local_service_tax_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@overtime_amt", SqlDbType.Decimal);
							cmd.Parameters["@overtime_amt"].Value = overtime_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@special_amt", SqlDbType.Decimal);
							cmd.Parameters["@special_amt"].Value = special_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@arrears_amt", SqlDbType.Decimal);
							cmd.Parameters["@arrears_amt"].Value = arrears_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@advance_amt", SqlDbType.Decimal);
							cmd.Parameters["@advance_amt"].Value = advance_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@penalty_amt", SqlDbType.Decimal);
							cmd.Parameters["@penalty_amt"].Value = penalty_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@absentism_amt", SqlDbType.Decimal);
							cmd.Parameters["@absentism_amt"].Value = absentism_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_days_worked", SqlDbType.Int);
							cmd.Parameters["@total_days_worked"].Value = total_days_worked;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_overtime_days_worked", SqlDbType.Int);
							cmd.Parameters["@total_overtime_days_worked"].Value = total_overtime_days_worked;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_resident_days", SqlDbType.Int);
							cmd.Parameters["@total_resident_days"].Value = total_resident_days;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_penalty_days", SqlDbType.Int);
							cmd.Parameters["@total_penalty_days"].Value = total_penalty_days;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_tax_relief_for_guard", SqlDbType.Decimal);
							cmd.Parameters["@total_tax_relief_for_guard"].Value = total_tax_relief_for_guard;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@gross_pay_amt", SqlDbType.Decimal);
							cmd.Parameters["@gross_pay_amt"].Value = gross_pay_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_paye_amt", SqlDbType.Decimal);
							cmd.Parameters["@total_paye_amt"].Value = total_paye_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_nssf_amt", SqlDbType.Decimal);
							cmd.Parameters["@total_nssf_amt"].Value = total_nssf_amt;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@total_deductions", SqlDbType.Decimal);
							cmd.Parameters["@total_deductions"].Value = total_deductions;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_net_pay_amt", SqlDbType.Decimal);
							cmd.Parameters["@guard_net_pay_amt"].Value = guard_net_pay_amt;
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
				SqlConnection sqlConnection = Payroll_Engine.conn;
			}
		}

		public static DataTable select_guard_payroll_details_by_deploy_id(string myQuery, string guard_number, int deploy_period_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_period_id", SqlDbType.Int);
							cmd.Parameters["@deploy_period_id"].Value = deploy_period_id;
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
				if (Payroll_Engine.conn.State == ConnectionState.Open)
				{
					Payroll_Engine.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_payroll_details_for_selected_guard(string myQuery, string guard_number, DateTime deploy_start_date, DateTime deploy_end_date)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_payroll_queries", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
							cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
							cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;
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
				if (Payroll_Engine.conn.State == ConnectionState.Open)
				{
					Payroll_Engine.conn.Close();
				}
			}
			return dt;
		}
	}
}