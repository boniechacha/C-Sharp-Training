using System;
using System.Data.SqlClient;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture6
{
    public class LearningMSSQL
    {
        public static string CONN_STRING = "Data Source=172.20.10.2;Initial Catalog=school;User ID=sa;Password=saby";

        public static void Run()
        {
            Console.WriteLine("1. List all student");
            Console.WriteLine("2. Register new student");
            Console.WriteLine("3. Update existing student");
            Console.WriteLine("4. Remove existing student");
            Console.WriteLine("5. Quit");

            int choice = ConsoleUtil.CaptureInputInt("Select your option", 1, 5);

            switch (choice)
            {
                case 1:
                    ListAllStudents();
                    break;
                case 2:
                    RegisterNewStudent();
                    break;
                case 3:
                    UpdateExistingStudent();
                    break;
                case 4:
                    RemoveStudent();
                    break;
                case 5:
                    Console.WriteLine("Thank you!");
                    return;
                default:
                    Console.WriteLine("We are not suppose to reach here");
                    break;
            }
            
            Run();
        }

        private static void ListAllStudents()
        {
            Reading();
        }


        private static void RegisterNewStudent()
        {
            string name = ConsoleUtil.CaptureInputString("What is the student name?");
            string course = ConsoleUtil.CaptureInputString("Which course does student take?");
            string campus = ConsoleUtil.CaptureInputString("Which campus does he attend?");

            Inserting(name, course, campus);
        }

        private static void RemoveStudent()
        {
            int stId = ConsoleUtil.CaptureInputInt("Enter student id to be removed", 0, Int32.MaxValue);
            Deleting(stId);
        }

        private static void UpdateExistingStudent()
        {
        }

        private static void Deleting(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(CONN_STRING))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server.");

                string sqlStatement = "DELETE FROM Student WHERE Id = @id";
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@id", studentId);
                int rowDeleted = command.ExecuteNonQuery();

                Console.WriteLine($"{rowDeleted} deleted");
            }
        }

        private static void Updating(int studentId, string newName, string newCourse, string newCampus)
        {
            using (SqlConnection connection = new SqlConnection(CONN_STRING))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server.");

                string sqlStatement = "UPDATE Student SET Name=@name, Course=@course,Campus=@campus WHERE Id = @id";
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.AddWithValue("@id", studentId);
                command.Parameters.AddWithValue("@name", newName);
                command.Parameters.AddWithValue("@course", newCourse);
                command.Parameters.AddWithValue("@campus", newCampus);

                int rowsUpdated = command.ExecuteNonQuery();
                Console.WriteLine("{0} rows updated", rowsUpdated);
            }
        }

        private static void Inserting(string name, string course, string campus)
        {
            using (SqlConnection connection = new SqlConnection(CONN_STRING))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server.");

                string sqlStatement = "INSERT INTO Student(Name, Course,Campus) VALUES(@name,@course,@campus);";
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@course", course);
                command.Parameters.AddWithValue("@campus", campus);

                int rowsInserted = command.ExecuteNonQuery();
                Console.WriteLine("{0} inserted", rowsInserted);
            }
        }


        private static void Reading()
        {
            using (SqlConnection connection = new SqlConnection(CONN_STRING))
            {
                connection.Open();
                Console.WriteLine("Connected to SQL Server.");

                string sqlStatement = "SELECT Id,Name,Course,Campus FROM Student;";
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("{0,10} {1,30} {2,10} {3,15}", "ID", "NAME", "COURSE", "CAMPUS");
                while (reader.Read())
                {
                    int id = (int) reader["Id"];
                    string name = (string) reader["Name"];
                    string course = (string) reader["Course"];
                    string campus = (string) reader["Campus"];

                    Console.WriteLine($"{id,10} {name,30} {course,10} {campus,15}");
                }
            }
        }
    }
}