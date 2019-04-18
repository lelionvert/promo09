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
        private Dictionary<Room, int> _prices;
        private readonly Period _mealsLimitPeriod;

        public Organisation(int mealPrice,
            Dictionary<Room, int> prices, Period mealsLimitPeriod)
        {
            _mealPrice = mealPrice;
            _prices = prices;
            _mealsLimitPeriod = mealsLimitPeriod;
            _nbMeals = CountNbMeals();

        }

        private int CountNbMeals()
        {
            const int NbMealsByDay = 2;
            return _mealsLimitPeriod.CountNumberOfDays() * NbMealsByDay;
        }

        public int CalculatePrice(Registration registration)
        {
            return _prices[registration.Room] + CalculatePriceMeals(registration);
        }

        private int CalculatePriceMeals(Registration registration)
        {
            return registration.CountNumberOfMeals(_nbMeals, _mealsLimitPeriod) * _mealPrice;
        }
    }
}
