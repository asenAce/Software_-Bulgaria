/**
 * Created by asen on 10/20/2015.
 */

import java.util.Locale;
import java.util.Scanner;


public class GetAverage {

    public static void main(String[] args) {

        System.out.println("Enter three numbers to find their average: ");
        Scanner reader = new Scanner(System.in);
        reader.useLocale(Locale.ENGLISH);
        Double firstNumber = reader.nextDouble();
        Double secondNumber = reader.nextDouble();
        Double threeNumber = reader.nextDouble();
        Double average = findingAverage(firstNumber, secondNumber, threeNumber);
        System.out.format("The average number is %.2f \n", average);
    }

    private static Double findingAverage(Double firstNumber, Double secondNumber, Double threeNumber) {

        Double sum =  firstNumber + secondNumber + threeNumber;
        Double average = sum / 3;
        return  average;
    }

}
