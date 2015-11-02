package Services;

import Start.SalesRoom;
import interfaces.DepartmentInterface;
import interfaces.EmployeeInterface;

/**
 * Created by asen on 11/2/2015.
 */
public class Administrator {

        private SalesRoom salesRoom;

        public  Administrator(SalesRoom salesRoom){

            this.salesRoom = salesRoom;
        }

        public Consultant getFreeConsultant(DepartmentInterface departmentInterface){

            for (EmployeeInterface employee : departmentInterface.getEmployeeList()) {

                if (employee instanceof  Consultant) {

                    if (employee.isFree()){

                        return (Consultant)employee;
                    }

                }

            }
             return  null;
        }
}
