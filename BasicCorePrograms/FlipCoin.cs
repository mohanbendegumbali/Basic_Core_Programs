using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        Random random = new Random();
        public void Coin()
        {
            int head = 0, tail = 0;
            Console.WriteLine(" Enter the number of times coin to be flipped ");
            int num = Convert.ToInt32(Console.ReadLine());
            int actualflip = num;
            while (num > 0)
            {
                if (random.NextDouble() > 0.5)
                    head++;
                else
                    tail++;
                num--;
            }
            double headpercent = (head / actualflip) * 100;
            double tailpercent = (tail / actualflip) * 100;
            Console.WriteLine(" HeadPercentage : " + headpercent);
            Console.WriteLine(" TailPercentage : " + tailpercent);
        }
    }
}
