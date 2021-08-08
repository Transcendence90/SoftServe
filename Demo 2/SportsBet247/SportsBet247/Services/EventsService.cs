using SportsBet247.Data;
using SportsBet247.Models;
using SportsBet247.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SportsBet247.Services
{
    public class EventsService : IEventsService
    {
        private readonly ApplicationDbContext db;

        public EventsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void CreateFootballEvent(string homeTeamName, string awayTeamName, DateTime playedOn, double homeTeamOdd, double awayTeamOdd, double drawOdd)
        {
            var footballEvent = new FootballEvent
            {
                HomeTeamName = homeTeamName,
                AwayTeamName = awayTeamName,
                PlayedOn = playedOn,
                HomeTeamOdd = homeTeamOdd,
                AwayTeamOdd = awayTeamOdd,
                DrawOdd = drawOdd,
            };
        }

        public IEnumerable<EventViewModel> SearchFootballEvents(DateTime playedOn)
        {
            return this.db.FootballEvents
                .Where(x => x.PlayedOn == playedOn)
                .Select(MapToFootballEventViewModel())
                .ToList();
        }

        public void UpdateFootballOdds(int eventId, double newHomeTeamOdd, double newAwayTeamOdd)
        {
            var footballEvent = this.db.FootballEvents.FirstOrDefault(x => x.Id == eventId);
            footballEvent.HomeTeamOdd = newHomeTeamOdd;
            footballEvent.AwayTeamOdd = newAwayTeamOdd;
        }

        private static Expression<Func<FootballEvent, EventViewModel>> MapToFootballEventViewModel()
        {
            return x => new EventViewModel
            {
                HomeTeamName = x.HomeTeamName,
                AwayTeamName = x.AwayTeamName,
                HomeTeamOdd = x.HomeTeamOdd,
                AwayTeamOdd = x.AwayTeamOdd,
                PlayedOn = x.PlayedOn,
                DrawOdd = x.DrawOdd,
            };
        }
    }
}
