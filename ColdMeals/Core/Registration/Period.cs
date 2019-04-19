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

        public bool IsAfter(DateTime date)
        {
            return date > _start;
        }
        public bool IsBefore(DateTime date)
        {
            return date < _end;
        }

        public int CountNumberOfDays()
        {
            return _end.Date.Subtract(_start.Date).Days;
        }

        public bool IsOverlaping(Period periodToCompare)
        {
            return _start < periodToCompare._start && _end < periodToCompare._end;
        }
        public bool IsDuring(Period periodToCompare)
        {
            return _start > periodToCompare._start && _end < periodToCompare._end;
        }

        public bool IsInverseOverlaping(Period periodToCompare)
        {
            return _start > periodToCompare._start && _end > periodToCompare._end;
        }
    }
}