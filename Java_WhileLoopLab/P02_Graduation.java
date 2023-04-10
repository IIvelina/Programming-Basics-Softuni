import java.util.Scanner;

public class P02_Graduation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String name = scanner.nextLine();

        double average = 0.0;
        int counter = 1;
        while (counter <= 12 ){
            double grade = Double.parseDouble(scanner.nextLine());
            if (grade >= 4.00){
                counter++;
                average = average + grade;
            }

        }
        System.out.printf("%s graduated. Average grade: %.2f",name,average / 12);


    }
}
