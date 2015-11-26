/**
 * Created by asen on 10/28/2015.
 */
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class _014_SortArrayWithStreamAPI {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<String> nums = new ArrayList<>();

        System.out.print("Please Insert few integers on a single line separated by space = ");
        nums.addAll(Arrays.asList(scanner.nextLine().split(" ")));

        System.out.println("Please Insert ordering type in format (\"Ascending /Descending \") = ");
        String sortType = scanner.nextLine();

        if (sortType.equals("Ascending ")) {

            nums.stream().map(s -> Integer.parseInt(s))
                    .sorted((numOne,numTwo) -> numOne.compareTo(numTwo))
                    .forEach(num -> System.out.print(num + " "));

        }
    }
}
