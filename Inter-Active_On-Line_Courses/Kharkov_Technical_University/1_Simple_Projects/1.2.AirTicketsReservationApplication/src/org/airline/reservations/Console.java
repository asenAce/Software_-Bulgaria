

// Import the package: 
package org.airline.reservations;
//Java Library .
import java.io.BufferedReader;  
import java.io.IOException;
import java.io.InputStreamReader;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.logging.Logger;

// The starting point of the application >> 
public class Console {

	public static void main(String[] args) {
		//1>> Initialize database. <<
			Database prodDB = new Database();
			prodDB.bootstrap();
		//2>> Initialize console. <<
			boolean always = true;
			BufferedReader screenInput = new BufferedReader(new InputStreamReader(System.in));
			//Declaring my variables:
			String passengerName = null;
			int flightNumber = 0;
			LocalDate departureDate = LocalDate.now();
			int seatNumber = 0;
			
		//3>> loop <<
			while(always){  // Indented with tab 
					//4 >> ask for passengerName and add. << 
					System.out.println("Please enter the name of the Passenger: ");
					
					try {
						passengerName = screenInput.readLine();
					} catch (IOException e) {
						System.out.println("Sorry,i do not understand.");
					}  
					
					// Exception Handling 
					boolean result = prodDB.addPassenger(passengerName);
					if(result){
						// Detecting existing Passenger 
						System.out.println("Welcome back " + passengerName );
					}else {
						// Detecting a new Passenger
						System.out.println("Welcome " + passengerName);
					}
					// by removing this the While loop will executed indefinitely always = false; // now the here the loop will stop 
					//5 >> show flights and ask for flight. <<
					// Display the information regarding the flights.
					System.out.println("\nHere are the available flights: ");
					for(Flight item : prodDB.getFlights()){
						System.out.println(item);
					}
					// Prompt the user
					System.out.println("Please enter the number of the flight which you want to book.");;
					// Exception Handling
					try{
						flightNumber = Integer.parseInt(screenInput.readLine());
					}catch(IOException e ){
						System.out.println("Please enter a flight number");
					}catch(NumberFormatException e ){
						// Global Logger
						Logger.getGlobal().warning("Flight must be an integer.");
					}
					
					
					
					//6 >> show available seats and ask. <<
					System.out.println("\nAssuming you are flying today,");
					System.out.println("Information regarding the avalabe seats on that flight: ");
					ArrayList<Seat> openSeats = prodDB.getOpenSeats(departureDate, flightNumber);
					for(Seat item : openSeats){
						System.out.print(item.getSeatNumber() + " ,");
					}
					System.out.println("\nPlease enter the number of the seat that you want to reservate: ");
					//Exception Handling
					try{
						seatNumber = Integer.parseInt(screenInput.readLine());
					}catch(IOException e ){
						System.out.println("Please enter a seat number: ");
					}
					//7 >> create the ticket and return the Information.<<
					String ticketInfo = prodDB.addTicket(departureDate, passengerName, flightNumber, seatNumber);
					System.out.println("\nReservation Successful. Here are your details:");
					System.out.println(ticketInfo + "\n");
					//8 >> Repeat the process.<<  
			} // End the While Loop so the program repeat 
	}

}
