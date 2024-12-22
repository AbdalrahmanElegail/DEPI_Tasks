using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Task7_Ticket_booking
{
    public enum TType { Regular, VIP, Child }                   
    
    public interface IOperations                                 
    {                                                            
        void BookTicket(Ticket ticket) { }
        void CancelTicket(int ticketId) { }
        void DisplayAvailableTickets() { }
    }
    public class Ticket
    {
        public int TicketId { get; private set; }    
        public string EventName { get; private set; }
        public TType TicketType { get; private set; }
        public double TicketPrice { get; private set; }

        public Ticket(int ticketId, string eventName, TType ticketType, double ticketPrice)
        {
            if (ticketId < 0 || string.IsNullOrWhiteSpace(eventName) || ticketPrice <= 0 || !Enum.IsDefined(ticketType))
            {
                Console.WriteLine("\nInvalid ticket data....");
            }
            else
            {
                TicketId = ticketId;
                EventName = eventName;
                TicketType = ticketType;
                TicketPrice = ticketPrice;
                Ticketing.AvailableTickets[TicketId] = new List<object> { EventName, TicketType, TicketPrice };
            }
        }
    } 
    public class Ticketing : IOperations
    { 
        public static Dictionary<int, List<object>> AvailableTickets = new Dictionary<int, List<object>>();
        public static Dictionary<int, List<object>> BookedTickets = new Dictionary<int, List<object>>();


        public static void BookTicket(int ticketId)
        {
            if (!BookedTickets.ContainsKey(ticketId) && AvailableTickets.ContainsKey(ticketId))
            {
                BookedTickets[ticketId] = new List<object>(AvailableTickets[ticketId]);
                AvailableTickets.Remove(ticketId);
                Console.WriteLine($"\nTicket: {ticketId} Booked successfully!");
            }
            else if (BookedTickets.ContainsKey(ticketId) && !AvailableTickets.ContainsKey(ticketId))
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} was already booked.");
            }
            else if (!BookedTickets.ContainsKey(ticketId) && !AvailableTickets.ContainsKey(ticketId))
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} Does not Exist.");
            }
            else
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} Has Error.");
            }            
        }


        public static void CancelTicket(int ticketId)
        {
            if (BookedTickets.ContainsKey(ticketId) && !AvailableTickets.ContainsKey(ticketId))
            {
                AvailableTickets[ticketId] = new List<object>(BookedTickets[ticketId]);
                BookedTickets.Remove(ticketId);
                Console.WriteLine($"\nTicket: {ticketId} Canceled successfully!");
            }
            else if (!BookedTickets.ContainsKey(ticketId) && AvailableTickets.ContainsKey(ticketId))
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} was not booked yet.");
            }
            else if (!BookedTickets.ContainsKey(ticketId) && !AvailableTickets.ContainsKey(ticketId))
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} Does not Exist.");
            }
            else
            {
                Console.WriteLine($"\nTicket with ID: {ticketId} Has Error.");
            }
        }


        public static void DisplayAvailableTickets()
        {
            if (AvailableTickets.Count == 0) { Console.WriteLine("No available tickets."); }
            else
            {
                foreach (var ticket in AvailableTickets)
                {
                    Console.WriteLine($"ID: {ticket.Key}".PadRight(7) + $"Event: {ticket.Value[0]}".PadRight(17) + $"Type: {ticket.Value[1]}".PadRight(15) + $"Price: {ticket.Value[2]}");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayBookedTickets()
        {
            if (BookedTickets.Count == 0) { Console.WriteLine("No booked tickets."); }
            else
            {
                foreach (var ticket in BookedTickets)
                {
                    Console.WriteLine($"ID: {ticket.Key}, Event: {ticket.Value[0]}, Type: {ticket.Value[1]}, Price: {ticket.Value[2]}");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        public delegate void TicketOperation(int ticketId);
        static void Main(string[] args)
        {
            TicketOperation cancelTicket = Ticketing.CancelTicket;
            TicketOperation bookTicket = Ticketing.BookTicket;

            Ticket ticket1 = new(1, "Concert", TType.VIP, 900.0);
            Ticket ticket2 = new(2, "Movie", TType.Regular, 500.0);
            Ticket ticket3 = new(3, "Match", TType.VIP, 200.0);
            Ticket ticket4 = new(4, "chilling", TType.Regular, 100.0);


            foreach (int i in Enumerable.Range(0, 9999))
            {
                Console.WriteLine("\nAvailable Tickets:");
                Ticketing.DisplayAvailableTickets();
                Console.WriteLine("\nBooked Tickets:");
                Ticketing.DisplayBookedTickets();
                Console.WriteLine("\n------Enter t => trminate the program || b => book a ticket || c => cancel a ticket------");
                string? inputt = Console.ReadLine();
                if (inputt == "t") { Console.WriteLine($"\nThank you..."); break; }
                else if (inputt == "b")
                {
                if (Ticketing.AvailableTickets.Count == 0)  Console.WriteLine("\nAll tickets are Booked.");
                else
                {
                    Console.Write("Enter the Id of the ticket you need  to book: ");
                    if (int.TryParse(Console.ReadLine(), out int id)) bookTicket(id);
                    else Console.WriteLine("invalid int input...");
                }
                }
                else if (inputt == "c")
                {
                    if (Ticketing.BookedTickets.Count == 0) Console.WriteLine("\nThere are No Booked tickets.");
                    else
                    {
                        Console.Write("Enter the Id of the ticket you need  to book: ");
                        if (int.TryParse(Console.ReadLine(), out int id)) cancelTicket(id);
                        else Console.WriteLine("invalid int input...");
                    }
                }
                else Console.WriteLine("\nInvalid Input...");
            }
            Console.ReadKey();
        }
    }
}