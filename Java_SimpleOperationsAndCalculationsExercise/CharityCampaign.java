package simpleCalculationsExer;

import java.util.Scanner;

public class CharityCampaign {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int days = Integer.parseInt(scanner.nextLine());
        int cooks = Integer.parseInt(scanner.nextLine());
        int cakes = Integer.parseInt(scanner.nextLine());
        int gofrets = Integer.parseInt(scanner.nextLine());
        int pancakes = Integer.parseInt(scanner.nextLine());

        int cakesPriceForDay = cakes * 45;
        double gofretsPriceForDay = gofrets * 5.80;
        double pancakePriceForDay = pancakes * 3.20;
        double sumForDay = (cakesPriceForDay + gofretsPriceForDay + pancakePriceForDay) * cooks;
        double wholeSum = sumForDay * days;
        double result = wholeSum - ( 0.125 * wholeSum);

        System.out.printf("%.2f",result);
    }
}
