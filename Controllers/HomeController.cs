using eproject_sem3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eproject_sem3.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blog() 
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult FeaturesDetails()
        {
            return View();
        }
        public IActionResult Feedback()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();

        }
        public IActionResult ProductDetail()
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