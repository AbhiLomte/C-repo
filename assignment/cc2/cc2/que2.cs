using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Product
    {
        public int Productid;
        {get:set;}
     
    public  String ProductName;
    {get:set;}

public decimal Price;

    { get: set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        for (int i = 0; i < 10; i++)
            {
            Product product = new Product();
            Console.Write("Enter Productid:");
            product.Productid = int.Parse(Console.ReadLine());
            Console.Write("Enter Productname:");
            product.ProductName = new ProductName();
            Console.Write("Enter price:")
                product.price = decimal.Parse(Console.ReadLine());

            products.Add(product);
        }
        var sortedProducts = products.OrderBy(p => p.Price).ToList();

        Console.Write("\n Products sorted by price:")
            foreach (var product in sortedProducts) ;
        {
            Console.WriteLine($"ID:{product.Productid},Name:{product.ProductName},Price:{product.Price}");
        } }       
        public static void Main(string[] args)
        {
        }
    }

