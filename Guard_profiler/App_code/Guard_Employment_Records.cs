using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
	internal static class Guard_Employment_Records
	{
		private static SqlConnection conn;

		static Guard_Employment_Records()
		{
			Guard_Employment_Records.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
		}

		public static DataTable SELECT_OFFICER_DETAILS(string myQuery, string guard_number)
		{
			DataTable dt = new DataTable();
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
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
				if (Guard_Employment_Records.conn.State == ConnectionState.Open)
				{
					Guard_Employment_Records.conn.Close();
				}
			}
			return dt;
		}

		public static void UPDATE_CURRENT_RESIDENTIAL_ADRESS_DETAILS(string QueryName, string guard_number, string current_adress, string current_district, string current_county, string current_sub_county, string current_parish, string current_village, string current_zone, string landlord_name, string lc1_chairperson_name, string lc1_chairperson_phone)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_adress", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_adress"].Value = current_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_district", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_district"].Value = current_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_county", SqlDbType.NVarChar, 150);
							cmd.Parameters["@current_county"].Value = current_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_sub_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_sub_county"].Value = current_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_parish", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_parish"].Value = current_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_village", SqlDbType.NVarChar, 50);
							cmd.Parameters["@current_village"].Value = current_village;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@current_zone", SqlDbType.NVarChar, 250);
							cmd.Parameters["@current_zone"].Value = current_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@landlord_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@landlord_name"].Value = landlord_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@lc1_chairperson_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@lc1_chairperson_name"].Value = lc1_chairperson_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@lc1_chairperson_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@lc1_chairperson_phone"].Value = lc1_chairperson_phone;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_CHILDREN_DETAILS(string QueryName, string guard_number, string child_one_name, string child_one_contact, string child_two_name, string child_two_contact, string child_three_name, string child_three_contact, string child_four_name, string child_four_contact)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_one_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@child_one_name"].Value = child_one_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_one_contact", SqlDbType.NVarChar, 50);
							cmd.Parameters["@child_one_contact"].Value = child_one_contact;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_two_name", SqlDbType.NVarChar, 150);
							cmd.Parameters["@child_two_name"].Value = child_two_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_two_contact", SqlDbType.NVarChar, 50);
							cmd.Parameters["@child_two_contact"].Value = child_two_contact;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_three_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@child_three_name"].Value = child_three_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_three_contact", SqlDbType.NVarChar, 50);
							cmd.Parameters["@child_three_contact"].Value = child_three_contact;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_four_name", SqlDbType.NVarChar, 250);
							cmd.Parameters["@child_four_name"].Value = child_four_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@child_four_contact", SqlDbType.NVarChar, 100);
							cmd.Parameters["@child_four_contact"].Value = child_four_contact;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_EDUCATION_HISTORY(string QueryName, string guard_number, string school_1_name, int school_1_year, string school_1_level, string school_1_qualification, string school_2_name, int school_2_year, string school_2_level, string school_2_qualification, string school_3_name, int school_3_year, string school_3_level, string school_3_qualification, string school_4_name, int school_4_year, string school_4_level, string school_4_qualification)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_1_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@school_1_name"].Value = school_1_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_1_year", SqlDbType.Int);
							cmd.Parameters["@school_1_year"].Value = school_1_year;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_1_level", SqlDbType.NVarChar, 150);
							cmd.Parameters["@school_1_level"].Value = school_1_level;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_1_qualification", SqlDbType.NVarChar, 50);
							cmd.Parameters["@school_1_qualification"].Value = school_1_qualification;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_2_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@school_2_name"].Value = school_2_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_2_year", SqlDbType.Int);
							cmd.Parameters["@school_2_year"].Value = school_2_year;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_2_level", SqlDbType.NVarChar, 150);
							cmd.Parameters["@school_2_level"].Value = school_2_level;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_2_qualification", SqlDbType.NVarChar, 50);
							cmd.Parameters["@school_2_qualification"].Value = school_2_qualification;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_3_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@school_3_name"].Value = school_3_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_3_year", SqlDbType.Int);
							cmd.Parameters["@school_3_year"].Value = school_3_year;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_3_level", SqlDbType.NVarChar, 150);
							cmd.Parameters["@school_3_level"].Value = school_3_level;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_3_qualification", SqlDbType.NVarChar, 50);
							cmd.Parameters["@school_3_qualification"].Value = school_3_qualification;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_4_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@school_4_name"].Value = school_4_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_4_year", SqlDbType.Int);
							cmd.Parameters["@school_4_year"].Value = school_4_year;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_4_level", SqlDbType.NVarChar, 150);
							cmd.Parameters["@school_4_level"].Value = school_4_level;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@school_4_qualification", SqlDbType.NVarChar, 50);
							cmd.Parameters["@school_4_qualification"].Value = school_4_qualification;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_FATHER_DETAILS(string QueryName, string guard_number, string home_origin_adress, string home_district, string home_county, string home_sub_county, string home_parish, string home_village, string home_zone, string home_lc1_chaiperson_name, string home_lc1_chaiperson_phone, string home_village_neigbor_name, string home_village_neigbor_phone)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_name_and_adress", SqlDbType.NVarChar, 50);
							cmd.Parameters["@father_name_and_adress"].Value = home_origin_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_district", SqlDbType.NVarChar, 50);
							cmd.Parameters["@father_district"].Value = home_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_county", SqlDbType.NVarChar, 150);
							cmd.Parameters["@father_county"].Value = home_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_sub_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@father_sub_county"].Value = home_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_parish", SqlDbType.NVarChar, 50);
							cmd.Parameters["@father_parish"].Value = home_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_village", SqlDbType.NVarChar, 50);
							cmd.Parameters["@father_village"].Value = home_village;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_zone", SqlDbType.NVarChar, 250);
							cmd.Parameters["@father_zone"].Value = home_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_lc1_chairperson", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_lc1_chairperson"].Value = home_lc1_chaiperson_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_lc1_chairperson_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_lc1_chairperson_phone"].Value = home_lc1_chaiperson_phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@father_village_neighbor_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@father_village_neighbor_name"].Value = home_village_neigbor_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village_neigbor_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_village_neigbor_phone"].Value = home_village_neigbor_phone;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_HOME_ADRESS_OF_ORIGIN(string QueryName, string guard_number, string home_origin_adress, string home_district, string home_county, string home_sub_county, string home_parish, string home_village, string home_zone, string home_lc1_chaiperson_name, string home_lc1_chaiperson_phone, string home_village_neigbor_name, string home_village_neigbor_phone)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_origin_adress", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_origin_adress"].Value = home_origin_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_district", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_district"].Value = home_district;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_county", SqlDbType.NVarChar, 150);
							cmd.Parameters["@home_county"].Value = home_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_sub_county", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_sub_county"].Value = home_sub_county;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_parish", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_parish"].Value = home_parish;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village", SqlDbType.NVarChar, 50);
							cmd.Parameters["@home_village"].Value = home_village;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_zone", SqlDbType.NVarChar, 250);
							cmd.Parameters["@home_zone"].Value = home_zone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_lc1_chaiperson_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_lc1_chaiperson_name"].Value = home_lc1_chaiperson_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_lc1_chaiperson_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_lc1_chaiperson_phone"].Value = home_lc1_chaiperson_phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village_neigbor_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_village_neigbor_name"].Value = home_village_neigbor_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@home_village_neigbor_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@home_village_neigbor_phone"].Value = home_village_neigbor_phone;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_PREVIOUS_EMPLOYER_DETAILS(string QueryName, string guard_number, string previous_employer_name, string previous_employer_postal_adress, string cause_of_departure)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_employer_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@previous_employer_name"].Value = previous_employer_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@previous_employer_postal_adress", SqlDbType.NVarChar, 250);
							cmd.Parameters["@previous_employer_postal_adress"].Value = previous_employer_postal_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@cause_of_departure", SqlDbType.NVarChar, 150);
							cmd.Parameters["@cause_of_departure"].Value = cause_of_departure;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_REFFERENCES(string QueryName, string guard_number, string reference1_name, string reference2_name, string reference3_name)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@reference1_name", SqlDbType.NVarChar, 250);
							cmd.Parameters["@reference1_name"].Value = reference1_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@reference2_name", SqlDbType.NVarChar, 250);
							cmd.Parameters["@reference2_name"].Value = reference2_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@reference3_name", SqlDbType.NVarChar, 250);
							cmd.Parameters["@reference3_name"].Value = reference3_name;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_GUARD_RELATIVE_DETAILS(string QueryName, string guard_number, string relative_one_name, string relative_one_phone, string relative_one_occupation, string relative_two_name, string relative_two_phone, string relative_two_occupation, string next_of_kin_name, string next_of_kin_adress, string next_of_kin_relationship, string next_of_kin_phone, string next_of_kin_national_id_number)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_one_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@relative_one_name"].Value = relative_one_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_one_phone", SqlDbType.NVarChar, 50);
							cmd.Parameters["@relative_one_phone"].Value = relative_one_phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_one_occupation", SqlDbType.NVarChar, 150);
							cmd.Parameters["@relative_one_occupation"].Value = relative_one_occupation;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_two_name", SqlDbType.NVarChar, 50);
							cmd.Parameters["@relative_two_name"].Value = relative_two_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_two_phone", SqlDbType.NVarChar, 50);
							cmd.Parameters["@relative_two_phone"].Value = relative_two_phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@relative_two_occupation", SqlDbType.NVarChar, 50);
							cmd.Parameters["@relative_two_occupation"].Value = relative_two_occupation;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@next_of_kin_name", SqlDbType.NVarChar, 250);
							cmd.Parameters["@next_of_kin_name"].Value = next_of_kin_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@next_of_kin_adress", SqlDbType.NVarChar, 100);
							cmd.Parameters["@next_of_kin_adress"].Value = next_of_kin_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@next_of_kin_relationship", SqlDbType.NVarChar, 100);
							cmd.Parameters["@next_of_kin_relationship"].Value = next_of_kin_relationship;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@next_of_kin_phone", SqlDbType.NVarChar, 100);
							cmd.Parameters["@next_of_kin_phone"].Value = next_of_kin_phone;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@next_of_kin_national_id_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@next_of_kin_national_id_number"].Value = next_of_kin_national_id_number;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_OR_INSERT_GUARD_EMP_RECORD_HEADER(string QueryName, string guard_number, string nationality, string tribe, string phone_primary, string phone_secondary, string national_id, string partner_birth_place, string partner_parents_names, string partner_parents_resident_adress, string partner_contact)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nationality", SqlDbType.NVarChar, 50);
							cmd.Parameters["@nationality"].Value = nationality;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@tribe", SqlDbType.NVarChar, 50);
							cmd.Parameters["@tribe"].Value = tribe;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@phone_primary", SqlDbType.NVarChar, 150);
							cmd.Parameters["@phone_primary"].Value = phone_primary;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@phone_secondary", SqlDbType.NVarChar, 50);
							cmd.Parameters["@phone_secondary"].Value = phone_secondary;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@national_id", SqlDbType.NVarChar, 50);
							cmd.Parameters["@national_id"].Value = national_id;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partner_birth_place", SqlDbType.NVarChar, 50);
							cmd.Parameters["@partner_birth_place"].Value = partner_birth_place;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partner_parents_names", SqlDbType.NVarChar, 250);
							cmd.Parameters["@partner_parents_names"].Value = partner_parents_names;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partner_parents_resident_adress", SqlDbType.NVarChar, 50);
							cmd.Parameters["@partner_parents_resident_adress"].Value = partner_parents_resident_adress;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@partner_contact", SqlDbType.NVarChar, 100);
							cmd.Parameters["@partner_contact"].Value = partner_contact;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}

		public static void UPDATE_OTHER_GUARD_DETAILS_AND_OFFICIAL_DATA(string QueryName, string guard_number, bool serious_illness_or_accident, string nature_of_illness, DateTime? illness_or_accident_date, bool premonia_or_athma_incident, bool epilipsy_incident, bool tb_incident, DateTime date_employed, string recruiting_officer_name, string commence_salary, string nssf_number, string bank_name, string account_number, string position_held_at_discharge, string general_conduct)
		{
			try
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
					{
						using (SqlCommand cmd = new SqlCommand("sp_guard_emp_record", conn))
						{
							cmd.CommandTimeout = 3600;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
							cmd.Parameters["@QueryName"].Value = QueryName;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@guard_number"].Value = guard_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@serious_illness_or_accident", SqlDbType.Bit);
							cmd.Parameters["@serious_illness_or_accident"].Value = serious_illness_or_accident;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nature_of_illness", SqlDbType.NVarChar, 100);
							cmd.Parameters["@nature_of_illness"].Value = nature_of_illness;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@illness_or_accident_date", SqlDbType.Date);
							cmd.Parameters["@illness_or_accident_date"].Value = illness_or_accident_date;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@premonia_or_athma_incident", SqlDbType.Bit);
							cmd.Parameters["@premonia_or_athma_incident"].Value = premonia_or_athma_incident;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@epilipsy_incident", SqlDbType.Bit);
							cmd.Parameters["@epilipsy_incident"].Value = epilipsy_incident;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@tb_incident", SqlDbType.Bit);
							cmd.Parameters["@tb_incident"].Value = tb_incident;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@date_employed", SqlDbType.Date);
							cmd.Parameters["@date_employed"].Value = date_employed;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@recruiting_officer_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@recruiting_officer_name"].Value = recruiting_officer_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@commence_salary", SqlDbType.NVarChar, 100);
							cmd.Parameters["@commence_salary"].Value = commence_salary;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@nssf_number", SqlDbType.NVarChar, 50);
							cmd.Parameters["@nssf_number"].Value = nssf_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@bank_name", SqlDbType.NVarChar, 100);
							cmd.Parameters["@bank_name"].Value = bank_name;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@account_number", SqlDbType.NVarChar, 100);
							cmd.Parameters["@account_number"].Value = account_number;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@position_held_at_discharge", SqlDbType.NVarChar, 100);
							cmd.Parameters["@position_held_at_discharge"].Value = position_held_at_discharge;
							cmd.CommandType = CommandType.StoredProcedure;
							cmd.Parameters.Add("@general_conduct", SqlDbType.NVarChar, 100);
							cmd.Parameters["@general_conduct"].Value = general_conduct;
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
				SqlConnection sqlConnection = Guard_Employment_Records.conn;
			}
		}
	}
}