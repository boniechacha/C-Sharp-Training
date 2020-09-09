using System;

namespace SoftNetTraining.Lecture2
{
    public class CanonPrinter : IPrinter
    {
        public void print(IPrintable printable)
        {
            Console.WriteLine("Canon printing : " + printable.GetContent());
        }
    }
}