﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int k = 10;
            int m = 20;
            int s = k + m;
            bool t = m > k;
            double z = Math.Sqrt(5);
            const double pi = 3.14;
            Console.WriteLine("The sum is: " + s);
            Console.WriteLine("Is m > k ?" + t);
            Console.WriteLine("The sqrt of 5: " + z);
            Console.WriteLine("The max value of Int32: " + Int32.MaxValue);
            Console.ReadLine();
        }
    }
}
