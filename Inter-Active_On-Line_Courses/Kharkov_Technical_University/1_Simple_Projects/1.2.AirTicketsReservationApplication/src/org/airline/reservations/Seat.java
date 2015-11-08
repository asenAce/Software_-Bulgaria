package org.airline.reservations;

public class Seat {

	private int seatNumber;

	public Seat() {
		setSeatNumber(10);
	}
	
	public Seat(int seat){
		setSeatNumber(seat);
	}

	public int getSeatNumber() {
		return seatNumber;
	}

	public void setSeatNumber(int seatNumber) {
		this.seatNumber = seatNumber;
	}

}
