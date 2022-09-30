using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    public class Payment
    {
        public int Payment_id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }


        // Collegamento con Orders
        public int Order_id { get; set; }
        public Order Order { get; set; }
    }
}
