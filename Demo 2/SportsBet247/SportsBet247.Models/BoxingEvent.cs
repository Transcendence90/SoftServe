using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBet247.Models
{
    public class BoxingEvent
    {
        public int Id { get; set; }

        [Required]
        public string FirstBoxerName { get; set; }

        [Required]
        public string SecondBoxerName { get; set; }

        public DateTime PlayedOn { get; set; }

        public double FirstBoxerOdd { get; set; }

        public double SecondBoxerOdd { get; set; }

        public double DrawOdd { get; set; }

        public string Result { get; set; }
    }
}
