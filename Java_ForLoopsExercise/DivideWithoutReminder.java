import java.util.Scanner;

public class DivideWithoutReminder {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;

        for (int i = 0; i < n; i++) {
            int num = Integer.parseInt(scanner.nextLine());

            if (num % 2 == 0) {
                p1++;
            }
            if (num % 3 == 0) {
                p2++;
            }
            if (num % 4 == 0) {
                p3 ++;
            }
        }
        double p1Result = p1 / n * 100;
        double p2Result = p2 / n * 100;
        double p3Result = p3 / n * 100;

        System.out.printf("%.2f%%%n", p1Result);
        System.out.printf("%.2f%%%n", p2Result);
        System.out.printf("%.2f%%%n", p3Result);
    }
}
