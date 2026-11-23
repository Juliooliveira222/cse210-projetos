using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(
        List<Product> products,
        Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateCost();
        }

        total += _customer.LivesInUSA()
            ? 5
            : 35;

        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("PACKING LABEL");

        foreach (Product product in _products)
        {
            Console.WriteLine(
                product.GetPackingInfo());
        }

        Console.WriteLine();
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(
            _customer.GetShippingInfo());

        Console.WriteLine();
    }
}