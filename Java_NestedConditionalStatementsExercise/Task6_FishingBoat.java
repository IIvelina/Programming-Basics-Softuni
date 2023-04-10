package Exercise3;

import java.util.Scanner;

public class Task6_FishingBoat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int budget = Integer.parseInt(scanner.nextLine());
        String season = scanner.nextLine();
        int people =  Integer.parseInt(scanner.nextLine());

        double priceShip = 0;

        if(season.equals("Spring")){
            priceShip = 3000;
        }else if(season.equals("Summer") || season.equals("Autumn")){
            priceShip = 4200;
        }else if(season.equals("Winter")){
            priceShip = 2600;
        }

        if(people <= 6){
            priceShip = priceShip - 0.10 * priceShip;
        }else if(people >= 7 && people <= 11){
            priceShip = priceShip - 0.15 * priceShip;
        }else if(people >= 12){
            priceShip = priceShip - 0.25 * priceShip;
        }

        if(people % 2 == 0 && !season.equals("Autumn")){
            priceShip = priceShip - 0.05 * priceShip;
        }

        if(budget >= priceShip){
            double left = budget - priceShip;
            System.out.printf("Yes! You have %.2f leva left.", left);
        }else{
            double need = priceShip - budget;
            System.out.printf("Not enough money! You need %.2f leva.", need);
        }
    }
}
