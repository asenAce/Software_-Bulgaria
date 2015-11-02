package bank;

/**
 * Created by asen on 11/2/2015.
 */
public class Sberbank extends  AbstractBank {

    //Constructor
    public  Sberbank(String name,String creditDescription){

        super(name,creditDescription);
    }

    @Override
    public void checkInfo(){
        //overworked realization
        super.checkInfo();
    }

    @Override
    public void giveCredit(){

    }
    // Override Method
    public void checkInfo(boolean critical){

    }


}
