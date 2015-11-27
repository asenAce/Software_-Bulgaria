package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class SeatTest {

	@Test
	public void testSeat() {
		Seat testSeatOne = new Seat();
		assertEquals(10,testSeatOne.getSeatNumber());
	}
	
	public void testSetSeatNumber() {
		Seat testSeatTwo = new Seat();
		testSeatTwo.setSeatNumber(2);
		assertEquals(2,testSeatTwo.getSeatNumber());
	}

}
