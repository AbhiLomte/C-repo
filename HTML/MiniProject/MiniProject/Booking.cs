public class Booking
{
    public int BookingID { get; set; }
    public int TrainNumber { get; set; }
    public Train Train { get; set; }
    public int UserID { get; set; }
    public User User { get; set; }
    public int NumberOfSeats { get; set; }
    public DateTime BookingDate { get; set; }
}