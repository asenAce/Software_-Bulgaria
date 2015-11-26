
import  java.time.LocalDateTime;
import  java.util.Calendar;
import  java.util.Date;


public  class  PrintCurrentDateTime {

    public static void main(String[] args) {

        Date today = new Date();
        LocalDateTime time = LocalDateTime.now();
        Calendar date = Calendar.getInstance();

        System.out.println(today);
        System.out.println(time);
        System.out.println(date.getTime());
    }
}




