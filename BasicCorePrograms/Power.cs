﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Power
    {
        public void powertable()
        {
            Console.WriteLine(" Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                double p = Math.Pow(2, i);
                Console.WriteLine(" Power is " + p);
            }
        }
    }
}
