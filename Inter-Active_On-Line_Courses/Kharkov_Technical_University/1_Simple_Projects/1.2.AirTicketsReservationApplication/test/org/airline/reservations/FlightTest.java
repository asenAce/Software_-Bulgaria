package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class FlightTest {

	@Test
	public void testFlight() {
		Flight testFlightOne = new Flight();
		assertEquals("Unknown Departure City",testFlightOne.getDepartureCity());
		assertEquals("Unknown Arrival City",testFlightOne.getArrivalCity());
		assertEquals(100,testFlightOne.getFlightNumber());
	}
	
	@Test 
	public void testSetDepartureCity() {
		Flight testFlightTwo = new Flight();
		testFlightTwo.setDepartureCity("Los Angelos");
		assertEquals("Los Angelis",testFlightTwo.getDepartureCity());
	}
	@Test
	public void testSetArrivalCity() {
		Flight testFlightThree = new Flight();
		testFlightThree.setArrivalCity("Chicago");
		assertEquals("Chicago",testFlightThree.getArrivalCity());
	}
	@Test
	public void testSetFlightNumber(){
		Flight testFlightFour = new Flight();
		testFlightFour.setFlightNumber(1000);
		assertEquals(1000,testFlightFour.getFlightNumber());
		
		
	}
}
