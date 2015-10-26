import java.io.*;

public class _06_SaveACustomObjectInAfile {
    public static void main(String[] args) {
        Course course = new Course() {{
            name = "IT";
            numberOfStudents = 56;
        }};

        saveObject(course);
        printCourse(loadObject(course));
    }

    private static void printCourse(Course course) {
        System.out.println(course);
    }

    private static Course loadObject(Course course) {
        Course cr = new Course();
        try(ObjectInputStream source = new ObjectInputStream(new FileInputStream("lib/course.save"))) {
            cr  = (Course) source.readObject();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }

        return cr;
    }

    private static void saveObject(Course course) {
        try(ObjectOutputStream destination = new ObjectOutputStream(new FileOutputStream("lib/course.save"))) {
            destination.writeObject(course);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

class Course implements Serializable {
    String name;
    int numberOfStudents;

    public String toString() {
        return this.name + " course has " + this.numberOfStudents + " students.";
    }
}