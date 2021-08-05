using Microsoft.AspNetCore.Mvc;
using SportsBet247.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBet247.Web.Controllers
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
