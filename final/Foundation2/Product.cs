using System;

class Product
{
    private string _name;
    private string _productID;
    private int _priceUnit;
    private int _quantity;

    public Product(string name, string productID, int priceUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _priceUnit = priceUnit;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _priceUnit * _quantity;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public string GetName()
    {
        return _name;
    }
}
