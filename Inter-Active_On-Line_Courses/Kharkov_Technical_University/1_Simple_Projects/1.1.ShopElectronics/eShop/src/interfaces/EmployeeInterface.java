package interfaces;

import java.util.ArrayList;

/**
 * Created by asen on 11/2/2015.
 */
public interface EmployeeInterface {

    String getName();
    boolean isFree();
    // Generic List<> of class EmployeeInterface
    // ArrayList<EmployeeInterface> getEmployeeList();
    // ArrayList<GoodsInterface> getGoodsList();


    DepartmentInterface getDepartment();
    void setDepartment(DepartmentInterface department);
}
