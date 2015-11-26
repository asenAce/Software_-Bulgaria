/**
 * Created by asen on 10/28/2015.
 */

import  java.util.Scanner;

public class _02_SequencesOfEqualStrings {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Please insert n Strings separated by space = ");

        String[] stringArr = scanner.nextLine().trim().split("\\s");

        for (int i = 0; i < stringArr.length; i++) {

            String currentString = stringArr[i];
            System.out.print(currentString);

            for (int j = i + 1; j  < stringArr.length ; j++) {


                String compareStr = stringArr[j];

                if (compareStr.equals(currentString)) {

                    System.out.print(" " + compareStr);
                    i++;
                }

            }

        }
    }

}
