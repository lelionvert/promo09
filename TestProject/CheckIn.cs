using System;

namespace SocratesFrance
{
    public class DayHour
    {
        DayOfWeek day;
        int hour;

        public DayHour(DayOfWeek day, int hour)
        {
            this.day = day;
            this.hour = hour;
        }

        public bool IsLaterTheSameDay(DayOfWeek startingDay, int startingHour)
        {
            return startingDay == day && startingHour <= hour;
        }
    }
}
