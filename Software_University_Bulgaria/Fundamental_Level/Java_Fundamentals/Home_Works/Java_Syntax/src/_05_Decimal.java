/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;

public class _05_Decimal {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.println("Please enter a number:");
        int number = scanner.nextInt();

        String baseSevenNumber = Integer.toString(number,7);
        Systme.out.println("The number in base -7 is: " + baseSevenNumber);
    }
}
