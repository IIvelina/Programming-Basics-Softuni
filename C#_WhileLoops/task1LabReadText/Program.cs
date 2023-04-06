using System;

namespace task1LabReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
