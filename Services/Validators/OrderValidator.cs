using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem.Entities.EntitiesEnum;

namespace OrderSystem.Services.Validators
{
    internal class OrderValidator
    {
        public static bool IsValidStatus(string input)
        {
            return Enum.TryParse<OrderStatus>(input, ignoreCase: true, out OrderStatus status);
        }
        public static bool IsValidItemsInOrder(string input)
        {
            return int.TryParse(input, out int quantity) && quantity > 0;
        }
    }
}
