package simpleCalculationsExer;

import java.util.Scanner;

public class TailoringWorkshop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int tables = Integer.parseInt(scanner.nextLine());
        double length = Double.parseDouble(scanner.nextLine());
        double width = Double.parseDouble(scanner.nextLine());

        double coversS = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
        double karetaS = tables * (length / 2) * (length / 2);
        double priceUSD = coversS * 7 + karetaS * 9;
        double priceBGN = priceUSD * 1.85;

        System.out.printf("%.2f USD\n%.2f BGN",priceUSD,priceBGN);
    }
}
