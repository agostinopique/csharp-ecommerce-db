using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Employee
    {
        public int Employee_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Level { get; set; }

        // Collegamento con Order
        public int Order_id { get; set; }
        public Order Order { get; set; }
    }
}
