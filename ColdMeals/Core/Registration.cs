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