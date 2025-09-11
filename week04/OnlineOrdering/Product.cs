public class Product
{
    private Guid _id;
    private string _name;
    private float _price;
    private int _quantity;
    public float GetTotalCost()
    {
        return _price * _quantity;
    }
    public Product(string name, float price, int quantity)
    {
        Guid id = Guid.NewGuid();
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }
    public List<object> GetData()
    {
        Guid id = _id;
        string name = _name;
        float price = _price;
        int quantity = _quantity;
        return [id.ToString(), name, price, quantity];
    }
}