using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace SoftNetTraining.Lecture5
{
    public class LearningFileInfo
    {
        public static void Run()
        {
            string filePath = Path.Combine(Path.GetTempPath(), "file1.txt");
        }

        private static void Directories()
        {
            string dirPath = "/Users/bonifacechacha/Projects/softnet/training/data";
            Directory.CreateDirectory(dirPath);
            Directory.Delete(dirPath);
        }

        public static void FileInfos()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/file1.txt";
            FileInfo info = new FileInfo(filePath);

            Console.WriteLine(info.Directory);
            Console.WriteLine(info.Length);
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.IsReadOnly);
            Console.WriteLine(info.Exists);
            Console.WriteLine(info.Attributes);

            Console.WriteLine("Hiding the file");
            info.Attributes |= FileAttributes.Hidden;
            // info.Attributes |= FileAttributes.ReadOnly;
            Console.WriteLine(info.Attributes);
            info.Attributes &= ~FileAttributes.Hidden;
        }
    }
}