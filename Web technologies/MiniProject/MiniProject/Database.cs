public class Database
{
    private readonly string connectionString = "Server=localhost;Database=myDataBase;Trusted_Connection=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
