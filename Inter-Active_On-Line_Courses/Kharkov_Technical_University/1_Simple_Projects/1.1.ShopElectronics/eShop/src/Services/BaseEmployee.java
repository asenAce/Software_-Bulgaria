package Services;

import departments.BaseDepartment;
import interfaces.EmployeeInterface;
import interfaces.DepartmentInterface;
/**
 * Created by asen on 11/2/2015.
 */
public abstract class BaseEmployee implements EmployeeInterface {

    private String name;
    private BaseDepartment department;
    private boolean free;


    @Override
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public boolean isFree() {
        return free;
    }

    public void setFree(boolean free) {
        this.free = free;
    }

    @Override
    public DepartmentInterface getDepartment(){
        return department;
    }

    public void setDepartment(DepartmentInterface department){
        this.department= (BaseDepartment) department;
    }
}
