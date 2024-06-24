using System;

public class Doctor
{
    // Private fields
    private int regnNo;
    private string name;
    private double feesCharged;

    // Properties to provide access to the private fields

    // Property for RegnNo
    public int RegnNo
    {
        get { return regnNo; }
        set { regnNo = value; }
    }

    // Property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Property for FeesCharged
    public double FeesCharged
    {
        get { return feesCharged; }
        set { feesCharged = value; }
    }

    // Method to display Doctor details
    public void DisplayDetails()
    {
        Console.WriteLine($"Doctor Details:");
        Console.WriteLine($"Registration Number: {RegnNo}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Fees Charged: {FeesCharged:C}");
    }
}

class que5
{
    static void Main()
    {
        // Creating an instance of Doctor class
        Doctor doctor1 = new Doctor();

        // Setting values using properties
        doctor1.RegnNo = 45454;
        doctor1.Name = "Dr. Mahesh";
        doctor1.FeesCharged = 150.0; // Example fees charged

        // Displaying details using method
        doctor1.DisplayDetails();

        // Example of getting values through properties
        Console.WriteLine($"Example of getting values through properties:");
        Console.WriteLine($"Registration Number: {doctor1.RegnNo}");
        Console.WriteLine($"Name: {doctor1.Name}");
        Console.WriteLine($"Fees Charged: {doctor1.FeesCharged:C}");
        Console.Read();
    }
}
