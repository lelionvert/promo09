using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrance
{
    public class DayHours
    {
        List<DayHour> checkIns;

        public DayHours()
        {
            checkIns = new List<DayHour>();
        }
        
        public DayHours(params DayHours[] dayHours)
        {
            checkIns = new List<DayHour>();
            
            foreach(DayHours dh in dayHours)
            {
                checkIns.AddRange(dh.checkIns);
            }
        }

        public void Add(DayHour checkIn)
        {
            checkIns.Add(checkIn);
        }

        public void AddAll(DayHours dayHours)
        {
            this.checkIns.AddRange(dayHours.checkIns);
        }

        public int CountSameDayAfter(DayHour dayHour)
        {
            return GetCheckInsSameDayAfter(dayHour).Count();
        }

        private IEnumerable<DayHour> GetCheckInsSameDayAfter(DayHour dayHour)
        {
            return checkIns.Where(checkIn =>
            checkIn.IsLaterTheSameDay(dayHour));
        }

        public int Count()
        {
            return this.checkIns.Count();
        }
    }
}
