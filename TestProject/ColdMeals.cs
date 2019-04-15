using System;

namespace SocratesFrance
{
    public class ColdMeals
    {
        DayOfWeek startingDay;
        int startingHour;
        CheckIns checkIns;

        public ColdMeals(DayOfWeek startingDay, int startingHour, CheckIns checkIns)
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