using System;

namespace SocratesFrance
{
    public class DayHour
    {
        DateTime date;
        DayOfWeek day;
        int hour;

        public DayHour(DayOfWeek day, int hour)
        {
            this.day = day;
            this.hour = hour;
        }

        public DayHour(DateTime date)
        {
            this.date = date;
        }

        public bool IsLaterTheSameDay(DateTime date)
        {
            return this.date.DayOfWeek == date.DayOfWeek && this.date >= date;
        }

        public bool IsLater(DateTime date)
        {
            return this.date >= date;
        }

        public bool IsLaterTheSameDay(DayOfWeek day, int hour)
        {
            return day == this.day && this.hour >= hour;
        }

        public bool IsSooner(DateTime date)
        {
            return this.date < date;
        }

        public bool IsSoonerTheSameDay(DayOfWeek day,int hour)
        {
            return day == this.day && this.hour < hour;
        }

        public bool IsAnotherDay(DayOfWeek day)
        {
            return day != this.day;
        }

        public bool IsAnotherDay(DateTime date)
        {
            return this.date.DayOfWeek == date.DayOfWeek;
        }
    }
}
