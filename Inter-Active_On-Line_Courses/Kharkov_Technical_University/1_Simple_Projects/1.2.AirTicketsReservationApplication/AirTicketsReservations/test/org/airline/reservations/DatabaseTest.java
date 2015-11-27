package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class DatabaseTest {

	@Test
	public void testDatabase() {
		 Database testDataBaseOne = new Database();
		 assertEquals(0,testDataBaseOne.getSeats().size());
		 assertEquals(0,testDataBaseOne.getFlights().size());
		 assertEquals(0,testDataBaseOne.getPassengers().size());
		 assertEquals(0,testDataBaseOne.getTickets().size());
	}
	
	@Test
	public void testAddSeat(){
		Database testDataBaseTwo = new Database();
		testDataBaseTwo.addSeat(2);
		assertEquals(1,testDataBaseTwo.getSeats().size());
		assertEquals(2,testDataBaseTwo.getSeats().get(0).getSeatNumber());
	}
	// Passenger and Flights tests
	@Test
	public void testAddPassenger(){
		Database testDataBaseThree = new Database();
		testDataBaseThree.addPassenger("Asen Lozanov");
		assertEquals(1,testDataBaseThree.getPassengers().size());
		//assertEquals(1,testDataBaseThree.getPassengers().get(0).getName());
	}
	
	
	@Test
	public void testAddFlight(){
		Database testDataBaseFour = new Database();
		testDataBaseFour.addFlight(1000,"Los Angeles","Chicago");
		assertEquals(1,testDataBaseFour.getFlights().size());
		//assertEquals(1,testDataBaseFour.getFlights().get(0).getFlightNumber());
	}
	
	public void testAddNewPassenger(){
		Database testDataBaseSix = new Database();
		boolean resultOne = testDataBaseSix.addPassenger("Asen Lozanov");
		assertEquals(false,resultOne);
		boolean resultTwo = testDataBaseSix.addPassenger("Asen Lozanov");
		assertEquals(true,resultTwo);
	}
	
	
	
	@Test
	public void testBootstrap(){
		Database testDataBaseFive = new Database();
		testDataBaseFive.bootstrap();
		assertEquals(6,testDataBaseFive.getSeats().size());  // 6  seats
		assertEquals(4,testDataBaseFive.getFlights().size()); // 4 flight destinations
	}
	
	
	
}
