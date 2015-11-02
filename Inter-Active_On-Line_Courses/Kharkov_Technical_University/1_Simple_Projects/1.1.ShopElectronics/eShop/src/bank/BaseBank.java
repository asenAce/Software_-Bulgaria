package bank;

import interfaces.BankInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class BaseBank implements BankInterface {

    private String name;
    private String creditDescription;


    // Constructor
    public BaseBank(String name,String creditDescription){

        this.name=name;
        this.creditDescription = creditDescription;
    }


    @Override
    public  void checkInfo(){

    }
     @Override
    public  void giveCredit(){

    }
     @Override
    public String getName(){
        return name;
    }
     @Override
    public String getCreditDescription(){
        return creditDescription;
    }


}
