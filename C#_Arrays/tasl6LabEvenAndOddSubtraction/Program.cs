using System;
using System.Linq;

namespace tasl6LabEvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i];
                }
                else
                {
                    odd += arr[i];
                }

            }
            Console.WriteLine(even - odd);
        }
    }
}
