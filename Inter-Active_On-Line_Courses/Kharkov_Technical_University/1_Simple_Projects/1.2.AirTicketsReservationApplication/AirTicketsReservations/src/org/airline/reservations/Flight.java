package org.airline.reservations;

public class Flight {

	private String departureCity;
	private String arrivalCity;
	private int flightNumber;

	public Flight() {
		departureCity = "Unknown Departure City";
		arrivalCity = "Unknown Arrival City";
		flightNumber= 100;
	}
	
	// Second Constructor
	public Flight(int flightNumber,String departureCity,String arrivalCity){
		setFlightNumber(flightNumber);
		setDepartureCity(departureCity);
		setArrivalCity(arrivalCity);
	}
 
	public String getDepartureCity() {
		return departureCity;
	}

	public void setDepartureCity(String departureCity) {
		this.departureCity = departureCity;
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
	
	// ToString();
	public String toString() {
		return "Flight Number: " + this.getFlightNumber() + " " + this.getDepartureCity() + " - " 
				+ this.getArrivalCity();
	}
	
	
	
	
	

}
