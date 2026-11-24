using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double Total()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateTotal();
        }
        if (!_customer.LiveInUsa())
        {
            total += 35;
        }
        else
        {
            total += 5;
        }

        return total;
    }

    public string PackLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Product ID: {product.GetId()}\n";
            label += $"Product: {product.GetName()}\n\n";
        }
        return label;
    }

    public string ShipLabel()
    {
        string label = "";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().FullAddress()}";

        return label;
    }
}