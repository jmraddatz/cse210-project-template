using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _productQuantity;


    public Product(string name, int id, double unitPrice, int quantity)
    {
        _name = name;
        _productId = id;
        _price = unitPrice;
        _productQuantity = quantity;
    }
    public double CalculateTotal()
    {
        return _price * _productQuantity;
    }

    public int GetId()
    {
        return _productId;
    }

    public string GetName()
    {
        return _name;
    }
}