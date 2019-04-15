using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ColdMeals.Core
{
    public class Checkins
    {
        private readonly List<Checkin> _checkins;

        public Checkins()
        {
            _checkins = new List<Checkin>();
        }

        public void AddCheckin(DateTime? arrivedDate)
        {
            Checkin checkin = Checkin.CreateCheckin(arrivedDate);
            _checkins.Add(checkin);
        }
        public int CountBetween(DateTime startDate, DateTime endDate)
        {
            return _checkins.Where(checkin => checkin.IsArrivingBetween(startDate, endDate))
                           .Count();
        }
    }
}