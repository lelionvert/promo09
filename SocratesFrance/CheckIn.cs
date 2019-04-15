using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocratesFrance
{
    public class CheckIn
    {
        DayOfWeek day;
        int hour;

        public CheckIn(DayOfWeek day, int hour)
        {
            this.day = day;
            this.hour = hour;
        }

        public bool IsLaterTheSameDay(DayOfWeek startingDay, int startingHour)
        {
            return startingDay == day && startingHour <= hour;
        }
    }
}
