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
        private readonly int _mealPrice;
        private readonly DateTime _firstMealLimit;
        private readonly DateTime _lastMealLimit;
        private Dictionary<Room, int> _prices;

        public Organisation(int mealPrice, DateTime firstMealLimit, DateTime lastMealLimit, Dictionary<Room, int> prices)
        {
            _mealPrice = mealPrice;
            _firstMealLimit = firstMealLimit;
            _lastMealLimit = lastMealLimit;
            _prices = prices;
            _nbMeals = CountNbMeals();

        }

        private int CountNbMeals()
        {
            const int NbMealsByDay = 2;
            return _lastMealLimit.Date.Subtract(_firstMealLimit.Date).Days * NbMealsByDay;
        }

        public int CalculatePrice(Registration registration)
        {
            return _prices[registration.Room] + CalculatePriceMeals(registration);
        }

        private int CalculatePriceMeals(Registration registration)
        {
            return registration.CountNumberOfMeals(_nbMeals, _firstMealLimit, _lastMealLimit) * _mealPrice;
        }
    }
}
