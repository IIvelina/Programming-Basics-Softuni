﻿using System;

namespace task2ExerciseBonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (num <= 100)
            {
                bonus = 5;
            }
            else if (num <= 1000)
            {
                bonus = 0.2 * num;
            }
            else
            {
                bonus = 0.1 * num;
            }

            if (num % 2 == 0)
            {
                bonus += 1;
            }

            if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);
        }
    }
}
