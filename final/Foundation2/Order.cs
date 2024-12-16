using System;


class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _shippingCost;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public int ShippingCost()
    {
        if (_customer.USResident())  // Check if the customer is a resident of the USA
            _shippingCost = 5;
        else
            _shippingCost = 35;

        return _shippingCost;
    }

    public string PackLabel()
    {
        string packLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packLabel += $"{product.GetName()}: {product.GetProductID()}\n";
        }
        return packLabel;
    }

    public string ShipLabel()
    {
        return $"Shipping Label:\n{_customer.GetAddress()}";
    }

    public int FullCost()
    {
        int totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }
        return totalProductCost + ShippingCost();
    }
}
