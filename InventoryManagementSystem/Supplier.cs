using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // 5. Supplier Model
    public class Supplier
    {
        public int SupplierId { get; private set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

        public Supplier(int id, string name, string contactNumber)
        {
            SupplierId = id;
            Name = name;
            ContactNumber = contactNumber;
        }
    }
}
