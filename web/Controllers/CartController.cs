using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using web.Models;

namespace web.Controllers
{
    public class CartController : Controller
    {
        static async Task<string> SendURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = u,
                    Content = c
                };

                HttpResponseMessage result = await client.SendAsync(request);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                }
            }
            return response;
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        // POST: Cart/CreateSaleOrder
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSaleOrder([Bind("Product_Id,Quantity")] Cart cart)
        {
            try
            {
                string productJson = JsonConvert.SerializeObject(cart);
                HttpContent content = new StringContent(productJson, Encoding.UTF8, "application/json");
                var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/SaleOrders"), content));
                return View();
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}