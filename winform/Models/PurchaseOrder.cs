﻿using System.Collections.Generic;
namespace winform.Models
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public double Price { get; set; }

        public Supplier Supplier { get; set; }
        public List<Product> Products { get; set; }
    }
}