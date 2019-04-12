using System;

namespace SocratesFranceTest
{
    public class ColdMeals
    {
        public static int GetParticipantNumber()
        {
            return 0;
        }

        public static int GetParticipantNumber(DayOfWeek thursday, int v)
        {
            if(v == 21)
            {
                return 1;
            }
            return 0;
        }
    }
}