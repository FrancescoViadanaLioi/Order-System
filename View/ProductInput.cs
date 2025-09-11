using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystem.Services.Validators;
using OrderSystem.View.Resources;

namespace OrderSystem.View
{
    internal class ProductInput
    {
        public static string NameInput()
        {
            string name = InputHelper.GetValidatedInput(
                "Enter with the product's name: ",
                input => ProductValidator.IsValidName(input),
                input => input,
                "A product's name can have digits or characters only.");
            return name;
        }
        public static double PriceInput()
        {
            double price = InputHelper.GetValidatedInput(
                "Enter with the product's price: ",
                input => ProductValidator.IsValidPrice(input),
                input => double.Parse(input),
                "Enter with a valid price, which is only numbers above 0.");
            return price;
        }
        public static int Quantity(string productName)
        {
            int quantity = InputHelper.GetValidatedInput(
                $"How many units of the product {productName} are being ordered? ",
                input => ProductValidator.IsValidQuantity(input),
                input => int.Parse(input),
                "Check if the units are a integer number bigger than 0.");
            return quantity;
        }
    }
}
