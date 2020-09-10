using System;
using System.IO;

namespace SoftNetTraining.Lecture5
{
    public class LearningText
    {
        public static void Run()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file2.txt";

            string contentToWrite = "Hello world, we know C#";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(contentToWrite);
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}