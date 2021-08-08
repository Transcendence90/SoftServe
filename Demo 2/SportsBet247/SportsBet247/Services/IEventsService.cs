using SportsBet247.ViewModels;
using System;
using System.Collections.Generic;

namespace SportsBet247.Services
{
    public interface IEventsService
    {
        public void CreateFootballEvent(string homeTeamName, string awayTeamName, DateTime playedOn, double homeTeamOdd, double awayTeamOdd, double drawOdd);

        void UpdateFootballOdds(int eventId, double newHomeTeamOdd, double newAwayTeamOdd);

        IEnumerable<EventViewModel> SearchFootballEvents(DateTime playedOn);
    }
}
