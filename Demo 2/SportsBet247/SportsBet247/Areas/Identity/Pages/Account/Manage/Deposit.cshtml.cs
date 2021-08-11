using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SportsBet247.Data;
using SportsBet247.Models;
using System.Threading.Tasks;

namespace SportsBet247.Areas.Identity.Pages.Account.Manage
{
    public class DepositModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<DepositModel> _logger;
        private readonly ApplicationDbContext db;

        public DepositModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<DepositModel> logger,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            this.db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            public double Amount { get; set; }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                this._userManager.GetUserAsync(User).Result.Balance += Input.Amount;
                await this.db.SaveChangesAsync();
            }

            return Page();
        }
    }
}