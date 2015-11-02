package bank;

import interfaces.BankInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class AbstractBank implements BankInterface {

    private String name;
    private String creditDescription;
    public static int requestCount;

    public AbstractBank(String name,String creditDescription){
        this.name=name;
        this.setName(name);
        this.setCreditDescription(creditDescription);
    }

    @Override
    public void checkInfo(){
            requestCount++;
    }

    @Override
    public void giveCredit(){

    }


    @Override
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String getCreditDescription() {
        return creditDescription;
    }

    public void setCreditDescription(String creditDescription) {
        this.creditDescription = creditDescription;
    }
}
