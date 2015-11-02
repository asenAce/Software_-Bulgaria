package clients;

import interfaces.GoodsInterface;

/**
 * Created by asen on 11/2/2015.
 */
public class VipVisitor extends  AbstractVisitor {


    public VipVisitor(float discount){
        this.discount = discount;
    }

    public VipVisitor(String name,float discount){

        super(name);
        this.discount = discount;
    }

    private String name;
    private  float discount;

    public void buy(GoodsInterface goods){

        if (!checkDiscount()){
            super.buy(goods);
        }else {
            // buy with discount;
        }

    }

    private boolean checkDiscount() {

        return discount>0;
    }

    public void returnGoods(){

    }
}
