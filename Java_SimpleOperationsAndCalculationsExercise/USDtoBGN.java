package simpleCalculationsExer;

import java.util.Scanner;

public class USDtoBGN {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double dollars = Double.parseDouble(scanner.nextLine());
        double usdPrice = 1.795491;

        System.out.printf("%.2f BGN",dollars * usdPrice);
    }
}
