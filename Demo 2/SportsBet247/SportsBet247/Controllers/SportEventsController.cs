using Microsoft.AspNetCore.Mvc;
using SportsBet247.Services;
using SportsBet247.ViewModels;

namespace SportsBet247.Controllers
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

        public IActionResult Tennis()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForTennis()
            };

            return this.View(viewModel);
        }

        public IActionResult Volleyball()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForVolleyball()
            };

            return this.View(viewModel);
        }

        public IActionResult MMA()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForMMA()
            };

            return this.View(viewModel);
        }

        public IActionResult Basketball()
        {
            var viewModel = new SportEventsViewModel()
            {
                SportEvents = sportEventsService.GetTopEventsForBasketball()
            };

            return this.View(viewModel);
        }
    }
}
