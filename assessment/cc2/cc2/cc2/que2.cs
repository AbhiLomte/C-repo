using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Product
    {
        public int Productid;
        
     
        public  String ProductName;
    

        public decimal Price;

    
    }
    class Program
    { 
       public static void Main()
       {
        List<Product> products = new List<Product>();
        for (int i = 0; i < 10; i++)
        {
            Product productid = new Product();
            Console.Write("Enter Productid:");
            Product.productid = int.Parse(Console.ReadLine());
            Console.Write("Enter Productname:");
            Product.productName = new Product();
            Console.Write("Enter price:");
                Product.Price = decimal.Parse(Console.ReadLine());

            products.Add(Product);
        }
        var sortedProducts = products.OrderBy(p => p.Price).ToList();

        Console.Write("\n Products sorted by price:")
            foreach (var product in sortedProducts) ;
        {
         
            Console.WriteLine($" ID:{ product.Productid},Name:{ product.ProductName},Price:{ product.Price} ");
        }
        Console.Read();
       }       
        
    }

