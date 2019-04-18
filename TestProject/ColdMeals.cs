using System;

namespace SocratesFrance
{
    public class ColdMeals
    {
        DayHours checkIns;
        DayHour startingDate;

        public ColdMeals(DayHour startingDate, DayHours checkIns)
        {
            this.startingDate = startingDate;
            this.checkIns = checkIns;
        }

        public int Count()
        {
            return checkIns.CountSameDayAfter(startingDate);
        }
    }
}