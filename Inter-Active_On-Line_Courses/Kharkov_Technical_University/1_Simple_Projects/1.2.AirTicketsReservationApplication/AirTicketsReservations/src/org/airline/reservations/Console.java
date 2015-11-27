package org.airline.reservations;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.logging.Logger;

public class Console {

	public static void main(String[] args) {
		
		// <1> Initialize database
		Database prodDB = new Database();
		prodDB.bootstrap();
		// <2> Initialize console
		boolean always = true;
		// bucket collecting  information
		BufferedReader screenInput = new BufferedReader(new InputStreamReader(System.in)); 
		// Initialize variables
		String passengerName = null;
		int flightNumber = 0;
		LocalDate departureDate = LocalDate.now();
		int seatNumber = 0;
		// <3> loop
		while(always){
			// tab indent 
			// <4> ask for passengerName and add..
				System.out.println("Please enter the Passenger Name:  ");
				
				try {
					passengerName = screenInput.readLine();
				} catch (IOException e) {
					System.out.println("Incorect ");
				}
				
				boolean result = prodDB.addPassenger(passengerName);
				// inform the passenger is he or she new or already existing in the program database.
				if(result){
					System.out.println("Welcome back " + passengerName );
				} else {
					System.out.println("Welcome  " + passengerName );
				}
				// always = false;
			// <5> show the flights and ask for the flight.
				// Prompt the user!
					System.out.println("\nInformation for the available flights: ");
					for(Flight item : prodDB.getFlights()){
						System.out.println(item);
					}
					System.out.println("Please enter the flight number which you want to book: ");
					try{
						// take the given value from the user and store it into the variable flightNumber.
					flightNumber = Integer.parseInt(screenInput.readLine());
					} catch (IOException e ){
						System.out.println("Incorect please try again!");
					} catch (NumberFormatException e) {
						Logger.getGlobal().warning("Incorect please try again!");
					}
			// <6> show the seats available and ask which one
					System.out.println("\nAssuming you are flighing today.");
					System.out.println("Information regarding the available seats numbers: ");
					
					ArrayList<Seat> openSeats = prodDB.getOpenSeats(departureDate, flightNumber);
					for(Seat item : openSeats){
						System.out.print(item.getSeatNumber() + ",");
					}
					System.out.println("Please choose the seat number:  ");
					try{
						seatNumber = Integer.parseInt(screenInput.readLine());
					} catch(IOException e) {
						System.out.println("Incorect please try again: ");
					}
			// <7> create the ticket and return info. about it.
					String ticketInfo = prodDB.addTicket(departureDate, passengerName, flightNumber, seatNumber);    
					System.out.println("Your Reservation is Successful.This is the information : ");
					System.out.println(ticketInfo + "\n");
			// <8> Do it again!!
		
		}
		
	}

}
