package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class PassengerTest {

	@Test
	public void testPassenger() {
		//step One creating an Object
		//test for the Constructor
		Passenger testPassengerOne = new Passenger();
		// step two variable result = the Object.Method();
		String result = testPassengerOne.getName();
		//step three call the special function assertEquals() and compare are they equals ,what we give with 
		//what we have; 
		assertEquals("Unknown name",result);
	}

	@Test
	public void testSetName() {
		Passenger testPassengerTwo = new  Passenger();
		testPassengerTwo.setName("Asen Lozanov"); // set write In 
		assertEquals("Asen Lozanov",testPassengerTwo.getName()); // get read Out (,) compare left with right 
	}

}
