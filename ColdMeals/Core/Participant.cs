using System;

namespace ColdMeals.Core
{
    public class Participant
    {
        private DateTime checkinDate;
        private DateTime checkoutDate;
        private object simple;

        public Participant(DateTime checkinDate, DateTime checkoutDate, object simple)
        {
            this.checkinDate = checkinDate;
            this.checkoutDate = checkoutDate;
            this.simple = simple;
        }

        public int CalculatePrice()
        {
            return 850; 
        }

    }

    public enum AccomodationChoice {

        Single = 610,
        Double = 510,
        Triple = 410,
        NoAccomodation = 240
        
    }
}