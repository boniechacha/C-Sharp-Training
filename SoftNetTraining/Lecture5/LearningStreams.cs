using System;
using System.IO;
using System.Text;

namespace SoftNetTraining.Lecture5
{
    public class LearningStreams
    {
        public static void Run()
        {
            WritFileStream();
            ReadFileStream();
        }

        private static void ReadFileStream()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file1.txt";

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] readBytes = new byte[inputStream.Length];
                inputStream.Read(readBytes, 0, readBytes.Length);
                
                string readContent = Encoding.Default.GetString(readBytes);
                Console.WriteLine(readContent);
            }
            
        }


        private static void WritFileStream()
        {
            string content = "We are the gurus of C#";
            byte[] contentBytes = Encoding.Default.GetBytes(content);

            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file1.txt";

            FileStream outputStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            outputStream.Write(contentBytes, 0, contentBytes.Length);
            outputStream.Close();
        }
    }
}