public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        using (var context = new RailwayContext())
        {
            var user = context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                if (user.IsAdmin)
                {
                    new AdminDashboard().Show();
                }
                else
                {
                    new UserDashboard().Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
