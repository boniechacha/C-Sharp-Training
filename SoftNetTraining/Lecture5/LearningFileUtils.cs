using System;
using System.IO;

namespace SoftNetTraining.Lecture5
{
    public class LearningFileUtils
    {
        public static void Run()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file1.txt";
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            
            string filePath2 = "/Users/bonifacechacha/Projects/softnet/training/file11.txt";
            File.Create(filePath2);
            
            File.Encrypt(filePath);

        }
    }
}