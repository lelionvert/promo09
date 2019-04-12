using System;

namespace SocratesFrance
{
    public class ColdMeals
    {
        public static int GetParticipantNumber()
        {
            return 0;
        }

        public static int GetParticipantNumber(DayOfWeek thursday, int hour)
        {
            if(hour == 21)
            {
                return 1;
            }
            return GetParticipantNumber();
        }
    }
}