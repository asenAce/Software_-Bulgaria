package org.airline.reservations;

public class Seat {

	private int seatNumber;
	// should i write second constructor?
	public Seat() {
		setSeatNumber(10);
	}
	// second constructor to take parameters int seatNumbers
	public Seat(int seat){
		setSeatNumber(seat);
	}
	
	public int getSeatNumber() {
		return seatNumber;
	}

	public void setSeatNumber(int seatNumber) {
		this.seatNumber = seatNumber;
	}

	// toString method
	public String toString() {
		return "Seat Number: " + this.getSeatNumber();
	}
	
}
