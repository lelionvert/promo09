using System;

namespace ColdMeals.Core
{
    public class Participant
    {
        private DateTime _checkinDate;
        private DateTime _checkoutDate;
        private AccomodationChoice _accomodationChoice;

        public Participant(DateTime checkinDate, DateTime checkoutDate, AccomodationChoice accomodationChoice)
        {
            _checkinDate = checkinDate;
            _checkoutDate = checkoutDate;
            _accomodationChoice = accomodationChoice;
        }

        public int CalculatePrice()
        {
            if (_accomodationChoice == AccomodationChoice.NoAccomodation)
            {
                return 480;
            }
            if (_accomodationChoice == AccomodationChoice.Double)
            {
                return 750;
            }
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