using System;
using System.Data.SqlClient;

namespace InsertRecordAuto
{
    class Program
    {
        static void main(string[] args)
        {
            //  Connection string — same as before
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;Database=Shreya;User ID=sa;Password=tiger;";

            //  SQL query to insert a record (static data)
            string query = @"
                INSERT INTO Employee (Name, age)
                VALUES ('Rohan Maurya', '20');
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();
                        Console.WriteLine($" Record inserted successfully! ({rows} row(s) affected)");
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
