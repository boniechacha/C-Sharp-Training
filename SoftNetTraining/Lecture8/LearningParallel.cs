using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using SoftNetTraining.Threads;

namespace SoftNetTraining
{
    public class LearningParallel
    {
        static string BASE_DIR = "/Users/bonifacechacha/Projects/softnet/training";

        public static void DownloadParallel()
        {
            string[] urls =
            {
                "http://www.google.com",
                "http://www.facebook.com",
                "http://www.twitter.com",
                "http://www.instagram.com",
                "http://www.badoo.com",
                "http://www.jamiiforums.com"
            };


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.ForEach(
                urls,
                (url) =>
                {
                    Console.WriteLine($"Downloading {url}");

                    string[] urlParts = url.Split(".");
                    string name = urlParts[1];
                    
                    string content = new WebClient().DownloadString(url);
                    File.WriteAllText($"{BASE_DIR}/{name}.txt", content);

                }
            );

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            
            
            stopwatch.Restart();

            Parallel.For(
                0,
                urls.Length,
                (urlIndex) =>
                {
                    string url = urls[urlIndex];
                    
                    Console.WriteLine($"Downloading {url}");

                    string[] urlParts = url.Split(".");
                    string name = urlParts[1];
                    
                    string content = new WebClient().DownloadString(url);
                    File.WriteAllText($"{BASE_DIR}/{name}.txt", content);

                }
            );

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }


        public static void RunParallel()
        {
            Parallel.For(
                0,
                10,
                i =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(i);
                }
            );

            for (int i = 0; i < 10; i++)
            {
            }


            List<Book> values = new List<Book>();
            Parallel.ForEach(
                values,
                i => { Console.WriteLine(i); }
            );

            foreach (var i in values)
            {
                Console.WriteLine(i);
            }
        }


        public static void Run()
        {
            string[] urls =
            {
                "http://www.google.com",
                "http://www.facebook.com",
                "http://www.twitter.com",
                "http://www.instagram.com",
                "http://www.badoo.com",
                "http://www.jamiiforums.com"
            };


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int fileNo = 0;
            foreach (string url in urls)
            {
                Console.WriteLine($"Downloading {url}");

                string content = new WebClient().DownloadString(url);
                File.WriteAllText($"{BASE_DIR}/file{fileNo++}.txt", content);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


            stopwatch.Restart();


            List<Task> allTasks = new List<Task>();

            foreach (string url in urls)
            {
                Console.WriteLine($"Starting task for {url}");

                Task task = Task.Run(() =>
                {
                    Console.WriteLine($"Downloading {url}");

                    string content = new WebClient().DownloadString(url);
                    File.WriteAllText($"{BASE_DIR}/file{fileNo++}.txt", content);
                });

                allTasks.Add(task);
            }

            Task.WaitAll(allTasks.ToArray());

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}