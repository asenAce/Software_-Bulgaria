/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;

public class _04_CalcilateExpression {

    public static void main(String[] args) {

        Scanner scanner = new Scanner();

        System.out.println("Please enter three floating points numbers:");

        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        double firstFormula = Math.pow((a*a + b*b) / (a*a - b*b),(a+b+c) / Math.sqrt(c));
        double secondFormula = Math.pow((a*a + b*b - c*c*c),(a-b));
        double numbersAverage = (a+b+c)/3;
        double formulaAverage = (firstFormula + secondFormula)/2;

        system.out.format("F1 result: %.2f; ",firstFormula);
        system.out.format("F2 result: %.2f; ",secondFormula);
        system.out.format("Diff: %.2f",Math.abs(numbersAverage - formulaAverage));
    }
}
