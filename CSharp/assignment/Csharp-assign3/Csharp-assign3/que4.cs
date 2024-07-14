using System;

public class Customer
{
  
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
    public string City { get; set; }

    
    public Customer()
    {
        
        CustomerId = 0;
        Name = "Unknown";
        Age = 0;
        Phone = "N/A";
        City = "Unknown";
    }

   
    public Customer(int id, string name, int age, string phone, string city)
    {
        CustomerId = id;
        Name = name;
        Age = age;
        Phone = phone;
        City = city;
    }

   
    public static void DisplayCustomer(Customer customer)
    {
        Console.WriteLine($"Customer ID: {customer.CustomerId}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Age: {customer.Age}");
        Console.WriteLine($"Phone: {customer.Phone}");
        Console.WriteLine($"City: {customer.City}");
    }

    // Destructor
    ~Customer()
    {
        // Clean-up code if needed
        Console.WriteLine($"Customer object with ID {CustomerId} is being destroyed.");
    }
}

class Program
{
    public static void Main()
    {
        
        Customer customer1 = new Customer();
        Customer customer2 = new Customer(5, "Priyanka", 25, "23467245", "Hyderabad");

       
        Console.WriteLine("Customer 1:");
        Customer.DisplayCustomer(customer1);

        Console.WriteLine("\nCustomer 2:");
        Customer.DisplayCustomer(customer2);

       
       
        Console.ReadLine();
    }
}
