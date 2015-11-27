package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class FlightTest {

	@Test
	public void testFlight() {
		// test for the constructor for non existing Class.
		Flight testFlightOne = new Flight();
		//Test for the data fields.
		assertEquals("Unknown Departure City",testFlightOne.getDepartureCity());
		assertEquals("Unknown Arrival City",testFlightOne.getArrivalCity());
		assertEquals(100,testFlightOne.getFlightNumber());
	}
	
	public void testSetDepartureCity() {
		Flight testFlightTwo = new Flight();
		testFlightTwo.setDepartureCity("Los Angelos");
		assertEquals("Los Angelos",testFlightTwo.getDepartureCity());
	}
	
	public void testSetArrivalCity() {
		Flight testFlightThree = new Flight();
		testFlightThree.setArrivalCity("Chicago");
		assertEquals("Chicago",testFlightThree.getDepartureCity());
	}
	
	public void testFlightNumber() {
		Flight testFlightFour = new Flight();
		testFlightFour.setFlightNumber(1000);
		assertEquals(1000,testFlightFour.getFlightNumber());
	}
	
	
	

}
