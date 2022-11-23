using HairdressingSalon.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class WorkersController : Controller
    {
        private readonly IWorkersService _workersService;

        public WorkersController(IWorkersService workersService)
        {
            _workersService = workersService;
        }

        [ResponseCache(Duration = 262)]
        public async Task<IActionResult> Get()
        {
            return View(await _workersService.Get(20, "Workers20"));
        }
    }
}
