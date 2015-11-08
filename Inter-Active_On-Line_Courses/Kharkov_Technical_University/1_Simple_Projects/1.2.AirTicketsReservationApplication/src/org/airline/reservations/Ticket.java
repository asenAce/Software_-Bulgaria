package org.airline.reservations;

import java.time.LocalDate;

public class Ticket {

	// the Data Fields:
	private LocalDate departureDate;
	private Passenger passenger;
	private Flight flight;
	private Seat seat;
	
	// A Constructor
	public Ticket(){
		
		departureDate = LocalDate.now();
		
	}
	// The Getter and Setters

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
	
	// Concatenation of Strings " " + " " The Report on your  Ticket.....
	public String toString(){
		return "Ticket: " + this.getPassenger().getName() + " departing on flight " + this.getFlight().getFlightNumber()
				+ " from " + this.getFlight().getDepartureCity() + "to" + this.getFlight().getArrivalCity() + "on"
				+ this.getDepartureDate()+ "in a seat " + this.getSeat().getSeatNumber();
	}
	
}
