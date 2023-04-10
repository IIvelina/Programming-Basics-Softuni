import java.util.Scanner;

public class P01_SumSeconds {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = Integer.parseInt(scanner.nextLine());
        int b = Integer.parseInt(scanner.nextLine());
        int c = Integer.parseInt(scanner.nextLine());

        int sumSec = a + b + c;
        int totalSec = sumSec % 60;
        int totalMin = sumSec / 60;

        if (totalSec <= 9) {
            System.out.println(totalMin + ":0" + totalSec);

        } else{
            System.out.println(totalMin + ":" + totalSec);
        }
    }
}
