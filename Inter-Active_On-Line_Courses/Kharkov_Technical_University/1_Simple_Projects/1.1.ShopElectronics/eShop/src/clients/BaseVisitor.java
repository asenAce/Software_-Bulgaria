package clients;

import interfaces.VisitorInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class BaseVisitor implements VisitorInterface {

    private String name;

     @Override
    public  void buy(){

    }
     @Override
    public void returnGoods(){

    }

    @Override
    public String getName(){
        return name;
    }

}
