using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class Users
	{
		private static SqlConnection conn;

		static Users()
		{
			Users.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static DataTable LOGIN_USER(string myQuery, string username, string password)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Login", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@myQueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@myQueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_name", SqlDbType.NChar, 50);
							cmd.Parameters["@user_name"].Value = username;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@pwd", SqlDbType.NChar, 50);
							cmd.Parameters["@pwd"].Value = password;
							if (conn.State == ConnectionState.Closed)
							{
								conn.Open();
							}
							cmd.Connection = conn;
							(new SqlDataAdapter(cmd)).Fill(dt);
							int count = dt.Rows.Count;
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
				if (Users.conn.State == ConnectionState.Open)
				{
					Users.conn.Close();
				}
			}
			return dt;
		}

		public static void NEW_USER_PROFILE(string myQuery, string name, string gender, string user_name, string pwd, bool is_admin, bool user_active, string user_department)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Login", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@myQueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@myQueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@name"].Value = name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 20);
							cmd.Parameters["@gender"].Value = gender;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@user_name"].Value = user_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@pwd", SqlDbType.NVarChar, 100);
							cmd.Parameters["@pwd"].Value = pwd;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_admin", SqlDbType.Bit);
							cmd.Parameters["@is_admin"].Value = is_admin;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_active", SqlDbType.Bit);
							cmd.Parameters["@user_active"].Value = user_active;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_department", SqlDbType.NVarChar, 50);
							cmd.Parameters["@user_department"].Value = user_department;
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
				if (Users.conn.State == ConnectionState.Open)
				{
					Users.conn.Close();
				}
			}
		}

		public static DataTable SELECT_USER_DETAILS(string myQuery, int user_id)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Login", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@myQueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@myQueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_id", SqlDbType.Int);
							cmd.Parameters["@user_id"].Value = user_id;
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
				if (Users.conn.State == ConnectionState.Open)
				{
					Users.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable SELECT_USER_LIST(string myQuery)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Login", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@myQueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@myQueryName"].Value = myQuery;
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
				if (Users.conn.State == ConnectionState.Open)
				{
					Users.conn.Close();
				}
			}
			return dt;
		}

		public static void UPDATE_USER_DETAILS(string myQuery, string name, string gender, bool is_admin, bool user_active, string user_department, int user_id)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Login", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@myQueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@myQueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@name"].Value = name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 20);
							cmd.Parameters["@gender"].Value = gender;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@is_admin", SqlDbType.Bit);
							cmd.Parameters["@is_admin"].Value = is_admin;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_active", SqlDbType.Bit);
							cmd.Parameters["@user_active"].Value = user_active;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_department", SqlDbType.NVarChar, 50);
							cmd.Parameters["@user_department"].Value = user_department;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@user_id", SqlDbType.Int);
							cmd.Parameters["@user_id"].Value = user_id;
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
				if (Users.conn.State == ConnectionState.Open)
				{
					Users.conn.Close();
				}
			}
		}
	}
}