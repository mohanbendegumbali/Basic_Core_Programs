using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        public void calculate()
        {
            Console.WriteLine(" Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(" The given number is even ");
            else
                Console.WriteLine(" The given number is odd ");
        }
    }
}
