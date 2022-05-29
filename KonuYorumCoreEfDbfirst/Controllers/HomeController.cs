using KonuYorumCoreEfDbfirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KonuYorumCoreEfDbfirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // https://localhost:44383/Home/Index Program.cs altındaki route tanımı : controller/action/id?
        // https://localhost:44383/Home // route 'da default action tanımı index
        // https://localhost:44383 // route ' da default controller tanımı Home, default action tanımı Index
        public IActionResult Index()
        {
            return View();
        }

        // https://localhost:44383/Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        // https://localhost:44383/Home/Error
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}