using System;

namespace Socrates
{
    public class Period
    {
        private readonly DateTime _start;
        private readonly DateTime _end;

        public Period(DateTime start, DateTime end)
        {
            _start = start;
            _end = end;
        }

        public Boolean IsAfter(DateTime date)
        {
            return _start > date;
        }
        public Boolean IsBefore(DateTime date)
        {
            return _end < date;
        }
        public Boolean Contains(DateTime date)
        {
            return _start < date && _end > date;
        }

        public int CountNumberOfDays()
        {
            return _end.Date.Subtract(_start.Date).Days;
        }
    }
}