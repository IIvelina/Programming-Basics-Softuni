package Exercise3;

import java.util.Scanner;

public class Task8_Journey {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double budget = Double.parseDouble(scanner.nextLine());
        String season = scanner.nextLine();

        String destination = "";
        String placeToStand = "";
        double price = 0;

        //Ако е лято ще почива на къмпинг, а зимата в хотел.
        // Ако е в Европа, независимо от сезона ще почива в хотел.

        if(budget <= 100){
            destination = "Bulgaria";
            if(season.equals("summer")){
                price = 0.3 * budget;
                placeToStand = "Camp";
            }else if(season.equals("winter")){
                price = 0.7 * budget;
                placeToStand = "Hotel";
            }
        }else if(budget <= 1000){
            destination = "Balkans";
            if(season.equals("summer")){
                price = 0.4 * budget;
                placeToStand = "Camp";
            }else if(season.equals("winter")){
                price = 0.8 * budget;
                placeToStand = "Hotel";
            }
        }else if(budget > 1000){
            destination = "Europe";
            price = 0.9 * budget;
            placeToStand = "Hotel";
        }


        System.out.printf("Somewhere in %s%n",destination);
        System.out.printf("%s - %.2f",placeToStand,price);


    }
}
