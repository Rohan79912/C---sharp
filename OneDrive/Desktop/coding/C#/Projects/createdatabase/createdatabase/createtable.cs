using System;
using System.Data.SqlClient;

namespace CreateTableAuto
{
    class Program
    {
        static void main(string[] args)
        {
            // 🔹 Update this connection string for your SQL Server setup
            string connectionString = "Server=LAPTOP-RMTS0624\\SQLEXPRESS;Database=Shreya;User ID=sa;Password=tiger;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(" Connection successful!");

                    // 🔹 SQL to create a table if it doesn't exist
                    string createTableQuery = @"
                        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employee' AND xtype='U')
                        CREATE TABLE Employee (
                            Id INT IDENTITY(1,1) PRIMARY KEY,
                            Name NVARCHAR(100),
                            Age INT
                        );
                    ";

                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine(" Table 'Employee' created successfully!");
                    }

                    // 🔹 Insert one record
                    string insertQuery = "INSERT INTO Employee (Name, Age) VALUES ('Rohan', 21);";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        int rows = insertCmd.ExecuteNonQuery();
                        Console.WriteLine($" Record inserted successfully! Rows affected: {rows}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine(" Connection closed.");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
