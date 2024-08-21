public partial class AdminDashboard : Form
{
    private BookingService bookingService = new BookingService();

    public AdminDashboard()
    {
        InitializeComponent();
    }

    private void btnViewBookings_Click(object sender, EventArgs e)
    {
        bookingService.PrintBookings();
    }

    private void btnViewCancellations_Click(object sender, EventArgs e)
    {
        bookingService.PrintCancellations();
    }
}
