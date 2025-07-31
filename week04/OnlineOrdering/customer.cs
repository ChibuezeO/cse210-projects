using System;
using System.Collections.Generic;
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string Name()
    {
        return _name;
    }

    public Address Address()
    {
        return _address;
    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
}