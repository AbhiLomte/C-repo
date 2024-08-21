public class BookingService
{
    public void BookTickets(int trainNumber, int userId, int numberOfSeats)
    {
        using (var connection = new Database().GetConnection())
        {
            connection.Open();

            // Check if train is valid and active
            var cmd = new SqlCommand("SELECT Price, SeatsAvailable, TrainStatus FROM Trains WHERE TrainNumber = @TrainNumber", connection);
            cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var price = reader.GetInt32(0);
                var availableSeats = reader.GetInt32(1);
                var status = reader.GetString(2);

                if (status == "active" && availableSeats >= numberOfSeats && numberOfSeats <= 3)
                {
                    reader.Close();

                    // Make booking
                    cmd = new SqlCommand("INSERT INTO Bookings (TrainNumber, UserID, NumberOfSeats) VALUES (@TrainNumber, @UserID, @NumberOfSeats)", connection);
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                    cmd.ExecuteNonQuery();

                    // Update available seats
                    cmd = new SqlCommand("UPDATE Trains SET SeatsAvailable = SeatsAvailable - @NumberOfSeats WHERE TrainNumber = @TrainNumber", connection);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Booking confirmed.");
                }
                else
                {
                    Console.WriteLine("Train is either inactive or not enough seats available.");
                }
            }
            else
            {
                Console.WriteLine("Train not found.");
            }
        }
    }

    public void CancelBooking(int bookingId, int numberOfSeats)
    {
        using (var connection = new Database().GetConnection())
        {
            connection.Open();

            // Retrieve booking details
            var cmd = new SqlCommand("SELECT TrainNumber, NumberOfSeats FROM Bookings WHERE BookingID = @BookingID", connection);
            cmd.Parameters.AddWithValue("@BookingID", bookingId);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var trainNumber = reader.GetInt32(0);
                var bookedSeats = reader.GetInt32(1);

                if (numberOfSeats <= bookedSeats)
                {
                    reader.Close();

                    // Add to cancellations
                    cmd = new SqlCommand("INSERT INTO Cancellations (BookingID, NumberOfSeats) VALUES (@BookingID, @NumberOfSeats)", connection);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                    cmd.ExecuteNonQuery();

                    // Update booking
                    cmd = new SqlCommand("UPDATE Bookings SET NumberOfSeats = NumberOfSeats - @NumberOfSeats WHERE BookingID = @BookingID", connection);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.ExecuteNonQuery();

                    // Update train
                    cmd = new SqlCommand("UPDATE Trains SET SeatsAvailable = SeatsAvailable + @NumberOfSeats WHERE TrainNumber = (SELECT TrainNumber FROM Bookings WHERE BookingID = @BookingID)", connection);
                    cmd.Parameters.AddWithValue("@NumberOfSeats", numberOfSeats);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Cancellation processed.");
                }
                else
                {
                    Console.WriteLine("Invalid number of seats to cancel.");
                }
            }
        }
    }

    public void PrintBookings()
    {
        using (var connection = new Database().GetConnection())
        {
            connection.Open();
            var cmd = new SqlCommand("SELECT * FROM Bookings", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"BookingID: {reader["BookingID"]}, TrainNumber: {reader["TrainNumber"]}, UserID: {reader["UserID"]}, NumberOfSeats: {reader["NumberOfSeats"]}, BookingDate: {reader["BookingDate"]}");
            }
        }
    }

    public void PrintCancellations()
    {
        using (var connection = new Database().GetConnection())
        {
            connection.Open();
            var cmd = new SqlCommand("SELECT * FROM Cancellations", connection);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"CancellationID: {reader["CancellationID"]}, BookingID: {reader["BookingID"]}, NumberOfSeats: {reader["NumberOfSeats"]}, CancellationDate: {reader["CancellationDate"]}");
            }
        }
    }
}
