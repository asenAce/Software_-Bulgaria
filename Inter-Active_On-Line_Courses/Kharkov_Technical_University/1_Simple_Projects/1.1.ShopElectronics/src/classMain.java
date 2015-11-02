/**
 * Created by asen on 11/2/2015.
 */

// My Practice , playing with classes,Objects,Properties,Data Fields,Assign Values,Methods

public class classMain  {

    public  static  void main(String[] args){

        // Instantiate an Objects.
        House houseOne = new House();
        House houseTwo = new House();

        Car car = new Car();
        // Assign a value;
        car.setName("Toyota");
        car.setHeight(2);
        car.setColor("blue");

        System.out.println("car.getName()=" + car.getName());

        Cammy30 cammy = new Cammy30();
        // Calling the Method()
        cammy.stop();

        Phone aPhone= new Phone(1024,"Samsung","GSM");

        System.out.println("phone.getType() = " + aPhone.getType());
        System.out.println("info" + aPhone.getName());
        System.out.println("info ram " + aPhone.getRam());

        aPhone.setName("iPhone");
        aPhone.setRam(8);
        aPhone.setType("GSM");
    }

    //Lesson One
    public static   class  House {  // Create a class ID House acessor public

        // acess private type String ID color = asign a value "Black" ; end of the statement = command
        public String color = "Black";
        public   int roomCount = 5;

        // a data field
        private String name;
    }
    // Lesson Two

    public class Door {

        // Properties  color,height
        private String color;
        private int height;

        // Function some Action in this case the Door perform a action Open
        public void open() {

        }

        // Boolean is it locked
        public void close (boolean keyClose) {

        }
    }

    public class  Room{

        private int width;
        private int height;
        private int length;

    }

    public static class Car {

        private String name;
        private String color;
        private int height;


        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getColor() {
            return color;
        }

        public void setColor(String color) {
            this.color = color;
        }

        public int getHeight() {
            return height;
        }

        public void setHeight(int height) {
            this.height = height;
        }
    }

    public static class  Phone {

        private int ram;
        private String name;
        private String type;

        // Constructor withOut parameters
        public  Phone(){

        }

        // Constructor with parameters
        public  Phone(int ram,String name,String type) {

            // Set the parameters
            this.ram = ram;
            this.name = name;
            this.type = type;

        }

        public int getRam() {
            return ram;
        }

        public void setRam(int ram) {
            this.ram = ram;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getType() {
            return type;
        }

        public void setType(String type) {
            this.type = type;
        }
    }

public static class Cammy30 {
    // A method
    public  void drive(){

        System.out.println("Cammy30 driving");
    }

    public void  stop(){

        System.out.println("Cammy30 is stopping");
    }

}


}

