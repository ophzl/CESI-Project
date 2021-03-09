using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;


namespace web.Controllers
{
    public class ProductsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,SellPrice,WineFamily")] Product product)
        {
            var values = new Dictionary<string, string>
            {
                {"Id", product.Id.ToString() },
                {"Name", product.Name },
                {"Price", product.Price.ToString() },
                {"SellPrice", product.SellPrice.ToString() },
                {"WineFamily", product.WineFamily.ToString() },
            };
            var content = new FormUrlEncodedContent(values);
            var client = new HttpClient();
            var res = await client.PostAsync("https://localhost:44343/api/WineFamilies", content);
            Console.WriteLine(res);
            return View(product);
        }
    }
}
