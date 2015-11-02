package goods;

import interfaces.ElectronicDeviceInterface;

/**
 * Created by asen on 11/2/2015.
 */
public class ElectronicDevice extends BaseGoods implements ElectronicDeviceInterface {

    public ElectronicDevice(){

    }

    public ElectronicDevice(String name){
        super(name);
    }

    public ElectronicDevice(double price,boolean hasGuarantee,String name,String company){

        super(price,hasGuarantee,name,company);
    }

    public void on(){

    }

    public void off(){

    }


}
