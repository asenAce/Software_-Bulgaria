/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;

public class _06_BaseSevenToDecimal {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.println("Please enter a number in base-7");

        int number = scanner.nextInt();
        // Integer.valueOf(number,7);

        int numberDigits = Integer.toString(number).length();

        int result = 0;

        for (int i = 0; i < numberDigits; i++) {

            int remainder = number % 10;
            result = result + remainder * Math.pow(7,i);
            number /= 10;
        }

        System.out.println("The number in decimal system is: " + result);

    }
}
