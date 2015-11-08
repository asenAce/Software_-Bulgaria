package org.airline.reservations;

/*
 * Passenger.java a Test Driven programming/design / style explain what is Aglin ,Junit Testing ,Test Driven Development On Eclipse IDE
 * a test suit, Array List<> , Service Oriented Architecture. A reservation Application: Bucking air Tickets, JAR File,
 * 
 */

  public class Passenger {
	//Data fields
  private	String name;  // Passenger name,

  // Constructor ctor 
  public Passenger (){
	  
	  name = "Unknown name";
  }
  
  public Passenger (String name){
	  setName(name);
	  
  }
  
  // getters getName and setters
  public String getName(){   // call the value name ,return the name 
	  
	  return name;
  }
  
  // Set / put the value of the receiving variable newName into the setName
  public void setName(String newName){
	  
	  name = newName;
  }
  //@Override  
  public String toString() {
	return "Passenger : " + this.getName();
}
  
  
  
  
  
  
}
