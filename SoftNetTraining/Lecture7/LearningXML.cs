using System;
using System.IO;
using System.Xml.Serialization;

namespace SoftNetTraining.Lecture7
{
    public class LearningXML
    {
        public static void Run()
        {
            string xml = Serializing();
            Book book = Deserializing(xml);
        }

        private static string Serializing()
        {
            Book book = new Book(
                "Chacha",
                "Things Fall Apart",
                100
            );

            string xml;
            
            Type bookTypeInfo = typeof(Book);
            XmlSerializer serializer = new XmlSerializer(bookTypeInfo);
            
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, book);
                xml = writer.ToString();
            }

            Console.WriteLine(xml);

            return xml;
        }

        public static Book Deserializing(string xml)
        {
            Type bookTypeInfo = typeof(Book);
            XmlSerializer serializer = new XmlSerializer(bookTypeInfo);

            Book book;
            using (StringReader reader = new StringReader(xml))
            {
                book = (Book) serializer.Deserialize(reader);
            }

            Console.WriteLine(book);

            return book;
        }
    }
}