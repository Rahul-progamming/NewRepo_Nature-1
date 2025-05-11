using Microsoft.AspNetCore.Mvc;

namespace Nature_WebApplication.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Index()
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

        public IActionResult About()
        {
            return View();
        }

    }
}   
