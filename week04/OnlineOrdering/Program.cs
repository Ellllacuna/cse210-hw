using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("398 Stardale St", "Chesapeake", "VA", "USA");
        Customer customer1 = new Customer("Ellianna", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Grapes", "G100", 12.79, 2));
        order1.AddProduct(new Product("Spring Mix", "SM01", 4.98, 1));
        order1.AddProduct(new Product("Mushrooms", "M153", 2.98, 1));
        orders.Add(order1);

        Address address2 = new Address("100 1st S W St", "Rexburg", "Idaho", "USA");
        Customer customer2 = new Customer("Nana", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Oyster Crackers", "OC85", 1.95, 4));
        order2.AddProduct(new Product("Paperclips", "P852", 0.01, 195));
        order2.AddProduct(new Product("Medicine", "SERT1", 195, 1));
        orders.Add(order2);

        Address address3 = new Address("1600 Pennsylvania Ave NW", "London", "N/A", "England");
        Customer customer3 = new Customer("Bingus", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Diapers", "D459", 0.74, 145));
        order3.AddProduct(new Product("Scotch tape", "ST93", 3.99, 2));
        order3.AddProduct(new Product("Zipper", "Z753", 12.85, 10));
        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine("\nPacking Label:");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("---------------------------------------");
        }

    }
}