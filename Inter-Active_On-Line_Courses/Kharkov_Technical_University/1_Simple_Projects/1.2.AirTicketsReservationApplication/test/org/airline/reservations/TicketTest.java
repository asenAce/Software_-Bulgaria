package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class TicketTest {

	@Test
	public void test() {
		Ticket testTicketOne = new Ticket();
		Passenger testPassengerOne = new Passenger("Asen Lozanov");
		testTicketOne.setPassenger(testPassengerOne);
		assertEquals("Asen Lozanov",testTicketOne.getPassenger().getName());
	}

}
