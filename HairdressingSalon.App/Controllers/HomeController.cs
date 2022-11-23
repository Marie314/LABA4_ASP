using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
