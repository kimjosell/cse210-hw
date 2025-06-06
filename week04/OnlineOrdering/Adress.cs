public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    public bool IsInUSA()
    {
        return _country.ToLower() == "united states" || _country.ToLower() == "usa" || _country.ToLower() == "united states of america";
    }
}