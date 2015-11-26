/**
 * Created by asen on 10/28/2015.
 */
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class _13_FilterArray {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<String> text = Arrays.asList(scanner.nextLine().split(" "));

        StringBuilder elementsLongerThanThree = new StringBuilder();

        String element;
        text.stream().filter(string -> string.length() > 3).forEach(elementsLongerThanThree.append(element + " "));
        System.out.print(elementsLongerThanThree.length() > 0 ? elementsLongerThanThree.toString() : "(empty)");


    }

}
