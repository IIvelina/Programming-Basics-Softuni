﻿using System;

namespace task5LabNumber100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (n <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
