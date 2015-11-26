/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;


public class _02_TriangleArea {


    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in); // 1> create a object scaner

        System.out.println("Please enter the coordinates x and y of three points."); // 2> Promp the user


        int aX = scanner.nextInt();  // 3> store the value into the variable aX,aY,bX .... with type int ID.
        int aY = scanner.nextInt();  //  Object scanner . *Dot separetor * call a Function / Method nextInt() .
        int bX = scanner.nextInt();
        int bY = scanner.nextInt();
        int cX = scanner.nextInt();
        int cY = scanner.nextInt();

        double triangleArea = Math.abs((ax*(bY - cY) + bX*(cY - aY)+cX*(aY-bY)) / 2 );  // new variable with type double
        // = assign value to the variable ID triangleArea which is  a formula;
        // the formula is from Internet.

        System.out((int)triangleArea);  // Display on the console: convert to (int)
    }


}
