using HairdressingSalon.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class ServiceKindsController : Controller
    {
        private readonly IServiceKindsService _serviceKindsService;

        public ServiceKindsController(IServiceKindsService serviceKindsService)
        {
            _serviceKindsService = serviceKindsService;
        }

        [ResponseCache(Duration = 262)]
        public async Task<IActionResult> Get()
        {
            return View(await _serviceKindsService.Get(20, "ServiceKinds20"));
        }
    }
}
