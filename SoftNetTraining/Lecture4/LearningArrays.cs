using System;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningArrays
    {
        public static void Run()
        {
            int[] a1 = new int[10];
            int[] a2 = {1, 6, 8, 9, 0, 11};
            a2[2] = 17;

            int[] a3 = new int[10];
            a2.CopyTo(a3, 0);

            Book[] b1 = new Book[5];
            Book[] b2 =
            {
                new Book("Chacha", "Things Fall Apart", 100),
                new Book("Juma", "Penzi kitovu cha uzembe", 120)
            };


            int[,] data1 = new int[4, 3];
            data1[1, 2] = 8;


            // int[,] data2 = {{11, 34, 90}, {8, 4, 8}, {34, 4, 21}, {23, 64, 32}};
            int[,] data2 =
            {
                {11, 34, 90},
                {8, 4, 8},
                {34, 4, 21},
                {23, 64, 32}
            };

            int[,,] data3 = new int[2, 2, 2];
            int[,,] data4 =
            {
                {{1, 2}, {3, 4}},
                {{5, 6}, {7, 8}}
            };


            int[,,] data5 = new int[2, 4, 3];
            int[,,] data6 =
            {
                {{2, 3, 4}, {5, 6, 3}, {8, 9, 3}, {7, 4, 5}},
                {{1, 8, 7}, {6, 5, 4}, {8, 9, 0}, {2, 3, 4}}
            };

            // Console.WriteLine(data6[0, 2, 2]);
            // Console.WriteLine(data6.Length);


            int[,,] data7 = new int[3, 5, 2];

            int[][] jagged = new int[][]
            {
                new int[] {1, 2, 4, 3},
                new int[] {1, 2}
            };

            int[][] jagged1 = new int[][]
            {
                new int[4],
                new int[2]
            };

            jagged1[0][2] = 4;
            jagged1[1][1] = 2;
        }
    }
}