using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace web.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>();
        List<string> houses = new List<string>();
        List<string> years = new List<string>();

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

        public async Task<IActionResult> Index(string house, string year, string family)
        {
            var t = Task.Run(() => GetURI(new Uri("https://localhost:5001/api/Products/")));
            t.Wait();
            JArray j = JArray.Parse(t.Result);
            foreach (var elem in j)
            {
                products.Add(new Product((long)elem["id"],(string)elem["name"],(double)elem["price"],(string)elem["house"],(string)elem["year"]));
                houses.Add((string)elem["house"]);
                years.Add((string)elem["year"]);
            }

            List<Product> FilteredProducts = products.ToList();

            if (house != null)
            {
                FilteredProducts = products.Where(x => x.House == house).ToList();
            }
            else if (year != null)
            {
                FilteredProducts = products.Where(x => x.Year == year).ToList();
            }
            else if (year != null && house != null)
            {
                FilteredProducts = products.Where(x => x.Year == year).Where(x => x.House == house).ToList();
            }

            var housesListItems = houses.Select(x => new SelectListItem() { Text = x.ToString(), Value = x.ToString() });
            var yearsListItems = years.Select(x => new SelectListItem() { Text = x.ToString(), Value = x.ToString() });

            var productsGroupBy = new ProductViewModel
            {
                Products = FilteredProducts,
                Houses = new SelectList(housesListItems, "Value", "Text"),
                Years = new SelectList(yearsListItems, "Value", "Text")
            };

            return View(productsGroupBy);
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
            Product product = new Product((int)j["id"], (string)j["name"], (double)j["price"], (string)j["house"], (string)j["year"]);
            return View(product);
        }

    }
}
