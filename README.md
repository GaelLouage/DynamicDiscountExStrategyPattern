# Dynamic Discount System

This project is a simple implementation of a dynamic discount system using ASP.NET Core. The system applies different types of discounts based on the total amount.

## Features

- **Flat Amount Discount:** Applies a fixed discount to the total.
- **Percentage Discount:** Applies a percentage-based discount to the total.
- **No Discount:** No discount is applied if the total does not meet the discount criteria.

## Architecture

- **Strategy Pattern:** The discount types are implemented using the Strategy Design Pattern. Each discount type is encapsulated in its own class that implements the `IDiscountStrategy` interface.
- **Dependency Injection:** The `DiscountService` is injected into the application using ASP.NET Core's built-in Dependency Injection (DI) framework.

## Project Structure

- **Services:** Contains the core business logic for applying discounts.
  - `DiscountService`: Decides which discount strategy to apply based on the total amount.
- **Strategy:** Contains the different discount strategies.
  - `NoDiscount`: Applies no discount.
  - `PercentageDiscount`: Applies a percentage-based discount.
  - `FlatAmountDiscount`: Applies a flat discount.
- **Interfaces:** Contains the interfaces used by the services and strategies.

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download)
  
### Running the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/yourusername/DynamicDiscountSystemEx.git

    Navigate to the project directory:

    bash

cd DynamicDiscountSystemEx

Run the application:

bash

    dotnet run

    Access the application at http://localhost:5000 (or the port specified in your launch settings).

Example Usage

The application exposes a single endpoint (/) which applies a discount to a total amount. The default total is set to 250. You can change this value in the code to see how different discounts are applied.
