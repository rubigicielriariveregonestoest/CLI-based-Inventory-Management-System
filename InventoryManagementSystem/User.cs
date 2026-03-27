using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    // 6. User Model
    public class User
    {
        public string Username { get; private set; }
        public string Role { get; private set; } // e.g., "Admin", "Staff"

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }
    }
}
