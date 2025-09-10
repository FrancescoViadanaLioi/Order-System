using System;

namespace OrderSystem.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public OrderItem(int quantity, double price)
        {
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price));
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
