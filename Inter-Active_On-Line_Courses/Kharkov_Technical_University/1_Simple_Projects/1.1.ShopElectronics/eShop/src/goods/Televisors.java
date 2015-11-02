package goods;

/**
 * Created by asen on 11/2/2015.
 */
public class Televisors extends ElectronicDevice {

    private String company;
    private String department;
    private String model;

    public Televisors(double price,boolean hasGuarantee,String name,String company){

        super(price,hasGuarantee,name,company);
    }

    public Televisors(String name){

        super(name);
    }

    public void on(){

    }

    public void off(){

    }

    public void selectChannel(){


    }

    public void  selectChannel(String name){

    }

    public void selectChannel(int number){

    }

}
