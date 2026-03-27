using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // 4. Category Model
    public class Category
    {
        public int CategoryId { get; private set; } // Private set enforces encapsulation
        public string Name { get; set; }

        // Constructor
        public Category(int id, string name)
        {
            CategoryId = id;
            Name = name;
        }
    }
}
