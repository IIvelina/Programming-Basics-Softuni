package simpleCalculationsExer;

import java.util.Scanner;

public class DanceHall {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double length = Double.parseDouble(scanner.nextLine());
        double width = Double.parseDouble(scanner.nextLine());
        double side = Double.parseDouble(scanner.nextLine());

        double hallS = (length * 100) * (width * 100);
        double wardRobe = (side * 100) * (side * 100);
        double peika = hallS / 10;
        double freeSpace = hallS - wardRobe - peika;
        int dancers = (int)(freeSpace / (40 + 7000));

        System.out.println(dancers);
    }
}
