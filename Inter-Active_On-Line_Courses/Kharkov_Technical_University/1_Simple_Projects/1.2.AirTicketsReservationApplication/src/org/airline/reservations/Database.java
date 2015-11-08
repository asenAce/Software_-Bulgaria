package org.airline.reservations;

import java.time.LocalDate;
import java.util.ArrayList; 
import java.util.logging.ConsoleHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
//  Quickfix

public class Database {
	
	// Declaring the Generic lists ArrayList<> , four Fields ;
	private ArrayList<Seat> seats;
	private ArrayList<Flight> flights;
	private ArrayList<Passenger> passengers;
	private ArrayList<Ticket> tickets;
	
	private static Logger databaseLog = Logger.getLogger(Database.class.getName());
	//Handler
	private static ConsoleHandler LogScreen = new ConsoleHandler();
	
	// Constructors that constructs all the  Four ArrayLists 
	public Database() {  
		seats = new ArrayList<Seat>();
		flights = new ArrayList<Flight>();
		passengers = new ArrayList<Passenger>();
		tickets = new ArrayList<Ticket>();
	}

	// Getters the functionality of our program:
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

	//setters
	public void setLogging(){
		databaseLog.addHandler(LogScreen);
		databaseLog.setLevel(Level.OFF); // Important when you start debugging switch to FINER, so you can see all the messages
		LogScreen.setLevel(Level.OFF);	// to the console. for how the program runs. lOGGING is expected features for all Java developers.   
		databaseLog.setUseParentHandlers(false);
	}
	
	public void addSeat(int seatNumber) {
		seats.add(new Seat(seatNumber));
		
	}

	public boolean addPassenger(String passengerName) {
		boolean passengerExists = false;
		for(Passenger item : getPassengers()){
			if(passengerName.equals(item.getName())){
				passengerExists = true;
			}
		}
		if(passengerExists = false){
			passengers.add(new Passenger(passengerName));
		}
		return passengerExists;
	}
	
	public String addTicket(LocalDate departureDate,String passengerName,int flightNumber,int seatNumber) {
		databaseLog.fine("Beginning ticket creation");
		//For the Passenger,find the passenger Object
		databaseLog.fine("Finding  passenger.");
		Passenger ticketPassenger = null;
		for(Passenger item : getPassengers()){
			if(passengerName.equals(item.getName())){
				ticketPassenger = item;
			}
		}
		
		//for the flight
		Flight ticketFlight = null;
		for(Flight item : getFlights()){
			databaseLog.finer("Comparing" + flightNumber + " to flight " + item.getFlightNumber());
			if(flightNumber == item.getFlightNumber()){
				ticketFlight = item;
			}
		}
		
		// for the seat object
		databaseLog.fine("Finding Seat ");
		Seat ticketSeat = null;
		for(Seat item : getSeats()){
			if(seatNumber == item.getSeatNumber()){
				ticketSeat = item;
			}
			
		}
		
		Ticket tempTicket = new Ticket();
		
		tempTicket.setDepartureDate(departureDate);
		tempTicket.setPassenger(ticketPassenger);
		tempTicket.setFlight(ticketFlight);
		tempTicket.setSeat(ticketSeat);
		tickets.add(tempTicket);
		databaseLog.info("Ticket created.");
		
		
		return tempTicket.toString();
		
	}

	public void addFlight(int flightNumber,String departureCity,String arrivalCity) {
		flights.add(new Flight(flightNumber,departureCity,arrivalCity));
		
	}
	
	public ArrayList<Seat> getOpenSeats(LocalDate departureDate,int flightNumber) {
		ArrayList<Seat> openSeats = getSeats();
		for(Ticket item : getTickets()){
			if(departureDate.equals(item.getDepartureDate())&& flightNumber == item.getFlight().getFlightNumber()){
				openSeats.remove(item.getSeat());
			}
		}
		return openSeats;
	}
	
	
	public void bootstrap  () {
		
		addSeat(1);
		addSeat(2);
		addSeat(3);
		addSeat(4);
		addSeat(5);
		addSeat(6);
		
		addFlight(1000,"Los Angelos","Chicago");
		addFlight(1010,"Chicago","New York");
		addFlight(2000,"New York","Chicago");
		addFlight(2010,"Chicago","Los Angelos");
		
	
	}
	
	
	
	
	
	
	
	
	
	

}
