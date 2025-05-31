public class Product
{
    private string _ID;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string ID, string name, double price, int quantity)
    {
        _ID = ID;
        _name = name;
        _price = price;
        _quantity = quantity;
    }
    public string GetID()
    {
        return _ID;
    }
    public string GetName()
    {
        return _name;
    }
    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}