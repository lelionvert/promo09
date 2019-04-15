using System;
using System.Collections;
using System.Collections.Generic;

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
            int count = 0;
            foreach (Checkin checkin in Checkins)
            {
                if (checkin.IsArrivingBetween(_coldMealStartDate, _startDate.Date.AddDays(1))) count++;
            }
            return count;
        }
    }
}