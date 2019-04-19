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
            return date > _start;
        }
        public Boolean IsBefore(DateTime date)
        {
            return date < _end;
        }

        public int CountNumberOfDays()
        {
            return _end.Date.Subtract(_start.Date).Days;
        }
    }
}