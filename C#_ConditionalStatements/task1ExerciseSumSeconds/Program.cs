using System;

namespace task1ExerciseSumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int total = first + second + third;

            int hours = total / 60;
            int min = total % 60;

            if (min < 10)
            {
                Console.WriteLine($"{hours}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hours}:{min}");     
            }
        }
    }
}
