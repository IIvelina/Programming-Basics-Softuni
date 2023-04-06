using System;

namespace task3LabSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());

            int sum = 0;

            while (true)
            {
                sum += input;
                if (sum >= num )
                {
                    Console.WriteLine(sum);
                    return;
                }
                else
                {
                    input = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
