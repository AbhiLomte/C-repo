using System;

namespace TicketBookingApp
{
    class Trainticket
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                TicketBookingLibrary.TicketBooking ticketBooking = new TicketBookingLibrary.TicketBooking();
                ticketBooking.CalculateConcession(age);
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }

            Console.ReadLine(); // To keep console window open
        }
    }
}
