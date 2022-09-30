using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Order
    {
        public int Order_id { get; set; }
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }

        // Collegamento con Customer
        public int Customer_id { get; set; }
        public Customer Customer { get; set; }

        // Collegamento con Employee
        public List<Employee> Employees { get; set; }

        //Collegamento con Payment 
         public List<Payment> Payments { get; set; }

        // Collegamento con Products
        public List<Product> Products { get; set; }
    }
}
