using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShopRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CoffeeDbContext _coffeeDbContext;

        public HomeController(ILogger<HomeController> logger, CoffeeDbContext context)
        {
            _logger = logger;
            _coffeeDbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        { 
            return View();
        }

        public IActionResult Success(User result)
        {
            if(result.Password.ToLower().Contains("password"))
            {
                return RedirectToAction("Failed");
            }
            else
            {
                return View(result);
            }
        }

        public IActionResult Failed()
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