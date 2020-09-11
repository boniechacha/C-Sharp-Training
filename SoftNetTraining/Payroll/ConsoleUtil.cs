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

        public static int CaptureInputInt(string message, int min, int max)
        {
            try
            {
                string input = CaptureInputString(message);
                int intInput = Convert.ToInt32(input);
                if (intInput > max || intInput < min)
                {
                    Console.WriteLine("You have entered number out of range");
                    return CaptureInputInt(message, min, max);
                }
                else
                {
                    return intInput;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("**** You have entered incorrect number ****");
                return CaptureInputInt(message, min, max);
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
                Console.WriteLine("**** You have entered incorrect number ****");
                return CaptureInputDouble(message);
            }
        }

        public static void Display(IEnumerable content)
        {
            foreach (object c in content)
            {
                Console.Write("{0} ", c);
            }

            Console.WriteLine();
        }

        public static void Display<T>(IEnumerable<T> content, string format, Func<T, object[]> formatInput)
        {
            foreach (T t in content)
            {
                Console.Write(format, formatInput(t));
            }

            Console.WriteLine();
        }
    }
}