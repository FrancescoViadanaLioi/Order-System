using System;
using OrderSystem.Services.Validators;

namespace OrderSystem.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            if (!ProductValidator.IsValidName(name)) throw new ArgumentException("The name of the product only support characters and digits.");
            if (!ProductValidator.IsValidPrice(price)) throw new ArgumentException("The price must be a number higher than 0.");
            Name = name;
            Price = price;
        }
    }
}
