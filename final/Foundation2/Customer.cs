using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool USResident()
    {
        return _address.USAResident();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}
