using System;

namespace SocratesFrance
{
    public class DayHour
    {
        DateTime date;

        public DayHour(DateTime date)
        {
            this.date = date;
        }

        public bool IsLaterTheSameDay(DayHour dayHour)
        {
            return this.date.DayOfWeek == dayHour.date.DayOfWeek && this.date >= dayHour.date ;
        }

        public bool IsLater(DateTime referenceDate)
        {
            return this.date >= referenceDate;
        }

        public bool IsSooner(DateTime referenceDate)
        {
            return this.date < referenceDate;
        }
    }
}
