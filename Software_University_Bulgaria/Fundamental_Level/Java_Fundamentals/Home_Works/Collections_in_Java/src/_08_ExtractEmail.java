/**
 * Created by asen on 10/28/2015.
 */

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08_ExtractEmail {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Please Insert the text:");
        String text = scanner.nextLine();

        Pattern pattern = Pattern.compile("[a-zA-Z0-9]+[a-zA-Z0-9\\.\\-_]*[a-zA-Z0-9]+[a-zA-Z0-9\\.]+[a-zA-Z0-9]+");
        Matcher matcher = pattern.matcher(text);

        while (matcher.find()) {

            System.out.println(matcher.group());

        }

    }
}
