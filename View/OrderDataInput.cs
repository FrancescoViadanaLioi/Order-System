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
                input => Enum.Parse<OrderStatus>(input),
                "This status doesn't exist in our system.");
            return status;
        }
    }
}
