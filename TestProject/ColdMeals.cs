using System;

namespace SocratesFrance
{
    public class ColdMeals
    {
        DayOfWeek startingDay;
        int startingHour;
        DayHours checkIns;

        public ColdMeals(DayOfWeek startingDay, int startingHour, DayHours checkIns)
        {
            this.startingDay = startingDay;
            this.startingHour = startingHour;
            this.checkIns = checkIns;
        }

        public int Count()
        {
            return checkIns.CountSameDayAfter(startingDay,startingHour);
        }
    }
}