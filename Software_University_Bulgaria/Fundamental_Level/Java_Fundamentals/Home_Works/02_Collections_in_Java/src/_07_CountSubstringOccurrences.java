/**
 * Created by asen on 10/28/2015.
 */
import java.util.Scanner;


public class _07_CountSubstringOccurrences {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String hayStack = scanner.nextLine().toLowerCase();
        String needle = scanner.nextLine().toLowerCase();

        int occurrences = 0;
        int searchIndex = 0;
        int findIndex;

        while ((findIndex = hayStack.indexOf(needle,searchIndex)) >= 0 ) {

            occurrences++;
            searchIndex = findIndex + 1;

        }

        System.out.println(occurrences);
    }

}
