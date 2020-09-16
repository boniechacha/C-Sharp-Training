using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftNetTraining.Encryption
{
    public class LearningHashing
    {
        static byte[] calculateHash(string source)
        {

            byte[] sourceBytes = Encoding.ASCII.GetBytes(source);

            HashAlgorithm hasher = SHA256.Create();

            byte[] hash = hasher.ComputeHash(sourceBytes);

            return hash;
        }

        static void showHash(string source)
        {
            
            byte[] hash = calculateHash(source);
            DumpBytes($"Hash for {source} is: ",hash);
            
        }

        public static void Run()
        {
            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");

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