/**
 * Created by asen on 10/28/2015.
 */

import  java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _06_CountSpecifiedWord {

    public static void main(String[] args) {

        //Creating an Object scanner
        Scanner scanner = new Scanner(System.in);

        // Promp the user
        System.out.print("Insert a text (haystack) = ");
        // Initialize a variable/Object of type String ID hayStack and store the value given from the user/Scanner into it,
        // but before that call . dot separetor the Function toLowerCase() which is a Function of the object scanner ;
        String hayStack = scanner.nextLine().toLowerCase();

        //Seconf promp
        System.out.print("Please Insert a needle string:");
        String needle = scanner.next().toLowerCase();

        // Declaring the variables;
        int index = 0;
        int counter =0;

        while (true) {

            int currentMatch = hayStack.indexOf(needle,index);

            if (currentMatch < 0) {

                break;

            }

            counter++;
            index = currentMatch + 1;
        }
        System.out.println(counter);
    }

}
