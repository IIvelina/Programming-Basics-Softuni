using System;

namespace task3LabRoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                double current = double.Parse(arr[i]);

                Console.WriteLine($"{arr[i]} => {Math.Round(current,MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
