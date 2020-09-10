using System;
using System.Collections;
using System.Collections.Generic;

namespace SoftNetTraining.Payroll
{
    public class ConsoleUtil
    {
        public static string CaptureInputString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public static void Display(IEnumerable content)
        {
            foreach (object c in content)
            {
                Console.Write("{0} ", c);
            }

            Console.WriteLine();
            
        }
        
        public static void Display<T>(IEnumerable<T> content,string format, Func<T, object[]> formatInput)
        {
            foreach (T t in content)
            {
                Console.Write(format, formatInput(t));
            }

            Console.WriteLine();
        }

        public static int CaptureInputInt(string message)
        {
            try
            {
                return Convert.ToInt32(CaptureInputString(message));
            }
            catch (Exception e)
            {
                Console.WriteLine("****{0}****", e.Message);
                return CaptureInputInt(message);
            }
        }

        public static double CaptureInputDouble(string message)
        {
            try
            {
                return Convert.ToDouble(CaptureInputString(message));
            }
            catch (Exception e)
            {
                Console.WriteLine("****{0}****", e.Message);
                return CaptureInputInt(message);
            }
        }
    }
}