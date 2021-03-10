using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace web.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>();

        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var t = Task.Run(() => GetURI(new Uri("https://localhost:5001/api/Products/" + id)));
            t.Wait();
            var j = JObject.Parse(t.Result);
            Product product = new Product((int)j["id"], (string)j["name"], (double)j["price"]);
            return View(product);
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
