using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SoftNetTraining
{ 
   public class Book
    {
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        // static Book()
        // {
        //     Console.WriteLine("Before the first instance of the book is created");
        // }

        public Book()
        {
        }

        public Book(string author, string title, int pages)
        {
            this.Author = author;
            this.Title = title;
            this.Pages = pages;
        }


        public string this[string input]
        {
            get
            {
                if (input == "Author")
                {
                    return Author;
                }
                else if (input == "Title")
                {
                    return Title;
                }
                else throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return Title + " by " + Author + " : " + Pages;
        }
    }
}