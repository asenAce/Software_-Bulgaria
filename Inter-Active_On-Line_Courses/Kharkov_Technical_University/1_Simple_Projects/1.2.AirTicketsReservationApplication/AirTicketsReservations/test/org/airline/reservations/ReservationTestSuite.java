package org.airline.reservations;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;
import org.junit.runners.Suite.SuiteClasses;
// It test all the tests 
@RunWith(Suite.class)
@SuiteClasses({ FlightTest.class, PassengerTest.class, SeatTest.class })
public class ReservationTestSuite {

}
