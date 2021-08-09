using System;
using System.ComponentModel.DataAnnotations;

namespace SportsBet247.ValidationAttributes
{
    public class CurrentYearMaxValueAttribute : ValidationAttribute
    {
        public CurrentYearMaxValueAttribute(int minYear)
        {
            MinYear = minYear;
            this.ErrorMessage = $"You must be at least 18 years old.";
        }

        public int MinYear { get; }

        public override bool IsValid(object value)
        {
            if (value is int intValue)
            {
                if (intValue <= MinYear)
                {
                    return true;
                }
            }

            if (value is DateTime dtValue)
            {
                if (dtValue.Year <= MinYear)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
