package goods;

import departments.BaseDepartment;
import interfaces.GoodsInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class BaseGoods implements GoodsInterface {

    // properties that will have all the others commodities
    private double price;
    private boolean hasGuarantee;
    private  String name;
    private BaseDepartment department;
    private  String company;

    public BaseGoods() {

    }

    public BaseGoods(String name){

    }

    public BaseGoods(double price, boolean hasGuarantee, String name, String company) {


    }


    @Override
    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
    @Override
    public boolean hasGuarantee() {
        return hasGuarantee;
    }

    public void setHasGuarantee(boolean hasGuarantee) {
        this.hasGuarantee = hasGuarantee;
    }

    @Override
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String getCompany() {
        return company;
    }

    public void setCompany(String company){
        this.company = company;
    }

     @Override
    public BaseDepartment getDepartment(){
         return department;
     }
    public void setDepartment(BaseDepartment department){

        this.department = department;
    }
}
