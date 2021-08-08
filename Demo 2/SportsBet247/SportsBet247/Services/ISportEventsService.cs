using SportsBet247.ViewModels;
using System.Collections.Generic;

namespace SportsBet247.Services
{
    public interface ISportEventsService
    {
        IEnumerable<SportEventViewModel> GetTopEventsForFootball(int count = 10);

        IEnumerable<SportEventViewModel> GetTopEventsForBasketball(int count = 10);

        IEnumerable<SportEventViewModel> GetTopEventsForVolleyball(int count = 10);

        IEnumerable<SportEventViewModel> GetTopEventsForTennis(int count = 10);

        IEnumerable<SportEventViewModel> GetTopEventsForBoxing(int count = 10);

        IEnumerable<SportEventViewModel> GetTopEventsForMMA(int count = 10);
    }
}
