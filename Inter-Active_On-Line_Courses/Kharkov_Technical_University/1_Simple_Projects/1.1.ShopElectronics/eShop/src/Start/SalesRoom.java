package Start; /**
 * Created by asen on 11/2/2015.
 */
import Services.Administrator;
import interfaces.DepartmentInterface;
import interfaces.VisitorInterface;

import java.util.ArrayList;

public class SalesRoom {

    public static final String SHOP_NAME = "aceShop";

    private  ArrayList<VisitorInterface> visiorList = new ArrayList<VisitorInterface>();
    // in each department there is a unique worker
    private  ArrayList<DepartmentInterface> departmentList = new ArrayList<DepartmentInterface>();


    private  String name;
    private  String consultants;
    private  Administrator administrator;


    public  ArrayList<DepartmentInterface> getDepartmentList(){

        return departmentList;
    }

    public void addDepartment(DepartmentInterface department){

        departmentList.add(department);

    }

    public void  addVisitor(VisitorInterface visitor){

        visiorList.add(visitor);
    }

}
