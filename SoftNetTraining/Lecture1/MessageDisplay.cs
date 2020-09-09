using System;

namespace SoftNetTraining.Lecture2
{
    public class MessageDisplay
    {
        private string message;

        public MessageDisplay(string message)
        {
            this.message = message;
        }

        public void Display()
        {
            Console.WriteLine(this.message);
        }
    }
}