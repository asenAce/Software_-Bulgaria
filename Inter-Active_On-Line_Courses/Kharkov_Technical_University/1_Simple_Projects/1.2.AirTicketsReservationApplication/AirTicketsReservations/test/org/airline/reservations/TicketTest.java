package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class TicketTest {

	@Test
	public void testSetPassenger() {
		Ticket testTicketOne = new Ticket();
		Passenger testPassengerOne = new Passenger("Asen Lozanov");
		testTicketOne.setPassenger(testPassengerOne);
		assertEquals("Asen Lozanov",testTicketOne.getPassenger().getName());
		
	}
	
	public void testSetSeat() {
		Ticket testTicketTwo = new Ticket();
		Seat testSeatOne = new Seat();
		testTicketTwo.setSeat(testSeatOne);
		assertEquals(3,testSeatOne.getSeatNumber());
	}
	
	public void testSetFlight() {
		Ticket testTicketThree = new Ticket();
		Flight testFlightOne = new Flight();
		testTicketThree.setFlight(testFlightOne);
		assertEquals(1000,testFlightOne.getFlightNumber());
		
	}
	// How to test the toString()?
	
	
	

}
