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
        double productTotal = 0;

        foreach (var product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return productTotal + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"- {product.GetProductName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetCustomerName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
    public void DisplayOrderInfo()
    {
        Console.WriteLine();

        Console.WriteLine(GetPackingLabel());

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(GetShippingLabel());
        Console.ResetColor();

        Console.WriteLine($"\nTotal Price: ${GetTotalPrice()}\n");

        Console.WriteLine("======================\n");


    }
}