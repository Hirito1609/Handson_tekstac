using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "John", "Boby", "Chraig", "Denis", "Alfee", "Bond" };

            //var namesOfB = names.Where(n => n.StartsWith("B"));

            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
            }
            catch(Exception ex)
            { 
            
            }
        }
    }
}
