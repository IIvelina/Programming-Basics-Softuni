import java.util.Scanner;

public class Salary {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int openTabs = Integer.parseInt(scanner.nextLine());
        double salary = Double.parseDouble(scanner.nextLine());

        boolean isSalaryLost = false;

        for (int i = 0; i < openTabs; i++) {
            String siteName = scanner.nextLine();

            switch (siteName) {
                case "Facebook":
                    salary -= 150;
                    break;
                case "Instagram":
                    salary -= 100;
                    break;
                case "Reddit":
                    salary -= 50;
                    break;
            }
            if (salary <= 0){
                isSalaryLost = true;
                break;
            }
        }
        if (isSalaryLost){
            System.out.println("You have lost your salary.");
        } else {
            System.out.printf("%.0f", salary);
        }
    }
}
