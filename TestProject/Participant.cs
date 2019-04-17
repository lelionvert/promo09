using System;

namespace SocratesFrance
{
    public class Participant
    {
        private readonly DayHour checkIn;
        private readonly DayHour checkOut;
        private readonly Priceable accommodation;
        
        public Participant(DayHour checkIn = null, DayHour checkOut = null, Priceable accommodation = null)
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

        
        public int ComputeMealCount()
        {
            int mealCount = 6;

            if (checkOut.IsSooner(new DateTime(2019,04,28,12,0,0)))
            {
                mealCount--;
            }
            if (checkIn.IsLater(new DateTime(2019, 04, 25, 21, 0, 0)))
            {
                mealCount--;
            }
            return mealCount;
        }
    }
}