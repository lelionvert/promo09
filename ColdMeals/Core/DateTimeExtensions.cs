using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socrates
{
    static class DateTimeExtensions
    {


        public static Boolean IsAfterStart(this DateTime date, Period period)
        {
            return period.IsAfter(date);
        }

        public static Boolean IsAfterEnd(this DateTime date, Period period)
        {
            return !IsBeforeEnd(date, period);
        }

        public static Boolean IsBeforeEnd(this DateTime date, Period period)
        {
            return period.IsBefore(date);
        }

        public static Boolean IsBeforeStart(this DateTime date, Period period)
        {
            return !IsAfterStart(date, period);
        }



    }
}
