using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public readonly List<Checkin> Checkins;
        private readonly DateTime _startDate;
        private readonly DateTime _coldMealStartDate;

        public Socrates(DateTime startedDate)
        {
            Checkins = new List<Checkin>();
            _startDate = startedDate;
        }

        public Socrates(DateTime startedDate, DateTime coldMealStartDate)
        {
            Checkins = new List<Checkin>();
            _coldMealStartDate = coldMealStartDate;
            _startDate = startedDate;
        }

        public void AddCheckin(DateTime? arrivedDate)
        {
            Checkin checkin = Checkin.CreateCheckin(arrivedDate);
            Checkins.Add(checkin);
        }
        public int CountNumberOfColdMeals()
        {
            DateTime coldMealEndDate = _startDate.Date.AddDays(1);
            return Checkins.Where(checkin => checkin.IsArrivingBetween(_coldMealStartDate, coldMealEndDate))
                           .Count();
        }
    }
}