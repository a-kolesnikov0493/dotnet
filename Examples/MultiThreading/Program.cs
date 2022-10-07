using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            ThreadPool.QueueUserWorkItem(o => Count(cts.Token, 1000));

            Console.WriteLine("Enter for exit");
            Console.ReadLine();

            cts.Cancel();

            Console.ReadLine();
        }

        public static void Count(CancellationToken token, int countTo)
        {
            for (int i = 0; i < countTo; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelled");
                    break;
                }

                Console.WriteLine(i);
                Thread.Sleep(200);
            }

            Console.WriteLine("Done");
        }
    }
}
