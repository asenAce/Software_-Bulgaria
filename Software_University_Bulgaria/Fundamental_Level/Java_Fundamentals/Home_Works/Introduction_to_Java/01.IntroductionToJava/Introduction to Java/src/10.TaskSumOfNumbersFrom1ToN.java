
import java.util.Scanner;

public class  SumOfNumbersFrom1ToN {

    public static void main(String[] args) {

        System.out.println("Enter the eding number for the calculation:  ");
        Scanner reader = new Scanner(System.in);
        Integer number = reader.nextInt();
        Integer sum = calculateSum(number);
        System.out.println(sum);
    }


    private static  Integer calculateSum(Integer number){

        Integer sum =0;
        for (int i = 1; i <= number;i++){
            sum = sum+i;
        }

        return sum;
    }
}






