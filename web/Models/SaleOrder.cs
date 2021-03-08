using System.Collections.Generic;

namespace web.Models
{
    public class SaleOrder
    {

        public long Id { get; set; }
        public double Total { get; set; }

        public List<Product> Products { get; set; }
        public long CustomerId { get; set; }

    }

}

