/**
 * Created by asen on 10/22/2015.
 */

import  java.util.HashMap;
import java.util.Scanner;


public class _14_ExchangableWords {

    public static void main(String[] args) {

        Scanner scanner = new Scanner();

        System.out.println("Please enter two strings: ");
        String firstString = scanner.next();
        String secondString = scanner.next();

        Boolean isExchangable;

        if ( firstString.length() == secondString.length()) {

            isExchangable = checkIsExchangeable(firstString,secondString);

        } else {

            isExchangable = false;
        }

        System.out.println(isExchangable);
    }

    private static Boolean checkIsExchangeable(String firstString, String secondString) {

        HashMap<Character,Character> dictionary = new HashMap<>();

        for (int i = 0; i < firstString.length; i++) {

            if ( dictionary.containsKey(firstString,charAt(i))) {

                if ( secondString.charAt(i) != dictionary.get(firstString.charAt(i))) {

                    return false;
                }
            }  else if( dictionary.containsValue(secondString.charAt(i))){

                return false;

            } else {

                dictionary.put(firstString.charAt(i),secondString.charAt(i));
            }
        }

        return true;
    }
}
