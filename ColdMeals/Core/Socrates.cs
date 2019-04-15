using System;
using System.Collections.Generic;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public readonly List<Checkin> Checkins;
        private readonly DateTime _startDate;

        public Socrates(DateTime startedDate)
        {
            Checkins = new List<Checkin>();
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
                if (checkin.IsArrivingAfter21hTheStartDay(_startDate)) count++;
            }
            return count;
        }
    }
}