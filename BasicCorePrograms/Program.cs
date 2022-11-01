using BasicCorePrograms;
using System; 

namespace Demo 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Flip Coin" + "\n" + "2.Leap Year" + "\n" + "3.Swapping" + "\n" + "4.Largest" + "\n" + "5.Vowels" + "\n" + "6.Power" + "\n" + "7.Even or Odd ");
                Console.WriteLine(" Enter the option ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Coin();
                        break;
                }
            }
        }
    }
}