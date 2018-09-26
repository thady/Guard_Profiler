using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class HeadShotEngine
	{
		private static SqlConnection conn;

		static HeadShotEngine()
		{
			HeadShotEngine.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static void INSERT_OR_UPDATE_IMAGE(string myQuery, string record_guid, byte[] imageBinary)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
							cmd.Parameters["@record_guid"].Value = record_guid;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@image_data", SqlDbType.VarBinary);
							cmd.Parameters["@image_data"].Value = imageBinary;
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
				if (HeadShotEngine.conn.State == ConnectionState.Open)
				{
					HeadShotEngine.conn.Close();
				}
			}
		}

		public static DataTable SELECT_OFFICER_HEAD_SHOT(string myQuery, string record_guid)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
							cmd.Parameters["@QueryName"].Value = myQuery;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 50);
							cmd.Parameters["@record_guid"].Value = record_guid;
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
				if (HeadShotEngine.conn.State == ConnectionState.Open)
				{
					HeadShotEngine.conn.Close();
				}
			}
			return dt;
		}

		public static DataTable select_officer_headshot_by_guard_number(string myQuery, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
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
				if (HeadShotEngine.conn.State == ConnectionState.Open)
				{
					HeadShotEngine.conn.Close();
				}
			}
			return dt;
		}
	}
}