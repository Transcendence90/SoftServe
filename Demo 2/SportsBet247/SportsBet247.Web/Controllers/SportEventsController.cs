using Microsoft.AspNetCore.Mvc;
using SportsBet247.Services;
using SportsBet247.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBet247.Web.Controllers
{
    public class SportEventsController : Controller
    {
        private readonly ISportEventsService sportEventsService;

        public SportEventsController(ISportEventsService sportEventsService)
        {
            this.sportEventsService = sportEventsService;
        }

        public IActionResult Football()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForFootball()
            };

            return this.View(viewModel);
        }

        public IActionResult Boxing()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForBoxing()
            };

            return this.View(viewModel);
        }
    }
}
