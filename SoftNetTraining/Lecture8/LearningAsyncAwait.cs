using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace SoftNetTraining
{
    public class LearningAsyncAwait
    {
        
        public static void Run2()
        {
        }
        
        public static void Run1()
        {
            DownloadingFromURLS();
            Console.WriteLine("Hello Async");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }

        public async static void DownloadingFromURLS()
        {
            string url = "http://www.google.com";

            WebClient client = new WebClient();
            // string result = await client.DownloadStringTaskAsync(url);
            string result = await DownloadString(url);
            Console.WriteLine(result.Substring(0, 50));
        }

        public static Task<string> DownloadString(string url)
        {
            Task<string> task = Task.Run(
                () =>
                {
                    Console.WriteLine($"Downloading {url}");
                    string result = new WebClient().DownloadString(url);
                    return result;
                }
            );

            return task;
        }
    }
}