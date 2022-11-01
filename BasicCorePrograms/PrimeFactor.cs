using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactor
    {
        public void factor()
        {
            int count=0;
            Console.WriteLine(" Enter number to find prime factor ");
            int num = Convert.ToInt32(Console.ReadLine());
            for ( int i = 3; i < num; i++)
            {
                if (num % i == 0)
                {
                    for(int j = 0; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine(" Prime Factor is " + i);
                    }
                }
            }
        }
    }
}
