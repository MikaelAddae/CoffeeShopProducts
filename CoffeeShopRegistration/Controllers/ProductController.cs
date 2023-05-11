using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers
{
    public class ProductController : Controller
    {
        private readonly CoffeeDbContext _coffeeDbContext;

        public ProductController (CoffeeDbContext context)
        {
            _coffeeDbContext = context;
        }
        public IActionResult Index()
        {
            List<Product> offerings = _coffeeDbContext.Products.ToList();
            return View(offerings);
        }

        public IActionResult Detail(int id)
        {
            Product p= _coffeeDbContext.Products.FirstOrDefault(p=>p.Id == id);

            return View(p);
        }
    }
}

            //Product p = _coffeeDbContext.Products.FirstOrDefault(p => p.Id == item);
            //_coffeeDBContext.Products.FirstOrDefault(e => e.Id == id);
            //_employeeDbContext.Employees.Remove(e);
            //_employeeDbContext.SaveChanges();
            //return RedirectToAction("EmployeesView");