package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class DatabaseTest {

	@Test
	public void testDatabase() {
		 Database testDB = new Database();
		 assertEquals(0,testDB.getSeats().size());
		 assertEquals(0,testDB.getFlights().size());
		 assertEquals(0,testDB.getPassengers().size());
		 assertEquals(0,testDB.getTickets().size());
	}
	//Test Seat
	public void testAddSeat(){
		Database testDBtwo = new Database();
		testDBtwo.addSeat(2);
		assertEquals(1,testDBtwo.getSeats().size());
		assertEquals(2,testDBtwo.getSeats().get(0).getSeatNumber());
	}

	// Test Passenger
	public void testAddPassenger(){
		Database testDBThree = new Database();
		testDBThree.addPassenger("Ivanov");
		assertEquals("Petrow",testDBThree.getPassengers().size());
	}
	
	//Test Flight
	public void testAddFlight(){
		Database testDBFour = new Database();
		testDBFour.addFlight(1000,"Los Angelis","Chicago");
		assertEquals(1,testDBFour.getFlights().size());
	}
	
	public void testAddNewPassenger(){
		Database testDBFour = new Database();
		boolean resultOne = testDBFour.addPassenger("Asen Lozanov");
		assertEquals(false,resultOne);
		boolean resultTwo = testDBFour.addPassenger("Asen Lozanov");
		assertEquals(false,resultTwo);
	}
	
	public void	 testBootstrap() {
		Database testDBSeven = new Database();
		testDBSeven.bootstrap();
		assertEquals(6,testDBSeven.getSeats().size());
		assertEquals(4,testDBSeven.getSeats().size());
		
	}
	

}
