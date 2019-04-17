
using System;

namespace SocratesFrance
{
    public class Participant
    {
        private CheckIn checkIn;
        private CheckIn checkOut;

        public Participant(CheckIn checkIn = null)
        {
            this.checkIn = checkIn;
        }

        public Participant(CheckIn checkIn, CheckIn checkOut)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }

        public int ComputeTotalPrice()
        {
            return 850;
        }
    }
}