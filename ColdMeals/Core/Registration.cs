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
            if (!mealsLimitPeriod.IsAfter(_checkin))
            {
                nbOfMeals--;
            }

            if (!mealsLimitPeriod.IsBefore(_checkout))
            {
                nbOfMeals--;
            }
            return nbOfMeals;
        }
    }
}