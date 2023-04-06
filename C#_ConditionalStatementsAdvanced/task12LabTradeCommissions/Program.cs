using System;

namespace task12LabTradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales0Sofia500 = 0.05;
            double sales500Sofia1000 = 0.07;
            double sales1000Sofia10000 = 0.08;
            double salesOver10000Sofia = 0.12;

            double sales0Varna500 = 0.045;
            double sales500Varna1000 = 0.075;
            double sales1000Varna10000 = 0.1;
            double salesOver10000Varna = 0.13;

            double sales0Plovdiv500 = 0.055;
            double sales500Plovdiv1000 = 0.08;
            double sales1000Plovdiv10000 = 0.12;
            double salesOver10000Plovdiv = 0.145;

            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (sales < 0)
            {
                Console.WriteLine("error");
                return;
            }
            if (city != "Sofia" && city != "Varna" && city != "Plovdiv")
            {
                Console.WriteLine("error");
                return;
            }

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    price = sales * sales0Sofia500;
                }
                else if (sales <= 1000)
                {
                    price = sales * sales500Sofia1000;
                }
                else if (sales <= 10000)
                {
                    price = sales * sales1000Sofia10000;
                }
                else
                {
                    sales = sales * salesOver10000Sofia;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    price = sales * sales0Varna500;
                }
                else if (sales <= 1000)
                {
                    price = sales * sales500Varna1000;
                }
                else if (sales <= 10000)
                {
                    price = sales * sales1000Varna10000;
                }
                else
                {
                    sales = sales * salesOver10000Varna;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    price = sales * sales0Plovdiv500;
                }
                else if (sales <= 1000)
                {
                    price = sales * sales500Plovdiv1000;
                }
                else if (sales <= 10000)
                {
                    price = sales * sales1000Plovdiv10000;
                }
                else
                {
                    sales = sales * salesOver10000Plovdiv;
                }
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}
