using System;

namespace task7LabMinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Stop")
                {
                    Console.WriteLine(min);
                    return;
                }
                else
                {
                    int number = int.Parse(input);
                    if (number < min)
                    {
                        min = number;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
