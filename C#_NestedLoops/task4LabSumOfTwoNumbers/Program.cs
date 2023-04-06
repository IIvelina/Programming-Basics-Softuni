using System;

namespace task4LabSumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        int sum = i + j;
                        Console.WriteLine("Combination N:" + count + " " + "(" + i + " " + "+" + " " + j + " " + "=" + " " + sum + ")");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magic}");
        }
    }
}
