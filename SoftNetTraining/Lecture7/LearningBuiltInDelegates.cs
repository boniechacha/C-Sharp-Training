using System;
using System.Collections.Generic;

namespace SoftNetTraining.Lecture7
{
    public class LearningBuiltInDelegates
    {
        public static void Finding()
        {
            Predicate<int> checkLogic = (x) =>
            {
                if (x > 10) return true;
                else return false;
            };

            List<int> l = new List<int>() {1, 2, 3, 4, 5, 6, 11, 12, 13, 14, 15};

            List<int> g = l.FindAll(checkLogic);

            
            
            
            List<int> m = l.FindAll(
                (i) => { return i % 2 == 0; }
            );
        }


        public static void Actions()
        {
            Action<int, int> o = Print;
        }

        public static void Print(int x, int y)
        {
            Console.WriteLine($"{x} {y}");
        }

        public static void Functs()
        {
            Func<int, int, int> calc2 = Sum;
            Func<int, int, int, int> calc5 = SumThree;


            Func<int, int, double> calc3 = SumDouble;
            Func<double, int, double> calc4 = SumDouble2;

            Func<string, string, string> op = Join;
        }

        public static string Join(string s1, string s2)
        {
            return $"{s1} {s2}";
        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int SumThree(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double SumDouble(int x, int y)
        {
            return (double) x + y;
        }

        public static double SumDouble2(double x, int y)
        {
            return (double) x + y;
        }
    }
}