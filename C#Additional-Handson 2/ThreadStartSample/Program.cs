using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****ThreadStart Delegate App*****\n");
            Console.Write("Do you want [1] or [2] threads? ");

            string threadCount = Console.ReadLine();

            // Name the current thread.
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            // Display Thread info.
            Console.WriteLine("-> {0} is executing Main()", Thread.CurrentThread.Name);

            // Make worker class.
            Printer p = new Printer();

            switch (threadCount)
            {
                case "2":
                    // Now make the thread.
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "Secondary";
                    backgroundThread.Start();// Changes the state of current instance to ThreadState.Running.
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want... you get 1 thread.");
                    goto case "1";
            }

            Console.WriteLine("Hello from main!!!");
            Console.Read();

        }
    }
}
