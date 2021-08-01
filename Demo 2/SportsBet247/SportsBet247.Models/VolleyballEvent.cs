﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBet247.Models
{
    public class VolleyballEvent
    {
        public int Id { get; set; }

        [Required]
        public string HomeTeamName { get; set; }

        [Required]
        public string AwayTeamName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double HomeTeamOdd { get; set; }

        public double AwayTeamOdd { get; set; }

        [Required]
        public string Result { get; set; }
    }
}
