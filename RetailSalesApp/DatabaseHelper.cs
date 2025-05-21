using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RetailSalesApp
{
    public static class DatabaseHelper
    {
        private static string connStr = "Data Source=192.168.100.69;Initial Catalog=Tests;User ID=TestUser;Password=444";
        //private static string connStr = "Data Source=localhost;Initial Catalog=RetailDB;Integrated Security=True";

        public static List<SaleItem> LoadItems()
        {
            List<SaleItem> items = new List<SaleItem>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Guid, NameA, Price FROM TB_ITM", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new SaleItem
                    {
                        ItemGuid = reader.GetGuid(0),
                        Name = reader.GetString(1),
                        UnitPrice = reader.GetDecimal(2)
                    });
                }
            }
            return items;
        }

        public static void InsertSale(SaleItem item)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO TB_Sales 
                (ItemGuid, Quantity, UnitPrice, SubTotal, VAT, Total) 
                VALUES (@ItemGuid, @Qty, @UnitPrice, @SubTotal, @VAT, @Total)", conn);

                cmd.Parameters.AddWithValue("@ItemGuid", item.ItemGuid);
                cmd.Parameters.AddWithValue("@Qty", item.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                cmd.Parameters.AddWithValue("@SubTotal", item.SubTotal);
                cmd.Parameters.AddWithValue("@VAT", item.VAT);
                cmd.Parameters.AddWithValue("@Total", item.Total);

                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetSalesByDate(DateTime from, DateTime to)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM TB_Sales 
                WHERE SaleDate BETWEEN @From AND @To", conn);
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@To", to);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }

}
