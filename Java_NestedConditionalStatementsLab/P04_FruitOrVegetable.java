import java.util.Scanner;

public class P04_FruitOrVegetable {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        if (text.equals("banana") || text.equals("apple") || text.equals("kiwi") ||
                text.equals("lemon") || text.equals("grapes") || text.equals("cherry")){
            System.out.println("fruit");
        }else if (text.equals("tomato") || text.equals("cucumber") ||
                text.equals("pepper") || text.equals("carrot")){
            System.out.println("vegetable");
        }else {
            System.out.println("unknown");
        }
    }
}
