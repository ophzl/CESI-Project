using System.Collections.Generic;
using System;


namespace api.Models
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public double Total { get; set; }

        public string Status { get; set; }
        
        public DateTime DateTime { get; set; }

        public List<Order> Orders { get; set; }
        public Supplier Supplier { get; set; }
        public long Supplier_Id { get; set; }
    }
}