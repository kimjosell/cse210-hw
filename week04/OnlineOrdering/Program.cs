using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));
        Product product1 = new Product("P001", "Laptop", 999.99, 1);
        Product product2 = new Product("P002", "Smartphone", 499.99, 2);
        Product product3 = new Product("P003", "Headphones", 199.99, 1);

        Order order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
    

        Order order2 = new Order(new List<Product> { product1, product3 }, customer2);

        Console.WriteLine(order1.packingLabel());
        Console.WriteLine(order1.shippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.packingLabel());
        Console.WriteLine(order2.shippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
        Console.WriteLine();


    }
}