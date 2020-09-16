using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Renci.SshNet.Security.Cryptography;

namespace SoftNetTraining.Lecture9
{
    public class LearningConcurrentCollections
    {

        public static void Run()
        {
            BlockingCollection<Book> books = new BlockingCollection<Book>();
            
            Task consumer = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(books.Take());
                }
            });

            int i = 0;
            while (true)
            {
                Console.ReadLine();
                Book book = new Book($"Author {i}", $"Book {i}", i);
                books.Add(book);
                i++;
            }

        }
    }
}