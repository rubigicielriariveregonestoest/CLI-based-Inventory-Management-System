# CLI-Based Inventory Management System

## Overview
This is a Command-Line Interface (CLI) Inventory Management System built using C#. It relies heavily on Object-Oriented Programming (OOP) principles to manage inventory data securely. The application is designed to run entirely in-memory using generic lists, meaning it does not require an external database to function[cite: 4].

---

## System Architecture and Models

The system is structured around five core models, each separated into its own `.cs` file for clean organization:

*   **Category (`Category.cs`):** Defines product groupings using a `CategoryId` and a `Name`[cite: 2].
*   **Supplier (`Supplier.cs`):** Stores information about the people or companies supplying the items, including `SupplierId`, `Name`, and a `ContactNumber`[cite: 5].
*   **User (`User.cs`):** Manages the individuals operating the system, tracking their `Username` and a specific `Role` (such as "Admin" or "Staff")[cite: 7].
*   **Product (`Product.cs`):** The central entity of the system. It tracks the `ProductId`, `Name`, `Price`, and current `StockQuantity`[cite: 3]. Each product is also linked to a specific `Category` and `Supplier`[cite: 3]. 
*   **TransactionRecord (`TransactionRecord.cs`):** An audit trail for inventory changes. Whenever stock is added or removed, a record is created logging the `TransactionId`, the `TransactionType` (e.g., "Restock" or "Deduct"), the specific `Product`, the `Quantity` changed, and the `User` who performed the action[cite: 6]. It also automatically timestamps the action using `DateTime.Now`[cite: 6].

---

## Object-Oriented Programming (OOP) Highlights

This project enforces strict data integrity using core OOP concepts:

*   **Encapsulation:** Properties like IDs, user roles, and stock quantities use a `private set` modifier[cite: 2, 3, 5, 6, 7]. This prevents external parts of the program from accidentally overwriting critical data. 
*   **Controlled State Changes:** The `StockQuantity` inside the `Product` class cannot be changed directly[cite: 3]. Instead, it must be modified using the specific `Restock(int amount)` or `DeductStock(int amount)` methods, ensuring stock can only be altered in mathematically valid ways[cite: 3].
*   **Constructors:** Every model requires specific parameters to be initialized[cite: 2, 3, 5, 6, 7]. For example, a `Product` cannot be created without a valid `Category` and `Supplier` assigned to it right from the start[cite: 3].

---

## Main Program Logic (`Program.cs`)

The central nervous system of the application lives in `Program.cs`:

*   **In-Memory Storage:** The program uses static `List<T>` collections to act as our database, holding all instances of categories, suppliers, products, transactions, and users while the program is running[cite: 4]. 
*   **Session Management:** It initializes a default `currentUser` (AdminUser) so that actions can be logged against a specific profile immediately[cite: 4].
*   **The Interface Loop:** The application runs on a continuous `while (isRunning)` loop[cite: 4]. It presents an 11-option menu to the user, capturing their choices via `Console.ReadLine()` and executing the corresponding features using a `switch` statement[cite: 4]. Entering `0` safely breaks the loop and exits the application[cite: 4].
