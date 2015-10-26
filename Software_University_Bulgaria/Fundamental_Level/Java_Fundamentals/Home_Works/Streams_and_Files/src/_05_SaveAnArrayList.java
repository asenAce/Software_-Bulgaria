/**
 * Created by asen on 10/26/2015.
 */

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;


public class _05_SaveAnArrayList {

    public static void main(String[] args) {

        List<Double> doubles = new ArrayList<Double>()  {{

            addAll(Arrays.asList(2.5,6.2,1.3,0.1,3.14,66.6,6.9));

        }};

        saveDoubles(doubles);
        loadDoubles(doubles.size());
    }

    private static void loadDoubles(int numOfIteams) {

        try (ObjectInputStream source = new ObjectInputStream( new FileInputStream("lib/double.list"))){

            for (int i = 0; i < numOfIteams; i++) {

                System.out.println(source.readDouble());

            }
        } catch (FileNotFoundException e) {

            e.printStackTrace();

        } catch (IOException e) {

            e.printStackTrace();
        }
    }

    private static void saveDoubles(List<Double> doubles) {

        try(ObjectOutputStream destination = new ObjectOutputStream(new FileOutputStream("lib/double.list"))) {

            for (Double aDouble : doubles) {

                destination.writeDouble(aDouble);

            }

        } catch (FileNotFoundException e) {

            e.printStackTrace();

        } catch (IOException e) {

            e.printStackTrace();
        }

    }
}
