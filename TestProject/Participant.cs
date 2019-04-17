
using System;

namespace SocratesFrance
{
    public enum Accommodation { SINGLE, DOUBLE, TRIPLE, NO_ACCOMODATION}
    public class Participant
    {
        private readonly DayHour checkIn;
        private readonly DayHour checkOut;
        private readonly Accommodation accommodation;
        
        public Participant(DayHour checkIn = null, DayHour checkOut = null, Accommodation accomodation = Accommodation.NO_ACCOMODATION)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.accommodation = accomodation;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }

        public int ComputeTotalPrice()
        {
            if (accommodation == Accommodation.TRIPLE)
                return 410 + 6 * 40;
            int accommodationPrice = 610;
            if (accommodation == Accommodation.DOUBLE)
                accommodationPrice = 510;
            return accommodationPrice + 6 * 40;
        }
    }
}