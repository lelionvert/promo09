using System;

namespace SocratesFrance
{
    public class Registration
    {
        private readonly DayHour checkIn;
        private readonly DayHour checkOut;
        private readonly Room accommodation;

        public Registration(Room accommodation, DayHour checkIn = null, DayHour checkOut = null)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.accommodation = accommodation;
        }

        public DayHour CheckOut
        {
            get
            {
                return this.checkOut;
            }
        }

        public DayHour CheckIn
        {
            get
            {
                return this.checkIn;
            }
        }


        public Room Accommodation
        {
            get
            {
                return this.accommodation;
            }
        }

        public bool HasCheckin()
        {
            return checkIn != null;
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