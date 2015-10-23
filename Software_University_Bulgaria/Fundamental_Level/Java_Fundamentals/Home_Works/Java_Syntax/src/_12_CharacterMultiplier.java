/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;

public class _12_CharacterMultiplier {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out("Please enter two strings: ");

        String firstString = scanner.next();
        String secondString = scanner.next();

        int characterSum = calculateCharacterSum(firstString,secondString);

        System.out.println(characterSum);
    }

    private static int calculateCharacterSum(String firstString, String secondString) {

        int sum = 0;
        int firstStrLength = firstString.length();
        int secondStrLength = secondString.length();

        if (firstStrLength <  secondStrLength) {

            for (int i = firstStrLength - 1; i < secondStrLength - firstStrLength ; i++) {

                sum = sum + secondString.charAt(i);
            }
        } else if ( firstStrLength > secondStrLength) {

            for (int i = secondStrLength - 1; i < firstStrLength - secondStrLength ; i++) {

                sum += firstString.charAt(i);
            }
        }

        for (int i = 0; i < Math.min(firstStrLength, secondStrLength); i++) {

            sum = sum +firstString.charAt(i) * secondString.charAt(i);

        }

        return sum;
    }
}
