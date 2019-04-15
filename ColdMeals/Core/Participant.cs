using System;

namespace ColdMeals.Core
{
    public class Participant
    {
        private string _name;
        private DateTime? _arrivedDate;

        public static Participant CreateParticipant(string name, DateTime? arrivedDate)
        {
            return new Participant(name, arrivedDate);
        }

        private Participant(string name, DateTime? arrivedDate)
        {
            this._name = name;
            this._arrivedDate = arrivedDate;
        }

        public bool IsArrivingTheStartDay(DateTime startedDate)
        {
            return this._arrivedDate < startedDate.Date.AddDays(1);
        }

        public bool IsArrivingAfter21hTheStartDay(DateTime startedDate)
        {
            return _arrivedDate >= startedDate && IsArrivingTheStartDay(startedDate);
        }
    }

}