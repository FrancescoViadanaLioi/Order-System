using System;

namespace OrderSystem.Entities.EntitiesEnum
{
    internal enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Ordered = 3
    }
}
