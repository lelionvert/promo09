using System;

namespace ColdMeals.Core
{
    public class Participant
    {
        private string _name;
        private DateTime _arrivedDate;

        public static Participant CreateParticipant(string name, DateTime arrivedDate)
        {
            return new Participant(name, arrivedDate);
        }

        private Participant(string name, DateTime arrivedDate)
        {
            this._name = name;
            this._arrivedDate = arrivedDate;
        }

        public bool IsArrivingTheStartDay()
        {
            return this._arrivedDate < new DateTime(2019, 11, 19);
        }

        public bool IsArrivingBeforeOrAt21h()
        {
            return _arrivedDate <= new DateTime(2019,11,18,21,00,00);
        }
    }
}