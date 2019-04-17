﻿using System;

namespace ColdMeals
{
    public class Participant
    {
        private readonly DateTime _checkinDate;
        private readonly DateTime _checkoutDate;
        private readonly AccomodationChoice _accomodationChoice;

        internal AccomodationChoice AccomodationChoice { get => _accomodationChoice; }

        public Participant(DateTime checkinDate, DateTime checkoutDate, AccomodationChoice accomodationChoice)
        {
            _checkinDate = checkinDate;
            _checkoutDate = checkoutDate;
            _accomodationChoice = accomodationChoice;
        }

        internal int GetNumberOfMeals(int defaultNbOfMeals)
        {
            if (_checkoutDate.Date == new DateTime(2019, 11, 20) || _checkinDate == new DateTime(2019, 11, 19))
            {
                return --defaultNbOfMeals;
            }
            return defaultNbOfMeals;
        }
    }

    public enum AccomodationChoice
    {
        Single = 610,
        Double = 510,
        Triple = 410,
        NoAccomodation = 240
    }
}