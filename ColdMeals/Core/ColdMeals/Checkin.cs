using System;

namespace Socrates
{
    public class Checkin
    {
        private DateTime? _arrivedDate;

        public static Checkin CreateCheckin(DateTime? arrivedDate)
        {
            return new Checkin(arrivedDate);
        }

        private Checkin(DateTime? arrivedDate)
        {
            _arrivedDate = arrivedDate;
        }

        public bool IsArrivingBetween(DateTime startDate, DateTime endDate)
        {
            return _arrivedDate >= startDate && _arrivedDate < endDate;
        }
    }


}