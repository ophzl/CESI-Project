using System.Collections.Generic;

namespace api.Models
{
    public class Order
    {

        public long Id { get; set; }

        public Product Product { get; set; }
        public long Product_Id { get; set; }

        public long Quantity { get; set; }


        

    }

}

