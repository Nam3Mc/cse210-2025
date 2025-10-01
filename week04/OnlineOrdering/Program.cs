using System;

class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Laptop", 1200.50f, 1);
        Product p2 = new Product("Mouse", 25.75f, 2);
        Product p3 = new Product("Keyboard", 55.30f, 1);
        List<Product> products = new List<Product> { p1, p2, p3 };
        Address address = new Address("123 Main Street", "New York", "NY", "45625", "USA");
        Customer customer = new Customer("John Doe", address);
        Order order = new Order(products, customer);

        Product p4 = new Product("Camara", 70, 1);
        Product p5 = new Product("Speaker", 300, 2);
        Product p6 = new Product("Desk", 825.30f, 1);
        List<Product> products2 = new List<Product> { p4, p5, p6 };
        Address address2 = new Address("742 Evergreen Terrace", "Springfield", "IL", "62704", "USA");
        Customer customer2 = new Customer("Ana Smith", address2);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("\n===== PACKING LABEL =====");
        order.GetPackingLabel();
        Console.WriteLine("\n===== SHIPPING LABEL =====");
        order.GetShippingLabel();
        Console.WriteLine($"\nTotal de la orden: ${order.GetTotal()}");

        Console.WriteLine("\n===== PACKING LABEL =====");
        order2.GetPackingLabel();
        Console.WriteLine("\n===== SHIPPING LABEL =====");
        order2.GetShippingLabel();
        Console.WriteLine($"\nTotal de la orden: ${order2.GetTotal()}");

    }
}