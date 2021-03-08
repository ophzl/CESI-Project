using System.Collections.Generic;
namespace web.Models
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public double Price { get; set; }

        public long SupplierId { get; set; }
        public List<Product> Products { get; set; }
    }
}