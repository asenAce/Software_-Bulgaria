
import java.util.Scanner;

public class  SumTwoNumbers {

    public static void main(String[] args) {

            Scanner reader = new Scanner(System.in);
            System.out.println( "Enter the first number: "); // promp the user.
            Integer firstNumber = reader.nextInt();  // = int.Parse(Console.ReadLine());
            System.out.println("Enter the second number: ");
            Integer secondNumber = reader.nextInt();
            Integer sum =firstNumber + secondNumber;

        System.out.println("The sum is: ");
        System.out.println(sum);
    }

}













