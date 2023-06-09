﻿using System;

namespace task7LabAreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double area = 0.0;

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (input == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(r, 2);
            }
            else if (input == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = a * h / 2;
            }
            Console.WriteLine($"{area:F3}", area);
        }
    }
}
