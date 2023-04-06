using System;
using System.Linq;

namespace task8LabCondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToArray();

            int[] arr2 = new int[arr1.Length - 1];

            while(arr1.Length > 1)
            {
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    arr2[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = arr2;
                arr2 = new int[arr1.Length - 1];
            }
            Console.WriteLine(arr1[0]);
        }

    }
}
