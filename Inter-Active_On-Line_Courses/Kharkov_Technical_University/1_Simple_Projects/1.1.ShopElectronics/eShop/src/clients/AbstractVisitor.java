package clients;

import interfaces.GoodsInterface;
import interfaces.VisitorInterface;



/**
 * Created by asen on 11/2/2015.
 */
public abstract class AbstractVisitor implements VisitorInterface {

    private String name;

    public AbstractVisitor(){

    }

    public AbstractVisitor(String name){
        this.name=name;
    }

    //@Override
    public void buy(GoodsInterface goods){

        System.out.println("buy" + goods.getName());
    }

    // @Override
    public void returnGoods(GoodsInterface goods){

    }

    @Override
    public String getName(){

        return name;
    }




}
