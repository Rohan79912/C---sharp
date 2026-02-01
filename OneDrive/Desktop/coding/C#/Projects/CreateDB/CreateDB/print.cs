using System;
using System.Data.SqlClient;

namespace CreateDB
{
    class print
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string cs = "Server=LAPTOP-RMTS0624\\SQLEXPRESS; Database=Rohan; User ID=sa; Password=tiger;";


            string query = @"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'rohan';";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("Columns retrieved successfully!");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["COLUMN_NAME"]);
                           //Console.WriteLine("Columns retrieved successfully!");
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
