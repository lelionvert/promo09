using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFrance
{
    public class ColdMeals
    {
        DayOfWeek startingDay;
        int startingHour;

        public ColdMeals(DayOfWeek startingDay, int startingHour)
        {
            this.startingDay = startingDay;
            this.startingHour = startingHour;
        }

        public int GetNumber(List<CheckIn> checkIns)
        {
            return GetElligibleCheckIns(checkIns).Count();
        }

        private IEnumerable<CheckIn> GetElligibleCheckIns(List<CheckIn> checkIns)
        {
            return checkIns.Where(checkIn => 
            checkIn.IsLaterTheSameDay(startingDay, startingHour));
        }
    }
}