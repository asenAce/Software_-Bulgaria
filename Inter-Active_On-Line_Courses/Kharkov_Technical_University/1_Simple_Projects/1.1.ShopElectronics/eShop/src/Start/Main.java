package Start;

import Services.Administrator;
import Services.Consultant;
import clients.CommonVisitor;
import clients.VipVisitor;
import departments.ElectronicDepartment;
import departments.GameDepartment;
import enums.ConsultResult;
import goods.Computers;
import goods.GameConsole;
import goods.Televisors;

/**
 * Created by asen on 11/2/2015.
 */



public class Main {

    public static void main(String[] args) {

        imitateShopWorking();

    }

    private static void imitateShopWorking() {
        // Create a sales room
        SalesRoom salesRoom = new SalesRoom();
        // Create an Administrator in the trade room
        Administrator administrator = new Administrator(salesRoom);
        //Create two Departments
        ElectronicDepartment electronicDepartment = new ElectronicDepartment();
        GameDepartment gameDepartment = new GameDepartment();

        // Sixth   


        // Add the departments into the trade rooms
        // Object salesRoom . Method addDepartment () passing the parameters  electronicDepartment;
        salesRoom.addDepartment(electronicDepartment);
        salesRoom.addDepartment(gameDepartment);


        // Add worker to each department
        // Creating an Object consultantOne
        Consultant consultantOne = new Consultant("Djonn");
        // Object consultantOne has property / Method setFree() passing a parameter (true) a boolean expression;
        consultantOne.setFree(true);

        Consultant consultantTwo = new Consultant("Anna");
        // from back to front ==>  passing parameters () consultantOne a Method addEmployee pass the Object consultantOne
        // to electronicDepartment;
        electronicDepartment.addEmployee(consultantOne);
        electronicDepartment.addEmployee(consultantTwo);

        // Creating the commodities
        Computers computers = new Computers(200,true,"Zenbook","Asus",2048);
        Televisors televisors = new Televisors(1000.56,false,"Smart TV VTX","Samsung");
        GameConsole xbox = new GameConsole("XBOX",1024);

        //Add goods into the departments;
        electronicDepartment.addGoods(televisors);
        electronicDepartment.addGoods(computers);
        gameDepartment.addGoods(xbox);

        // Create a Customer
        CommonVisitor visitorOne = new CommonVisitor("Viktor");
        VipVisitor vipVisitorOne = new VipVisitor("Tonny",50);

        // Calling a free Consultant to serve the customer
        ConsultResult consultResults =  administrator.getFreeConsultant(electronicDepartment).consult(visitorOne);

        switch (consultResults) {

            case BUY:
                visitorOne.buy(televisors); // buy() a verb , televisors noun , visitorOne adjective
                break;
            case DoNot:
                break;

        }











    }

}
