using System;

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

        public static int GetParticipantNumber()
        {
            return 0;
        }

        public static int GetParticipantNumber(CheckIn checkIn)
        {
            if (checkIn.Day == DayOfWeek.Thursday && checkIn.Hour >= 21)
            {
                return 1;
            }
            return GetParticipantNumber();
        }

        public static int GetParticipantNumber(CheckIn checkIn1, CheckIn checkIn2)
        {
            if(checkIn1.Day == DayOfWeek.Friday)
            {
                return GetParticipantNumber();
            }
            if(checkIn1.Hour >= 21)
            {
                return 1;
            }
            if (checkIn2.Day == DayOfWeek.Thursday && checkIn2.Hour >= 21)
            {
                return 1;
            }
            return GetParticipantNumber();
        }
    }
}