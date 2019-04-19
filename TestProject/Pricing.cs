using System;

namespace SocratesFrance
{
    public class Pricing
    {
        Priceable meal;

        public Pricing(Priceable meal)
        {
            this.meal = meal;
        }

        public int ComputeTotalPrice(Registration registration, int mealCount)
        {
            return registration.GetAccomodationPrice() + 
                mealCount * meal.Price;
        }
    }
}
