using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace web.Controllers
{
    public class CustomersController : Controller
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

        static async Task<string> PutURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Put,
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

        // GET: CustomersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] Customer customer)
        {
            try
            {
                string customerJson = JsonConvert.SerializeObject(customer);
                HttpContent content = new StringContent(customerJson, Encoding.UTF8, "application/json");
                var t = await Task.Run(() => SendURI(new Uri("https://localhost:5001/api/Customers"), content));
                return View(customer);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address")] Customer customer)
        {
            if (id == customer.Id)
            {
                try
                {
                    string familyJson = JsonConvert.SerializeObject(customer);
                    HttpContent content = new StringContent(familyJson, Encoding.UTF8, "application/json");
                    var t = await Task.Run(() => PutURI(new Uri("https://localhost:5001/api/Customers/" + customer.Id), content));
                    return RedirectToAction(nameof(Edit));
                }
                catch (Exception e)
                {
                    return View();
                }
            }
            return View(customer);
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
