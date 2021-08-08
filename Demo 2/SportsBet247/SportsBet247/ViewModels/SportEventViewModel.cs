using System;

namespace SportsBet247.ViewModels
{
    public class SportEventViewModel
    {
        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double HomeTeamOdd { get; set; }

        public string HomeTeamOddView => this.HomeTeamOdd.ToString("F2");

        public double AwayTeamOdd { get; set; }

        public string AwayTeamOddView => this.AwayTeamOdd.ToString("F2");

        public double DrawOdd { get; set; }

        public string DrawOddView => this.DrawOdd.ToString("F2");

        public double PointDifference { get; set; }
    }
}
