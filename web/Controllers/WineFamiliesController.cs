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
    public class WineFamiliesController : Controller
    {

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
    }
}
