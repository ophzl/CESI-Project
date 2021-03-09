using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Token
    {
        public long Id { get; set; }
        public string Bearer { get; set; }
        public DateTime CreatedAt { get; set; }

        public long Customer_Id { get; set; }
    }
}
