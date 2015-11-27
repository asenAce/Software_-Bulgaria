package org.airline.reservations;

/*
 * Created by Kharkov_Technical_University ; 
 * Practiced  by Asen Lozanov aka Ace 
 * 
 */

public class Passenger {
	
	// 1>Data fields:
	// Access modifier private,type String, ID name ;  
	public  String name;
	
	// 2>Constructor
	// Create a pre-define Objects .Objects has parameters,the parameters are define
	// in the Constructor the constructor is like the biscuits cutter it mouds the forms of the biscuits
	// but each biscuit is unique and in the same time has major features of the rest biscuits. Objects can be created only in
	// a class, method / Function is the functionality of the program the method is the action. 
	public Passenger(){
		name = "Unknown name";
	}

	public Passenger(String name){
		setName(name);
	}
	// 3>getters and setters
	// get show the value.
	public String getName(){
		return name;
	}
	
	// void do not return anything.passing the parameter what type ..and ID()
	public void setName(String newName){
		name = newName;
	}
	//  OverRide concatenation of a strings 
	public String toString() {
		return "Passenger: " + this.getName();
	}
}







