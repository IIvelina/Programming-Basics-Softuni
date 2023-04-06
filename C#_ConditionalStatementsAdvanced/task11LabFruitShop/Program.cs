using System;

namespace task11LabFruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double bananaWork = 2.50;
            double appleWork = 1.20;
            double orangeWork = 0.85;
            double grapefruitWork = 1.45;
            double kiwiWork = 2.70;
            double pineappleWork = 5.50;
            double grapesWork = 3.85;

            double bananaWeekend = 2.70;
            double appleWeekend = 1.25;
            double orangeWeekend = 0.90;
            double grapefruitWeekend = 1.60;
            double kiwiWeekend = 3.00;
            double pineappleWeekend = 5.60;
            double grapesWeekend = 4.20;

            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (product != "banana" && product != "apple" && product != "orange" && product != "grapefruit" && product != "kiwi" && product != "pineapple" && product != "grapes")
            {
                Console.WriteLine("error");
                return;
            }
            if (day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" && day != "Friday" && day != "Saturday" && day != "Sunday")
            {
                Console.WriteLine("error");
                return;
            }

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    price = bananaWork * quantity;
                }
                else if (product == "apple")
                {
                    price = appleWork * quantity;
                }
                else if (product == "orange")
                {
                    price = orangeWork * quantity;
                }
                else if (product == "grapefruit")
                {
                    price = grapefruitWork * quantity;
                }
                else if (product == "kiwi")
                {
                    price = kiwiWork * quantity;
                }
                else if (product == "pineapple")
                {
                    price = pineappleWork * quantity;
                }
                else if (product == "grapes")
                {
                    price = grapesWork * quantity;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    price = bananaWeekend * quantity;
                }
                else if (product == "apple")
                {
                    price = appleWeekend * quantity;
                }
                else if (product == "orange")
                {
                    price = orangeWeekend * quantity;
                }
                else if (product == "grapefruit")
                {
                    price = grapefruitWeekend * quantity;
                }
                else if (product == "kiwi")
                {
                    price = kiwiWeekend * quantity;
                }
                else if (product == "pineapple")
                {
                    price = pineappleWeekend * quantity;
                }
                else if (product == "grapes")
                {
                    price = grapesWeekend * quantity;
                }
            }
            Console.WriteLine($"{price:F2}");            
        }
    }
}
