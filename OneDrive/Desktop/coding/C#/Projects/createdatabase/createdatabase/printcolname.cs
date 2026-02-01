using System;
using System.Data.SqlClient;

namespace PrintTableColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Update this connection string with your SQL Server credentials
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;Database=Shreya;User ID=sa;Password=tiger;";

            // 🔹 Table name you want to inspect
            string tableName = "Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine($" Connected to database '{connection.Database}'");

                    // 🔹 Query to get column names from the system catalog
                    string query = @"
                        SELECT COLUMN_NAME
                        FROM INFORMATION_SCHEMA.COLUMNS
                        WHERE TABLE_NAME = @TableName;
                    ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableName", tableName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine($"\n Columns in table '{tableName}':");

                            if (!reader.HasRows)
                            {
                                Console.WriteLine(" No columns found (check if table exists).");
                            }

                            while (reader.Read())
                            {
                                Console.WriteLine(" - " + reader["COLUMN_NAME"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine(" Connection closed.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
