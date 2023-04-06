using System;

namespace task6ExerciseOperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());

            double result = 0.0;

            if ((operators == '/' && n2 == 0) || (operators == '%' && n2 == 0))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
                return;
            }

            if (operators == '/')
            {
              result = (double)n1 / (double)n2; 
            }
            else if (operators == '%')
            {
                result = n1 % n2;
            }
            else if (operators == '+')
            {
                result = n1 + n2;
            }
            else if (operators == '-')
            {
                result = n1 - n2;
            }
            else if (operators == '*')
            {
                result = n1 * n2;
            }

            if (operators == '+' || operators == '-' || operators == '*')
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operators} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operators} {n2} = {result} - odd");
                }
            }
            else if (operators == '/')
            {
                Console.WriteLine($"{n1} {operators} {n2} = {result:F2}");
            }else
            {
                      Console.WriteLine($"{n1} {operators} {n2} = {result}");
            }
        }
    }
}
