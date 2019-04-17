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

        public Organisation(int nbMeals, int priceByMeal)
        {
            _nbMeals = nbMeals;
            _priceByMeal = priceByMeal;
        }

        public int CalculatePrice(Participant participant)
        {
            return (int)participant.AccomodationChoice + _nbMeals * _priceByMeal;
        }
    }
}
