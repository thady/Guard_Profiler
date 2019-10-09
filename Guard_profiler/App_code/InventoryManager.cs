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
   public static class InventoryManager
    {
        private static SqlConnection conn;
        public static string item_cat_id = string.Empty;
        public static string item_name = string.Empty;
        public static string itemstockout_main_id = string.Empty;
        public static DateTime stock_date = DateTime.Today;
        public static string guard_id = string.Empty;

        static InventoryManager() 
        {
            InventoryManager.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        }
        public static void save_item_category(string myQuery,string item_cat_id ,string item_cat_name,bool item_cat_active,string usr_id_create ,string usr_id_update ,DateTime usr_date_update)
        {
    
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_cat_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@item_cat_id"].Value = item_cat_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_cat_name", SqlDbType.VarChar,100);
                            cmd.Parameters["@item_cat_name"].Value = item_cat_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_cat_active", SqlDbType.Bit);
                            cmd.Parameters["@item_cat_active"].Value = item_cat_active;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar,50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar,50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }

        public static void save_item_details(string myQuery,string item_id,string item_cat_id ,string item_name, bool item_active, string usr_id_create, string usr_id_update, DateTime usr_date_update)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@item_id"].Value = item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_cat_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@item_cat_id"].Value = item_cat_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_name", SqlDbType.VarChar, 100);
                            cmd.Parameters["@item_name"].Value = item_name;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_active", SqlDbType.Bit);
                            cmd.Parameters["@item_active"].Value = item_active;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }


        public static void save_item_stock(string myQuery,string stock_id,DateTime stock_date,string item_id,decimal qty,string notes,string usr_id_create,string usr_id_update,DateTime usr_date_update)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stock_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@stock_id"].Value = stock_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stock_date", SqlDbType.Date);
                            cmd.Parameters["@stock_date"].Value = stock_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.VarChar, 100);
                            cmd.Parameters["@item_id"].Value = item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@qty", SqlDbType.Decimal);
                            cmd.Parameters["@qty"].Value = qty;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar,1000);
                            cmd.Parameters["@notes"].Value = notes;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }

        public static DataTable select_guardList(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }

        

        public static DataTable select_item_category_list(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }

        public static decimal select_item_available_stock(string myQuery,string item_id)
        {
            DataTable dt = new DataTable();
            decimal available_stock = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@item_id"].Value = item_id;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;
                            (new SqlDataAdapter(cmd)).Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtRow = dt.Rows[0];
                                available_stock = Convert.ToDecimal(dtRow["qty"]);
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return available_stock;
        }

        public static DataTable select_itemList(string myQuery,string category_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_cat_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@item_cat_id"].Value = category_id;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }


        #region StockOutManager
        public static void save_item_stockout_main(string myQuery,string stockout_main_id,DateTime stock_date,int item_count,string guard_id,string notes,string usr_id_create,string usr_id_update,DateTime usr_date_update)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stockout_main_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@stockout_main_id"].Value = stockout_main_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stock_date", SqlDbType.Date);
                            cmd.Parameters["@stock_date"].Value = stock_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_count", SqlDbType.Int);
                            cmd.Parameters["@item_count"].Value = item_count;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_id", SqlDbType.VarChar,50);
                            cmd.Parameters["@guard_id"].Value = guard_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 1000);
                            cmd.Parameters["@notes"].Value = notes;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }


        public static void save_item_stockout(string myQuery,string stockout_id,string stockout_main_id,string item_id,decimal qty,DateTime stock_date,string guard_id,string notes,string usr_id_create,string usr_id_update,DateTime usr_date_update)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stockout_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@stockout_id"].Value = stockout_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stockout_main_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@stockout_main_id"].Value = stockout_main_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@item_id"].Value = item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@qty", SqlDbType.Decimal);
                            cmd.Parameters["@qty"].Value = qty;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stock_date", SqlDbType.Date);
                            cmd.Parameters["@stock_date"].Value = stock_date;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@guard_id"].Value = guard_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 1000);
                            cmd.Parameters["@notes"].Value = notes;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }

        public static DataTable LoadStockOutRecord(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }

        public static DataTable select_line_items_by_stockoutmain_id(string myQuery,string stockout_main_id)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@stockout_main_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@stockout_main_id"].Value = stockout_main_id;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }

        public static decimal select_item_qty_assigned_to_guard(string myQuery, string item_id,string guard_id)
        {
            DataTable dt = new DataTable();
            decimal qty = 0;
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@item_id"].Value = item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_id", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@guard_id"].Value = guard_id;

                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }
                            cmd.Connection = conn;
                            (new SqlDataAdapter(cmd)).Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                DataRow dtRow = dt.Rows[0];
                                qty = decimal.Parse(dtRow["qty"].ToString());
                            }
                            else
                            {
                                qty = 0;
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return qty;
        }
        #endregion StockOutManager

        #region MissingItem
        public static void save_missing_item(string myQuery,string record_id,string item_id,string guard_id,DateTime date_lost,decimal qty, string notes, string usr_id_create, string usr_id_update, DateTime usr_date_update)
        {

            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
                        {
                            cmd.CommandTimeout = 3600;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                            cmd.Parameters["@QueryName"].Value = myQuery;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@record_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@record_id"].Value = record_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@item_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@item_id"].Value = item_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@guard_id", SqlDbType.VarChar, 50);
                            cmd.Parameters["@guard_id"].Value = guard_id;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@date_lost", SqlDbType.Date);
                            cmd.Parameters["@date_lost"].Value = date_lost;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@qty", SqlDbType.Decimal);
                            cmd.Parameters["@qty"].Value = qty;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 1000);
                            cmd.Parameters["@notes"].Value = notes;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_create", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_create"].Value = usr_id_create;

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@usr_id_update", SqlDbType.VarChar, 50);
                            cmd.Parameters["@usr_id_update"].Value = usr_id_update;

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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
        }

        public static DataTable select_lost_item_list(string myQuery)
        {
            DataTable dt = new DataTable();
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Inventory", conn))
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
                if (InventoryManager.conn.State == ConnectionState.Open)
                {
                    InventoryManager.conn.Close();
                }
            }
            return dt;
        }
        #endregion MissingItem
    }
}
