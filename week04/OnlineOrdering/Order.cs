using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            total += 5.00; // Flat shipping fee for USA customers
        }
        else
        {
            total += 35.00; // Flat shipping fee for international customers
        }
        return total;
    }

    public string packingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetID()})";
        }
        return label;
    }

    public string shippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetFullDetails()}";
    }
}