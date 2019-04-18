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

        internal int GetNumberOfMeals(int defaultNbOfMeals, DateTime firstMealLimit, DateTime lastMealLimit)
        {
            int nbOfMeals = defaultNbOfMeals;
            if (_checkinDate >= firstMealLimit)
            {
                nbOfMeals--;
            }

            if (_checkoutDate <= lastMealLimit)
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