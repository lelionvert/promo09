using System;

namespace SocratesFrance
{
    public class ColdMeals
    {
        public static int GetParticipantNumber()
        {
            return 0;
        }

        public static int GetParticipantNumber(DayOfWeek day, int hour)
        {
            if (day == DayOfWeek.Thursday && hour >= 21)
            {
                return 1;
            }
            return GetParticipantNumber();
        }

        public static int GetParticipantNumber(DayOfWeek thursday1, int v1, DayOfWeek thursday2, int v2)
        {
            return 0;
        }
    }
}