﻿using System;

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
            if (_checkinDate >= new DateTime(2019, 11, 18, 21, 00, 00) || _checkoutDate <= new DateTime(2019, 11, 21, 12, 00, 00))
            {
                return --defaultNbOfMeals;
            }
            
            return defaultNbOfMeals;
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