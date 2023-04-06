using System;

namespace task1LabDayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day =
             {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int n = int.Parse(Console.ReadLine());

            if (n <= 0 || n > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(day[n - 1]);
            }
        }
    }
}
