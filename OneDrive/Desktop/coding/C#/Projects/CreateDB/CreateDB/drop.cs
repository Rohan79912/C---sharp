using System;
using System.Data.SqlClient;

namespace CreateDB
{
    class drop
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string cs = "Server=LAPTOP-RMTS0624\\SQLEXPRESS; Database=master; User ID=sa; Password=tiger;";


            string query = @"drop  database Student ;";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("  drop database  successfully!");
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
