using System;

namespace SocratesFrance
{
    public class Registration
    {
        private readonly DayHour checkIn;
        private readonly DayHour checkOut;
        private readonly Priceable accommodation;
        
        public Registration(DayHour checkIn = null, DayHour checkOut = null, Priceable accommodation = null)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.accommodation = accommodation;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }

        public int GetAccomodationPrice()
        {
            return accommodation.Price;
        }
        
        public int ComputeMealCount(DateTime startDate, DateTime endDate)
        {
            int mealCount = 6;

            if (checkOut.IsSooner(endDate))
            {
                mealCount--;
            }
            if (checkIn.IsLater(startDate))
            {
                mealCount--;
            }
            return mealCount;
        }
    }
}