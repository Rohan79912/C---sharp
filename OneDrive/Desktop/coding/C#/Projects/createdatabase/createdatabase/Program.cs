using System;
using System.Data.SqlClient;  // ✅ Required for SQL classes
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createdatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string to SQL Server (connect to master DB)
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;User ID=sa;Password=tiger;Database=master;";

            // 🔹 Ask user for database name
            Console.Write("Enter new database name: ");
            string databaseName = Console.ReadLine();

            // 🔹 SQL query to create database
            string query = $"CREATE DATABASE [{databaseName}]";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Open connection
                    con.Open();

                    // Create and execute command
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine($"✅ Database '{databaseName}' created successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
