package NestedConditionalStatements;

import java.util.Scanner;

public class OperationsBetweenNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int num1 = Integer.parseInt(scanner.nextLine());
        int num2 = Integer.parseInt(scanner.nextLine());
        char operation = scanner.nextLine().charAt(0);

        String type = "";

        switch (operation) {
            case '+':
                int sum = num1 + num2;

                if (sum % 2 == 0) {
                    type = "even";
                } else {
                    type = "odd";
                }
                System.out.printf("%d %c %d = %d - %s", num1, operation, num2, sum, type);
                break;
            case '-':
                int diff = num1 - num2;
                if (diff % 2 == 0) {
                    type = "even";
                } else {
                    type = "odd";
                }
                System.out.printf("%d %c %d = %d - %s", num1, operation, num2, diff, type);
                break;
            case '*':
                int product = num1 * num2;
                if (product % 2 == 0) {
                    type = "even";
                } else {
                    type = "odd";
                }
                System.out.printf("%d %c %d = %d - %s", num1, operation, num2, product, type);
                break;
            case '/':
                double division = num1 * 1.0 / num2;
                if (num2 != 0) {
                    System.out.printf("%d %c %d = %.2f ", num1, operation, num2, division);
                }else{
                    System.out.printf("Cannot divide %d by zero", num1);
                }
                break;
            case '%':

                if (num2 != 0) {
                    int left = num1 % num2;
                    System.out.printf("%d %c %d = %d ", num1, operation, num2, left);
                }else{
                    System.out.printf("Cannot divide %d by zero", num1);
                }
                break;

        }


    }


}
