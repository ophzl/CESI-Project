using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class Cart
    {
        public long Product_Id { get; set; }
        public int Quantity { get; set; }
        public long Customer_Id { get; set; }
    }
}
