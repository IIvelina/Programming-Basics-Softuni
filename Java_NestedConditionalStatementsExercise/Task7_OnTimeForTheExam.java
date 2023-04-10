package Exercise3;

import java.util.Scanner;

public class Task7_OnTimeForTheExam {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int examHour = Integer.parseInt(scanner.nextLine());
        int examMinutes = Integer.parseInt(scanner.nextLine());
        int arriveHour = Integer.parseInt(scanner.nextLine());
        int arriveMinutes = Integer.parseInt(scanner.nextLine());

        int totalExam = examHour * 60 + examMinutes;
        int totalArrive = arriveHour * 60 + arriveMinutes;

        if(totalArrive > totalExam){
            System.out.println("Late");
            if(totalArrive - totalExam < 60){
                System.out.printf("%d minutes after the start", totalArrive - totalExam);
            }else{
                int lateHour = (totalArrive - totalExam) / 60;
                int lateMinute = (totalArrive - totalExam) % 60;
                System.out.printf("%d:%02d hours after the start",lateHour,lateMinute);
            }

        }else if(totalArrive == totalExam || totalExam - totalArrive <= 30){
            System.out.println("On time");
            if(totalExam - totalArrive <= 30 && totalExam - totalArrive != 0){
                System.out.printf("%d minutes before the start",totalExam - totalArrive);
            }

        }else if(totalExam - totalArrive > 30){
            System.out.println("Early");
            if(totalExam - totalArrive < 60){
                System.out.printf("%d minutes before the start", totalExam - totalArrive);
            }else {
                int earlyHour = (totalExam - totalArrive) / 60;
                int earlyMinute = (totalExam - totalArrive) % 60;
                System.out.printf("%d:%02d hours before the start",earlyHour,earlyMinute );
            }
        }

    }
}
