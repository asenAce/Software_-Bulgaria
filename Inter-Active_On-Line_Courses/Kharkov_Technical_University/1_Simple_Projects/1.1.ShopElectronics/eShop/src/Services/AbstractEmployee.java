package Services;

import interfaces.DepartmentInterface;
import interfaces.EmployeeInterface;

/**
 * Created by asen on 11/2/2015.
 */
public abstract class AbstractEmployee implements EmployeeInterface {

    private String name;
    private DepartmentInterface department;
    private boolean free;


    public AbstractEmployee(){


    }

    public  AbstractEmployee(String name){

        this.setName(name);
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

    @Override
    public void setDepartment(DepartmentInterface department) {
        this.department = department;
    }

    @Override
    public boolean isFree() {
        return free;
    }

    public void setFree(boolean free) {
        this.free = free;
    }
}
