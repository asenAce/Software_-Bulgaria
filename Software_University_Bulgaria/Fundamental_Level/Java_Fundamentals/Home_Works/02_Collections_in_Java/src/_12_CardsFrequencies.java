/**
 * Created by asen on 10/28/2015.
 */

import  java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _12_CardsFrequencies {

    public static void main(String[] args) {

        Scanner scanner =new Scanner(System.in);

        System.out.print("Please Insert text with cards = ");

        String[] input = scanner.nextLine().trim().split(" ");
        int numOfAllCards = input.length;


        Map<String,Integer> result = new LinkedHashMap<>();

        for (int i = 0; i < input.length; i++) {

            String cardFace = input[i].substring(0,input[i].length() - 1);

            if (!result.containsKey(cardFace)) {

                result.put(cardFace,0);

            }

            result.put(cardFace,result.get(cardFace) + 1);
        }

        for (Map.Entry<String, Integer> card : result.entrySet()) {

            double precentage = ((double)card.getValue() / numOfAllCards) * 100;
            System.out.printf("%s -> %.2f%%\n",card.getKey(), precentage);
        }


    }
}
