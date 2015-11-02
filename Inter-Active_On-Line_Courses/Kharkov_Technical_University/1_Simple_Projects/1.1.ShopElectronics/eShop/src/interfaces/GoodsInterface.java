package interfaces;

/**
 * Created by asen on 11/2/2015.
 */
public interface GoodsInterface {

    double getPrice();
    boolean hasGuarantee();
    String getName();
    String getCompany();

    DepartmentInterface getDepartment();
    void setDepartment(DepartmentInterface department);



}
