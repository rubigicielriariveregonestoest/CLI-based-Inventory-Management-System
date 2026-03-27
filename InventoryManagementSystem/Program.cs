using System;
using System.Collections.Generic; // Required for List<T>

namespace InventoryManagementSystem
{
    class Program
    {
        // 1. Data Storage: Using List<T> as required (No Database)
        static List<Category> categories = new List<Category>();
        static List<Supplier> suppliers = new List<Supplier>();
        static List<Product> products = new List<Product>();
        static List<TransactionRecord> transactions = new List<TransactionRecord>();
        static List<User> users = new List<User>();

        // We can create a default user for the session
        static User currentUser = new User("AdminUser", "Admin");

        static void Main(string[] args)
        {
            bool isRunning = true;

            // 2. The Main Menu Loop
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("      INVENTORY MANAGEMENT SYSTEM       ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. Add Supplier");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Update Product");
                Console.WriteLine("7. Delete Product");
                Console.WriteLine("8. Restock / Deduct Stock");
                Console.WriteLine("9. View Transaction History");
                Console.WriteLine("10. Show Low-Stock Items");
                Console.WriteLine("11. Compute Total Inventory Value");
                Console.WriteLine("0. Exit");
                Console.WriteLine("========================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                // 3. Handling User Input
                switch (choice)
                {
                    case "1":
                        // AddCategory();
                        Console.WriteLine("Add Category selected. Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "2":
                        // AddSupplier();
                        Console.WriteLine("Add Supplier selected. Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case "3":
                        // AddProduct();
                        break;
                    case "4":
                        // ViewProducts();
                        break;
                    // ... We will fill the rest in as we build the features
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}