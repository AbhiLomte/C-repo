public class Cancellation
{
    public int CancellationID { get; set; }
    public int BookingID { get; set; }
    public Booking Booking { get; set; }
    public int NumberOfSeats { get; set; }
    public DateTime CancellationDate { get; set; }
}