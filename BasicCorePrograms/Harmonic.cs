using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Harmonic
    {
        float sum = 0;
        
        public void harmonic()
        {
            Console.WriteLine(" Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                this.sum += 1 / i;
            }
            Console.WriteLine(" Harmonic series is " +sum);
        }
    }
}
