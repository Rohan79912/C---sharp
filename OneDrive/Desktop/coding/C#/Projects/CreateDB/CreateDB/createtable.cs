using System;
using System.Data.SqlClient;

namespace CreateDB
{
    class createtable
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string cs = "Server=LAPTOP-RMTS0624\\SQLEXPRESS; Database=Rohan; User ID=sa; Password=tiger;";


            string query = @" Create table rohan( id int primary key, name varchar(20));";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("  created 'Table'  successfully!");
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
