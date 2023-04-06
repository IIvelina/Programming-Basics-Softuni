using System;

namespace task3LabAnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "snake" || animal == "torroise" || animal == "crocodile" || animal == "reptile")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
