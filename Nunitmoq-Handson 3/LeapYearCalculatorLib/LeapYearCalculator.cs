using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCalculatorLib
{
    public class LeapYearCalculator
    {
       
        public int IsLeapYear(int year)
        {
            int output;

            if (year<1753||year>9999)
            {
                return -1;
            }

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                output = 1;
            else
                output = 0;

            return output;

        }
    }
}
