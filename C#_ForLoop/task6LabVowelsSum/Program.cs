using System;

namespace task6LabVowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;

            string text = Console.ReadLine();

            int sum = 0;

            for (int j = 0; j < text.Length; j++)
            {
                char current = text[j];

                if (current == 'a')
                {
                    sum += a;
                }
                else if (current == 'e')
                {
                    sum += e;
                }
                else if (current == 'i')
                {
                    sum += i;
                }
                else if (current == 'o')
                {
                    sum += o;
                }
                else if (current == 'u')
                {
                    sum += u;
                }
                else
                {
                    sum += 0;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
