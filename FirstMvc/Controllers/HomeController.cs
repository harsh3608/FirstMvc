using FirstMvc.Data.DatabaseContext;
using FirstMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _context = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            List<City> cities = _context.Cities.ToList();

            ViewBag.Cities = cities;

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


        public IActionResult Icons()
        {
            return View();
        }
    }
}