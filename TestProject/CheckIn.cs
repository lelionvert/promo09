using System;

namespace SocratesFrance
{
    public class CheckIn
    {
        DayOfWeek day;
        int hour;

        public CheckIn(DayOfWeek day, int hour)
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
