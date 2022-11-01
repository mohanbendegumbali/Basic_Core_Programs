using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Biggest
    {
        public void largest()
        {
            int a = 40;
            int b = 25;
            int c = 7;
            if ((a > b) && (a > c))
                Console.WriteLine(" The biggest number is ", +a);

            else if (b > c)
                Console.WriteLine(" The biggest number is ", +b);

            else
                Console.WriteLine(" The biggest number is ", +c);
        }
    }
}
