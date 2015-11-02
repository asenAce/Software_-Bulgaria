package goods;

/**
 * Created by asen on 11/2/2015.
 */
public class GameConsole extends ElectronicDevice {

    private  String name;
    private int ram;
    private String department;

    public GameConsole(int ram){

        this.ram = ram;
    }

    public GameConsole(String name,int ram){

        super(name);
        this.ram = ram;

    }

    public GameConsole(double price,boolean hasGuarantee,String name,String company,int ram){

        super(price,hasGuarantee,name,company);
        this.ram = ram;
    }

    public  void on(){

    }

    public void loadGame(){

    }

}
