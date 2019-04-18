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

        internal int CountNumberOfMeals(int defaultNbOfMeals,
            Period mealsLimitPeriod)
        {
            int nbOfMeals = defaultNbOfMeals;
            if (!_checkin.IsAfter(mealsLimitPeriod))
            {
                nbOfMeals--;
            }

            if (!_checkout.IsBefore(mealsLimitPeriod))
            {
                nbOfMeals--;
            }
            return nbOfMeals;
        }
    }
}