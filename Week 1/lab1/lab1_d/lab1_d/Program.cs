﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[ , ] arr = new int[a , a];
            for(int i = 0; i<a; i++)
            {
                for(int j = 0; j<=i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
