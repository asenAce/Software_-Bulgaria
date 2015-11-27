package org.airline.reservations;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.logging.ConsoleHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

 

public class Database {
	
	// ArrayList<> base data men.;
	private ArrayList<Seat> seats;
	private ArrayList<Flight> flights;
	private ArrayList<Passenger> passengers;
	private ArrayList<Ticket> tickets;
	
	private static Logger databaseLog = Logger.getLogger(Database.class.getName());
	//the handler
	private static ConsoleHandler logScreen = new ConsoleHandler();
	// the constructor
	public Database() {
		seats = new ArrayList<Seat>();
		flights = new ArrayList<Flight>();
		passengers = new ArrayList<Passenger>();
		tickets = new ArrayList<Ticket>();
	}
	// getters
	public ArrayList<Seat> getSeats() {
		return seats;
		
	}
	
	public ArrayList<Flight> getFlights(){
		return flights;
	}
	
	public ArrayList<Passenger> getPassengers(){
		return passengers;
	}
	
	public ArrayList<Ticket> getTickets(){
		return tickets;
	}
	
	public void setLogging(){
		databaseLog.addHandler(logScreen);
		databaseLog.setLevel(Level.OFF); // change to FINER,FINE
		logScreen.setLevel(Level.OFF);
		databaseLog.setUseParentHandlers(false);
	}
	
	// Methods
	public void addSeat(int seatNumber) {
		// Creating a new object called Seat which taking parameters of int namely the (seatNumber);
		// need to be specified also in the constructor. class Seat
		seats.add(new Seat(seatNumber));  
		
	}
	public boolean addPassenger(String passengerName) {   
		boolean passengerExists = false;
		for(Passenger item : getPassengers()){
			if(passengerName.equals(item.getName())){
				passengerExists = true;
			}
		}
		if(passengerExists == false){
		passengers.add(new Passenger(passengerName));
		}
		return passengerExists;
		
	}
	public void addFlight(int flightNumber,String departureCity,String arrivalCity) {
		flights.add(new Flight(flightNumber,departureCity,arrivalCity));
		
	}
	
	public String addTicket(LocalDate departureDate,String passengerName,int flightNumber,int seatNumber) {
		databaseLog.fine("Beginning ticket creation ");
		// find the passenger object.
		databaseLog.fine("Finding Passenger  ");
		Passenger ticketPassenger = null;
		for(Passenger item : getPassengers()){
			if(passengerName.equals(item.getName())){
				ticketPassenger = item;
			}
		}
		// find the flight object
		databaseLog.fine("Finding flight  ");
		Flight ticketFlight = null;
		for(Flight item : getFlights()){
			databaseLog.finer("Comparing " + flightNumber + "to flight " + item.getFlightNumber());
			if(flightNumber == item.getFlightNumber()){
				ticketFlight = item;
			}
		}
		// find the seats
		databaseLog.fine("Finding a seat  ");
		Seat ticketSeat = null;
		for(Seat item : getSeats()){
			if(seatNumber == item.getSeatNumber()){
				ticketSeat = item;
			}
		}
		// Creating a new Object ID tempTicket from class Ticket;
		//so i can add it letter to the ArrayList 
		databaseLog.fine("Creating the Ticket  ");
		Ticket tempTicket = new Ticket();
		// Then we call the Methods from the class Ticket , passing the parameters()
		tempTicket.setDepartureDate(departureDate);
		tempTicket.setPassenger(ticketPassenger);
		tempTicket.setFlight(ticketFlight);
		tempTicket.setSeat(ticketSeat);
		//After we gather all the necessary information regarding the ticket object we add it to 
		// the Array List<> from right to left << the object tempTicket now has all the information which is parameters of the object
		// departureDate,ticketPassenger,ticketFlight,ticketSeat
		tickets.add(tempTicket);
		//return by calling the Method .toString() which is a method of tempTicket object.
		//it returns a nice summary of the ticket.from class Ticket
		databaseLog.info("Ticked created ");
		return tempTicket.toString();
		
	}
	
	// A method to check is there available seats 
	public ArrayList<Seat> getOpenSeats(LocalDate departureDate,int flightNumber){
		ArrayList<Seat> openSeats = getSeats();
		for(Ticket item : getTickets()){
			if(departureDate.equals(item.getDepartureDate()) && flightNumber == item.getFlight().getFlightNumber()){
				openSeats.remove(item.getSeat());
			}
		}
		return openSeats;
	}
	
	public void bootstrap() {
		addSeat(1);
		addSeat(2);
		addSeat(3);
		addSeat(4);
		addSeat(5);
		addSeat(6);
		
		addFlight( 1000," Los Angeles ","Chicago ");
		addFlight( 1010," Chicago "," New York ");
		addFlight( 2000," New York "," Chicago ");
		addFlight( 2010," Chicago "," Los Angeles ");
	}
	
	
}
