/**
 * Created by asen on 10/28/2015.
 */

import java.util.Scanner;

public class _05_CountAllWords {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Inser text = ");

        String[] words = scanner.nextLine().trim().split("[^a-zA-Z]+");
        System.out.println(words.length);

    }

}
