using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SoftNetTraining.Lecture7
{
    public class LeaningDelegates
    {
        public delegate int CalculationInt(int m, int n);


        public static void Run()
        {
            Action<string> a = s => {};
        }

        private static void Lambdas()
        {
            CalculationInt c1 = Multiply;
            CalculationInt c2 = (m, n) => m % n;
            CalculationInt c3 =
                (x, y) =>
                {
                    Console.WriteLine("Dividing ");
                    return x / y;
                };
            CalculationInt c4 = (h, j) => h + j;

            PrintPrettyResult(c4);


            CalculationInt c = (x, y) => x + y;
            // PrintPrettyResult(c);

            // PrintPrettyResult((x, y) => x + y);

            PrintPrettyResult(
                (x, y) => { return x + y; }
            );
        }


        public static void MultiCasting()
        {
            CalculationInt calc = Sum;
            calc += Multiply;
            calc += Substract;
            calc += Max;

            int r = calc(2, 3);

            Console.WriteLine(r);

            // CalculationInt calc2;
            // calc2(2, 3);
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


        public static void PrintPrettyResult(CalculationInt calc)
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