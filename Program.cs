using System;
using OrderSystem.Entities;
using OrderSystem.Entities.EntitiesEnum;
using OrderSystem.Services.Validators;
using OrderSystem.View;
using OrderSystem.View.Resources;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the client' data:");
        string clientName = ClientDataInput.NameInput();
        string clientEmail = ClientDataInput.EmailInput();
        DateTime birthDate = ClientDataInput.BirthDateInput();

        Client client = new Client(clientName, clientEmail, birthDate);

        Console.WriteLine("Enter order data:");
        OrderStatus status = OrderDataInput.StatusInput();

        Order order = new Order(DateTime.Now, client, status);

        int itemsInOrder = OrderDataInput.OrderQuantityInput();

        var products = new List<Product>();

        for (int i = 1; i <= itemsInOrder; i++)
        {
            Console.WriteLine($"Enter with {i}# item data:");
            string productName = ProductInput.NameInput();
            double productPrice = ProductInput.PriceInput();

            products.Add(new Product(productName, productPrice));

            int productQuantity = ProductInput.QuantityInput(productName);

            OrderItem orderItem = new OrderItem(productQuantity, productPrice);

            order.AddItem(orderItem);
        }
        Console.WriteLine("Order summary:");
        Console.WriteLine(order.ToString());
        ConsoleUI.ShowInfo("End of the program.");
    }
}