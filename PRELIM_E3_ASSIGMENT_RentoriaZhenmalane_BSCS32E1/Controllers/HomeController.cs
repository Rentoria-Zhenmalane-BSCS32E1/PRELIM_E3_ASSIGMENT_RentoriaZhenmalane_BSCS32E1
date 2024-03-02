using Microsoft.AspNetCore.Mvc;
using PRELIM_E3_ASSIGMENT_RentoriaZhenmalane_BSCS32E1.Models;
using System.Diagnostics;

namespace PRELIM_E3_ASSIGMENT_RentoriaZhenmalane_BSCS32E1.Controllers
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
        public IActionResult Schedule()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
