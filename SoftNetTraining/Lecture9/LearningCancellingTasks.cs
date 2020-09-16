using System;
using System.Threading;
using System.Threading.Tasks;

namespace SoftNetTraining.Lecture9
{
    public class LearningCancellingTasks
    {
        public static void Run()
        {
            
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Action a = () =>
            {
                int i = 0;
                while (!token.IsCancellationRequested)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(i++);
                }
                
                token.ThrowIfCancellationRequested();
            };

            Action<Task> c = (t) =>
            {
                Console.WriteLine("Good bye, Cancelled");
            };
            
            
            
            Task t = Task.Run(a,token)
                .ContinueWith(c,TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to cancel");
            Console.ReadLine();
            
            tokenSource.Cancel();
            
            Thread.Sleep(5000);
        }
    }
}