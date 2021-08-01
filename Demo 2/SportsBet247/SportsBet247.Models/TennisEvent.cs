using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBet247.Models
{
    public class TennisEvent
    {
        public int Id { get; set; }

        [Required]
        public string FirstPlayerName { get; set; }

        [Required]
        public string SecondPlayerName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double FirstPlayerOdd { get; set; }

        public double SecondPlayerOdd { get; set; }

        [Required]
        public string Result { get; set; }
    }
}
