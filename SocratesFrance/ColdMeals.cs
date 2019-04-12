using System;
using System.Collections.Generic;

namespace SocratesFrance
{
    public class ColdMeals
    {
        public class CheckIn
        {
            DayOfWeek day;
            int hour;

            public CheckIn(DayOfWeek day, int hour)
            {
                this.Day = day;
                this.Hour = hour;
            }

            public DayOfWeek Day { get => day; private set => day = value; }
            public int Hour { get => hour; private set => hour = value; }
        }

        public static int GetParticipantNumber(List<CheckIn> checkIns)
        {
            int participants = 0;
            foreach (CheckIn checkIn in checkIns)
            {
                if (checkIn.Day == DayOfWeek.Thursday && checkIn.Hour >= 21)
                {
                    participants += 1;
                }
            }
            return participants;
        }
    }
}