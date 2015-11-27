package org.airline.reservations;

import java.time.LocalDateTime;

public class Charter extends Flight  {

	// data fields
	private LocalDateTime departureDateTime;
	
	// constructor
	public Charter(int flightNumber,String departureCity,String arrivalCity,String departureDateTime){
		super(flightNumber, departureCity,arrivalCity);
		setDepartureDateTime(departureDateTime);
	}

	public LocalDateTime getDepartureDateTime() {
		return departureDateTime;
	}

	public void setDepartureDateTime(String  departureDateTime) {
		this.departureDateTime =LocalDateTime.parse(departureDateTime) ;
	}
	
	// ToString();
	public String toString() {
		return "Flight Number: " + this.getFlightNumber() + " " + this.getDepartureCity() + " - " 
				+ this.getArrivalCity() + ", departing " + this.getDepartureDateTime().toLocalDate()
				+ " at " + this.getDepartureDateTime().toLocalTime();
	}				
	
}
