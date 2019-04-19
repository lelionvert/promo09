using System;

namespace Socrates
{
    public class Registration
    {
        private readonly DateTime _checkin;
        private readonly DateTime _checkout;
        public Room Room { get; private set; }

        public Registration(DateTime checkin, DateTime checkout, Room room)
        {
            _checkin = checkin;
            _checkout = checkout;
            Room = room;
        }

        internal int CountNumberOfMeals(int defaultNumberOfMeals,
            Period mealsLimitPeriod)
        {
            int numberOfMeals = defaultNumberOfMeals;
            if (_checkin.IsAfterStart(mealsLimitPeriod))
            {
                numberOfMeals--;
            }

            if (_checkout.IsBeforeEnd(mealsLimitPeriod))
            {
                numberOfMeals--;
            }
            return numberOfMeals;
        }
    }
}