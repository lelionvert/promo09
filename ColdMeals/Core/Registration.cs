using System;

namespace Socrates
{
    public class Registration
    {
        private readonly DateTime _checkin;
        private readonly DateTime _checkout;
        private readonly Room _room;

        internal Room Room
        {
            get => _room;
        }

        public Registration(DateTime checkin, DateTime checkout, Room room)
        {
            _checkin = checkin;
            _checkout = checkout;
            _room = room;
        }

        internal int CountNumberOfMeals(int defaultNbOfMeals, DateTime firstMealLimit, DateTime lastMealLimit)
        {
            int nbOfMeals = defaultNbOfMeals;
            if (_checkin >= firstMealLimit)
            {
                nbOfMeals--;
            }

            if (_checkout <= lastMealLimit)
            {
                nbOfMeals--;
            }
            return nbOfMeals;
        }
    }
}