using SportsBet247.Models;

namespace SportsBet247.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationUser user;

        public UserService(ApplicationUser user)
        {
            this.user = user;
        }

        public void Deposit(double amount)
        {
            this.user.Balance += amount;
        }

        public void MakePrediction(string result)
        {
            this.user.Prediction = result;
        }
    }
}
