package NestedConditionalStatements;

import java.util.Scanner;

public class HotelRoom {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String month = scanner.nextLine();
        int nights = Integer.parseInt(scanner.nextLine());
        //•	За студио, при повече от 7 нощувки през май и октомври : 5% намаление.
        //•	За студио, при повече от 14 нощувки през май и октомври : 30% намаление.
        //•	За студио, при повече от 14 нощувки през юни и септември: 20% намаление.
        //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10% намаление.

        double priceApartment = 0;
        double priceStudio = 0;

        if (month.equals("May") || month.equals("October")) {
            if (nights > 7 && nights <= 14) {
                priceStudio = 50 - 0.05 * 50;
                priceApartment = 65;
            } else if (nights > 14) {
                priceStudio = 50 - 0.3 * 50;
                priceApartment = 65 - 0.1 * 65;
            } else {
                priceStudio = 50;
                priceApartment = 65;
            }
        } else if (month.equals("June") || month.equals("September")) {
            if (nights > 14) {
                priceStudio = 75.20 - 0.20 * 75.20;
                priceApartment = 68.70 - 0.1 * 68.70;
            } else {
                priceStudio = 75.20;
                priceApartment = 68.70;
            }


        } else if (month.equals("July") || month.equals("August")) {
            if (nights > 14) {
                priceApartment = 77 - 0.1 * 77;
            } else {

                priceApartment = 77;
            }
            priceStudio = 76;
        }

        double totalPriceForStudio = nights * priceStudio;
        double totalPriceForApartment = nights * priceApartment;

        System.out.printf("Apartment: %.2f lv.%n", totalPriceForApartment);
        System.out.printf("Studio: %.2f lv.", totalPriceForStudio);


    }
}
