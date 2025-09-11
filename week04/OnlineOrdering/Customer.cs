public class Customer
{
    private string _name;
    private Address _address;
    public bool IsUSAAddress()
    {
        return _address.USAAddress();
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public List<string> GetData()
    {
        string name = _name;
        string address = _address.GetAddress();
        return [name, address];
    }
    public string GetName()
    {
        return $"{_name}";
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}