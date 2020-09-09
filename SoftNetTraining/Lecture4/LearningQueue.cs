using System;
using System.Collections.Generic;
using SoftNetTraining.Payroll;

namespace SoftNetTraining.Lecture4
{
    public class LearningQueue
    {
        public static void Run()
        {
            
            Queue<int> q = new Queue<int>();
            q.Enqueue(6);
            q.Enqueue(11);
            q.Enqueue(3);
            q.Enqueue(5);
            
            ConsoleUtil.Display(q);
            
            int v = q.Dequeue();
            Console.WriteLine(v);
            
            
            ConsoleUtil.Display(q);

            v = q.Dequeue();
            Console.WriteLine(v);
            
            Console.WriteLine(q.Peek());

            ConsoleUtil.Display(q);

        }
    }
}