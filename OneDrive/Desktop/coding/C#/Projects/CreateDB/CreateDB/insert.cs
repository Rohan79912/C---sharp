using System;
using System.Data.SqlClient;

namespace CreateDB
{
    class insert
    {
        static void Main(string[] args)
        {
            // 🔹 Connection string — same as before
            string cs = "Server=LAPTOP-RMTS0624\\SQLEXPRESS; Database=Rohan; User ID=sa; Password=tiger;";


            string query = @" insert into  rohan( id , name ) values (2, 'Abhay');";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("insert data into table successfully!");
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
