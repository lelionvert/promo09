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

        public int ComputeTotalPrice(Registration registration, DateTime sessionStartTime, DateTime sessionEndTime)
        {
            return registration.GetAccomodationPrice() + 
                registration.ComputeMealCount(sessionStartTime, sessionEndTime) * meal.Price;
        }
    }
}
