using SportsBet247.Data;
using SportsBet247.Services.Models;
using System;
using System.Collections.Generic;

namespace SportsBet247.Services
{
    public class EventsService : IEventsService
    {
        private readonly SportsBet247DbContext db;

        public EventsService(SportsBet247DbContext db)
        {
            this.db = db;
        }

        public IEnumerable<EventViewModel> Search(string homeTeamName, string awayTeamName, DateTime playedOn)
        {
            throw new System.NotImplementedException();
        }
    }
}
