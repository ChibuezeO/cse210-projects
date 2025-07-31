using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Rexburg St", "Idaho", "ID", "USA");
        Address address2 = new Address("1 Woman lecturer, Awka", "Anambra", "AN", "Nigeria");

        Customer customer1 = new Customer("Hyacinth Okoro", address1);
        Customer customer2 = new Customer("Chibueze Smith", address2);

        Product product1 = new Product("Laptop", "LAP001", 999.99, 1);
        Product product2 = new Product("Mouse", "MOU002", 29.99, 2);
        Product product3 = new Product("Keyboard", "KEY003", 49.99, 1);
        Product product4 = new Product("Monitor", "MON004", 199.99, 1);

        List<Order> orders = new List<Order>();

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        orders.Add(order1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product2);
        orders.Add(order2);

        for (int i = 0; i < orders.Count; i++)
        {
            Console.WriteLine($"Order {i + 1}:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(orders[i].PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(orders[i].ShippingLabel());
            Console.WriteLine($"Total Cost: ${orders[i].TotalCost():F2}");
            Console.WriteLine();
        }

    }
}