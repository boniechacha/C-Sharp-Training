using System;
using System.Threading.Tasks;

namespace SoftNetTraining.Threads
{
    public class Tasks
    {
        public static void Run()
        {
            Task t1 = Task.Run(
                () => { Console.WriteLine("Hello 1"); }
            );

            t1.Wait();

            Task<string> t2 = Task.Run(
                () => { return "Hello 2"; }
            );

            Console.WriteLine(t2.Result);

            Task t3 = Task.Run(
                () =>
                {
                    Console.WriteLine("Running");
                    return "Hello 3";
                }
            ).ContinueWith(task => { Console.WriteLine($"Continuing: {task.Result}"); });

            Task<string> t4 = Task
                .Run(() => { return "Hello 4"; });

            t4.ContinueWith(
                (r) => { Console.WriteLine("Cancelled"); },
                TaskContinuationOptions.OnlyOnCanceled
            );
            t4.ContinueWith(
                (r) => { Console.WriteLine("Faulted"); },
                TaskContinuationOptions.OnlyOnFaulted
            );

            Task completedTask = t4.ContinueWith(
                (t) =>
                {
                    Task.Delay(1000).Wait();
                    Console.WriteLine($"Completed : {t.Result}");
                },
                TaskContinuationOptions.OnlyOnRanToCompletion
            );

            completedTask.Wait();


            Task.WaitAll(
                Task.Run(() => { Console.WriteLine("Task 1"); }),
                Task.Run(() => { Console.WriteLine("Task 2"); }),
                Task.Run(() => { Console.WriteLine("Task 3"); })
            );

            Task.WhenAny(
                Task.Run(() =>
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("Task 1");
                }),
                Task.Run(() => {
                    Task.Delay(1000).Wait(); Console.WriteLine("Task 2"); }),
                Task.Run(() => { Console.WriteLine("Task 3"); })
            ).ContinueWith(
                task =>
                {
                    Console.WriteLine("Something to execute");
                }
            );
        }
    }
}