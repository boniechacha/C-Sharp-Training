using System;
using System.Threading;

namespace SoftNetTraining.Lecture9
{
    public class LearningLocking
    {
        public static void Run()
        {
            
            object l = new object();
            
            Thread t1 = new Thread(
                () =>
                {
                    lock (l)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Console.WriteLine($"{Thread.CurrentThread.Name} {i}");
                        }
                    }

                }
            );
            t1.Name = "First Thread";
            t1.Start();

            Thread t2 = new Thread(
                () =>
                {
                    lock (l)
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Console.WriteLine($"{Thread.CurrentThread.Name} {i}");
                        }
                    }
                }
            );
            t2.Name = "Second Thread";
            t2.Start();
        }
    }
}