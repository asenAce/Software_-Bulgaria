package org.airline.reservations;

import java.time.LocalDate;

public class Ticket {

	//fields
	
	private LocalDate departureDate;
	private Passenger passenger;
	private Flight flight;
	private Seat seat;
	
	// Constructor should i write second constructor?
	public Ticket(){
		departureDate = LocalDate.now();
	}
	//getters and setters
	public LocalDate getDepartureDate() {
		return departureDate;
	}

	public void setDepartureDate(LocalDate departureDate) {
		this.departureDate = departureDate;
	}

	public Passenger getPassenger() {
		return passenger;
	}

	public void setPassenger(Passenger passenger) {
		this.passenger = passenger;
	}

	public Flight getFlight() {
		return flight;
	}

	public void setFlight(Flight flight) {
		this.flight = flight;
	}

	public Seat getSeat() {
		return seat;
	}

	public void setSeat(Seat seat) {
		this.seat = seat;
	}
	
	// Create the over ride method toString();
	// this method print in a friendly way all the information regarding the client;
	// the name of the passenger/client + the number of the flight + the name of the DepartureCity city +
	// + the name of arrival city + the current date of the voyage + and the seat  number of the passenger. each on 
	// is with calling the object. then calling the method();
	public String toString() {
		return "Ticket Info: " + this.getPassenger().getName() + this.getFlight().getFlightNumber() 
				+ this.getFlight().getDepartureCity() + this.getFlight().getArrivalCity() + this.getDepartureDate()+ this.getSeat().getSeatNumber();             		
	}
	
	
}
