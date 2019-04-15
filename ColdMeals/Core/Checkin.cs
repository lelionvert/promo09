using System;

namespace ColdMeals.Core
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

        public bool IsArrivingTheStartDay(DateTime startedDate)
        {
            bool isStartedDay = _arrivedDate >= startedDate.Date && _arrivedDate < startedDate.Date.AddDays(1);
            return isStartedDay;
            //return this._arrivedDate < startedDate.Date.AddDays(1);
        }

        public bool IsArrivingAfter21hTheStartDay(DateTime startedDate)
        {
            return _arrivedDate >= startedDate && IsArrivingTheStartDay(startedDate);
        }
    }

}