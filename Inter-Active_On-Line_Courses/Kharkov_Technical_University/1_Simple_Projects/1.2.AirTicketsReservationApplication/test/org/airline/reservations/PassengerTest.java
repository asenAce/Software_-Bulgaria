package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class PassengerTest {

	@Test
	public void testPassenger() {
		Passenger testPassengerOne = new Passenger();
		String result = testPassengerOne.getName();
		assertEquals("Unknown name",result);
	}

	

	@Test
	public void testSetName() {
		Passenger testPassengerTwo = new Passenger();
		testPassengerTwo.setName("Asen Lozanow");
		assertEquals("Asen Lozanow", testPassengerTwo.getName());
	}

}
