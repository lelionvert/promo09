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
            if(hour == 22)
            {
                return 1;
            }
            if(hour == 21)
            {
                return 1;
            }
            return GetParticipantNumber();
        }
    }
}