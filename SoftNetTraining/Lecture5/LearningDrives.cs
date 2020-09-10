using System;
using System.IO;

namespace SoftNetTraining.Lecture5
{
    public class LearningDrives
    {
        public static void Run()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"{drive.Name,-30} {drive.DriveFormat,-7} {drive.RootDirectory,-30} {drive.TotalSize,20}");
                }
                else
                {
                    Console.WriteLine($"{drive.Name} is not ready");
                }
                
            }
        }
    }
}