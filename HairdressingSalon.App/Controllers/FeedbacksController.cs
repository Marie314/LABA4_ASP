using HairdressingSalon.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HairdressingSalon.App.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly IFeedbacksService _feedbacksService;

        public FeedbacksController(IFeedbacksService feedbacksService)
        {
            _feedbacksService = feedbacksService;
        }

        [ResponseCache(Duration = 262)]
        public async Task<IActionResult> Get()
        {
            return View(await _feedbacksService.Get(20, "Feedbacks20"));
        }
    }
}
