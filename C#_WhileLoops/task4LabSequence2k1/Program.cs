using System;

namespace task4LabSequence2k1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            int current = 1;

            while (true)
            {
                Console.WriteLine(current);
                current = current * 2 + 1;
                counter++;

                if (current > n)
                {
                    return;
                }
            }
        }
    }
}
