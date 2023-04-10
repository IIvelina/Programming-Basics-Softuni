package simpleCalculationsExer;

import java.util.Scanner;

public class AlcoholMarket {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double whiskeyPriceLv = Double.parseDouble(scanner.nextLine());
        double colBeersInLiters = Double.parseDouble(scanner.nextLine());
        double colWineInLiters = Double.parseDouble(scanner.nextLine());
        double colRakijaInLiters = Double.parseDouble(scanner.nextLine());
        double colWhiskeyInLiters = Double.parseDouble(scanner.nextLine());

        double rakijaPriceInLv = whiskeyPriceLv / 2;
        double winePriceInLv = rakijaPriceInLv - (rakijaPriceInLv * 0.4);
        double beerPriceInLv = rakijaPriceInLv -(rakijaPriceInLv * 0.8);

        double totalSum = (colRakijaInLiters * rakijaPriceInLv) + (winePriceInLv * colWineInLiters) + (colBeersInLiters * beerPriceInLv)
                + (colWhiskeyInLiters * whiskeyPriceLv);
        System.out.printf("%.2f",totalSum);

    }
}
