using System;
using System.Threading;
using System.Threading.Tasks;

namespace SoftNetTraining.Lecture9
{
    public class ReadingUser
    {
        public static void Run()
        {
            PrintingUserWithWait();
            Count0To9();
        }

        private static void Count0To9()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }

        private static async void PrintingUserWithWait()
        {
            string user1 = await GetUserAsync(1);
            Console.WriteLine($"First {user1}");
            
            string user2 =  await GetUserAsync(2);
            Console.WriteLine($"Second {user2}");
            
            Console.WriteLine($"{user1}  {user2}");
        }
        
        private static void PrintingUser()
        {
            string user1 = GetUser(1);
            Console.WriteLine($"{user1}");
        }

        public static string GetUser(int studentId)
        {
            Task<string> task = GetUserAsync(studentId);
            string student = task.Result;
            return student;
        }

        public static Task<string> GetUserAsync(int studentId)
        {
            Task<string> task = Task.Run(
                () =>
                {
                    Task.Delay(2000).Wait();
                    return $"Student : {studentId}";
                }
            );

            return task;
        }
    }
}