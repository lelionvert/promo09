using System;

namespace SocratesFrance
{
    public class Billing
    {
        Priceable meal;

        public Billing(Priceable meal)
        {
            this.meal = meal;
        }

        public int ComputeTotalPriceForRegistration(Registration registration, int mealCount)
        {
            return registration.GetAccomodationPrice() + 
                mealCount * meal.Price;
        }
    }
}
