using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdMeals
{
    public class Organisation
    {
        private readonly int _nbMeals;
        private readonly int _priceByMeal;
        private readonly DateTime _firstMealLimit;
        private readonly DateTime _lastMealLimit;
        private Dictionary<AccomodationChoice, int> _accomodationPrice;

        public Organisation(int nbMeals, int priceByMeal, DateTime firstMealLimit, DateTime lastMealLimit)
        {
            _nbMeals = nbMeals;
            _priceByMeal = priceByMeal;
            _firstMealLimit = firstMealLimit;
            _lastMealLimit = lastMealLimit;
            SetUpAccomodationPrices();
        }

        private void SetUpAccomodationPrices()
        {
            _accomodationPrice = new Dictionary<AccomodationChoice, int>
            {
                { AccomodationChoice.Single, 610 },
                { AccomodationChoice.Double, 510 },
                { AccomodationChoice.Triple, 410 },
                { AccomodationChoice.NoAccomodation, 240 }
            };
        }

        public int CalculatePrice(Participant participant)
        {
            return _accomodationPrice[participant.AccomodationChoice] + CalculatePriceMeals(participant);
        }

        private int CalculatePriceMeals(Participant participant)
        {
            return participant.GetNumberOfMeals(_nbMeals, _firstMealLimit, _lastMealLimit) * _priceByMeal;
        }
    }
}
