using System;
using System.Collections.Generic;
using System.Linq;
using SoftNetTraining.Banking;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningLINQ
    {
        public static void Run()
        {
            //List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result1 = from i in values
            //              where i > 5
            //              orderby i descending
            //              select i;

            //foreach (int i in result1)
            //{
            //    Console.WriteLine(i);
            //}


            var accounts = new List<Account>();

            Current a1 = new Current("Chacha", "123");
            Current a2 = new Current("Michael", "876");
            Saving a3 = new Saving("Ferouz", "789", 1000);

            accounts.Add(a1);
            accounts.Add(a2);
            accounts.Add(a3);

            List<Book> books = new List<Book>();
            
            Book b1 = new Book("Chacha", "Fall Apart", 340);
            Book b2 = new Book("Michael", "Zawadi ya Ushindi", 120);
            Book b3 = new Book("Chacha", "Machozi Jasho Na Damu", 987);
            Book b4 = new Book("Chacha", "Programming in C#", 70);
            Book b5 = new Book("Michael", "Tutarudi na roho zetu", 600);

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);
            books.Add(b5);

            var groupResults = 
                from book in books
                group book by book.Author
                into bookGroups
                select new
                {
                    auth = bookGroups.Key,
                    cnt = bookGroups.Count(),
                    maxPages = bookGroups.Max(
                           b =>
                           {
                               return b.Pages;
                           }

                        ),
                    minPages = bookGroups.Min(
                           b =>
                           {
                               return b.Pages;
                           }

                        )
                };

            foreach (var entry in groupResults)
            {
                Console.WriteLine(entry);
            }


            var joinResults = from acc in accounts
                join book in books
                    on acc.Name equals book.Author
                select new {acc, book};

            foreach (var v in joinResults)
            {
                Console.WriteLine($"{v.acc.Name,-15} {v.acc.Number,15}  {v.book.Author,-15} {v.book.Title,-30}");
            }


            //var result = from acc in accounts select acc;

            //var result2 = from acc in accounts
            //              where acc.Name == "Chacha" && acc.Number=="123"
            //              orderby acc.Number
            //              select acc;


            //foreach(var entry in result2)
            //{
            //    Console.WriteLine(entry.Number);
            //    Console.WriteLine($"{entry.Name} | {entry.Number}");
            //}


            //var result3 = from acc in accounts
            //              where acc.Name == "Chacha" && acc.Number == "123"
            //              orderby acc.Number
            //              select new { n = acc.Name, m = acc.Number };

            //foreach(var entry in result3)
            //{
            //    Console.WriteLine(entry.m);
            //    Console.WriteLine(entry.n);
            //    Console.WriteLine($"{entry.n} | {entry.m}");
            //}
        }
    }
}