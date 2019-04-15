using System;
using System.Collections.Generic;

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
            int participants = 0;
            foreach (CheckIn checkIn in checkIns)
            {
                if (checkIn.NeedColdMeal(startingDay,startingHour))
                {
                    participants += 1;
                }
            }
            return participants;
        }
    }
}