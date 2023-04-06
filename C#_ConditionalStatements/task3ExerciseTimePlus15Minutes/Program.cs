using System;

namespace task3ExerciseTimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int all = hour * 60 + min + 15;

            int h = all / 60;
            int m = all % 60;

            if (h > 23)
            {
                h = 0;
            }

            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }
            {

            }
        }
    }
}
