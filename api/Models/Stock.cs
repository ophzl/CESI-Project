using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public long Id { get; set; }
        
        public long ProductId { get; set; }
        public long Quantity { get; set; }
    }
}
