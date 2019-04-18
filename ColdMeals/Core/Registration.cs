using System;

namespace Socrates
{
    public class Registration
    {
        private readonly DateTime _checkin;
        private readonly DateTime _checkout;
        private readonly Good _good;

        internal Good Good
        {
            get => _good;
        }

        public Registration(DateTime checkin, DateTime checkout, Good good)
        {
            _checkin = checkin;
            _checkout = checkout;
            _good = good;
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