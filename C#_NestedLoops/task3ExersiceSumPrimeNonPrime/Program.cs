using System;

namespace task3ExersiceSumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                int count = 0;
                if (number < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                }

                if (count == 2)
                {
                    primeSum += number;
                }
                else if (true)
                {
                    nonPrimeSum += number;       
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
