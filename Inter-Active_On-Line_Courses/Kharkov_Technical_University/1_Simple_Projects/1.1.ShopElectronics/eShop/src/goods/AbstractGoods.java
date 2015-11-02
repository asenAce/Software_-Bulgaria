package goods;

import interfaces.DepartmentInterface;
import interfaces.GoodsInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class AbstractGoods implements GoodsInterface {

    private static final int DEFAULT_GUARANTEE = 2;

    private  double price;
    private boolean hasGuarantee;
    private String name;
    private DepartmentInterface department;
    private  String company;

    public AbstractGoods(){

    }

    public AbstractGoods(double price,boolean hasGuarantee,String name,String company){

        this.setPrice(price);
        this.setHasGuarantee(hasGuarantee);
        this.setName(name);
        this.setCompany(company);

    }

    public static int getDefaultGuarantee() {
        return DEFAULT_GUARANTEE;
    }

    @Override
    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

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
    public DepartmentInterface getDepartment() {
        return department;
    }

    public void setDepartment(DepartmentInterface department) {
        this.department = department;
    }

    @Override
    public String getCompany() {
        return company;
    }

    public void setCompany(String company) {
        this.company = company;
    }
}
