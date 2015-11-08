package org.airline.reservations;

import static org.junit.Assert.*;

import org.junit.Test;

public class CharterTest {

	@Test
	public void testCharter() {
		Charter charterOne = new Charter(6010,"San Diego","San Francisco","2014-06-15T09:30");
		assertEquals(6010,charterOne.getFlightNumber());
		assertEquals("2014-06-15T09:30",charterOne.getDepartureDateTime().toString());
	}

}
