using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal class Salary_scales
	{
		private static SqlConnection conn;

		public static int bank_id;

		public static int branch_id;

		static Salary_scales()
		{
			Salary_scales.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
			Salary_scales.bank_id = -1;
			Salary_scales.branch_id = -1;
		}

		public Salary_scales()
		{
		}

		public static void auto_assign_salary_scale_to_guard(string myQuery, int years_served, int guard_auto_id, string guard_number)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@months_served", SqlDbType.Int);
							cmd.Parameters["@months_served"].Value = years_served;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
							cmd.Parameters["@guard_auto_id"].Value = guard_auto_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static DataTable get_bank_branches(string myQuery, int bank_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_id", SqlDbType.Int);
							cmd.Parameters["@bank_id"].Value = bank_id;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static void insert_update_guard_account_details(string myQuery, string guard_number, int bank_id, int branch_id, string account_number, string nssf_number)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_id", SqlDbType.Int);
							cmd.Parameters["@bank_id"].Value = bank_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_id", SqlDbType.Int);
							cmd.Parameters["@branch_id"].Value = branch_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@account_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@account_number"].Value = account_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nssf_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@nssf_number"].Value = nssf_number;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static DataTable return_bank_and_nssf_details_by_guard_number(string myQuery, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_bank_lists(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_guard_salary_mappings(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_manual_guard_salary_scale_mappings_search(string myQuery, string name, string branch, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@full_name ", SqlDbType.NVarChar, 50);
							cmd.Parameters["@full_name "].Value = name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_number_of_years_served_for_each_gaurd(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable return_salary_scales(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}

		public static void Salary_scale_manual_assigment_query(string myQuery, int guard_auto_id, string guard_number, int scale_id, string user_name, int previous_scale_id)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
							cmd.Parameters["@guard_auto_id"].Value = guard_auto_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@scale_id", SqlDbType.Int);
							cmd.Parameters["@scale_id"].Value = scale_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@user_name"].Value = user_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_scale_id", SqlDbType.Int);
							cmd.Parameters["@previous_scale_id"].Value = previous_scale_id;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static void save_or_update_salary_scale_guards(string myQuery, string scale_name, int minimum_year_count, int maximum_year_count, float salary_amount, string record_guid)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@scale_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@scale_name"].Value = scale_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@minimum_year_count", SqlDbType.Int);
							cmd.Parameters["@minimum_year_count"].Value = minimum_year_count;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@maximum_year_count", SqlDbType.Int);
							cmd.Parameters["@maximum_year_count"].Value = maximum_year_count;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@salary_amount", SqlDbType.Float);
							cmd.Parameters["@salary_amount"].Value = salary_amount;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static void save_update_bank_details(string myQuery, string bank_code, string bank_name, bool active)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_id", SqlDbType.Int);
							cmd.Parameters["@bank_id"].Value = Salary_scales.bank_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_code", SqlDbType.NVarChar, 20);
							cmd.Parameters["@bank_code"].Value = bank_code;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@bank_name"].Value = bank_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_active", SqlDbType.Bit);
							cmd.Parameters["@bank_active"].Value = active;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static void save_update_branch_details(string myQuery, string branch_name, bool active, int branch_id)
		{
			DataTable dataTable = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_id", SqlDbType.Int);
							cmd.Parameters["@bank_id"].Value = Salary_scales.bank_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_id", SqlDbType.Int);
							cmd.Parameters["@branch_id"].Value = branch_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@branch_name"].Value = branch_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_active", SqlDbType.Bit);
							cmd.Parameters["@branch_active"].Value = active;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
		}

		public static DataTable select_guard_bank_details_mapping_search(string myQuery, string branch, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@branch_name"].Value = branch;

							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@guard_number"].Value = guard_number;
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
				if (Salary_scales.conn.State == ConnectionState.Open)
				{
					Salary_scales.conn.Close();
				}
			}
			return dt;
		}
	}
}