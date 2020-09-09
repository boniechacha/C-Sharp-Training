using System;

namespace SoftNetTraining
{
    public class Student
    {
        public static int studentCount;

        private string name;
        private DateTime registrationDate;
        private DateTime dateOfBirth;

        static Student()
        {
            Console.WriteLine("-----Static Block ---");
            studentCount = 10;
            Console.WriteLine("We are about to create students");
            Console.WriteLine("Initial student count:" + studentCount);
            Console.WriteLine("-----Static Block ---");
        }

        public Student(string name, DateTime registrationDate, DateTime dateOfBirth)
        {
            if (name.Length < 3) throw new ArgumentException();

            this.name = name;
            this.registrationDate = registrationDate;
            this.dateOfBirth = dateOfBirth;

            studentCount = studentCount + 1;
        }

        public Student(string name, DateTime registrationDate)
            : this(name, registrationDate, DateTime.Today.AddYears(-7))
        {
        }

        public Student(string name)
            : this(name, DateTime.Today)
        {
        }


        public int Age(DateTime asOfDate)
        {
            if (dateOfBirth > asOfDate) return 0;
            else return asOfDate.Year - dateOfBirth.Year;
        }
    }
}