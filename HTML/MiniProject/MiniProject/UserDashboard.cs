public partial class UserDashboard : Form
{
    private BookingService bookingService = new BookingService();

    public UserDashboard()
    {
        InitializeComponent();
    }

    private void btnBook_Click(object sender, EventArgs e)
    {
        int trainNumber = Convert.ToInt32(txtTrainNumber.Text);
        int userId = 1; // Replace with logged-in user ID
        int numberOfSeats = Convert.ToInt32(txtNumberOfSeats.Text);

        bookingService.BookTickets(trainNumber, userId, numberOfSeats);
    }
}
