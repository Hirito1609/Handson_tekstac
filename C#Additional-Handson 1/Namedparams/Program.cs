using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namedparams
{
    class Program
    {
        public static void GetCohortDetails(string Cohortname, int GenCcount, string Mode, string Track, string CurrentModule)
        {
            Console.WriteLine("It is {0} with {1} GenC Students undergoing training for {2} through {3}. The current module of training is {4}", Cohortname, GenCcount, Track, Mode, CurrentModule);
        }
        public static void OrderDetails(string Productname, string Sellername, int Orderquantity = 1, bool returnable = true)
        {
            Console.WriteLine("Here is the order details – {0} number of {1} by {2} is ordered. Its returnable status is {3}", Orderquantity, Productname, Sellername, returnable);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("GetCohortDetails");
            GetCohortDetails(Cohortname: "INTCDE21ID008", GenCcount: 18, Track: ".NET", Mode: "OBL", CurrentModule: "Stage-3");
            Console.WriteLine("OrderDetails");
            OrderDetails(Sellername: "Hirito", Productname: "Oculus-Rift", Orderquantity: 10, returnable: false);


            Console.Read();

        }
    }
}
