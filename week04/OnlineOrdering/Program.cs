using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Apple St", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Arballo", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A404", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B101", 25.00, 2));

        Address address2 = new Address("456 Maple Dr", "London", "ON", "UK");
        Customer customer2 = new Customer("Jorge Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "C202", 150.00, 1));
        order2.AddProduct(new Product("Keyboard", "D303", 45.00, 1));
        order2.AddProduct(new Product("Webcam", "F505", 60.00, 1));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotal():0.00}");
        Console.WriteLine("------------------------------\n");
    }
}