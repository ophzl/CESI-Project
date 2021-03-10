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

        public async Task<IActionResult> Index()
        {
            var t = Task.Run(() => GetURI(new Uri("https://localhost:5001/api/Products/")));
            t.Wait();
            JArray j = JArray.Parse(t.Result);
            foreach (var elem in j)
            {
                products.Add(new Product((long)elem["id"],(string)elem["name"],(double)elem["price"],(string)elem["house"]));
            }
            return View(products);
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
            Product product = new Product((int)j["id"], (string)j["name"], (double)j["price"], (string)j["house"]);
            return View(product);
        }

    }
}
