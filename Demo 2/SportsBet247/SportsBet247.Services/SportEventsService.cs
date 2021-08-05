using SportsBet247.Data;
using SportsBet247.Models;
using SportsBet247.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SportsBet247.Services
{
    public class SportEventsService : ISportEventsService
    {
        private readonly SportsBet247DbContext db;

        public SportEventsService(SportsBet247DbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SportEventViewModel> GetTopEventsForBasketball(int count = 10)
        {
            return this.db.BasketballEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToBasketballEventViewModel())
                .Take(count)
                .ToList();
        }

        public IEnumerable<SportEventViewModel> GetTopEventsForBoxing(int count = 10)
        {
            return this.db.BoxingEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToBoxingEventViewModel())
                .Take(count)
                .ToList();
        }

        public IEnumerable<SportEventViewModel> GetTopEventsForFootball(int count = 10)
        {
            return this.db.FootballEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToFootballEventViewModel())
                .Take(count)
                .ToList();
        }

        public IEnumerable<SportEventViewModel> GetTopEventsForMMA(int count = 10)
        {
            return this.db.MMAEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToMMAEventViewModel())
                .Take(count)
                .ToList();
        }
        public IEnumerable<SportEventViewModel> GetTopEventsForTennis(int count = 10)
        {
            return this.db.TennisEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToTennisEventViewModel())
                .Take(count)
                .ToList();
        }

        public IEnumerable<SportEventViewModel> GetTopEventsForVolleyball(int count = 10)
        {
            return this.db.VolleyballEvents
                .OrderBy(x => x.PlayedOn)
                .Select(MapToVolleyballEventViewModel())
                .Take(count)
                .ToList();
        }

        private static Expression<Func<FootballEvent, SportEventViewModel>> MapToFootballEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.HomeTeamName,
                AwayTeamName = x.AwayTeamName,
                HomeTeamOdd = x.HomeTeamOdd,
                AwayTeamOdd = x.AwayTeamOdd,
                PlayedOn = x.PlayedOn,
                DrawOdd = x.DrawOdd,
            };
        }

        private static Expression<Func<BasketballEvent, SportEventViewModel>> MapToBasketballEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.HomeTeamName,
                AwayTeamName = x.AwayTeamName,
                HomeTeamOdd = x.HomeTeamOdd,
                AwayTeamOdd = x.AwayTeamOdd,
                PlayedOn = x.PlayedOn,
                DrawOdd = x.DrawOdd,
            };
        }

        private static Expression<Func<TennisEvent, SportEventViewModel>> MapToTennisEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.FirstPlayerName,
                AwayTeamName = x.SecondPlayerName,
                HomeTeamOdd = x.FirstPlayerOdd,
                AwayTeamOdd = x.SecondPlayerOdd,
                PlayedOn = x.PlayedOn,
            };
        }

        private static Expression<Func<VolleyballEvent, SportEventViewModel>> MapToVolleyballEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.HomeTeamName,
                AwayTeamName = x.AwayTeamName,
                HomeTeamOdd = x.HomeTeamOdd,
                AwayTeamOdd = x.AwayTeamOdd,
                PlayedOn = x.PlayedOn,
            };
        }

        private static Expression<Func<BoxingEvent, SportEventViewModel>> MapToBoxingEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.FirstBoxerName,
                AwayTeamName = x.SecondBoxerName,
                HomeTeamOdd = x.FirstBoxerOdd,
                AwayTeamOdd = x.SecondBoxerOdd,
                PlayedOn = x.PlayedOn,
                DrawOdd = x.DrawOdd,
            };
        }

        private static Expression<Func<MMAEvent, SportEventViewModel>> MapToMMAEventViewModel()
        {
            return x => new SportEventViewModel
            {
                HomeTeamName = x.FirstFighterName,
                AwayTeamName = x.SecondFighterName,
                HomeTeamOdd = x.FirstFighterOdd,
                AwayTeamOdd = x.SecondFighterOdd,
                PlayedOn = x.PlayedOn,
                DrawOdd = x.DrawOdd,
            };
        }
    }
}
