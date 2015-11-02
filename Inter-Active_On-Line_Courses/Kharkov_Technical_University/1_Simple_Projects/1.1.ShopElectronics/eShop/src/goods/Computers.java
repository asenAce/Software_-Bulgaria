package goods;

/**
 * Created by asen on 11/2/2015.
 */
public class Computers extends  ElectronicDevice {

    private String name;
    private int ram;
    private String department;

    public Computers(String name){
        super(name);
    }

    public Computers(String name,int ram){
        super(name);
        this.ram= ram;

    }



    public Computers(double price,boolean hasGuarantee,String name,String company,int ram){

        super(price,hasGuarantee,name,company);
        this.ram = ram;
    }


    public void on(){

    }

    public  void off(){

    }

    public void loadOS(){


    }

}
