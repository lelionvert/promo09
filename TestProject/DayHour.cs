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

        public bool IsLaterTheSameDay(DayOfWeek day, int hour)
        {
            return day == this.day && this.hour >= hour;
        }

        public bool IsSoonerTheSameDay(DayOfWeek day,int hour)
        {
            return !IsLaterTheSameDay(day, hour);
        }
    }
}
