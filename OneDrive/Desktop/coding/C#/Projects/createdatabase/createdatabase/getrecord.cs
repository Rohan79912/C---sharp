using System;
using System.Data.SqlClient;

namespace GetRecordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Update your SQL Server connection info here
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;Database=Shreya;User ID=sa;Password=tiger;";

            // 🔹 Table name to fetch records from
            string tableName = "Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine($"✅ Connected to database '{connection.Database}'");

                    // 🔹 SQL query to get all records
                    string query = $"SELECT * FROM {tableName};";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine($"⚠️ No records found in table '{tableName}'.");
                        }
                        else
                        {
                            Console.WriteLine($"\n📋 Records from '{tableName}':\n");

                            // 🔹 Print column headers
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetName(i) + "\t");
                            }
                            Console.WriteLine("\n" + new string('-', 50));

                            // 🔹 Print all rows
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write(reader[i].ToString() + "\t");
                                }
                                Console.WriteLine();
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
                    Console.WriteLine("\n🔒 Connection closed.");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
