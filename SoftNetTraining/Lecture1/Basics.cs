using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Text;
using SoftNetTraining.Banking;
using SoftNetTraining.Lecture1;
using SoftNetTraining.Lecture2;
using SoftNetTraining.Lecture3;
using SoftNetTraining.Lecture4;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture1
{
    public class Basics
    {
        
        
        
        


        public static void strings()
        {
            // string s = "Hi there!";
            // string l = s;
            //
            // s = s + " Everyone";

            StringBuilder s = new StringBuilder();
            s.Append("Hi There!");
            s.Append("Everyone!");


            StringWriter writer = new StringWriter();
            writer.WriteLine("The first line");
            writer.WriteLine("The second line");

            string content = writer.ToString();


            string contents = "This is the content from the file";
            StreamReader reader = new StreamReader(contents);
            reader.ReadLine();
            
            // int x = 12;
            // double y = 34.56;
            // string s = $"{x,10} {y,10}";
            // Console.WriteLine(s);


            // Console.WriteLine("{0} {1}",1234,"Hello");

            // Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXX");
            // Console.WriteLine("{0,10}  {1,-10} {2}",1234,890,876);

            // string content = "This is a C# training session";
            //
            // Console.WriteLine(content.Contains("training"));
            // Console.WriteLine(content.StartsWith("This"));
            // Console.WriteLine(content.EndsWith("session"));
            // Console.WriteLine(content.IndexOf("ing"));
            // Console.WriteLine(content.LastIndexOf("s"));
            //
            // string result = content.Substring(10, 11);
            // Console.WriteLine(result);
            //
            // result = content.Replace("training", "entertainment");
            // Console.WriteLine(result);
            //
            // result = content.Replace("is", "_");
            // Console.WriteLine(result);
            //
            // string[] words = content.Split("C#");
            // foreach (string word in words)
            // {
            //     Console.WriteLine(word);
            // }
        }


        private static void enumerating2()
        {
            Leadership leadership = new Leadership("Brighton", "Msuya", "Hadji", "Kibinda");

            foreach (string leader in leadership)
            {
                Console.WriteLine(leader);
            }
        }


        private static void enumerating1()
        {
            Bank bank = new Bank();


            bank.CreateCurrentAccount("Chacha", "123");
            bank.CreateCurrentAccount("Mwita", "345");
            bank.CreateCurrentAccount("Juma", "367");
            bank.CreateCurrentAccount("Jane", "183");
            bank.CreateCurrentAccount("Mary", "190");

            foreach (Account account in bank)
            {
                account.Deposit(12.25);
                Console.WriteLine(account.getInfo());
            }
        }


        private static void sorting()
        {
            Person p1 = new Person("Chacha", 12);
            Person p2 = new Person("Jane", 3);
            Person p3 = new Person("Juma", 40);
            Person p4 = new Person("Mwita", 34);

            List<Person> people = new List<Person>()
            {
                p1,
                p2,
                p3,
                p4
            };

            Console.WriteLine("Before sorting");
            foreach (Person person in people)
            {
                Console.WriteLine("{0} {1}", person.Name, person.Age);
            }

            people.Sort();
            Console.WriteLine("After sorting");
            foreach (Person person in people)
            {
                Console.WriteLine("{0} {1}", person.Name, person.Age);
            }
        }


        private static void printing()
        {
            // IPrinter printer = capturePrinterSelection();
            // IPrintable printable = captureReportSelection();
            // print(printer, printable);
        }

        public static void print(IPrinter printer, IPrintable printable)
        {
            printer.print(printable);
        }


        private static IPrinter CreatePrinter()
        {
            Console.WriteLine("Choose Printer to use\n 1. HP \n 2. Canon");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                HPPrinter p = new HPPrinter();
                return p;
            }

            else
            {
                CanonPrinter p = new CanonPrinter();
                return p;
            }
        }


        public static void display(IDisplay display)
        {
            Console.WriteLine("Displaying:" + display.getContent());
        }

        public static void print(IPrint print)
        {
            Console.WriteLine("Printing:" + print.getContent());
        }


        private static void encapsulations()
        {
            Person person = new Person();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            person.Name = "";
            // person.Age = 20;
        }


        private static void CastingOperators()
        {
            // Kilometer km = new Kilometer(100);
            // Mile mile = km;
            // double distance = (double) km;
            //
        }

        private static void expandos()
        {
            Player player = new Player();

            dynamic person = new ExpandoObject();
            person.Name = "Boniface";
            person.Age = "12";
            person.Gender = 'M';


            Console.WriteLine("{0} is a {1} of {2} years", person.Name, person.Gender, person.Age);


            dynamic expando = new ExpandoObject();
            expando.Name = "Boniface Chacha";
            expando.Age = 12;
            expando.Gender = 'M';

            Console.WriteLine("{0} is a {1} of {2} years", expando.Name, expando.Gender, expando.Age);
        }

        private static void dynamics()
        {
            dynamic display = new MessageDisplay("Hello World");
            display.Display();
        }

        private static void immutables()
        {
            DateTime date = DateTime.Today;
            Console.WriteLine(date);

            DateTime date2 = date.AddDays(3);
            Console.WriteLine(date);
            Console.WriteLine(date2);
        }


        private static void ourlist()
        {
            List myList = new List(100);


            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            myList[3] = 5;

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList[3]);


            foreach (object x in myList)
            {
                Console.WriteLine(x);
            }
        }


        private static void generics()
        {
            Repository<Book> bookDatabase = new Repository<Book>(100);
            bookDatabase.save(1, new Book());
            Bag<int> bagInt = new Bag<int>(2);
            Bag<string> bagString = new Bag<string>("Chacha");
            Bag<Point> bagPoint = new Bag<Point>(new Point(1, 1));

            Bag<Book> bagBook = new Bag<Book>(new Book());
        }

        public class Bag<T>
        {
            public T Data { get; set; }

            public Bag(T data)
            {
                Data = data;
            }
        }


        // public class Receipt : Invoice
        // {
        // }

        public class Invoice : Document
        {
            private int amount;

            public override void Print()
            {
                Console.WriteLine("Printing Invoice");
            }
        }

        public class Document
        {
            private DateTime timeCreated;

            public virtual void Print()
            {
                Console.WriteLine("Printing Document");
            }
        }


        private static void indexers()
        {
            int[] array = {1, 2, 3, 4};
            Console.WriteLine(array[0]);

            Book book = new Book();
            Console.WriteLine(book["Author"]);
            Console.WriteLine(book["Title"]);
        }


        private static void extensions()
        {
            int x = "100".toInt();

            bool check = x.isLessThan100();
            if (check)
            {
                Console.WriteLine("Less than 100");
            }
        }


        private static void references()
        {
            SampleVal val1 = new SampleVal();
            Console.WriteLine("Original Val 1 : " + val1);
            SampleVal val2 = val1;
            Console.WriteLine("Val 1 after assignment  : " + val1);
            Console.WriteLine("Val 2 after assignment  : " + val2);
            val2.Data = 2;
            Console.WriteLine("Val 1 after change  : " + val1);
            Console.WriteLine("Val 2 after change  : " + val2);
            SampleRef ref1 = new SampleRef();
            Console.WriteLine("Original Ref 1 : " + ref1);
            SampleRef ref2 = ref1;
            Console.WriteLine("Ref 1 after assignment  : " + ref1);
            Console.WriteLine("Ref 2 after assignment  : " + ref2);
            ref2.Data = 2;
            Console.WriteLine("Ref 1 after change  : " + ref1);
            Console.WriteLine("Ref 2 after change  : " + ref2);
        }


        public static void dates()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd-MM-yyyy"));

            date.AddDays(2);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));

            DateTime date2 = date.AddDays(2);
            Console.WriteLine(date2.ToString("dd-MM-yyyy"));
        }

        public static void namedoptional()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(y: 0, x: 0);

            Point point3 = Point.Create(1, 1);
            Point point4 = Point.Create();
        }

        public static void enums()
        {
            foreach (string direction in Enum.GetNames(typeof(Direction)))
            {
                Console.WriteLine(direction);
            }

            foreach (int direction in Enum.GetValues(typeof(Direction)))
            {
                Console.WriteLine(direction);
            }
        }


        public static void indexing()
        {
            Name name = new Name("Boniface", "Samson", "Chacha");
            Console.WriteLine(name["First"]);
        }


        public static void documents()
        {
            Document document = new Document();
            document.Print();

            Invoice invoice = new Invoice();
            invoice.Print();
        }

        public static int PrompInt(int min, int max, string message = "Enter a number : ")
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);

            if (value < min || value > max)
            {
                return PrompInt(min, max, message);
            }
            else
            {
                return value;
            }
        }

        private static void books()
        {
            Book book1 = new Book();
            book1.Author = "Boniface";
            book1.Title = "Feminism";
            book1.Pages = 10;

            Console.WriteLine(book1);
        }
    }

    public struct SampleVal
    {
        public int Data;

        public override string ToString()
        {
            return $"{Data}";
        }
    }

    public class SampleRef
    {
        public int Data;

        public override string ToString()
        {
            return $"{Data}";
        }
    }
    
}