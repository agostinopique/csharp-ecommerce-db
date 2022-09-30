using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Customer
    {
        public int Customer_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Collegamento con Orders
        public List<Order> Orders { get; set; }
    }
} 
