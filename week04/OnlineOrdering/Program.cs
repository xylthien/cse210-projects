using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "Utah",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );


        // Products
        Product product1 = new Product(
            "Sword",
            "S001",
            50,
            2
        );

        Product product2 = new Product(
            "Shield",
            "S002",
            75,
            1
        );

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);


        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Address address2 = new Address(
            "456 Oak Avenue",
            "London",
            "England",
            "United Kingdom"
        );

        Customer customer2 = new Customer(
            "Jane Doe",
            address2
        );


        Product product3 = new Product(
            "Potion",
            "P001",
            10,
            5
        );

        Product product4 = new Product(
            "Magic Staff",
            "M001",
            120,
            1
        );

        Product product5 = new Product(
            "Spell Book",
            "B001",
            60,
            2
        );

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);


        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
