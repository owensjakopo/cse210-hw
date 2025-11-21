using System;

public class Product
{
    private int _productId;
    private string _productName;
    private double _productPricePerUnit;
    private int _quantity;

    public Product(int productId, string productName, double productPricePerUnit, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _productPricePerUnit = productPricePerUnit;
        _quantity = quantity;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public double GetProductPricePerUnit()
    {
        return _productPricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _productPricePerUnit * _quantity;
    }
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Name: {_productName},Id: {_productId}, Price: {_productPricePerUnit}, Quantity: {_quantity}");
    }
}