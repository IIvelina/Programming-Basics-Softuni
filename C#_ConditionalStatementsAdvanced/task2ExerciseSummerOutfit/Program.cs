using System;

namespace task2ExerciseSummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string morning10to18Outfit = "Sweatshirt";
            string morning10to18Shoes = "Sneakers";

            string morning18to24Outfit = "Shirt";
            string morning18to24Shoes = "Moccasins";

            string morningOverThan25Outfit = "T-Shirt";
            string morningOverThan25Shoes = "Sandals";


            string afternoon10to18Outfit = "Shirt";
            string afternoon10to18Shoes = "Moccasins";

            string afternoon18to24Outfit = "T-Shirt";
            string afternoon18to24Shoes = "Sandals";

            string afternoonOverThan25Outfit = "Swim Suit";
            string afternoonOverThan25Shoes = "Barefoot";


            string evening10to18Outfit = "Shirt";
            string evening10to18Shoes = "Moccasins";

            string evening18to24Outfit = "Shirt";
            string evening18to24Shoes = "Moccasins";

            string eveningOverThan25Outfit = "Shirt";
            string eveningOverThan25Shoes = "Moccasins";

            string outfit = "";
            string shoes = "";

            if (timeOfDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = morning10to18Outfit;
                    shoes = morning10to18Shoes;
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = morning18to24Outfit;
                    shoes = morning18to24Shoes;
                }
                else if (degrees >= 25)
                {
                    outfit = morningOverThan25Outfit;
                    shoes = morningOverThan25Shoes;
                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = afternoon10to18Outfit;
                    shoes = afternoon10to18Shoes;
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = afternoon18to24Outfit;
                    shoes = afternoon18to24Shoes;
                }
                else if (degrees >= 25)
                {
                    outfit = afternoonOverThan25Outfit;
                    shoes = afternoonOverThan25Shoes;
                }
            }
            else if (timeOfDay == "Evening")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = evening10to18Outfit;
                    shoes = evening10to18Shoes;
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = evening18to24Outfit;
                    shoes = evening18to24Shoes;
                }
                else if (degrees >= 25)
                {
                    outfit = eveningOverThan25Outfit;
                    shoes = eveningOverThan25Shoes;
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
