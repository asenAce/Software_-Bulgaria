package departments;

/**
 * Created by asen on 11/2/2015.
 */
import java.util.ArrayList;
import departments.BaseDepartment;
import goods.BaseGoods;
import interfaces.DepartmentInterface;
import interfaces.EmployeeInterface;
import interfaces.GoodsInterface;
import Services.BaseEmployee;

public abstract class BaseDepartment implements DepartmentInterface {
    
    private String name;

    private  ArrayList<EmployeeInterface> employeeList;
    private  ArrayList<GoodsInterface>  goodsList;

    @Override
    public String getName(){
        return name;
    }


    public void setName(String name){
        this.name=name;
    }

    @Override
    public  ArrayList<EmployeeInterface> getEmployeeList(){

        return employeeList;
    }

    public void setEmployeeList(ArrayList<EmployeeInterface>employeeList){

        this.employeeList=employeeList;
    }

    @Override
    public  ArrayList<GoodsInterface>getGoodsList(){

        return goodsList;
    }

    public void setGoodsList(ArrayList<GoodsInterface> goodsList){

        this.goodsList = goodsList;
    }













}
