using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json.Linq;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Files
{
    public class LearningFiles
    {
        public static void Run()
        {
            WebClients();
        }

        private static void WebClients()
        {
            string url = "https://gorest.co.in/public-api/categories";   
            WebClient client = new WebClient();
            string results = client.DownloadString(url);
            Console.WriteLine(results);
        }

        private static void WebRequestsJSON()
        {
            string url = "https://gorest.co.in/public-api/categories";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string apiResult = reader.ReadToEnd();
                JObject jsonResult = JObject.Parse(apiResult);

                var data =
                    from entry in jsonResult["data"]
                    select entry;
                
                ConsoleUtil.Display(data);
            }
        }

        private static void WebRequests()
        {
            string url = "https://google.com";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string pageContent = reader.ReadToEnd();
                Console.WriteLine(pageContent);
            }
        }

        private static void Directories()
        {
            string dirPath = "/Users/bonifacechacha/Projects/softnet/training/data";
            Directory.CreateDirectory(dirPath);
            Thread.Sleep(5000);
            Directory.Delete(dirPath);
        }

        private static void FileInfos()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file4.txt";
            File.WriteAllText(filePath, "Working with file infos");

            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Directory);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.Attributes);

            Console.WriteLine("Hiding the file");
            fileInfo.Attributes |= FileAttributes.Hidden;
            Console.WriteLine(fileInfo.Attributes);
        }

        private static void Drives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine(
                        $"{drive.Name,30} | {drive.DriveFormat,-10} | {drive.DriveType,-10} | {drive.TotalSize,20}");
                }
                else
                {
                    Console.WriteLine($"{drive.Name,30} | Drive is not ready");
                }
            }
        }

        private static void FileUtils()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file3.txt";
            File.WriteAllText(filePath, "Writing using File class");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }

        private static void StreamReaderWriter()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file2.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello streams");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }

        private static void FileStreams()
        {
            String content = "This is sample text";
            byte[] contentBytes = Encoding.Default.GetBytes(content);

            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file1.txt";
            FileStream outputStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            outputStream.Write(contentBytes, 0, contentBytes.Length);
            outputStream.Close();

            FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            byte[] readBytes = new byte[inputStream.Length];
            inputStream.Read(readBytes, 0, readBytes.Length);
            inputStream.Close();

            string readContent = Encoding.Default.GetString(readBytes);
            Console.WriteLine(readContent);
        }
    }
}