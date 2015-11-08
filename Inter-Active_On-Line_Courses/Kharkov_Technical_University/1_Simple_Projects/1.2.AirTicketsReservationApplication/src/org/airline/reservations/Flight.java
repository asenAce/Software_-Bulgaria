package org.airline.reservations;

/*
 * 
 */

public class Flight {
	
	// Declaring the data fields,Properties
	private String departureCity;
	private String arrivalCity;
	private int flightNumber;
	
	// A constructor ,moulding the Object with pre-defined properties!
	public Flight() {
		departureCity = "Unknown Departure City ";
		arrivalCity = "Unknown Arrival City ";
		flightNumber = 100;
	}
	
	public Flight(int flightNumber, String departureCity, String arrivalCity) {
		setFlightNumber(flightNumber);
		setDepartureCity(departureCity);
		setArrivalCity(arrivalCity);
	}
	// Get and Set 
	public String getDepartureCity() {
		return departureCity;
	}

	public void setDepartureCity(String departureCity) {
		this.departureCity = departureCity;
	}
	
	public void setCities(String departureCity, String arrivalCity){
		this.departureCity = departureCity;
		this.arrivalCity = arrivalCity;
		
	}
	
	public String getArrivalCity() {
		return arrivalCity;
	}
	public void setArrivalCity(String arrivalCity) {
		this.arrivalCity = arrivalCity;
	}
	public int getFlightNumber() {
		return flightNumber;
	}
	public void setFlightNumber(int flightNumber) {
		this.flightNumber = flightNumber;
	}
	
	public String toString(){
		
		return "Flight: " + this.getFlightNumber() + " " + this.getDepartureCity() + " - " + this.getArrivalCity();  
	}

}
