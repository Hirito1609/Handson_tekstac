using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncawait
{
    class Program
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                string msg = Method2().Result;
                Console.WriteLine(msg);
            });
        }

        public static async Task<string> Method2()
        {
            Console.WriteLine("Waiting for string return");
            Thread.Sleep(2000);
            return "Call from 2nd method";
        }

        static void Main(string[] args)
        {
            Method1();
            Console.ReadKey();
        }
    }
}
