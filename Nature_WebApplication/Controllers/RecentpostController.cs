using Microsoft.AspNetCore.Mvc;

namespace Nature_WebApplication.Controllers
{
    public class RecentpostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RecentPost()
        {
            return View();
        }
    }
}
