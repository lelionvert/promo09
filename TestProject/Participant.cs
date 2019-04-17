
using System;

namespace SocratesFrance
{
    public enum Choice { SINGLE, DOUBLE}
    public class Participant
    {
        private DayHour checkIn;
        private DayHour checkOut;
        private readonly Choice dOUBLE;

        public Participant(DayHour checkIn = null)
        {
            this.checkIn = checkIn;
        }

        public Participant(DayHour checkIn, DayHour checkOut, Choice dOUBLE)
        {
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.dOUBLE = dOUBLE;
        }

        public bool HasCheckin()
        {
            return checkIn != null;
        }

        public int ComputeTotalPrice()
        {
            if (dOUBLE == Choice.DOUBLE)
                return 510 + 6 * 40;
            return 610 + 6 * 40;
        }
    }
}