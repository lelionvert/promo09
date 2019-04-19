using System;

namespace Socrates
{
    public class Registration
    {
        private readonly Period _period;
        public Room Room { get; private set; }

        public Registration(Period period, Room room)
        {
            Room = room;
            _period = period;
        }

        internal int CountNumberOfMeals(int defaultNumberOfMeals, Period mealsLimitPeriod)
        {
            int numberOfMeals = defaultNumberOfMeals;
            if (_period.IsDuring(mealsLimitPeriod) || _period.IsInverseOverlaping(mealsLimitPeriod))
            {
                numberOfMeals--;
            }

            if (_period.IsOverlaping(mealsLimitPeriod) || _period.IsDuring(mealsLimitPeriod))
            {
                numberOfMeals--;
            }
            return numberOfMeals;
        }
    }
}