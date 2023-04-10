import java.util.Scanner;

public class P09_WorldSwimmingRecord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double recordSec = Double.parseDouble(scanner.nextLine());
        double meter = Double.parseDouble(scanner.nextLine());
        double timeSec = Double.parseDouble(scanner.nextLine());

        double target = meter * timeSec;

        target = target + (Math.floor(meter / 15) * 12.5);

        if (target >= recordSec){
            System.out.printf("No, he failed! He was %.2f seconds slower.",target - recordSec );
        }else {
            System.out.printf("Yes, he succeeded! The new world record is %.2f seconds.",
                    target);
        }
    }
}
