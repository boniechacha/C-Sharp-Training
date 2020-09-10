using System;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace SoftNetTraining.Lecture5
{
    public class LearningWeb
    {
        public static void Run()
        {
            string url = "https://gorest.co.in/public-api/categories";

            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            
            JObject json = JObject.Parse(content);
            Console.WriteLine(json);
        }

        private static void WebRequests()
        {
            string url = "https://gorest.co.in/public-api/categories";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string content = reader.ReadToEnd();

                JObject contentJSON = JObject.Parse(content);
                var data = contentJSON["data"];

                var result =
                    from c in data
                    where c["name"].ToString().Contains("Computer")
                    select c;

                foreach (var d in result)
                {
                    Console.WriteLine($"{d["id"],10} | {d["name"],-40} | {d["status"],-10}");
                }
            }
        }
    }
}