using System;

namespace task3LabCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int count = 0;
            //x + x + x

            for (int x1 = 0; x1 <= x; x1++)
            {
                for (int x2 = 0; x2 <= x; x2++)
                {
                    for (int x3 = 0; x3 <= x; x3++)
                    {
                        if (x1 + x2 + x3 == x)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
