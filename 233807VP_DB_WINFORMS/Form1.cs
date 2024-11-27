using System;
using System.Data.SqlClient;

namespace _233807VP_DB_WINFORMS
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=mysqlserver;Integrated Security=true;";

        // Create database if it does not exist
        public static void CreateDatabaseAndTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string createDbQuery = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'CustomerDB') " +
                                           "BEGIN " +
                                           "CREATE DATABASE CustomerDB; " +
                                           "END";

                    SqlCommand cmd = new SqlCommand(createDbQuery, conn);
                    cmd.ExecuteNonQuery();

                    conn.ChangeDatabase("CustomerDB");

                    string createTableQuery = @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
                                                BEGIN
                                                    CREATE TABLE Customers (
                                                        CustomerID INT PRIMARY KEY IDENTITY(1,1),
                                                        CustomerName NVARCHAR(100),
                                                        Country NVARCHAR(100),
                                                        Gender NVARCHAR(50),
                                                        Hobbies NVARCHAR(200),
                                                        Status NVARCHAR(50)
                                                    );
                                                END";
                    cmd = new SqlCommand(createTableQuery, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error creating database or table: " + ex.Message);
                }
            }
        }

        // Insert data into the database
        public static void InsertCustomer(string customerName, string country, string gender, string hobbies, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    conn.ChangeDatabase("CustomerDB");

                    string insertQuery = "INSERT INTO Customers (CustomerName, Country, Gender, Hobbies, Status) " +
                                         "VALUES (@CustomerName, @Country, @Gender, @Hobbies, @Status)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Hobbies", hobbies);
                    cmd.Parameters.AddWithValue("@Status", status);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inserting data: " + ex.Message);
                }
            }
        }

        // Fetch data from the database (for example, to display customer details)
        public static void FetchCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    conn.ChangeDatabase("CustomerDB");

                    string selectQuery = "SELECT * FROM Customers";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["CustomerID"]}: {reader["CustomerName"]}, {reader["Country"]}, {reader["Gender"]}, {reader["Hobbies"]}, {reader["Status"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching data: " + ex.Message);
                }
            }
        }
    }
}
