/**
 * Created by asen on 10/28/2015.
 */

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class _09_CombineListOfLetters {

    public static void main(String[] args) {

        List<Character> result = new ArrayList<>();

        Scanner scanner = new Scanner(System.in);

        System.out.print("Please Insert text Line One: ");
        String listOne = scanner.nextLine();

        System.out.print("Please Insert text Line Two: ");
        String listTwo = scanner.nextLine();

        for (int i = 0; i < listOne.length(); i++) {

            char currentChar = listOne.charAt(i);

            if (currentChar != ' ') {

                result.add(currentChar);

            }
        }

        for (int i = 0; i < listTwo.length(); i++) {

            char currentChar = listTwo.charAt(i);

            if (currentChar != ' ' && !listOne.contains(" " + currentChar)) {

                result.add(currentChar);

            }

        }

        for (Character ch : result) {

            System.out.print(ch + " ");

        }


    }

}
