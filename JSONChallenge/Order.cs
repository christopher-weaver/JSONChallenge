using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge
{
    public class Order : ObjectForJson
    {
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> LineItems { get; set; } = new List<Product>();
        public DateTime PurchaseDate { get; set; }
    }
}
