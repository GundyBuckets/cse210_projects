using System;

class Program
{
    static void Main(string[] args)
    {
        // Address of the first customer
        Address firstAddress = new Address("742 Maple Grove Lane", "willowbrook", "Vermont", "USA");
        
        // Customer for first order
        Customer firstCustomer = new Customer("Billy Bob", firstAddress);
        
        // Products for the first order
        Product lamp = new Product("Luminara Smart Desk Lamp", "LUM-SD-2024-001", 89.99, 2);
        Product watch = new Product("Quantum Fitness Smartwatch", "QTM-FW-2024-002", 249.50, 1);

        // First Order
        Order firstOrder = new Order();
        firstOrder.SetCustomer(firstCustomer);
        firstOrder.AddProduct(lamp);
        firstOrder.AddProduct(watch);

        // Displaying the info of the first order
        Console.WriteLine("First Order");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(firstOrder.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine($"Cost: {firstOrder.CalculateTotalCost()}\n");

        // Address of the second customer
        Address secondAddress = new Address("1884 Spruce ValleyRoad", "Canmore", "Alberta", "Canada");

        // Customer for second order
        Customer secondCustomer = new Customer("Sally Jackson", secondAddress);

        // Products for the second order
        Product purifier = new Product("EcoBreeze Portable Air Purifier", "ECO-AP-2024-003", 129.75, 4);
        Product pillow = new Product("NovaSleep Memory Foam Pillow", "NVA-PW-2024-004", 64.50, 6);

        // Second Order
        Order secondOrder = new Order();
        secondOrder.SetCustomer(secondCustomer);
        secondOrder.AddProduct(purifier);
        secondOrder.AddProduct(pillow);

        // Displaying the info of the second order
        Console.WriteLine("Second Order");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine($"Cost: {secondOrder.CalculateTotalCost()}");

    }
}