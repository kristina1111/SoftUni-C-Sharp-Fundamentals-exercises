﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
