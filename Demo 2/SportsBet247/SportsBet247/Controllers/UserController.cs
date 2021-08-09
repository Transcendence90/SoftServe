using Microsoft.AspNetCore.Mvc;
using SportsBet247.Services;

namespace SportsBet247.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Deposit(double inputAmount)
        {
            this.userService.Deposit(inputAmount);

            return this.RedirectToAction("Index");
        }
    }
}
