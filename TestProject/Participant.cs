using System;

namespace SocratesFrance
{
    public class Participant
    {
        private CheckIn checkIn;

        public Participant()
        {
        }

        public Participant(CheckIn checkIn)
        {
            this.checkIn = checkIn;
        }

        public bool HasCheckin()
        {
            if (checkIn != null)
                return true;
            return false;
        }
    }
}