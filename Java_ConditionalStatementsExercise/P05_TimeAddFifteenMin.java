import java.util.Scanner;

public class P05_TimeAddFifteenMin {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int hour = Integer.parseInt(scanner.nextLine());
        int m = Integer.parseInt(scanner.nextLine());

        int totalMin = m + 15;
        int totalHour = hour;
        if (totalMin >= 60) {
            totalHour = totalHour + 1;
            totalMin = totalMin % 60;
        }
        String minFormat = "";
        if (totalMin < 10) {
            minFormat = "0" + totalMin;
        } else {
            minFormat = "" + totalMin;
        }

        if (totalHour >= 24) {
            totalHour = totalHour - 24;
        }

        System.out.printf("%d:%s",totalHour,minFormat);


    }
}
