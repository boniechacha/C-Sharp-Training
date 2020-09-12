using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SoftNetTraining.Lecture7
{
    public class LeaningDelegateGeneric
    {
        public delegate T Calculation<T>(T m, T n);


        public static void Run()
        {
            Calculation<int> c1 = (x,y)=>x+y;
            
            Calculation<int> c2 = Sum;
            Calculation<int> c3 = Multiply;

            c3 = c3 + c2;
        }

        public static double SumDouble(double x, double y)
        {
            return x + y;
        }

        private static void Lambdas()
        {
            Calculation<int> c1 = Multiply;
            Calculation<int> c2 = (m, n) => m % n;
            Calculation<int> c3 =
                (x, y) =>
                {
                    Console.WriteLine("Dividing ");
                    return x / y;
                };
            Calculation<int> c4 = (h, j) => h + j;

            PrintPrettyResult(c4);


            Calculation<int> c = (x, y) => x + y;
            // PrintPrettyResult(c);

            // PrintPrettyResult((x, y) => x + y);

            PrintPrettyResult(
                (x, y) => { return x + y; }
            );
        }


        public static void MultiCasting()
        {
            Calculation<int> calc = Sum;
            calc += Multiply;
            calc += Substract;
            calc += Max;

            int r = calc(2, 3);
            Console.WriteLine(r);
        }

        public static int Sum(int x, int y)
        {
            Console.WriteLine("Summing {0} {1}", x, y);
            return x + y;
        }

        public static int Substract(int p, int r)
        {
            Console.WriteLine("Substracting {0} {1}", p, r);
            return p - r;
        }

        public static int Multiply(int x, int y)
        {
            Console.WriteLine("Multiplying {0} {1}", x, y);
            return x * y;
        }

        public static int Max(int x, int y)
        {
            Console.WriteLine("Finding Max {0} {1}", x, y);
            return Math.Max(x, y);
        }


        public static void PrintPrettyResult(Calculation<int> calc)
        {
            Dictionary<int, int> data = new Dictionary<int, int>()
            {
                {2, 3},
                {4, 5},
                {6, 7},
                {10, 11},
                {7, 3}
            };

            foreach (int key in data.Keys)
            {
                int x = key;
                int y = data[key];
                int r = calc(x, y);

                Console.WriteLine($"{key} ,{data[key]} = {r}");
            }
        }
    }
}