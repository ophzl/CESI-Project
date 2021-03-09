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
using RestSharp;

namespace web.Controllers
{
    public class WineFamiliesController : Controller
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

        // GET: WineFamilies
        public ActionResult Index()
        {
            return View();
        }

        // GET: WineFamilies/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WineFamilies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WineFamilies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] WineFamily family)
        {
            try
            {
                string familyJson = JsonConvert.SerializeObject(family);
                HttpContent content = new StringContent(familyJson, Encoding.UTF8, "application/json");
                var t = await Task.Run(() => SendURI(new Uri("https://localhost:44343/api/WineFamilies"), content));
                return View(family);
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: WineFamilies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WineFamilies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] WineFamily family)
        {
            if (id != family.Id)
            {
                try
                {
                    string familyJson = JsonConvert.SerializeObject(family);
                    HttpContent content = new StringContent(familyJson, Encoding.UTF8, "application/json");
                    var t = await Task.Run(() => PutURI(new Uri("https://localhost:44343/api/WineFamilies" + family.Id), content));
                    return View(family);
                }
                catch
                {
                    return View();
                }
            }
            return View(family);
        }

        // GET: WineFamilies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WineFamilies/Delete/5
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
