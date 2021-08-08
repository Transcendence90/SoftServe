using Microsoft.AspNetCore.Mvc;
using SportsBet247.Services;

namespace SportsBet247.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventsService eventsService;

        public EventController(IEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        public IActionResult Events()
        {
            return this.View();
        }
    }
}
