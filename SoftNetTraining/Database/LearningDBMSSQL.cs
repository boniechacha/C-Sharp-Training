using SoftNetTraining.Files;
using SoftNetTraining.Lecture5;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace SoftNetTraining.Database
{
    public class LearningDBMSSQL
    {
        public static void Run()
        {
            Inserting();
        }

        private static void Inserting()
        {
            string connString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string statement = "INSERT INTO Student([Name], [Course],[Campus]) VALUES(@name, @course,@campus);";
                SqlCommand command = new SqlCommand(statement, connection);
                command.Parameters.AddWithValue("@name", "Boniface");
                command.Parameters.AddWithValue("@course", "ML");
                command.Parameters.AddWithValue("@campus", "Posta");

                int affectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} rows inserted");
            }
        }

        private static void Connecting()
        {
            string connString = ConfigurationManager.ConnectionStrings["MSSQL"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server");
            }
        }
    }
}