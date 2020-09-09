using System;

namespace SoftNetTraining.Lecture2
{
    public class HPPrinter : IPrinter
    {
        public void print(IPrintable printable)
        {
            Console.WriteLine(printable.GetContent());
        }
    }
}