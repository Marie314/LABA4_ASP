using HairdressingSalon.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        [ResponseCache(Duration = 262)]
        public async Task<IActionResult> Get()
        {
            return View(await _servicesService.Get(20, "Services20"));
        }
    }
}
