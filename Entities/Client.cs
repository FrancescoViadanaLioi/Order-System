using System;
using OrderSystem.Services.Validations;

namespace OrderSystem.Entities
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Client(string name, string email, DateTime birthDate)
        {
            if (!ClientValidations.IsValidName(name)) throw new ArgumentException("This name is invalid.");
            if (!ClientValidations.IsValidEmail(email)) throw new ArgumentException("This email is invalid.");
            if (!ClientValidations.IsValidBirthDate(birthDate)) throw new ArgumentException("This birth date is invalid.");
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
