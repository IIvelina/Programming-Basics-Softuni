package simpleCalculationsExer;

import java.util.Scanner;

public class CurrencyConvertor {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double value  = Double.parseDouble(scanner.nextLine());
        String inputCurrency = scanner.nextLine();
        String outputCurrency = scanner.nextLine();

        double USD = 1.79549;
        double EUR = 1.95583;
        double GBP = 2.53405;

        switch (inputCurrency){
            case "BGN":
                break;
            case "USD":
                value = value * USD;
                break;
            case "EUR":
                value = value * EUR;
                break;
            case "GBP":
                value = value * GBP;
                break;
        }

        switch (outputCurrency){
            case "BGN":
                break;
            case "USD":
                value = value / USD;
                break;
            case "EUR":
                value = value / EUR;
                break;
            case "GBP":
                value = value / GBP;
                break;
        }

        System.out.printf("%.2f %s",value,outputCurrency);
    }
}
