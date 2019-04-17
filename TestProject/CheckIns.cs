using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrance
{
    public class CheckIns
    {
        List<DayHour> checkIns;

        public CheckIns()
        {
            checkIns = new List<DayHour>();
        }

        public void Add(DayHour checkIn)
        {
            checkIns.Add(checkIn);
        }
        
        public int CountSameDayAfter(DayOfWeek day, int hour)
        {
            return GetCheckInsSameDayAfter(day,hour).Count();
        }

        private IEnumerable<DayHour> GetCheckInsSameDayAfter(DayOfWeek day, int hour)
        {
            return checkIns.Where(checkIn =>
            checkIn.IsLaterTheSameDay(day, hour));
        }
    }
}
