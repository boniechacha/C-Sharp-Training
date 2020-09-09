using System;

namespace SoftNetTraining.Lecture2
{
    public class Person : IComparable<Person>
    {
        private string name = "NoName";
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person()
        {
        }

        // public int Age { set; }

        public int Age
        {
            get { return age; }
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (value.Length < 5) throw new ArgumentException();
                name = value;
            }
        }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age)
                return +1;
            else if (this.Age < other.Age)
                return -1;
            else return 0;
        }

        // public int CompareTo(object obj)
        // {
        //     // Person other =(Person) obj;
        //     Person other = obj as Person;
        //
        //     if (this.Age > other.Age)
        //         return +1;
        //     else if (this.Age < other.Age)
        //         return -1;
        //     else return 0;
        // }
    }
}