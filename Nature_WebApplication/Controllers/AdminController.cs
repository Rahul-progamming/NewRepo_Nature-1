using Microsoft.AspNetCore.Mvc;

namespace Nature_WebApplication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
