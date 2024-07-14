using System;

namespace TicketBookingLibrary
{
    public class TicketBooking
    {
        // Constant fare
        private const decimal TotalFare = 500.00m;

        // Method to calculate concession based on age
        public void CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                decimal concessionAmount = 0.3m * TotalFare;
                decimal fareAfterConcession = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Fare after 30% concession: {fareAfterConcession:C}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare:C}");
            }
        }
    }
}
