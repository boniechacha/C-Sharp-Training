using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace SoftNetTraining.Threads
{
    public class Parallels
    {
        public static void Run()
        {
            Parallel.For(
                0,
                10,
                i =>
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                });

            Parallel.ForEach(
                new[] {"hello", "world", "it's", "me", "magret"},
                inpt => { Console.WriteLine(inpt); }
            );
        }


        public static void Demo()
        {
            string BASE_API = "https://gorest.co.in/public-api";
            string BASE_DIR = "/Users/bonifacechacha/Projects/softnet/training";

            string[] dataPaths = {"users", "posts", "comments", "todos", "categories", "products"};

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            foreach (string path in dataPaths)
            {
                string json = new WebClient().DownloadString($"{BASE_API}/{path}");
                File.WriteAllText($"{BASE_DIR}/{path}.json", json);
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);


            stopWatch.Restart();

            Parallel.ForEach(
                dataPaths,
                path =>
                {
                    string json = new WebClient().DownloadString($"{BASE_API}/{path}");
                    File.WriteAllText($"{BASE_DIR}/{path}.json", json);
                });

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }
    }
}