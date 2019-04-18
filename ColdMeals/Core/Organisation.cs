using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socrates
{
    public class Organisation
    {
        private readonly int _nbMeals;
        private readonly DateTime _firstMealLimit;
        private readonly DateTime _lastMealLimit;
        private Dictionary<Good, int> _prices;

        public Organisation(int nbMeals, DateTime firstMealLimit, DateTime lastMealLimit,
            Dictionary<Good, int> prices)
        {
            _nbMeals = nbMeals;
            _firstMealLimit = firstMealLimit;
            _lastMealLimit = lastMealLimit;
            _prices = prices;
        }

        public int CalculatePrice(Registration registration)
        {
            return _prices[registration.Good] + CalculatePriceMeals(registration);
        }

        private int CalculatePriceMeals(Registration registration)
        {
            return registration.CountNumberOfMeals(_nbMeals, _firstMealLimit, _lastMealLimit) * _prices[Good.Meal];
        }
    }
}
