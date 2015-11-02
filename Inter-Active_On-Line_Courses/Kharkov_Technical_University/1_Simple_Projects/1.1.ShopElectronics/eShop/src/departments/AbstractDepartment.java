package departments;

import interfaces.DepartmentInterface;
import interfaces.EmployeeInterface;
import interfaces.GoodsInterface;

import java.util.ArrayList;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class AbstractDepartment implements DepartmentInterface {

    private String name;
    private ArrayList<EmployeeInterface> employeeList=new ArrayList<EmployeeInterface>();
    private ArrayList<GoodsInterface> goodsList = new ArrayList<GoodsInterface>();


    public AbstractDepartment(){


    }

    public AbstractDepartment(String name){

         this.name = name;
    }

    @Override
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public ArrayList<EmployeeInterface> getEmployeeList() {
        return employeeList;
    }

    public void setEmployeeList(ArrayList<EmployeeInterface> employeeList) {
        this.employeeList = employeeList;
    }

    @Override
    public ArrayList<GoodsInterface> getGoodsList() {
        return goodsList;
    }

    public void setGoodsList(ArrayList<GoodsInterface> goodsList) {
        this.goodsList = goodsList;
    }

    public void addEmployee(EmployeeInterface employee){

        employee.setDepartment(this);
        employeeList.add(employee);
    }

    public  void addGoods(GoodsInterface goods){

        goods.setDepartment(this);
        goodsList.add(goods);

    }
}
