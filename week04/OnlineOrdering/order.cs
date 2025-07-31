using System;
using System.Collections.Generic;
public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        total += _customer.IsInUsa() ? 5.0 : 35.0;
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.Name()}: {product.ProductId()}\n";
        }
        return label.TrimEnd('\n');
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name()}\n{_customer.Address().FullAddress()}";
    }

    public List<Product> ProductsList()
    {
        return _products;
    }

    public Customer Customer()
    {
        return _customer;
    }
}