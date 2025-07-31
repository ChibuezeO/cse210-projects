using System;
using System.Collections.Generic;
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name()
    {
        return _name;
    }

    public string ProductId()
    {
        return _productId;
    }

    public double Price()
    {
        return _price;
    }

    public int Quantity()
    {
        return _quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }
}
