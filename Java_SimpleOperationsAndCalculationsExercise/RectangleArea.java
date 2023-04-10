package simpleCalculationsExer;

import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double x1 = Double.parseDouble(scanner.nextLine());
        double y1 = Double.parseDouble(scanner.nextLine());
        double x2 = Double.parseDouble(scanner.nextLine());
        double y2 = Double.parseDouble(scanner.nextLine());

        double width = Math.abs(x1 - x2);
        double height = Math.abs(y1 - y2);

        double s = width * height;
        double p = 2 * (width + height);

        System.out.println(s);
        System.out.println(p);
    }
}
