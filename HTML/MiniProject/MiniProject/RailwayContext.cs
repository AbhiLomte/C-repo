public class RailwayContext : DbContext
{
    public DbSet<Train> Trains { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Cancellation> Cancellations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=myDataBase;Trusted_Connection=True;");
    }
}