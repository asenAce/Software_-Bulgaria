package Services;

import enums.ConsultResult;
import interfaces.VisitorInterface;

/**
 * Created by asen on 11/2/2015.
 */
public class Consultant extends  AbstractEmployee{

    private String name;
    private String department;
    private boolean free;


    public   Consultant(){

    }

    public Consultant(String name){

        super(name);
    }

    public ConsultResult consult(VisitorInterface visitor){

        super.setFree(false);
        return ConsultResult.BUY;
    }

    public void send(){

    }

}
