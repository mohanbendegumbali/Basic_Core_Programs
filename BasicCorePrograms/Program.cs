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
                Console.WriteLine("1.Flip Coin" + "\n" + "2.Leap Year" + "\n" + "3.Swapping" + "\n" + "4.Largest" + "\n" + "5.Vowels" + "\n" + "6.Power" + "\n" + "7.Harmonic " + "\n" + "8.Prime Factor " + "\n" + "9.Even or Odd");
                Console.WriteLine(" Enter the option ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        flip.Coin();
                        break;
                    case 2:
                        LeapYear year = new LeapYear();
                        year.Leap();
                        break;
                    case 3:
                        Swapping swapping = new Swapping();
                        swapping.swap();
                        break;
                    case 4:
                        Biggest biggest = new Biggest();
                        biggest.largest();
                        break;
                    case 5:
                        VowelConsonent vowel = new VowelConsonent();
                        vowel.Vowel();
                        break;
                    case 6:
                        Power power = new Power();
                        power.powertable();
                        break;
                    case 7:
                        Harmonic num = new Harmonic();
                        num.harmonic();
                        break;
                    case 8:
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.factor();
                        break;
                    case 9:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.calculate();
                        break;

                }
            }
        }
    }
}