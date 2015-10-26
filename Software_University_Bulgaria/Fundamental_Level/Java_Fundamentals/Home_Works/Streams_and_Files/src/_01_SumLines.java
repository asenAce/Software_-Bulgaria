/**
 * Created by asen on 10/26/2015.
 */

import java.io.*;

public class _01_SumLines {

    public static void main(String[] args) {

        try (BufferedReader reader = new BufferedReader(new FileReader(new File("lib/lines.txt")))){

            String line = reader.readLine();

            while (line != null) {

                int currentLineSum = 0;

                for (int i = 0; i < line.length(); i++) {
                    currentLineSum += line.charAt(i);
                }

                System.out.println(currentLineSum);
                line = reader.readLine();
            }
        } catch (FileNotFoundException e) {

            e.printStackTrace();

        } catch (IOException e) {

            e.printStackTrace();
        }

    }
}
