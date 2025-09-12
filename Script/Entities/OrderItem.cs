using System;
using System.Globalization;
using System.Text;
using System.Xml.Linq;

namespace OrderSystem.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; private set; }

        public OrderItem(int quantity, Product product, double price)
        {
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity));
            if (price <= 0) throw new ArgumentOutOfRangeException(nameof(price));
            Quantity = quantity;
            Product = product;
            Price = price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Product.Name}");
            sb.AppendLine($"${Price.ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
