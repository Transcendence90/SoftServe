using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBet247.Models
{
    public class MMAEvent
    {
        public int Id { get; set; }

        [Required]
        public string FirstFighterName { get; set; }

        [Required]
        public string SecondFighterName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double FirstFighterOdd { get; set; }

        public double SecondFighterOdd { get; set; }

        public double DrawOdd { get; set; }

        [Required]
        public string Result { get; set; }
    }
}
