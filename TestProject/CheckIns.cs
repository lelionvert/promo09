using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrance
{
    public class CheckIns
    {
        List<CheckIn> checkIns;

        public CheckIns()
        {
            checkIns = new List<CheckIn>();
        }

        public void Add(CheckIn checkIn)
        {
            checkIns.Add(checkIn);
        }
        
        public int CountSameDayAfter(DayOfWeek day, int hour)
        {
            return GetCheckInsSameDayAfter(day,hour).Count();
        }

        private IEnumerable<CheckIn> GetCheckInsSameDayAfter(DayOfWeek day, int hour)
        {
            return checkIns.Where(checkIn =>
            checkIn.IsLaterTheSameDay(day, hour));
        }
    }
}
