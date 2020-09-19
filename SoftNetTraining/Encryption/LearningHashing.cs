using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftNetTraining.Encryption
{
    public class LearningHashing
    {
        static byte[] CalculateHash(string source)
        {

            byte[] sourceBytes = Encoding.ASCII.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();

            byte[] hash = hasher.ComputeHash(sourceBytes);

            return hash;
        }

        static void ShowHash(string source)
        {
            
            byte[] hash = CalculateHash(source);
            DumpBytes($"Hash for {source} is: ",hash);
            
        }

        public static void Run()
        {
            ShowHash("Hello world");
            ShowHash("world Hello");
            ShowHash("Hemmm world");

            Console.ReadKey();
        }
        
        public static void DumpBytes(string title, byte[] bytes)
        {
            Console.Write(title);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }

            Console.WriteLine();
        }
    }
}