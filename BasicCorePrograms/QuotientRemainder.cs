using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        public void divide()
        {
            int dividend = 50;
            int divisor = 25;
            int remainder = dividend / divisor;
            int quotient = dividend % divisor;
            Console.WriteLine("Quoteint is " +quotient);
            Console.WriteLine(" Remainder is " +remainder);
        }
    }
}
