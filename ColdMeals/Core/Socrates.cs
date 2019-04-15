using System;
using System.Collections;
using System.Collections.Generic;

namespace ColdMeals.Core
{
    public class Socrates
    {
        public readonly List<Checkin> Checkins;
        private readonly DateTime _startDate;
        private readonly int _coldMealStartHour;
        

        public Socrates(DateTime startedDate)
        {
            Checkins = new List<Checkin>();
            _startDate = startedDate;
        }
        public Socrates(DateTime startedDate, int coldMealStartHour)
        {
            Checkins = new List<Checkin>();
            _coldMealStartHour = coldMealStartHour;
            _startDate = startedDate;
        }
        public void AddCheckin(DateTime? arrivedDate)
        {
            Checkin checkin = Checkin.CreateCheckin(arrivedDate);
            Checkins.Add(checkin);
        }

        //public int CountNumberOfColdMeals()
        //{
        //    int count = 0;
        //    foreach (Checkin checkin in Checkins)
        //    {
        //        if (checkin.IsArrivingAfter21hTheStartDay(_startDate)) count++;
        //    }
        //    return count;
        //}

        public int CountNumberOfColdMeals()
        {
            int count = 0;
            //FIXME dégueu
            DateTime coldMealStar = new DateTime(_startDate.Year,_startDate.Month, _startDate.Day, _coldMealStartHour,00,00);
            foreach (Checkin checkin in Checkins)
            {
                if (checkin.IsArrivingBetween(coldMealStar, _startDate.Date.AddDays(1))) count++;
            }
            return count;
        }
    }

    //public struct StartHour
    //{
    //    public int hour;
    //}


}