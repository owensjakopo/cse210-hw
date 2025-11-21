using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Owen Jakopo", new Address("374 Chitambo Section", "Chinhoyi", "Mashonaland West", "Zimbabwe"));

        Customer customer2 = new Customer("Memory Antonio Jakopo", new Address("374 Chitambo Section", "Chinhoyi", "Mashonaland West", "Zimbabwe"));

        Customer customer3 = new Customer("Phillip Sigauke", new Address("123 Main St", "Springfield", "IL", "USA"));

        Product laptop = new Product(1, "Laptop", 200.32, 8);
        Product phone = new Product(2, "Phone", 100.50, 5);
        Product tablet = new Product(3, "Tablet", 150.75, 3);
        Product headphones = new Product(4, "Headphones", 50.25, 10);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);

        order1.AddProduct(laptop);
        order1.AddProduct(phone);

        order2.AddProduct(tablet);
        order2.AddProduct(headphones);

        order3.AddProduct(phone);
        order3.AddProduct(headphones);
        order3.AddProduct(laptop);


        order1.DisplayOrderInfo();
        order2.DisplayOrderInfo();
        order3.DisplayOrderInfo();

    }
}