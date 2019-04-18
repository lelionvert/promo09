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

        public bool IsLater(DayHour referenceDate)
        {
            return this.date >= referenceDate.date;
        }

        public bool IsSooner(DayHour referenceDate)
        {
            return this.date < referenceDate.date;
        }
    }
}
