using System;
using System.Collections;

namespace SoftNetTraining
{
    public class List : IEnumerable
    {
        private object[] content;
        private int pointer = 0;

        public List(int size)
        {
            if (size <= 0) throw new ArgumentException();

            content = new object[size];
        }

        public void Add(object input)
        {
            content[pointer] = input;
            // pointer = pointer + 1;
            pointer++;
        }


        public object this[int index]
        {
            get
            {
                return content[index];
            }

            set
            {
                content[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return content.GetEnumerator();
        }
    }
}