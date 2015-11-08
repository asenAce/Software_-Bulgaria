package org.airline.reservations;

/*
 * A Test Suite that run all the test files for testing! In @SuiteClasses are all the files.The ID is ReservationTestSuite
 * 
 */

import org.junit.runner.RunWith;
import org.junit.runners.Suite;
import org.junit.runners.Suite.SuiteClasses;

@RunWith(Suite.class)
@SuiteClasses({ FlightTest.class, PassengerTest.class, SeatTest.class })
public class ReservationTestSuite {

}
