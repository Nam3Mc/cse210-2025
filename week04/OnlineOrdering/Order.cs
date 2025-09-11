public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public float GetTotal()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (!_customer.IsUSAAddress())
        {
            total += 35;
        }
        else
        {
            total += 5;
        }
        return total;
    }
    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetData().ElementAt(1)}, Id: {product.GetData().ElementAt(0)}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetData().ElementAt(0)}, Address: {_customer.GetAddress()}");
    }
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
}