using System;

namespace task6LabBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            for (int f = floor; f >= 1; f--)
            {
                for (int r = 0; r < room; r++)
                {
                    if (floor == 1)
                    {
                        Console.Write($"L{f}{r} ");
                        return;
                    }
                    else if (floor == f)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else
                    {
                        if (f % 2 != 0)
                        {
                            Console.Write($"A{f}{r} ");
                        }
                        else
                        {
                            Console.Write($"O{f}{r} ");
                        }
                    }
                    if (floor == 1)
                    {
                        return;
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
