using System;

namespace task6LabMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Stop")
                {
                    Console.WriteLine(max);
                    return;
                }
                else
                {
                    int number = int.Parse(input);
                    if (number > max)
                    {
                        max = number;
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
