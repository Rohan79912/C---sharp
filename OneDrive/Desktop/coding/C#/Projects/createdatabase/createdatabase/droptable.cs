using System;
using System.Data.SqlClient;

namespace DropTableAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;Database=Shreya;User ID=sa;Password=tiger;";

            // 🔹 SQL query to drop table
            string query = @"
                IF OBJECT_ID('Student', 'U') IS NOT NULL
                DROP TABLE Student;
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine(" Table 'Student' dropped successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
