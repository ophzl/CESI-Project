using System.Collections.Generic;
namespace api.Models
{
    public class PurchaseOrder
    {
        public long Id { get; set; }
        public double Price { get; set; }

        public long SupplierId { get; set; }
        public List<Product> Products { get; set; }
    }
}