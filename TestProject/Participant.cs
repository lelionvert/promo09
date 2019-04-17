
using System;

namespace SocratesFrance
{
    public class Accommodation
    {
        public enum AccommodationEnum { SINGLE, DOUBLE, TRIPLE, NO_ACCOMODATION }

        AccommodationEnum type;
        int price;

        public Accommodation(AccommodationEnum type, int price)
        {
            this.type = type;
            this.price = price;
        }

        public int Price { get => price; private set => price = value; }
    }

    public class Participant
    {
        private readonly DayHour checkIn;
        private readonly DayHour checkOut;
        private readonly Accommodation accommodation;
        
        public Participant(DayHour checkIn = null, DayHour checkOut = null, Accommodation accommodation = null)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.accommodation = accommodation;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }

        public int ComputeTotalPrice()
        {
            int mealCount = 6;

            if(checkIn.IsLaterTheSameDay(DayOfWeek.Thursday, 21))
            {
                mealCount--;
            }
            return accommodation.Price + mealCount * 40;
        }
    }
}