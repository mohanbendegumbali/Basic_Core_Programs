using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Swapping
    {
        public void swap()
        {
            int num1 = 25;
            int num2 = 50;
            int temp = 0;

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping...");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
        }
    }
}
