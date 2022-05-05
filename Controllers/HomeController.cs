using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sibahlenkosini.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Sibahlenkosini.Services;

namespace Sibahlenkosini.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            FirebaseData data = new FirebaseData();
            var pro = await data.GetDataAsync();
            ViewBag.Products = pro;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<ActionResult> Gallery()
        {

            FirebaseData data = new FirebaseData();
            var items = await data.GetAllMedia();
           

            ViewBag.Medias = items;
            

            return View();
        }

        [HttpPost]
        public IActionResult OnWhatsapp()
        {
            var process = $"whatsapp://send?phone=27825432455";
            Process.Start(process);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
