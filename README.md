# Order System
<p align="center">
  <a href="https://dotnet.microsoft.com/download/dotnet/9.0">
    <img src="https://img.shields.io/badge/.NET-9.0-blue" alt=".NET 9.0"/>
  </a>
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/">
    <img src="https://img.shields.io/badge/C%23-13.0-green" alt="C# 13"/>
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="MIT License"/>
  </a>
</p>

A simple project console-based to test and showcase my skills with object oriented programming (OOP), software architecture patterns (such as SRP, DRY, and others), input validation and a modular code structure for managing clients, products, and orders. This is the most complete project that I have built since I started my studies and research.

## Features

- Register client information (name, email, birth date)
- Create new orders with status tracking
- Add multiple products and quantities to each order
- Input validation for all user entries
- Order summary with total calculation
- Clean, modular codebase for easy extension

## Technologies Used

- C# 13.0
- .NET 9
- Console Application

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later

### Running the Application

1. Clone the repository: https://github.com/FrancescoViadanaLioi/Order-System

2. Navigate to the project directory: `Script/`

3. Build and run the project: 
```powershell
cd Order-System
dotnet run
```
-Note: Do not create a new project inside the repository. Just run the cloned project.

## Usage

Follow the on-screen prompts to:
- Enter client data
```
Enter with the client's name: Jack
Enter with the client's email: jack.pot@outlook.com
Enter with the client's birth date (dd/MM/yyyy format): 02/04/2002
```
- Specify order status and number of items
```
Enter order data:
Status: Processing
How many items will be in this order? 2
```
- Add product details and quantities
```
Enter with #1 item data:
Enter with the product's name: TV
Enter with the product's price: $2000
How many units of the product TV are being ordered? 3
```
```
Enter with #2 item data:
Enter with the product's name: Gamer Keyboard
Enter with the product's price: $100
How many units of the product Gamer Keyboard are being ordered? 1
```
- View a summary of the completed order
```
Order summary:

Moment: 12/09/2025 10:13:41
Order status: Processing
Client: Jack (02/04/2002 00:00:00) - email: jack.pot@outlook.com
Order items:
TV
$2000.00
Subtotal: $6000.00

Gamer Keyboard
$100.00
Subtotal: $100.00

Total price: $6100.00

INFORMATION: End of the program.
(Press any key to proceed) //In this moment, any key that the user press the program will end.
```

## Project Structure

- `Entities/` – Core business entities (Client, Product, Order, etc.)
- `Services/Validators/` – Input validation logic
- `View/` – User input and output handling
- `Program.cs` – Main application entry point

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---
