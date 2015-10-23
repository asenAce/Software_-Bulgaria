/**
 * Created by asen on 10/20/2015.
 */

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Sacanner;


public class SortArrayOfStrings {

    public static void main(String[] args) {

        System.out.println("How many strings you will enter:");
        Scanner reader = new Scanner(System.in);
        Integer integer =reader.nextInt();

        ArrayList<String> words =new ArrayList<String>();

        for (int i =0; i < integer;i++) {

            String word = reader.next();
            words.add(word);
        }

        for (int i=0;i<words.size()-1;i++){

            if (words.get(i).compareTo(words.get(i+1))>0){

                String container = words.get(i+1);
                words.set(i+1,words.get(i));
                words.set(i,container);
                i=i-2;

                if (i<0){
                    i=-1;
                }
            }
        }
    }

}
