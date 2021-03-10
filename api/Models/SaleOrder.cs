using System.Collections.Generic;
using System;

namespace api.Models
{
    public class SaleOrder
    {

        public long Id { get; set; }
        public double Total { get; set; }

        public string Status { get; set; }

        public List<Order> Orders { get; set; }

        public DateTime DateTime { get; set; }

        public Customer Customer { get; set; }
        public long Customer_Id { get; set; }

    }

}

