/**
 * Created by asen on 10/26/2015.
 */


import java.io.*;

public class _02_AllCapitals {

    static  final String filePath = "lib/lines.txt";

    public static void main(String[] args) {

        StringBuilder upperCaseText = new StringBuilder();

        try( BufferedReader reader = new BufferedReader(new FileReader( new File(filePath)));
        ) {

            String line = reader.readLine();

            while (line != null) {

                upperCaseText.append(line.toUpperCase() + "\n");
                line = reader.readLine();
            }

            try (PrintWriter writer = new PrintWriter(new FileWriter(new File(filePath)))) {

                writer.write(upperCaseText.toString());

            } catch (IOException e) {

                e.printStackTrace();

            } catch (FileNotFoundException e){

                e.printStackTrace();

            }
        }

    }
}
