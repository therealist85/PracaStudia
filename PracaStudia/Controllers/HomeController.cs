using Microsoft.AspNetCore.Mvc;
using PracaStudia.Models;
using System.Diagnostics;

namespace PracaStudia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Kontakt()
        {
            var model = new Kontakt()
            {
                Name = "Piotr Pyk",
                Adress = "Kielce, os. KSM",
             };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details()
        {
            var model = new List<Opis>()
            {
                new Opis()
                {
                    typ = "samochód osobowy",
                    przebieg = "125.500 km"
                }
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
