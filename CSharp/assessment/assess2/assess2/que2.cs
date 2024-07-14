using System;

class Products
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

class que2
{
    static void Main()
    {
        Products[] productList = new Products[10];

        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for Product {i + 1}:");

            Console.Write("Product ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            productList[i] = new Products
            {
                ProductId = productId,
                ProductName = productName,
                Price = price
            };
        }

       
        Array.Sort(productList, (p1, p2) => p1.Price.CompareTo(p2.Price));

       
        Console.WriteLine("\nProducts sorted by price:");
        foreach (var product in productList)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
        }

        Console.ReadLine(); 
    }
}
