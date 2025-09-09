using System;
using OrderSystem.Entities.EntitiesEnum;

namespace OrderSystem.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }
    }
}
