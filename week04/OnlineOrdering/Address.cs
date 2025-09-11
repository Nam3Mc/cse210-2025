public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;
    private string _country;

    public string GetAddress()
    {
        return $"{_street}, {_city} \n{_state} {_zipCode}, {_country} ";
    }
    public bool USAAddress()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        return false;
    }
    public Address(string street, string city, string state, string zipCode, string county)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = county;
    }
}