using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }

    public void SetCustomerName(string newName)
    {
        _customerName = newName;
    }

    public bool LivesInUSA()
    {
        return _customerAddress.IsInUSA();
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {_customerName}");

        Console.Write($"Customer Address: {_customerAddress.GetFullAddress()}");

        Console.WriteLine($"Lives in USA: {LivesInUSA()}");
    }
}