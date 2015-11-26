/**
 * Created by asen on 10/28/2015.
 */

import java.util.Arrays;
import java.util.Scanner;


public class _01_SortArrayOfNumbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in); // Create an Object scanner

        System.out.print("Insert n = "); // Promp the user
        int n = scanner.nextInt();  // store the value into n type int
        System.out.printf("Insert %d number of integers separated by space = ",n); // Display the result

        int[] nums = new int[n];   // Array of int [] ID nums  -> pass the parameters n into [] which means elemetns n
        // store into the array;

        for (int i = 0; i < n; i++) {  // Iteration  bottom ; roof ; step

            nums[i] = scanner.nextInt();  // code block execute this command

        }

        Arrays.sort(nums);  // Object Arrays call Function sort() passing the parameters into the bracets nums;

        for (int num : nums) {   // For loop Iteration from num in collection nums

            System.out.print(num + "  ");  // Display to the Console == Print the elements into the collection nums after sorting ;

        }
    }

}
