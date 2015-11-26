/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;

public class _01_RectangleArea {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the two sides of a rectangle.");


        int sideA = scanner.nextInt();
        int sideB = scanner.nextInt();

        long rectangleArea = sideA * sideB;

        System.out.println(rectangleArea);

    }

}
