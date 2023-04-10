import java.util.Scanner;

public class P06_ThreeBrother {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double brotherA = Double.parseDouble(scanner.nextLine());
        double brotherB = Double.parseDouble(scanner.nextLine());
        double brotherC = Double.parseDouble(scanner.nextLine());
        double timeFishing = Double.parseDouble(scanner.nextLine());

        double allTime = 1 / (1/brotherA + 1/brotherB + 1/brotherC);

        allTime = allTime * 1.15;

        if(allTime < timeFishing){
            System.out.printf("Cleaning time: %.2f%n",allTime);
            System.out.printf("Yes, there is a surprise - time left -> %.0f hours.",
                    Math.floor(timeFishing - allTime));
        }else {
            System.out.printf("Cleaning time: %.2f%n", allTime);
            System.out.printf("No, there isn't a surprise - shortage of time -> %.0f hours.",
                    Math.ceil(allTime - timeFishing));
        }




    }
}
