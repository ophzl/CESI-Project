using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace web.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public SelectList Houses { get; set; }
        public SelectList Years { get; set; }
        public SelectList Families { get; set; }
        public string ProductHouse { get; set; }
        public string ProductYear { get; set; }
        public string ProductFamily { get; set; }
    }
}
