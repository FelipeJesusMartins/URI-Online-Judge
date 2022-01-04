import java.io.IOException;
import java.util.Scanner;

public class uri1001ExtremelyBasic {

    public static void main(String[] args) throws IOException {

        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();
        int y = sc.nextInt();
        System.out.println("X = " + (x + y));
        sc.close();
    }
}