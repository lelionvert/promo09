using System;

namespace ColdMeals
{
    public class Participant
    {
        private readonly DateTime _checkinDate;
        private readonly DateTime _checkoutDate;
        private readonly AccomodationChoice _accomodationChoice;

        internal AccomodationChoice AccomodationChoice
        {
            get => _accomodationChoice;
        }

        public Participant(DateTime checkinDate, DateTime checkoutDate, AccomodationChoice accomodationChoice)
        {
            _checkinDate = checkinDate;
            _checkoutDate = checkoutDate;
            _accomodationChoice = accomodationChoice;
        }

        internal int GetNumberOfMeals(int defaultNbOfMeals)
        {
            int nbOfMeals = defaultNbOfMeals;
            if (_checkinDate >= new DateTime(2019, 11, 19, 00, 00, 00) )
            {
                nbOfMeals--;
            }

            if ( _checkoutDate <= new DateTime(2019, 11, 21, 12, 00, 00))
            {
                nbOfMeals--;

            }

            return nbOfMeals;
        }
    }

    public enum AccomodationChoice
    {
        Single,
        Double,
        Triple,
        NoAccomodation
    }
}