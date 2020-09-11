using SoftNetTraining.Files;
using SoftNetTraining.Lecture5;
using System;
using System.Configuration;
using System.Transactions;
using MySql.Data.MySqlClient;

namespace SoftNetTraining.Database
{
    public class LearningDB
    {
        public static void Run()
        {
            InsertingTransactional();
        }

        private static void InsertingTransactional()
        {
            string connString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;

            using (TransactionScope transaction = new TransactionScope())
            {
                Console.WriteLine("Beginning transaction");
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    string statement = "INSERT INTO student(name, course) VALUES(@name, @course);";
                    MySqlCommand command1 = new MySqlCommand(statement, connection);
                    command1.Parameters.AddWithValue("@name", "Chacha");
                    command1.Parameters.AddWithValue("@course", "IT");

                    int affectedRows1 = command1.ExecuteNonQuery();
                    Console.WriteLine($"{affectedRows1} rows inserted");

                    MySqlCommand command2 = new MySqlCommand(statement, connection);
                    command2.Parameters.AddWithValue("@name", "Marwa");
                    command2.Parameters.AddWithValue("@course", "Arts");

                    int affectedRows2 = command2.ExecuteNonQuery();
                    Console.WriteLine($"{affectedRows2} rows inserted");
                }

                transaction.Complete();
            }
        }

        private static void Inserting()
        {
            string connString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string statement = "INSERT INTO student(name, course) VALUES(@name, @course);";
                MySqlCommand command = new MySqlCommand(statement, connection);
                command.Parameters.AddWithValue("@name", "Chacha");
                command.Parameters.AddWithValue("@course", "IT");

                int affectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} rows inserted");
            }
        }

        private static void Updating()
        {
            string connString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string statement = "update student set name='Boniface' where id=1;";
                MySqlCommand command = new MySqlCommand(statement, connection);
                int affectedRows = command.ExecuteNonQuery();
                Console.WriteLine($"{affectedRows} rows updated");
            }
        }

        private static void Selecting()
        {
            string connString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;

            Console.WriteLine(connString);
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine("Connected to MySQL");

                string SQL = "select id,name,course from student";
                MySqlCommand command = new MySqlCommand(SQL, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"],-10} | {reader["name"],-40}");
                }
            }
        }
    }
}