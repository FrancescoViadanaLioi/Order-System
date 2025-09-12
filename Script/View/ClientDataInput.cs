using System;
using System.Collections.Generic;
using OrderSystem.View.Resources;
using OrderSystem.Services.Validators;

namespace OrderSystem.View
{
    internal class ClientDataInput
    {
        public static string NameInput()
        {
            string name = InputHelper.GetValidatedInput(
                "Enter with the client's name: ",
                input => !string.IsNullOrWhiteSpace(input) && ClientValidators.IsValidName(input),
                input => input,
                "This name cannot be set.");
            return name;
        }
        public static string EmailInput()
        {
            string email = InputHelper.GetValidatedInput(
                "Enter with the client's email: ",
                input => !string.IsNullOrWhiteSpace(input) && ClientValidators.IsValidEmail(input),
                input => input,
                "This email is not valid.");
            return email;
        }
        public static DateTime BirthDateInput()
        {
            DateTime birthDate = InputHelper.GetValidatedInput(
                "Enter with the client's birth date (dd/MM/yyyy format): ",
                input => ClientValidators.IsValidBirthDate(input),
                input => DateTime.Parse(input),
                "This birthdate is not valid.");
            return birthDate;
        }
    }
}
