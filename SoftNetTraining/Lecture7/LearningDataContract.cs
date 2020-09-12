using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SoftNetTraining.Lecture7
{
    public class LearningDataContract
    {
        
        public static void SerializingJSON()
        {
            Book book = new Book(
                "Chacha",
                "Things Fall Apart",
                100
            );

            string filePath = "/Users/bonifacechacha/Projects/softnet/training/book.json";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Type bookType = typeof(Book);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(bookType);
                serializer.WriteObject(fileStream, book);
            }
        }
        
        public static void Deserializing()
        {
            string filePath = "/Users/bonifacechacha/Projects/softnet/training/book.xml";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                Type bookType = typeof(Book);
                DataContractSerializer serializer = new DataContractSerializer(bookType);
                Book book = (Book) serializer.ReadObject(fileStream);
                Console.WriteLine(book);
            }
        }

        public static void Serializing()
        {
            Book book = new Book(
                "Chacha",
                "Things Fall Apart",
                100
            );

            string filePath = "/Users/bonifacechacha/Projects/softnet/training/book.xml";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Type bookType = typeof(Book);
                DataContractSerializer serializer = new DataContractSerializer(bookType);
                serializer.WriteObject(fileStream, book);
            }
        }


        public static void SerializingCollections()
        {
            Book book1 = new Book(
                "Chacha",
                "Things Fall Apart",
                100
            );

            Book book2 = new Book(
                "Kibinda",
                "C# for Professional",
                120
            );

            BookCollection collection = new BookCollection();
            collection.Books = new Book[] {book1, book2};

            string filePath = "/Users/bonifacechacha/Projects/softnet/training/book.xml";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                Type bookType = typeof(BookCollection);
                DataContractSerializer serializer = new DataContractSerializer(bookType);
                serializer.WriteObject(fileStream, collection);
            }
        }
    }
}