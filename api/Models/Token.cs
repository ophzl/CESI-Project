using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Token
    {
        public long Id { get; set; }
        public string token { get; set; }
        public DateTime createdAt { get; set; }
    }
}
