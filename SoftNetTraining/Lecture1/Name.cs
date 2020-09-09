using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftNetTraining
{
    public class Name : IEnumerable<string>
    {
        public Name(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }

        public Name()
        {
        }

        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }

        public string this[int position]
        {
            get
            {
                if (position == 1) return First;
                else if (position == 2) return Middle;
                else if (position == 3) return Last;
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (position == 1) First = value;
                else if (position == 2) Middle = value;
                else if (position == 3) Last = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public string this[string type]
        {
            get
            {
                if (type == "First") return First;
                else if (type == "Middle") return Middle;
                else if (type == "Last") return Last;
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (type == "First") First = value;
                else if (type == "Middle") Middle = value;
                else if (type == "Last") Last = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            yield return First;
            yield return Middle;
            yield return Last;
        }

        public override string ToString()
        {
            return $"{First} {Middle} {Last}";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Name Parse(string value)
        {
            Name name = new Name();
            string[] parts = value.Split(" ");
            for (var i = 0; i < parts.Length && i < 3; i++)
            {
                name[i + 1] = parts[i];
            }

            return name;
        }
    }
}