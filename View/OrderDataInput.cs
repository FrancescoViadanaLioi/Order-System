using System;
using OrderSystem.View.Resources;
using OrderSystem.Entities.EntitiesEnum;
using OrderSystem.Services.Validators;

namespace OrderSystem.View
{
    internal class OrderDataInput
    {
        public static OrderStatus StatusInput()
        {
            OrderStatus status = InputHelper.GetValidatedInput(
                "Status: ",
                input => !string.IsNullOrWhiteSpace(input) && OrderValidator.IsValidStatus(input),
                input => Enum.Parse<OrderStatus>(input, ignoreCase : true),
                "This status doesn't exist in our system.");
            return status;
        }
        public static int OrderQuantityInput()
        {
            int quantity = InputHelper.GetValidatedInput(
                "How many items will be in this order? ",
                input => OrderValidator.IsValidItemsInOrder(input),
                input => int.Parse(input),
                "It has to be at least one item in the order.");
            return quantity;
        }
    }
}
