package interfaces;

import java.util.ArrayList;

/**
 * Created by asen on 11/2/2015.
 */
public interface DepartmentInterface {

    String getName();

    ArrayList<EmployeeInterface>getEmployeeList();
    ArrayList<GoodsInterface>getGoodsList();

}
