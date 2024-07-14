using System;

public class Saledetails
{
    // Data members
    private int Salesno;
    private int Productno;
    private double Price;
    private string dateofsale;
    private int Qty;
    private double TotalAmount;

    // Constructor to initialize the object
    public Saledetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
    {
        this.Salesno = salesNo;
        this.Productno = productNo;
        this.Price = price;
        this.Qty = qty;
        this.dateofsale = dateOfSale;

        // Calculate TotalAmount upon object creation
        Sales();
    }

    // Method to calculate TotalAmount based on Qty and Price
    public void Sales()
    {
        TotalAmount = Qty * Price;
    }

    
    public void showData()
    {
        Console.WriteLine("Sales No: " + Salesno);
        Console.WriteLine("Product No: " + Productno);
        Console.WriteLine("Price per unit: $" + Price.ToString("F2"));
        Console.WriteLine("Quantity sold: " + Qty);
        Console.WriteLine("Date of sale: " + dateofsale);
        Console.WriteLine("Total Amount: $" + TotalAmount.ToString("F2"));
    }

    public static void Main(string[] args)
    {
        
        Saledetails sale1 = new Saledetails(1, 101, 25.5, 5, "2024-06-24");

        
        sale1.showData();
        Console.Read();
    }
}
