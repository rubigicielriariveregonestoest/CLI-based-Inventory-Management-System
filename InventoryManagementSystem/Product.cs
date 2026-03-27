using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // 7. Product Model
    public class Product
    {
        public int ProductId { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Encapsulation: Stock can only be modified through specific methods, not set directly.
        public int StockQuantity { get; private set; }

        public Category ProductCategory { get; set; }
        public Supplier ProductSupplier { get; set; }

        public Product(int id, string name, decimal price, Category category, Supplier supplier)
        {
            ProductId = id;
            Name = name;
            Price = price;
            StockQuantity = 0; // Default stock is 0 until a restock transaction occurs
            ProductCategory = category;
            ProductSupplier = supplier;
        }

        // Methods for Restocking and Deducting Stock
        public void Restock(int amount)
        {
            if (amount > 0)
            {
                StockQuantity += amount;
            }
        }

        public bool DeductStock(int amount)
        {
            if (amount > 0 && StockQuantity >= amount)
            {
                StockQuantity -= amount;
                return true; // Successfully deducted
            }
            return false; // Insufficient stock or invalid amount
        }
    }
}
