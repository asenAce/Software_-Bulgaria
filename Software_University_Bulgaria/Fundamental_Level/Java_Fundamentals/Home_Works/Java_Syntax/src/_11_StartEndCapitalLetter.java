/**
 * Created by asen on 10/22/2015.
 */

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class _11_StartEndCapitalLetter {

    public static void main(String[] args) {

            Scanner scanner = new Scanner();

            System.out.println("Please enter some text:");
            String text = scanner.nextLine();

            Pattern pattern = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b");
            Matcher matcher = pattern.matcher(text);

            while (matcher.find()) {

                System.out.print(matcher.group() + " ");
            }
    }

}
