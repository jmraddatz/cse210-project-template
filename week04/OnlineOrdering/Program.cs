using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("777 East 900 South", "Provo", "UT", "United States");
        Customer customer1 = new Customer("Johnathon", address1);
        Product product1 = new Product("Sandals", 77389, 25.99, 1);
        Product product2 = new Product("Golf Balls", 33764, 1.99, 10);
        List<Product> list1 = new List<Product>();
        list1.Add(product1);
        list1.Add(product2);
        Order order1 = new Order(customer1, list1);

        Address address2 = new Address("SW1A 1AA", "Westminister", "London", "England");
        Customer customer2 = new Customer("King Charles III", address2);
        Product product3 = new Product("Royal Robe", 83441, 245.83, 3);
        Product product4 = new Product("Chain Mail Armor", 33290, 1985, 1);
        List<Product> list2 = new List<Product>();
        list2.Add(product3);
        list2.Add(product4);
        Order order2 = new Order(customer2, list2);


        Console.WriteLine($"Total: ${order1.Total()}\n");
        Console.WriteLine(order1.PackLabel());
        Console.WriteLine("Shipping Information:");
        Console.WriteLine(order1.ShipLabel());
        Console.WriteLine();

        Console.WriteLine($"\n\nTotal: ${order2.Total()}\n");
        Console.WriteLine(order2.PackLabel());
        Console.WriteLine("Shipping Information:");
        Console.WriteLine(order2.ShipLabel());
    }
}
