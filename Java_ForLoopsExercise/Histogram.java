import java.util.Scanner;

public class Histogram {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numbersCounter = Integer.parseInt(scanner.nextLine());

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 0; i < numbersCounter; i++) {
            int num = Integer.parseInt(scanner.nextLine());

            if (num < 200) {
                p1++;
            } else if (num < 400) {
                p2++;
            } else if (num < 600) {
                p3++;
            } else if (num < 800) {
                p4++;
            } else {
                p5++;
            }
        }
        double p1Result = p1 / numbersCounter * 100;
        double p2Result = p2 / numbersCounter * 100;
        double p3Result = p3 / numbersCounter * 100;
        double p4Result = p4 / numbersCounter * 100;
        double p5Result = p5 / numbersCounter * 100;

        System.out.printf("%.2f%%%n", p1Result);
        System.out.printf("%.2f%%%n", p2Result);
        System.out.printf("%.2f%%%n", p3Result);
        System.out.printf("%.2f%%%n", p4Result);
        System.out.printf("%.2f%%%n", p5Result);
    }
}
