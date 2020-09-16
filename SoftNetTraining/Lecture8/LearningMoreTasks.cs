using System;
using System.Collections;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using SoftNetTraining.Lecture9;

namespace SoftNetTraining
{
    public class LearningMoreTasks
    {
        
        private static void WaitContinue()
        {
            Task t = Task.Run(
                () =>
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Doing the task");
                }
            );

            Task contTask = t.ContinueWith(
                (task) =>
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Completed");
                }
            );

            contTask.Wait();
            
            
            
            Task t1 = Task.Run(
                () =>
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Doing the T1");
                }
            );

            Task t2 = Task.Run(
                () =>
                {
                    Task.Delay(4000).Wait();
                    Console.WriteLine("Doing the T2");
                }
            );

            Task t3 = Task.Run(
                () =>
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Doing the T3");
                }
            );

            // Task.WaitAll(t1, t2, t3);
            
            Task.WaitAny(t1, t2, t3);
        }


        private static void Continuing()
        {
            Console.WriteLine("Programs starts ...");

            Func<int> a = () =>
            {
                Task.Delay(3000).Wait();
                return 2 * 3;
            };

            Action<Task<int>> s = (m) => { Console.WriteLine(m.Result); };

            Action<Task<int>> f = (m) => { Console.WriteLine("Failed to execute"); };

            Task<int> t1 = Task.Run(a);
            t1.ContinueWith(s, TaskContinuationOptions.OnlyOnRanToCompletion);
            t1.ContinueWith(f, TaskContinuationOptions.OnlyOnFaulted);


            //
            // Task<int> t2 = Task.Run(a);
            // Task completedT2 = t2.ContinueWith(c);
            //
            // Task<int> t3 = Task.Run(a);
            // t3.ContinueWith(c);
            //
            //
            // Task<int> t4 = Task.Run(a);


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }


        public static void Tasks()
        {
            Task<string> t3 = Task.Run(
                () => { return "Hellow world"; }
            );
            Console.WriteLine(t3.Result);

            Task<int> t2 = Task.Run(
                () =>
                {
                    Task.Delay(1000).Wait();
                    // Thread.Sleep(2000);
                    return 2 * 3;
                }
            );
            Console.WriteLine(t2.Result);


            Task t1 = Task.Run(
                () =>
                {
                    Task.Delay(1000).Wait();
                    Console.WriteLine("Executing a task ..");
                }
            );

            t1.Wait();
        }


        public static void ParametersDownloadServer()
        {
            ParameterizedThreadStart x = (input) =>
            {
                string serverName = (string) input;
                string data = new WebClient().DownloadString(serverName);
                Console.WriteLine($"{serverName} {data.Substring(0, 100)}");
            };


            string url1 = "http://www.immigration.go.tz";
            Thread t1 = new Thread(x);
            t1.Name = "T1";
            t1.Start(url1);


            string url2 = "http://www.google.com";
            Thread t2 = new Thread(x);
            t2.Name = "T2";
            t2.Start(url2);
        }


        public static void Parameters()
        {
            ParameterizedThreadStart x = (input) =>
            {
                int val = (int) input;
                for (int i = 0; i < val; i++)
                {
                    string tName = Thread.CurrentThread.Name;
                    Thread.Sleep(300);
                    Console.WriteLine($"{i} {tName}");
                }
            };


            Thread t1 = new Thread(x);
            t1.Name = "T1";
            t1.Start(10);

            Thread t2 = new Thread(x);
            t2.Name = "T2";
            t2.Start(20);
        }


        public static void ParamaterizedThreads()
        {
            ParameterizedThreadStart x = (input) => { Console.WriteLine($"Thread 1 {input}"); };


            Thread t1 = new Thread(x);
            t1.Start("Hello");

            Thread t2 = new Thread(x);
            t2.Start("Hi");
        }

        private static void StartingThreads()
        {
            Thread t1 = new Thread(
                () =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        int threadId = Thread.CurrentThread.ManagedThreadId;
                        string threadName = Thread.CurrentThread.Name;

                        Thread.Sleep(500);
                        Console.WriteLine($"T {threadId} {threadName} : {i}");
                    }
                }
            );
            t1.Name = "First Thread";
            t1.Start();

            Thread t2 = new Thread(
                () =>
                {
                    for (int i = 0; i < 30; i++)
                    {
                        int threadId = Thread.CurrentThread.ManagedThreadId;
                        string threadName = Thread.CurrentThread.Name;

                        Thread.Sleep(500);
                        Console.WriteLine($"T {threadId} {threadName} : {i}");
                    }
                }
            );
            t2.Name = "Second Thread";
            t2.Start();
        }

        private static void StartingThreads2()
        {
            ThreadStart m = () =>
            {
                for (int i = 0; i < 30; i++)
                {
                    int threadId = Thread.CurrentThread.ManagedThreadId;
                    string threadName = Thread.CurrentThread.Name;

                    Thread.Sleep(500);
                    Console.WriteLine($"T {threadId} {threadName} : {i}");
                }
            };


            Thread t1 = new Thread(m);
            t1.Name = "First Thread";
            t1.Start();

            Thread t2 = new Thread(m);
            t2.Name = "Second Thread";
            t2.Start();
        }
    }
    
}