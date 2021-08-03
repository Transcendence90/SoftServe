using SportsBet247.Services.Models;
using System;
using System.Collections.Generic;

namespace SportsBet247.Services
{
    public interface IEventsService
    {
        void Create(string homeTeamName, string awayTeamName, DateTime playedOn, double homeTeamOdd, double awayTeamOdd, double drawOdd)
        {
            var sportEvent = new SportEventViewModel
            {
                HomeTeamName = homeTeamName,
                AwayTeamName = awayTeamName,
                PlayedOn = playedOn,
                HomeTeamOdd = homeTeamOdd,
                AwayTeamOdd = awayTeamOdd,
                DrawOdd = drawOdd,
            };
        }

        IEnumerable<EventViewModel> Search(string homeTeamName, string awayTeamName, DateTime playedOn);
    }
}
