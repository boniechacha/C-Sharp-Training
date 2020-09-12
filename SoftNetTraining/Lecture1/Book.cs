using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SoftNetTraining
{
    [Serializable]
    [DataContract]
    public class Book
    {
        [DataMember] 
        public int Pages { get; set; }

        [DataMember] 
        public string Author { get; set; }

        [DataMember] 
        public string Title { get; set; }

        [XmlIgnore] 
        public DateTime Date { get; set; }

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