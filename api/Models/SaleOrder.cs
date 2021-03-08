using System.Collections.Generic;

namespace api.Models
{
    public class SaleOrder
    {

        public long Id { get; set; }
        public double Total { get; set; }

        public List<Product> Products { get; set; }
        public long CustomerId { get; set; }

    }

}

