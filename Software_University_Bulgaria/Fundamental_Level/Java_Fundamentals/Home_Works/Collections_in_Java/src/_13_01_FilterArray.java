/**
 * Created by asen on 10/28/2015.
 */

import java.util.Scanner;
import java.util.stream.Stream;

public class _13_01_FilterArray {

    public static void main(String[] args) {

        Stream.of(new Scanner(System.in).nextLine().split(" ")).filter(s -> s.length() > 3)
                .forEach(e -> System.out.print(e + " "));

    }


}
