﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _23Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFactorial = int.Parse(Console.ReadLine());
            BigInteger number = 1;
            for (int i = 1; i <= numFactorial; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
