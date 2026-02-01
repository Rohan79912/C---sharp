using System;
using System.Data.SqlClient;

namespace CreateDB
{
    class record
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string cs = "Server=LAPTOP-RMTS0624\\SQLEXPRESS; Database=Rohan; User ID=sa; Password=tiger;";


            string query = @"SELECT * from rohan;";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("data retrieved successfully!");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]}  \nName: {reader["name"]}");
                            
                        }
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
