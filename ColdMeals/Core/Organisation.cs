using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socrates
{
    public class Organisation
    {
        private readonly int _maxNumberOfMeals;
        private readonly Price _mealPrice;
        private Dictionary<Room, Price> _prices;
        private readonly Period _mealsLimitPeriod;

        public Organisation(Price mealPrice,
            Dictionary<Room, Price> prices, Period mealsLimitPeriod)
        {
            _mealPrice = mealPrice;
            _prices = prices;
            _mealsLimitPeriod = mealsLimitPeriod;
            _maxNumberOfMeals = CountMaxNumberOfMeals();
        }

        private int CountMaxNumberOfMeals()
        {
            const int NbMealsByDay = 2;
            return _mealsLimitPeriod.CountNumberOfDays() * NbMealsByDay;
        }

        public Price CalculatePrice(Registration registration)
        {
            return _prices[registration.Room].Add(CalculatePriceMeals(registration));
        }

        private Price CalculatePriceMeals(Registration registration)
        {
            return _mealPrice.Times(registration.CountNumberOfMeals(_maxNumberOfMeals, _mealsLimitPeriod));
        }
    }
}
