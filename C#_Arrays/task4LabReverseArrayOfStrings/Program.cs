using System;

namespace task4LabReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            foreach (string empty in arr)
            {
                Console.Write(empty + " ");
            }
        }
    }
}
