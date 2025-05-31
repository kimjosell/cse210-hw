public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

    public string GetFullDetails()
    {
        return $"{_name}\nAddress: {_address.GetFullAddress()}";
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}