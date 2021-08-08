using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SportsBet247.Models
{
    public class ApplicationUser : IdentityUser
    {
        public double Balance { get; set; }

        public string Prediction { get; set; }
    }
}
