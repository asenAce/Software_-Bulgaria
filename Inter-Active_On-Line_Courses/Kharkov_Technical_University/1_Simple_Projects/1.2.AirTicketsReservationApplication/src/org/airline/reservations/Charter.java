package org.airline.reservations;

import java.time.LocalDateTime;

// class Charter is a sub-Class of Flight ,class Charter inherited properties pre-defined in the class Flight  
public class Charter extends Flight {

	//fields
	private LocalDateTime departureDateTime; 
	
	// Constructor , passing the parameters () , extending the Functionality 
	public Charter(int flightNumber,String departureCity,String arrivalCity,String departureDateTime){
	super(flightNumber,departureCity,arrivalCity);	
	setDepartureDateTime(departureDateTime);
	}

	public LocalDateTime getDepartureDateTime() {
		return departureDateTime;
	}

	public void setDepartureDateTime(String departureDateTime) {
		this.departureDateTime = LocalDateTime.parse(departureDateTime);
	}
	// Adding 
	public String toString(){
		
		return "Flight: " + this.getFlightNumber() + " " + this.getDepartureCity() + " - " + this.getArrivalCity()
				+ ", departing" + this.getDepartureDateTime().toLocalTime();  
	}
	
}
