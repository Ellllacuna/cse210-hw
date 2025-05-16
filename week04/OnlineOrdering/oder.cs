using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.InUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += ($"- {product.GetPackingLabel()}\n");
        }
        return label;
    }

    public string ShippingLabel()
    {
        return ($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}