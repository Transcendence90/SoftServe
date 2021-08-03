using System;

namespace SportsBet247.Services.Models
{
    public class EventViewModel
    {
        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double HomeTeamOdd { get; set; }

        public double AwayTeamOdd { get; set; }

        public double DrawOdd { get; set; }
    }
}
