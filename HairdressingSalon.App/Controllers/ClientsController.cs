using HairdressingSalon.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientsService _clientsService;

        public ClientsController(IClientsService clientsService)
        {
            _clientsService = clientsService;
        }

        [ResponseCache(Duration = 262)]
        public async Task<IActionResult> Get()
        {
            return View(await _clientsService.Get(20, "Clients20"));
        }
    }
}
