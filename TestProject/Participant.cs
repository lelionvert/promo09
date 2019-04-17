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

            if (checkOut.IsSoonerTheSameDay(DayOfWeek.Sunday, 12))
            {
                mealCount--;
            }
            if (checkIn.IsLaterTheSameDay(DayOfWeek.Thursday, 21))
            {
                mealCount--;
            }
            return mealCount;
        }
    }
}