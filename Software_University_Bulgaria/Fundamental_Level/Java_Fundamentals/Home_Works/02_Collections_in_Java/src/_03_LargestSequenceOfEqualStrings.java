/**
 * Created by asen on 10/28/2015.
 */
import  java.util.Scanner;


public class _03_LargestSequenceOfEqualStrings {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Insert n Strings separated by space =  ");

        String[] stringArr = scanner.nextLine().trim().split("\\s");

        int startIndex = 0;
        int longestSequence = 1;

        for (int i = 0; i < stringArr.length; i++) {

            String currentString = stringArr[i];

            int currentlongestSequence = 1;
            int currentstartIndex = i;

            for (int j = i + 1; j < stringArr.length ; j++) {

                String compareStr = stringArr[j];

                if (compareStr.equals(currentString)) {

                    currentlongestSequence++;
                    i++;

                } else {

                    break;

                }
            }

            if (currentlongestSequence > longestSequence) {

                longestSequence = currentlongestSequence;
                startIndex = currentstartIndex;

            }
        }

        System.out.printf("The longest sequence of equals strings is: %s",stringArr[startIndex]);

        for (int i = startIndex + 1; i < startIndex + longestSequence ; i++) {

            System.out.print(" " + stringArr[i]);

        }

    }

}
