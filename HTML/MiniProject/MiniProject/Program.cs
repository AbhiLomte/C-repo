class Program
{
    static void Main(string[] args)
    {
        var bookingService = new BookingService();

        // Example operations
        Console.WriteLine("Booking Tickets:");
        bookingService.BookTickets(14543, 1, 2); // TrainNumber, UserID, NumberOfSeats

        Console.WriteLine("Current Bookings:");
        bookingService.PrintBookings();

        Console.WriteLine("Canceling Tickets:");
        bookingService.CancelBooking(1, 1); // BookingID, NumberOfSeats

        Console.WriteLine("Updated Bookings:");
        bookingService.PrintBookings();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
