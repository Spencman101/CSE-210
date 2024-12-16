using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("John Doe", new Address("1234 Elm St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("5678 Oak Rd", "Toronto", "ON", "Canada"));

        Product product1 = new Product("Laptop", "001", 1000, 2);
        Product product2 = new Product("Mouse", "002", 25, 1);
        Product product3 = new Product("Keyboard", "003", 75, 1);
        
        List<Product> productsOrder1 = new List<Product> { product1, product2 };
        List<Product> productsOrder2 = new List<Product> { product3 };

        Order order1 = new Order(productsOrder1, customer1);
        Order order2 = new Order(productsOrder2, customer2);

        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.PackLabel());
        Console.WriteLine(order.ShipLabel());
        Console.WriteLine("Total Cost: $" + order.FullCost());
        Console.WriteLine();
    }
}
