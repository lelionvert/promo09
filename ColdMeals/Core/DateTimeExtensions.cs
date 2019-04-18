using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socrates
{
    static class DateTimeExtensions
    {
        public static Boolean IsAfter(this DateTime date, Period period)
        {
            return period.IsAfter(date);
        }

        public static Boolean IsBefore(this DateTime date, Period period)
        {
            return period.IsBefore(date);
        }
    }
}
