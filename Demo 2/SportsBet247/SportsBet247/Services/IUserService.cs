using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBet247.Services
{
    public interface IUserService
    {
        public void Deposit(double amount);

        public void MakePrediction(string result);
    }
}
