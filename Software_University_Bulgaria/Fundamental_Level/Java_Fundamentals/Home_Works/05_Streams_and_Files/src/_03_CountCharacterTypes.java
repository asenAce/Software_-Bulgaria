/**
 * Created by asen on 10/26/2015.
 */

import  java.io.*;

import java.lang.reflect.Array;
import  java.util.ArrayList;

import  java.util.Arrays;

public class _03_CountCharacterTypes {

    public static void main(String[] args) {

        int vowels =0;
        int consonants = 0;
        int punct = 0;

        try (FileReader reader = new FileReader(new File("lib/words.txt"));
        PrintWriter writer = new PrintWriter(new FileWriter("lib/count-chars.txt"))){

            int input = reader.read();

            while (input != -1) {

                char ch = (char) input;

                if (Character.isLetter(ch)) {

                    if (Arrays.asList(new Character[]{'a','e','i','o','u'}).contains(ch)) {

                        vowels++;

                    } else {

                        consonants++;

                    }
                } else if (Arrays.asList(new Character[]{'!',',','.','?'}).contains(ch)) {

                    punct++;


                }

                // input = reader.read;
            }

            writer.write(String.format("Vowels: %d\n Consonants: %d\n Punctuation: %d",vowels,consonants,punct));

        } catch (FileNotFoundException e) {

            e.printStackTrace();

        } catch (IOException e) {

            e.printStackTrace();
        }


    }

}
