using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // 8. TransactionRecord Model
    public class TransactionRecord
    {
        public int TransactionId { get; private set; }
        public DateTime Date { get; private set; }
        public string TransactionType { get; private set; } // "Restock" or "Deduct"
        public Product TransactedProduct { get; private set; }
        public int Quantity { get; private set; }
        public User PerformedBy { get; private set; }

        public TransactionRecord(int id, string type, Product product, int quantity, User user)
        {
            TransactionId = id;
            Date = DateTime.Now; // Automatically sets to current time
            TransactionType = type;
            TransactedProduct = product;
            Quantity = quantity;
            PerformedBy = user;
        }
    }
}
