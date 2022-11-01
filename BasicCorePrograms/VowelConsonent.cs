using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelConsonent
    {
        public void Vowel()
        {
            Console.WriteLine(" Enter the alphabet to check ");
            char c = Convert.ToChar(Console.Read());
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(" The alphabet is a vowel ");
                    break;
                default:
                    Console.WriteLine(" The given alphabet is a consonent ");
                    break;
            }
        }
    }
}
